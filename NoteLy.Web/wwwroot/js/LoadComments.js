function loadComments(songId) {
    $.ajax({
        url: '/Home/CommentSection', // Your action that returns comments for a specific song
        type: 'GET',
        data: { songId: songId },
        success: function (comments) {
            const commentsContainer = $('.CommentsDiv'); // Change this to your actual comments container class/ID
            commentsContainer.empty(); // Clear existing comments

            // Check if there are any comments
            if (comments.length === 0) {
                commentsContainer.append('<div class="emptyCommentsDiv"><p class="emptyCommentsMessage">No comments for this song.</p></div>');
            } else {
                comments.forEach(comment => {
                    // Append each comment's information to the container
                    commentsContainer.append(`
                        <div class="Comment">
                            <div class="UserNameDiv">
                                <p class="UserName">${comment.applicationUserName}</p>
                            </div>
                            <div class="CommentContent">
                                <p class="text">${comment.text}</p>
                                ${comment.isCreator ? `
                                <div class="CommentCardActions">
                                <a class="editComment" href="/Comment/Edit/${comment.id}"><i class="fa-solid fa-pen"></i></a>
                                <a class="deleteComment" href="/Comment/Delete/${comment.id}"><i class="fa-solid fa-trash"></i></a>
                                </div>
                            ` : ''}
                            </div>
                        </div>
                    `);
                });
            }
        },
        error: function (xhr, status, error) {
            console.error('Error loading comments:', error); // Log error for debugging
        }
    });
}