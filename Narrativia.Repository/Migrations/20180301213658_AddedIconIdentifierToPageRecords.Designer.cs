﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Narrativia.Repository.Data;
using System;

namespace Narrativia.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180301213658_AddedIconIdentifierToPageRecords")]
    partial class AddedIconIdentifierToPageRecords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Narrativia.Data.Entities.BlogPost", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BodyText")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Excerpt")
                        .IsRequired();

                    b.Property<string>("HeaderImageUrl");

                    b.Property<uint>("Likes");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<uint>("Views");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("Narrativia.Data.Entities.Comment", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("BlogPostId");

                    b.Property<ulong?>("CommentId");

                    b.Property<string>("CommentText")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BlogPostId");

                    b.HasIndex("CommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Narrativia.Data.Entities.Page", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BodyText")
                        .IsRequired();

                    b.Property<DateTime>("Created");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("IconIdentifier");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<bool>("VisibleInHeader");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Narrativia.Data.Entities.Comment", b =>
                {
                    b.HasOne("Narrativia.Data.Entities.BlogPost", "BlogPost")
                        .WithMany("Comments")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Narrativia.Data.Entities.Comment")
                        .WithMany("Replies")
                        .HasForeignKey("CommentId");
                });
#pragma warning restore 612, 618
        }
    }
}
