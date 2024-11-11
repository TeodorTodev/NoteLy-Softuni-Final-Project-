using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NoteLy.Data.Models;
using NoteLy.Data;
using System.Diagnostics;
//using NoteLy.Web.ViewModels.Song_Controls;

namespace NoteLy.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongControlsController : ControllerBase
    {
        private readonly NoteLyDbContext dbContext;
        //private readonly UserManager<ApplicationUser> userManager;
        public SongControlsController(NoteLyDbContext _dbContext/*, UserManager<ApplicationUser> _userManager*/)
        {
            this.dbContext = _dbContext;
            //this.userManager = _userManager;
        }

        [HttpGet("ConvertToMp3")]
        public IActionResult ConvertToMp3(/*YouTubeRequest request*/ int songId)
        {

            var song = dbContext.Songs.FirstOrDefault(a => a.Id == songId);

            var songUrl = song.FilePath;

            if (string.IsNullOrEmpty(songUrl))
            {
                return BadRequest("YouTube URL cannot be empty.");
            }

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string pythonScriptPath = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", "..", "wwwroot", "py", "download_mp3.py"));
            //string outputFilePath = Path.Combine("C:\\path\\to\\output\\directory", "output.mp3");
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

                    process.OutputDataReceived += (sender, args) => Console.WriteLine("Output: " + args.Data);//aaaaa
                    process.ErrorDataReceived += (sender, args) => Console.WriteLine("Error: " + args.Data);//aaaaaaa


                    if (process.ExitCode == 0)
                    {
                        return Ok(new { message = "Download and conversion successful!", filePath = outputFilePath });
                    }
                    else
                    {
                        return StatusCode(500, $"Error: {error}");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An exception occurred: {ex.Message}");
            }
        }
    }
}
