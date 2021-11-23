using System;
using System.Collections.Generic;

namespace Models.Data
{
    public partial class Admin
    {
        public Admin()
        {
            Article = new HashSet<Article>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Article> Article { get; set; }
    }
}
