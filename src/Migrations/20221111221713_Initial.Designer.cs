﻿// <auto-generated />
using ItemsDisplay.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ItemsDisplay.Migrations
{
    [DbContext(typeof(CharacterContext))]
    [Migration("20221111221713_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("ItemsDisplay.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AttackType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Attribute")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AttackType = "Melee",
                            Attribute = "Strength",
                            Description = "Able to transform enemy attacks into self-healing, Abaddon can survive almost any assault. Shielding allies and launching his double-edged coil at a friend or foe, he is always ready to ride into the thick of battle.",
                            ImgURL = "https://lh3.googleusercontent.com/2CYfQT9UPNNDUZteJfXzM-yBn9eIxdR_Dgw7hG6aG9iKCb_KTqzTOXMzYQCXzY7DPFfJkoBI8dmQMB6TIw9vL1gatEzk-SIip02j4FinBmNibF-HusTjbUh0veavNvLKF0jgbwmrag=w2400",
                            Name = "Abaddon"
                        },
                        new
                        {
                            Id = 2,
                            AttackType = "Melee",
                            Attribute = "Strength",
                            Description = "Synthesizing extra resources from each and every kill, Alchemist has no trouble gathering the tools needed to destroy his foes. Ambushing enemies with corrosive acid and a host of unstable chemicals, he battles to ensure his greedy escapades can remain uninterrupted.",
                            ImgURL = "https://lh3.googleusercontent.com/bLZS7hRhCDDvmBMkwxE-o_xZPcB_EqOM-WXwzPXOHOYVXS9WLEovCqcBOjAOziSBXiZMPA148K9xy641c8PrJ_UCiH5hDgqK2Vez_0rdCFatsmv4qnHCnLUHof0xyjfU1gcGK51oFQ=w2400",
                            Name = "Alchemist"
                        },
                        new
                        {
                            Id = 3,
                            AttackType = "Ranged",
                            Attribute = "Intelligence",
                            Description = "Able to launch a powerful blast of damaging ice across the battlefield, Ancient Apparition threatens to shatter weakened enemies wherever they are. Slowing enemies as he enhances his allies' effectiveness in battle, he is a constant threat to his foes.",
                            ImgURL = "https://lh3.googleusercontent.com/NEnrdtBkJJFCswj5htxDWR-EC7lozKAgTgV3QAtH6USldJ1FcpKsG4CwhgBUYVmWB-BxqhsH3iiXWlEMpSewdQ_SByMw3tND_WnSigDLrxisM1x3cko81ZVWebTq9oNnhfgKFYFPlw=w2400",
                            Name = "Ancient Apparition"
                        },
                        new
                        {
                            Id = 4,
                            AttackType = "Melee",
                            Attribute = "Agility",
                            Description = "Should Anti-Mage have the opportunity to gather his full strength, few can stop his assaults. Draining mana from enemies with every strike or teleporting short distances to escape an ambush, cornering him is a challenge for any foe.",
                            ImgURL = "https://lh3.googleusercontent.com/hxNLqoVUvqpYvZNyrINPVQQqr8DEHJJWdZjdpM89uqZnVodKiKcJIkhM7pnOhmc63wu01T_2RKGE9O1kSzxKkM4T8Ayj_cb7RgTghMypGCzPx7Gk_XFygxM6V8tvdkU6DHHm3qyeTQ=w2400",
                            Name = "Anti-Mage"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}