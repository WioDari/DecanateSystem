using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Decanate.Migrations
{
    public partial class n3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decanates_Groups_Groupsid",
                table: "Decanates");

            migrationBuilder.DropForeignKey(
                name: "FK_Decanates_Infos_Infosid",
                table: "Decanates");

            migrationBuilder.DropForeignKey(
                name: "FK_Decanates_PayFlows_PayFlowsid",
                table: "Decanates");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Students_Studentsid",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Evaluations_Evaluationsid",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Infos_Infosid",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_PayFlows_PayFlowsid",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Evaluationsid",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Infosid",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Decanates_Groupsid",
                table: "Decanates");

            migrationBuilder.DropIndex(
                name: "IX_Decanates_Infosid",
                table: "Decanates");

            migrationBuilder.DropIndex(
                name: "IX_Decanates_PayFlowsid",
                table: "Decanates");

            migrationBuilder.DropColumn(
                name: "Evaluationsid",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Infosid",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Groupsid",
                table: "Decanates");

            migrationBuilder.DropColumn(
                name: "Infosid",
                table: "Decanates");

            migrationBuilder.DropColumn(
                name: "PayFlowsid",
                table: "Decanates");

            migrationBuilder.RenameColumn(
                name: "PayFlowsid",
                table: "Students",
                newName: "groups_id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_PayFlowsid",
                table: "Students",
                newName: "IX_Students_groups_id");

            migrationBuilder.RenameColumn(
                name: "Studentsid",
                table: "Groups",
                newName: "decanates_id");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_Studentsid",
                table: "Groups",
                newName: "IX_Groups_decanates_id");

            migrationBuilder.AddColumn<int>(
                name: "decanates_id",
                table: "PayFlows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "students_id",
                table: "PayFlows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "decanates_id",
                table: "Infos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "students_id",
                table: "Infos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "students_id",
                table: "Evaluations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PayFlows_decanates_id",
                table: "PayFlows",
                column: "decanates_id");

            migrationBuilder.CreateIndex(
                name: "IX_PayFlows_students_id",
                table: "PayFlows",
                column: "students_id");

            migrationBuilder.CreateIndex(
                name: "IX_Infos_decanates_id",
                table: "Infos",
                column: "decanates_id");

            migrationBuilder.CreateIndex(
                name: "IX_Infos_students_id",
                table: "Infos",
                column: "students_id");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_students_id",
                table: "Evaluations",
                column: "students_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Students_students_id",
                table: "Evaluations",
                column: "students_id",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Decanates_decanates_id",
                table: "Groups",
                column: "decanates_id",
                principalTable: "Decanates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_Decanates_decanates_id",
                table: "Infos",
                column: "decanates_id",
                principalTable: "Decanates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Infos_Students_students_id",
                table: "Infos",
                column: "students_id",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayFlows_Decanates_decanates_id",
                table: "PayFlows",
                column: "decanates_id",
                principalTable: "Decanates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PayFlows_Students_students_id",
                table: "PayFlows",
                column: "students_id",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_groups_id",
                table: "Students",
                column: "groups_id",
                principalTable: "Groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Students_students_id",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Decanates_decanates_id",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Infos_Decanates_decanates_id",
                table: "Infos");

            migrationBuilder.DropForeignKey(
                name: "FK_Infos_Students_students_id",
                table: "Infos");

            migrationBuilder.DropForeignKey(
                name: "FK_PayFlows_Decanates_decanates_id",
                table: "PayFlows");

            migrationBuilder.DropForeignKey(
                name: "FK_PayFlows_Students_students_id",
                table: "PayFlows");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_groups_id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_PayFlows_decanates_id",
                table: "PayFlows");

            migrationBuilder.DropIndex(
                name: "IX_PayFlows_students_id",
                table: "PayFlows");

            migrationBuilder.DropIndex(
                name: "IX_Infos_decanates_id",
                table: "Infos");

            migrationBuilder.DropIndex(
                name: "IX_Infos_students_id",
                table: "Infos");

            migrationBuilder.DropIndex(
                name: "IX_Evaluations_students_id",
                table: "Evaluations");

            migrationBuilder.DropColumn(
                name: "decanates_id",
                table: "PayFlows");

            migrationBuilder.DropColumn(
                name: "students_id",
                table: "PayFlows");

            migrationBuilder.DropColumn(
                name: "decanates_id",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "students_id",
                table: "Infos");

            migrationBuilder.DropColumn(
                name: "students_id",
                table: "Evaluations");

            migrationBuilder.RenameColumn(
                name: "groups_id",
                table: "Students",
                newName: "PayFlowsid");

            migrationBuilder.RenameIndex(
                name: "IX_Students_groups_id",
                table: "Students",
                newName: "IX_Students_PayFlowsid");

            migrationBuilder.RenameColumn(
                name: "decanates_id",
                table: "Groups",
                newName: "Studentsid");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_decanates_id",
                table: "Groups",
                newName: "IX_Groups_Studentsid");

            migrationBuilder.AddColumn<int>(
                name: "Evaluationsid",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Infosid",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Groupsid",
                table: "Decanates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Infosid",
                table: "Decanates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PayFlowsid",
                table: "Decanates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Evaluationsid",
                table: "Students",
                column: "Evaluationsid");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Infosid",
                table: "Students",
                column: "Infosid");

            migrationBuilder.CreateIndex(
                name: "IX_Decanates_Groupsid",
                table: "Decanates",
                column: "Groupsid");

            migrationBuilder.CreateIndex(
                name: "IX_Decanates_Infosid",
                table: "Decanates",
                column: "Infosid");

            migrationBuilder.CreateIndex(
                name: "IX_Decanates_PayFlowsid",
                table: "Decanates",
                column: "PayFlowsid");

            migrationBuilder.AddForeignKey(
                name: "FK_Decanates_Groups_Groupsid",
                table: "Decanates",
                column: "Groupsid",
                principalTable: "Groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Decanates_Infos_Infosid",
                table: "Decanates",
                column: "Infosid",
                principalTable: "Infos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Decanates_PayFlows_PayFlowsid",
                table: "Decanates",
                column: "PayFlowsid",
                principalTable: "PayFlows",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Students_Studentsid",
                table: "Groups",
                column: "Studentsid",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Evaluations_Evaluationsid",
                table: "Students",
                column: "Evaluationsid",
                principalTable: "Evaluations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Infos_Infosid",
                table: "Students",
                column: "Infosid",
                principalTable: "Infos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_PayFlows_PayFlowsid",
                table: "Students",
                column: "PayFlowsid",
                principalTable: "PayFlows",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
