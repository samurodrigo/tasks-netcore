﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TasksApi.Models;

namespace TasksApi.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20190619081556_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("TasksApi.Models.TaskItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("TaskListID");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ID");

                    b.HasIndex("TaskListID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TasksApi.Models.TaskList", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("ListName");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ID");

                    b.ToTable("TasksList");
                });

            modelBuilder.Entity("TasksApi.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TasksApi.Models.TaskItem", b =>
                {
                    b.HasOne("TasksApi.Models.TaskList", "TaskList")
                        .WithMany("Tasks")
                        .HasForeignKey("TaskListID");
                });
#pragma warning restore 612, 618
        }
    }
}