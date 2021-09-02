﻿// <auto-generated />
using Elsa.WorkflowSettings.Persistence.EntityFramework.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Elsa.WorkflowSettings.Persistence.EntityFramework.Sqlite.Migrations
{
    [DbContext(typeof(WorkflowSettingsContext))]
    [Migration("20210723101352_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Elsa")
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Elsa.WorkflowSettings.Models.WorkflowSetting", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowBlueprintId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .HasDatabaseName("IX_WorkflowSetting_Key");

                    b.HasIndex("Value")
                        .HasDatabaseName("IX_WorkflowSetting_Value");

                    b.HasIndex("WorkflowBlueprintId")
                        .HasDatabaseName("IX_WorkflowSetting_WorkflowBlueprintId");

                    b.ToTable("WorkflowSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
