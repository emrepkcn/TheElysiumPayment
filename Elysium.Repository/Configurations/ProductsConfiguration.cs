using Elysium.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elysium.Repository.Configurations
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            //Bunun Bir Key Olduğunu Belirtiyoruz.
            builder.HasKey(x => x.Id);

            //Identity Key olduğunu ve kaçar kaçar artıcağını ayarlayabiliriz.
            builder.Property(x => x.Id).UseIdentityColumn();

            //Bu alan zorunlu ve max length ayarlıyoruz.
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            //Burda kolonda decimal tipinde toplamda 18 karakter bir tutar olucağını fakat 16. karakterden sonra virgül 2 karakter geliceğini söylüyoruz.
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");

            //Tablo Adını Değiştirmek İstersek Vermezsek Dbsetteki isimi bazı alıcaktır.
            builder.ToTable("Products");

            //Veritabanı ilişkilendirme
            //Bir kategorinin birden fazla ürünü olabilir demiş olduk. Hangi tablodaysan belirlediğimiz nesnenin ıd alanını veriyoruz foreignkeye
            //builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);

           

        }
    }
}
