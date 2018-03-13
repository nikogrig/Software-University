﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;
using System;

namespace P01_BillsPaymentSystem.Data.Migrations
{
    [DbContext(typeof(BillsPaymentSystemContext))]
    [Migration("20180312173004_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.BankAccount", b =>
                {
                    b.Property<int>("BankAccountId");

                    b.Property<decimal>("Balance");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SwiftCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("BankAccountId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.CreditCard", b =>
                {
                    b.Property<int>("CreditCardId");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<decimal>("Limit");

                    b.Property<decimal>("MoneyOwed");

                    b.HasKey("CreditCardId");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BankAccountId");

                    b.Property<int?>("CreditCardId");

                    b.Property<int>("PaymentMethodType");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "BankAccountId", "CreditCardId")
                        .IsUnique()
                        .HasFilter("[BankAccountId] IS NOT NULL AND [CreditCardId] IS NOT NULL");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.BankAccount", b =>
                {
                    b.HasOne("P01_BillsPaymentSystem.Data.Models.PaymentMethod", "PaymentMethod")
                        .WithOne("BankAccount")
                        .HasForeignKey("P01_BillsPaymentSystem.Data.Models.BankAccount", "BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.CreditCard", b =>
                {
                    b.HasOne("P01_BillsPaymentSystem.Data.Models.PaymentMethod", "PaymentMethod")
                        .WithOne("CreditCard")
                        .HasForeignKey("P01_BillsPaymentSystem.Data.Models.CreditCard", "CreditCardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("P01_BillsPaymentSystem.Data.Models.PaymentMethod", b =>
                {
                    b.HasOne("P01_BillsPaymentSystem.Data.Models.User", "User")
                        .WithMany("PaymentMethods")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
