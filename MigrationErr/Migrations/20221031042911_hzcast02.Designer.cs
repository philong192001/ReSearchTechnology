﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MigrationErr.Context;
using MigrationErr.Models;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace MigrationErr.Migrations
{
    [DbContext(typeof(AccountDbContext))]
    [Migration("20221031042911_hzcast02")]
    partial class hzcast02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MigrationErr.Models.CashLog", b =>
                {
                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("ACREATEDATE")
                        .HasColumnOrder(1);

                    b.Property<DateTime?>("TranDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("ATRANDATE")
                        .HasColumnOrder(2);

                    b.Property<string>("RefId")
                        .HasColumnType("VARCHAR2(50CHAR)")
                        .HasColumnName("AREFID")
                        .HasColumnOrder(3);

                    b.Property<int>("BusinessType")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ABUSINESSTYPE")
                        .HasColumnOrder(9);

                    b.Property<string>("ClientCode")
                        .HasColumnType("VARCHAR2(10CHAR)")
                        .HasColumnName("ACLIENTCODE")
                        .HasColumnOrder(7);

                    b.Property<long?>("Adhoc")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AADHOC")
                        .HasColumnOrder(13);

                    b.Property<long?>("Advance")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AADVANCE")
                        .HasColumnOrder(11);

                    b.Property<long?>("AdvisorSelectFee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AADVISORSELECTFEE")
                        .HasColumnOrder(23);

                    b.Property<long?>("BankGuarantee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ABANKGUARANTEE")
                        .HasColumnOrder(40);

                    b.Property<long?>("BankSaving")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ABANKSAVING")
                        .HasColumnOrder(42);

                    b.Property<long?>("CashAmount")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ACASHAMOUNT")
                        .HasColumnOrder(10);

                    b.Property<long?>("CreditLine")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ACREDITLINE")
                        .HasColumnOrder(27);

                    b.Property<long?>("DVSD")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ADVSD")
                        .HasColumnOrder(34);

                    b.Property<long?>("DebtInterest")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ADEBTINTEREST")
                        .HasColumnOrder(26);

                    b.Property<string>("Desc")
                        .HasColumnType("VARCHAR2(2000CHAR)")
                        .HasColumnName("ADESC")
                        .HasColumnOrder(43);

                    b.Property<long?>("ExternalTransfer")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AEXTERNALTRANSFER")
                        .HasColumnOrder(21);

                    b.Property<long?>("FGuarantee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AFGUARANTEE")
                        .HasColumnOrder(47);

                    b.Property<long?>("FSaving")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AFSAVING")
                        .HasColumnOrder(41);

                    b.Property<long?>("FSavingPower")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AFSAVINGPOWER")
                        .HasColumnOrder(39);

                    b.Property<long?>("FUTradingTax")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AFUTRADINGTAX")
                        .HasColumnOrder(38);

                    b.Property<long?>("InternalTransfer")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AINTERNALTRANSFER")
                        .HasColumnOrder(20);

                    b.Property<long?>("IntradayDebt")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AINTRADAYDEBT")
                        .HasColumnOrder(18);

                    b.Property<long?>("MatchedBuy")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDBUY")
                        .HasColumnOrder(14);

                    b.Property<long?>("MatchedBuyFee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDBUYFEE")
                        .HasColumnOrder(16);

                    b.Property<long?>("Offset")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AOFFSET")
                        .HasColumnOrder(46);

                    b.Property<long?>("Partition")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APARTITION")
                        .HasColumnOrder(45);

                    b.Property<long?>("PendingBuy")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGBUY")
                        .HasColumnOrder(15);

                    b.Property<long?>("PendingBuyDebt")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGBUYDEBT")
                        .HasColumnOrder(19);

                    b.Property<long?>("PendingBuyFee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGBUYFEE")
                        .HasColumnOrder(17);

                    b.Property<long?>("ReceivableDividend")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_DIVIDEND")
                        .HasColumnOrder(31);

                    b.Property<long?>("ReceivableMatureCW")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_MATURECW")
                        .HasColumnOrder(32);

                    b.Property<long?>("ReceivableOddlot")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_ODDLOT")
                        .HasColumnOrder(33);

                    b.Property<long?>("ReceivableT0")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T0")
                        .HasColumnOrder(28);

                    b.Property<long?>("ReceivableT1")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T1")
                        .HasColumnOrder(29);

                    b.Property<long?>("ReceivableT2")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T2")
                        .HasColumnOrder(30);

                    b.Property<long?>("RemainDebt")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AREMAINDEBT")
                        .HasColumnOrder(25);

                    b.Property<long?>("RemainSecuritiesPower")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AREMAINSECURITIESPOWER")
                        .HasColumnOrder(12);

                    b.Property<long?>("SMSfee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ASMSFEE")
                        .HasColumnOrder(22);

                    b.Property<byte?>("Status")
                        .HasColumnType("NUMBER(2,0)")
                        .HasColumnName("ASTATUS")
                        .HasColumnOrder(5);

                    b.Property<string>("StockCode")
                        .HasColumnType("VARCHAR2(50CHAR)")
                        .HasColumnName("ASTOCKCODE")
                        .HasColumnOrder(8);

                    b.Property<string>("SubId")
                        .HasColumnType("VARCHAR2(50CHAR)")
                        .HasColumnName("ASUBID")
                        .HasColumnOrder(4);

                    b.Property<string>("TopicName")
                        .HasColumnType("VARCHAR2(50CHAR)")
                        .HasColumnName("ATOPICNAME")
                        .HasColumnOrder(44);

                    b.Property<long?>("TransferDFPTSToDVSD")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRANSFER_DFPTSTODVSD")
                        .HasColumnOrder(36);

                    b.Property<long?>("TransferDVSDToDFPTS")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRANSFER_DVSDTODFPTS")
                        .HasColumnOrder(37);

                    b.Property<long?>("UnpaidVM")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AUNPAIDVM")
                        .HasColumnOrder(35);

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("AUPDATETIME")
                        .HasColumnOrder(0);

                    b.Property<byte?>("UpdateType")
                        .HasColumnType("NUMBER(2,0)")
                        .HasColumnName("AUPDATETYPE")
                        .HasColumnOrder(6);

                    b.Property<long?>("VSDFee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AVSDFEE")
                        .HasColumnOrder(24);

                    b.HasKey("CreateDate", "TranDate", "RefId", "BusinessType", "ClientCode");

                    b.ToTable("TACC_CASHLOG", (string)null);
                });

            modelBuilder.Entity("MigrationErr.Models.FuturesCash", b =>
                {
                    b.Property<string>("ClientCode")
                        .HasColumnType("VARCHAR2(10 CHAR)")
                        .HasColumnName("ACLIENTCODE");

                    b.Property<long>("DFPTS")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ADFPTS");

                    b.Property<long>("DVSD")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ADVSD");

                    b.Property<long>("DebtInterest")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ADEBTINTEREST");

                    b.Property<long>("FUTradingTax")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AFUTRADINGTAX");

                    b.Property<long>("InternalTransfer")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AINTERNALTRANSFER");

                    b.Property<long>("MatchedFee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDFEE");

                    b.Property<long>("RemainDebt")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AREMAINDEBT");

                    b.Property<long>("TransferDFPTStoDVSD")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRANSFER_DFPTSTODVSD");

                    b.Property<long>("TransferDVSDtoDFPTS")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRANSFER_DVSDTODFPTS");

                    b.Property<long>("UnpaidVM")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AUNPAIDVM");

                    b.Property<long>("VSDFee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AVSDFEE");

                    b.HasKey("ClientCode");

                    b.ToTable("TACC_FUTURESCASH", (string)null);
                });

            modelBuilder.Entity("MigrationErr.Models.FuturesSecuritiesItem", b =>
                {
                    b.Property<string>("ClientCode")
                        .HasMaxLength(10)
                        .HasColumnType("VARCHAR2(10)")
                        .HasColumnName("ACLIENTCODE");

                    b.Property<string>("StockCode")
                        .HasColumnType("VARCHAR2(20 CHAR)")
                        .HasColumnName("ASTOCKCODE");

                    b.Property<long>("MatchedBuyIntraday")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDBUYINTRADAY");

                    b.Property<long>("MatchedSellIntraday")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDSELLINTRADAY");

                    b.Property<long>("NetPosition")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ANETPOSITION");

                    b.Property<long>("OpenPosition")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AOPENPOSITION");

                    b.Property<long>("PendingBuy")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGBUY");

                    b.Property<long>("PendingSell")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGSELL");

                    b.Property<long>("VMIntraday")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AVMINTRADAY");

                    b.HasKey("ClientCode", "StockCode");

                    b.ToTable("TACC_FUTURESSECURITIES", (string)null);
                });

            modelBuilder.Entity("MigrationErr.Models.SecuritiesLog", b =>
                {
                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("ACREATEDATE")
                        .HasColumnOrder(1);

                    b.Property<DateTime?>("TranDate")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("ATRANDATE")
                        .HasColumnOrder(2);

                    b.Property<string>("RefId")
                        .HasColumnType("varchar2(50char)")
                        .HasColumnName("AREFID")
                        .HasColumnOrder(3);

                    b.Property<int>("BusinessType")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ABUSINESSTYPE")
                        .HasColumnOrder(9);

                    b.Property<string>("ClientCode")
                        .HasColumnType("varchar2(10char)")
                        .HasColumnName("ACLIENTCODE")
                        .HasColumnOrder(7);

                    b.Property<string>("StockCode")
                        .HasColumnType("varchar2(20char)")
                        .HasColumnName("ASTOCKCODE")
                        .HasColumnOrder(8);

                    b.Property<string>("Desc")
                        .HasColumnType("varchar2(2000char)")
                        .HasColumnName("ADESC")
                        .HasColumnOrder(38);

                    b.Property<long?>("Dividend")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ADIVIDEND")
                        .HasColumnOrder(21);

                    b.Property<long?>("Esop")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AESOP")
                        .HasColumnOrder(22);

                    b.Property<long?>("EsopWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AESOPWAITING")
                        .HasColumnOrder(27);

                    b.Property<long?>("Holding")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AHOLDING")
                        .HasColumnOrder(25);

                    b.Property<long?>("HoldingWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AHOLDINGWAITING")
                        .HasColumnOrder(30);

                    b.Property<long?>("MarproSuspend")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMARPROSUSPEND")
                        .HasColumnOrder(32);

                    b.Property<long?>("MatchedBuyIntraday")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDBUYINTRADAY")
                        .HasColumnOrder(15);

                    b.Property<long?>("MatchedSellIntraday")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDSELLINTRADAY")
                        .HasColumnOrder(16);

                    b.Property<long?>("MatchedSellIntraday_Mar")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDSELLINTRADAY_MAR")
                        .HasColumnOrder(17);

                    b.Property<long?>("MortgageAtBank")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMORTGAGEATBANK")
                        .HasColumnOrder(24);

                    b.Property<long?>("MortgageBankWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMORTGAGEBANKWAITING")
                        .HasColumnOrder(29);

                    b.Property<long?>("NetPosition")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ANETPOSITION")
                        .HasColumnOrder(33);

                    b.Property<long?>("Offset")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AOFFSET")
                        .HasColumnOrder(41);

                    b.Property<long?>("OpenPosition")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AOPENPOSITION")
                        .HasColumnOrder(34);

                    b.Property<long?>("Partition")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APARTITION")
                        .HasColumnOrder(40);

                    b.Property<long?>("PendingBuy")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGBUY")
                        .HasColumnOrder(12);

                    b.Property<long?>("PendingSell")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGSELL")
                        .HasColumnOrder(13);

                    b.Property<long?>("PendingSell_Mar")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGSELL_MAR")
                        .HasColumnOrder(14);

                    b.Property<long?>("Price")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APRICE")
                        .HasColumnOrder(35);

                    b.Property<long?>("ReceivableRight")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_RIGHT")
                        .HasColumnOrder(20);

                    b.Property<long?>("ReceivableT1")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T1")
                        .HasColumnOrder(18);

                    b.Property<long?>("ReceivableT2")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T2")
                        .HasColumnOrder(19);

                    b.Property<long?>("Restricted")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARESTRICTED")
                        .HasColumnOrder(23);

                    b.Property<long?>("RestrictedWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARESTRICTEDWAITING")
                        .HasColumnOrder(28);

                    b.Property<byte?>("Status")
                        .HasColumnType("NUMBER(2,0)")
                        .HasColumnName("ASTATUS")
                        .HasColumnOrder(5);

                    b.Property<string>("StockCode2")
                        .HasColumnType("varchar2(20char)")
                        .HasColumnName("ASTOCKCODE2")
                        .HasColumnOrder(37);

                    b.Property<string>("SubId")
                        .HasColumnType("varchar2(50char)")
                        .HasColumnName("ASUBID")
                        .HasColumnOrder(4);

                    b.Property<string>("TopicName")
                        .HasColumnType("VARCHAR2(50CHAR)")
                        .HasColumnName("ATOPICNAME")
                        .HasColumnOrder(39);

                    b.Property<long?>("TradingAvail")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRADINGAVAIL")
                        .HasColumnOrder(10);

                    b.Property<long?>("TradingAvail_Mar")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRADINGAVAIL_MAR")
                        .HasColumnOrder(11);

                    b.Property<long?>("TradingWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRADINGWAITING")
                        .HasColumnOrder(26);

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("AUPDATETIME")
                        .HasColumnOrder(0);

                    b.Property<byte?>("UpdateType")
                        .HasColumnType("NUMBER(2,0)")
                        .HasColumnName("AUPDATETYPE")
                        .HasColumnOrder(6);

                    b.Property<long?>("VmIntraday")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AVMINTRADAY")
                        .HasColumnOrder(36);

                    b.Property<long?>("WaitingFromCustody")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AWAITINGFROMCUSTODY")
                        .HasColumnOrder(31);

                    b.HasKey("CreateDate", "TranDate", "RefId", "BusinessType", "ClientCode", "StockCode");

                    b.ToTable("TACC_SECURITIESLOG", (string)null);
                });

            modelBuilder.Entity("MigrationErr.Models.TradingCash", b =>
                {
                    b.Property<string>("ClientCode")
                        .HasColumnType("VARCHAR2(10 CHAR)")
                        .HasColumnName("ACLIENTCODE");

                    b.Property<long>("Adhoc")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AADHOC");

                    b.Property<long>("Advance")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AADVANCE");

                    b.Property<long>("BankGuarantee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ABANKGUARANTEE");

                    b.Property<long>("BankSaving")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ABANKSAVING");

                    b.Property<long>("CashAmount")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ACASHAMOUNT");

                    b.Property<long>("CreditLine")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ACREDITLINE");

                    b.Property<long>("DebtInterest")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ADEBTINTEREST");

                    b.Property<long>("ExternalTransfer")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AEXTERNALTRANSFER");

                    b.Property<long>("FGuarantee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AFGUARANTEE");

                    b.Property<long>("FSaving")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AFSAVING");

                    b.Property<long>("FSavingPower")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AFSAVINGPOWER");

                    b.Property<long>("FeeSum")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AFEESUM");

                    b.Property<long>("InternalTransfer")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AINTERNALTRANSFER");

                    b.Property<long>("IntradayDebt")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AINTRADAYDEBT");

                    b.Property<long>("MatchedBuy")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDBUY");

                    b.Property<long>("MatchedBuyFee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDBUYFEE");

                    b.Property<long>("PendingBuy")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGBUY");

                    b.Property<long>("PendingBuyDebt")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGBUYDEBT");

                    b.Property<long>("PendingBuyFee")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGBUYFEE");

                    b.Property<long>("ReceivableDividend")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_DIVIDEND");

                    b.Property<long>("ReceivableMatureCW")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_MATURECW");

                    b.Property<long>("ReceivableOddlot")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_ODDLOT");

                    b.Property<long>("ReceivableT0")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T0");

                    b.Property<long>("ReceivableT1")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T1");

                    b.Property<long>("ReceivableT2")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T2");

                    b.Property<long>("RemainDebt")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AREMAINDEBT");

                    b.Property<long>("RemainSecuritiesPower")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AREMAINSECURITIESPOWER");

                    b.HasKey("ClientCode");

                    b.ToTable("TACC_TRADINGCASH", (string)null);
                });

            modelBuilder.Entity("MigrationErr.Models.TradingFeeItem", b =>
                {
                    b.Property<string>("ClientCode")
                        .HasColumnType("VARCHAR2(10 CHAR)")
                        .HasColumnName("ACLIENTCODE");

                    b.Property<FeeType>("FeeType")
                        .HasColumnType("NUMBER(10,0)")
                        .HasColumnName("AFEETYPE");

                    b.Property<long>("Value")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AVALUE");

                    b.HasKey("ClientCode", "FeeType");

                    b.ToTable("TACC_TRADINGFEE", (string)null);
                });

            modelBuilder.Entity("MigrationErr.Models.TradingSecuritiesItem", b =>
                {
                    b.Property<string>("ClientCode")
                        .HasColumnType("VARCHAR2(10 CHAR)")
                        .HasColumnName("ACLIENTCODE");

                    b.Property<string>("StockCode")
                        .HasColumnType("VARCHAR2(20 CHAR)")
                        .HasColumnName("ASTOCKCODE");

                    b.Property<long>("Dividend")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ADIVIDEND");

                    b.Property<long>("ESOP")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AESOP");

                    b.Property<long>("ESOPWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AESOPWAITING");

                    b.Property<long>("Holding")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AHOLDING");

                    b.Property<long>("HoldingWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AHOLDINGWAITING");

                    b.Property<long>("MarproSuspend")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMARPROSUSPEND");

                    b.Property<long>("MatchedBuyIntraday")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDBUYINTRADAY");

                    b.Property<long>("MatchedSellIntraday")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDSELLINTRADAY");

                    b.Property<long>("MatchedSellIntraday_Mar")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMATCHEDSELLINTRADAY_MAR");

                    b.Property<long>("MortgageAtBank")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMORTGAGEATBANK");

                    b.Property<long>("MortgageAtBankWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AMORTGAGEBANKWAITING");

                    b.Property<long>("OddlotSellIntraday")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AODDLOTSELLINTRADAY");

                    b.Property<long>("PendingSell")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGSELL");

                    b.Property<long>("PendingSell_Mar")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("APENDINGSELL_MAR");

                    b.Property<long>("ReceivableRight")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_RIGHT");

                    b.Property<long>("ReceivableT1")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T1");

                    b.Property<long>("ReceivableT2")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARECEIVABLE_T2");

                    b.Property<long>("Restricted")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARESTRICTED");

                    b.Property<long>("RestrictedWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ARESTRICTEDWAITING");

                    b.Property<long>("TradingAvail")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRADINGAVAIL");

                    b.Property<long>("TradingAvail_Mar")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRADINGAVAIL_MAR");

                    b.Property<long>("TradingWaiting")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ATRADINGWAITING");

                    b.Property<long>("WaitingFromCustody")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("AWAITINGFROMCUSTODY");

                    b.HasKey("ClientCode", "StockCode");

                    b.ToTable("TACC_TRADINGSECURITIES", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}