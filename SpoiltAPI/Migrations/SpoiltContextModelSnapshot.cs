﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpoiltAPI.Data;

namespace SpoiltAPI.Migrations
{
    [DbContext(typeof(SpoiltContext))]
    partial class SpoiltContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpoiltAPI.Models.Movie", b =>
                {
                    b.Property<string>("ID");

                    b.Property<string>("Genre");

                    b.Property<string>("Plot");

                    b.Property<string>("Poster");

                    b.Property<string>("Title");

                    b.Property<string>("Year");

                    b.HasKey("ID");

                    b.ToTable("Movies");

                    b.HasData(
                        new { ID = "tt0167404", Genre = "Drama, Thriller, Mystery", Plot = "A boy who communicates with spirits seeks the help of a disheartened child psychologist.", Poster = "https://m.media-amazon.com/images/M/MV5BMWM4NTFhYjctNzUyNi00NGMwLTk3NTYtMDIyNTZmMzRlYmQyXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_SX300.jpg", Title = "The Sixth Sense", Year = "1999" }
                    );
                });

            modelBuilder.Entity("SpoiltAPI.Models.Spoiler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("MovieID");

                    b.Property<string>("SpoilerText");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.HasIndex("MovieID");

                    b.ToTable("Spoilers");

                    b.HasData(
                        new { ID = 1, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), MovieID = "tt0167404", SpoilerText = "Bruce Willis was DEAD THE WHOLE TIME!!!!!", UserName = "Stairmaster" }
                    );
                });

            modelBuilder.Entity("SpoiltAPI.Models.Spoiler", b =>
                {
                    b.HasOne("SpoiltAPI.Models.Movie", "Movie")
                        .WithMany("Spoilers")
                        .HasForeignKey("MovieID");
                });
#pragma warning restore 612, 618
        }
    }
}
