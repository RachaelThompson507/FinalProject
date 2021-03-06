﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _FinalProject.Data.Context;

namespace Data.Migrations
{
    [DbContext(typeof(FinalProjectDBContext))]
    [Migration("20190206022523_updated-navigational-references")]
    partial class updatednavigationalreferences
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_FinalProject.Model.Models.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EventDate");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentContent");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<int?>("LetterId");

                    b.Property<int>("PostId");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LetterId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Letter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ClosedDate");

                    b.Property<int>("CommentId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Name");

                    b.Property<int>("PostId");

                    b.Property<int>("RobinId");

                    b.Property<int>("SubmissionId");

                    b.Property<DateTime>("SubmittedDate");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("Letters");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latutude");

                    b.Property<double>("Longitute");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DeletedDate");

                    b.Property<int?>("LetterId");

                    b.Property<int>("RobinId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LetterId");

                    b.HasIndex("RobinId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Robin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("DisableDate");

                    b.Property<string>("InviteCode");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Robins");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.SubmissionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LetterId");

                    b.Property<string>("SubmissionState");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LetterId");

                    b.ToTable("SubmissionStatuses");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DisableDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("ImageURL");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.UsersByRobin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin");

                    b.Property<int>("RobinID");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RobinID");

                    b.HasIndex("UserId");

                    b.ToTable("UsersByRobins");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Calendar", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany()
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Comment", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Letter")
                        .WithMany("Comments")
                        .HasForeignKey("LetterId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Letter", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany("Letters")
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Map", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany()
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Post", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Letter")
                        .WithMany("Posts")
                        .HasForeignKey("LetterId");

                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany()
                        .HasForeignKey("RobinId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.Robin", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.User")
                        .WithMany("Robins")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.SubmissionStatus", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Letter")
                        .WithMany("SubmissionStatuses")
                        .HasForeignKey("LetterId");
                });

            modelBuilder.Entity("_FinalProject.Model.Models.UsersByRobin", b =>
                {
                    b.HasOne("_FinalProject.Model.Models.Robin", "Robin")
                        .WithMany()
                        .HasForeignKey("RobinID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("_FinalProject.Model.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
