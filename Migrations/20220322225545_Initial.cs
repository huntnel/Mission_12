using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission_12.Migrations
{
    public partial class Initial : Migration
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
                values: new object[] { 1, true, "2022-03-22", "08:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 66, false, "2022-03-27", "08:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 65, false, "2022-03-26", "20:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 64, false, "2022-03-26", "19:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 63, false, "2022-03-26", "18:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 62, false, "2022-03-26", "17:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 61, false, "2022-03-26", "16:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 60, false, "2022-03-26", "15:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 59, false, "2022-03-26", "14:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 58, false, "2022-03-26", "13:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 57, false, "2022-03-26", "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 56, false, "2022-03-26", "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 55, false, "2022-03-26", "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 54, false, "2022-03-26", "09:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 53, false, "2022-03-26", "08:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 52, false, "2022-03-25", "20:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 51, false, "2022-03-25", "19:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 50, false, "2022-03-25", "18:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 49, false, "2022-03-25", "17:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 48, false, "2022-03-25", "16:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 67, false, "2022-03-27", "09:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 47, false, "2022-03-25", "15:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 68, false, "2022-03-27", "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 70, false, "2022-03-27", "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 89, false, "2022-03-28", "18:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 88, false, "2022-03-28", "17:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 87, false, "2022-03-28", "16:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 86, false, "2022-03-28", "15:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 85, false, "2022-03-28", "14:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 84, false, "2022-03-28", "13:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 83, false, "2022-03-28", "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 82, false, "2022-03-28", "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 81, false, "2022-03-28", "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 80, false, "2022-03-28", "09:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 79, false, "2022-03-28", "08:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 78, false, "2022-03-27", "20:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 77, false, "2022-03-27", "19:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 76, false, "2022-03-27", "18:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 75, false, "2022-03-27", "17:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 74, false, "2022-03-27", "16:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 73, false, "2022-03-27", "15:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 72, false, "2022-03-27", "14:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 71, false, "2022-03-27", "13:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 69, false, "2022-03-27", "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 90, false, "2022-03-28", "19:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 46, false, "2022-03-25", "14:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 44, false, "2022-03-25", "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 15, false, "2022-03-23", "14:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 14, false, "2022-03-23", "13:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 13, false, "2022-03-23", "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 12, false, "2022-03-23", "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 11, false, "2022-03-23", "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 10, false, "2022-03-23", "09:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 9, false, "2022-03-23", "08:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 26, false, "2022-03-22", "20:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 25, false, "2022-03-22", "19:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 24, false, "2022-03-22", "18:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 23, false, "2022-03-22", "17:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 22, false, "2022-03-22", "16:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 8, false, "2022-03-22", "15:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 7, false, "2022-03-22", "14:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 6, false, "2022-03-22", "13:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 5, false, "2022-03-22", "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 4, false, "2022-03-22", "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 3, false, "2022-03-22", "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 2, false, "2022-03-22", "09:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 16, false, "2022-03-23", "15:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 45, false, "2022-03-25", "13:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 17, false, "2022-03-23", "16:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 19, false, "2022-03-23", "18:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 43, false, "2022-03-25", "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 42, false, "2022-03-25", "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 41, false, "2022-03-25", "09:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 40, false, "2022-03-25", "08:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 39, false, "2022-03-24", "20:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 38, false, "2022-03-24", "19:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 37, false, "2022-03-24", "18:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 36, false, "2022-03-24", "17:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 35, false, "2022-03-24", "16:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 34, false, "2022-03-24", "15:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 33, false, "2022-03-24", "14:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 32, false, "2022-03-24", "13:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 31, false, "2022-03-24", "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 30, false, "2022-03-24", "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 29, false, "2022-03-24", "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 28, false, "2022-03-24", "09:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 27, false, "2022-03-24", "08:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 21, false, "2022-03-23", "20:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 20, false, "2022-03-23", "19:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 18, false, "2022-03-23", "17:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "Id", "Booked", "Date", "Time" },
                values: new object[] { 91, false, "2022-03-28", "20:00" });

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
