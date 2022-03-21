using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission_12.Migrations
{
    public partial class Appointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: false),
                    Booked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeSlotId = table.Column<int>(nullable: true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_TimeSlots_TimeSlotId",
                        column: x => x.TimeSlotId,
                        principalTable: "TimeSlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 1, false, "03-22-2021", "08:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 19, false, "03-23-2021", "18:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 18, false, "03-23-2021", "17:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 17, false, "03-23-2021", "16:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 16, false, "03-23-2021", "15:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 15, false, "03-23-2021", "14:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 14, false, "03-23-2021", "13:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 13, false, "03-23-2021", "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 12, false, "03-23-2021", "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 11, false, "03-23-2021", "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 10, false, "03-23-2021", "09:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 9, false, "03-23-2021", "08:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 26, false, "03-22-2021", "20:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 25, false, "03-22-2021", "19:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 24, false, "03-22-2021", "18:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 23, false, "03-22-2021", "17:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 22, false, "03-22-2021", "16:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 8, false, "03-22-2021", "15:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 7, false, "03-22-2021", "14:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 6, false, "03-22-2021", "13:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 5, false, "03-22-2021", "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 4, false, "03-22-2021", "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 3, false, "03-22-2021", "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 2, false, "03-22-2021", "09:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 20, false, "03-23-2021", "19:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 21, false, "03-23-2021", "20:00" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TimeSlotId",
                table: "Appointments",
                column: "TimeSlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "TimeSlots");
        }
    }
}
