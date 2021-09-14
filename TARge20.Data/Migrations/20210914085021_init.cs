using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kindergarden",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kindergarden", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NameOfGroup = table.Column<string>(nullable: true),
                    GroupType = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    EducatorId = table.Column<Guid>(nullable: true),
                    SeniorEducatorId = table.Column<Guid>(nullable: true),
                    MethodologistId = table.Column<Guid>(nullable: true),
                    ChildId = table.Column<Guid>(nullable: true),
                    CookId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GroupHistory = table.Column<string>(nullable: true),
                    ParentName = table.Column<string>(nullable: true),
                    ParentAddress = table.Column<string>(nullable: true),
                    ParentPhoneNumber = table.Column<int>(nullable: false),
                    ParentEmail = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Child_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cook",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HistoryOfJobs = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cook_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Educator",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HistoryOfJobs = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educator_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Meal = table.Column<string>(nullable: true),
                    TimeOfMeal = table.Column<DateTime>(nullable: false),
                    Portion = table.Column<int>(nullable: false),
                    DayOfServing = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Methodologist",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HistoryOfJobs = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Methodologist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Methodologist_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeniorEducator",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HistoryOfJobs = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeniorEducator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeniorEducator_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupQueue",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OpenGroups = table.Column<string>(nullable: true),
                    Slots = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: true),
                    ChildId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupQueue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupQueue_Child_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Child",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupQueue_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kitchen",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HistoryOfJobs = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CookId = table.Column<Guid>(nullable: true),
                    MenuId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kitchen_Cook_CookId",
                        column: x => x.CookId,
                        principalTable: "Cook",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kitchen_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Child_GroupId",
                table: "Child",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Cook_GroupId",
                table: "Cook",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Educator_GroupId",
                table: "Educator",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_ChildId",
                table: "Group",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_CookId",
                table: "Group",
                column: "CookId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_EducatorId",
                table: "Group",
                column: "EducatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_MethodologistId",
                table: "Group",
                column: "MethodologistId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_SeniorEducatorId",
                table: "Group",
                column: "SeniorEducatorId",
                unique: true,
                filter: "[SeniorEducatorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GroupQueue_ChildId",
                table: "GroupQueue",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupQueue_GroupId",
                table: "GroupQueue",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitchen_CookId",
                table: "Kitchen",
                column: "CookId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitchen_MenuId",
                table: "Kitchen",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_GroupId",
                table: "Menu",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Methodologist_GroupId",
                table: "Methodologist",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SeniorEducator_GroupId",
                table: "SeniorEducator",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Child_ChildId",
                table: "Group",
                column: "ChildId",
                principalTable: "Child",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Cook_CookId",
                table: "Group",
                column: "CookId",
                principalTable: "Cook",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Educator_EducatorId",
                table: "Group",
                column: "EducatorId",
                principalTable: "Educator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Methodologist_MethodologistId",
                table: "Group",
                column: "MethodologistId",
                principalTable: "Methodologist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Group_SeniorEducator_SeniorEducatorId",
                table: "Group",
                column: "SeniorEducatorId",
                principalTable: "SeniorEducator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Group_GroupId",
                table: "Child");

            migrationBuilder.DropForeignKey(
                name: "FK_Cook_Group_GroupId",
                table: "Cook");

            migrationBuilder.DropForeignKey(
                name: "FK_Educator_Group_GroupId",
                table: "Educator");

            migrationBuilder.DropForeignKey(
                name: "FK_Methodologist_Group_GroupId",
                table: "Methodologist");

            migrationBuilder.DropForeignKey(
                name: "FK_SeniorEducator_Group_GroupId",
                table: "SeniorEducator");

            migrationBuilder.DropTable(
                name: "GroupQueue");

            migrationBuilder.DropTable(
                name: "Kindergarden");

            migrationBuilder.DropTable(
                name: "Kitchen");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Child");

            migrationBuilder.DropTable(
                name: "Cook");

            migrationBuilder.DropTable(
                name: "Educator");

            migrationBuilder.DropTable(
                name: "Methodologist");

            migrationBuilder.DropTable(
                name: "SeniorEducator");
        }
    }
}
