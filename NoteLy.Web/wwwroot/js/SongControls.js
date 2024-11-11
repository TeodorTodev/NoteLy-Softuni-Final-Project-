const audioPlayer = document.getElementById("audioPlayer");
const playPauseBtn = document.getElementById("playPauseBtn");
const progressBar = document.getElementById("progressBar");
const currentTimeDisplay = document.getElementById("currentTime");
const durationDisplay = document.getElementById("duration");
const volumeControl = document.getElementById("volumeControl");

// Play/Pause Button
playPauseBtn.addEventListener("click", function () {
    if (audioPlayer.paused) {
        audioPlayer.play();
        playPauseBtn.innerHTML = '<i class="fa-solid fa-circle-pause"></i>';
    } else {
        audioPlayer.pause();
        playPauseBtn.innerHTML = '<i class="fa-solid fa-circle-play"></i>';
    }
});

// Update Progress Bar as the song plays
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