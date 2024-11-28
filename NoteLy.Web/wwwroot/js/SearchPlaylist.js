$(document).ready(function () {
    $('#searchButton').click(function () {
        const query = $('#searchInput').val().trim();
        const targetContainer = $('.PlaylistsDiv');
        targetContainer.empty(); // Clear previous results

        if (!query) {
            alert("Please enter a search term.");
            return;
        }

        $.ajax({
            url: '/PlayList/Search',
            method: 'GET',
            data: { query: query },
            success: function (response) {
                if (response.success) {
                    var userId = response.userId;
                    response.playlists.forEach(playlist => {
                        let playlistHtml = `
                            <div class="Playlist" data-id="${playlist.id}" onclick="loadSongs(${playlist.id})">
                                <img class="icon" src="/Resources/Note.svg" alt="Alternate Text" />
                                <span class="PlInfoDiv">
                                    <p class="Name" style="letter-spacing: 1px; font-weight: 500;">${playlist.name}</p>
                                </span>
                                ${playlist.applicationUserId === userId ? `
                                    <div class="PlaylistCardActions">
                                        <td>
                                            <a class="editPlaylist" href="/PlayList/Edit/${playlist.id}">
                                                <i class="fa-solid fa-pen"></i>
                                            </a>
                                            <a class="deletePlaylist" href="/PlayList/Delete/${playlist.id}">
                                                <i class="fa-solid fa-trash"></i>
                                            </a>
                                        </td>
                                    </div>` : ''}
                            </div>
                        `;

                        // Append the HTML to the target container
                        targetContainer.append(playlistHtml);
                    });

                } else {
                    targetContainer.empty();
                    let NoMatches = `
                        <div class="EmptyPlaylistDiv">
                            <p class="EmptyPlaylistMessage">No matches found</p>
                        </div>
                    `;
                    targetContainer.append(NoMatches);
                }
            },
            error: function (xhr, status, error) {
                console.error('Error:', error);
                alert('An error occurred while searching.');
            }
        });
    });
});
