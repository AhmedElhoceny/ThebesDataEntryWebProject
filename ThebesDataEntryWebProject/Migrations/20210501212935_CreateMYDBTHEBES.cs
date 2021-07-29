using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThebesDataEntryWebProject.Migrations
{
    public partial class CreateMYDBTHEBES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Person_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Person_Name = table.Column<string>(nullable: true),
                    Person_Nationality = table.Column<string>(nullable: true),
                    Person_NationalID = table.Column<string>(nullable: true),
                    Person_Address = table.Column<string>(nullable: true),
                    Person_TelephoneNumber = table.Column<string>(nullable: true),
                    Person_PhoneNumber = table.Column<string>(nullable: true),
                    Person_Email = table.Column<string>(nullable: true),
                    Person_GraduationDate = table.Column<string>(nullable: true),
                    Person_Department = table.Column<string>(nullable: true),
                    Person_Division = table.Column<string>(nullable: true),
                    Person_Grad = table.Column<string>(nullable: true),
                    Person_PresentJob = table.Column<string>(nullable: true),
                    Person_CV_Destination = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Person_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
