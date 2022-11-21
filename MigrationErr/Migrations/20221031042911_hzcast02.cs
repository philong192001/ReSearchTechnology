using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationErr.Migrations
{
    public partial class hzcast02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TACC_CASHLOG",
                columns: table => new
                {
                    AUPDATETIME = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    ACREATEDATE = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ATRANDATE = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    AREFID = table.Column<string>(type: "VARCHAR2(50CHAR)", nullable: false),
                    ASUBID = table.Column<string>(type: "VARCHAR2(50CHAR)", nullable: true),
                    ASTATUS = table.Column<byte>(type: "NUMBER(2,0)", nullable: true),
                    AUPDATETYPE = table.Column<byte>(type: "NUMBER(2,0)", nullable: true),
                    ACLIENTCODE = table.Column<string>(type: "VARCHAR2(10CHAR)", nullable: false),
                    ASTOCKCODE = table.Column<string>(type: "VARCHAR2(50CHAR)", nullable: true),
                    ABUSINESSTYPE = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ACASHAMOUNT = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AADVANCE = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AREMAINSECURITIESPOWER = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AADHOC = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AMATCHEDBUY = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    APENDINGBUY = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AMATCHEDBUYFEE = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    APENDINGBUYFEE = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AINTRADAYDEBT = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    APENDINGBUYDEBT = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AINTERNALTRANSFER = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AEXTERNALTRANSFER = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ASMSFEE = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AADVISORSELECTFEE = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AVSDFEE = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AREMAINDEBT = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ADEBTINTEREST = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ACREDITLINE = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARECEIVABLE_T0 = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARECEIVABLE_T1 = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARECEIVABLE_T2 = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARECEIVABLE_DIVIDEND = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARECEIVABLE_MATURECW = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARECEIVABLE_ODDLOT = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ADVSD = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AUNPAIDVM = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ATRANSFER_DFPTSTODVSD = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ATRANSFER_DVSDTODFPTS = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AFUTRADINGTAX = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AFSAVINGPOWER = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ABANKGUARANTEE = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AFSAVING = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ABANKSAVING = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ADESC = table.Column<string>(type: "VARCHAR2(2000CHAR)", nullable: true),
                    ATOPICNAME = table.Column<string>(type: "VARCHAR2(50CHAR)", nullable: true),
                    APARTITION = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AOFFSET = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AFGUARANTEE = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TACC_CASHLOG", x => new { x.ACREATEDATE, x.ATRANDATE, x.AREFID, x.ABUSINESSTYPE, x.ACLIENTCODE });
                });

            migrationBuilder.CreateTable(
                name: "TACC_FUTURESCASH",
                columns: table => new
                {
                    ACLIENTCODE = table.Column<string>(type: "VARCHAR2(10 CHAR)", nullable: false),
                    ADFPTS = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMATCHEDFEE = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AINTERNALTRANSFER = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AVSDFEE = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AREMAINDEBT = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ADEBTINTEREST = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ADVSD = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ATRANSFER_DVSDTODFPTS = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ATRANSFER_DFPTSTODVSD = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AUNPAIDVM = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AFUTRADINGTAX = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TACC_FUTURESCASH", x => x.ACLIENTCODE);
                });

            migrationBuilder.CreateTable(
                name: "TACC_FUTURESSECURITIES",
                columns: table => new
                {
                    ASTOCKCODE = table.Column<string>(type: "VARCHAR2(20 CHAR)", nullable: false),
                    ACLIENTCODE = table.Column<string>(type: "VARCHAR2(10)", maxLength: 10, nullable: false),
                    APENDINGBUY = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    APENDINGSELL = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMATCHEDBUYINTRADAY = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMATCHEDSELLINTRADAY = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ANETPOSITION = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AOPENPOSITION = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AVMINTRADAY = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TACC_FUTURESSECURITIES", x => new { x.ACLIENTCODE, x.ASTOCKCODE });
                });

            migrationBuilder.CreateTable(
                name: "TACC_SECURITIESLOG",
                columns: table => new
                {
                    AUPDATETIME = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    ACREATEDATE = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ATRANDATE = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    AREFID = table.Column<string>(type: "varchar2(50char)", nullable: false),
                    ASUBID = table.Column<string>(type: "varchar2(50char)", nullable: true),
                    ASTATUS = table.Column<byte>(type: "NUMBER(2,0)", nullable: true),
                    AUPDATETYPE = table.Column<byte>(type: "NUMBER(2,0)", nullable: true),
                    ACLIENTCODE = table.Column<string>(type: "varchar2(10char)", nullable: false),
                    ASTOCKCODE = table.Column<string>(type: "varchar2(20char)", nullable: false),
                    ABUSINESSTYPE = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ATRADINGAVAIL = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ATRADINGAVAIL_MAR = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    APENDINGBUY = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    APENDINGSELL = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    APENDINGSELL_MAR = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AMATCHEDBUYINTRADAY = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AMATCHEDSELLINTRADAY = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AMATCHEDSELLINTRADAY_MAR = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARECEIVABLE_T1 = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARECEIVABLE_T2 = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARECEIVABLE_RIGHT = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ADIVIDEND = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AESOP = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARESTRICTED = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AMORTGAGEATBANK = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AHOLDING = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ATRADINGWAITING = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AESOPWAITING = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ARESTRICTEDWAITING = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AMORTGAGEBANKWAITING = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AHOLDINGWAITING = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AWAITINGFROMCUSTODY = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AMARPROSUSPEND = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ANETPOSITION = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AOPENPOSITION = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    APRICE = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AVMINTRADAY = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    ASTOCKCODE2 = table.Column<string>(type: "varchar2(20char)", nullable: true),
                    ADESC = table.Column<string>(type: "varchar2(2000char)", nullable: true),
                    ATOPICNAME = table.Column<string>(type: "VARCHAR2(50CHAR)", nullable: true),
                    APARTITION = table.Column<long>(type: "NUMBER(19)", nullable: true),
                    AOFFSET = table.Column<long>(type: "NUMBER(19)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TACC_SECURITIESLOG", x => new { x.ACREATEDATE, x.ATRANDATE, x.AREFID, x.ABUSINESSTYPE, x.ACLIENTCODE, x.ASTOCKCODE });
                });

            migrationBuilder.CreateTable(
                name: "TACC_TRADINGCASH",
                columns: table => new
                {
                    ACLIENTCODE = table.Column<string>(type: "VARCHAR2(10 CHAR)", nullable: false),
                    ACASHAMOUNT = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AADVANCE = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AREMAINSECURITIESPOWER = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AFSAVINGPOWER = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AADHOC = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMATCHEDBUY = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    APENDINGBUY = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AINTRADAYDEBT = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    APENDINGBUYDEBT = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMATCHEDBUYFEE = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    APENDINGBUYFEE = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AINTERNALTRANSFER = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AEXTERNALTRANSFER = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AFEESUM = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ACREDITLINE = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AREMAINDEBT = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ADEBTINTEREST = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARECEIVABLE_T0 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARECEIVABLE_T1 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARECEIVABLE_T2 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARECEIVABLE_DIVIDEND = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARECEIVABLE_MATURECW = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARECEIVABLE_ODDLOT = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AFSAVING = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ABANKGUARANTEE = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ABANKSAVING = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AFGUARANTEE = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TACC_TRADINGCASH", x => x.ACLIENTCODE);
                });

            migrationBuilder.CreateTable(
                name: "TACC_TRADINGFEE",
                columns: table => new
                {
                    ACLIENTCODE = table.Column<string>(type: "VARCHAR2(10 CHAR)", nullable: false),
                    AFEETYPE = table.Column<int>(type: "NUMBER(10,0)", nullable: false),
                    AVALUE = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TACC_TRADINGFEE", x => new { x.ACLIENTCODE, x.AFEETYPE });
                });

            migrationBuilder.CreateTable(
                name: "TACC_TRADINGSECURITIES",
                columns: table => new
                {
                    ASTOCKCODE = table.Column<string>(type: "VARCHAR2(20 CHAR)", nullable: false),
                    ACLIENTCODE = table.Column<string>(type: "VARCHAR2(10 CHAR)", nullable: false),
                    ATRADINGAVAIL = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ATRADINGAVAIL_MAR = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    APENDINGSELL = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    APENDINGSELL_MAR = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMATCHEDSELLINTRADAY = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMATCHEDSELLINTRADAY_MAR = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ADIVIDEND = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARESTRICTED = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMORTGAGEATBANK = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AHOLDING = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AESOP = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMARPROSUSPEND = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMATCHEDBUYINTRADAY = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARECEIVABLE_T1 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARECEIVABLE_T2 = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARECEIVABLE_RIGHT = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ARESTRICTEDWAITING = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AMORTGAGEBANKWAITING = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AHOLDINGWAITING = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ATRADINGWAITING = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AWAITINGFROMCUSTODY = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AESOPWAITING = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    AODDLOTSELLINTRADAY = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TACC_TRADINGSECURITIES", x => new { x.ACLIENTCODE, x.ASTOCKCODE });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TACC_CASHLOG");

            migrationBuilder.DropTable(
                name: "TACC_FUTURESCASH");

            migrationBuilder.DropTable(
                name: "TACC_FUTURESSECURITIES");

            migrationBuilder.DropTable(
                name: "TACC_SECURITIESLOG");

            migrationBuilder.DropTable(
                name: "TACC_TRADINGCASH");

            migrationBuilder.DropTable(
                name: "TACC_TRADINGFEE");

            migrationBuilder.DropTable(
                name: "TACC_TRADINGSECURITIES");
        }
    }
}
