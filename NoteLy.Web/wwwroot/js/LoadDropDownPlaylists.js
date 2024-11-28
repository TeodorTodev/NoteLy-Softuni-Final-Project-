function loadPlaylists() {
    $.ajax({
        url: '/Song/GetPlaylists',
        type: 'GET',
        success: function (playlists) {
            var dropdown = $('#playlistDropdown');
            dropdown.empty(); // Clear existing options

            dropdown.append(`<option value="">Select a Playlist</option>`);

            playlists.forEach(function (playlist) {
                dropdown.append(`<option value="${playlist.id}">${playlist.name}</option>`);
            });
        },
        error: function (error) {
            console.error('Error loading playlists:', error);
        }
    });
}
$(document).ready(function () {
    loadPlaylists();
});