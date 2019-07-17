﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Todos2019;

namespace Todos2019.Migrations
{
    [DbContext(typeof(ToDosContext))]
    partial class ToDosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Todos2019.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("ToDoId");

                    b.HasKey("Id");

                    b.HasIndex("ToDoId");

                    b.ToTable("Tags");

                    b.HasData(
                        new { Id = 1, Name = "Difficult", ToDoId = 1 },
                        new { Id = 2, Name = "8:00 am", ToDoId = 1 },
                        new { Id = 3, Name = "Eggs", ToDoId = 2 },
                        new { Id = 4, Name = "Important", ToDoId = 2 }
                    );
                });

            modelBuilder.Entity("Todos2019.Models.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Item");

                    b.HasKey("Id");

                    b.ToTable("ToDos");

                    b.HasData(
                        new { Id = 1, Item = "Wake up" },
                        new { Id = 2, Item = "Eat breakfast" },
                        new { Id = 3, Item = "Exercise" }
                    );
                });

            modelBuilder.Entity("Todos2019.Models.Tag", b =>
                {
                    b.HasOne("Todos2019.Models.ToDo")
                        .WithMany("Tags")
                        .HasForeignKey("ToDoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
