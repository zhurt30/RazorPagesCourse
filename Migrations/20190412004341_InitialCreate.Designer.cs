﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesCourse.Models;

namespace RazorPagesCourse.Migrations
{
    [DbContext(typeof(RazorPagesCourseContext))]
    [Migration("20190412004341_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("RazorPagesCourse.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Number");

                    b.Property<string>("Semester");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Course");
                });
#pragma warning restore 612, 618
        }
    }
}
