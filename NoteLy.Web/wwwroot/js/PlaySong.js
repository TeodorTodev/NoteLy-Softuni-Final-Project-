function PlaySong(songId) {
    // Send AJAX request to the server to get the audio URL
    $.ajax({
        url: '/api/SongControls/ConvertToMp3', // The controller action
        type: 'GET',
        data: { songId: songId },
        success: function (data) {
            // Once the URL is received, set it as the source of the audio player
            // document.getElementById("audioSource").src = data;
            // document.getElementById("audioPlayer").load();
            // document.getElementById("audioPlayer").play();
            console.log("hi");
        },
        error: function (error) {
            console.log("Error:", error);
        }
    });
}