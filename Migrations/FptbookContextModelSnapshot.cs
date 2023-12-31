﻿// <auto-generated />
using System;
using BookStoreV10.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreV10.Migrations
{
    [DbContext(typeof(FptbookContext))]
    partial class FptbookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStoreV10.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("AdminID");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ImageURL");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasIndex(new[] { "AdminId" }, "UQ__Admins__1788CCADD46FA1CF")
                        .IsUnique();

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("BookStoreV10.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("AuthorID");

                    b.Property<string>("AuthorAddress")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AuthorEmail")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AuthorName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AuthorPhoto")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("AuthorId")
                        .HasName("PK_Authors_1");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookStoreV10.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    b.Property<int?>("AuthorName")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ImageURL");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int?>("PublisherName")
                        .HasColumnType("int");

                    b.Property<int?>("StoreOwnerId")
                        .HasColumnType("int")
                        .HasColumnName("StoreOwnerID");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("BookId")
                        .HasName("PK__Books__3DE0C2271627489E");

                    b.HasIndex("AuthorName");

                    b.HasIndex("PublisherName");

                    b.HasIndex("StoreOwnerId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookStoreV10.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("CartID");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.HasKey("CartId")
                        .HasName("PK__Carts__51BCD797E74E601F");

                    b.HasIndex("CustomerId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("BookStoreV10.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .HasColumnType("int")
                        .HasColumnName("CartItemID");

                    b.Property<int?>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    b.Property<int?>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("CartID");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ImageURL");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemId")
                        .HasName("PK__CartItem__488B0B2A988D95C9");

                    b.HasIndex("BookId");

                    b.HasIndex("CartId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("BookStoreV10.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ImageURL");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("CustomerId")
                        .HasName("PK__Customer__A4AE64B8861FDA72");

                    b.HasIndex(new[] { "UserId" }, "UQ__Customer__1788CCAD2A92AA0F")
                        .IsUnique()
                        .HasFilter("[UserID] IS NOT NULL");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookStoreV10.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("StoreOwnerId")
                        .HasColumnType("int")
                        .HasColumnName("StoreOwnerID");

                    b.HasKey("OrderId")
                        .HasName("PK__Orders__C3905BAFD6191291");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StoreOwnerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookStoreV10.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int")
                        .HasColumnName("OrderDetailID");

                    b.Property<int?>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("BookID");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ImageURL");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId")
                        .HasName("PK__OrderDet__D3B9D30C92FDE201");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BookStoreV10.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .HasColumnType("int")
                        .HasColumnName("PublisherID");

                    b.Property<string>("PublisherAddress")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PublisherLogo")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PublisherName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("BookStoreV10.Models.StoreOwner", b =>
                {
                    b.Property<int>("StoreOwnerId")
                        .HasColumnType("int")
                        .HasColumnName("StoreOwnerID");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ImageURL");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("UserName")
                        .HasColumnType("int");

                    b.HasKey("StoreOwnerId")
                        .HasName("PK__StoreOwn__071566580602B353");

                    b.HasIndex(new[] { "UserName" }, "UQ__StoreOwn__1788CCADE512BC5D")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("StoreOwners");
                });

            modelBuilder.Entity("BookStoreV10.Models.Book", b =>
                {
                    b.HasOne("BookStoreV10.Models.Author", "AuthorNameNavigation")
                        .WithMany("Books")
                        .HasForeignKey("AuthorName")
                        .HasConstraintName("FK_Books_Authors");

                    b.HasOne("BookStoreV10.Models.Publisher", "PublisherNameNavigation")
                        .WithMany("Books")
                        .HasForeignKey("PublisherName")
                        .HasConstraintName("FK_Books_Publishers");

                    b.HasOne("BookStoreV10.Models.StoreOwner", "StoreOwner")
                        .WithMany("Books")
                        .HasForeignKey("StoreOwnerId")
                        .HasConstraintName("FK__Books__StoreOwne__787EE5A0");

                    b.Navigation("AuthorNameNavigation");

                    b.Navigation("PublisherNameNavigation");

                    b.Navigation("StoreOwner");
                });

            modelBuilder.Entity("BookStoreV10.Models.Cart", b =>
                {
                    b.HasOne("BookStoreV10.Models.Customer", "Customer")
                        .WithMany("Carts")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Carts__CustomerI__4CA06362");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BookStoreV10.Models.CartItem", b =>
                {
                    b.HasOne("BookStoreV10.Models.Book", "Book")
                        .WithMany("CartItems")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__CartItems__BookI__5070F446");

                    b.HasOne("BookStoreV10.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .HasConstraintName("FK__CartItems__CartI__4F7CD00D");

                    b.Navigation("Book");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("BookStoreV10.Models.Order", b =>
                {
                    b.HasOne("BookStoreV10.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Orders__Customer__534D60F1");

                    b.HasOne("BookStoreV10.Models.StoreOwner", "StoreOwner")
                        .WithMany("Orders")
                        .HasForeignKey("StoreOwnerId")
                        .HasConstraintName("FK__Orders__StoreOwn__5441852A");

                    b.Navigation("Customer");

                    b.Navigation("StoreOwner");
                });

            modelBuilder.Entity("BookStoreV10.Models.OrderDetail", b =>
                {
                    b.HasOne("BookStoreV10.Models.Book", "Book")
                        .WithMany("OrderDetails")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__OrderDeta__BookI__5812160E");

                    b.HasOne("BookStoreV10.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__OrderDeta__Order__571DF1D5");

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookStoreV10.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStoreV10.Models.Book", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookStoreV10.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("BookStoreV10.Models.Customer", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BookStoreV10.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookStoreV10.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStoreV10.Models.StoreOwner", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
