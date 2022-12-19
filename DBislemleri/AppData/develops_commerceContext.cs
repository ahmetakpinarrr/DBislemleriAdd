using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Dbislemleri.Models;

#nullable disable

namespace Dbislemleri.AppData
{
    public partial class develops_commerceContext : DbContext
    {
        public develops_commerceContext()
        {
        }

        public develops_commerceContext(DbContextOptions<develops_commerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<Advert> Adverts { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CouponCode> CouponCodes { get; set; }
        public virtual DbSet<DbIslemleriAhmet> DbIslemleriAhmets { get; set; }
        public virtual DbSet<MainMenu> MainMenus { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; }
        public virtual DbSet<OrderStatusType> OrderStatusTypes { get; set; }
        public virtual DbSet<PhotoTbl> PhotoTbls { get; set; }
        public virtual DbSet<ProdCategory> ProdCategories { get; set; }
        public virtual DbSet<ProdSubCategory> ProdSubCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategoryRelation> ProductCategoryRelations { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Showcase> Showcases { get; set; }
        public virtual DbSet<ShowcaseProduct> ShowcaseProducts { get; set; }
        public virtual DbSet<SliderBanner> SliderBanners { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAddress> UserAddresses { get; set; }
        public virtual DbSet<UserDiscount> UserDiscounts { get; set; }
        public virtual DbSet<UserProdRate> UserProdRates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source=89.252.185.155\\MSSQLSERVER2019; Initial Catalog=develops_commerce; User ID= develops_emreaydin ;Password=emre_6616;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("develops_emreaydin")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.Property(e => e.UserCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserFirstName).HasMaxLength(50);

                entity.Property(e => e.UserLastName).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(50);
            });

            modelBuilder.Entity<Advert>(entity =>
            {
                entity.Property(e => e.AdvertPath).HasMaxLength(350);

                entity.Property(e => e.AdvertType).HasComment("1- Anasayfa reklamları,  2-Anasayfa 2. alan reklamları 3- Kategori sayfa reklamları");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityName).HasMaxLength(255);
            });

            modelBuilder.Entity<CouponCode>(entity =>
            {
                entity.Property(e => e.CouponCode1)
                    .HasMaxLength(15)
                    .HasColumnName("CouponCode");

                entity.Property(e => e.CouponCodeExpireDate).HasColumnType("datetime");

                entity.Property(e => e.CouponCreateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DbIslemleriAhmet>(entity =>
            {
                entity.ToTable("DbIslemleriAhmet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectDescription).HasMaxLength(50);

                entity.Property(e => e.ProjectName).HasMaxLength(50);
            });

            modelBuilder.Entity<MainMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.Property(e => e.MenuCreatedAt).HasColumnType("datetime");

                entity.Property(e => e.MenuImage).HasMaxLength(500);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.MenuType).HasMaxLength(50);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("MESSAGES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Iletisim)
                    .HasMaxLength(50)
                    .HasColumnName("ILETISIM");

                entity.Property(e => e.Isim)
                    .HasMaxLength(50)
                    .HasColumnName("ISIM");

                entity.Property(e => e.Konu)
                    .HasMaxLength(500)
                    .HasColumnName("KONU");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderCreateDate).HasColumnType("datetime");

                entity.Property(e => e.OrderTotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductFullName).HasMaxLength(300);

                entity.Property(e => e.ProductStockCode).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderHeader>(entity =>
            {
                entity.ToTable("OrderHeader");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.OrderCreateDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TownName).HasMaxLength(100);
            });

            modelBuilder.Entity<OrderStatusType>(entity =>
            {
                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<PhotoTbl>(entity =>
            {
                entity.ToTable("PhotoTBL");

                entity.Property(e => e.PhotoCreateDate).HasColumnType("datetime");

                entity.Property(e => e.PhotoPath).HasMaxLength(250);

                entity.Property(e => e.PhotoTitle).HasMaxLength(250);
            });

            modelBuilder.Entity<ProdCategory>(entity =>
            {
                entity.HasKey(e => e.ProductCategoryId);

                entity.ToTable("ProdCategory");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ProdCategoryImage).HasMaxLength(500);

                entity.Property(e => e.ProductCategoryDesc).HasMaxLength(100);

                entity.Property(e => e.ProductCategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProdSubCategory>(entity =>
            {
                entity.ToTable("ProdSubCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProdCategoryImage).HasMaxLength(500);

                entity.Property(e => e.ProductSubCategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProdRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductBarcode).HasMaxLength(100);

                entity.Property(e => e.ProductBrandSortOrder).HasComment("Marka vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz.");

                entity.Property(e => e.ProductBuyingPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Ürünün alış fiyatı.");

                entity.Property(e => e.ProductCampaignedSortOrder).HasComment("Kampanyalı ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz.");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(10)
                    .HasComment("Ürünün tam adı. Bu değer bir varyant için ana ürünün adı ve varyant adının birleşiminden oluşur. Örneğin Kırmızı varyantı için Kalem Kırmızı olur.");

                entity.Property(e => e.ProductCreateDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCustomShippingCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Sistem seçeneği seçilmemişse ürün için girilmesi gereken kargo ücreti.");

                entity.Property(e => e.ProductCustomShippingDisabled).HasComment("Kargo ücreti için sistemin kullanılıp kullanılmama değerini belirtir.\r\n\r\n1: Sistem seçeneği seçili\r\n0: Sistem seçeneği seçili değil");

                entity.Property(e => e.ProductDescription).HasColumnType("text");

                entity.Property(e => e.ProductDiscount).HasComment("Ürünün indirim değeri. Örneğin; discountType 1 olursa %5, 0 olursa 5 tl anlamına gelir.");

                entity.Property(e => e.ProductDiscountType).HasComment("Ürünün indirim tipini belirtir.\r\n\r\n1: İndirim yüzdesi\r\n0: İndirimli fiyat");

                entity.Property(e => e.ProductDiscountedSortOrder).HasComment("İndirimli ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz.");

                entity.Property(e => e.ProductDistributor)
                    .HasMaxLength(255)
                    .HasComment("Ürünün distribütör bilgisi");

                entity.Property(e => e.ProductFeaturedSortOrder).HasComment("Sponsor ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz.");

                entity.Property(e => e.ProductFullName).HasMaxLength(255);

                entity.Property(e => e.ProductGift)
                    .HasMaxLength(255)
                    .HasComment("Ürünün yanında hediye olarak vermek istediğiniz hediyeyi bu alanda metin ya da rakamla belirtebilirsiniz.");

                entity.Property(e => e.ProductHasOption).HasComment("Ürünün varyantının olup olmadığı değerini belirtir. (API otomatik olarak bu değeri atar.)\r\n\r\n1: Varyantı var\r\n0: Varyantı yok");

                entity.Property(e => e.ProductHomeSortOrder).HasComment("Anasayfa vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz.");

                entity.Property(e => e.ProductInstallmentThreshold)
                    .HasMaxLength(10)
                    .HasComment("Ürüne özel yasal veya isteğe bağlı belirleyebiliceğiniz taksit adedini belirtir. Ürüne özel bir belirleme yapmak istemiyorsanız '-' işareti kullanabilirsiniz.");

                entity.Property(e => e.ProductIsActive).HasComment("Ürün nesnesinin aktiflik durumunu belirten değer.\r\n\r\n1: Aktif\r\n0: Pasif");

                entity.Property(e => e.ProductIsGifted).HasComment("Ürünün hediyeli olup olmadığını belirtir.\r\n\r\n1: Hediyeli\r\n0: Hediyeli Değil");

                entity.Property(e => e.ProductMarketPriceDetail)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Ürünün piyasa fiyatı");

                entity.Property(e => e.ProductMetaDescription).HasComment("Arama motorları tarafından tespit edilebilecek açıklama yazısı.");

                entity.Property(e => e.ProductMetaKeywords).HasComment("Arama motorları tarafından tespit edilebilecek anahtar kelimeler.");

                entity.Property(e => e.ProductName).HasMaxLength(255);

                entity.Property(e => e.ProductNewSortOrder).HasComment("Yeni ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz.");

                entity.Property(e => e.ProductPageTitle).HasMaxLength(100);

                entity.Property(e => e.ProductPopularSortOrder).HasComment("\r\nPopüler ürünler vitrini sırası. Vitrin sırası belirlememek için null değer atayabilirsiniz.");

                entity.Property(e => e.ProductPrice1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductSearchKeywords)
                    .HasMaxLength(255)
                    .HasComment("Ziyaretçilerinizin site içindeki ürünlerinizin hangi anahtar kelimelerine göre bulacağını belirler.Kelimeler arasında virgül bırakılarak girilmelidir.(etiket1,etiket2)");

                entity.Property(e => e.ProductShortDetails)
                    .HasMaxLength(600)
                    .HasComment("Ürünün kısa açıklaması.");

                entity.Property(e => e.ProductStockCode)
                    .HasMaxLength(255)
                    .HasComment("Ürünün stok kodu. ID değeri gibi eşsiz bir kimlik değeridir.");

                entity.Property(e => e.ProductStockType).HasComment("Ürünün stok tipi.");

                entity.Property(e => e.ProductTax).HasComment("Ürünün KDV oranı.");

                entity.Property(e => e.ProductTaxIncluded).HasComment("Ürün fiyatlarına KDV dahil olup olmadığın belirten değer.\r\n\r\n1: KDV Dahil\r\n0: KDV Hariç");

                entity.Property(e => e.ProductThumbnail).HasMaxLength(350);

                entity.Property(e => e.ProductTitle).HasMaxLength(100);

                entity.Property(e => e.ProductUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ProductWarranty).HasComment("Ürünün garanti süresi.");
            });

            modelBuilder.Entity<ProductCategoryRelation>(entity =>
            {
                entity.HasKey(e => e.RelationId);
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ProductImagePath).IsRequired();
            });

            modelBuilder.Entity<Showcase>(entity =>
            {
                entity.Property(e => e.ShowcaseCreateDate).HasColumnType("datetime");

                entity.Property(e => e.ShowcaseName).HasMaxLength(60);

                entity.Property(e => e.ShowcaseUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShowcaseProduct>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("date");
            });

            modelBuilder.Entity<SliderBanner>(entity =>
            {
                entity.Property(e => e.BottomTitle).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ImgPath).HasMaxLength(350);

                entity.Property(e => e.MainTitle).HasMaxLength(50);

                entity.Property(e => e.TopTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.Property(e => e.TownName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.EmailValCode).HasMaxLength(10);

                entity.Property(e => e.SignUpDate).HasColumnType("datetime");

                entity.Property(e => e.UserMail).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasMaxLength(500);

                entity.Property(e => e.UserPhone).HasMaxLength(15);

                entity.Property(e => e.UserSurname).HasMaxLength(50);
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.ToTable("UserAddress");

                entity.Property(e => e.AddressDetail).HasMaxLength(200);

                entity.Property(e => e.AddressTitle).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Town).HasMaxLength(50);
            });

            modelBuilder.Entity<UserDiscount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<UserProdRate>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.UserProdRate1).HasColumnName("UserProdRate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
