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
    [Migration("20221205054838_Edit_field_attributes")]
    partial class Editfieldattributes
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
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Attribute")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
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
                        },
                        new
                        {
                            Id = 5,
                            AttackType = "Ranged",
                            Attribute = "Agility",
                            Description = "A splintered fragment of the same primordial power as the Ancients themselves, Zet the Arc Warden has pledged to see the clash between Radiant and Dire finally end. Assault lone enemies with fluxing energy, or distort space to generate a protective field around allies. Summon a Spark Wraith to patrol an area for enemies to infuse with harmful magic, then create a double of Zet, items and all, to overwhelm your foes.",
                            ImgURL = "https://lh3.googleusercontent.com/PpOVTM88AYFgImSba_yF5UOF2hS75Cue-9dx9bWcjhDZgBeoPAwMBNH2XQW6CBeezHQ2fY9zfFFnnpbcHoEmmrTBO-wWzfvJQC3o7muh2OjLIx33TTVQKmdvIS5y9cosJnLO8Sm-nQ=w2400",
                            Name = "Arc Warden"
                        },
                        new
                        {
                            Id = 6,
                            AttackType = "Melee",
                            Attribute = "Strength",
                            Description = "One after another, Axe cuts down his foes. Marching ahead of his team, he locks his enemies in battle then counters their blows with a deadly spin of his weapon. Slamming his culling blade through a weakened enemy, he is always charging onward.",
                            ImgURL = "https://lh3.googleusercontent.com/oUTnwEbx0xPlPVRBikCWZD0-Ba0wup0exk0LVn1g3tjja-cZ3o9OutuOopGbanP01ACqbaxDZy5TpoFWpE-IkSwhVpyFzgrgRekcnUtaJIUm-zj7ghvghbhidO_uE9Z7Xt_zuIbcFw=w2400",
                            Name = "Axe"
                        },
                        new
                        {
                            Id = 7,
                            AttackType = "Ranged",
                            Attribute = "Intelligence",
                            Description = "Bane brings terror to his enemies with his arsenal of disabling abilities. Whether trapping a foe within a contagious nightmare, or gripping an enemy in place, he gives allies all the time they need to slay their enemy.",
                            ImgURL = "https://lh3.googleusercontent.com/JZWgMILBfdrO3K2-fy1f3ebg80L1prQ10H9D2lGYv5W0s88zgX21Mvc6Hwk8r_f10X8cCU1pkGW-XU1IB7fr3OyNbxbxJ_tmwwfvCfTTkxhusipJYM_UFdjt6ODQBUPUJ4eDPS8VUA=w2400",
                            Name = "Bane"
                        },
                        new
                        {
                            Id = 8,
                            AttackType = "Ranged",
                            Attribute = "Intelligence",
                            Description = "Once he takes to the skies, Batrider can strike from any direction. Snatching a foe with his lasso, he soars above the treetops, pulling his prey through a trail of flame as he drags them before his merciless allies.",
                            ImgURL = "https://lh3.googleusercontent.com/fkeYPDMsqvczU9bE_mDh7NfCG5lnIKHxgGa83KLnztLzJKCw2CC4D_4xp1NAzC66wFGZcQOFCyjtq_tfHKNj-dCdPwHdjdA8togr53YANrfAJlZ9xIjaptB9zK4xArV3tvbJpkxREw=w2400",
                            Name = "Batrider"
                        },
                        new
                        {
                            Id = 9,
                            AttackType = "Melee",
                            Attribute = "Strength",
                            Description = "Summoning a poison-spitting boar and a scouting hawk to aid his hunt, Beastmaster never stalks the battlefield unprepared. Chopping through the forest with his axes, his stunning roar opens the way for his allies to devastate enemies.",
                            ImgURL = "https://lh3.googleusercontent.com/ytZUKh7bpb4dR6Lx3nj146B7rqwNsoZ0oecd4kDFZUtV4LtVPJ0vjWdmWUn9pgx7ua8J9V1RjL03Ip8t-RvkRVUT-3vqCHummu-Kq_HJ909FFuOMOHeIZVcwy1AljF5h6u5o2ntM0Q=w2400",
                            Name = "Beastmaster"
                        },
                        new
                        {
                            Id = 10,
                            AttackType = "Melee",
                            Attribute = "Agility",
                            Description = "Bloodseeker forces difficult decisions on his enemies. Able to drive his foes to a retreat by bathing a large area with a damaging ritual, his gruesome ultimate asks his opponents to hold still, or die.",
                            ImgURL = "https://lh3.googleusercontent.com/EhxOIuZUNPJHxA2s_9yQjlqaCgWnFrLpEurNLvr_3xJpgoXCph30X53HKSKYkwRBQxwjqhTAgTsUtOL6t93op54LEM8FnkMB3_nSf0vMJZS_IUCBRORCbv6ohka88Dt46SfPE-6ilQ=w2400",
                            Name = "Bloodseeker"
                        },
                        new
                        {
                            Id = 11,
                            AttackType = "Melee",
                            Attribute = "Agility",
                            Description = "Sneaking invisibly at the heels of his enemies, Bounty Hunter is always keeping track of his foes. Whenever one of his targets falls in battle, he and his allies stand to make quite a profit.",
                            ImgURL = "https://lh3.googleusercontent.com/qVj6cvcuFt-wox9nlg9iJwsQbaLj5ld-ICe6c70aw0lDs9z3lIGul7O7XRSMXzppone9gZnhMDivA9LaVjH1UwYPMaGdWtuStqs3iaZlMvULBGDZImMmEoYuT3ftFL5ravkFYnu-CA=w2400",
                            Name = "Bounty Hunter"
                        },
                        new
                        {
                            Id = 12,
                            AttackType = "Melee",
                            Attribute = "Strength",
                            Description = "A fearsome fighter in any situation, Brewmaster can turn the tide of battle by splitting into three elemental spirits, each with their own unique abilities. When not divided, he brings drunken chaos to his foes with slowing claps and powerful swings of his staff.",
                            ImgURL = "https://lh3.googleusercontent.com/JWgYxAT_EWqRs2JJrTbG-EVPT82bevxjK7Kd1SNS86_o1RjkJ6G5NzDGHswSit6VtvL-oRedv_2V7OefIxoe24KlLNGOkbOZFLHJ71oV2QRVCpLmO6V19l5_037FXDDTNDf0ISBkkQ=w2400",
                            Name = "Brewmaster"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
