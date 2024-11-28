const audioPlayer = document.getElementById("audioPlayer");
const playPauseBtn = document.getElementById("playPauseBtn");
const progressBar = document.getElementById("progressBar");
const currentTimeDisplay = document.getElementById("currentTime");
const durationDisplay = document.getElementById("duration");
const volumeControl = document.getElementById("volumeControl");
let currentTime = 0;
let isPlaying = false;
let previousId = "";

// Play/Pause Button
playPauseBtn.addEventListener('click', function () {
    if (isPlaying) {
        // Pause and save current time
        currentTime = audioPlayer.currentTime;
        audioPlayer.pause();
        playPauseBtn.innerHTML = '<i class="fa-solid fa-circle-play"></i>';
    } else {
        if (previousId !== window.id) {
            console.log(`Song changed: Previous: "${previousId}", Now: "${window.id}"`);
            previousId = window.id; // Update the previousTitle
            currentTime = 0; // Reset playback position for new song
        } else {
            console.log(`Resuming: "${window.id}"`);
        }
        // Add a random query string to bypass the cache
        const timestamp = new Date().getTime();
        audioSource.src = `Mp3Songs/output.mp3?timestamp=${timestamp}`;
        // Load the audio source and play from the saved position
        audioPlayer.load();
        audioPlayer.currentTime = currentTime;
        audioPlayer.play();
        const songLoadingInfoDiv = document.getElementById("loadingSongInfoDiv");
        const songLoadingInfo = document.getElementById("loadingSongInfo");
        songLoadingInfoDiv.style.display = "none";
        songLoadingInfo.innerText = "Wait, song is loading...";
        playPauseBtn.innerHTML = '<i class="fa-solid fa-circle-pause"></i>';
    }
    isPlaying = !isPlaying;
});

 /*Update Progress Bar as the song plays*/
audioPlayer.addEventListener("timeupdate", function () {
    const progress = (audioPlayer.currentTime / audioPlayer.duration) * 100;
    progressBar.value = progress;

    // Update current time
    const currentMinutes = Math.floor(audioPlayer.currentTime / 60);
    const currentSeconds = Math.floor(audioPlayer.currentTime % 60);
    currentTimeDisplay.textContent = `${currentMinutes}:${currentSeconds < 10 ? '0' : ''}${currentSeconds}`;

    // Update duration
    const durationMinutes = Math.floor(audioPlayer.duration / 60);
    const durationSeconds = Math.floor(audioPlayer.duration % 60);
    durationDisplay.textContent = `${durationMinutes}:${durationSeconds < 10 ? '0' : ''}${durationSeconds}`;
});

// Seek in the song by changing the progress bar
progressBar.addEventListener("input", function () {
    const seekTime = (progressBar.value / 100) * audioPlayer.duration;
    audioPlayer.currentTime = seekTime;
});

// Volume Control
volumeControl.addEventListener("input", function () {
    audioPlayer.volume = volumeControl.value / 100;
});