using System;

namespace MVC.ViewModels
{
    public class CommentViewModel
    {
        public string Id { get; set; }

        public string AuthorEmail { get; set; }

        public string AuthorName { get; set; }

        public string AuthorNickname { get; set; }

        public string AuthorImage { get; set; }

        public DateTime Time { get; set; }

        public string Text { get; set; }
    }
}
