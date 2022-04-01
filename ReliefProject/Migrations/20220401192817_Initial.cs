using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReliefProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    DonationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Discount = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    ProductionId = table.Column<int>(nullable: false),
                    HumanitarianId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.DonationId);
                });

            migrationBuilder.CreateTable(
                name: "Humanitarians",
                columns: table => new
                {
                    OrgId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrgName = table.Column<string>(nullable: false),
                    OrgPhone = table.Column<string>(nullable: false),
                    OrgAddress = table.Column<string>(nullable: false),
                    OrgCity = table.Column<string>(nullable: false),
                    OrgState = table.Column<string>(nullable: true),
                    OrgZip = table.Column<string>(nullable: true),
                    OrgCountry = table.Column<string>(nullable: false),
                    RequesterFirstName = table.Column<string>(nullable: false),
                    RequesterLastName = table.Column<string>(nullable: false),
                    RequesterEmail = table.Column<string>(nullable: false),
                    RequesterPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humanitarians", x => x.OrgId);
                });

            migrationBuilder.CreateTable(
                name: "Productions",
                columns: table => new
                {
                    ProductionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SupplierId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productions", x => x.ProductionId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    AidType = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    HumanitarianId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    OrgId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrgName = table.Column<string>(nullable: false),
                    OrgPhone = table.Column<string>(nullable: false),
                    OrgAddress = table.Column<string>(nullable: false),
                    OrgCity = table.Column<string>(nullable: false),
                    OrgState = table.Column<string>(nullable: true),
                    OrgZip = table.Column<string>(nullable: true),
                    OrgCountry = table.Column<string>(nullable: false),
                    SupplierFirstName = table.Column<string>(nullable: false),
                    SupplierLastName = table.Column<string>(nullable: false),
                    SupplierEmail = table.Column<string>(nullable: false),
                    SupplierPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.OrgId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Clothing" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Toiletries" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Food" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Furniture" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Toys" });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "DonationId", "Discount", "HumanitarianId", "Notes", "ProductionId", "Quantity", "TimeStamp" },
                values: new object[] { 4, "Free", 2, "Manufacturing Issues", 3, 500, new DateTime(2022, 4, 1, 13, 28, 17, 268, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "DonationId", "Discount", "HumanitarianId", "Notes", "ProductionId", "Quantity", "TimeStamp" },
                values: new object[] { 3, "50% Off", 2, "", 3, 4500, new DateTime(2022, 4, 1, 13, 28, 17, 268, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "DonationId", "Discount", "HumanitarianId", "Notes", "ProductionId", "Quantity", "TimeStamp" },
                values: new object[] { 5, "Free", 3, "", 4, 1200, new DateTime(2022, 4, 1, 13, 28, 17, 268, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "DonationId", "Discount", "HumanitarianId", "Notes", "ProductionId", "Quantity", "TimeStamp" },
                values: new object[] { 1, "Free", 1, "", 1, 500, new DateTime(2022, 4, 1, 13, 28, 17, 259, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "DonationId", "Discount", "HumanitarianId", "Notes", "ProductionId", "Quantity", "TimeStamp" },
                values: new object[] { 2, "Free", 3, "", 2, 1000, new DateTime(2022, 4, 1, 13, 28, 17, 268, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.InsertData(
                table: "Humanitarians",
                columns: new[] { "OrgId", "OrgAddress", "OrgCity", "OrgCountry", "OrgName", "OrgPhone", "OrgState", "OrgZip", "RequesterEmail", "RequesterFirstName", "RequesterLastName", "RequesterPhone" },
                values: new object[] { 1, "88 Hamilton Ave", "Stamford", "United States of America", "AmeriCares", "203-658-9500", "CT", "06902", "requester@americares.org", "John", "Adams", "555-765-4321" });

            migrationBuilder.InsertData(
                table: "Humanitarians",
                columns: new[] { "OrgId", "OrgAddress", "OrgCity", "OrgCountry", "OrgName", "OrgPhone", "OrgState", "OrgZip", "RequesterEmail", "RequesterFirstName", "RequesterLastName", "RequesterPhone" },
                values: new object[] { 2, "430 17th Street NW", "Washington DC", "United States of America", "Red Cross", "202-303-4498", "DC", "20006", "requester@redcross.org", "George", "Washington", "555-123-4567" });

            migrationBuilder.InsertData(
                table: "Humanitarians",
                columns: new[] { "OrgId", "OrgAddress", "OrgCity", "OrgCountry", "OrgName", "OrgPhone", "OrgState", "OrgZip", "RequesterEmail", "RequesterFirstName", "RequesterLastName", "RequesterPhone" },
                values: new object[] { 3, "78 rue de Lausanne Case Postale 116", "Geneva", "Switzerland", "Doctors Without Borders", "212-763-5779", "CH", "1211", "requester@doctors.org", "James", "Madison", "555-666-7777" });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "ProductionId", "Notes", "ProductId", "SupplierId" },
                values: new object[] { 1, "40 Count", 1, 4 });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "ProductionId", "Notes", "ProductId", "SupplierId" },
                values: new object[] { 7, "12 Count", 4, 6 });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "ProductionId", "Notes", "ProductId", "SupplierId" },
                values: new object[] { 6, "", 3, 6 });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "ProductionId", "Notes", "ProductId", "SupplierId" },
                values: new object[] { 5, "40 Count", 1, 6 });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "ProductionId", "Notes", "ProductId", "SupplierId" },
                values: new object[] { 4, "24 Count", 4, 5 });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "ProductionId", "Notes", "ProductId", "SupplierId" },
                values: new object[] { 3, "12 Count", 4, 4 });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "ProductionId", "Notes", "ProductId", "SupplierId" },
                values: new object[] { 2, "", 2, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Notes", "ProductName", "Size" },
                values: new object[] { 3, 5, "Women's Size", "Basketball", "29 in" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Notes", "ProductName", "Size" },
                values: new object[] { 4, 2, "", "Paper Towel", "11 in" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Notes", "ProductName", "Size" },
                values: new object[] { 2, 1, "", "T-Shirt", "M" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Notes", "ProductName", "Size" },
                values: new object[] { 1, 3, "", "Water Bottle", "1L" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Notes", "ProductName", "Size" },
                values: new object[] { 5, 4, "Queen Size", "Mattress", "60X80 in" });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "RequestId", "AidType", "Amount", "HumanitarianId", "Notes", "ProductId", "TimeStamp" },
                values: new object[] { 1, "Natural Disaster Recovery", 1500, 1, "", 1, new DateTime(2022, 4, 1, 13, 28, 17, 269, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "RequestId", "AidType", "Amount", "HumanitarianId", "Notes", "ProductId", "TimeStamp" },
                values: new object[] { 2, "Third World Production", 6000, 3, "", 4, new DateTime(2022, 4, 1, 13, 28, 17, 269, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "RequestId", "AidType", "Amount", "HumanitarianId", "Notes", "ProductId", "TimeStamp" },
                values: new object[] { 3, "Refugee Assistance", 200, 2, "", 5, new DateTime(2022, 4, 1, 13, 28, 17, 269, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "RequestId", "AidType", "Amount", "HumanitarianId", "Notes", "ProductId", "TimeStamp" },
                values: new object[] { 4, "Refugee Assistance", 2000, 2, "", 1, new DateTime(2022, 4, 1, 13, 28, 17, 269, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "OrgId", "OrgAddress", "OrgCity", "OrgCountry", "OrgName", "OrgPhone", "OrgState", "OrgZip", "SupplierEmail", "SupplierFirstName", "SupplierLastName", "SupplierPhone" },
                values: new object[] { 5, "1634 Beach Ave", "Mehoopany", "United States of America", "Bounty", "570-833-5141", "PA", "18629", "supplier@bounty.org", "Alexander", "Hamilton", "555-333-4444" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "OrgId", "OrgAddress", "OrgCity", "OrgCountry", "OrgName", "OrgPhone", "OrgState", "OrgZip", "SupplierEmail", "SupplierFirstName", "SupplierLastName", "SupplierPhone" },
                values: new object[] { 4, "999 Lake Drive", "Issaquah", "United States of America", "Kirkland", "425-313-8100", "WA", "98027", "supplier@kirkland.org", "James", "Monroe", "555-111-2222" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "OrgId", "OrgAddress", "OrgCity", "OrgCountry", "OrgName", "OrgPhone", "OrgState", "OrgZip", "SupplierEmail", "SupplierFirstName", "SupplierLastName", "SupplierPhone" },
                values: new object[] { 6, "702 SW 8th St", "St Bentonville", "United States of America", "Great Value", "801-221-0600", "AK", "72716", "supplier@walmart.org", "Benjamin", "Franklin", "555-888-9999" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Humanitarians");

            migrationBuilder.DropTable(
                name: "Productions");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
