﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission_06_briggsm2.Models;

namespace Mission_06_briggsm2.Migrations
{
    [DbContext(typeof(AddMovieContext))]
    partial class AddMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission_06_briggsm2.Models.AddMovieResponce", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent_To")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Ruben Fleischer",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Uncharted",
                            Year = 2022
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 1,
                            Director = "Joseph Kosinski",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Top Gun: Maverick",
                            Year = 2022
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 2,
                            Director = "Marc Forster",
                            Edited = false,
                            Notes = "This is my most favorite",
                            Rating = "PG-13",
                            Title = "World War Z",
                            Year = 2013
                        });
                });

            modelBuilder.Entity("Mission_06_briggsm2.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Horror/Action"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Mission_06_briggsm2.Models.AddMovieResponce", b =>
                {
                    b.HasOne("Mission_06_briggsm2.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
