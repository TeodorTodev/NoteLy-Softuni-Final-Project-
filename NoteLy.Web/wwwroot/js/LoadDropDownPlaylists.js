function loadPlaylists() {
    $.ajax({
        url: '/Song/GetPlaylists', // Replace with your actual controller name
        type: 'GET',
        success: function (playlists) {
            var dropdown = $('#playlistDropdown'); // Make sure this matches your dropdown ID
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