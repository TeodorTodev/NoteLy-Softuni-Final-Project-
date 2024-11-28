function PlaySong(songId) {
    let songLoadingInfoDiv = document.getElementById("loadingSongInfoDiv");
    songLoadingInfoDiv.style.display = "block";
    let songLoadingInfo = document.getElementById("loadingSongInfo");
    songLoadingInfo.innerText = "Wait, song is loading...";
    $.ajax({
        url: '/api/SongControls/ConvertToMp3',
        type: 'GET',
        data: { songId: songId },
        success: function (data) {
            let songInfo = document.getElementById("songInfo");
            let songName = document.getElementById("songName");
            songName.innerText = data.songName;
            songInfo.style.display = "flex";
            window.id = data.songId;
            songLoadingInfo.innerText = 'Song Ready to play (if you are playing song press "pause" then "play" to play the song)';
        },
        error: function (error) {
            console.log("Error:", error);
        }
    });
}