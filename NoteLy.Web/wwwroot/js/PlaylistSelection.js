const playlists = document.querySelectorAll('.Playlist');

playlists.forEach(playlist => {
    playlist.addEventListener('click', () => {
        // Remove 'selected' class from all items
        playlists.forEach(i => i.classList.remove('selectedPlaylist'));
        // Add 'selected' class to the clicked item
        playlist.classList.add('selectedPlaylist');
        let selectedCollection = document.getElementsByClassName('selectedPlaylist')[0];
        let selectedCollectionName = selectedCollection.querySelector('.PlInfoDiv .Name');
        let nameValue = selectedCollectionName.textContent;
        let playListName = document.getElementsByClassName('PlayListName')[0];
        playListName.textContent = nameValue;

    });
});