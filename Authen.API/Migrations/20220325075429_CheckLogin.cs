using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Authen.API.Migrations
{
    public partial class CheckLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    EzTradeChargeRate = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EzTrade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EzTransfer = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EzAdvance = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EzMargin = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EzMortgage = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EzOddlot = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EzMarginPro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EzFuture = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EzTvdt = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vTblid = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeUP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeUP_CCQ = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeLISTED_CP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeHSX_CP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeRate_TP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeLISTED_ETF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeLISTED_CCQ = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeHSX_CCQ = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeHSX_CQ = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeHSX_ETF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    vFeeLISTED_CQ = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResponseLogin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    Time = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    ALOGINNAME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ATOKEN = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AIPSERVER = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AIPCLIENT = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AUSERAGENT = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ABROWSER = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ALOGINTIME = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ALOGOUTTIME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ASESSIONNO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ASESSIONFIRSTLOGIN = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    AISMOBILE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ABROWSERNAME = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ABROWSERVERS = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ACHKPASS2 = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permits");

            migrationBuilder.DropTable(
                name: "ResponseLogin");

            migrationBuilder.DropTable(
                name: "UserLogin");
        }
    }
}
