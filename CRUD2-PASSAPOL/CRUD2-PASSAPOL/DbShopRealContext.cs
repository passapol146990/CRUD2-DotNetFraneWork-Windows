using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD2_PASSAPOL;

public partial class DbShopRealContext : DbContext
{
    public DbShopRealContext()
    {
    }

    public DbShopRealContext(DbContextOptions<DbShopRealContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<TbBuy> TbBuys { get; set; }

    public virtual DbSet<TbCustomer> TbCustomers { get; set; }

    public virtual DbSet<TbProduct> TbProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=dbShopReal;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_CI_AS");

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("ProductType");

            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.TypeName)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("type_name");
        });

        modelBuilder.Entity<TbBuy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tb_bye");

            entity.ToTable("tb_buy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CusId).HasColumnName("cus_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.ProId).HasColumnName("pro_id");

            entity.HasOne(d => d.Cus).WithMany(p => p.TbBuys)
                .HasForeignKey(d => d.CusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_buy_tb_customer");

            entity.HasOne(d => d.Pro).WithMany(p => p.TbBuys)
                .HasForeignKey(d => d.ProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_buy_tb_product");
        });

        modelBuilder.Entity<TbCustomer>(entity =>
        {
            entity.HasKey(e => e.CusId);

            entity.ToTable("tb_customer");

            entity.Property(e => e.CusId).HasColumnName("cus_id");
            entity.Property(e => e.Bdate)
                .HasColumnType("datetime")
                .HasColumnName("bdate");
            entity.Property(e => e.CusAdd)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("cus_add");
            entity.Property(e => e.CusLname)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("cus_lname");
            entity.Property(e => e.CusName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("cus_name");
            entity.Property(e => e.CusTel)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cus_tel");
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("password");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sex");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("username");
        });

        modelBuilder.Entity<TbProduct>(entity =>
        {
            entity.HasKey(e => e.ProId);

            entity.ToTable("tb_product");

            entity.Property(e => e.ProId).HasColumnName("pro_id");
            entity.Property(e => e.ProDesc)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("pro_desc");
            entity.Property(e => e.ProImage)
                .HasColumnType("image")
                .HasColumnName("pro_image");
            entity.Property(e => e.ProName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("pro_name");
            entity.Property(e => e.ProNum).HasColumnName("pro_num");
            entity.Property(e => e.ProTypeid).HasColumnName("pro_typeid");

            entity.HasOne(d => d.ProType).WithMany(p => p.TbProducts)
                .HasForeignKey(d => d.ProTypeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tb_product_ProductType");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
