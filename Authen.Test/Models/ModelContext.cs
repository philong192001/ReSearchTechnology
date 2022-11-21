using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Authen.Test.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QuestSlTempExplain1> QuestSlTempExplain1 { get; set; }
        public virtual DbSet<SqlnExplainPlan> SqlnExplainPlan { get; set; }
        public virtual DbSet<TauthChangeaccstatelog> TauthChangeaccstatelog { get; set; }
        public virtual DbSet<TauthClientsession> TauthClientsession { get; set; }
        public virtual DbSet<TauthClientsessionlog> TauthClientsessionlog { get; set; }
        public virtual DbSet<TauthClientsessionlogh> TauthClientsessionlogh { get; set; }
        public virtual DbSet<TauthClientverifylog> TauthClientverifylog { get; set; }
        public virtual DbSet<TauthCostcenter> TauthCostcenter { get; set; }
        public virtual DbSet<TauthErrorlist> TauthErrorlist { get; set; }
        public virtual DbSet<TauthInternalsession> TauthInternalsession { get; set; }
        public virtual DbSet<TauthInternalsessionlog> TauthInternalsessionlog { get; set; }
        public virtual DbSet<TauthSysgroup> TauthSysgroup { get; set; }
        public virtual DbSet<TauthSysmodule> TauthSysmodule { get; set; }
        public virtual DbSet<TauthSysuser> TauthSysuser { get; set; }
        public virtual DbSet<TauthSysusergroup> TauthSysusergroup { get; set; }
        public virtual DbSet<TauthSysusertype> TauthSysusertype { get; set; }
        public virtual DbSet<TauthUserlogin> TauthUserlogin { get; set; }
        public virtual DbSet<TauthWebnav> TauthWebnav { get; set; }
        public virtual DbSet<TauthWebnavgroup> TauthWebnavgroup { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseOracle("Data Source=10.26.7.23:1521/tradingt;User ID=authen;Password=authen1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "AUTHEN");

            modelBuilder.Entity<QuestSlTempExplain1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QUEST_SL_TEMP_EXPLAIN1");

                entity.Property(e => e.AccessPredicates)
                    .HasColumnName("ACCESS_PREDICATES")
                    .IsUnicode(false);

                entity.Property(e => e.Bytes)
                    .HasColumnName("BYTES")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Cardinality)
                    .HasColumnName("CARDINALITY")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Cost)
                    .HasColumnName("COST")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CpuCost)
                    .HasColumnName("CPU_COST")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Depth)
                    .HasColumnName("DEPTH")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Distribution)
                    .HasColumnName("DISTRIBUTION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FilterPredicates)
                    .HasColumnName("FILTER_PREDICATES")
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.IoCost)
                    .HasColumnName("IO_COST")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ObjectAlias)
                    .HasColumnName("OBJECT_ALIAS")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectInstance)
                    .HasColumnName("OBJECT_INSTANCE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("OBJECT_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectNode)
                    .HasColumnName("OBJECT_NODE")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectOwner)
                    .HasColumnName("OBJECT_OWNER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Operation)
                    .HasColumnName("OPERATION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Optimizer)
                    .HasColumnName("OPTIMIZER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Options)
                    .HasColumnName("OPTIONS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasColumnName("OTHER")
                    .HasColumnType("LONG");

                entity.Property(e => e.OtherTag)
                    .HasColumnName("OTHER_TAG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtherXml)
                    .HasColumnName("OTHER_XML")
                    .HasColumnType("CLOB");

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PartitionId)
                    .HasColumnName("PARTITION_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PartitionStart)
                    .HasColumnName("PARTITION_START")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PartitionStop)
                    .HasColumnName("PARTITION_STOP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlanId)
                    .HasColumnName("PLAN_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Position)
                    .HasColumnName("POSITION")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Projection)
                    .HasColumnName("PROJECTION")
                    .IsUnicode(false);

                entity.Property(e => e.QblockName)
                    .HasColumnName("QBLOCK_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .IsUnicode(false);

                entity.Property(e => e.SearchColumns)
                    .HasColumnName("SEARCH_COLUMNS")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StatementId)
                    .HasColumnName("STATEMENT_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempSpace)
                    .HasColumnName("TEMP_SPACE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("DATE");
            });

            modelBuilder.Entity<SqlnExplainPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SQLN_EXPLAIN_PLAN");

                entity.Property(e => e.AccessPredicates)
                    .HasColumnName("ACCESS_PREDICATES")
                    .IsUnicode(false);

                entity.Property(e => e.Bytes)
                    .HasColumnName("BYTES")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Cardinality)
                    .HasColumnName("CARDINALITY")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Cost)
                    .HasColumnName("COST")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.CpuCost)
                    .HasColumnName("CPU_COST")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Depth)
                    .HasColumnName("DEPTH")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Distribution)
                    .HasColumnName("DISTRIBUTION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FilterPredicates)
                    .HasColumnName("FILTER_PREDICATES")
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.IoCost)
                    .HasColumnName("IO_COST")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ObjectAlias)
                    .HasColumnName("OBJECT_ALIAS")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectInstance)
                    .HasColumnName("OBJECT_INSTANCE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ObjectName)
                    .HasColumnName("OBJECT_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectNode)
                    .HasColumnName("OBJECT_NODE")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectOwner)
                    .HasColumnName("OBJECT_OWNER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Operation)
                    .HasColumnName("OPERATION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Optimizer)
                    .HasColumnName("OPTIMIZER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Options)
                    .HasColumnName("OPTIONS")
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasColumnName("OTHER")
                    .HasColumnType("LONG");

                entity.Property(e => e.OtherTag)
                    .HasColumnName("OTHER_TAG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnName("PARENT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PartitionId)
                    .HasColumnName("PARTITION_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.PartitionStart)
                    .HasColumnName("PARTITION_START")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PartitionStop)
                    .HasColumnName("PARTITION_STOP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlanId)
                    .HasColumnName("PLAN_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Position)
                    .HasColumnName("POSITION")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Projection)
                    .HasColumnName("PROJECTION")
                    .IsUnicode(false);

                entity.Property(e => e.QblockName)
                    .HasColumnName("QBLOCK_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .IsUnicode(false);

                entity.Property(e => e.SearchColumns)
                    .HasColumnName("SEARCH_COLUMNS")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.StatementId)
                    .HasColumnName("STATEMENT_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TempSpace)
                    .HasColumnName("TEMP_SPACE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Time)
                    .HasColumnName("TIME")
                    .HasColumnType("NUMBER(20,2)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("DATE");
            });

            modelBuilder.Entity<TauthChangeaccstatelog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_CHANGEACCSTATELOG");

                entity.HasIndex(e => e.Aloginname)
                    .HasName("IDXTAUTH_CHANGEACCLOG_LOGINAME");

                entity.HasIndex(e => e.Alogtime)
                    .HasName("IDXTAUTH_CHANGEACCLOG_LOGTIME");

                entity.Property(e => e.Aactivity)
                    .HasColumnName("AACTIVITY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Aactivitybtntype)
                    .HasColumnName("AACTIVITYBTNTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aactivitydsc)
                    .HasColumnName("AACTIVITYDSC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Aactivityusr)
                    .HasColumnName("AACTIVITYUSR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Abrkid)
                    .HasColumnName("ABRKID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Aloginname)
                    .HasColumnName("ALOGINNAME")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Alogtime)
                    .HasColumnName("ALOGTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Atblid).HasColumnName("ATBLID");
            });

            modelBuilder.Entity<TauthClientsession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_CLIENTSESSION");

                entity.HasIndex(e => e.ALOGINNAME)
                    .HasName("UDXTAUTH_CLIENTSESSION")
                    .IsUnique();

                entity.HasIndex(e => e.ATOKEN)
                    .HasName("IDXTAUTH_CLIENTSESSION_TOKEN");

                entity.Property(e => e.ABROWSER)
                    .HasColumnName("ABROWSER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ABROWSERNAME)
                    .HasColumnName("ABROWSERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ABROWSERVERS)
                    .HasColumnName("ABROWSERVERS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ACHKPASS2)
                    .HasColumnName("ACHKPASS2")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AIPCLIENT)
                    .HasColumnName("AIPCLIENT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AIPSERVER)
                    .HasColumnName("AIPSERVER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AISMOBILE)
                    .HasColumnName("AISMOBILE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ALOGINNAME)
                    .HasColumnName("ALOGINNAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ALOGINTIME)
                    .HasColumnName("ALOGINTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.ALOGOUTTIME)
                    .HasColumnName("ALOGOUTTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.ASESSIONFIRSTLOGIN).HasColumnName("ASESSIONFIRSTLOGIN");

                entity.Property(e => e.ASESSIONNO)
                    .HasColumnName("ASESSIONNO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ATOKEN)
                    .HasColumnName("ATOKEN")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AUSERAGENT)
                    .HasColumnName("AUSERAGENT")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthClientsessionlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_CLIENTSESSIONLOG");

                entity.HasIndex(e => e.ALOGINNAME)
                    .HasName("IDXTAUTH_CLIENTSESSIONLOG");

                entity.HasIndex(e => e.ATBLID)
                    .HasName("UDXTAUTH_CLIENTSESSIONLOG")
                    .IsUnique();

                entity.HasIndex(e => new { e.AIPCLIENT, e.AACTIVITY, e.AERRCODE })
                    .HasName("IDXCLIENTSESSSIONLOG_1");

                entity.Property(e => e.AACTIVITY)
                    .HasColumnName("AACTIVITY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AACTIVITYBTNTYPE)
                    .HasColumnName("AACTIVITYBTNTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AACTIVITYDSC)
                    .HasColumnName("AACTIVITYDSC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AACTIVITYUSR)
                    .HasColumnName("AACTIVITYUSR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ABRKID)
                    .HasColumnName("ABRKID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ABROWSER)
                    .HasColumnName("ABROWSER")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ABROWSERNAME)
                    .HasColumnName("ABROWSERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ABROWSERVERS)
                    .HasColumnName("ABROWSERVERS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AERRCODE)
                    .HasColumnName("AERRCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AERRMESSAGE)
                    .HasColumnName("AERRMESSAGE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AIPCLIENT)
                    .HasColumnName("AIPCLIENT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AIPSERVER)
                    .HasColumnName("AIPSERVER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AISMOBILE)
                    .HasColumnName("AISMOBILE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ALOGINNAME)
                    .HasColumnName("ALOGINNAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ALOGTIME)
                    .HasColumnName("ALOGTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.AREFERER)
                    .HasColumnName("AREFERER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ASOURCE).HasColumnName("ASOURCE");

                entity.Property(e => e.ATBLID)
                    .HasColumnName("ATBLID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.AUSERAGENT)
                    .HasColumnName("AUSERAGENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthClientsessionlogh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_CLIENTSESSIONLOGH");

                entity.HasIndex(e => e.Aloginname)
                    .HasName("IDXTAUTH_CLIENTLOGH_LOGINNAME");

                entity.HasIndex(e => e.Alogtime)
                    .HasName("IDXTAUTH_CLIENTLOGH_LOGTIME");

                entity.Property(e => e.Aactivity)
                    .HasColumnName("AACTIVITY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Aactivitybtntype)
                    .HasColumnName("AACTIVITYBTNTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aactivitydsc)
                    .HasColumnName("AACTIVITYDSC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Aactivityusr)
                    .HasColumnName("AACTIVITYUSR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Abrkid)
                    .HasColumnName("ABRKID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Abrowser)
                    .HasColumnName("ABROWSER")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Abrowsername)
                    .HasColumnName("ABROWSERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Abrowservers)
                    .HasColumnName("ABROWSERVERS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aerrcode)
                    .HasColumnName("AERRCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aerrmessage)
                    .HasColumnName("AERRMESSAGE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Aipclient)
                    .HasColumnName("AIPCLIENT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aipserver)
                    .HasColumnName("AIPSERVER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aismobile)
                    .HasColumnName("AISMOBILE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aloginname)
                    .HasColumnName("ALOGINNAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Alogtime)
                    .HasColumnName("ALOGTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Areferer)
                    .HasColumnName("AREFERER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Asource).HasColumnName("ASOURCE");

                entity.Property(e => e.Atblid)
                    .HasColumnName("ATBLID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Auseragent)
                    .HasColumnName("AUSERAGENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthClientverifylog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_CLIENTVERIFYLOG");

                entity.HasIndex(e => e.Aloginname)
                    .HasName("IDXTAUTH_CLIENTVERIFYLOG");

                entity.HasIndex(e => e.Atblid)
                    .HasName("UDXTAUTH_CLIENTVERIFYLOG")
                    .IsUnique();

                entity.HasIndex(e => e.Averifycode)
                    .HasName("IDXTAUTH_CLIENTVERIFYLOG1");

                entity.Property(e => e.Aactivity)
                    .HasColumnName("AACTIVITY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Aerrcode)
                    .HasColumnName("AERRCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aerrmessage)
                    .HasColumnName("AERRMESSAGE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Aloginname)
                    .HasColumnName("ALOGINNAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Alogtime)
                    .HasColumnName("ALOGTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Asource).HasColumnName("ASOURCE");

                entity.Property(e => e.Atblid)
                    .HasColumnName("ATBLID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Auseragent)
                    .HasColumnName("AUSERAGENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Averifycode)
                    .HasColumnName("AVERIFYCODE")
                    .HasMaxLength(66)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthCostcenter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_COSTCENTER");

                entity.Property(e => e.Aactive).HasColumnName("AACTIVE");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("NUMBER(2)");
            });

            modelBuilder.Entity<TauthErrorlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_ERRORLIST");

                entity.HasIndex(e => e.Aerrorcode)
                    .HasName("IDXTAUTH_ERRORLIST");

                entity.HasIndex(e => e.Aid)
                    .HasName("UDXTAUTH_ERRORLIST")
                    .IsUnique();

                entity.Property(e => e.Aerrorcode)
                    .HasColumnName("AERRORCODE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Aid)
                    .HasColumnName("AID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Amessageen)
                    .HasColumnName("AMESSAGEEN")
                    .IsUnicode(false);

                entity.Property(e => e.Amessagevn)
                    .HasColumnName("AMESSAGEVN")
                    .IsUnicode(false);

                entity.Property(e => e.Aremarks)
                    .HasColumnName("AREMARKS")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthInternalsession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_INTERNALSESSION");

                entity.HasIndex(e => e.Aloginname)
                    .HasName("UDXTAUTH_INTERNALSESSION")
                    .IsUnique();

                entity.HasIndex(e => e.Atoken)
                    .HasName("IDXTAUTH_INTERNALSESSION_TOKEN");

                entity.Property(e => e.Abrowser)
                    .HasColumnName("ABROWSER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Abrowsername)
                    .HasColumnName("ABROWSERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Abrowservers)
                    .HasColumnName("ABROWSERVERS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aipclient)
                    .HasColumnName("AIPCLIENT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aipserver)
                    .HasColumnName("AIPSERVER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aloginname)
                    .HasColumnName("ALOGINNAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Alogintime)
                    .HasColumnName("ALOGINTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Alogouttime)
                    .HasColumnName("ALOGOUTTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Atoken)
                    .HasColumnName("ATOKEN")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Auseragent)
                    .HasColumnName("AUSERAGENT")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthInternalsessionlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_INTERNALSESSIONLOG");

                entity.HasIndex(e => e.Aloginname)
                    .HasName("IDXTAUTH_INTERNALSESSIONLOG");

                entity.HasIndex(e => e.Atblid)
                    .HasName("UDXINTERNALSESSIONLOG")
                    .IsUnique();

                entity.HasIndex(e => new { e.Aipclient, e.Aactivity, e.Aerrcode })
                    .HasName("IDXINTERNALSESSIONLOG_1");

                entity.Property(e => e.Aactivity)
                    .HasColumnName("AACTIVITY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Abrowser)
                    .HasColumnName("ABROWSER")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Abrowsername)
                    .HasColumnName("ABROWSERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Abrowservers)
                    .HasColumnName("ABROWSERVERS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aerrcode)
                    .HasColumnName("AERRCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aerrmessage)
                    .HasColumnName("AERRMESSAGE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Aipclient)
                    .HasColumnName("AIPCLIENT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aipserver)
                    .HasColumnName("AIPSERVER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aloginname)
                    .HasColumnName("ALOGINNAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Alogtime)
                    .HasColumnName("ALOGTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Areferer)
                    .HasColumnName("AREFERER")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Asource).HasColumnName("ASOURCE");

                entity.Property(e => e.Atblid)
                    .HasColumnName("ATBLID")
                    .HasColumnType("TIMESTAMP(9)");

                entity.Property(e => e.Auseragent)
                    .HasColumnName("AUSERAGENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthSysgroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_SYSGROUP");

                entity.HasIndex(e => e.Agroupid)
                    .HasName("UDXTAUTH_SYSGROUP")
                    .IsUnique();

                entity.Property(e => e.Adescription)
                    .HasColumnName("ADESCRIPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Agroupid)
                    .HasColumnName("AGROUPID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Agroupname)
                    .HasColumnName("AGROUPNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Asysmodule)
                    .HasColumnName("ASYSMODULE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthSysmodule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_SYSMODULE");

                entity.HasIndex(e => e.Asysmoduleid)
                    .HasName("UDXTAUTH_SYSMODULE")
                    .IsUnique();

                entity.Property(e => e.Asysmodulecode)
                    .HasColumnName("ASYSMODULECODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Asysmoduledesc)
                    .HasColumnName("ASYSMODULEDESC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Asysmoduleid)
                    .HasColumnName("ASYSMODULEID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Asysmodulename)
                    .HasColumnName("ASYSMODULENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Asysvirtualapp)
                    .HasColumnName("ASYSVIRTUALAPP")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthSysuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_SYSUSER");

                entity.HasIndex(e => e.Auserid)
                    .HasName("UDXTAUTH_SYSUSER")
                    .IsUnique();

                entity.HasIndex(e => e.Ausername)
                    .HasName("IDX_TAUTH_SYSUSER");

                entity.Property(e => e.Adept)
                    .HasColumnName("ADEPT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Adescription)
                    .HasColumnName("ADESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Afullname)
                    .HasColumnName("AFULLNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Alocal)
                    .HasColumnName("ALOCAL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Astatusotp)
                    .HasColumnName("ASTATUSOTP")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Asubcstcencde)
                    .HasColumnName("ASUBCSTCENCDE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Auserid)
                    .HasColumnName("AUSERID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Auserlockstt)
                    .HasColumnName("AUSERLOCKSTT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ausername)
                    .HasColumnName("AUSERNAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ausertypemargin).HasColumnName("AUSERTYPEMARGIN");

                entity.Property(e => e.Ausertypereport).HasColumnName("AUSERTYPEREPORT");
            });

            modelBuilder.Entity<TauthSysusergroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_SYSUSERGROUP");

                entity.HasIndex(e => e.Aid)
                    .HasName("UDXTAUTH_SYSUSERGROUP")
                    .IsUnique();

                entity.Property(e => e.Agroupid)
                    .HasColumnName("AGROUPID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Aid)
                    .HasColumnName("AID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Auserid)
                    .HasColumnName("AUSERID")
                    .HasColumnType("NUMBER(12)");
            });

            modelBuilder.Entity<TauthSysusertype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_SYSUSERTYPE");

                entity.Property(e => e.Usertype).HasColumnName("USERTYPE");

                entity.Property(e => e.Usertypedesc)
                    .HasColumnName("USERTYPEDESC")
                    .HasMaxLength(200);

                entity.Property(e => e.Usertypeid).HasColumnName("USERTYPEID");

                entity.Property(e => e.Usertypename)
                    .HasColumnName("USERTYPENAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Usertypesysmodul)
                    .HasColumnName("USERTYPESYSMODUL")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TauthUserlogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_USERLOGIN");

                entity.HasIndex(e => e.ACLIENTCODE)
                    .HasName("UDXTAUTH_USERLOGIN")
                    .IsUnique();

                entity.HasIndex(e => e.APASSWORDII)
                    .HasName("IDXTAUTH_USERLOGIN_1")
                    .HasFilter("SUBSTR(\"ACLIENTCODE\",-6)");

                entity.HasIndex(e => new { e.APASSWORDII, e.ARSATOKEN })
                    .HasName("IDX1_TAUTH_USERLOGIN")
                    .HasFilter("SUBSTR(\"ACLIENTCODE\",-6)");

                entity.Property(e => e.ACLIENTCODE)
                    .HasColumnName("ACLIENTCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ACLIENTLOCKSTATUS).HasColumnName("ACLIENTLOCKSTATUS");

                entity.Property(e => e.ACLIENTLOCKTIME)
                    .HasColumnName("ACLIENTLOCKTIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.ACLIENTNAME)
                    .HasColumnName("ACLIENTNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ADESCRIPTION)
                    .HasColumnName("ADESCRIPTION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AFIRSTLOGIN).HasColumnName("AFIRSTLOGIN");

                entity.Property(e => e.ALASTPASSWORDCHANGEDDATE)
                    .HasColumnName("ALASTPASSWORDCHANGEDDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.AMOBILEDEVICEID)
                    .HasColumnName("AMOBILEDEVICEID")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.APASSWORD)
                    .HasColumnName("APASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.APASSWORDII)
                    .HasColumnName("APASSWORDII")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AREASON).HasColumnName("AREASON");

                entity.Property(e => e.ARETRYCOUNT)
                    .HasColumnName("ARETRYCOUNT")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.ARSATOKEN).HasColumnName("ARSATOKEN");

                entity.Property(e => e.AUSINGPWD1BY1)
                    .HasColumnName("AUSINGPWD1BY1")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<TauthWebnav>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_WEBNAV");

                entity.HasIndex(e => e.Amenuid)
                    .HasName("UDXTAUTH_WEBNAV")
                    .IsUnique();

                entity.Property(e => e.Aactive).HasColumnName("AACTIVE");

                entity.Property(e => e.Adbname)
                    .HasColumnName("ADBNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ahaslink).HasColumnName("AHASLINK");

                entity.Property(e => e.Aisadmin).HasColumnName("AISADMIN");

                entity.Property(e => e.Aisblank).HasColumnName("AISBLANK");

                entity.Property(e => e.Aisinternal).HasColumnName("AISINTERNAL");

                entity.Property(e => e.Aloginstate).HasColumnName("ALOGINSTATE");

                entity.Property(e => e.Amenuid)
                    .HasColumnName("AMENUID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.AmlanguageId)
                    .HasColumnName("AMLANGUAGE_ID")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Amlink)
                    .HasColumnName("AMLINK")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Amname)
                    .HasColumnName("AMNAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Amnameen)
                    .HasColumnName("AMNAMEEN")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Amorder)
                    .HasColumnName("AMORDER")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Amparent)
                    .HasColumnName("AMPARENT")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Asysmodule)
                    .HasColumnName("ASYSMODULE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Atype)
                    .HasColumnName("ATYPE")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Avhaschild).HasColumnName("AVHASCHILD");

                entity.Property(e => e.Avlevel).HasColumnName("AVLEVEL");

                entity.Property(e => e.Avrootgroup).HasColumnName("AVROOTGROUP");
            });

            modelBuilder.Entity<TauthWebnavgroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TAUTH_WEBNAVGROUP");

                entity.HasIndex(e => e.Aid)
                    .HasName("UDXTAUTH_WEBNAVGROUP")
                    .IsUnique();

                entity.Property(e => e.AgroupId)
                    .HasColumnName("AGROUP_ID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.Aid)
                    .HasColumnName("AID")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.AmenuId)
                    .HasColumnName("AMENU_ID")
                    .HasColumnType("NUMBER(12)");
            });

            modelBuilder.HasSequence("SQTAUTH_CHANGEACCSTATELOG");

            modelBuilder.HasSequence("SQTAUTH_CLIENTSESSIONLOG");

            modelBuilder.HasSequence("SQTAUTH_CLIENTVERIFYLOG");

            modelBuilder.HasSequence("SQTAUTH_ERRORLIST");

            modelBuilder.HasSequence("SQTAUTH_ERRORLIST_CACHELOG");

            modelBuilder.HasSequence("SQTAUTH_SYSGROUP");

            modelBuilder.HasSequence("SQTAUTH_SYSMODULE");

            modelBuilder.HasSequence("SQTAUTH_SYSUSER");

            modelBuilder.HasSequence("SQTAUTH_SYSUSERGROUP");

            modelBuilder.HasSequence("SQTAUTH_WEBNAV");

            modelBuilder.HasSequence("SQTAUTH_WEBNAVGROUP");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
