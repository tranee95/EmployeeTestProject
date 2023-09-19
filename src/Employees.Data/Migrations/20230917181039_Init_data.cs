using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employees.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "departments",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("1e48d94f-1e05-4f5b-9633-dc044926c23d"), "department_1" },
                    { new Guid("b52b0cb3-c535-4484-86fe-3ffc52a65995"), "departments_2" }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "id", "department_id", "name", "surname", "patronymic", "date_birth", "date_employment", "salary" },
                values: new object[,]
                {
                    { new Guid("c7f4bf4c-29e6-483c-835f-67649658e70d"), new Guid("1e48d94f-1e05-4f5b-9633-dc044926c23d"), "Иванов", "Иван", "Ивановимч", DateTime.Now.AddYears(-20), DateTime.Now.AddYears(-1), 10000.0 },
                    { new Guid("d0b16bd0-1084-421a-bea7-6cda0d5e742e"), new Guid("1e48d94f-1e05-4f5b-9633-dc044926c23d"), "Кудрявцев", "Адам", "Авдеевич", DateTime.Now.AddYears(-70), DateTime.Now.AddYears(-2), 68000.0 },
                    { new Guid("ced254e5-1d56-4afe-b83f-c2bca7635c05"), new Guid("1e48d94f-1e05-4f5b-9633-dc044926c23d"), "Бобылёв", "Людвиг", "Рубенович", DateTime.Now.AddYears(-25), DateTime.Now.AddYears(-3), 20000.0 },
                    { new Guid("a4a1b4a2-a7a2-499e-972d-51d55f30faa7"), new Guid("1e48d94f-1e05-4f5b-9633-dc044926c23d"), "Кулагин", "Мирон", "Михайлович", DateTime.Now.AddYears(-43), DateTime.Now.AddYears(-5), 120000.0 },
                    { new Guid("cdbe2d6d-ee24-49b8-ad86-f7d7d0da4ddc"), new Guid("b52b0cb3-c535-4484-86fe-3ffc52a65995"), "Туров", "Варлам", "Богданович", DateTime.Now.AddYears(-35), DateTime.Now.AddYears(-1), 45000.0 },
                    { new Guid("5b16189c-3d76-4829-8ee2-371f178a175e"), new Guid("b52b0cb3-c535-4484-86fe-3ffc52a65995"), "Агафонов", "Герасим", "Георгиевич", DateTime.Now.AddYears(-26), DateTime.Now.AddYears(-1), 87000.0 },
                    { new Guid("7e969cb1-9e92-407a-93e5-b3c15007378a"), new Guid("b52b0cb3-c535-4484-86fe-3ffc52a65995"), "Пестов", "Илларион", "Борисович", DateTime.Now.AddYears(-21), DateTime.Now.AddYears(-2), 78000.0 },
                    { new Guid("e912c6b7-9185-4a62-9eff-a420218815cb"), new Guid("b52b0cb3-c535-4484-86fe-3ffc52a65995"), "Ситников", "Бенедикт", "Валерьевич", DateTime.Now.AddYears(-25), DateTime.Now.AddYears(-3), 13000.0 },
                    { new Guid("c8183b9c-a8aa-4633-bc78-6eb574f2e0a7"), new Guid("b52b0cb3-c535-4484-86fe-3ffc52a65995"), "Самойлов", "Владислав", "Мэлсович", DateTime.Now.AddYears(-29), DateTime.Now.AddYears(-4), 189000.0 },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "departments",
                keyColumn: "id",
                keyValue: new object[,]
                {
                    { new Guid("1e48d94f-1e05-4f5b-9633-dc044926c23d") },
                    { new Guid("b52b0cb3-c535-4484-86fe-3ffc52a65995") }
                });

            migrationBuilder.DeleteData(
                table: "employees",
                keyColumn: "id",
                keyValue: new object[,]
                {
                    { new Guid("c7f4bf4c-29e6-483c-835f-67649658e70d") },
                    { new Guid("d0b16bd0-1084-421a-bea7-6cda0d5e742e") },
                    { new Guid("ced254e5-1d56-4afe-b83f-c2bca7635c05") },
                    { new Guid("a4a1b4a2-a7a2-499e-972d-51d55f30faa7") },
                    { new Guid("cdbe2d6d-ee24-49b8-ad86-f7d7d0da4ddc") },
                    { new Guid("5b16189c-3d76-4829-8ee2-371f178a175e") },
                    { new Guid("7e969cb1-9e92-407a-93e5-b3c15007378a") },
                    { new Guid("e912c6b7-9185-4a62-9eff-a420218815cb") },
                    { new Guid("c8183b9c-a8aa-4633-bc78-6eb574f2e0a7") }
                });
        }
    }
}
