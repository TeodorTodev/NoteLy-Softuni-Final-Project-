using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteLy.Data;
using System.Diagnostics;
using System.Text.Json;
using NoteLy.Data.Repository.Interfaces;
using NoteLy.Services.Data.Interfaces;
using Notely.Data.Models;

namespace NoteLy.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongControlsController : ControllerBase
    {
        private readonly NoteLyDbContext dbContext;
        private readonly ISongControlsService songControlsService;
        public SongControlsController(NoteLyDbContext _dbContext, ISongControlsService songControlsService)
        {
            this.dbContext = _dbContext;
            this.songControlsService = songControlsService;
        }

        [HttpGet("ConvertToMp3")]
        public IActionResult ConvertToMp3(int songId)
        {

            Song? song = this.songControlsService.GetSong(songId);
            var songUrl = song.FilePath;

            if (string.IsNullOrEmpty(songUrl))
            {
                return BadRequest("YouTube URL cannot be empty.");
            }

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string pythonScriptPath = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", "..", "wwwroot", "py", "download_mp3.py"));
            string outputFilePath = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", "..", "wwwroot", "Mp3Songs","output"));

            try
            {
                // Start the process for the Python script
                ProcessStartInfo start = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"\"{pythonScriptPath}\" \"{songUrl}\" \"{outputFilePath}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process { StartInfo = start })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    process.OutputDataReceived += (sender, args) => Console.WriteLine("Output: " + args.Data);
                    process.ErrorDataReceived += (sender, args) => Console.WriteLine("Error: " + args.Data);


                    if (process.ExitCode == 0)
                    {
                        string id = ExtractJson(output);
                        return Ok(new { message = "Download and conversion successful!", filePath = outputFilePath, songId = id, songName = song.Name });
                    }
                    else
                    {
                        return StatusCode(500, $"Error: {error}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, $"An exception occurred: {ex.Message}");
            }
        }
        public string ExtractJson(string output)
        {
            int jsonStartIndex = output.IndexOf("{");
            int jsonEndIndex = output.LastIndexOf("}");

            if (jsonStartIndex >= 0 && jsonEndIndex >= 0)
            {
                string jsonString = output.Substring(jsonStartIndex, jsonEndIndex - jsonStartIndex + 1);

                try
                {
                    using (JsonDocument jsonDoc = JsonDocument.Parse(jsonString))
                    {
                        string id = jsonDoc.RootElement.GetProperty("id").GetString();
                        return id;
                    }
                }
                catch (JsonException ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "JSON not found in the output.";
            }
        }
    }
}

public class AudioMetadata
{
    public string Title { get; set; }
}