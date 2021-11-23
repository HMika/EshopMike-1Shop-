using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class CustomerComments
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public int? IdArticle { get; set; }

        public virtual Article IdArticleNavigation { get; set; }
    }
}
