using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Article
    {
        public Article()
        {
            ArticleTags = new HashSet<ArticleTags>();
            CustomerComments = new HashSet<CustomerComments>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public int? ComentId { get; set; }
        public string Picture { get; set; }
        public int? IdAdmin { get; set; }
        public int? IdTags { get; set; }

        public virtual Admin IdAdminNavigation { get; set; }
        public virtual ICollection<ArticleTags> ArticleTags { get; set; }
        public virtual ICollection<CustomerComments> CustomerComments { get; set; }
    }
}
