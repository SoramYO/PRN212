using Microsoft.EntityFrameworkCore;
using MilkTeaManagerDAL.Models;

namespace MilkTeaManagerDAL;

public partial class CoffeeContext : DbContext
{
    public CoffeeContext()
    {
    }

    public CoffeeContext(DbContextOptions<CoffeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<LoginRole> LoginRoles { get; set; }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    public virtual DbSet<TbBill> TbBills { get; set; }

    public virtual DbSet<TbBillDetailt> TbBillDetailts { get; set; }

    public virtual DbSet<TbCustomer> TbCustomers { get; set; }

    public virtual DbSet<TbGroupProduct> TbGroupProducts { get; set; }

    public virtual DbSet<TbGroupTb> TbGroupTbs { get; set; }

    public virtual DbSet<TbProduct> TbProducts { get; set; }

    public virtual DbSet<TbStore> TbStores { get; set; }

    public virtual DbSet<TbTable> TbTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=Coffee;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .HasColumnName("address");
            entity.Property(e => e.DateWork).HasColumnName("dateWork");
            entity.Property(e => e.FullName)
                .HasMaxLength(250)
                .HasColumnName("fullName");
            entity.Property(e => e.IdCard)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("idCard");
            entity.Property(e => e.Img).HasColumnName("img");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.ToTable("Login");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdEmployees).HasColumnName("idEmployees");
            entity.Property(e => e.IsUse).HasColumnName("isUse");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<LoginRole>(entity =>
        {
            entity.ToTable("LoginRole");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdLogin).HasColumnName("idLogin");
            entity.Property(e => e.IdMenuItems).HasColumnName("idMenuItems");
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NameMenu)
                .HasMaxLength(500)
                .HasColumnName("nameMenu");
            entity.Property(e => e.NameShow)
                .HasMaxLength(500)
                .HasColumnName("nameShow");
        });

        modelBuilder.Entity<TbBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_bill");

            entity.ToTable("tbBill");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.BillDate)
                .HasColumnType("datetime")
                .HasColumnName("billDate");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");
            entity.Property(e => e.IdTable).HasColumnName("idTable");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TotalMoney).HasColumnName("totalMoney");
        });

        modelBuilder.Entity<TbBillDetailt>(entity =>
        {
            entity.ToTable("tbBillDetailt");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.IdBill).HasColumnName("idBill");
            entity.Property(e => e.IdProduct).HasColumnName("idProduct");
            entity.Property(e => e.IntoMoney).HasColumnName("intoMoney");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");
        });

        modelBuilder.Entity<TbCustomer>(entity =>
        {
            entity.ToTable("tbCustomer");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .HasColumnName("address");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<TbGroupProduct>(entity =>
        {
            entity.HasKey(e => e.IdGr);

            entity.ToTable("tbGroupProduct");

            entity.Property(e => e.IdGr)
                .ValueGeneratedNever()
                .HasColumnName("idGr");
            entity.Property(e => e.DescriptionGr)
                .HasMaxLength(500)
                .HasColumnName("descriptionGr");
            entity.Property(e => e.NameGr)
                .HasMaxLength(500)
                .HasColumnName("nameGr");
        });

        modelBuilder.Entity<TbGroupTb>(entity =>
        {
            entity.ToTable("tbGroupTb");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TbProduct>(entity =>
        {
            entity.ToTable("tbProduct");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .HasColumnName("description");
            entity.Property(e => e.IdGroupProduct).HasColumnName("idGroupProduct");
            entity.Property(e => e.Img).HasColumnName("img");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasColumnName("name");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
            entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");
        });

        modelBuilder.Entity<TbStore>(entity =>
        {
            entity.ToTable("tbStore");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AddressStore)
                .HasMaxLength(500)
                .HasColumnName("addressStore");
            entity.Property(e => e.NameStore)
                .HasMaxLength(500)
                .HasColumnName("nameStore");
            entity.Property(e => e.PhoneStore)
                .HasMaxLength(500)
                .HasColumnName("phoneStore");
            entity.Property(e => e.TaxCode)
                .HasMaxLength(250)
                .HasColumnName("taxCode");
        });

        modelBuilder.Entity<TbTable>(entity =>
        {
            entity.ToTable("tbTable");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IdGroup).HasColumnName("idGroup");
            entity.Property(e => e.NameTb)
                .HasMaxLength(50)
                .HasColumnName("nameTb");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
