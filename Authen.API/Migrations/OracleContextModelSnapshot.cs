﻿// <auto-generated />
using System;
using Authen.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace Authen.API.Migrations
{
    [DbContext(typeof(OracleContext))]
    partial class OracleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Authen.API.Models.CheckLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Time")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.ToTable("ResponseLogin");
                });

            modelBuilder.Entity("Authen.API.Models.Permit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EzAdvance")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EzFuture")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EzMargin")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EzMarginPro")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EzMortgage")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EzOddlot")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EzTrade")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EzTradeChargeRate")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EzTransfer")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("EzTvdt")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("UserId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("vFeeHSX_CCQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeHSX_CP")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeHSX_CQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeHSX_ETF")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeLISTED_CCQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeLISTED_CP")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeLISTED_CQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeLISTED_ETF")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeRate_TP")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeUP")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vFeeUP_CCQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("vTblid")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Permits");
                });

            modelBuilder.Entity("Authen.API.Models.UserTest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABROWSER")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ABROWSERNAME")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ABROWSERVERS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ACHKPASS2")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("AIPCLIENT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("AIPSERVER")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("AISMOBILE")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ALOGINNAME")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("ALOGINTIME")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("ALOGOUTTIME")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ASESSIONFIRSTLOGIN")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ASESSIONNO")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ATOKEN")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("AUSERAGENT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ID");

                    b.ToTable("UserLogin");
                });
#pragma warning restore 612, 618
        }
    }
}
