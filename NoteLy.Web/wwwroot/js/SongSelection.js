function songSelection()
{
    let songs = document.getElementsByClassName('Song');
    Array.from(songs).forEach(song => {
        song.addEventListener('click', () => {
            // Remove 'selected' class from all items
            Array.from(songs).forEach(s => s.classList.remove('selectedSong'));
            // Add 'selected' class to the clicked item
            song.classList.add('selectedSong');
        });
    });
}

