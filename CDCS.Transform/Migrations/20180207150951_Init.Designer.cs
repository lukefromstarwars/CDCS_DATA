﻿// <auto-generated />
using CDCS.Transform.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CDCS.Transform.Migrations
{
    [DbContext(typeof(CdcsContext))]
    [Migration("20180207150951_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CDCS.Transform.Model.ActionZone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CdcsId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Description_FR");

                    b.Property<string>("Description_NL");

                    b.Property<string>("FR");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("NL");

                    b.Property<string>("ParentIds");

                    b.Property<DateTime?>("RemovedOn");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("SortOrder");

                    b.HasKey("Id");

                    b.ToTable("ActionZones");
                });
#pragma warning restore 612, 618
        }
    }
}
