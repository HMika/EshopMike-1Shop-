using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models.Data
{
    public partial class EshopDbContext : DbContext
    {
        public EshopDbContext()
        {
        }

        public EshopDbContext(DbContextOptions<EshopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleTags> ArticleTags { get; set; }
        public virtual DbSet<Basket> Basket { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CustomerComments> CustomerComments { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<OrderedBasket> OrderedBasket { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsCategory> ProductsCategory { get; set; }
        public virtual DbSet<ProductsOrders> ProductsOrders { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=mysqlstudenti.litv.sssvt.cz;database=4a1_hasanovmikayil_db2;user=hasanovmikayil;password=12Barabas", x => x.ServerVersion("10.3.25-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasIndex(e => e.ComentId)
                    .HasName("ComentID")
                    .IsUnique();

                entity.HasIndex(e => e.IdAdmin)
                    .HasName("id_admin");

                entity.HasIndex(e => e.IdTags)
                    .HasName("id_tags");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComentId)
                    .HasColumnName("comentID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasColumnName("context")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.IdAdmin)
                    .HasColumnName("id_admin")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTags)
                    .HasColumnName("id_tags")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasColumnName("picture")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.HasOne(d => d.IdAdminNavigation)
                    .WithMany(p => p.Article)
                    .HasForeignKey(d => d.IdAdmin)
                    .HasConstraintName("Article_ibfk_2");
            });

            modelBuilder.Entity<ArticleTags>(entity =>
            {
                entity.ToTable("Article_Tags");

                entity.HasIndex(e => e.IdArticle)
                    .HasName("id_article");

                entity.HasIndex(e => e.IdTags)
                    .HasName("id_tags");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdArticle)
                    .HasColumnName("id_article")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTags)
                    .HasColumnName("id_tags")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdArticleNavigation)
                    .WithMany(p => p.ArticleTags)
                    .HasForeignKey(d => d.IdArticle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Article_Tags_ibfk_1");

                entity.HasOne(d => d.IdTagsNavigation)
                    .WithMany(p => p.ArticleTags)
                    .HasForeignKey(d => d.IdTags)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Article_Tags_ibfk_2");
            });

            modelBuilder.Entity<Basket>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NameOfcategory)
                    .HasColumnName("nameOfcategory")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");
            });

            modelBuilder.Entity<CustomerComments>(entity =>
            {
                entity.HasIndex(e => e.IdArticle)
                    .HasName("id_article");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.IdArticle)
                    .HasColumnName("id_article")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.HasOne(d => d.IdArticleNavigation)
                    .WithMany(p => p.CustomerComments)
                    .HasForeignKey(d => d.IdArticle)
                    .HasConstraintName("CustomerComments_ibfk_1");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");
            });

            modelBuilder.Entity<OrderedBasket>(entity =>
            {
                entity.ToTable("Ordered_Basket");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.ApartmentNumber)
                    .HasColumnName("apartmentNumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.NumberOfOrder)
                    .HasColumnName("numberOfOrder")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Psc)
                    .HasColumnName("psc")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(400)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dph)
                    .HasColumnName("dph")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NameOfProduct)
                    .HasColumnName("nameOfProduct")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.PhotoPath)
                    .HasColumnName("photoPath")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Vendor)
                    .HasColumnName("vendor")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");
            });

            modelBuilder.Entity<ProductsCategory>(entity =>
            {
                entity.ToTable("Products_Category");

                entity.HasIndex(e => e.IdCategory)
                    .HasName("id_category");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCategory)
                    .HasColumnName("id_category")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.ProductsCategory)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Products_Category_ibfk_2");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.ProductsCategory)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Products_Category_ibfk_1");
            });

            modelBuilder.Entity<ProductsOrders>(entity =>
            {
                entity.ToTable("Products_Orders");

                entity.HasIndex(e => e.IdOrder)
                    .HasName("id_order");

                entity.HasIndex(e => e.IdProduct)
                    .HasName("id_product");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("id_product")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.ProductsOrders)
                    .HasForeignKey(d => d.IdOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Products_Orders_ibfk_2");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.ProductsOrders)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Products_Orders_ibfk_1");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");

                entity.Property(e => e.Lable)
                    .HasColumnName("lable")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_czech_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
