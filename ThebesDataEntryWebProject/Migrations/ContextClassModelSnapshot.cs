// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThebesDataEntryWebProject.Models;

namespace ThebesDataEntryWebProject.Migrations
{
    [DbContext(typeof(ContextClass))]
    partial class ContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThebesDataEntryWebProject.Models.Person", b =>
                {
                    b.Property<int>("Person_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Person_Address");

                    b.Property<string>("Person_CV_Destination");

                    b.Property<string>("Person_Department");

                    b.Property<string>("Person_Division");

                    b.Property<string>("Person_Email");

                    b.Property<string>("Person_Grad");

                    b.Property<string>("Person_GraduationDate");

                    b.Property<string>("Person_Name");

                    b.Property<string>("Person_NationalID");

                    b.Property<string>("Person_Nationality");

                    b.Property<string>("Person_PhoneNumber");

                    b.Property<string>("Person_PresentJob");

                    b.Property<string>("Person_TelephoneNumber");

                    b.HasKey("Person_ID");

                    b.ToTable("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
