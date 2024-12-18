﻿function loadDropDownSongs() {
    $.ajax({
        url: '/Comment/GetSongs',
        type: 'GET',
        success: function (songs) {
            var dropdown = $('#songDropdown');
            dropdown.empty(); // Clear existing options

            dropdown.append(`<option value="">Select a song</option>`);

            songs.forEach(function (song) {
                dropdown.append(`<option value="${song.id}">${song.name}</option>`);
            });
        },
        error: function (error) {
            console.error('Error loading playlists:', error);
        }
    });
}
$(document).ready(function () {
    loadDropDownSongs();
});