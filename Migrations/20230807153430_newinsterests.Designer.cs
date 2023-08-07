﻿// <auto-generated />
using HyperDuckInterestApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HyperDuckInterestApi.Migrations
{
    [DbContext(typeof(HyperDuckInterestApiContext))]
    [Migration("20230807153430_newinsterests")]
    partial class newinsterests
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HyperDuckInterestApi.Models.InterestLink", b =>
                {
                    b.Property<int>("InterestLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestLinkId"));

                    b.Property<string>("InterestURL")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LinkDescription")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.HasKey("InterestLinkId");

                    b.ToTable("InterestLinks");

                    b.HasData(
                        new
                        {
                            InterestLinkId = 1,
                            InterestURL = "http://youtube.com",
                            LinkDescription = "Praesent eu nulla at sem molestie"
                        },
                        new
                        {
                            InterestLinkId = 2,
                            InterestURL = "http://walmart.com",
                            LinkDescription = "at,"
                        },
                        new
                        {
                            InterestLinkId = 3,
                            InterestURL = "https://guardian.co.uk",
                            LinkDescription = "urna, nec luctus"
                        },
                        new
                        {
                            InterestLinkId = 4,
                            InterestURL = "https://netflix.com",
                            LinkDescription = "ipsum ac mi eleifend"
                        },
                        new
                        {
                            InterestLinkId = 5,
                            InterestURL = "https://google.com",
                            LinkDescription = "augue ut"
                        },
                        new
                        {
                            InterestLinkId = 6,
                            InterestURL = "https://bbc.co.uk",
                            LinkDescription = "ante ipsum primis in faucibus orci"
                        },
                        new
                        {
                            InterestLinkId = 7,
                            InterestURL = "http://baidu.com",
                            LinkDescription = "per conubia nostra, per"
                        },
                        new
                        {
                            InterestLinkId = 8,
                            InterestURL = "https://ebay.com",
                            LinkDescription = "Proin velit. Sed malesuada augue ut lacus."
                        },
                        new
                        {
                            InterestLinkId = 9,
                            InterestURL = "http://reddit.com",
                            LinkDescription = "Integer urna. Vivamus molestie"
                        },
                        new
                        {
                            InterestLinkId = 10,
                            InterestURL = "https://reddit.com",
                            LinkDescription = "dolor sit amet, consectetuer"
                        },
                        new
                        {
                            InterestLinkId = 11,
                            InterestURL = "http://cnn.com",
                            LinkDescription = "Aliquam fringilla cursus purus. Nullam scelerisque"
                        },
                        new
                        {
                            InterestLinkId = 12,
                            InterestURL = "https://instagram.com",
                            LinkDescription = "Donec consectetuer"
                        },
                        new
                        {
                            InterestLinkId = 13,
                            InterestURL = "http://zoom.us",
                            LinkDescription = "magna. Sed eu eros. Nam consequat dolor vitae dolor."
                        },
                        new
                        {
                            InterestLinkId = 14,
                            InterestURL = "http://cnn.com",
                            LinkDescription = "gravida sit amet, dapibus id, blandit"
                        },
                        new
                        {
                            InterestLinkId = 15,
                            InterestURL = "https://baidu.com",
                            LinkDescription = "mus. Donec dignissim magna a tortor."
                        });
                });

            modelBuilder.Entity("HyperDuckInterestApi.Models.InterestList", b =>
                {
                    b.Property<int>("InterestListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestListId"));

                    b.Property<int>("Fk_InterestId")
                        .HasColumnType("int");

                    b.Property<int>("Fk_InterestLinkId")
                        .HasColumnType("int");

                    b.Property<int>("Fk_PersonId")
                        .HasColumnType("int");

                    b.HasKey("InterestListId");

                    b.HasIndex("Fk_InterestId");

                    b.HasIndex("Fk_InterestLinkId");

                    b.HasIndex("Fk_PersonId");

                    b.ToTable("InterestLists");

                    b.HasData(
                        new
                        {
                            InterestListId = 1,
                            Fk_InterestId = 1,
                            Fk_InterestLinkId = 1,
                            Fk_PersonId = 15
                        },
                        new
                        {
                            InterestListId = 2,
                            Fk_InterestId = 2,
                            Fk_InterestLinkId = 2,
                            Fk_PersonId = 14
                        },
                        new
                        {
                            InterestListId = 3,
                            Fk_InterestId = 3,
                            Fk_InterestLinkId = 3,
                            Fk_PersonId = 13
                        },
                        new
                        {
                            InterestListId = 4,
                            Fk_InterestId = 4,
                            Fk_InterestLinkId = 4,
                            Fk_PersonId = 12
                        },
                        new
                        {
                            InterestListId = 5,
                            Fk_InterestId = 5,
                            Fk_InterestLinkId = 5,
                            Fk_PersonId = 11
                        },
                        new
                        {
                            InterestListId = 6,
                            Fk_InterestId = 6,
                            Fk_InterestLinkId = 6,
                            Fk_PersonId = 10
                        },
                        new
                        {
                            InterestListId = 7,
                            Fk_InterestId = 7,
                            Fk_InterestLinkId = 7,
                            Fk_PersonId = 9
                        },
                        new
                        {
                            InterestListId = 8,
                            Fk_InterestId = 8,
                            Fk_InterestLinkId = 8,
                            Fk_PersonId = 8
                        },
                        new
                        {
                            InterestListId = 9,
                            Fk_InterestId = 9,
                            Fk_InterestLinkId = 9,
                            Fk_PersonId = 7
                        },
                        new
                        {
                            InterestListId = 10,
                            Fk_InterestId = 10,
                            Fk_InterestLinkId = 10,
                            Fk_PersonId = 6
                        },
                        new
                        {
                            InterestListId = 11,
                            Fk_InterestId = 11,
                            Fk_InterestLinkId = 11,
                            Fk_PersonId = 5
                        },
                        new
                        {
                            InterestListId = 12,
                            Fk_InterestId = 12,
                            Fk_InterestLinkId = 12,
                            Fk_PersonId = 4
                        },
                        new
                        {
                            InterestListId = 13,
                            Fk_InterestId = 13,
                            Fk_InterestLinkId = 13,
                            Fk_PersonId = 3
                        },
                        new
                        {
                            InterestListId = 14,
                            Fk_InterestId = 14,
                            Fk_InterestLinkId = 14,
                            Fk_PersonId = 2
                        },
                        new
                        {
                            InterestListId = 15,
                            Fk_InterestId = 15,
                            Fk_InterestLinkId = 15,
                            Fk_PersonId = 1
                        });
                });

            modelBuilder.Entity("HyperDuckInterestApi.Models.Interests", b =>
                {
                    b.Property<int>("InterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InterestId");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            InterestId = 1,
                            Description = "The act of fishing",
                            Title = "Fishing"
                        },
                        new
                        {
                            InterestId = 2,
                            Description = "The art of preparing food",
                            Title = "Cooking"
                        },
                        new
                        {
                            InterestId = 3,
                            Description = "Exploring nature on foot",
                            Title = "Hiking"
                        },
                        new
                        {
                            InterestId = 4,
                            Description = "Capturing moments through a lens",
                            Title = "Photography"
                        },
                        new
                        {
                            InterestId = 5,
                            Description = "Growing and nurturing plants",
                            Title = "Gardening"
                        },
                        new
                        {
                            InterestId = 6,
                            Description = "Immersing oneself in books",
                            Title = "Reading"
                        },
                        new
                        {
                            InterestId = 7,
                            Description = "Expressing creativity through art",
                            Title = "Painting"
                        },
                        new
                        {
                            InterestId = 8,
                            Description = "Creating music with strings",
                            Title = "Playing guitar"
                        },
                        new
                        {
                            InterestId = 9,
                            Description = "Connecting mind, body, and spirit",
                            Title = "Yoga"
                        },
                        new
                        {
                            InterestId = 10,
                            Description = "Exploring new places and cultures",
                            Title = "Traveling"
                        },
                        new
                        {
                            InterestId = 11,
                            Description = "Exercising through jogging or sprints",
                            Title = "Running"
                        },
                        new
                        {
                            InterestId = 12,
                            Description = "Expressing emotions through movement",
                            Title = "Dancing"
                        },
                        new
                        {
                            InterestId = 13,
                            Description = "Strategic board game for two players",
                            Title = "Playing chess"
                        },
                        new
                        {
                            InterestId = 14,
                            Description = "Putting thoughts into words",
                            Title = "Writing"
                        },
                        new
                        {
                            InterestId = 15,
                            Description = "Finding inner peace and mindfulness",
                            Title = "Meditation"
                        });
                });

            modelBuilder.Entity("HyperDuckInterestApi.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            FirstName = "Owen",
                            LastName = "Marsh",
                            PhoneNumber = "0725-11 71 34"
                        },
                        new
                        {
                            PersonId = 2,
                            FirstName = "Cheyenne",
                            LastName = "Willis",
                            PhoneNumber = "0730-24 18 39"
                        },
                        new
                        {
                            PersonId = 3,
                            FirstName = "Justin",
                            LastName = "Ortiz",
                            PhoneNumber = "0715-83 45 79"
                        },
                        new
                        {
                            PersonId = 4,
                            FirstName = "Declan",
                            LastName = "Burns",
                            PhoneNumber = "0715-07 88 73"
                        },
                        new
                        {
                            PersonId = 5,
                            FirstName = "Otto",
                            LastName = "Clements",
                            PhoneNumber = "0795-86 28 17"
                        },
                        new
                        {
                            PersonId = 6,
                            FirstName = "Yardley",
                            LastName = "Webb",
                            PhoneNumber = "0795-65 65 88"
                        },
                        new
                        {
                            PersonId = 7,
                            FirstName = "Octavius",
                            LastName = "Flores",
                            PhoneNumber = "0738-18 40 65"
                        },
                        new
                        {
                            PersonId = 8,
                            FirstName = "Kermit",
                            LastName = "Maxwell",
                            PhoneNumber = "0767-83 35 84"
                        },
                        new
                        {
                            PersonId = 9,
                            FirstName = "Garrison",
                            LastName = "Bryant",
                            PhoneNumber = "0739-76 66 19"
                        },
                        new
                        {
                            PersonId = 10,
                            FirstName = "Keane",
                            LastName = "Rasmussen",
                            PhoneNumber = "0724-13 64 81"
                        },
                        new
                        {
                            PersonId = 11,
                            FirstName = "Scarlet",
                            LastName = "Keller",
                            PhoneNumber = "0712-37 27 00"
                        },
                        new
                        {
                            PersonId = 12,
                            FirstName = "Trevor",
                            LastName = "West",
                            PhoneNumber = "0751-22 72 78"
                        },
                        new
                        {
                            PersonId = 13,
                            FirstName = "Curran",
                            LastName = "Pruitt",
                            PhoneNumber = "0759-76 21 08"
                        },
                        new
                        {
                            PersonId = 14,
                            FirstName = "Dorian",
                            LastName = "Hines",
                            PhoneNumber = "0791-59 25 44"
                        },
                        new
                        {
                            PersonId = 15,
                            FirstName = "Kieran",
                            LastName = "Chapman",
                            PhoneNumber = "0710-67 68 13"
                        });
                });

            modelBuilder.Entity("HyperDuckInterestApi.Models.InterestList", b =>
                {
                    b.HasOne("HyperDuckInterestApi.Models.Interests", "Interests")
                        .WithMany()
                        .HasForeignKey("Fk_InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HyperDuckInterestApi.Models.InterestLink", "InterestLinks")
                        .WithMany()
                        .HasForeignKey("Fk_InterestLinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HyperDuckInterestApi.Models.Person", "Persons")
                        .WithMany()
                        .HasForeignKey("Fk_PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InterestLinks");

                    b.Navigation("Interests");

                    b.Navigation("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
