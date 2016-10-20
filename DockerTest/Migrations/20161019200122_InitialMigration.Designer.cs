using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DockerTest.Data.Model;

namespace DockerTest.Migrations
{
    [DbContext(typeof(ArticleDbContext))]
    [Migration("20161019200122_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("DockerTest.Data.Model.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<string>("Body");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("DockerTest.Data.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("DockerTest.Data.Model.Article", b =>
                {
                    b.HasOne("DockerTest.Data.Model.Author", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
