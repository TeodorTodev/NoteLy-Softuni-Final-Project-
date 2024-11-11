function formatDuration(duration) {
    // Check if the duration is a string and parse it
    if (typeof duration === 'string') {
        // Split the duration by ':'
        const timeParts = duration.split(':');
        let hours = 0, minutes = 0, seconds = 0;

        // Depending on the length of timeParts, assign values
        if (timeParts.length === 3) {
            // HH:MM:SS format
            hours = parseInt(timeParts[0], 10);
            minutes = parseInt(timeParts[1], 10);
            seconds = parseInt(timeParts[2], 10);
        } else if (timeParts.length === 2) {
            // MM:SS format
            minutes = parseInt(timeParts[0], 10);
            seconds = parseInt(timeParts[1], 10);
        } else if (timeParts.length === 1) {
            // SS format
            seconds = parseInt(timeParts[0], 10);
        }

        // Format the output string
        // If hours is present, format as HH:MM:SS; otherwise, MM:SS
        if (hours > 0) {
            return `${hours}:${minutes < 10 ? '0' + minutes : minutes}:${seconds < 10 ? '0' + seconds : seconds}`;
        } else {
            return `${minutes}:${seconds < 10 ? '0' + seconds : seconds}`;
        }
    } else {
        console.error('Expected a string for duration, but received:', typeof duration);
        return '';
    }
}