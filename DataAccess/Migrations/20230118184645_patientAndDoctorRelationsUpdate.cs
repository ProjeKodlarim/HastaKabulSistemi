using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class patientAndDoctorRelationsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PatientInformations_DoctorId",
                table: "PatientInformations",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientInformations_Doctors_DoctorId",
                table: "PatientInformations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientInformations_Doctors_DoctorId",
                table: "PatientInformations");

            migrationBuilder.DropIndex(
                name: "IX_PatientInformations_DoctorId",
                table: "PatientInformations");
        }
    }
}
