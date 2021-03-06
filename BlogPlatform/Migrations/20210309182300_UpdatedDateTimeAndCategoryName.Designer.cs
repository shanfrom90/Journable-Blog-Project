// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog_template_practice;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20210309182300_UpdatedDateTimeAndCategoryName")]
    partial class UpdatedDateTimeAndCategoryName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("blog_template_practice.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Personal Wellness"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Food"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Planning Ahead"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Shannon",
                            Body = "I want to visit my family in Cincinnati first, and then plan a trip out west, hopefully to Arizona and/or New Mexico",
                            CategoryId = 3,
                            PublishDate = new DateTime(2021, 3, 9, 13, 23, 0, 132, DateTimeKind.Local).AddTicks(897),
                            Title = "Once I am Vaccinated"
                        },
                        new
                        {
                            Id = 2,
                            Author = "JP",
                            Body = "I can't believe this only have 5 ingredients! For best results roast the red peppers yourself. You can put this sauce on anything and everything!",
                            CategoryId = 2,
                            PublishDate = new DateTime(2021, 3, 9, 13, 23, 0, 135, DateTimeKind.Local).AddTicks(7276),
                            Title = "Roasted Red Pepper Sauce"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Shannon",
                            Body = "My cat, my mom, my sister, WCCI, a warm place to sleep",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 3, 9, 13, 23, 0, 135, DateTimeKind.Local).AddTicks(7328),
                            Title = "Gratitute List"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Shannon",
                            Body = "I'm going on an 8+ mile hike.",
                            CategoryId = 3,
                            PublishDate = new DateTime(2021, 3, 9, 13, 23, 0, 135, DateTimeKind.Local).AddTicks(7335),
                            Title = "When Winter Is Over"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Mary",
                            Body = "So easy and delicious! The perfect vegetarian weeknight meal. Tip: Keep fresh basil out of the fridge as it is cold-sensitive.",
                            CategoryId = 2,
                            PublishDate = new DateTime(2021, 3, 9, 13, 23, 0, 135, DateTimeKind.Local).AddTicks(7339),
                            Title = "Creamy Instant Pot Pasta"
                        },
                        new
                        {
                            Id = 6,
                            Author = "BP",
                            Body = "Whether you are experienced with yoga or brand new, Yoga With Adriene on YouTube is a dream come true. Namaste!",
                            CategoryId = 1,
                            PublishDate = new DateTime(2021, 3, 9, 13, 23, 0, 135, DateTimeKind.Local).AddTicks(7344),
                            Title = "Yoga With Adriene"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.HasOne("blog_template_practice.Models.Category", "Category")
                        .WithMany("Contents")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
