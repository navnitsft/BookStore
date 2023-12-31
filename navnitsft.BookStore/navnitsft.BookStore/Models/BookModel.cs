﻿namespace navnitsft.BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public int PageCount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set;}
    }
}
