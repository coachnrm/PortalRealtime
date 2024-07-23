using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortalRealTime.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PortalCarType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortalCarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalCarType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PortalClerk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortalName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalClerk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Remark",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RemarkName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remark", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrgencyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrgencyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrgencyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NurseRequest",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartPointId = table.Column<int>(type: "int", nullable: false),
                    EndPointId = table.Column<int>(type: "int", nullable: false),
                    PortalCarTypeId = table.Column<int>(type: "int", nullable: false),
                    UrgencyTypeId = table.Column<int>(type: "int", nullable: false),
                    PortalNameId = table.Column<int>(type: "int", nullable: false),
                    JobStatusId = table.Column<int>(type: "int", nullable: false),
                    RemarkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NurseRequest", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_NurseRequest_Department_EndPointId",
                        column: x => x.EndPointId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NurseRequest_Department_StartPointId",
                        column: x => x.StartPointId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NurseRequest_JobStatus_JobStatusId",
                        column: x => x.JobStatusId,
                        principalTable: "JobStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NurseRequest_PortalCarType_PortalCarTypeId",
                        column: x => x.PortalCarTypeId,
                        principalTable: "PortalCarType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NurseRequest_PortalClerk_PortalNameId",
                        column: x => x.PortalNameId,
                        principalTable: "PortalClerk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NurseRequest_Remark_RemarkId",
                        column: x => x.RemarkId,
                        principalTable: "Remark",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NurseRequest_UrgencyType_UrgencyTypeId",
                        column: x => x.UrgencyTypeId,
                        principalTable: "UrgencyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "OPD อายุรกรรม" },
                    { 2, "OPD ศัลยกรรม" },
                    { 3, "ห้องเจาะเลือด" },
                    { 4, "ห้อง x-ray" }
                });

            migrationBuilder.InsertData(
                table: "JobStatus",
                columns: new[] { "Id", "JobStatusName" },
                values: new object[,]
                {
                    { 1, "ร้องขอ" },
                    { 2, "จ่ายงาน" },
                    { 3, "กำลังเดินทาง" },
                    { 4, "การบริการเสร็จสิ้น" }
                });

            migrationBuilder.InsertData(
                table: "PortalCarType",
                columns: new[] { "Id", "PortalCarName" },
                values: new object[,]
                {
                    { 1, "รถนั่ง" },
                    { 2, "รถนอน" }
                });

            migrationBuilder.InsertData(
                table: "PortalClerk",
                columns: new[] { "Id", "PortalName" },
                values: new object[,]
                {
                    { 1, "รณรงค์ มาลามาศ" },
                    { 2, "กิตติ ภูมิบูรณ์" }
                });

            migrationBuilder.InsertData(
                table: "Remark",
                columns: new[] { "Id", "RemarkName" },
                values: new object[,]
                {
                    { 1, "ผู้ป่วยติดเชื้อ" },
                    { 2, "ผู้ป่วยอ้วน ขอเวรเปล 2 คน" }
                });

            migrationBuilder.InsertData(
                table: "UrgencyType",
                columns: new[] { "Id", "UrgencyName" },
                values: new object[,]
                {
                    { 1, "ปกติ" },
                    { 2, "ด่วน" },
                    { 3, "ด่วนมาก" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NurseRequest_EndPointId",
                table: "NurseRequest",
                column: "EndPointId");

            migrationBuilder.CreateIndex(
                name: "IX_NurseRequest_JobStatusId",
                table: "NurseRequest",
                column: "JobStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_NurseRequest_PortalCarTypeId",
                table: "NurseRequest",
                column: "PortalCarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NurseRequest_PortalNameId",
                table: "NurseRequest",
                column: "PortalNameId");

            migrationBuilder.CreateIndex(
                name: "IX_NurseRequest_RemarkId",
                table: "NurseRequest",
                column: "RemarkId");

            migrationBuilder.CreateIndex(
                name: "IX_NurseRequest_StartPointId",
                table: "NurseRequest",
                column: "StartPointId");

            migrationBuilder.CreateIndex(
                name: "IX_NurseRequest_UrgencyTypeId",
                table: "NurseRequest",
                column: "UrgencyTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NurseRequest");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "JobStatus");

            migrationBuilder.DropTable(
                name: "PortalCarType");

            migrationBuilder.DropTable(
                name: "PortalClerk");

            migrationBuilder.DropTable(
                name: "Remark");

            migrationBuilder.DropTable(
                name: "UrgencyType");
        }
    }
}
