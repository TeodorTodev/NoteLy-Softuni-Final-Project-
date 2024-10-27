const songs = document.querySelectorAll('.Song');

songs.forEach(song => {
    song.addEventListener('click', () => {
        // Remove 'selected' class from all items
        songs.forEach(s => s.classList.remove('selectedSong'));
        // Add 'selected' class to the clicked item
        song.classList.add('selectedSong');
    });
});
