using System;

namespace YouTubeVideos
{
    public class Comment
    {
        // Private member variables.
        private string _commenterName;
        private string _commentText;

        // Constructor to initialize the comment.
        public Comment(string commenterName, string commentText)
        {
            _commenterName = commenterName;
            _commentText = commentText;
        }

        // Returns a formatted string representing the comment.
        public string DisplayComment()
        {
            return $"{_commenterName}: {_commentText}";
        }
    }
}
