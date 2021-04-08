﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TASagentTwitchBot.Standard.Database;

namespace TASagentTwitchBot.Standard.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210712174020_AddingTTSSpeed")]
    partial class AddingTTSSpeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("TASagentTwitchBot.Core.Database.CustomTextCommand", b =>
                {
                    b.Property<int>("CustomTextCommandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Command")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomTextCommandId");

                    b.ToTable("CustomTextCommands");
                });

            modelBuilder.Entity("TASagentTwitchBot.Core.Database.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("CreatorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FakeNewsExplanation")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFakeNews")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QuoteText")
                        .HasColumnType("TEXT");

                    b.Property<string>("Speaker")
                        .HasColumnType("TEXT");

                    b.HasKey("QuoteId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("TASagentTwitchBot.Core.Database.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorizationLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FirstFollowed")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FirstSeen")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastSuccessfulTTS")
                        .HasColumnType("TEXT");

                    b.Property<string>("TTSEffectsChain")
                        .HasColumnType("TEXT");

                    b.Property<int>("TTSPitchPreference")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TTSSpeedPreference")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TTSVoicePreference")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TwitchUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TwitchUserName")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TASagentTwitchBot.Standard.Database.SupplementalData", b =>
                {
                    b.Property<int>("SupplementalDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastPointsSpentUpdate")
                        .HasColumnType("TEXT");

                    b.Property<int>("PointsSpent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SupplementalDataId");

                    b.HasIndex("UserId");

                    b.ToTable("SupplementalData");
                });

            modelBuilder.Entity("TASagentTwitchBot.Core.Database.Quote", b =>
                {
                    b.HasOne("TASagentTwitchBot.Core.Database.User", "Creator")
                        .WithMany("QuotesCreated")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("TASagentTwitchBot.Standard.Database.SupplementalData", b =>
                {
                    b.HasOne("TASagentTwitchBot.Core.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TASagentTwitchBot.Core.Database.User", b =>
                {
                    b.Navigation("QuotesCreated");
                });
#pragma warning restore 612, 618
        }
    }
}
