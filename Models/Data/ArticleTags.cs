using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class ArticleTags
    {
        public int Id { get; set; }
        public int IdArticle { get; set; }
        public int IdTags { get; set; }

        public virtual Article IdArticleNavigation { get; set; }
        public virtual Tags IdTagsNavigation { get; set; }
    }
}
