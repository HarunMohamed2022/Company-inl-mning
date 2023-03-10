// <auto-generated />
using System;
using Company.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Company.Data.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AnställdAnställdBefattningar", b =>
                {
                    b.Property<int>("Anställdsid")
                        .HasColumnType("int");

                    b.Property<int>("AnställdBefattningarsAnställdid")
                        .HasColumnType("int");

                    b.Property<int>("AnställdBefattningarsBefattningid")
                        .HasColumnType("int");

                    b.HasKey("Anställdsid", "AnställdBefattningarsAnställdid", "AnställdBefattningarsBefattningid");

                    b.HasIndex("AnställdBefattningarsAnställdid", "AnställdBefattningarsBefattningid");

                    b.ToTable("AnställdAnställdBefattningar");
                });

            modelBuilder.Entity("AnställdAvdelning", b =>
                {
                    b.Property<int>("Anställdsid")
                        .HasColumnType("int");

                    b.Property<int>("Avdelningsid")
                        .HasColumnType("int");

                    b.HasKey("Anställdsid", "Avdelningsid");

                    b.HasIndex("Avdelningsid");

                    b.ToTable("AnställdAvdelning");
                });

            modelBuilder.Entity("AnställdBefattningarBeffatning", b =>
                {
                    b.Property<int>("Beffatningsid")
                        .HasColumnType("int");

                    b.Property<int>("AnställdBefattningarsAnställdid")
                        .HasColumnType("int");

                    b.Property<int>("AnställdBefattningarsBefattningid")
                        .HasColumnType("int");

                    b.HasKey("Beffatningsid", "AnställdBefattningarsAnställdid", "AnställdBefattningarsBefattningid");

                    b.HasIndex("AnställdBefattningarsAnställdid", "AnställdBefattningarsBefattningid");

                    b.ToTable("AnställdBefattningarBeffatning");
                });

            modelBuilder.Entity("AvdelningFöretag", b =>
                {
                    b.Property<int>("Avdelningarid")
                        .HasColumnType("int");

                    b.Property<int>("Företagsid")
                        .HasColumnType("int");

                    b.HasKey("Avdelningarid", "Företagsid");

                    b.HasIndex("Företagsid");

                    b.ToTable("AvdelningFöretag");
                });

            modelBuilder.Entity("Company.Data.Entities.Anställd", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Avdelningid")
                        .HasColumnType("int");

                    b.Property<string>("EfterNamn")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool?>("Fackförening")
                        .HasColumnType("bit");

                    b.Property<string>("FörNamn")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal?>("Lön")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Anställds");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Avdelningid = 1,
                            EfterNamn = "Parker",
                            Fackförening = true,
                            FörNamn = "Peter",
                            Lön = 30000m
                        },
                        new
                        {
                            id = 2,
                            Avdelningid = 3,
                            EfterNamn = "Black",
                            Fackförening = true,
                            FörNamn = "Jack",
                            Lön = 40000m
                        },
                        new
                        {
                            id = 3,
                            Avdelningid = 4,
                            EfterNamn = "Wick",
                            Fackförening = true,
                            FörNamn = "John",
                            Lön = 50000m
                        },
                        new
                        {
                            id = 4,
                            Avdelningid = 2,
                            EfterNamn = "Mama",
                            Fackförening = true,
                            FörNamn = "Joe",
                            Lön = 60000m
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.AnställdBefattningar", b =>
                {
                    b.Property<int>("Anställdid")
                        .HasColumnType("int");

                    b.Property<int>("Befattningid")
                        .HasColumnType("int");

                    b.HasKey("Anställdid", "Befattningid");

                    b.ToTable("AnställdBefattningars");

                    b.HasData(
                        new
                        {
                            Anställdid = 1,
                            Befattningid = 1
                        },
                        new
                        {
                            Anställdid = 1,
                            Befattningid = 2
                        },
                        new
                        {
                            Anställdid = 2,
                            Befattningid = 2
                        },
                        new
                        {
                            Anställdid = 3,
                            Befattningid = 4
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Avdelning", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Företagid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("id");

                    b.ToTable("Avdelnings");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Företagid = 1,
                            Name = "accounting"
                        },
                        new
                        {
                            id = 2,
                            Företagid = 2,
                            Name = "marketing"
                        },
                        new
                        {
                            id = 3,
                            Företagid = 2,
                            Name = "human resources"
                        },
                        new
                        {
                            id = 4,
                            Företagid = 1,
                            Name = "legal"
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Beffatning", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("id");

                    b.ToTable("Beffatnings");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Tittle = "Doctor"
                        },
                        new
                        {
                            id = 2,
                            Tittle = "Police"
                        },
                        new
                        {
                            id = 3,
                            Tittle = "Pilot"
                        },
                        new
                        {
                            id = 4,
                            Tittle = "Lumberjack"
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Företag", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("OrgNum")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Företags");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "ClassOlson",
                            OrgNum = 123456
                        },
                        new
                        {
                            id = 2,
                            Name = "Elgiganten",
                            OrgNum = 654321
                        });
                });

            modelBuilder.Entity("AnställdAnställdBefattningar", b =>
                {
                    b.HasOne("Company.Data.Entities.Anställd", null)
                        .WithMany()
                        .HasForeignKey("Anställdsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.AnställdBefattningar", null)
                        .WithMany()
                        .HasForeignKey("AnställdBefattningarsAnställdid", "AnställdBefattningarsBefattningid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnställdAvdelning", b =>
                {
                    b.HasOne("Company.Data.Entities.Anställd", null)
                        .WithMany()
                        .HasForeignKey("Anställdsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.Avdelning", null)
                        .WithMany()
                        .HasForeignKey("Avdelningsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnställdBefattningarBeffatning", b =>
                {
                    b.HasOne("Company.Data.Entities.Beffatning", null)
                        .WithMany()
                        .HasForeignKey("Beffatningsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.AnställdBefattningar", null)
                        .WithMany()
                        .HasForeignKey("AnställdBefattningarsAnställdid", "AnställdBefattningarsBefattningid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AvdelningFöretag", b =>
                {
                    b.HasOne("Company.Data.Entities.Avdelning", null)
                        .WithMany()
                        .HasForeignKey("Avdelningarid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.Företag", null)
                        .WithMany()
                        .HasForeignKey("Företagsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
