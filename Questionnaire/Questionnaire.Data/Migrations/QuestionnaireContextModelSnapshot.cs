﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Questionnaire.Data;

namespace Questionnaire.Data.Migrations
{
    [DbContext(typeof(QuestionnaireContext))]
    partial class QuestionnaireContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Questionnaire.Data.Entities.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<DateTime>("DateBorn");

                    b.Property<int>("Gender");

                    b.Property<int>("MaritalStatus");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Programming");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
