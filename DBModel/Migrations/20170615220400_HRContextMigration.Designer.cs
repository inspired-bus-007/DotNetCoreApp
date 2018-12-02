using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DotNetCoreApp.DBModel;

namespace DotNetCoreApp_FinalOnLinux.DBModel.Migrations
{
    [DbContext(typeof(HRContext))]
    [Migration("20170615220400_HRContextMigration")]
    partial class HRContextMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotNetCoreApp.DBModel.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DotNetCoreApp.DBModel.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .HasMaxLength(100);

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DotNetCoreApp.DBModel.RoleAssignment", b =>
                {
                    b.Property<int>("RoleAssignmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("End");

                    b.Property<string>("Position")
                        .HasMaxLength(30);

                    b.Property<int>("ProjectId");

                    b.Property<DateTime>("Start");

                    b.HasKey("RoleAssignmentId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("RoleAssignments");
                });

            modelBuilder.Entity("DotNetCoreApp.DBModel.RoleAssignment", b =>
                {
                    b.HasOne("DotNetCoreApp.DBModel.Employee", "Employee")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DotNetCoreApp.DBModel.Project", "Project")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
