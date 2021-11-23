using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Tags
    {
        public Tags()
        {
            ArticleTags = new HashSet<ArticleTags>();
        }

        public int Id { get; set; }
        public string Lable { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ArticleTags> ArticleTags { get; set; }
    }
}
