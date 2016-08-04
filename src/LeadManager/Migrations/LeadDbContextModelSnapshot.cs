using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LeadManager.Entities;

namespace LeadManager.Migrations
{
    [DbContext(typeof(LeadDbContext))]
    partial class LeadDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeadManager.Entities.Lead", b =>
                {
                    b.Property<int>("LeadId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Assigned");

                    b.Property<int>("Budget");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<DateTime>("Submitted");

                    b.HasKey("LeadId");

                    b.ToTable("Leads");
                });
        }
    }
}
