using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace odev_web.Models
{
    /// <summary>
    /// Bura blog daki veya kategori içindeki değişimleri değişime karşın veri tabanı test etmek için.
    /// </summary>
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="Ender Hayvanlar"},
                new Category() { KategoriAdi = "Endemik Bitkiler" },
            };

            foreach(var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() {Baslik="Ender Hayvanlar Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Aciklama="Türkiyedeki ender Hayvanlar", Resim="1.jpg",CategoryId=1},
                new Blog() {Baslik="Ender Hayvanlar Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-5), Anasayfa=false, Onay=true, Aciklama="Türkiyedeki ender Hayvanlar", Resim="1.jpg",CategoryId=2},
                new Blog() {Baslik="Ender Hayvanlar Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-4), Anasayfa=true, Onay=false, Aciklama="Türkiyedeki ender Hayvanlar", Resim="1.jpg",CategoryId=2},


            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
