﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PatientService.Data;

#nullable disable

namespace PatientService.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20240924185523_Relation-Patients-MeidcalRecord-Prescriptions")]
    partial class RelationPatientsMeidcalRecordPrescriptions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PatientService.Model.MedicalRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateOfVisit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<string>("Treatment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("PatientService.Model.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PatientService.Model.Prescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MedicationName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("PatientService.Model.MedicalRecord", b =>
                {
                    b.HasOne("PatientService.Model.Patient", null)
                        .WithMany("MedicalHistory")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("PatientService.Model.Prescription", b =>
                {
                    b.HasOne("PatientService.Model.Patient", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("PatientService.Model.Patient", b =>
                {
                    b.Navigation("MedicalHistory");

                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
