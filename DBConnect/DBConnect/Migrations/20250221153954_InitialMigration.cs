using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace DBConnect.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "attachments",
                columns: table => new
                {
                    attachment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    attachment_type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    blob_storage_address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__attachme__B74DF4E2BE34FBA8", x => x.attachment_id);
                });

            migrationBuilder.CreateTable(
                name: "coins_wbs",
                columns: table => new
                {
                    cbs_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wbs_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__coins_wb__FE6B9C3F22AA2DB3", x => x.cbs_id);
                });

            migrationBuilder.CreateTable(
                name: "log_type",
                columns: table => new
                {
                    log_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    log_type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__log_type__9E2397E0F1186BB3", x => x.log_id);
                });

            migrationBuilder.CreateTable(
                name: "orgs",
                columns: table => new
                {
                    org_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    organisation_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__orgs__F6AD8012A55C4456", x => x.org_id);
                });

            migrationBuilder.CreateTable(
                name: "package_information",
                columns: table => new
                {
                    package_id = table.Column<int>(type: "int", nullable: false),
                    package_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__package___63846AE83CD40F73", x => x.package_id);
                });

            migrationBuilder.CreateTable(
                name: "project_information",
                columns: table => new
                {
                    project_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    project_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    project_code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__project___BC799E1F41B4BE7F", x => x.project_id);
                });

            migrationBuilder.CreateTable(
                name: "site_info",
                columns: table => new
                {
                    site_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__site_inf__B22FDBCA9E6A154C", x => x.site_id);
                });

            migrationBuilder.CreateTable(
                name: "staff",
                columns: table => new
                {
                    staff_id = table.Column<int>(type: "int", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__staff__1963DD9C430315CB", x => x.staff_id);
                });

            migrationBuilder.CreateTable(
                name: "trades",
                columns: table => new
                {
                    trade_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trade_description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__trades__AAFF5BF7117EF3FF", x => x.trade_id);
                });

            migrationBuilder.CreateTable(
                name: "weather_data",
                columns: table => new
                {
                    weather_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    temperature = table.Column<int>(type: "int", nullable: false),
                    weather_conditions = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    wind_speed = table.Column<int>(type: "int", nullable: true),
                    longitude = table.Column<Point>(type: "geography", nullable: false),
                    latitude = table.Column<Point>(type: "geography", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__weather___4CDA2101E16CD1F6", x => x.weather_id);
                });

            migrationBuilder.CreateTable(
                name: "downtime",
                columns: table => new
                {
                    downtime_log_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    site_key = table.Column<int>(type: "int", nullable: false),
                    cbs_key = table.Column<int>(type: "int", nullable: false),
                    downtime_hours = table.Column<TimeOnly>(type: "time", nullable: true),
                    no_of_people_affected = table.Column<int>(type: "int", nullable: true),
                    lost_man_hours = table.Column<TimeOnly>(type: "time", nullable: true),
                    issues_delays = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    impact = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    details = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    attachment_key = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__downtime__1C118E0182F3D303", x => x.downtime_log_id);
                    table.ForeignKey(
                        name: "FK__downtime__attach__3B75D760",
                        column: x => x.attachment_key,
                        principalTable: "attachments",
                        principalColumn: "attachment_id");
                });

            migrationBuilder.CreateTable(
                name: "site_cbs",
                columns: table => new
                {
                    site_cbs_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cbs_key = table.Column<int>(type: "int", nullable: false),
                    project_key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__site_cbs__E71622130CA3366F", x => x.site_cbs_id);
                    table.ForeignKey(
                        name: "FK__site_cbs__cbs_ke__4D94879B",
                        column: x => x.cbs_key,
                        principalTable: "coins_wbs",
                        principalColumn: "cbs_id");
                    table.ForeignKey(
                        name: "FK__site_cbs__projec__4E88ABD4",
                        column: x => x.project_key,
                        principalTable: "project_information",
                        principalColumn: "project_id");
                });

            migrationBuilder.CreateTable(
                name: "site_orgs",
                columns: table => new
                {
                    site_orgs_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    org_key = table.Column<int>(type: "int", nullable: false),
                    site_key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__site_org__76C35F2D06939FB7", x => x.site_orgs_id);
                    table.ForeignKey(
                        name: "FK__site_orgs__org_k__5535A963",
                        column: x => x.org_key,
                        principalTable: "orgs",
                        principalColumn: "org_id");
                    table.ForeignKey(
                        name: "FK__site_orgs__site___5629CD9C",
                        column: x => x.site_key,
                        principalTable: "site_info",
                        principalColumn: "site_id");
                });

            migrationBuilder.CreateTable(
                name: "site_packages",
                columns: table => new
                {
                    site_packages_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    package_key = table.Column<int>(type: "int", nullable: false),
                    site_key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__site_pac__9C9A65CAB4FBF30F", x => x.site_packages_id);
                    table.ForeignKey(
                        name: "FK__site_pack__packa__59063A47",
                        column: x => x.package_key,
                        principalTable: "package_information",
                        principalColumn: "package_id");
                    table.ForeignKey(
                        name: "FK__site_pack__site___59FA5E80",
                        column: x => x.site_key,
                        principalTable: "site_info",
                        principalColumn: "site_id");
                });

            migrationBuilder.CreateTable(
                name: "site_trades",
                columns: table => new
                {
                    site_trades_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trade_key = table.Column<int>(type: "int", nullable: false),
                    project_key = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__site_tra__7094B1E5F8EE658F", x => x.site_trades_id);
                    table.ForeignKey(
                        name: "FK__site_trad__proje__52593CB8",
                        column: x => x.project_key,
                        principalTable: "project_information",
                        principalColumn: "project_id");
                    table.ForeignKey(
                        name: "FK__site_trad__trade__5165187F",
                        column: x => x.trade_key,
                        principalTable: "trades",
                        principalColumn: "trade_id");
                });

            migrationBuilder.CreateTable(
                name: "diary_entries",
                columns: table => new
                {
                    diary_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    project_id = table.Column<int>(type: "int", nullable: false),
                    staff_id = table.Column<int>(type: "int", nullable: false),
                    log_type_id = table.Column<int>(type: "int", nullable: false),
                    organisation_id = table.Column<int>(type: "int", nullable: false),
                    weather_id = table.Column<int>(type: "int", nullable: true),
                    created = table.Column<DateTime>(type: "datetime", nullable: false),
                    to_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    from_datetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    problems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    works_location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__diary_en__339232C83A2070F2", x => x.diary_id);
                    table.ForeignKey(
                        name: "FK__diary_ent__log_t__5EBF139D",
                        column: x => x.log_type_id,
                        principalTable: "log_type",
                        principalColumn: "log_id");
                    table.ForeignKey(
                        name: "FK__diary_ent__organ__5FB337D6",
                        column: x => x.organisation_id,
                        principalTable: "orgs",
                        principalColumn: "org_id");
                    table.ForeignKey(
                        name: "FK__diary_ent__proje__5CD6CB2B",
                        column: x => x.project_id,
                        principalTable: "project_information",
                        principalColumn: "project_id");
                    table.ForeignKey(
                        name: "FK__diary_ent__staff__5DCAEF64",
                        column: x => x.staff_id,
                        principalTable: "staff",
                        principalColumn: "staff_id");
                    table.ForeignKey(
                        name: "FK__diary_ent__weath__60A75C0F",
                        column: x => x.weather_id,
                        principalTable: "weather_data",
                        principalColumn: "weather_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_diary_entries_log_type_id",
                table: "diary_entries",
                column: "log_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_diary_entries_organisation_id",
                table: "diary_entries",
                column: "organisation_id");

            migrationBuilder.CreateIndex(
                name: "IX_diary_entries_project_id",
                table: "diary_entries",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "IX_diary_entries_staff_id",
                table: "diary_entries",
                column: "staff_id");

            migrationBuilder.CreateIndex(
                name: "IX_diary_entries_weather_id",
                table: "diary_entries",
                column: "weather_id");

            migrationBuilder.CreateIndex(
                name: "IX_downtime_attachment_key",
                table: "downtime",
                column: "attachment_key");

            migrationBuilder.CreateIndex(
                name: "IX_site_cbs_cbs_key",
                table: "site_cbs",
                column: "cbs_key");

            migrationBuilder.CreateIndex(
                name: "IX_site_cbs_project_key",
                table: "site_cbs",
                column: "project_key");

            migrationBuilder.CreateIndex(
                name: "IX_site_orgs_org_key",
                table: "site_orgs",
                column: "org_key");

            migrationBuilder.CreateIndex(
                name: "IX_site_orgs_site_key",
                table: "site_orgs",
                column: "site_key");

            migrationBuilder.CreateIndex(
                name: "IX_site_packages_package_key",
                table: "site_packages",
                column: "package_key");

            migrationBuilder.CreateIndex(
                name: "IX_site_packages_site_key",
                table: "site_packages",
                column: "site_key");

            migrationBuilder.CreateIndex(
                name: "IX_site_trades_project_key",
                table: "site_trades",
                column: "project_key");

            migrationBuilder.CreateIndex(
                name: "IX_site_trades_trade_key",
                table: "site_trades",
                column: "trade_key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "diary_entries");

            migrationBuilder.DropTable(
                name: "downtime");

            migrationBuilder.DropTable(
                name: "site_cbs");

            migrationBuilder.DropTable(
                name: "site_orgs");

            migrationBuilder.DropTable(
                name: "site_packages");

            migrationBuilder.DropTable(
                name: "site_trades");

            migrationBuilder.DropTable(
                name: "log_type");

            migrationBuilder.DropTable(
                name: "staff");

            migrationBuilder.DropTable(
                name: "weather_data");

            migrationBuilder.DropTable(
                name: "attachments");

            migrationBuilder.DropTable(
                name: "coins_wbs");

            migrationBuilder.DropTable(
                name: "orgs");

            migrationBuilder.DropTable(
                name: "package_information");

            migrationBuilder.DropTable(
                name: "site_info");

            migrationBuilder.DropTable(
                name: "project_information");

            migrationBuilder.DropTable(
                name: "trades");
        }
    }
}
