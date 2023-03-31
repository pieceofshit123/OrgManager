using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OrganisationManager.Models
{
    public partial class TRADEORGContext : DbContext
    {
        public TRADEORGContext()
        {
        }

        public TRADEORGContext(DbContextOptions<TRADEORGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAdmin> TbAdmins { get; set; } = null!;
        public virtual DbSet<TbAvailableProduct> TbAvailableProducts { get; set; } = null!;
        public virtual DbSet<TbBuyer> TbBuyers { get; set; } = null!;
        public virtual DbSet<TbDate> TbDates { get; set; } = null!;
        public virtual DbSet<TbEmployee> TbEmployees { get; set; } = null!;
        public virtual DbSet<TbEmployeeSold> TbEmployeeSolds { get; set; } = null!;
        public virtual DbSet<TbEmployeeType> TbEmployeeTypes { get; set; } = null!;
        public virtual DbSet<TbKiosk> TbKiosks { get; set; } = null!;
        public virtual DbSet<TbOrder> TbOrders { get; set; } = null!;
        public virtual DbSet<TbOutlet> TbOutlets { get; set; } = null!;
        public virtual DbSet<TbOutletAdvanced> TbOutletAdvanceds { get; set; } = null!;
        public virtual DbSet<TbProductSold> TbProductSolds { get; set; } = null!;
        public virtual DbSet<TbProductType> TbProductTypes { get; set; } = null!;
        public virtual DbSet<TbProvider> TbProviders { get; set; } = null!;
        public virtual DbSet<TbRequest> TbRequests { get; set; } = null!;
        public virtual DbSet<TbSection> TbSections { get; set; } = null!;
        public virtual DbSet<TbShop> TbShops { get; set; } = null!;
        public virtual DbSet<TbShopingRoom> TbShopingRooms { get; set; } = null!;
        public virtual DbSet<TbStore> TbStores { get; set; } = null!;
        public virtual DbSet<TbSupplierProduct> TbSupplierProducts { get; set; } = null!;
        public virtual DbSet<TbTradeorg> TbTradeorgs { get; set; } = null!;
        public virtual DbSet<TbTradingTray> TbTradingTrays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=COMPUTER;initial catalog=TRADEORG;trusted_connection=true");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__TB_ADMIN__59AF14B522842036");

                entity.ToTable("TB_ADMINS");

                entity.Property(e => e.AdminId).HasColumnName("ADMIN_ID");

                entity.Property(e => e.AdminLogin)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_LOGIN");

                entity.Property(e => e.AdminPassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADMIN_PASSWORD");

                entity.Property(e => e.IdTradeorg).HasColumnName("ID_TRADEORG");

                entity.HasOne(d => d.IdTradeorgNavigation)
                    .WithMany(p => p.TbAdmins)
                    .HasForeignKey(d => d.IdTradeorg)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_ADMINS__ID_TR__6754599E");
            });

            modelBuilder.Entity<TbAvailableProduct>(entity =>
            {
                entity.HasKey(e => e.ProductAvId)
                    .HasName("PK__TB_AVAIL__2D970FFB2B6537F9");

                entity.ToTable("TB_AVAILABLE_PRODUCT");

                entity.Property(e => e.ProductAvId).HasColumnName("PRODUCT_AV_ID");

                entity.Property(e => e.IdOutlet).HasColumnName("ID_OUTLET");

                entity.Property(e => e.IdProductType).HasColumnName("ID_PRODUCT_TYPE");

                entity.Property(e => e.ProductVolume).HasColumnName("PRODUCT_VOLUME");

                entity.HasOne(d => d.IdOutletNavigation)
                    .WithMany(p => p.TbAvailableProducts)
                    .HasForeignKey(d => d.IdOutlet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_AVAILA__ID_OU__440B1D61");

                entity.HasOne(d => d.IdProductTypeNavigation)
                    .WithMany(p => p.TbAvailableProducts)
                    .HasForeignKey(d => d.IdProductType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_AVAILA__ID_PR__4316F928");
            });

            modelBuilder.Entity<TbBuyer>(entity =>
            {
                entity.HasKey(e => e.BuyerId)
                    .HasName("PK__TB_BUYER__41FBBC4991CF3D16");

                entity.ToTable("TB_BUYERS");

                entity.Property(e => e.BuyerId).HasColumnName("BUYER_ID");

                entity.Property(e => e.BuyerGender).HasColumnName("BUYER_GENDER");

                entity.Property(e => e.BuyerName)
                    .HasMaxLength(255)
                    .HasColumnName("BUYER_NAME");
            });

            modelBuilder.Entity<TbDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_DATES");

                entity.Property(e => e.BeginDate)
                    .HasColumnType("date")
                    .HasColumnName("BEGIN_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.IdProvider).HasColumnName("ID_PROVIDER");

                entity.Property(e => e.IdTradeorg).HasColumnName("ID_TRADEORG");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_DATES__ID_PRO__47DBAE45");

                entity.HasOne(d => d.IdTradeorgNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTradeorg)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_DATES__ID_TRA__48CFD27E");
            });

            modelBuilder.Entity<TbEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__TB_EMPLO__CBA14F48E44264FD");

                entity.ToTable("TB_EMPLOYEES");

                entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.DismissalDate)
                    .HasColumnType("date")
                    .HasColumnName("DISMISSAL_DATE");

                entity.Property(e => e.EmployeeGender).HasColumnName("EMPLOYEE_GENDER");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(255)
                    .HasColumnName("EMPLOYEE_NAME");

                entity.Property(e => e.EmployeePassport)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMPLOYEE_PASSPORT");

                entity.Property(e => e.EmployeeSalary)
                    .HasColumnType("money")
                    .HasColumnName("EMPLOYEE_SALARY");

                entity.Property(e => e.EmploymentDate)
                    .HasColumnType("date")
                    .HasColumnName("EMPLOYMENT_DATE");

                entity.Property(e => e.IdOutlet).HasColumnName("ID_OUTLET");

                entity.Property(e => e.IdType).HasColumnName("ID_TYPE");

                entity.HasOne(d => d.IdOutletNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.IdOutlet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_EMPLOY__ID_OU__59FA5E80");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_EMPLOY__ID_TY__59063A47");
            });

            modelBuilder.Entity<TbEmployeeSold>(entity =>
            {
                entity.ToTable("TB_EMPLOYEE_SOLD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdEmployee).HasColumnName("ID_EMPLOYEE");

                entity.Property(e => e.IdProductSold).HasColumnName("ID_PRODUCT_SOLD");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.TbEmployeeSolds)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_EMPLOY__ID_EM__6477ECF3");

                entity.HasOne(d => d.IdProductSoldNavigation)
                    .WithMany(p => p.TbEmployeeSolds)
                    .HasForeignKey(d => d.IdProductSold)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_EMPLOY__ID_PR__6383C8BA");
            });

            modelBuilder.Entity<TbEmployeeType>(entity =>
            {
                entity.HasKey(e => e.EmployeeTypeId)
                    .HasName("PK__TB_EMPLO__CB2CE8A9646E4842");

                entity.ToTable("TB_EMPLOYEE_TYPE");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("EMPLOYEE_TYPE_ID");

                entity.Property(e => e.EmployeeTname)
                    .HasMaxLength(255)
                    .HasColumnName("EMPLOYEE_TNAME");
            });

            modelBuilder.Entity<TbKiosk>(entity =>
            {
                entity.HasKey(e => e.KioskId)
                    .HasName("PK__TB_KIOSK__793E93F68519FBB6");

                entity.ToTable("TB_KIOSK");

                entity.HasIndex(e => e.IdOutletAdv, "UQ__TB_KIOSK__F132A4172F44D05E")
                    .IsUnique();

                entity.Property(e => e.KioskId).HasColumnName("KIOSK_ID");

                entity.Property(e => e.IdOutletAdv).HasColumnName("ID_OUTLET_ADV");

                entity.HasOne(d => d.IdOutletAdvNavigation)
                    .WithOne(p => p.TbKiosk)
                    .HasForeignKey<TbKiosk>(d => d.IdOutletAdv)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_KIOSK__ID_OUT__3B75D760");
            });

            modelBuilder.Entity<TbOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__TB_ORDER__460A94641717EC9E");

                entity.ToTable("TB_ORDERS");

                entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

                entity.Property(e => e.Cost)
                    .HasColumnType("money")
                    .HasColumnName("COST");

                entity.Property(e => e.CurrentVolume).HasColumnName("CURRENT_VOLUME");

                entity.Property(e => e.IdProvider).HasColumnName("ID_PROVIDER");

                entity.Property(e => e.IdTradeorg).HasColumnName("ID_TRADEORG");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("ORDER_DATE");

                entity.Property(e => e.OrderNumber).HasColumnName("ORDER_NUMBER");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.TbOrders)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_ORDERS__ID_PR__4BAC3F29");

                entity.HasOne(d => d.IdTradeorgNavigation)
                    .WithMany(p => p.TbOrders)
                    .HasForeignKey(d => d.IdTradeorg)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_ORDERS__ID_TR__4CA06362");
            });

            modelBuilder.Entity<TbOutlet>(entity =>
            {
                entity.HasKey(e => e.OutletId)
                    .HasName("PK__TB_OUTLE__B8D55EF9E0894A2C");

                entity.ToTable("TB_OUTLET");

                entity.Property(e => e.OutletId).HasColumnName("OUTLET_ID");

                entity.Property(e => e.IdTradeorg).HasColumnName("ID_TRADEORG");

                entity.Property(e => e.OutletAddress)
                    .HasMaxLength(255)
                    .HasColumnName("OUTLET_ADDRESS");

                entity.Property(e => e.OutletName)
                    .HasMaxLength(255)
                    .HasColumnName("OUTLET_NAME");

                entity.Property(e => e.OutletType)
                    .HasMaxLength(255)
                    .HasColumnName("OUTLET_TYPE");

                entity.HasOne(d => d.IdTradeorgNavigation)
                    .WithMany(p => p.TbOutlets)
                    .HasForeignKey(d => d.IdTradeorg)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_OUTLET__ID_TR__267ABA7A");
            });

            modelBuilder.Entity<TbOutletAdvanced>(entity =>
            {
                entity.HasKey(e => e.OutletAdvId)
                    .HasName("PK__TB_OUTLE__9BCEFCC45E4759D8");

                entity.ToTable("TB_OUTLET_ADVANCED");

                entity.HasIndex(e => e.IdOutlet, "UQ__TB_OUTLE__B1E69712928055A8")
                    .IsUnique();

                entity.Property(e => e.OutletAdvId).HasColumnName("OUTLET_ADV_ID");

                entity.Property(e => e.IdOutlet).HasColumnName("ID_OUTLET");

                entity.Property(e => e.OutletSize).HasColumnName("OUTLET_SIZE");

                entity.Property(e => e.RentPayments).HasColumnName("RENT_PAYMENTS");

                entity.Property(e => e.StallCount).HasColumnName("STALL_COUNT");

                entity.Property(e => e.UtilitiesPayments).HasColumnName("UTILITIES_PAYMENTS");

                entity.HasOne(d => d.IdOutletNavigation)
                    .WithOne(p => p.TbOutletAdvanced)
                    .HasForeignKey<TbOutletAdvanced>(d => d.IdOutlet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_OUTLET__ID_OU__2A4B4B5E");
            });

            modelBuilder.Entity<TbProductSold>(entity =>
            {
                entity.ToTable("TB_PRODUCT_SOLD");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdBuyer).HasColumnName("ID_BUYER");

                entity.Property(e => e.IdOutlet).HasColumnName("ID_OUTLET");

                entity.Property(e => e.IdProductType).HasColumnName("ID_PRODUCT_TYPE");

                entity.Property(e => e.SaleDate)
                    .HasColumnType("date")
                    .HasColumnName("SALE_DATE");

                entity.Property(e => e.VolumeSold).HasColumnName("VOLUME_SOLD");

                entity.HasOne(d => d.IdBuyerNavigation)
                    .WithMany(p => p.TbProductSolds)
                    .HasForeignKey(d => d.IdBuyer)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_PRODUC__ID_BU__5FB337D6");

                entity.HasOne(d => d.IdOutletNavigation)
                    .WithMany(p => p.TbProductSolds)
                    .HasForeignKey(d => d.IdOutlet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_PRODUC__ID_OU__5EBF139D");

                entity.HasOne(d => d.IdProductTypeNavigation)
                    .WithMany(p => p.TbProductSolds)
                    .HasForeignKey(d => d.IdProductType)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_PRODUC__ID_PR__60A75C0F");
            });

            modelBuilder.Entity<TbProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId)
                    .HasName("PK__TB_PRODU__A60F8E81A2DFCEE7");

                entity.ToTable("TB_PRODUCT_TYPE");

                entity.Property(e => e.ProductTypeId).HasColumnName("PRODUCT_TYPE_ID");

                entity.Property(e => e.ProductCost)
                    .HasColumnType("money")
                    .HasColumnName("PRODUCT_COST");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_NAME");
            });

            modelBuilder.Entity<TbProvider>(entity =>
            {
                entity.HasKey(e => e.ProviderId)
                    .HasName("PK__TB_PROVI__BF677C76C070BF6B");

                entity.ToTable("TB_PROVIDERS");

                entity.Property(e => e.ProviderId).HasColumnName("PROVIDER_ID");

                entity.Property(e => e.ProvideName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PROVIDE_NAME");
            });

            modelBuilder.Entity<TbRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK__TB_REQUE__71D2766C020971B7");

                entity.ToTable("TB_REQUESTS");

                entity.Property(e => e.RequestId).HasColumnName("REQUEST_ID");

                entity.Property(e => e.IdOrder).HasColumnName("ID_ORDER");

                entity.Property(e => e.IdOutlet).HasColumnName("ID_OUTLET");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_NAME");

                entity.Property(e => e.ProductVolume).HasColumnName("PRODUCT_VOLUME");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.TbRequests)
                    .HasForeignKey(d => d.IdOrder)
                    .HasConstraintName("FK__TB_REQUES__ID_OR__534D60F1");

                entity.HasOne(d => d.IdOutletNavigation)
                    .WithMany(p => p.TbRequests)
                    .HasForeignKey(d => d.IdOutlet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_REQUES__ID_OU__5441852A");
            });

            modelBuilder.Entity<TbSection>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .HasName("PK__TB_SECTI__92F806956FAC58A6");

                entity.ToTable("TB_SECTION");

                entity.Property(e => e.SectionId)
                    .ValueGeneratedNever()
                    .HasColumnName("SECTION_ID");

                entity.Property(e => e.IdStore).HasColumnName("ID_STORE");

                entity.Property(e => e.SLevel).HasColumnName("S_LEVEL");

                entity.Property(e => e.StallCount).HasColumnName("STALL_COUNT");

                entity.HasOne(d => d.IdStoreNavigation)
                    .WithMany(p => p.TbSections)
                    .HasForeignKey(d => d.IdStore)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_SECTIO__ID_ST__30F848ED");
            });

            modelBuilder.Entity<TbShop>(entity =>
            {
                entity.HasKey(e => e.ShopId)
                    .HasName("PK__TB_SHOP__6AFEA57F7C2E1E9F");

                entity.ToTable("TB_SHOP");

                entity.HasIndex(e => e.IdOutletAdv, "UQ__TB_SHOP__F132A41752C28626")
                    .IsUnique();

                entity.Property(e => e.ShopId).HasColumnName("SHOP_ID");

                entity.Property(e => e.IdOutletAdv).HasColumnName("ID_OUTLET_ADV");

                entity.HasOne(d => d.IdOutletAdvNavigation)
                    .WithOne(p => p.TbShop)
                    .HasForeignKey<TbShop>(d => d.IdOutletAdv)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_SHOP__ID_OUTL__34C8D9D1");
            });

            modelBuilder.Entity<TbShopingRoom>(entity =>
            {
                entity.HasKey(e => e.ShopingroomId)
                    .HasName("PK__TB_SHOPI__AB1C7A498F9DC70F");

                entity.ToTable("TB_SHOPING_ROOM");

                entity.Property(e => e.ShopingroomId).HasColumnName("SHOPINGROOM_ID");

                entity.Property(e => e.IdOutletAdv).HasColumnName("ID_OUTLET_ADV");

                entity.Property(e => e.StallCount).HasColumnName("STALL_COUNT");

                entity.HasOne(d => d.IdOutletAdvNavigation)
                    .WithMany(p => p.TbShopingRooms)
                    .HasForeignKey(d => d.IdOutletAdv)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_SHOPIN__ID_OU__37A5467C");
            });

            modelBuilder.Entity<TbStore>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__TB_STORE__F5E247F1A12E39D1");

                entity.ToTable("TB_STORE");

                entity.HasIndex(e => e.IdOutletAdvanced, "UQ__TB_STORE__0B152CB09F444878")
                    .IsUnique();

                entity.Property(e => e.StoreId).HasColumnName("STORE_ID");

                entity.Property(e => e.IdOutletAdvanced).HasColumnName("ID_OUTLET_ADVANCED");

                entity.Property(e => e.LevelsCount).HasColumnName("LEVELS_COUNT");

                entity.HasOne(d => d.IdOutletAdvancedNavigation)
                    .WithOne(p => p.TbStore)
                    .HasForeignKey<TbStore>(d => d.IdOutletAdvanced)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_STORE__ID_OUT__2E1BDC42");
            });

            modelBuilder.Entity<TbSupplierProduct>(entity =>
            {
                entity.HasKey(e => e.SupplierpId)
                    .HasName("PK__TB_SUPPL__C8C88C99A2E1A646");

                entity.ToTable("TB_SUPPLIER_PRODUCTS");

                entity.Property(e => e.SupplierpId).HasColumnName("SUPPLIERP_ID");

                entity.Property(e => e.IdOrder).HasColumnName("ID_ORDER");

                entity.Property(e => e.IdProvider).HasColumnName("ID_PROVIDER");

                entity.Property(e => e.ProductCost)
                    .HasColumnType("money")
                    .HasColumnName("PRODUCT_COST");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .HasColumnName("PRODUCT_NAME");

                entity.Property(e => e.ProductVolume).HasColumnName("PRODUCT_VOLUME");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.TbSupplierProducts)
                    .HasForeignKey(d => d.IdOrder)
                    .HasConstraintName("FK__TB_SUPPLI__ID_OR__4F7CD00D");

                entity.HasOne(d => d.IdProviderNavigation)
                    .WithMany(p => p.TbSupplierProducts)
                    .HasForeignKey(d => d.IdProvider)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_SUPPLI__ID_PR__5070F446");
            });

            modelBuilder.Entity<TbTradeorg>(entity =>
            {
                entity.HasKey(e => e.OrgId)
                    .HasName("PK__TB_TRADE__66696A8C35F4B547");

                entity.ToTable("TB_TRADEORG");

                entity.Property(e => e.OrgId).HasColumnName("ORG_ID");

                entity.Property(e => e.OrgBudget).HasColumnName("ORG_BUDGET");

                entity.Property(e => e.OrgIndex).HasColumnName("ORG_INDEX");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(255)
                    .HasColumnName("ORG_NAME");
            });

            modelBuilder.Entity<TbTradingTray>(entity =>
            {
                entity.HasKey(e => e.TrayId)
                    .HasName("PK__TB_TRADI__517247151CD145EE");

                entity.ToTable("TB_TRADING_TRAY");

                entity.Property(e => e.TrayId).HasColumnName("TRAY_ID");

                entity.Property(e => e.IdOutlet).HasColumnName("ID_OUTLET");

                entity.HasOne(d => d.IdOutletNavigation)
                    .WithMany(p => p.TbTradingTrays)
                    .HasForeignKey(d => d.IdOutlet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__TB_TRADIN__ID_OU__3E52440B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
