function loadSongs(playlistId) {
    $.ajax({
        url: '/Home/SongsSection', // Ensure this matches your route
        type: 'GET',
        data: { playlistId: playlistId },
        success: function (songs) {
            var songsContainer = $('.Songs');
            songsContainer.empty(); // Clear previous songs

            if (songs.length > 0) {
                songs.forEach(function (song, index) {
                    var formattedTime = formatDuration(song.duration); // Function to format duration
                    console.log(song);
                    //songsContainer.append(`
                    //    <div class="Song">
                    //        <p class="SongNumber">${index + 1}</p>
                    //        <img src="Resources/Note.svg" alt="Alternate Text" />
                    //        <span class="SongInfo">
                    //            <p class="Name">${song.name}</p>
                    //            <p class="Artists">${song.artists.join(", ")}</p>
                    //        </span>
                    //        <p class="Duration">${formattedTime}</p>
                    //        <a class="renderComments" onclick="loadComments(${song.id})"><i class="fa-solid fa-comment"></i></a>
                    //        ${song.isCreator ? `
                    //            <div class="SongCardActions">
                    //            <a class="editSong" href="/Song/Edit/${song.id}"><i class="fa-solid fa-pen"></i></a>
                    //            <a class="deleteSong" href="/Song/Delete/${song.id}"><i class="fa-solid fa-trash"></i></a>
                    //            </div>
                    //        ` : ''}
                    //    </div>
                    //`);
                    // Create the song card
                    var songHtml = `
                        <div class="Song">
                            <p class="SongNumber">${index + 1}</p>
                            <img src="Resources/Note.svg" alt="Alternate Text" />
                            <span class="SongInfo">
                                <p class="Name">${song.name}</p>
                                <p class="Artists">${song.artists.join(", ")}</p>
                            </span>
                            <p class="Duration">${formattedTime}</p>
                            <a class="renderComments" onclick="loadComments(${song.id})"><i class="fa-solid fa-comment"></i></a>
                    `;

                    // Check if the current user is the creator of the song
                    if (song.isCreator || song.isPlaylistCreator) {
                        songHtml += `
                            <div class="SongCardActions">
                                <a class="editSong" href="/Song/Edit/${song.id}"><i class="fa-solid fa-pen"></i></a>
                                <a class="deleteSong" href="/Song/Delete/${song.id}"><i class="fa-solid fa-trash"></i></a>
                            </div>
                        `;
                    }

                    // Close the song div
                    songHtml += '</div>';

                    // Append the constructed HTML to the songs container
                    songsContainer.append(songHtml);
                });
            } else {
                songsContainer.append('<div class="emptyPlaylistDiv"><p class="emptyPlaylistMessage">No songs for this playlist.</p></div>');
            }
        },
        error: function (error) {
            console.error('Error fetching songs:', error);
        }
    });
}