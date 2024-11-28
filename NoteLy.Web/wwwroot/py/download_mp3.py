import sys
import json
from yt_dlp import YoutubeDL

def download_mp3(youtube_url, output_path):
    ydl_opts = {
        'format': 'bestaudio/best',
        'postprocessors': [{
            'key': 'FFmpegExtractAudio',
            'preferredcodec': 'mp3',
            'preferredquality': '192',
        }],
        'outtmpl': output_path,
        'verbose': True,  # Enable verbose logging
    }

    with YoutubeDL(ydl_opts) as ydl:

        info = ydl.extract_info(youtube_url, download=False)
        video_id = info.get('id', 'Unknown ID')

        metadata = {
            "id": video_id,
        }

        print(json.dumps(metadata))

        ydl.download([youtube_url])

# This section will be executed when the script is run
if __name__ == "__main__":
    if len(sys.argv) != 3:
        print("Usage: python download_mp3.py <youtube_url> <output_path>")
    else:
        song_url = sys.argv[1]  # URL of the song
        output_file_path = sys.argv[2]  # Path to save the MP3 file
        download_mp3(song_url, output_file_path)