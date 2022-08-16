using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace odev_web.Models
{
    /* veri tabanı için kurudupum bölüm.*/
    public class BlogContext:DbContext
    {
        /// <summary>
        /// jenerik dbset ile istediğim entity dönüşümünü sağlar.
        /// </summary>
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }

    }
}
