using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebAPI.Entities
{
    public partial class compassContext : DbContext
    {
        public compassContext()
        {
        }

        public compassContext(DbContextOptions<compassContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Aspnetroleclaims> Aspnetroleclaims { get; set; }
        //public virtual DbSet<Aspnetroles> Aspnetroles { get; set; }
        //public virtual DbSet<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        //public virtual DbSet<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        //public virtual DbSet<Aspnetuserroles> Aspnetuserroles { get; set; }
        //public virtual DbSet<Aspnetusers> Aspnetusers { get; set; }
        //public virtual DbSet<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Dataprotectionkeys> Dataprotectionkeys { get; set; }
        public virtual DbSet<DeliveryAddress> DeliveryAddress { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemPhoto> ItemPhoto { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuCategory> MenuCategory { get; set; }
        public virtual DbSet<MenuCategoryPhoto> MenuCategoryPhoto { get; set; }
        public virtual DbSet<MenuItem> MenuItem { get; set; }
        public virtual DbSet<Offer> Offer { get; set; }
        public virtual DbSet<OfferItem> OfferItem { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderRider> OrderRider { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Rider> Rider { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreOrder> StoreOrder { get; set; }
        public virtual DbSet<StoreUser> StoreUser { get; set; }
        public virtual DbSet<User> User { get; set; }
        //public virtual DbSet<UserRefreshTokens> UserRefreshTokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("brand");

                entity.Property(e => e.BrandId)
                    .HasColumnName("Brand_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivationDate).HasColumnName("Activation_Date");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeactivationDate).HasColumnName("Deactivation_Date");

                entity.Property(e => e.DeliveryCharges)
                    .HasColumnName("Delivery_Charges")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.DeliveryMinutes)
                    .HasColumnName("Delivery_Minutes")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookId)
                    .HasColumnName("Facebook_Id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FreeDeliveryAmount)
                    .HasColumnName("Free_Delivery_Amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasColumnType("tinyint(1)")
                    .HasConversion(new BoolToZeroOneConverter<Int16>());

                entity.Property(e => e.Logo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumOrder)
                    .HasColumnName("Minimum_Order")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Mobile).HasColumnType("smallint(6)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingHoursText)
                    .IsRequired()
                    .HasColumnName("Operating_Hours_Text")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasColumnType("smallint(6)");

                entity.Property(e => e.TaxEntity)
                    .IsRequired()
                    .HasColumnName("Tax_Entity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercent)
                    .HasColumnName("Tax_Percent")
                    .HasColumnType("decimal(3,2)");

                entity.Property(e => e.TaxRegistrationNumber)
                    .IsRequired()
                    .HasColumnName("Tax_Registration_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TwitterId)
                    .HasColumnName("Twitter_Id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WhatsApp).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.HasIndex(e => e.CountryId)
                    .HasName("country_city_fk");

                entity.Property(e => e.CityId)
                    .HasColumnName("City_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("country_city_fk");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasColumnName("Currency_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasColumnName("Currency_Symbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dataprotectionkeys>(entity =>
            {
                entity.ToTable("dataprotectionkeys");

                entity.Property(e => e.Id).HasColumnType("int(1)");

                entity.Property(e => e.FriendlyName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Xml)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryAddress>(entity =>
            {
                entity.ToTable("delivery_address");

                entity.HasIndex(e => e.CityId)
                    .HasName("city_delivery_address_fk");

                entity.HasIndex(e => e.CountryId)
                    .HasName("country_delivery_address_fk");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_delivery_address_fk");

                entity.Property(e => e.DeliveryAddressId)
                    .HasColumnName("Delivery_Address_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CityId)
                    .HasColumnName("City_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasColumnName("Street_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_Id")
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.DeliveryAddress)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("city_delivery_address_fk");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.DeliveryAddress)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("country_delivery_address_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeliveryAddress)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_delivery_address_fk");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("item");

                entity.Property(e => e.ItemId)
                    .HasColumnName("Item_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsOutOfStock)
                    .HasColumnName("Is_Out_of_Stock")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ItemPhoto>(entity =>
            {
                entity.ToTable("item_photo");

                entity.HasIndex(e => e.ItemId)
                    .HasName("dish_dish_photo_fk");

                entity.Property(e => e.ItemPhotoId)
                    .HasColumnName("Item_Photo_Id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.IsPrimary)
                    .HasColumnName("Is_Primary")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ItemId)
                    .HasColumnName("Item_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPhoto)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dish_dish_photo_fk");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu");

                entity.HasIndex(e => e.StoreId)
                    .HasName("restuarant_menu_fk");

                entity.Property(e => e.MenuId)
                    .HasColumnName("Menu_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.PublishEndTime).HasColumnName("Publish_End_Time");

                entity.Property(e => e.PublishStateTime).HasColumnName("Publish_State_Time");

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("restuarant_menu_fk");
            });

            modelBuilder.Entity<MenuCategory>(entity =>
            {
                entity.ToTable("menu_category");

                entity.Property(e => e.MenuCategoryId)
                    .HasColumnName("Menu_Category_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_Id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<MenuCategoryPhoto>(entity =>
            {
                entity.ToTable("menu_category_photo");

                entity.HasIndex(e => e.MenuCategoryId)
                    .HasName("menu_category_menu_category_photo_fk");

                entity.Property(e => e.MenuCategoryPhotoId)
                    .HasColumnName("Menu_Category_Photo_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MenuCategoryId)
                    .HasColumnName("Menu_Category_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.HasOne(d => d.MenuCategory)
                    .WithMany(p => p.MenuCategoryPhoto)
                    .HasForeignKey(d => d.MenuCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("menu_category_menu_category_photo_fk");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.ToTable("menu_item");

                entity.HasIndex(e => e.ItemId)
                    .HasName("dish_menu_item_fk");

                entity.HasIndex(e => e.MenuCategoryId)
                    .HasName("menu_category_menu_item_fk");

                entity.HasIndex(e => e.MenuId)
                    .HasName("menu_menu_item_fk");

                entity.HasIndex(e => e.StoreId)
                    .HasName("restuarant_menu_item_fk");

                entity.Property(e => e.MenuItemId)
                    .HasColumnName("Menu_Item_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasColumnType("tinyint(1)")
                    .HasConversion(new BoolToZeroOneConverter<Int16>());

                entity.Property(e => e.IsOutOfStock)
                    .HasColumnName("Is_Out_of_Stock")
                    .HasColumnType("tinyint(1)")
                    .HasConversion(new BoolToZeroOneConverter<Int16>()); ;

                entity.Property(e => e.ItemId)
                    .HasColumnName("Item_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenuCategoryId)
                    .HasColumnName("Menu_Category_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenuId)
                    .HasColumnName("Menu_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.Price).HasColumnType("decimal(10,2)");

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dish_menu_item_fk");

                entity.HasOne(d => d.MenuCategory)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.MenuCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("menu_category_menu_item_fk");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("menu_menu_item_fk");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("restuarant_menu_item_fk");
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.ToTable("offer");

                entity.HasIndex(e => e.StoreId)
                    .HasName("restuarant_special_offer_fk");

                entity.Property(e => e.OfferId)
                    .HasColumnName("Offer_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.EndDatetime).HasColumnName("End_Datetime");

                entity.Property(e => e.MinimumAmount)
                    .HasColumnName("Minimum_Amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.Percentage).HasColumnType("decimal(3,2)");

                entity.Property(e => e.StartDatetime).HasColumnName("Start_Datetime");

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("restuarant_special_offer_fk");
            });

            modelBuilder.Entity<OfferItem>(entity =>
            {
                entity.ToTable("offer_item");

                entity.HasIndex(e => e.MenuItemId)
                    .HasName("menu_item_special_offer_item_fk");

                entity.Property(e => e.OfferItemId)
                    .HasColumnName("Offer_Item_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Amount).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.EndDatetime).HasColumnName("End_Datetime");

                entity.Property(e => e.MenuItemId)
                    .HasColumnName("Menu_Item_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.Percentage).HasColumnType("decimal(3,2)");

                entity.Property(e => e.StartDatetime).HasColumnName("Start_Datetime");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.OfferItem)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("menu_item_special_offer_item_fk");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("order_item");

                entity.HasIndex(e => e.MenuItemId)
                    .HasName("menu_item_order_item_fk");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_order_item_fk");

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("Order_Item_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActualPrice)
                    .HasColumnName("Actual_Price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.FinalPrice)
                    .HasColumnName("Final_Price")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Instructions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MenuItemId)
                    .HasColumnName("Menu_Item_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.OfferAmount)
                    .HasColumnName("Offer_Amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.OfferPercent)
                    .HasColumnName("Offer_Percent")
                    .HasColumnType("decimal(3,2)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("menu_item_order_item_fk");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_order_item_fk");
            });

            modelBuilder.Entity<OrderRider>(entity =>
            {
                entity.HasKey(e => new { e.RiderId, e.OrderId });

                entity.ToTable("order_rider");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_order_rider_fk");

                entity.Property(e => e.RiderId)
                    .HasColumnName("Rider_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.AssignmentDatetime).HasColumnName("Assignment_Datetime");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.JourneyEndTime).HasColumnName("Journey_End_Time");

                entity.Property(e => e.JourneyStartTime).HasColumnName("Journey_Start_Time");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderRider)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_order_rider_fk");

                entity.HasOne(d => d.Rider)
                    .WithMany(p => p.OrderRider)
                    .HasForeignKey(d => d.RiderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rider_order_rider_fk");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("order_status");

                entity.HasIndex(e => e.OrderId)
                    .HasName("order_order_status_fk");

                entity.HasIndex(e => e.StatusId)
                    .HasName("status_order_status_fk");

                entity.Property(e => e.OrderStatusId)
                    .HasColumnName("Order_Status_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_Id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderStatus)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("order_order_status_fk");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OrderStatus)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("status_order_status_fk");
            });

            modelBuilder.Entity<Rider>(entity =>
            {
                entity.ToTable("rider");

                entity.HasIndex(e => e.StoreId)
                    .HasName("restuarant_rider_fk");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_rider_fk");

                entity.Property(e => e.RiderId)
                    .HasColumnName("Rider_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_Id")
                    .IsUnicode(false);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Rider)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("restuarant_rider_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Rider)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_rider_fk");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("store");

                entity.HasIndex(e => e.BrandId)
                    .HasName("brand_store_fk");

                entity.HasIndex(e => e.CityId)
                    .HasName("city_restuarant_fk");

                entity.HasIndex(e => e.CountryId)
                    .HasName("country_restuarant_fk");

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.BrandId)
                    .HasColumnName("Brand_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CityId)
                    .HasColumnName("City_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeactivationDate).HasColumnName("Deactivation_Date");

                entity.Property(e => e.GooglePin)
                    .HasColumnName("Google_Pin")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnName("Is_Active")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsClosed)
                    .HasColumnName("Is_Closed")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDistance)
                    .HasColumnName("Service_Distance")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.StreetAddress)
                    .IsRequired()
                    .HasColumnName("Street_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brand_store_fk");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("city_restuarant_fk");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("country_restuarant_fk");
            });

            modelBuilder.Entity<StoreOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("store_order");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("user_order_fk");

                entity.HasIndex(e => e.DeliveryAddressId)
                    .HasName("delivery_address_order_fk");

                entity.HasIndex(e => e.StoreId)
                    .HasName("restuarant_order_fk");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ArchivedBy)
                    .HasColumnName("Archived_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivedDate).HasColumnName("Archived_Date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_Id")
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAddressId)
                    .HasColumnName("Delivery_Address_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeliveryCharge)
                    .HasColumnName("Delivery_Charge")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("Discount_Amount")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("Discount_Percent")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("Modified_By")
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnName("Modified_Date");

                entity.Property(e => e.NetPayable)
                    .HasColumnName("Net_Payable")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tax).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Total).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Type).HasColumnType("tinyint(4)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.StoreOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("user_order_fk");

                entity.HasOne(d => d.DeliveryAddress)
                    .WithMany(p => p.StoreOrder)
                    .HasForeignKey(d => d.DeliveryAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("delivery_address_order_fk");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreOrder)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("restuarant_order_fk");
            });

            modelBuilder.Entity<StoreUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.StoreId });

                entity.ToTable("store_user");

                entity.HasIndex(e => e.BrandId)
                    .HasName("brand_store_user_fk");

                entity.HasIndex(e => e.StoreId)
                    .HasName("restuarant_restuarant_user_fk");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .IsUnicode(false);

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActivationDatetime).HasColumnName("Activation_Datetime");

                entity.Property(e => e.BrandId)
                    .HasColumnName("Brand_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DeactivationDatetime).HasColumnName("Deactivation_Datetime");

                entity.Property(e => e.InvitationDatetime).HasColumnName("Invitation_Datetime");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.StoreUser)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brand_store_user_fk");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreUser)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("restuarant_restuarant_user_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StoreUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_restuarant_user_fk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Type).HasColumnType("tinyint(4)");
            });            
        }
    }
}
