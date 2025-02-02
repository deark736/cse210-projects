using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeVideos
{
    public class Video
    {
        // Private member variables.
        private string _title;
        private string _author;
        private int _lengthInSeconds;
        private List<Comment> _comments;

        // Constructor to initialize the video.
        public Video(string title, string author, int lengthInSeconds)
        {
            _title = title;
            _author = author;
            _lengthInSeconds = lengthInSeconds;
            _comments = new List<Comment>();
        }

        // Adds a comment to the video.
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        // Returns the number of comments.
        public int GetCommentCount()
        {
            return _comments.Count;
        }

        // Returns a string containing the video details and its comments.
        public string DisplayVideoInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Title: {_title}");
            sb.AppendLine($"Author: {_author}");
            sb.AppendLine($"Length: {_lengthInSeconds} seconds");
            sb.AppendLine($"Comments ({GetCommentCount()}):");
            foreach (Comment comment in _comments)
            {
                sb.AppendLine(comment.DisplayComment());
            }
            return sb.ToString();
        }
    }
}
