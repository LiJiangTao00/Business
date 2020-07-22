using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Model.Models
{
    public partial class PracticalContext : DbContext
    {
        public PracticalContext()
        {
        }

        public PracticalContext(DbContextOptions<PracticalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminInfo> AdminInfo { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<InformationInfo> InformationInfo { get; set; }
        public virtual DbSet<MessageInfo> MessageInfo { get; set; }
        public virtual DbSet<OrderDetailInfo> OrderDetailInfo { get; set; }
        public virtual DbSet<OrderInfo> OrderInfo { get; set; }
        public virtual DbSet<ProductInfo> ProductInfo { get; set; }
        public virtual DbSet<ProductTypeInfo> ProductTypeInfo { get; set; }
        public virtual DbSet<ShopCartInfo> ShopCartInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.43.93;User Id=sa;Password=12345;Database=Practical;Persist Security Info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminInfo>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__AdminInf__719FE4882F049847");

                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminPwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Customer__1788CC4C419460F6");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Useraddress)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Userbirthday).HasColumnType("date");

                entity.Property(e => e.Useremail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userlevel)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usersex)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usertel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InformationInfo>(entity =>
            {
                entity.HasKey(e => e.InfoId)
                    .HasName("PK__Informat__4DEC9D7AE66D64D2");

                entity.Property(e => e.InfoAddtime).HasColumnType("datetime");

                entity.Property(e => e.InfoAuthor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfoContents)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.InfoTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MessageInfo>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__MessageI__C87C0C9C1183180C");

                entity.Property(e => e.Commentdate).HasColumnType("datetime");

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Messagecontent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Messagetitle)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderDetailInfo>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId)
                    .HasName("PK__OrderDet__D3B9D36C43536A31");

                entity.Property(e => e.OrderDetailId).ValueGeneratedNever();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poststatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Recevstatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Saletotalprice).HasColumnType("money");
            });

            modelBuilder.Entity<OrderInfo>(entity =>
            {
                entity.Property(e => e.Memo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate).HasColumnType("datetime");

                entity.Property(e => e.Paymethod)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Postmethod)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Receveraddr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Recevername)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Recevertel)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Totalprice).HasColumnType("money");
            });

            modelBuilder.Entity<ProductInfo>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__ProductI__B40CC6CDE3DCA0B3");

                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductDprice)
                    .HasColumnName("ProductDPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductOutline)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPic)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("money");

                entity.Property(e => e.ProductStoretime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductTypeInfo>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId)
                    .HasName("PK__ProductT__A1312F6EEB647CBE");

                entity.Property(e => e.ProductTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShopCartInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__ShopCart__1788CC4CCED05846");

                entity.Property(e => e.Ispay)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
