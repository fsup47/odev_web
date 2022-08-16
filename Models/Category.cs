using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace odev_web.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public List<Blog> Bloglar { get; set; }


    }
}
