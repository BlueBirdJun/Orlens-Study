using Microsoft.EntityFrameworkCore;
using PS.Database.Models.db_Partner;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PS.Database
{
    public partial class db_partnercontext : DbContext
    {
        public db_partnercontext(IDbConnection dbConnection, bool isConsoleLogging = false) //: base(dbConnection, isConsoleLogging)
        {
        }
        public db_partnercontext(DbContextOptions<db_partnercontext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAccCdCategory>(entity =>
            {
                entity.HasKey(e => e.AccCateIdx)
                    .HasName("PK__tbl_ACC_CD_Categ__731BDD5C");

                entity.ToTable("tbl_ACC_CD_Category");

                entity.Property(e => e.AccCateIdx).HasColumnName("ACC_CateIdx");

                entity.Property(e => e.AccCateName)
                    .HasColumnName("ACC_CateName")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AccDepth)
                    .HasColumnName("ACC_DEPTH")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccOrder).HasColumnName("ACC_Order");

                entity.Property(e => e.AccPcateIdx).HasColumnName("ACC_PCateIdx");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblAccCdCategoryDetail>(entity =>
            {
                entity.HasKey(e => e.AccCateDidx)
                    .HasName("PK__tbl_ACC_CD_Categ__561FABFB");

                entity.ToTable("tbl_ACC_CD_CategoryDetail");

                entity.Property(e => e.AccCateDidx).HasColumnName("ACC_CateDIdx");

                entity.Property(e => e.AccCateIdx).HasColumnName("ACC_CateIdx");

                entity.Property(e => e.AccCd)
                    .IsRequired()
                    .HasColumnName("ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblAdminKey>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.KeyIdx });

                entity.ToTable("tbl_admin_key");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KeyIdx)
                    .HasColumnName("key_idx")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DelIsusing)
                    .IsRequired()
                    .HasColumnName("del_isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Teamname)
                    .HasColumnName("teamname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsernameDetail)
                    .HasColumnName("username_detail")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAraplinkedms>(entity =>
            {
                entity.HasKey(e => e.AraplinkedmsIdx)
                    .HasName("PK__tbl_ARAPlinkedms__65D6F0D7");

                entity.ToTable("tbl_ARAPlinkedms");

                entity.Property(e => e.AraplinkedmsIdx).HasColumnName("ARAPlinkedmsIdx");

                entity.Property(e => e.ArapCd)
                    .HasColumnName("ARAP_CD")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.EdmsIdx).HasColumnName("edmsIdx");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblBizMonthProfit>(entity =>
            {
                entity.HasKey(e => e.BizProfitIdx)
                    .HasName("PK__tbl_BIZ_MonthPro__6BAFC5BE");

                entity.ToTable("tbl_BIZ_MonthProfit");

                entity.Property(e => e.BizProfitIdx).HasColumnName("bizProfitIdx");

                entity.Property(e => e.AccCd)
                    .HasColumnName("acc_cd")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdUp)
                    .HasColumnName("acc_cd_up")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccGrpCd)
                    .HasColumnName("acc_grp_cd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccGrpNm)
                    .HasColumnName("acc_grp_nm")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AccNm)
                    .HasColumnName("acc_nm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccUpNm)
                    .HasColumnName("acc_up_nm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccUseCd)
                    .HasColumnName("acc_use_cd")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BizType).HasColumnName("bizType");

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("bizsection_cd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionNm)
                    .HasColumnName("bizsection_nm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditSum)
                    .HasColumnName("creditSum")
                    .HasColumnType("money");

                entity.Property(e => e.DebitSum)
                    .HasColumnName("debitSum")
                    .HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("YYYYMM")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBizMonthProfitBizsection>(entity =>
            {
                entity.HasKey(e => e.BizProfitIdx)
                    .HasName("PK__tbl_BIZ_MonthPro__1D121728");

                entity.ToTable("tbl_BIZ_MonthProfit_Bizsection");

                entity.Property(e => e.BizProfitIdx).HasColumnName("bizProfitIdx");

                entity.Property(e => e.AccCd)
                    .HasColumnName("acc_cd")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdUp)
                    .HasColumnName("acc_cd_up")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccGrpCd)
                    .HasColumnName("acc_grp_cd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccGrpNm)
                    .HasColumnName("acc_grp_nm")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AccNm)
                    .HasColumnName("acc_nm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccUpNm)
                    .HasColumnName("acc_up_nm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccUseCd)
                    .HasColumnName("acc_use_cd")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BizType).HasColumnName("bizType");

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("bizsection_cd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionNm)
                    .HasColumnName("bizsection_nm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditSum)
                    .HasColumnName("creditSum")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DebitSum)
                    .HasColumnName("debitSum")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSupport).HasColumnName("isSupport");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("YYYYMM")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCompCalendar>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_compCalendar");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnName("contents")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImportantLevel).HasColumnName("importantLevel");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modiuserid)
                    .IsRequired()
                    .HasColumnName("modiuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OpenLevel).HasColumnName("openLevel");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("useYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCompCalendarOpenList>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_compCalendar_OpenList");

                entity.HasIndex(e => e.CalIdx);

                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.Empno);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CalIdx).HasColumnName("calIdx");

                entity.Property(e => e.DepartmentId).HasColumnName("department_Id");

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("useYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCompanyState>(entity =>
            {
                entity.HasKey(e => e.CompanyNo)
                    .IsClustered(false);

                entity.ToTable("tbl_company_state");

                entity.HasIndex(e => e.Upddt)
                    .HasName("IX_tbl_company_state")
                    .IsClustered();

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("company_no")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Closuredate)
                    .HasColumnName("closuredate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Regstat)
                    .IsRequired()
                    .HasColumnName("regstat")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Upddt)
                    .HasColumnName("upddt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Vatconvdate)
                    .HasColumnName("vatconvdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Vatgubun)
                    .HasColumnName("vatgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCompanyStateQueue>(entity =>
            {
                entity.HasKey(e => e.CompanyNo)
                    .IsClustered(false);

                entity.ToTable("tbl_company_state_queue");

                entity.HasIndex(e => e.Regdt)
                    .IsClustered();

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("company_no")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Regdt)
                    .HasColumnName("regdt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblCooperateAns>(entity =>
            {
                entity.HasKey(e => e.AnsIdx);

                entity.ToTable("tbl_cooperate_ans");

                entity.HasIndex(e => e.AnsIdx)
                    .HasName("IX_tbl_cooperate_ans");

                entity.Property(e => e.AnsIdx).HasColumnName("ans_idx");

                entity.Property(e => e.AnsContent)
                    .IsRequired()
                    .HasColumnName("ans_content")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AnsRegdate)
                    .HasColumnName("ans_regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AnsType).HasColumnName("ans_type");

                entity.Property(e => e.AnsUseyn)
                    .IsRequired()
                    .HasColumnName("ans_useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.DocIdx).HasColumnName("doc_idx");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblCooperateBoard>(entity =>
            {
                entity.HasKey(e => e.BrdSn)
                    .HasName("PK__tbl_cooperate_bo__2E5BD364");

                entity.ToTable("tbl_cooperate_board");

                entity.Property(e => e.BrdSn).HasColumnName("brd_sn");

                entity.Property(e => e.BrdContent)
                    .HasColumnName("brd_content")
                    .HasColumnType("text");

                entity.Property(e => e.BrdFixed).HasColumnName("brd_fixed");

                entity.Property(e => e.BrdHit).HasColumnName("brd_hit");

                entity.Property(e => e.BrdIsusing)
                    .HasColumnName("brd_isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BrdRegdate)
                    .HasColumnName("brd_regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BrdSubject)
                    .IsRequired()
                    .HasColumnName("brd_subject")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BrdTeam)
                    .HasColumnName("brd_team")
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.BrdType).HasColumnName("brd_type");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCooperateBoardComment>(entity =>
            {
                entity.HasKey(e => e.CmtSn)
                    .HasName("PK__tbl_cooperate_bo__33208881");

                entity.ToTable("tbl_cooperate_board_comment");

                entity.Property(e => e.CmtSn).HasColumnName("cmt_sn");

                entity.Property(e => e.BrdSn).HasColumnName("brd_sn");

                entity.Property(e => e.CmtContent)
                    .HasColumnName("cmt_content")
                    .HasColumnType("text");

                entity.Property(e => e.CmtRegdate)
                    .HasColumnName("cmt_regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCooperateBoardPart>(entity =>
            {
                entity.HasKey(e => new { e.PartSn, e.BrdSn, e.DepartmentId })
                    .HasName("PK__tbl_cooperate_bo__35FCF52C");

                entity.ToTable("tbl_cooperate_board_part");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.BrdSn).HasColumnName("brd_sn");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.JobSn).HasColumnName("job_sn");

                entity.Property(e => e.LevelSn).HasColumnName("level_sn");

                entity.Property(e => e.PositSn).HasColumnName("posit_sn");
            });

            modelBuilder.Entity<TblCooperateComCode>(entity =>
            {
                entity.HasKey(e => new { e.CodeType, e.CodeValue });

                entity.ToTable("tbl_cooperate_comCode");

                entity.Property(e => e.CodeType)
                    .HasColumnName("code_type")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeValue).HasColumnName("code_value");

                entity.Property(e => e.CodeDesc)
                    .IsRequired()
                    .HasColumnName("code_desc")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeSort).HasColumnName("code_sort");

                entity.Property(e => e.CodeUseyn)
                    .IsRequired()
                    .HasColumnName("code_useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblCooperateDocument>(entity =>
            {
                entity.HasKey(e => e.DocIdx);

                entity.ToTable("tbl_cooperate_document");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_tbl_cooperate_document");

                entity.Property(e => e.DocIdx).HasColumnName("doc_idx");

                entity.Property(e => e.DocAnsOx)
                    .IsRequired()
                    .HasColumnName("doc_ans_ox")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('x')");

                entity.Property(e => e.DocContent)
                    .IsRequired()
                    .HasColumnName("doc_content")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocDifficult).HasColumnName("doc_difficult");

                entity.Property(e => e.DocEnddate)
                    .HasColumnName("doc_enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocImportant).HasColumnName("doc_important");

                entity.Property(e => e.DocRefername)
                    .IsRequired()
                    .HasColumnName("doc_refername")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocRegdate)
                    .HasColumnName("doc_regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocStartdate)
                    .HasColumnName("doc_startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocStatus).HasColumnName("doc_status");

                entity.Property(e => e.DocSubject)
                    .IsRequired()
                    .HasColumnName("doc_subject")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DocType).HasColumnName("doc_type");

                entity.Property(e => e.DocUseyn)
                    .IsRequired()
                    .HasColumnName("doc_useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.DocWorkername)
                    .IsRequired()
                    .HasColumnName("doc_workername")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblCooperateFile>(entity =>
            {
                entity.HasKey(e => e.FileIdx);

                entity.ToTable("tbl_cooperate_file");

                entity.HasIndex(e => e.DocIdx)
                    .HasName("IX_tbl_cooperate_file");

                entity.Property(e => e.FileIdx).HasColumnName("file_idx");

                entity.Property(e => e.BrdSn).HasColumnName("brd_sn");

                entity.Property(e => e.DocIdx).HasColumnName("doc_idx");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RealName)
                    .HasColumnName("real_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCooperateLog>(entity =>
            {
                entity.HasKey(e => e.LogIdx);

                entity.ToTable("tbl_cooperate_log");

                entity.HasIndex(e => e.DocIdx)
                    .HasName("IX_tbl_cooperate_log");

                entity.Property(e => e.LogIdx).HasColumnName("log_idx");

                entity.Property(e => e.DocIdx).HasColumnName("doc_idx");

                entity.Property(e => e.LogContent)
                    .IsRequired()
                    .HasColumnName("log_content")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogIp)
                    .IsRequired()
                    .HasColumnName("log_ip")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LogRegdate)
                    .HasColumnName("log_regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogType).HasColumnName("log_type");
            });

            modelBuilder.Entity<TblCooperateRefer>(entity =>
            {
                entity.HasKey(e => new { e.DocIdx, e.ReferId });

                entity.ToTable("tbl_cooperate_refer");

                entity.HasIndex(e => e.PartSn)
                    .HasName("IX_tbl_cooperate_refer");

                entity.Property(e => e.DocIdx).HasColumnName("doc_idx");

                entity.Property(e => e.ReferId)
                    .HasColumnName("refer_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.ReferViewdate)
                    .HasColumnName("refer_viewdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCooperateWorker>(entity =>
            {
                entity.HasKey(e => new { e.DocIdx, e.WorkerId });

                entity.ToTable("tbl_cooperate_worker");

                entity.HasIndex(e => e.PartSn)
                    .HasName("IX_tbl_cooperate_worker");

                entity.Property(e => e.DocIdx).HasColumnName("doc_idx");

                entity.Property(e => e.WorkerId)
                    .HasColumnName("worker_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.WorkerViewdate)
                    .HasColumnName("worker_viewdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEAppAccount>(entity =>
            {
                entity.HasKey(e => e.AccountIdx);

                entity.ToTable("tbl_eAppAccount");

                entity.Property(e => e.AccountIdx).HasColumnName("accountIdx");

                entity.Property(e => e.AccountKind).HasColumnName("accountKind");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasColumnName("accountName")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.EdmsIdx).HasColumnName("edmsIdx");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblEAppAttachFile>(entity =>
            {
                entity.HasKey(e => e.AttachFileIdx)
                    .HasName("PK__tbl_eAppAttachFi__308412F8");

                entity.ToTable("tbl_eAppAttachFile");

                entity.Property(e => e.AttachFileIdx).HasColumnName("attachFileIdx");

                entity.Property(e => e.FileType).HasColumnName("fileType");

                entity.Property(e => e.Filelink)
                    .IsRequired()
                    .HasColumnName("filelink")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PayRequestIdx).HasColumnName("payRequestIdx");

                entity.Property(e => e.ReportIdx).HasColumnName("reportIdx");
            });

            modelBuilder.Entity<TblEAppAuthLine>(entity =>
            {
                entity.HasKey(e => e.AuthLineidx)
                    .HasName("PK__tbl_eAppAuthLine__40BA7AC1");

                entity.ToTable("tbl_eAppAuthLine");

                entity.HasIndex(e => e.AuthId)
                    .HasName("IX_tbl_eAppAuthLine_2");

                entity.HasIndex(e => e.PayRequestIdx)
                    .HasName("IX_tbl_eAppAuthLine");

                entity.HasIndex(e => e.ReportIdx)
                    .HasName("IX_tbl_eAppAuthLine_1");

                entity.HasIndex(e => new { e.ReportIdx, e.Authposition, e.AuthState, e.IsView, e.AuthId, e.IsUsing })
                    .HasName("IX_tbl_eAppAuthLine_authId_isUsing");

                entity.Property(e => e.AuthLineidx).HasColumnName("authLineidx");

                entity.Property(e => e.AuthId)
                    .HasColumnName("authId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AuthState).HasColumnName("authState");

                entity.Property(e => e.Authposition)
                    .HasColumnName("authposition")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Confirmdate)
                    .HasColumnName("confirmdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsSms)
                    .HasColumnName("isSMS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsType)
                    .HasColumnName("isType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsUsing)
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayRequestIdx).HasColumnName("payRequestIdx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReportIdx).HasColumnName("reportIdx");

                entity.Property(e => e.Viewdate)
                    .HasColumnName("viewdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEAppCommCd>(entity =>
            {
                entity.HasKey(e => e.CommCd);

                entity.ToTable("tbl_eAppCommCD");

                entity.Property(e => e.CommCd).HasColumnName("comm_cd");

                entity.Property(e => e.ActiveYn)
                    .IsRequired()
                    .HasColumnName("activeYn")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CommDesc)
                    .HasColumnName("comm_desc")
                    .HasColumnType("text");

                entity.Property(e => e.CommName)
                    .IsRequired()
                    .HasColumnName("comm_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Dispnum).HasColumnName("dispnum");

                entity.Property(e => e.ErpCode)
                    .HasColumnName("erpCode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Parentkey).HasColumnName("parentkey");
            });

            modelBuilder.Entity<TblEAppComment>(entity =>
            {
                entity.HasKey(e => e.CommentIdx)
                    .HasName("PK__tbl_eAppComment__2CB38214");

                entity.ToTable("tbl_eAppComment");

                entity.Property(e => e.CommentIdx).HasColumnName("commentIdx");

                entity.Property(e => e.AdminId)
                    .HasColumnName("adminId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayRequestIdx).HasColumnName("payRequestIdx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReportIdx).HasColumnName("reportIdx");
            });

            modelBuilder.Entity<TblEAppPartMoney>(entity =>
            {
                entity.HasKey(e => e.PartMoneyIdx)
                    .HasName("PK__tbl_eAppPartMone__326C5B6A");

                entity.ToTable("tbl_eAppPartMoney");

                entity.Property(e => e.PartMoneyIdx).HasColumnName("partMoneyIdx");

                entity.Property(e => e.BizSectionCd)
                    .HasColumnName("BizSection_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EappPartIdx).HasColumnName("eappPartIdx");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PartMoney)
                    .HasColumnName("partMoney")
                    .HasColumnType("money");

                entity.Property(e => e.PayRequestIdx).HasColumnName("payRequestIdx");

                entity.Property(e => e.ReportIdx).HasColumnName("reportIdx");
            });

            modelBuilder.Entity<TblEAppPayDoc>(entity =>
            {
                entity.HasKey(e => e.Paydocidx);

                entity.ToTable("tbl_eAppPayDoc");

                entity.HasIndex(e => e.PayRequestIdx)
                    .HasName("IX_tbleAppPayDoc_Uniq_payrequestIDX")
                    .IsUnique();

                entity.Property(e => e.Paydocidx).HasColumnName("paydocidx");

                entity.Property(e => e.AdminId)
                    .HasColumnName("adminId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Attachfile)
                    .HasColumnName("attachfile")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("bigo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErpDocLinkKey)
                    .HasColumnName("erpDocLinkKey")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ErpDocLinkType)
                    .HasColumnName("erpDocLinkType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ErpDocSendDate)
                    .HasColumnName("erpDocSendDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Etaxkey)
                    .HasColumnName("etaxkey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Issuedate)
                    .HasColumnName("issuedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayRequestIdx).HasColumnName("payRequestIdx");

                entity.Property(e => e.Paydockind).HasColumnName("paydockind");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Supplyprice)
                    .HasColumnName("supplyprice")
                    .HasColumnType("money");

                entity.Property(e => e.Totprice)
                    .HasColumnName("totprice")
                    .HasColumnType("money");

                entity.Property(e => e.Vatkind)
                    .HasColumnName("vatkind")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vatprice)
                    .HasColumnName("vatprice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblEAppPayRequest>(entity =>
            {
                entity.HasKey(e => e.PayRequestidx)
                    .HasName("PK__tbl_eAppPayReque__0658CF02");

                entity.ToTable("tbl_eAppPayRequest");

                entity.HasIndex(e => e.AdminId)
                    .HasName("IX_tbl_eAppPayRequest_1");

                entity.HasIndex(e => e.ReportIdx)
                    .HasName("IX_tbl_eAppPayRequest");

                entity.Property(e => e.PayRequestidx).HasColumnName("payRequestidx");

                entity.Property(e => e.AccountHolder)
                    .HasColumnName("accountHolder")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasColumnName("accountNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdminId)
                    .HasColumnName("adminId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCd)
                    .HasColumnName("arap_cd")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text");

                entity.Property(e => e.Currencyprice)
                    .HasColumnName("currencyprice")
                    .HasColumnType("money");

                entity.Property(e => e.Currencytype)
                    .HasColumnName("currencytype")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustCd)
                    .HasColumnName("cust_cd")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ErpLinkKey)
                    .HasColumnName("erpLinkKey")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ErpLinkType)
                    .HasColumnName("erpLinkType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InBank)
                    .HasColumnName("inBank")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsTakeDoc).HasColumnName("isTakeDoc");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OutBank).HasColumnName("outBank");

                entity.Property(e => e.PayRealdate)
                    .HasColumnName("payRealdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayRequestPrice)
                    .HasColumnName("payRequestPrice")
                    .HasColumnType("money");

                entity.Property(e => e.PayRequestState).HasColumnName("payRequestState");

                entity.Property(e => e.PayRequestTitle)
                    .HasColumnName("payRequestTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayRequestType).HasColumnName("payRequestType");

                entity.Property(e => e.PayRequestdate)
                    .HasColumnName("payRequestdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paydate)
                    .HasColumnName("paydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paytype).HasColumnName("paytype");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReportIdx).HasColumnName("reportIdx");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEAppPayRequestSubList>(entity =>
            {
                entity.HasKey(e => e.PayRequestSubIdx)
                    .HasName("PK_tbl_eAppPayRequest_SubList_1");

                entity.ToTable("tbl_eAppPayRequest_SubList");

                entity.Property(e => e.PayRequestSubIdx).HasColumnName("payRequestSubIdx");

                entity.Property(e => e.ErpKey)
                    .HasColumnName("erpKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PayRequestIdx).HasColumnName("payRequestIdx");

                entity.Property(e => e.PayState)
                    .HasColumnName("payState")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefKey).HasColumnName("refKey");

                entity.Property(e => e.RefType).HasColumnName("refType");
            });

            modelBuilder.Entity<TblEAppReport>(entity =>
            {
                entity.HasKey(e => e.ReportIdx)
                    .HasName("PK__tbl_eAppReport_reportIdx");

                entity.ToTable("tbl_eAppReport");

                entity.HasIndex(e => e.AdminId)
                    .HasName("IX_tbl_eAppReport");

                entity.Property(e => e.ReportIdx).HasColumnName("reportIdx");

                entity.Property(e => e.AccountIdx)
                    .HasColumnName("accountIdx")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AdminId)
                    .HasColumnName("adminId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCd)
                    .HasColumnName("arap_cd")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.Bigo)
                    .HasColumnName("bigo")
                    .HasColumnType("text");

                entity.Property(e => e.Currencyprice)
                    .HasColumnName("currencyprice")
                    .HasColumnType("money");

                entity.Property(e => e.Currencytype)
                    .HasColumnName("currencytype")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EdmsIdx).HasColumnName("edmsIdx");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastApprovalid).HasColumnName("lastApprovalid");

                entity.Property(e => e.Paytype).HasColumnName("paytype");

                entity.Property(e => e.ReferId)
                    .HasColumnName("referId")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReportContents)
                    .HasColumnName("reportContents")
                    .HasColumnType("text");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasColumnName("reportName")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ReportPrice)
                    .HasColumnName("reportPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ReportState).HasColumnName("reportState");

                entity.Property(e => e.ScmlinkNo).HasColumnName("scmlinkNo");
            });

            modelBuilder.Entity<TblEappPart>(entity =>
            {
                entity.HasKey(e => e.EappPartIdx)
                    .HasName("PK__tbl_eappPart__703483B9");

                entity.ToTable("tbl_eappPart");

                entity.Property(e => e.EappPartIdx).HasColumnName("eappPartIdx");

                entity.Property(e => e.EappDepth).HasColumnName("eappDepth");

                entity.Property(e => e.EappPartName)
                    .IsRequired()
                    .HasColumnName("eappPartName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PartSort).HasColumnName("partSort");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Step1PartIdx).HasColumnName("step1PartIdx");

                entity.Property(e => e.Step2PartIdx).HasColumnName("step2PartIdx");
            });

            modelBuilder.Entity<TblEappPayManager>(entity =>
            {
                entity.HasKey(e => e.PayManagerIdx)
                    .HasName("PK__tbl_eappPayManag__3DA903EC");

                entity.ToTable("tbl_eappPayManager");

                entity.Property(e => e.PayManagerIdx).HasColumnName("payManagerIdx");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PayManagerType)
                    .HasColumnName("payManagerType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEdms>(entity =>
            {
                entity.HasKey(e => e.Edmsidx)
                    .HasName("PK__tbl_edms_master__5DC0CDC3");

                entity.ToTable("tbl_edms");

                entity.Property(e => e.Edmsidx).HasColumnName("edmsidx");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Cateidx1).HasColumnName("cateidx1");

                entity.Property(e => e.Cateidx2).HasColumnName("cateidx2");

                entity.Property(e => e.EdmsFile)
                    .HasColumnName("edmsFile")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Edmscode)
                    .IsRequired()
                    .HasColumnName("edmscode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Edmsform)
                    .HasColumnName("edmsform")
                    .HasColumnType("text");

                entity.Property(e => e.Edmsname)
                    .HasColumnName("edmsname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.IsAgreeNeed)
                    .HasColumnName("isAgreeNeed")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsAgreeNeedTarget)
                    .HasColumnName("isAgreeNeedTarget")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsApproval)
                    .IsRequired()
                    .HasColumnName("isApproval")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPayEapp).HasColumnName("isPayEApp");

                entity.Property(e => e.IsScmApproval)
                    .IsRequired()
                    .HasColumnName("isScmApproval")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastApprovalid).HasColumnName("lastApprovalid");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ScmLink)
                    .HasColumnName("scmLink")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ScmSubmitLink)
                    .HasColumnName("scmSubmitLink")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNum)
                    .IsRequired()
                    .HasColumnName("serialNum")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ViewNo).HasColumnName("viewNo");
            });

            modelBuilder.Entity<TblEdmsCategory>(entity =>
            {
                entity.HasKey(e => e.Categoryidx)
                    .HasName("PK__tbl_edms_categor__168449D3");

                entity.ToTable("tbl_edms_category");

                entity.Property(e => e.Categoryidx).HasColumnName("categoryidx");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Catedepth)
                    .HasColumnName("catedepth")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Pcateidx).HasColumnName("pcateidx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblEquipmentGubun>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Gubuntype, e.Gubuncd });

                entity.ToTable("tbl_equipment_gubun");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Gubuntype)
                    .HasColumnName("gubuntype")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gubuncd)
                    .HasColumnName("gubuncd")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gubunname)
                    .IsRequired()
                    .HasColumnName("gubunname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Orderno).HasColumnName("orderno");

                entity.Property(e => e.Typename)
                    .IsRequired()
                    .HasColumnName("typename")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEquipmentInfoDtl>(entity =>
            {
                entity.HasKey(e => new { e.EqIdx, e.InfoGbnIdx });

                entity.ToTable("tbl_equipment_info_Dtl");

                entity.Property(e => e.EqIdx).HasColumnName("eq_idx");

                entity.Property(e => e.InfoGbnIdx).HasColumnName("info_GbnIdx");

                entity.Property(e => e.InfoValue)
                    .IsRequired()
                    .HasColumnName("info_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEquipmentInfoGbn>(entity =>
            {
                entity.HasKey(e => e.InfoGbnIdx);

                entity.ToTable("tbl_equipment_info_Gbn");

                entity.Property(e => e.InfoGbnIdx).HasColumnName("info_GbnIdx");

                entity.Property(e => e.InfoGbnName)
                    .IsRequired()
                    .HasColumnName("info_GbnName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.InfoGubun).HasColumnName("info_gubun");

                entity.Property(e => e.InfoSort)
                    .HasColumnName("info_sort")
                    .HasDefaultValueSql("((999))");
            });

            modelBuilder.Entity<TblEquipmentIp>(entity =>
            {
                entity.HasKey(e => e.Ipidx);

                entity.ToTable("tbl_equipment_ip");

                entity.Property(e => e.Ipidx).HasColumnName("ipidx");

                entity.Property(e => e.CompanyIp)
                    .IsRequired()
                    .HasColumnName("company_ip")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Gubuncd)
                    .IsRequired()
                    .HasColumnName("gubuncd")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");
            });

            modelBuilder.Entity<TblEquipmentList사용안함>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_equipment_list");

                entity.ToTable("tbl_equipment_list_사용안함");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.BuyCompanyCode)
                    .HasColumnName("buy_company_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCompanyName)
                    .HasColumnName("buy_company_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCost)
                    .HasColumnName("buy_cost")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BuyDate)
                    .HasColumnName("buy_date")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BuySum)
                    .HasColumnName("buy_sum")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BuyVat)
                    .HasColumnName("buy_vat")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DetailIp)
                    .HasColumnName("detail_ip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DetailQuality1)
                    .HasColumnName("detail_quality1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DetailQuality2)
                    .HasColumnName("detail_quality2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DetailQualityetc)
                    .HasColumnName("detail_qualityetc")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DurabilityMonth)
                    .HasColumnName("durability_month")
                    .HasDefaultValueSql("(60)");

                entity.Property(e => e.EquipCode)
                    .HasColumnName("equip_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquipGubun)
                    .HasColumnName("equip_gubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EquipName)
                    .HasColumnName("equip_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.EtcStr)
                    .HasColumnName("etc_str")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureCompany)
                    .HasColumnName("manufacture_company")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ModelName)
                    .HasColumnName("model_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Modiuserid)
                    .HasColumnName("modiuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .HasColumnName("part_code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Usinguserid)
                    .HasColumnName("usinguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEquipmentLog사용안함>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_equipment_log");

                entity.ToTable("tbl_equipment_log_사용안함");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.BuyCompanyCode)
                    .HasColumnName("buy_company_code")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCompanyName)
                    .HasColumnName("buy_company_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCost)
                    .HasColumnName("buy_cost")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BuyDate)
                    .HasColumnName("buy_date")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BuySum)
                    .HasColumnName("buy_sum")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BuyVat)
                    .HasColumnName("buy_vat")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DelDate)
                    .HasColumnName("del_date")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DelId)
                    .HasColumnName("del_id")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DetailIp)
                    .HasColumnName("detail_ip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DetailQuality1)
                    .HasColumnName("detail_quality1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DetailQuality2)
                    .HasColumnName("detail_quality2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DetailQualityetc)
                    .HasColumnName("detail_qualityetc")
                    .HasColumnType("text");

                entity.Property(e => e.DurabilityMonth)
                    .HasColumnName("durability_month")
                    .HasDefaultValueSql("(36)");

                entity.Property(e => e.EquipCode)
                    .HasColumnName("equip_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquipGubun)
                    .HasColumnName("equip_gubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EquipName)
                    .HasColumnName("equip_name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EquipNo)
                    .HasColumnName("equip_no")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.EtcStr)
                    .HasColumnName("etc_str")
                    .HasColumnType("text");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureCompany)
                    .HasColumnName("manufacture_company")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ModelName)
                    .HasColumnName("model_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Modiuserid)
                    .HasColumnName("modiuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PartCode)
                    .HasColumnName("part_code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Usinguserid)
                    .HasColumnName("usinguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEquipmentMain>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_equipment_main");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.AccountGubun)
                    .HasColumnName("account_gubun")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Accountassetcode)
                    .HasColumnName("accountassetcode")
                    .HasMaxLength(32);

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("BIZSECTION_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCompanyName)
                    .HasColumnName("buy_company_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCost)
                    .HasColumnName("buy_cost")
                    .HasColumnType("money");

                entity.Property(e => e.BuyDate)
                    .HasColumnName("buy_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BuySum)
                    .HasColumnName("buy_sum")
                    .HasColumnType("money");

                entity.Property(e => e.BuyVat)
                    .HasColumnName("buy_vat")
                    .HasColumnType("money");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DurabilityMonth)
                    .HasColumnName("durability_month")
                    .HasDefaultValueSql("((60))");

                entity.Property(e => e.EquipCode)
                    .IsRequired()
                    .HasColumnName("equip_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquipGubun)
                    .IsRequired()
                    .HasColumnName("equip_gubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EquipMainimage)
                    .HasColumnName("equip_mainimage")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EquipName)
                    .HasColumnName("equip_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EquipSpec)
                    .HasColumnName("equip_spec")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Etc)
                    .HasColumnName("etc")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.InfoGubun).HasColumnName("info_gubun");

                entity.Property(e => e.InfoImportanceA).HasColumnName("info_importance_A");

                entity.Property(e => e.InfoImportanceC).HasColumnName("info_importance_C");

                entity.Property(e => e.InfoImportanceI).HasColumnName("info_importance_I");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastuserid)
                    .HasColumnName("lastuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LocateGubun)
                    .HasColumnName("locate_gubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ManufactureCompany)
                    .HasColumnName("manufacture_company")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureManager)
                    .HasColumnName("manufacture_manager")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureSn)
                    .HasColumnName("manufacture_sn")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureTel)
                    .HasColumnName("manufacture_tel")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyDeprice)
                    .HasColumnName("monthlyDeprice")
                    .HasColumnType("money");

                entity.Property(e => e.OutDate)
                    .HasColumnName("out_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.Paymentrequestidx).HasColumnName("paymentrequestidx");

                entity.Property(e => e.PropertyGubun).HasColumnName("property_gubun");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RemainValue201412)
                    .HasColumnName("remainValue201412")
                    .HasColumnType("money");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsingDate)
                    .HasColumnName("using_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsingUserid)
                    .HasColumnName("using_userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEquipmentMainLog>(entity =>
            {
                entity.HasKey(e => e.Logidx);

                entity.ToTable("tbl_equipment_main_log");

                entity.Property(e => e.Logidx).HasColumnName("logidx");

                entity.Property(e => e.AccountGubun)
                    .HasColumnName("account_gubun")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Accountassetcode)
                    .HasColumnName("accountassetcode")
                    .HasMaxLength(32);

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("BIZSECTION_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCompanyName)
                    .HasColumnName("buy_company_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCost)
                    .HasColumnName("buy_cost")
                    .HasColumnType("money");

                entity.Property(e => e.BuyDate)
                    .HasColumnName("buy_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BuySum)
                    .HasColumnName("buy_sum")
                    .HasColumnType("money");

                entity.Property(e => e.BuyVat)
                    .HasColumnName("buy_vat")
                    .HasColumnType("money");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DurabilityMonth)
                    .HasColumnName("durability_month")
                    .HasDefaultValueSql("((60))");

                entity.Property(e => e.EquipCode)
                    .IsRequired()
                    .HasColumnName("equip_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquipGubun)
                    .IsRequired()
                    .HasColumnName("equip_gubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EquipMainimage)
                    .HasColumnName("equip_mainimage")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EquipName)
                    .HasColumnName("equip_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.EquipSpec)
                    .HasColumnName("equip_spec")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Etc)
                    .HasColumnName("etc")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastuserid)
                    .HasColumnName("lastuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LocateGubun)
                    .HasColumnName("locate_gubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Logregdate)
                    .HasColumnName("logregdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Logreguserid)
                    .IsRequired()
                    .HasColumnName("logreguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureCompany)
                    .HasColumnName("manufacture_company")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureManager)
                    .HasColumnName("manufacture_manager")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureSn)
                    .HasColumnName("manufacture_sn")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureTel)
                    .HasColumnName("manufacture_tel")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyDeprice)
                    .HasColumnName("monthlyDeprice")
                    .HasColumnType("money");

                entity.Property(e => e.OutDate)
                    .HasColumnName("out_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.Paymentrequestidx).HasColumnName("paymentrequestidx");

                entity.Property(e => e.PropertyGubun).HasColumnName("property_gubun");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RemainValue201412)
                    .HasColumnName("remainValue201412")
                    .HasColumnType("money");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsingDate)
                    .HasColumnName("using_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsingUserid)
                    .HasColumnName("using_userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEquipmentMonthly>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.Idx });

                entity.ToTable("tbl_equipment_monthly");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.AccountGubun)
                    .HasColumnName("account_gubun")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionCd)
                    .IsRequired()
                    .HasColumnName("BIZSECTION_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCost)
                    .HasColumnName("buy_cost")
                    .HasColumnType("money");

                entity.Property(e => e.BuyDate)
                    .HasColumnName("buy_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BuySum)
                    .HasColumnName("buy_sum")
                    .HasColumnType("money");

                entity.Property(e => e.MonthDownValue)
                    .HasColumnName("month_down_value")
                    .HasColumnType("money");

                entity.Property(e => e.MonthRemainValue)
                    .HasColumnName("month_remain_value")
                    .HasColumnType("money");

                entity.Property(e => e.OutDate)
                    .HasColumnName("out_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State).HasColumnName("state");
            });

            modelBuilder.Entity<TblEseroAutoIcheMapData>(entity =>
            {
                entity.HasKey(e => e.AutoIcheIdx);

                entity.ToTable("tbl_Esero_AutoIcheMapData");

                entity.Property(e => e.AutoIcheIdx).HasColumnName("autoIcheIdx");

                entity.Property(e => e.AssignArapCd).HasColumnName("AssignArap_cd");

                entity.Property(e => e.AssignBizSec)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AutoIcheTitle)
                    .IsRequired()
                    .HasColumnName("autoIcheTitle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorpNo)
                    .IsRequired()
                    .HasColumnName("corpNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CustCd)
                    .HasColumnName("cust_cd")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.MatchType).HasColumnName("matchType");

                entity.Property(e => e.MayAcctDate)
                    .HasColumnName("mayAcctDate")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MayAcctJukyo)
                    .HasColumnName("mayAcctJukyo")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MayIcheDate)
                    .HasColumnName("mayIcheDate")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MayPrice)
                    .HasColumnName("mayPrice")
                    .HasColumnType("money");

                entity.Property(e => e.MayPumok)
                    .HasColumnName("mayPumok")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEseroTax>(entity =>
            {
                entity.HasKey(e => e.TaxKey);

                entity.ToTable("tbl_Esero_Tax");

                entity.HasIndex(e => e.AppDate)
                    .HasName("IX_tbl_Esero_Tax_SellCorp_AppDate");

                entity.HasIndex(e => e.SellCorpNo);

                entity.Property(e => e.TaxKey)
                    .HasColumnName("taxKey")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasComment("승인번호");

                entity.Property(e => e.AppDate)
                    .IsRequired()
                    .HasColumnName("appDate")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("작성일자");

                entity.Property(e => e.Bigo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCeoName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCorpName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyCorpNo)
                    .IsRequired()
                    .HasColumnName("buyCorpNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BuyEmail)
                    .HasColumnName("buyEmail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BuyJongNo)
                    .IsRequired()
                    .HasColumnName("buyJongNo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DtlBigo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DtlDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DtlName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DtlNameOrg)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DtlSuplysum).HasColumnType("money");

                entity.Property(e => e.DtltaxSum).HasColumnType("money");

                entity.Property(e => e.EvalTypeNm)
                    .HasColumnName("evalTypeNm")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasComment("발급유형");

                entity.Property(e => e.MayErrType).HasColumnName("mayErrType");

                entity.Property(e => e.RecreqGubunNm)
                    .HasColumnName("recreqGubunNm")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasComment("영수/청구");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqDate)
                    .HasColumnName("reqDate")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("발급일");

                entity.Property(e => e.SellCeoName)
                    .IsRequired()
                    .HasColumnName("sellCeoName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SellCorpName)
                    .IsRequired()
                    .HasColumnName("sellCorpName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SellCorpNo)
                    .IsRequired()
                    .HasColumnName("sellCorpNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SellEmail)
                    .HasColumnName("sellEmail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SellJongNo)
                    .IsRequired()
                    .HasColumnName("sellJongNo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SendDate)
                    .HasColumnName("sendDate")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("전송일");

                entity.Property(e => e.SuplySum)
                    .HasColumnName("suplySum")
                    .HasColumnType("money");

                entity.Property(e => e.TaxArapCd)
                    .HasColumnName("tax_arap_cd")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.TaxCustCd)
                    .HasColumnName("tax_cust_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TaxModiType)
                    .HasColumnName("taxModiType")
                    .HasComment("0:세금계산서(전자),1:수정세금계산서(전자), 9:수기계산서");

                entity.Property(e => e.TaxSellType)
                    .HasColumnName("taxSellType")
                    .HasComment("1:매출세금계산서,0:매입세금계산서");

                entity.Property(e => e.TaxSum)
                    .HasColumnName("taxSum")
                    .HasColumnType("money");

                entity.Property(e => e.TaxType)
                    .HasColumnName("taxType")
                    .HasComment("1:과세, 2:영세, 3:면세");

                entity.Property(e => e.TotSum)
                    .HasColumnName("totSum")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblEseroTaxMatch>(entity =>
            {
                entity.HasKey(e => new { e.TaxKey, e.MatchSeq });

                entity.ToTable("tbl_Esero_TaxMatch");

                entity.Property(e => e.TaxKey)
                    .HasColumnName("taxKey")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.MatchSeq).HasColumnName("matchSeq");

                entity.Property(e => e.BizSecCd)
                    .HasColumnName("bizSecCD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErpLinkKey)
                    .HasColumnName("erpLinkKey")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ErpLinkType)
                    .HasColumnName("erpLinkType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MatchKey).HasColumnName("matchKey");

                entity.Property(e => e.MatchState).HasColumnName("matchState");

                entity.Property(e => e.MatchType)
                    .HasColumnName("matchType")
                    .HasComment("1:온라인정산,2:오프라인정산,3:아이띵소정산,11:온라인매출");
            });

            modelBuilder.Entity<TblInternalOrder>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_InternalOrder");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.AccCd)
                    .HasColumnName("acc_cd")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AppDate)
                    .IsRequired()
                    .HasColumnName("appDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BuybizsectionCd)
                    .HasColumnName("BUYBIZSECTION_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Buyuserid)
                    .HasColumnName("buyuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Deldate)
                    .HasColumnName("deldate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Divcd)
                    .IsRequired()
                    .HasColumnName("divcd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SellbizsectionCd)
                    .HasColumnName("SELLBIZSECTION_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Selluserid)
                    .HasColumnName("selluserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SupplySum)
                    .HasColumnName("supplySum")
                    .HasColumnType("money");

                entity.Property(e => e.TaxSum)
                    .HasColumnName("taxSum")
                    .HasColumnType("money");

                entity.Property(e => e.TotalSum)
                    .HasColumnName("totalSum")
                    .HasColumnType("money");

                entity.Property(e => e.Useyn)
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Vatyn)
                    .HasColumnName("vatyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInternalOrderDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_InternalOrderDetail");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Dealdiv)
                    .HasColumnName("dealdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Innerorderpercentage).HasColumnName("innerorderpercentage");

                entity.Property(e => e.Itemdiv)
                    .HasColumnName("itemdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Masteridx).HasColumnName("masteridx");

                entity.Property(e => e.Meachulgubun)
                    .HasColumnName("meachulgubun")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Pricediv)
                    .HasColumnName("pricediv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Shopid)
                    .IsRequired()
                    .HasColumnName("shopid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sitefee).HasColumnName("sitefee");

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SupplySum)
                    .HasColumnName("supplySum")
                    .HasColumnType("money");

                entity.Property(e => e.TaxSum)
                    .HasColumnName("taxSum")
                    .HasColumnType("money");

                entity.Property(e => e.TotalSum)
                    .HasColumnName("totalSum")
                    .HasColumnType("money");

                entity.Property(e => e.Totalbuycash)
                    .HasColumnName("totalbuycash")
                    .HasColumnType("money");

                entity.Property(e => e.Totalchulgocash)
                    .HasColumnName("totalchulgocash")
                    .HasColumnType("money");

                entity.Property(e => e.Totalsellcash)
                    .HasColumnName("totalsellcash")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblInternalPart>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_InternalPart");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("BIZSECTION_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Divcd)
                    .IsRequired()
                    .HasColumnName("divcd")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Scmid)
                    .HasColumnName("scmid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Useyn)
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblJobInfo>(entity =>
            {
                entity.HasKey(e => e.JobSn)
                    .HasName("PK__tbl_JobInfo__047AA831");

                entity.ToTable("tbl_JobInfo");

                entity.Property(e => e.JobSn).HasColumnName("job_sn");

                entity.Property(e => e.JobIsDel)
                    .HasColumnName("job_isDel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.JobName)
                    .HasColumnName("job_name")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLevel>(entity =>
            {
                entity.HasKey(e => e.LevelSn)
                    .HasName("PK__tbl_level__690797E6");

                entity.ToTable("tbl_level");

                entity.Property(e => e.LevelSn).HasColumnName("level_sn");

                entity.Property(e => e.LevelIsDel)
                    .IsRequired()
                    .HasColumnName("level_isDel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LevelName)
                    .HasColumnName("level_name")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.LevelNo)
                    .HasColumnName("level_no")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblMdmenuCategory>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_md_catepurpose");

                entity.ToTable("tbl_mdmenu_category");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMdmenuPurpose>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Catecode })
                    .HasName("PK_tbl_mdmenu_purpose_1");

                entity.ToTable("tbl_mdmenu_purpose");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Gubun)
                    .HasColumnName("gubun")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mm)
                    .HasColumnName("mm")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProfitMoney)
                    .HasColumnName("profitMoney")
                    .HasColumnType("money");

                entity.Property(e => e.TargetMoney)
                    .HasColumnName("targetMoney")
                    .HasColumnType("money");

                entity.Property(e => e.Yyyy)
                    .IsRequired()
                    .HasColumnName("yyyy")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblMenuPart>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.PartSn })
                    .HasName("PK__tbl_menu_part__3F115E1A");

                entity.ToTable("tbl_menu_part");

                entity.HasIndex(e => new { e.PartSn, e.LevelSn })
                    .HasName("IX_tbl_menu_part_partLevel");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.LevelSn)
                    .HasColumnName("level_sn")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblMenuUser>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.MenuId })
                    .HasName("PK__tbl_menu_user__40058253");

                entity.ToTable("tbl_menu_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId).HasColumnName("menu_id");
            });

            modelBuilder.Entity<TblMonthlyBrandInfo>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.Makerid });

                entity.ToTable("tbl_monthly_brandInfo");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultDeliveryType)
                    .HasColumnName("defaultDeliveryType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultOnMargin).HasColumnName("defaultOnMargin");

                entity.Property(e => e.DefaultOnMwDiv)
                    .HasColumnName("defaultOnMwDiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Defaultdeliverpay)
                    .HasColumnName("defaultdeliverpay")
                    .HasColumnType("money");

                entity.Property(e => e.Defaultfreebeasonglimit)
                    .HasColumnName("defaultfreebeasonglimit")
                    .HasColumnType("money");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCountMsale).HasColumnName("ItemCountMSale");

                entity.Property(e => e.ItemCountTtl).HasColumnName("ItemCountTTL");

                entity.Property(e => e.ItemCountTtlsale).HasColumnName("ItemCountTTLSale");

                entity.Property(e => e.ItemCountUsale).HasColumnName("ItemCountUSale");

                entity.Property(e => e.ItemCountWsale).HasColumnName("ItemCountWSale");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MMargin).HasColumnName("M_margin");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SellType).HasColumnName("sellType");

                entity.Property(e => e.StockAreaBox).HasColumnName("stockAreaBox");

                entity.Property(e => e.UMargin).HasColumnName("U_margin");

                entity.Property(e => e.WMargin).HasColumnName("W_margin");
            });

            modelBuilder.Entity<TblMonthlySoldoutCancel>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.AllianceYn });

                entity.ToTable("tbl_monthly_soldout_cancel");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AllianceYn)
                    .HasColumnName("allianceYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CommName)
                    .IsRequired()
                    .HasColumnName("comm_name")
                    .HasMaxLength(32);

                entity.Property(e => e.Gubun)
                    .IsRequired()
                    .HasColumnName("gubun")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Totalcnt).HasColumnName("totalcnt");
            });

            modelBuilder.Entity<TblNewpartnerMenu>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_newpartner_menu");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.Depth1).HasColumnName("depth1");

                entity.Property(e => e.Depth1name)
                    .IsRequired()
                    .HasColumnName("depth1name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2).HasColumnName("depth2");

                entity.Property(e => e.Depth2name)
                    .HasColumnName("depth2name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3).HasColumnName("depth3");

                entity.Property(e => e.Depth3name)
                    .HasColumnName("depth3name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Divcd).HasColumnName("divcd");

                entity.Property(e => e.Explanation)
                    .HasColumnName("explanation")
                    .HasColumnType("text");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Linkurl)
                    .HasColumnName("linkurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Viewidx)
                    .HasColumnName("viewidx")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblOffshopEmployeeWorkcode>(entity =>
            {
                entity.HasKey(e => e.Workcode);

                entity.ToTable("tbl_offshop_employee_workcode");

                entity.Property(e => e.Workcode)
                    .HasColumnName("workcode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Endwork)
                    .IsRequired()
                    .HasColumnName("endwork")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Startwork)
                    .IsRequired()
                    .HasColumnName("startwork")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblOffshopEmployeeWorkschedule>(entity =>
            {
                entity.HasKey(e => new { e.Empno, e.Workdate });

                entity.ToTable("tbl_offshop_employee_workschedule");

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Workdate)
                    .HasColumnName("workdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Workcode)
                    .IsRequired()
                    .HasColumnName("workcode")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpExpAccount>(entity =>
            {
                entity.HasKey(e => e.OpExpAccountidx)
                    .HasName("PK__tbl_OpExpAccount__09BF4B92");

                entity.ToTable("tbl_OpExpAccount");

                entity.Property(e => e.ArapCd)
                    .HasColumnName("arap_cd")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.CommCd).HasColumnName("comm_cd");

                entity.Property(e => e.Inouttype)
                    .HasColumnName("inouttype")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblOpExpDaily>(entity =>
            {
                entity.HasKey(e => e.OpExpDailyIdx)
                    .HasName("PK__tbl_OpExpDetail__0F7824E8");

                entity.ToTable("tbl_OpExpDaily");

                entity.Property(e => e.AccountIdx).HasColumnName("accountIdx");

                entity.Property(e => e.ArapCd)
                    .HasColumnName("arap_cd")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.AuthNo)
                    .HasColumnName("authNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BizSectionCd)
                    .HasColumnName("BizSection_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusiIdx)
                    .HasColumnName("busiIdx")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CommCd).HasColumnName("comm_cd");

                entity.Property(e => e.DetailConts)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ErpLinkSeq)
                    .HasColumnName("erpLinkSEQ")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.InExp)
                    .HasColumnName("inExp")
                    .HasColumnType("money");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpExpObj)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OutExp)
                    .HasColumnName("outExp")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regid)
                    .IsRequired()
                    .HasColumnName("regid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SupExp)
                    .HasColumnName("supExp")
                    .HasColumnType("money");

                entity.Property(e => e.VatExp)
                    .HasColumnName("vatExp")
                    .HasColumnType("money");

                entity.Property(e => e.Yyyymmdd)
                    .IsRequired()
                    .HasColumnName("YYYYMMDD")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpExpDailyCard>(entity =>
            {
                entity.HasKey(e => e.OpExpDailyCardIdx)
                    .HasName("PK__tbl_OpExpDailyCa__747A15E9");

                entity.ToTable("tbl_OpExpDailyCard");

                entity.Property(e => e.AccCd)
                    .HasColumnName("ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCd)
                    .HasColumnName("arap_cd")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.AuthDate).HasColumnType("datetime");

                entity.Property(e => e.AuthNo)
                    .HasColumnName("authNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BizNo)
                    .HasColumnName("bizNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("Bizsection_cd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardTmpSeq).HasColumnName("cardTmpSeq");

                entity.Property(e => e.DeductType).HasColumnName("deductType");

                entity.Property(e => e.DetailConts)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ErpLinkSeq)
                    .HasColumnName("erpLinkSEQ")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpExpObj)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OutExp)
                    .HasColumnName("outExp")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regid)
                    .HasColumnName("regid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SevExp)
                    .HasColumnName("sevExp")
                    .HasColumnType("money");

                entity.Property(e => e.SupExp)
                    .HasColumnName("supExp")
                    .HasColumnType("money");

                entity.Property(e => e.UseScope)
                    .HasColumnName("useScope")
                    .HasComment("1-국내, 2-국외");

                entity.Property(e => e.VatExp)
                    .HasColumnName("vatExp")
                    .HasColumnType("money");

                entity.Property(e => e.VatType)
                    .HasColumnName("vatType")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("YYYYMM")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpExpDepartmentInfo>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_OpExpDepartm__752E4300");

                entity.ToTable("tbl_OpExpDepartmentInfo");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("useYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblOpExpMonthly>(entity =>
            {
                entity.HasKey(e => e.OpExpidx)
                    .HasName("PK__tbl_OpExp__05EEBAAE");

                entity.ToTable("tbl_OpExpMonthly");

                entity.Property(e => e.ErpLinkKey)
                    .HasColumnName("erpLinkKey")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ErpLinkType)
                    .HasColumnName("erpLinkType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InExp).HasColumnType("money");

                entity.Property(e => e.LastMonthExp).HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutExp).HasColumnType("money");

                entity.Property(e => e.RegId)
                    .IsRequired()
                    .HasColumnName("regId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TotExp).HasColumnType("money");

                entity.Property(e => e.Yyyymm)
                    .IsRequired()
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpExpMonthlyCard>(entity =>
            {
                entity.HasKey(e => e.OpExpCardIdx)
                    .HasName("PK__tbl_OpExpMonthly__72F0F4D3");

                entity.ToTable("tbl_OpExpMonthlyCard");

                entity.Property(e => e.ErpLinkKey)
                    .HasColumnName("erpLinkKey")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ErpLinkType)
                    .HasColumnName("erpLinkType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutExp).HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regid)
                    .HasColumnName("regid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Yyyymm)
                    .IsRequired()
                    .HasColumnName("YYYYMM")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpExpPart>(entity =>
            {
                entity.HasKey(e => e.OpExpPartidx)
                    .HasName("PK__tbl_OpExpPart__12549193");

                entity.ToTable("tbl_OpExpPart");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCd)
                    .HasColumnName("ARAP_CD")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("BIZSECTION_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CardCo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustCd)
                    .HasColumnName("cust_cd")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.EapppArtiDx).HasColumnName("EAPPpARTiDX");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OpExpPartName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.OutAccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutBank)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutName)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOpExpPartInfo>(entity =>
            {
                entity.HasKey(e => e.OpExpPartInfoIdx)
                    .HasName("PK__tbl_OpExpPartInf__377B294A");

                entity.ToTable("tbl_OpExpPartInfo");

                entity.Property(e => e.OpExpPartInfoIdx).HasColumnName("opExpPartInfoIdx");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");
            });

            modelBuilder.Entity<TblOpExpPartType>(entity =>
            {
                entity.HasKey(e => e.PartTypeidx)
                    .HasName("PK__tbl_OpExpPartTyp__171946B0");

                entity.ToTable("tbl_OpExpPartType");

                entity.Property(e => e.IsCard)
                    .HasColumnName("isCard")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PartTypeName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutbrand>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.Makerid });

                entity.ToTable("tbl_outbrand");

                entity.HasIndex(e => e.Yyyymm)
                    .HasName("IX_tbl_out_brand_YYYYMM");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastPartnerLogindate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lastgrouplogindate)
                    .HasColumnName("lastgrouplogindate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lastminuscnt)
                    .HasColumnName("lastminuscnt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lastminussum)
                    .HasColumnName("lastminussum")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lastoffjungsansum)
                    .HasColumnName("lastoffjungsansum")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lastonjungsansum)
                    .HasColumnName("lastonjungsansum")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastsellDateOf)
                    .HasColumnName("lastsellDateOF")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastsellDateOn)
                    .HasColumnName("lastsellDateON")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Makerlevel)
                    .HasColumnName("makerlevel")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Makername)
                    .HasColumnName("makername")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Newitemcount)
                    .HasColumnName("newitemcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Usingitemcount)
                    .HasColumnName("usingitemcount")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblPartInfo>(entity =>
            {
                entity.HasKey(e => e.PartSn)
                    .HasName("PK__tbl_partInfo__42E1EEFE");

                entity.ToTable("tbl_partInfo");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.PartIsDel)
                    .IsRequired()
                    .HasColumnName("part_isDel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PartName)
                    .HasColumnName("part_name")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PartSort)
                    .HasColumnName("part_sort")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblPartner>(entity =>
            {
                entity.ToTable("tbl_partner");

                entity.HasIndex(e => e.Groupid);

                entity.HasIndex(e => e.PartnerSeq)
                    .HasName("IX_tbl_partner_partnerseq")
                    .IsUnique();

                entity.HasIndex(e => e.Tplcompanyid);

                entity.HasIndex(e => new { e.Groupid, e.Isusing, e.Id })
                    .HasName("IX_tbl_partner_partner_ID_Isusing");

                entity.HasIndex(e => new { e.Id, e.Isusing, e.Groupid })
                    .HasName("IX_tbl_partner_partner_Isusing_groupid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("bigo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BirthIsSolar)
                    .HasColumnName("birth_isSolar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Buseo)
                    .HasColumnName("buseo")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ceoname)
                    .HasColumnName("ceoname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Commission).HasColumnName("commission");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("company_no")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUpjong)
                    .HasColumnName("company_upjong")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUptae)
                    .HasColumnName("company_uptae")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Cposition)
                    .HasColumnName("cposition")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Defaultsongjangdiv).HasColumnName("defaultsongjangdiv");

                entity.Property(e => e.DeliverEmail)
                    .HasColumnName("deliver_email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverHp)
                    .HasColumnName("deliver_hp")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverName)
                    .HasColumnName("deliver_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverPhone)
                    .HasColumnName("deliver_phone")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Discountrate)
                    .HasColumnName("discountrate")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Enc2password64)
                    .HasColumnName("Enc_2password64")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EncPassword)
                    .HasColumnName("Enc_password")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EncPassword64)
                    .HasColumnName("Enc_password64")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Etcjungsantype)
                    .HasColumnName("etcjungsantype")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Frandefaultmargin)
                    .HasColumnName("frandefaultmargin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Franjungsangubun)
                    .HasColumnName("franjungsangubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Intro)
                    .HasColumnName("intro")
                    .HasColumnType("text");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.JobSn).HasColumnName("job_sn");

                entity.Property(e => e.JungsanAcctname)
                    .HasColumnName("jungsan_acctname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanAcctno)
                    .HasColumnName("jungsan_acctno")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanBank)
                    .HasColumnName("jungsan_bank")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanDate)
                    .HasColumnName("jungsan_date")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanDateFrn)
                    .HasColumnName("jungsan_date_frn")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanDateOff)
                    .HasColumnName("jungsan_date_off")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanEmail)
                    .HasColumnName("jungsan_email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanGubun)
                    .HasColumnName("jungsan_gubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanHp)
                    .HasColumnName("jungsan_hp")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanName)
                    .HasColumnName("jungsan_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanPhone)
                    .HasColumnName("jungsan_phone")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastExpireDt)
                    .HasColumnName("lastExpireDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastInfoChgDt)
                    .HasColumnName("lastInfoChgDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastLoginDt)
                    .HasColumnName("lastLoginDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastPwChgDt)
                    .HasColumnName("lastPwChgDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastadminid)
                    .HasColumnName("lastadminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastip)
                    .HasColumnName("lastip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LevelSn)
                    .HasColumnName("level_sn")
                    .HasDefaultValueSql("((9999))");

                entity.Property(e => e.MMargin)
                    .HasColumnName("M_margin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ManagerAddress)
                    .HasColumnName("manager_address")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerHp)
                    .HasColumnName("manager_hp")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerName)
                    .HasColumnName("manager_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerPhone)
                    .HasColumnName("manager_phone")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Msn)
                    .HasColumnName("msn")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Offcatecode)
                    .HasColumnName("offcatecode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Offlinedefaultmargin)
                    .HasColumnName("offlinedefaultmargin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Offlinejungsangubun)
                    .HasColumnName("offlinejungsangubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Offmduserid)
                    .HasColumnName("offmduserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Onlinedefaultmargin)
                    .HasColumnName("onlinedefaultmargin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Onlinemwdiv)
                    .HasColumnName("onlinemwdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Part)
                    .HasColumnName("part")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartSn)
                    .HasColumnName("part_sn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerSeq)
                    .HasColumnName("partnerSeq")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PositSn)
                    .HasColumnName("posit_sn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseType)
                    .HasColumnName("purchaseType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnAddress)
                    .HasColumnName("return_address")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAddress2)
                    .HasColumnName("return_address2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnZipcode)
                    .HasColumnName("return_zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.SellBizCd)
                    .HasColumnName("sellBizCd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SellType).HasColumnName("sellType");

                entity.Property(e => e.Signtype).HasColumnName("signtype");

                entity.Property(e => e.Subid)
                    .HasColumnName("subid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Taxevaltype)
                    .HasColumnName("taxevaltype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Tplcompanyid)
                    .HasColumnName("tplcompanyid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UMargin)
                    .HasColumnName("U_margin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userdiv).HasColumnName("userdiv");

                entity.Property(e => e.Userimg)
                    .HasColumnName("userimg")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WMargin)
                    .HasColumnName("W_margin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerAddDepartment>(entity =>
            {
                entity.HasKey(e => e.Depidx)
                    .HasName("PK__tbl_part__C0947DDD1477CBBE");

                entity.ToTable("tbl_partner_addDepartment");

                entity.Property(e => e.Depidx).HasColumnName("depidx");

                entity.Property(e => e.Departmentid).HasColumnName("departmentid");

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerAddInfo>(entity =>
            {
                entity.HasKey(e => e.Partnerid);

                entity.ToTable("tbl_partner_addInfo");

                entity.Property(e => e.Partnerid)
                    .HasColumnName("partnerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PadminId)
                    .IsRequired()
                    .HasColumnName("padminId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PadminPwd)
                    .IsRequired()
                    .HasColumnName("padminPwd")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PadminUrl)
                    .IsRequired()
                    .HasColumnName("padminUrl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PcomType).HasColumnName("pcomType");

                entity.Property(e => e.PmallSellType).HasColumnName("pmallSellType");
            });

            modelBuilder.Entity<TblPartnerAddJungsanInfo>(entity =>
            {
                entity.HasKey(e => e.Partnerid);

                entity.ToTable("tbl_partner_addJungsanInfo");

                entity.Property(e => e.Partnerid)
                    .HasColumnName("partnerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanAcctname)
                    .IsRequired()
                    .HasColumnName("jungsan_acctname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanAcctno)
                    .IsRequired()
                    .HasColumnName("jungsan_acctno")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanBank)
                    .IsRequired()
                    .HasColumnName("jungsan_bank")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanDate)
                    .IsRequired()
                    .HasColumnName("jungsan_date")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanDateOff)
                    .IsRequired()
                    .HasColumnName("jungsan_date_off")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblPartnerAddLevel>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.PartSn, e.LevelSn });

                entity.ToTable("tbl_partner_AddLevel");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.LevelSn).HasColumnName("level_sn");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("isDefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblPartnerAuthToken>(entity =>
            {
                entity.HasKey(e => e.Groupid)
                    .HasName("PK__tbl_part__88C40F85C0E77597");

                entity.ToTable("tbl_partner_authToken");

                entity.HasIndex(e => e.Token);

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expireDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RegUserId)
                    .IsRequired()
                    .HasColumnName("regUserId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerAuthlog>(entity =>
            {
                entity.HasKey(e => e.Logidx)
                    .HasName("PK__tbl_part__6B78A40BB3D02C09");

                entity.ToTable("tbl_partner_authlog");

                entity.Property(e => e.Logidx).HasColumnName("logidx");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Logmsg)
                    .HasColumnName("logmsg")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Logtype).HasColumnName("logtype");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerAutosms>(entity =>
            {
                entity.HasKey(e => new { e.Makerid, e.SendTime, e.SendKey });

                entity.ToTable("tbl_partner_Autosms");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SendTime)
                    .HasColumnName("sendTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SendKey)
                    .HasColumnName("sendKey")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerCommCode>(entity =>
            {
                entity.HasKey(e => new { e.PcommGroup, e.PcommCd });

                entity.ToTable("tbl_partner_comm_code");

                entity.Property(e => e.PcommGroup)
                    .HasColumnName("pcomm_group")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PcommCd)
                    .HasColumnName("pcomm_cd")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PcommIsusing)
                    .IsRequired()
                    .HasColumnName("pcomm_isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PcommName)
                    .IsRequired()
                    .HasColumnName("pcomm_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcommSortno)
                    .HasColumnName("pcomm_sortno")
                    .HasDefaultValueSql("((999))");
            });

            modelBuilder.Entity<TblPartnerContract>(entity =>
            {
                entity.HasKey(e => e.ContractId);

                entity.ToTable("tbl_partner_contract");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_tbl_partner_contract");

                entity.HasIndex(e => e.Makerid);

                entity.Property(e => e.ContractId).HasColumnName("contractID");

                entity.Property(e => e.Confirmdate)
                    .HasColumnName("confirmdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractContents)
                    .HasColumnName("contractContents")
                    .HasColumnType("text");

                entity.Property(e => e.ContractEtcContetns)
                    .HasColumnName("contractEtcContetns")
                    .HasColumnType("text");

                entity.Property(e => e.ContractName)
                    .HasColumnName("contractName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNo)
                    .HasColumnName("contractNo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ContractState)
                    .HasColumnName("contractState")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractType).HasColumnName("contractType");

                entity.Property(e => e.Finishdate)
                    .HasColumnName("finishdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerContractDetail>(entity =>
            {
                entity.HasKey(e => new { e.ContractId, e.DetailKey });

                entity.ToTable("tbl_partner_contractDetail");

                entity.Property(e => e.ContractId).HasColumnName("contractID");

                entity.Property(e => e.DetailKey)
                    .HasColumnName("detailKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DetailValue)
                    .HasColumnName("detailValue")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerContractDetailType>(entity =>
            {
                entity.HasKey(e => new { e.ContractType, e.DetailKey });

                entity.ToTable("tbl_partner_contractDetailType");

                entity.Property(e => e.ContractType).HasColumnName("contractType");

                entity.Property(e => e.DetailKey)
                    .HasColumnName("detailKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DetailDesc)
                    .HasColumnName("detailDesc")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasDefaultValueSql("((99))");
            });

            modelBuilder.Entity<TblPartnerContractType>(entity =>
            {
                entity.HasKey(e => e.ContractType);

                entity.ToTable("tbl_partner_contractType");

                entity.Property(e => e.ContractType).HasColumnName("contractType");

                entity.Property(e => e.ContractContents)
                    .HasColumnName("contractContents")
                    .HasColumnType("text");

                entity.Property(e => e.ContractName)
                    .IsRequired()
                    .HasColumnName("contractName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Onoffgubun)
                    .IsRequired()
                    .HasColumnName("onoffgubun")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ON')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubType).HasColumnName("subType");
            });

            modelBuilder.Entity<TblPartnerCtrDetail>(entity =>
            {
                entity.HasKey(e => new { e.CtrKey, e.DetailKey });

                entity.ToTable("tbl_partner_ctr_Detail");

                entity.Property(e => e.CtrKey).HasColumnName("ctrKey");

                entity.Property(e => e.DetailKey)
                    .HasColumnName("detailKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DetailValue)
                    .HasColumnName("detailValue")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerCtrHold>(entity =>
            {
                entity.HasKey(e => new { e.Makerid, e.Onoffgbn })
                    .HasName("PK_dbo.tbl_partner_ctr_Hold");

                entity.ToTable("tbl_partner_ctr_Hold");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Onoffgbn)
                    .HasColumnName("onoffgbn")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Holddate)
                    .HasColumnName("holddate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Holdregid)
                    .IsRequired()
                    .HasColumnName("holdregid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerCtrLgToken>(entity =>
            {
                entity.HasKey(e => e.Tidx)
                    .HasName("PK__tbl_part__E7F7B3F40DC2308E");

                entity.ToTable("tbl_partner_ctrLg_token");

                entity.Property(e => e.Tidx).HasColumnName("tidx");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RefreshToken)
                    .HasColumnName("refresh_token")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblPartnerCtrMaster>(entity =>
            {
                entity.HasKey(e => e.CtrKey)
                    .HasName("PK_tbl_partner_contract_master");

                entity.ToTable("tbl_partner_ctr_master");

                entity.HasIndex(e => e.Groupid);

                entity.HasIndex(e => e.Makerid);

                entity.Property(e => e.CtrKey).HasColumnName("ctrKey");

                entity.Property(e => e.Confirmdate)
                    .HasColumnName("confirmdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractContents)
                    .HasColumnName("contractContents")
                    .HasColumnType("text");

                entity.Property(e => e.ContractType).HasColumnName("contractType");

                entity.Property(e => e.CtrNo)
                    .IsRequired()
                    .HasColumnName("ctrNo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CtrState).HasColumnName("ctrState");

                entity.Property(e => e.Deletedate)
                    .HasColumnName("deletedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcAuser)
                    .HasColumnName("ecAUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EcBuser)
                    .HasColumnName("ecBUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EcctrSeq).HasColumnName("ecctrSeq");

                entity.Property(e => e.Ecupdate)
                    .HasColumnName("ecupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinUserId)
                    .HasColumnName("finUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Finishdate)
                    .HasColumnName("finishdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Groupid)
                    .IsRequired()
                    .HasColumnName("groupid")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RegUserId)
                    .HasColumnName("regUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Renewdate)
                    .HasColumnName("renewdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SendUserId)
                    .HasColumnName("sendUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Senddate)
                    .HasColumnName("senddate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPartnerCtrStateLog>(entity =>
            {
                entity.HasKey(e => e.Ctrlogidx)
                    .HasName("PK__tbl_part__9D3AA5BE30091032");

                entity.ToTable("tbl_partner_ctr_stateLog");

                entity.Property(e => e.Ctrlogidx).HasColumnName("ctrlogidx");

                entity.Property(e => e.Ctrkey).HasColumnName("ctrkey");

                entity.Property(e => e.Logmsg)
                    .HasColumnName("logmsg")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Logtype).HasColumnName("logtype");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regid)
                    .HasColumnName("regid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerCtrSub>(entity =>
            {
                entity.HasKey(e => e.CtrSubKey)
                    .HasName("PK_tbl_partner_contract_Sub");

                entity.ToTable("tbl_partner_ctr_Sub");

                entity.HasIndex(e => e.CtrKey);

                entity.Property(e => e.CtrSubKey).HasColumnName("ctrSubKey");

                entity.Property(e => e.CtrKey).HasColumnName("ctrKey");

                entity.Property(e => e.DefaultDeliverPay)
                    .HasColumnName("defaultDeliverPay")
                    .HasColumnType("money");

                entity.Property(e => e.DefaultDeliveryType)
                    .HasColumnName("defaultDeliveryType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultFreeBeasongLimit)
                    .HasColumnName("defaultFreeBeasongLimit")
                    .HasColumnType("money");

                entity.Property(e => e.Defaultmargin).HasColumnName("defaultmargin");

                entity.Property(e => e.Mwdiv)
                    .IsRequired()
                    .HasColumnName("mwdiv")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Sellplace)
                    .IsRequired()
                    .HasColumnName("sellplace")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerDispcate>(entity =>
            {
                entity.HasKey(e => new { e.Makerid, e.Catecode })
                    .HasName("PK_tbl_partner_category");

                entity.ToTable("tbl_partner_dispcate");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Isdefault)
                    .HasColumnName("isdefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCnt).HasColumnName("itemCnt");
            });

            modelBuilder.Entity<TblPartnerFingersAgreeHist>(entity =>
            {
                entity.HasKey(e => e.AgreeIdx);

                entity.ToTable("tbl_partner_fingers_agreeHist");

                entity.HasIndex(e => e.Groupid);

                entity.HasIndex(e => e.Makerid)
                    .HasName("IX_tbl_partner_fingers_agreeHist_maskerid");

                entity.Property(e => e.AgreeIdx).HasColumnName("agreeIdx");

                entity.Property(e => e.AgreeRefIp)
                    .HasColumnName("agreeRefIP")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Agreedate)
                    .HasColumnName("agreedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractContents).HasColumnType("text");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Deldate)
                    .HasColumnName("deldate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Groupid)
                    .IsRequired()
                    .HasColumnName("groupid")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Viewdate)
                    .HasColumnName("viewdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPartnerGroup>(entity =>
            {
                entity.HasKey(e => e.Groupid);

                entity.ToTable("tbl_partner_group");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ceoname)
                    .HasColumnName("ceoname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress)
                    .HasColumnName("company_address")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress2)
                    .HasColumnName("company_address2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFax)
                    .HasColumnName("company_fax")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("company_no")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTel)
                    .HasColumnName("company_tel")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUpjong)
                    .HasColumnName("company_upjong")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUptae)
                    .HasColumnName("company_uptae")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyZipcode)
                    .HasColumnName("company_zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverEmail)
                    .HasColumnName("deliver_email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverHp)
                    .HasColumnName("deliver_hp")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverName)
                    .HasColumnName("deliver_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverPhone)
                    .HasColumnName("deliver_phone")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EncCompNo)
                    .HasColumnName("encCompNo")
                    .HasMaxLength(512);

                entity.Property(e => e.ErpCustCd)
                    .HasColumnName("erpCust_CD")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ErpUsing)
                    .HasColumnName("erpUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCloseCompany)
                    .HasColumnName("isCloseCompany")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JungsanAcctname)
                    .HasColumnName("jungsan_acctname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanAcctno)
                    .HasColumnName("jungsan_acctno")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanBank)
                    .HasColumnName("jungsan_bank")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanDate)
                    .HasColumnName("jungsan_date")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanDateOff)
                    .HasColumnName("jungsan_date_off")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanEmail)
                    .HasColumnName("jungsan_email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanGubun)
                    .HasColumnName("jungsan_gubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanHp)
                    .HasColumnName("jungsan_hp")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanName)
                    .HasColumnName("jungsan_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanPhone)
                    .HasColumnName("jungsan_phone")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ManagerEmail)
                    .HasColumnName("manager_email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerHp)
                    .HasColumnName("manager_hp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerName)
                    .HasColumnName("manager_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerPhone)
                    .HasColumnName("manager_phone")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnAddress)
                    .HasColumnName("return_address")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAddress2)
                    .HasColumnName("return_address2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnZipcode)
                    .HasColumnName("return_zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerGroupAdddata>(entity =>
            {
                entity.HasKey(e => e.Groupid)
                    .HasName("PK_tbl_partner_group_addInfo");

                entity.ToTable("tbl_partner_group_adddata");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EncCompNo64)
                    .IsRequired()
                    .HasColumnName("encCompNo64")
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<TblPartnerLoginBatchVendorIp>(entity =>
            {
                entity.HasKey(e => e.Refip)
                    .HasName("PK_tbl_partnerLogin_BatchVendorIP");

                entity.ToTable("tbl_partner_login_BatchVendorIP");

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Validdate)
                    .HasColumnName("validdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Vendor)
                    .IsRequired()
                    .HasColumnName("vendor")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerLoginIpAuthed>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Refip });

                entity.ToTable("tbl_partner_loginIP_Authed");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LastAuthdate)
                    .HasColumnName("lastAuthdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblPartnerLoginRejectIp>(entity =>
            {
                entity.HasKey(e => e.Refip);

                entity.ToTable("tbl_partner_login_rejectIP");

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RejectExpDt)
                    .HasColumnName("rejectExpDt")
                    .HasColumnType("datetime");

                entity.Property(e => e.RjtCnt)
                    .HasColumnName("rjtCnt")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblPartnerMenu>(entity =>
            {
                entity.ToTable("tbl_partner_menu");

                entity.HasIndex(e => e.Parentid);

                entity.HasIndex(e => new { e.Id, e.Isusing })
                    .HasName("IX_tbl_partner_menu_IDisUsing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Criticinfo)
                    .HasColumnName("criticinfo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Divcd)
                    .HasColumnName("divcd")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Haschild)
                    .IsRequired()
                    .HasColumnName("haschild")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Linkurl)
                    .HasColumnName("linkurl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Menucolor)
                    .HasColumnName("menucolor")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Menuname)
                    .IsRequired()
                    .HasColumnName("menuname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MenunameEn)
                    .HasColumnName("menuname_En")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Menuposhelp)
                    .HasColumnName("menuposhelp")
                    .HasColumnType("text");

                entity.Property(e => e.Menuposnotice)
                    .HasColumnName("menuposnotice")
                    .HasColumnType("text");

                entity.Property(e => e.Parentid)
                    .HasColumnName("parentid")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SaveLog)
                    .HasColumnName("saveLog")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UseSslYn)
                    .HasColumnName("useSslYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Viewidx)
                    .HasColumnName("viewidx")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblPartnerMenuFavorite>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.MenuId })
                    .HasName("PK__tbl_partner_menu__6EB64F9B");

                entity.ToTable("tbl_partner_menu_favorite");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("useYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblPartnerPenaltyLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_partner_penalty_log");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Deleteyn)
                    .HasColumnName("deleteyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Deluser)
                    .HasColumnName("deluser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Detailcontents)
                    .HasColumnName("detailcontents")
                    .HasColumnType("text");

                entity.Property(e => e.Linkitemid).HasColumnName("linkitemid");

                entity.Property(e => e.Linkorderserial)
                    .HasColumnName("linkorderserial")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Partgubun)
                    .IsRequired()
                    .HasColumnName("partgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Penaltydate)
                    .HasColumnName("penaltydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Penaltygubun)
                    .IsRequired()
                    .HasColumnName("penaltygubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Penaltyname)
                    .IsRequired()
                    .HasColumnName("penaltyname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Penaltyvalue)
                    .HasColumnName("penaltyvalue")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguser)
                    .IsRequired()
                    .HasColumnName("reguser")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerSearchPwdAuthno>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_part__DC501A78CBC16871");

                entity.ToTable("tbl_partner_searchPWD_authno");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Authno)
                    .IsRequired()
                    .HasColumnName("authno")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IsSucess)
                    .IsRequired()
                    .HasColumnName("isSucess")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerSearchPwdLog>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_part__DC501A7862DB94E3");

                entity.ToTable("tbl_partner_searchPWD_log");

                entity.HasIndex(e => e.Refip)
                    .HasName("IX_tbl_partner_searchPWD_log_refIP");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerShopuser>(entity =>
            {
                entity.HasKey(e => new { e.Empno, e.Shopid });

                entity.ToTable("tbl_partner_shopuser");

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Firstisusing)
                    .IsRequired()
                    .HasColumnName("firstisusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblPartnerSignlist>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_partner_signlist");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Defaultmargin)
                    .HasColumnName("defaultmargin")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Document)
                    .HasColumnName("document")
                    .HasColumnType("text");

                entity.Property(e => e.Gubunid)
                    .IsRequired()
                    .HasColumnName("gubunid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Isexpired)
                    .HasColumnName("isexpired")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Jungsandate)
                    .HasColumnName("jungsandate")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Maeipgubun)
                    .HasColumnName("maeipgubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Signdate)
                    .HasColumnName("signdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statecd)
                    .HasColumnName("statecd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerSummaryInfo>(entity =>
            {
                entity.HasKey(e => new { e.Makerid, e.SmKeyName });

                entity.ToTable("tbl_partner_summaryInfo");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SmKeyName)
                    .HasColumnName("smKeyName")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SmKeyValInt)
                    .HasColumnName("smKeyValInt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SmKeyValVar)
                    .HasColumnName("smKeyValVar")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPartnerTempFile>(entity =>
            {
                entity.HasKey(e => e.FileIdx);

                entity.ToTable("tbl_partner_temp_file");

                entity.HasIndex(e => e.Tidx)
                    .HasName("IX_tbl_partner_temp_file");

                entity.Property(e => e.FileIdx).HasColumnName("file_idx");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RealName)
                    .HasColumnName("real_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tidx).HasColumnName("tidx");
            });

            modelBuilder.Entity<TblPartnerTempInfo>(entity =>
            {
                entity.HasKey(e => e.Tidx);

                entity.ToTable("tbl_partner_temp_info");

                entity.HasIndex(e => new { e.Reguserid, e.Groupid, e.CompanyNo })
                    .HasName("IX_tbl_partner_temp_info");

                entity.Property(e => e.Tidx).HasColumnName("tidx");

                entity.Property(e => e.Ceoname)
                    .HasColumnName("ceoname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyAddress)
                    .HasColumnName("company_address")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress2)
                    .HasColumnName("company_address2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyFax)
                    .HasColumnName("company_fax")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("company_no")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTel)
                    .HasColumnName("company_tel")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUpjong)
                    .HasColumnName("company_upjong")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUptae)
                    .HasColumnName("company_uptae")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyZipcode)
                    .HasColumnName("company_zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Confirmuserid)
                    .IsRequired()
                    .HasColumnName("confirmuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EncCompNo)
                    .HasColumnName("encCompNo")
                    .HasMaxLength(512);

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.GroupidOld)
                    .HasColumnName("groupid_old")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Gubun)
                    .IsRequired()
                    .HasColumnName("gubun")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JungsanAcctname)
                    .HasColumnName("jungsan_acctname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanAcctno)
                    .HasColumnName("jungsan_acctno")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanBank)
                    .HasColumnName("jungsan_bank")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanDate)
                    .HasColumnName("jungsan_date")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanDateOff)
                    .HasColumnName("jungsan_date_off")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanEmail)
                    .HasColumnName("jungsan_email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanGubun)
                    .HasColumnName("jungsan_gubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanHp)
                    .HasColumnName("jungsan_hp")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanName)
                    .HasColumnName("jungsan_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanPhone)
                    .HasColumnName("jungsan_phone")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ManagerEmail)
                    .HasColumnName("manager_email")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerHp)
                    .HasColumnName("manager_hp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerName)
                    .HasColumnName("manager_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerPhone)
                    .HasColumnName("manager_phone")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReturnAddress)
                    .HasColumnName("return_address")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAddress2)
                    .HasColumnName("return_address2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnZipcode)
                    .HasColumnName("return_zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblPartnerTempInfoAdddata>(entity =>
            {
                entity.HasKey(e => e.Tidx);

                entity.ToTable("tbl_partner_temp_info_adddata");

                entity.Property(e => e.Tidx)
                    .HasColumnName("tidx")
                    .ValueGeneratedNever();

                entity.Property(e => e.EncCompNo64)
                    .IsRequired()
                    .HasColumnName("encCompNo64")
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<TblPartnerTempMakerid>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_partner_temp_makerid_1");

                entity.ToTable("tbl_partner_temp_makerid");

                entity.HasIndex(e => new { e.Tidx, e.Makerid })
                    .HasName("IX_tbl_partner_temp_makerid");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Tidx).HasColumnName("tidx");
            });

            modelBuilder.Entity<TblPartnerTpl>(entity =>
            {
                entity.HasKey(e => e.Tplcompanyid);

                entity.ToTable("tbl_partner_tpl");

                entity.Property(e => e.Tplcompanyid)
                    .HasColumnName("tplcompanyid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BillUseYn)
                    .HasColumnName("billUseYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BillUserId)
                    .HasColumnName("billUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BillUserPass)
                    .HasColumnName("billUserPass")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Groupid)
                    .IsRequired()
                    .HasColumnName("groupid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tplcompanyname)
                    .IsRequired()
                    .HasColumnName("tplcompanyname")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("useYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblPartpersonCategory>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_dbo.tbl_partperson_category");

                entity.ToTable("tbl_partperson_category");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Category1)
                    .HasColumnName("category1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gubun).HasColumnName("gubun");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPartpersonCategory2>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_partperson_category2");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Category1)
                    .HasColumnName("category1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cidx).HasColumnName("cidx");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sabun)
                    .HasColumnName("sabun")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPhotoBbs>(entity =>
            {
                entity.HasKey(e => e.BbsNo)
                    .HasName("PK__tbl_photo_bbs__7C8480AE");

                entity.ToTable("tbl_photo_bbs");

                entity.Property(e => e.BbsNo).HasColumnName("bbs_no");

                entity.Property(e => e.BbsContent)
                    .IsRequired()
                    .HasColumnName("bbs_content")
                    .HasColumnType("text");

                entity.Property(e => e.BbsHit).HasColumnName("bbs_hit");

                entity.Property(e => e.BbsId)
                    .IsRequired()
                    .HasColumnName("bbs_id")
                    .HasMaxLength(32);

                entity.Property(e => e.BbsRegdate)
                    .HasColumnName("bbs_regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BbsTitle)
                    .IsRequired()
                    .HasColumnName("bbs_title")
                    .HasMaxLength(256);

                entity.Property(e => e.BrdFixed).HasColumnName("brd_fixed");

                entity.Property(e => e.BrdIsusing)
                    .IsRequired()
                    .HasColumnName("brd_isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPhotoCode>(entity =>
            {
                entity.HasKey(e => e.CodeNo)
                    .HasName("PK__tbl_photo_code__22D5121F");

                entity.ToTable("tbl_photo_code");

                entity.Property(e => e.CodeNo).HasColumnName("code_no");

                entity.Property(e => e.CodeName)
                    .IsRequired()
                    .HasColumnName("code_name")
                    .HasMaxLength(60);

                entity.Property(e => e.CodeSort).HasColumnName("code_sort");

                entity.Property(e => e.CodeType)
                    .IsRequired()
                    .HasColumnName("code_type")
                    .HasMaxLength(20);

                entity.Property(e => e.CodeUseyn)
                    .HasColumnName("code_useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeValue).HasColumnName("code_value");
            });

            modelBuilder.Entity<TblPhotoFile>(entity =>
            {
                entity.HasKey(e => e.FileNo)
                    .HasName("PK__tbl_photo_file__276FAA0A");

                entity.ToTable("tbl_photo_file");

                entity.Property(e => e.FileNo).HasColumnName("file_no");

                entity.Property(e => e.BbsNo).HasColumnName("bbs_no");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasMaxLength(500);

                entity.Property(e => e.FileRegdate)
                    .HasColumnName("file_regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RealName)
                    .HasColumnName("real_name")
                    .HasMaxLength(500);

                entity.Property(e => e.ReqNo).HasColumnName("req_no");
            });

            modelBuilder.Entity<TblPhotoOpendata>(entity =>
            {
                entity.HasKey(e => e.Openidx);

                entity.ToTable("tbl_photo_opendata");

                entity.Property(e => e.Openidx).HasColumnName("openidx");

                entity.Property(e => e.Openurl)
                    .HasColumnName("openurl")
                    .HasMaxLength(512);

                entity.Property(e => e.ReqNo).HasColumnName("req_no");
            });

            modelBuilder.Entity<TblPhotoReq>(entity =>
            {
                entity.HasKey(e => e.ReqNo)
                    .HasName("PK__tbl_photo_req__2957F27C");

                entity.ToTable("tbl_photo_req");

                entity.Property(e => e.ReqNo).HasColumnName("req_no");

                entity.Property(e => e.FontColor)
                    .HasColumnName("fontColor")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImportLevel).HasColumnName("import_level");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LoadReq).HasColumnName("load_req");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Mdid)
                    .HasColumnName("MDid")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PrdName)
                    .IsRequired()
                    .HasColumnName("prd_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PrdPrice)
                    .HasColumnName("prd_price")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PrdType)
                    .IsRequired()
                    .HasColumnName("prd_type")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PrdType2).HasColumnName("prd_type2");

                entity.Property(e => e.ReqCategory)
                    .HasColumnName("req_category")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReqCdlDisp).HasColumnName("req_cdl_disp");

                entity.Property(e => e.ReqComment)
                    .HasColumnName("req_comment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDate)
                    .HasColumnName("req_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqDepartment)
                    .HasColumnName("req_department")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReqEtc1)
                    .IsRequired()
                    .HasColumnName("req_etc1")
                    .HasColumnType("text");

                entity.Property(e => e.ReqEtc2)
                    .HasColumnName("req_etc2")
                    .HasColumnType("text");

                entity.Property(e => e.ReqGubun)
                    .IsRequired()
                    .HasColumnName("req_gubun")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReqName)
                    .IsRequired()
                    .HasColumnName("req_name")
                    .HasMaxLength(64);

                entity.Property(e => e.ReqRegdate)
                    .HasColumnName("req_regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqStatus).HasColumnName("req_status");

                entity.Property(e => e.ReqUrl)
                    .HasColumnName("req_url")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReqUse)
                    .IsRequired()
                    .HasColumnName("req_use")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReqUseDetail)
                    .HasColumnName("req_use_detail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("use_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPhotoReqConcept>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_photo_req_concept");

                entity.Property(e => e.ReqNo).HasColumnName("req_no");

                entity.Property(e => e.ReqUseConcept)
                    .HasColumnName("req_use_concept")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPhotoReqUseType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_photo_req_use_type");

                entity.Property(e => e.ReqNo).HasColumnName("req_no");

                entity.Property(e => e.ReqUseType)
                    .HasColumnName("req_use_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPhotoSchedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleNo)
                    .HasName("PK__tbl_photo_schedu__2B403AEE");

                entity.ToTable("tbl_photo_schedule");

                entity.HasIndex(e => e.ReqNo)
                    .HasName("IX_req_no");

                entity.Property(e => e.ScheduleNo).HasColumnName("schedule_no");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReqNo).HasColumnName("req_no");

                entity.Property(e => e.ReqPhoto)
                    .HasColumnName("req_photo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReqStylist)
                    .HasColumnName("req_stylist")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleRegdate)
                    .HasColumnName("schedule_regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<TblPhotoUser>(entity =>
            {
                entity.HasKey(e => e.UserNo)
                    .HasName("PK__tbl_photo_user__2C5E7C59");

                entity.ToTable("tbl_photo_user");

                entity.Property(e => e.UserNo).HasColumnName("user_no");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_ID")
                    .HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(20);

                entity.Property(e => e.UserRegdate)
                    .HasColumnName("user_regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserType).HasColumnName("user_type");

                entity.Property(e => e.UserUseyn)
                    .HasColumnName("user_useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPositInfo>(entity =>
            {
                entity.HasKey(e => e.PositSn)
                    .HasName("PK__tbl_positInfo__756D6ECB");

                entity.ToTable("tbl_positInfo");

                entity.Property(e => e.PositSn).HasColumnName("posit_sn");

                entity.Property(e => e.PositIsDel)
                    .HasColumnName("posit_isDel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PositName)
                    .HasColumnName("posit_name")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRankInfo>(entity =>
            {
                entity.HasKey(e => e.RankSn);

                entity.ToTable("tbl_rankInfo");

                entity.HasIndex(e => e.RankSort)
                    .HasName("IX_tbl_rankInfo");

                entity.Property(e => e.RankSn)
                    .HasColumnName("rank_sn")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankIsDel)
                    .HasColumnName("rank_isDel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RankName)
                    .HasColumnName("rank_name")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.RankSort).HasColumnName("rank_sort");
            });

            modelBuilder.Entity<TblSeminarRoom>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_seminarRoom");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo).HasColumnName("orderNo");

                entity.Property(e => e.Roomname)
                    .IsRequired()
                    .HasColumnName("roomname")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSeminarSchedule>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_seminar_schedule");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.AdminId)
                    .IsRequired()
                    .HasColumnName("adminID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Etc)
                    .HasColumnName("etc")
                    .HasColumnType("text");

                entity.Property(e => e.Groupname)
                    .IsRequired()
                    .HasColumnName("groupname")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lecnum).HasColumnName("lecnum");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Roomidx).HasColumnName("roomidx");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseSu).HasColumnName("useSu");

                entity.Property(e => e.Usepurpose).HasColumnName("usepurpose");

                entity.Property(e => e.Usercell)
                    .HasColumnName("usercell")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTenAgitBooking>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_TenAgit_Book__3F865F66");

                entity.ToTable("tbl_TenAgit_Booking");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AreaDiv).HasDefaultValueSql("((1))");

                entity.Property(e => e.Canceldate)
                    .HasColumnName("canceldate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChkEnd).HasColumnType("datetime");

                entity.Property(e => e.ChkStart).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EtcComment)
                    .HasColumnName("etcComment")
                    .HasColumnType("text");

                entity.Property(e => e.Ipkumdate)
                    .HasColumnName("ipkumdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Isipkum).HasColumnName("isipkum");

                entity.Property(e => e.IsreturnKey).HasColumnName("isreturnKey");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.PositSn).HasColumnName("posit_sn");

                entity.Property(e => e.Refunddate)
                    .HasColumnName("refunddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatDiv)
                    .IsRequired()
                    .HasColumnName("statDiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.UseMoney)
                    .HasColumnName("useMoney")
                    .HasColumnType("money");

                entity.Property(e => e.UsePersonNo).HasColumnName("usePersonNo");

                entity.Property(e => e.UsePoint).HasColumnName("usePoint");

                entity.Property(e => e.UserHp)
                    .HasColumnName("userHP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhone)
                    .HasColumnName("userPhone")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTenAgitPenalty>(entity =>
            {
                entity.HasKey(e => e.Pidx)
                    .HasName("PK__tbl_TenA__40262B0438951F96");

                entity.ToTable("tbl_TenAgit_penalty");

                entity.Property(e => e.Pidx).HasColumnName("pidx");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.PenaltyCause)
                    .HasColumnName("penaltyCause")
                    .HasColumnType("text");

                entity.Property(e => e.PenaltyPoint).HasColumnName("penaltyPoint");

                entity.Property(e => e.Penaltykind).HasColumnName("penaltykind");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTenAgitPoint>(entity =>
            {
                entity.HasKey(e => e.Pidx)
                    .HasName("PK__tbl_TenA__40262B04B40478AD");

                entity.ToTable("tbl_TenAgit_Point");

                entity.Property(e => e.Pidx).HasColumnName("pidx");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Endday)
                    .HasColumnName("endday")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Startday)
                    .HasColumnName("startday")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotPoint).HasColumnName("totPoint");

                entity.Property(e => e.UsePoint).HasColumnName("usePoint");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Yyyy)
                    .HasColumnName("yyyy")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTenAgitSmsInfo>(entity =>
            {
                entity.HasKey(e => e.AreaDiv)
                    .HasName("PK__tbl_TenA__899A5FC99971F1A2");

                entity.ToTable("tbl_TenAgit_smsInfo");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnName("contents");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblTmsBaArapCd>(entity =>
            {
                entity.HasKey(e => e.ArapCd)
                    .HasName("PK_BA_ARAP_CD");

                entity.ToTable("tbl_TMS_BA_ARAP_CD");

                entity.Property(e => e.ArapCd)
                    .HasColumnName("ARAP_CD")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.AccCd)
                    .HasColumnName("ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdRmkSeq)
                    .HasColumnName("ACC_CD_RMK_SEQ")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.AcctUnitCd)
                    .HasColumnName("ACCT_UNIT_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArapAttach)
                    .HasColumnName("ARAP_ATTACH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArapAttachCd)
                    .HasColumnName("ARAP_ATTACH_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCdPrt)
                    .HasColumnName("ARAP_CD_PRT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCdUp)
                    .HasColumnName("ARAP_CD_UP")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.ArapGb)
                    .HasColumnName("ARAP_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArapNm)
                    .HasColumnName("ARAP_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BgtItemCd)
                    .HasColumnName("BGT_ITEM_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CashFlow)
                    .HasColumnName("CASH_FLOW")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpYn)
                    .HasColumnName("GRP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaArapCd2015>(entity =>
            {
                entity.HasKey(e => e.ArapCd)
                    .HasName("PK_TMS_BA_ARAP_CD_2015");

                entity.ToTable("tbl_TMS_BA_ARAP_CD_2015");

                entity.Property(e => e.ArapCd)
                    .HasColumnName("ARAP_CD")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.AccCd)
                    .HasColumnName("ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdOld)
                    .HasColumnName("ACC_CD_OLD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdRmkSeq)
                    .HasColumnName("ACC_CD_RMK_SEQ")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.AcctUnitCd)
                    .HasColumnName("ACCT_UNIT_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArapAttach)
                    .HasColumnName("ARAP_ATTACH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArapAttachCd)
                    .HasColumnName("ARAP_ATTACH_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCdPrt)
                    .HasColumnName("ARAP_CD_PRT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCdUp)
                    .HasColumnName("ARAP_CD_UP")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.ArapGb)
                    .HasColumnName("ARAP_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArapNm)
                    .HasColumnName("ARAP_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArapType)
                    .HasColumnName("ARAP_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BgtItemCd)
                    .HasColumnName("BGT_ITEM_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CashFlow)
                    .HasColumnName("CASH_FLOW")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpYn)
                    .HasColumnName("GRP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaBizsection>(entity =>
            {
                entity.HasKey(e => e.BizsectionCd)
                    .HasName("PK_BA_BIZSECTION");

                entity.ToTable("tbl_TMS_BA_BIZSECTION");

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("BIZSECTION_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.BizNo)
                    .HasColumnName("BIZ_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionCdUp)
                    .HasColumnName("BIZSECTION_CD_UP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionNm)
                    .HasColumnName("BIZSECTION_NM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionUseCd)
                    .HasColumnName("BIZSECTION_USE_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpYn)
                    .HasColumnName("GRP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IsSales).HasColumnName("isSales");

                entity.Property(e => e.IsView).HasColumnName("isView");

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegDatetime)
                    .HasColumnName("REG_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegUser)
                    .HasColumnName("REG_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaBizsection2015>(entity =>
            {
                entity.HasKey(e => e.BizsectionCd);

                entity.ToTable("tbl_TMS_BA_BIZSECTION_2015");

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("BIZSECTION_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.BizNo)
                    .HasColumnName("BIZ_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionCdUp)
                    .HasColumnName("BIZSECTION_CD_UP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionNm)
                    .HasColumnName("BIZSECTION_NM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionUseCd)
                    .HasColumnName("BIZSECTION_USE_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpYn)
                    .HasColumnName("GRP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegDatetime)
                    .HasColumnName("REG_DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegUser)
                    .HasColumnName("REG_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaComCd>(entity =>
            {
                entity.HasKey(e => new { e.GrpCd, e.ComCd });

                entity.ToTable("tbl_TMS_BA_COM_CD");

                entity.Property(e => e.GrpCd)
                    .HasColumnName("GRP_CD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComCd)
                    .HasColumnName("COM_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CdDesc)
                    .HasColumnName("CD_DESC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CdGb1)
                    .HasColumnName("CD_GB1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CdGb2)
                    .HasColumnName("CD_GB2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CdNm)
                    .HasColumnName("CD_NM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CdSysNm)
                    .HasColumnName("CD_SYS_NM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.EngNm)
                    .HasColumnName("ENG_NM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ext1)
                    .HasColumnName("EXT1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ext2)
                    .HasColumnName("EXT2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ext3)
                    .HasColumnName("EXT3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ext4)
                    .HasColumnName("EXT4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ext5)
                    .HasColumnName("EXT5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaComCd2015>(entity =>
            {
                entity.HasKey(e => new { e.GrpCd, e.ComCd });

                entity.ToTable("tbl_TMS_BA_COM_CD_2015");

                entity.Property(e => e.GrpCd)
                    .HasColumnName("GRP_CD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComCd)
                    .HasColumnName("COM_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CdDesc)
                    .HasColumnName("CD_DESC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CdGb1)
                    .HasColumnName("CD_GB1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CdGb2)
                    .HasColumnName("CD_GB2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CdNm)
                    .HasColumnName("CD_NM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CdSysNm)
                    .HasColumnName("CD_SYS_NM")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.EngNm)
                    .HasColumnName("ENG_NM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ext1)
                    .HasColumnName("EXT1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ext2)
                    .HasColumnName("EXT2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ext3)
                    .HasColumnName("EXT3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ext4)
                    .HasColumnName("EXT4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ext5)
                    .HasColumnName("EXT5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaCust>(entity =>
            {
                entity.HasKey(e => e.CustCd);

                entity.ToTable("tbl_TMS_BA_CUST");

                entity.HasIndex(e => e.BizNo);

                entity.Property(e => e.CustCd)
                    .HasColumnName("CUST_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Addr)
                    .HasColumnName("ADDR")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasColumnName("ADDR_2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AddrEng)
                    .HasColumnName("ADDR_ENG")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.BizCd)
                    .HasColumnName("BIZ_CD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BizNo)
                    .HasColumnName("BIZ_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Bscd)
                    .HasColumnName("BSCD")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CeoNm)
                    .HasColumnName("CEO_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ChrCd)
                    .HasColumnName("CHR_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CorpYn)
                    .HasColumnName("CORP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustApYn)
                    .HasColumnName("CUST_AP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustArYn)
                    .HasColumnName("CUST_AR_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustBrnType)
                    .HasColumnName("CUST_BRN_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustEngnm)
                    .HasColumnName("CUST_ENGNM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustNm)
                    .HasColumnName("CUST_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustSnm)
                    .HasColumnName("CUST_SNM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustUseCd)
                    .HasColumnName("CUST_USE_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.DmAddrGb)
                    .HasColumnName("DM_ADDR_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intp)
                    .HasColumnName("INTP")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonSiteGb)
                    .HasColumnName("PERSON_SITE_GB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostCd)
                    .HasColumnName("POST_CD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PostCd2)
                    .HasColumnName("POST_CD_2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrmYn)
                    .HasColumnName("PRM_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RegBizNo)
                    .HasColumnName("REG_BIZ_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAddrGb)
                    .HasColumnName("TAX_ADDR_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TaxType)
                    .HasColumnName("TAX_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TelNo)
                    .HasColumnName("TEL_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VacctYn)
                    .HasColumnName("VACCT_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaCust2015>(entity =>
            {
                entity.HasKey(e => e.CustCd);

                entity.ToTable("tbl_TMS_BA_CUST_2015");

                entity.Property(e => e.CustCd)
                    .HasColumnName("CUST_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCode)
                    .HasColumnName("ACCOUNT_CODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasColumnName("ACCOUNT_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasColumnName("ACCOUNT_TYPE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Addr)
                    .HasColumnName("ADDR")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasColumnName("ADDR_2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AddrEng)
                    .HasColumnName("ADDR_ENG")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.BizCd)
                    .HasColumnName("BIZ_CD")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BizNo)
                    .HasColumnName("BIZ_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Bscd)
                    .HasColumnName("BSCD")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CardCode)
                    .HasColumnName("CARD_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo)
                    .HasColumnName("CARD_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CeoNm)
                    .HasColumnName("CEO_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CeoReg)
                    .HasColumnName("CEO_REG")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ChrCd)
                    .HasColumnName("CHR_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Commission)
                    .HasColumnName("COMMISSION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CorpNo)
                    .HasColumnName("CORP_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CorpYn)
                    .HasColumnName("CORP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrCode)
                    .HasColumnName("CURR_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustApYn)
                    .HasColumnName("CUST_AP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustArYn)
                    .HasColumnName("CUST_AR_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustBrnType)
                    .HasColumnName("CUST_BRN_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustEngnm)
                    .HasColumnName("CUST_ENGNM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustNm)
                    .HasColumnName("CUST_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustSnm)
                    .HasColumnName("CUST_SNM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustType)
                    .HasColumnName("CUST_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustUseCd)
                    .HasColumnName("CUST_USE_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.DmAddrGb)
                    .HasColumnName("DM_ADDR_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EncCeoReg)
                    .HasColumnName("ENC_CEO_REG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasColumnName("FAX_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FinancialCode)
                    .HasColumnName("FINANCIAL_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intp)
                    .HasColumnName("INTP")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.LcEdate)
                    .HasColumnName("LC_EDATE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LcSdate)
                    .HasColumnName("LC_SDATE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OurhomeYn)
                    .HasColumnName("OURHOME_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("PAYMENT_DATE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PersonSiteGb)
                    .HasColumnName("PERSON_SITE_GB")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostCd)
                    .HasColumnName("POST_CD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PostCd2)
                    .HasColumnName("POST_CD_2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrmYn)
                    .HasColumnName("PRM_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RegBizNo)
                    .HasColumnName("REG_BIZ_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Retail)
                    .HasColumnName("RETAIL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNo)
                    .HasColumnName("STORE_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAddrGb)
                    .HasColumnName("TAX_ADDR_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TaxType)
                    .HasColumnName("TAX_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TelNo)
                    .HasColumnName("TEL_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VacctYn)
                    .HasColumnName("VACCT_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Wholesale)
                    .HasColumnName("WHOLESALE")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaCustAcct>(entity =>
            {
                entity.HasKey(e => new { e.CustCd, e.BankCd, e.AcctNo });

                entity.ToTable("tbl_TMS_BA_CUST_ACCT");

                entity.Property(e => e.CustCd)
                    .HasColumnName("CUST_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.BankCd)
                    .HasColumnName("BANK_CD")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AcctNo)
                    .HasColumnName("ACCT_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AcctNickNm)
                    .HasColumnName("ACCT_NICK_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArapType)
                    .IsRequired()
                    .HasColumnName("ARAP_TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CmsCd)
                    .HasColumnName("CMS_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustType)
                    .HasColumnName("CUST_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DefAcctYn)
                    .HasColumnName("DEF_ACCT_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefSavDt)
                    .HasColumnName("REF_SAV_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RefSavNm)
                    .HasColumnName("REF_SAV_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDt)
                    .HasColumnName("REQ_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ReqId)
                    .HasColumnName("REQ_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SanDt)
                    .HasColumnName("SAN_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SanId)
                    .HasColumnName("SAN_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SanYn)
                    .HasColumnName("SAN_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SavMn)
                    .HasColumnName("SAV_MN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VacctYn)
                    .HasColumnName("VACCT_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaCustAcct2015>(entity =>
            {
                entity.HasKey(e => new { e.CustCd, e.BankCd, e.AcctNo });

                entity.ToTable("tbl_TMS_BA_CUST_ACCT_2015");

                entity.Property(e => e.CustCd)
                    .HasColumnName("CUST_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.BankCd)
                    .HasColumnName("BANK_CD")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AcctNo)
                    .HasColumnName("ACCT_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AcctNickNm)
                    .HasColumnName("ACCT_NICK_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArapType)
                    .IsRequired()
                    .HasColumnName("ARAP_TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CmsCd)
                    .HasColumnName("CMS_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustType)
                    .HasColumnName("CUST_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DefAcctYn)
                    .HasColumnName("DEF_ACCT_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecNo)
                    .HasColumnName("REC_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefSavDt)
                    .HasColumnName("REF_SAV_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.RefSavNm)
                    .HasColumnName("REF_SAV_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDt)
                    .HasColumnName("REQ_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ReqId)
                    .HasColumnName("REQ_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SanDt)
                    .HasColumnName("SAN_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SanId)
                    .HasColumnName("SAN_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SanYn)
                    .HasColumnName("SAN_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SavMn)
                    .HasColumnName("SAV_MN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VacctYn)
                    .HasColumnName("VACCT_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaCustSaleor>(entity =>
            {
                entity.HasKey(e => new { e.CustCd, e.EmpNo });

                entity.ToTable("tbl_TMS_BA_CUST_SALEOR");

                entity.Property(e => e.CustCd)
                    .HasColumnName("CUST_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasColumnName("EMP_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DeptNm)
                    .HasColumnName("DEPT_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNm)
                    .HasColumnName("EMP_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HpNo)
                    .HasColumnName("HP_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pos)
                    .HasColumnName("POS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentSaleorYn)
                    .HasColumnName("REPRESENT_SALEOR_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TelNo)
                    .HasColumnName("TEL_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaCustSaleor2015>(entity =>
            {
                entity.HasKey(e => new { e.CustCd, e.EmpNo });

                entity.ToTable("tbl_TMS_BA_CUST_SALEOR_2015");

                entity.Property(e => e.CustCd)
                    .HasColumnName("CUST_CD")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasColumnName("EMP_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DeptNm)
                    .HasColumnName("DEPT_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DirectTelNo)
                    .HasColumnName("DIRECT_TEL_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNm)
                    .HasColumnName("EMP_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HpNo)
                    .HasColumnName("HP_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MsgId)
                    .HasColumnName("MSG_ID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pos)
                    .HasColumnName("POS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivePs)
                    .HasColumnName("RECEIVE_PS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RepresentSaleorYn)
                    .HasColumnName("REPRESENT_SALEOR_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TelNo)
                    .HasColumnName("TEL_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaProd>(entity =>
            {
                entity.HasKey(e => e.ProdCd)
                    .HasName("PK_BA_PROD");

                entity.ToTable("tbl_TMS_BA_PROD");

                entity.Property(e => e.ProdCd)
                    .HasColumnName("PROD_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccCd)
                    .HasColumnName("ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdRmkSeq)
                    .HasColumnName("ACC_CD_RMK_SEQ")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCd)
                    .HasColumnName("ARAP_CD")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.ArapGb)
                    .HasColumnName("ARAP_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArapSeq)
                    .HasColumnName("ARAP_SEQ")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpYn)
                    .HasColumnName("GRP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdCdUp)
                    .HasColumnName("PROD_CD_UP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdNm)
                    .HasColumnName("PROD_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProdType)
                    .HasColumnName("PROD_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VsAccCd)
                    .HasColumnName("VS_ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsBaProd2015>(entity =>
            {
                entity.HasKey(e => e.ProdCd);

                entity.ToTable("tbl_TMS_BA_PROD_2015");

                entity.Property(e => e.ProdCd)
                    .HasColumnName("PROD_CD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccCd)
                    .HasColumnName("ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdOld)
                    .HasColumnName("ACC_CD_OLD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdRmkSeq)
                    .HasColumnName("ACC_CD_RMK_SEQ")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ArapCd)
                    .HasColumnName("ARAP_CD")
                    .HasColumnType("decimal(13, 0)");

                entity.Property(e => e.ArapGb)
                    .HasColumnName("ARAP_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ArapSeq)
                    .HasColumnName("ARAP_SEQ")
                    .HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Bigo)
                    .HasColumnName("BIGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpYn)
                    .HasColumnName("GRP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdCdUp)
                    .HasColumnName("PROD_CD_UP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProdNm)
                    .HasColumnName("PROD_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProdType)
                    .HasColumnName("PROD_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VsAccCd)
                    .HasColumnName("VS_ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsSlAccCd>(entity =>
            {
                entity.HasKey(e => new { e.AccCd, e.AccountSection })
                    .HasName("PK_SL_ACC_CD");

                entity.ToTable("tbl_TMS_SL_ACC_CD");

                entity.Property(e => e.AccCd)
                    .HasColumnName("ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSection)
                    .HasColumnName("ACCOUNT_SECTION")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.AccCdKgaap)
                    .HasColumnName("ACC_CD_KGAAP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdRef)
                    .HasColumnName("ACC_CD_REF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdUp)
                    .HasColumnName("ACC_CD_UP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccGrpCd)
                    .HasColumnName("ACC_GRP_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccNm)
                    .IsRequired()
                    .HasColumnName("ACC_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccScd)
                    .HasColumnName("ACC_SCD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccSubGubun)
                    .HasColumnName("ACC_SUB_GUBUN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccUseCd)
                    .IsRequired()
                    .HasColumnName("ACC_USE_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultChdYn)
                    .HasColumnName("DEFAULT_CHD_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DevYn)
                    .HasColumnName("DEV_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpYn)
                    .HasColumnName("GRP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IfrsCd)
                    .HasColumnName("IFRS_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RefYn)
                    .HasColumnName("REF_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SideGb)
                    .HasColumnName("SIDE_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UseArap)
                    .HasColumnName("USE_ARAP")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UseBizsession)
                    .HasColumnName("USE_BIZSESSION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseChr)
                    .HasColumnName("USE_CHR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseCust)
                    .HasColumnName("USE_CUST")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UseDept)
                    .HasColumnName("USE_DEPT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseProd)
                    .HasColumnName("USE_PROD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseSlipRmk)
                    .HasColumnName("USE_SLIP_RMK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsSlAccCd2015>(entity =>
            {
                entity.HasKey(e => new { e.BaseYear, e.AccCd });

                entity.ToTable("tbl_TMS_SL_ACC_CD_2015");

                entity.Property(e => e.BaseYear)
                    .HasColumnName("BASE_YEAR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AccCd)
                    .HasColumnName("ACC_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdGroup)
                    .HasColumnName("ACC_CD_GROUP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdKgaap)
                    .HasColumnName("ACC_CD_KGAAP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdRef)
                    .HasColumnName("ACC_CD_REF")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdRef2)
                    .HasColumnName("ACC_CD_REF2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdType)
                    .HasColumnName("ACC_CD_TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccCdUp)
                    .HasColumnName("ACC_CD_UP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccEnm)
                    .HasColumnName("ACC_ENM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccGrpCd)
                    .HasColumnName("ACC_GRP_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccNm)
                    .IsRequired()
                    .HasColumnName("ACC_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccScd)
                    .HasColumnName("ACC_SCD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccSubGubun)
                    .HasColumnName("ACC_SUB_GUBUN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AccUseCd)
                    .IsRequired()
                    .HasColumnName("ACC_USE_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSection)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_SECTION")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.AddsubUseYn)
                    .HasColumnName("ADDSUB_USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultChdYn)
                    .HasColumnName("DEFAULT_CHD_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DevYn)
                    .HasColumnName("DEV_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.ErpCd)
                    .HasColumnName("ERP_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd1)
                    .HasColumnName("GBCD_1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd2)
                    .HasColumnName("GBCD_2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd3)
                    .HasColumnName("GBCD_3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gbcd4)
                    .HasColumnName("GBCD_4")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrpYn)
                    .HasColumnName("GRP_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IfrsCd)
                    .HasColumnName("IFRS_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InType)
                    .HasColumnName("IN_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ModUser)
                    .HasColumnName("MOD_USER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrFrCd)
                    .HasColumnName("PR_FR_CD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RedeemWith1)
                    .HasColumnName("REDEEM_WITH1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RedeemWith2)
                    .HasColumnName("REDEEM_WITH2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RedeemYn)
                    .HasColumnName("REDEEM_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RefYn)
                    .HasColumnName("REF_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ReqBizYn)
                    .HasColumnName("REQ_BIZ_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReqCustYn)
                    .HasColumnName("REQ_CUST_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReqDeptYn)
                    .HasColumnName("REQ_DEPT_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReqEmpYn)
                    .HasColumnName("REQ_EMP_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SideGb)
                    .HasColumnName("SIDE_GB")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StatementWriteYn)
                    .HasColumnName("STATEMENT_WRITE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StdFrCd)
                    .HasColumnName("STD_FR_CD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Subtype)
                    .HasColumnName("SUBTYPE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UseArap)
                    .HasColumnName("USE_ARAP")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UseBizsession)
                    .HasColumnName("USE_BIZSESSION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseChr)
                    .HasColumnName("USE_CHR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseCust)
                    .HasColumnName("USE_CUST")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UseDept)
                    .HasColumnName("USE_DEPT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseProd)
                    .HasColumnName("USE_PROD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UseSlipRmk)
                    .HasColumnName("USE_SLIP_RMK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsSlAccCdGrp>(entity =>
            {
                entity.HasKey(e => new { e.AccGrpCd, e.AccountSection })
                    .HasName("PK_SL_ACC_CD_GRP");

                entity.ToTable("tbl_TMS_SL_ACC_CD_GRP");

                entity.Property(e => e.AccGrpCd)
                    .HasColumnName("ACC_GRP_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSection)
                    .HasColumnName("ACCOUNT_SECTION")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.AccFcls)
                    .IsRequired()
                    .HasColumnName("ACC_FCLS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccGrpNm)
                    .IsRequired()
                    .HasColumnName("ACC_GRP_NM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BeginCd)
                    .HasColumnName("BEGIN_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.EndCd)
                    .HasColumnName("END_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTmsSlAccCdGrp2015>(entity =>
            {
                entity.HasKey(e => new { e.AccGrpCd, e.AccountSection })
                    .HasName("PK_tbl_iTMS_SL_ACC_CD_GRP");

                entity.ToTable("tbl_TMS_SL_ACC_CD_GRP_2015");

                entity.Property(e => e.AccGrpCd)
                    .HasColumnName("ACC_GRP_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccountSection)
                    .HasColumnName("ACCOUNT_SECTION")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.AccFcls)
                    .IsRequired()
                    .HasColumnName("ACC_FCLS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AccGrpNm)
                    .IsRequired()
                    .HasColumnName("ACC_GRP_NM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BeginCd)
                    .HasColumnName("BEGIN_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BitchkDt)
                    .HasColumnName("BITCHK_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelYn)
                    .HasColumnName("DEL_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DisAccGrpNm)
                    .HasColumnName("DIS_ACC_GRP_NM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DispSeq)
                    .HasColumnName("DISP_SEQ")
                    .HasColumnType("decimal(5, 0)");

                entity.Property(e => e.EndCd)
                    .HasColumnName("END_CD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GrpLvl)
                    .HasColumnName("GRP_LVL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KindGrpCd)
                    .HasColumnName("KIND_GRP_CD")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpGrpCd)
                    .HasColumnName("UP_GRP_CD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .HasColumnName("USE_YN")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserBizsection>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_user_Bizsect__3BA0BFE9");

                entity.ToTable("tbl_user_Bizsection");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionCd)
                    .IsRequired()
                    .HasColumnName("bizsection_cd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BizsectionUseCd)
                    .HasColumnName("bizsection_use_cd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Persent).HasColumnName("persent");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Yyyymm)
                    .IsRequired()
                    .HasColumnName("yyyymm")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserBizsectionAvg>(entity =>
            {
                entity.HasKey(e => e.AvgIdx)
                    .HasName("PK__tbl_user_bizsect__1570F560");

                entity.ToTable("tbl_user_bizsection_avg");

                entity.Property(e => e.AvgIdx).HasColumnName("avgIdx");

                entity.Property(e => e.AvgPersent).HasColumnName("avgPersent");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupBizCd)
                    .IsRequired()
                    .HasColumnName("supBizCD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserBizCd)
                    .IsRequired()
                    .HasColumnName("userBizCD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Yyyymm)
                    .IsRequired()
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserDailypay>(entity =>
            {
                entity.HasKey(e => e.Payidx);

                entity.ToTable("tbl_user_dailypay");

                entity.HasIndex(e => e.Empno)
                    .HasName("IX_tbl_user_dailypay");

                entity.HasIndex(e => e.Procyyyymm)
                    .HasName("IX_tbl_user_dailypay_2");

                entity.HasIndex(e => e.Yyyymmdd)
                    .HasName("IX_tbl_user_dailypay_1");

                entity.Property(e => e.Payidx).HasColumnName("payidx");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BreaktimeE).HasColumnName("breaktimeE");

                entity.Property(e => e.BreaktimeS).HasColumnName("breaktimeS");

                entity.Property(e => e.Defaulttime)
                    .HasColumnName("defaulttime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Endwork).HasColumnName("endwork");

                entity.Property(e => e.Extendtime)
                    .HasColumnName("extendtime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Holidaytime)
                    .HasColumnName("holidaytime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nighttime)
                    .HasColumnName("nighttime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Outtime).HasColumnName("outtime");

                entity.Property(e => e.Paystate).HasColumnName("paystate");

                entity.Property(e => e.Procyyyymm)
                    .HasColumnName("procyyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Startwork).HasColumnName("startwork");

                entity.Property(e => e.Vacationtime)
                    .HasColumnName("vacationtime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wholidaytime)
                    .HasColumnName("wholidaytime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkType)
                    .HasColumnName("workType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Yyyymmdd)
                    .IsRequired()
                    .HasColumnName("yyyymmdd")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUserDefaultpay>(entity =>
            {
                entity.HasKey(e => e.Defaultpayseq)
                    .HasName("PK__tbl_user_default__4CF5691D");

                entity.ToTable("tbl_user_defaultpay");

                entity.Property(e => e.Defaultpayseq).HasColumnName("defaultpayseq");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Defaultpay)
                    .HasColumnName("defaultpay")
                    .HasColumnType("money");

                entity.Property(e => e.DepartmentFullName)
                    .HasColumnName("departmentFullName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Foodpay)
                    .HasColumnName("foodpay")
                    .HasColumnType("money");

                entity.Property(e => e.FriBreakE).HasColumnName("friBreakE");

                entity.Property(e => e.FriBreakS).HasColumnName("friBreakS");

                entity.Property(e => e.FriEnd).HasColumnName("friEnd");

                entity.Property(e => e.FriStart).HasColumnName("friStart");

                entity.Property(e => e.FriWorkType).HasColumnName("friWorkType");

                entity.Property(e => e.Holidaywd).HasColumnName("holidaywd");

                entity.Property(e => e.Holidaywdtime)
                    .HasColumnName("holidaywdtime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InBreakTime).HasColumnName("inBreakTime");

                entity.Property(e => e.Ino)
                    .HasColumnName("ino")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Jobkind).HasColumnName("jobkind");

                entity.Property(e => e.Jobpay)
                    .HasColumnName("jobpay")
                    .HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MonBreakE).HasColumnName("monBreakE");

                entity.Property(e => e.MonBreakS).HasColumnName("monBreakS");

                entity.Property(e => e.MonEnd).HasColumnName("monEnd");

                entity.Property(e => e.MonStart).HasColumnName("monStart");

                entity.Property(e => e.MonWorkType).HasColumnName("monWorkType");

                entity.Property(e => e.Placekind).HasColumnName("placekind");

                entity.Property(e => e.PositName)
                    .HasColumnName("posit_name")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PositSn).HasColumnName("posit_sn");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SatBreakE).HasColumnName("satBreakE");

                entity.Property(e => e.SatBreakS).HasColumnName("satBreakS");

                entity.Property(e => e.SatEnd).HasColumnName("satEnd");

                entity.Property(e => e.SatStart).HasColumnName("satStart");

                entity.Property(e => e.SatWorkType).HasColumnName("satWorkType");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SunBreakE).HasColumnName("sunBreakE");

                entity.Property(e => e.SunBreakS).HasColumnName("sunBreakS");

                entity.Property(e => e.SunEnd).HasColumnName("sunEnd");

                entity.Property(e => e.SunStart).HasColumnName("sunStart");

                entity.Property(e => e.SunWorkType).HasColumnName("sunWorkType");

                entity.Property(e => e.ThuBreakE).HasColumnName("thuBreakE");

                entity.Property(e => e.ThuBreakS).HasColumnName("thuBreakS");

                entity.Property(e => e.ThuEnd).HasColumnName("thuEnd");

                entity.Property(e => e.ThuStart).HasColumnName("thuStart");

                entity.Property(e => e.ThuWorkType).HasColumnName("thuWorkType");

                entity.Property(e => e.TotPaySum)
                    .HasColumnName("totPaySum")
                    .HasColumnType("money");

                entity.Property(e => e.TueBreakE).HasColumnName("tueBreakE");

                entity.Property(e => e.TueBreakS).HasColumnName("tueBreakS");

                entity.Property(e => e.TueEnd).HasColumnName("tueEnd");

                entity.Property(e => e.TueStart).HasColumnName("tueStart");

                entity.Property(e => e.TueWorkType).HasColumnName("tueWorkType");

                entity.Property(e => e.WedBreakE).HasColumnName("wedBreakE");

                entity.Property(e => e.WedBreakS).HasColumnName("wedBreakS");

                entity.Property(e => e.WedEnd).HasColumnName("wedEnd");

                entity.Property(e => e.WedStart).HasColumnName("wedStart");

                entity.Property(e => e.WedWorkType).HasColumnName("wedWorkType");
            });

            modelBuilder.Entity<TblUserDefaultpayPattern>(entity =>
            {
                entity.HasKey(e => e.PatternSeq)
                    .HasName("PK__tbl_user_default__705EA0EB");

                entity.ToTable("tbl_user_defaultpay_Pattern");

                entity.Property(e => e.PatternSeq).HasColumnName("patternSeq");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Defaultpay)
                    .HasColumnName("defaultpay")
                    .HasColumnType("money");

                entity.Property(e => e.Foodpay)
                    .HasColumnName("foodpay")
                    .HasColumnType("money");

                entity.Property(e => e.FriBreakE).HasColumnName("friBreakE");

                entity.Property(e => e.FriBreakS).HasColumnName("friBreakS");

                entity.Property(e => e.FriEnd).HasColumnName("friEnd");

                entity.Property(e => e.FriStart).HasColumnName("friStart");

                entity.Property(e => e.FriWorkType).HasColumnName("friWorkType");

                entity.Property(e => e.Holidaywd).HasColumnName("holidaywd");

                entity.Property(e => e.Holidaywdtime)
                    .HasColumnName("holidaywdtime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InBreakTime).HasColumnName("inBreakTime");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Jobpay)
                    .HasColumnName("jobpay")
                    .HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MonBreakE).HasColumnName("monBreakE");

                entity.Property(e => e.MonBreakS).HasColumnName("monBreakS");

                entity.Property(e => e.MonEnd).HasColumnName("monEnd");

                entity.Property(e => e.MonStart).HasColumnName("monStart");

                entity.Property(e => e.MonWorkType).HasColumnName("monWorkType");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.PatternName)
                    .IsRequired()
                    .HasColumnName("patternName")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SatBreakE)
                    .HasColumnName("satBreakE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SatBreakS)
                    .HasColumnName("satBreakS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SatEnd).HasColumnName("satEnd");

                entity.Property(e => e.SatStart).HasColumnName("satStart");

                entity.Property(e => e.SatWorkType).HasColumnName("satWorkType");

                entity.Property(e => e.SunBreakE).HasColumnName("sunBreakE");

                entity.Property(e => e.SunBreakS).HasColumnName("sunBreakS");

                entity.Property(e => e.SunEnd).HasColumnName("sunEnd");

                entity.Property(e => e.SunStart).HasColumnName("sunStart");

                entity.Property(e => e.SunWorkType).HasColumnName("sunWorkType");

                entity.Property(e => e.ThuBreakE).HasColumnName("thuBreakE");

                entity.Property(e => e.ThuBreakS).HasColumnName("thuBreakS");

                entity.Property(e => e.ThuEnd).HasColumnName("thuEnd");

                entity.Property(e => e.ThuStart).HasColumnName("thuStart");

                entity.Property(e => e.ThuWorkType).HasColumnName("thuWorkType");

                entity.Property(e => e.TotPaySum)
                    .HasColumnName("totPaySum")
                    .HasColumnType("money");

                entity.Property(e => e.TueBreakE).HasColumnName("tueBreakE");

                entity.Property(e => e.TueBreakS).HasColumnName("tueBreakS");

                entity.Property(e => e.TueEnd).HasColumnName("tueEnd");

                entity.Property(e => e.TueStart).HasColumnName("tueStart");

                entity.Property(e => e.TueWorkType).HasColumnName("tueWorkType");

                entity.Property(e => e.WedBreakE).HasColumnName("wedBreakE");

                entity.Property(e => e.WedBreakS).HasColumnName("wedBreakS");

                entity.Property(e => e.WedEnd).HasColumnName("wedEnd");

                entity.Property(e => e.WedStart).HasColumnName("wedStart");

                entity.Property(e => e.WedWorkType).HasColumnName("wedWorkType");
            });

            modelBuilder.Entity<TblUserDepartment>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("tbl_user_department");

                entity.HasIndex(e => e.Pid);

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("departmentName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DispOrderNo)
                    .HasColumnName("dispOrderNo")
                    .HasDefaultValueSql("((10000))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UseYn)
                    .HasColumnName("useYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblUserInouttimeLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_user_inouttime_log");

                entity.HasIndex(e => e.Empno);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InoutTime)
                    .HasColumnName("inoutTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.InoutType)
                    .HasColumnName("inoutType")
                    .HasComment("1(출근) 2(퇴근) 3(외출)  4(복귀)");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Lasteditupdate)
                    .HasColumnName("lasteditupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastedituserid)
                    .HasColumnName("lastedituserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Placeid).HasColumnName("placeid");

                entity.Property(e => e.PosDate)
                    .HasColumnName("posDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosIdx).HasColumnName("posIdx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Yyyymmdd)
                    .IsRequired()
                    .HasColumnName("YYYYMMDD")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserInouttimePlace>(entity =>
            {
                entity.HasKey(e => e.Placeid)
                    .HasName("PK_tbl_user_inouttime_pos");

                entity.ToTable("tbl_user_inouttime_place");

                entity.Property(e => e.Placeid)
                    .HasColumnName("placeid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Placeiname)
                    .IsRequired()
                    .HasColumnName("placeiname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Validpart).HasColumnName("validpart");
            });

            modelBuilder.Entity<TblUserLoginIp>(entity =>
            {
                entity.HasKey(e => e.Ipaddress);

                entity.ToTable("tbl_user_loginIP");

                entity.HasIndex(e => e.Idx)
                    .IsUnique();

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("ipaddress")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Managername)
                    .HasColumnName("managername")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Modiuserid)
                    .HasColumnName("modiuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Usecustomerinfoyn)
                    .IsRequired()
                    .HasColumnName("usecustomerinfoyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Uselogicsyn)
                    .IsRequired()
                    .HasColumnName("uselogicsyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Usescmyn)
                    .IsRequired()
                    .HasColumnName("usescmyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblUserMonthlypay>(entity =>
            {
                entity.HasKey(e => new { e.Empno, e.Yyyymm, e.Ino })
                    .HasName("PK__tbl_user_monthly__3CBF0154");

                entity.ToTable("tbl_user_monthlypay");

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ino)
                    .HasColumnName("ino")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Addpay)
                    .HasColumnName("addpay")
                    .HasColumnType("money");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Bonuspay)
                    .HasColumnName("bonuspay")
                    .HasColumnType("money");

                entity.Property(e => e.Extendpay)
                    .HasColumnName("extendpay")
                    .HasColumnType("money");

                entity.Property(e => e.Extendtime).HasColumnName("extendtime");

                entity.Property(e => e.Foodpay)
                    .HasColumnName("foodpay")
                    .HasColumnType("money");

                entity.Property(e => e.Foodtime).HasColumnName("foodtime");

                entity.Property(e => e.Healthinspay)
                    .HasColumnName("healthinspay")
                    .HasColumnType("money");

                entity.Property(e => e.Holidaypay)
                    .HasColumnName("holidaypay")
                    .HasColumnType("money");

                entity.Property(e => e.Holidaytime).HasColumnName("holidaytime");

                entity.Property(e => e.Jobpay)
                    .HasColumnName("jobpay")
                    .HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Longtimepay)
                    .HasColumnName("longtimepay")
                    .HasColumnType("money");

                entity.Property(e => e.Nightpay)
                    .HasColumnName("nightpay")
                    .HasColumnType("money");

                entity.Property(e => e.Nighttime).HasColumnName("nighttime");

                entity.Property(e => e.Npensionpay)
                    .HasColumnName("npensionpay")
                    .HasColumnType("money");

                entity.Property(e => e.Outstandingpay)
                    .HasColumnName("outstandingpay")
                    .HasColumnType("money");

                entity.Property(e => e.Paystate).HasColumnName("paystate");

                entity.Property(e => e.Realtotpay)
                    .HasColumnName("realtotpay")
                    .HasColumnType("money");

                entity.Property(e => e.Recalexpay)
                    .HasColumnName("recalexpay")
                    .HasColumnType("money");

                entity.Property(e => e.Recalexttime).HasColumnName("recalexttime");

                entity.Property(e => e.Recalfpay)
                    .HasColumnName("recalfpay")
                    .HasColumnType("money");

                entity.Property(e => e.Recalftime).HasColumnName("recalftime");

                entity.Property(e => e.Recalhdpay)
                    .HasColumnName("recalhdpay")
                    .HasColumnType("money");

                entity.Property(e => e.Recalhdtime).HasColumnName("recalhdtime");

                entity.Property(e => e.Recalntpay)
                    .HasColumnName("recalntpay")
                    .HasColumnType("money");

                entity.Property(e => e.Recalnttime).HasColumnName("recalnttime");

                entity.Property(e => e.Recalpay)
                    .HasColumnName("recalpay")
                    .HasColumnType("money");

                entity.Property(e => e.Recaltime).HasColumnName("recaltime");

                entity.Property(e => e.Recaltotpay)
                    .HasColumnName("recaltotpay")
                    .HasColumnType("money");

                entity.Property(e => e.Recalworkday).HasColumnName("recalworkday");

                entity.Property(e => e.Recuinspay)
                    .HasColumnName("recuinspay")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Taxtotpay)
                    .HasColumnName("taxtotpay")
                    .HasColumnType("money");

                entity.Property(e => e.Timepay)
                    .HasColumnName("timepay")
                    .HasColumnType("money");

                entity.Property(e => e.Totpay)
                    .HasColumnName("totpay")
                    .HasColumnType("money");

                entity.Property(e => e.Unempinspay)
                    .HasColumnName("unempinspay")
                    .HasColumnType("money");

                entity.Property(e => e.Wholidaytime).HasColumnName("wholidaytime");

                entity.Property(e => e.Workday)
                    .HasColumnName("workday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Worktime).HasColumnName("worktime");

                entity.Property(e => e.Yearpay)
                    .HasColumnName("yearpay")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblUserTenbyten>(entity =>
            {
                entity.HasKey(e => e.Empno);

                entity.ToTable("tbl_user_tenbyten");

                entity.HasIndex(e => e.Username)
                    .HasName("IX_tbl_user_tenbyten");

                entity.HasIndex(e => new { e.DepartmentId, e.Statediv, e.Isusing, e.Userid })
                    .HasName("IX_tbl_user_tenbyten_statediv_isusing_userid_INC_department_id");

                entity.HasIndex(e => new { e.Username, e.JobSn, e.PartSn, e.Userid })
                    .HasName("IX_tbl_user_tenbyten_userid");

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.BizsectionCd)
                    .HasColumnName("bizsection_Cd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Criticinfouser)
                    .HasColumnName("criticinfouser")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Direct070)
                    .HasColumnName("direct070")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Emppass)
                    .HasColumnName("emppass")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EncEmppass)
                    .HasColumnName("Enc_emppass")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Frontid)
                    .HasColumnName("frontid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Interphoneno)
                    .HasColumnName("interphoneno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IsIdentify)
                    .IsRequired()
                    .HasColumnName("isIdentify")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Issolar)
                    .HasColumnName("issolar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobSn).HasColumnName("job_sn");

                entity.Property(e => e.Jobdetail)
                    .HasColumnName("jobdetail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Joinday)
                    .HasColumnName("joinday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Juminno)
                    .HasColumnName("juminno")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Messenger)
                    .HasColumnName("messenger")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Msnmail)
                    .HasColumnName("msnmail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Mywork)
                    .HasColumnName("mywork")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.Personalmail)
                    .HasColumnName("personalmail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.PositSn).HasColumnName("posit_sn");

                entity.Property(e => e.RankSn).HasColumnName("rank_sn");

                entity.Property(e => e.Realjoinday)
                    .HasColumnName("realjoinday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Retireday)
                    .HasColumnName("retireday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Retirereason).HasColumnName("retirereason");

                entity.Property(e => e.Sexflag)
                    .HasColumnName("sexflag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Statediv)
                    .HasColumnName("statediv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Useraddr)
                    .HasColumnName("useraddr")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Usercell)
                    .HasColumnName("usercell")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userimage)
                    .HasColumnName("userimage")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Usermail)
                    .HasColumnName("usermail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userphone)
                    .HasColumnName("userphone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Zipaddr)
                    .HasColumnName("zipaddr")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUserTenbytenModLog>(entity =>
            {
                entity.HasKey(e => e.Logidx)
                    .HasName("PK__tbl_user__94875BF4299FDAE3");

                entity.ToTable("tbl_user_tenbyten_modLog");

                entity.Property(e => e.Logidx).HasColumnName("logidx");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ChangePn)
                    .IsRequired()
                    .HasColumnName("changePN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ChangePndate)
                    .HasColumnName("changePNdate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Changedate)
                    .HasColumnName("changedate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentFullName)
                    .IsRequired()
                    .HasColumnName("departmentFullName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("job_name")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.JobSn).HasColumnName("job_sn");

                entity.Property(e => e.PositName)
                    .IsRequired()
                    .HasColumnName("posit_name")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PositSn).HasColumnName("posit_sn");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblUserTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_user_tmp");

                entity.Property(e => e.Rownum)
                    .HasColumnName("rownum")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVacationDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_vacation_detail");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Approveday)
                    .HasColumnName("approveday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Approverempno)
                    .HasColumnName("approverempno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Approverid)
                    .HasColumnName("approverid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CallNum)
                    .HasColumnName("callNum")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Deleteyn)
                    .IsRequired()
                    .HasColumnName("deleteyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Endday)
                    .HasColumnName("endday")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Halfgubun)
                    .IsRequired()
                    .HasColumnName("halfgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('no')");

                entity.Property(e => e.Masteridx).HasColumnName("masteridx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Registerempno)
                    .HasColumnName("registerempno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Registerid)
                    .HasColumnName("registerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Startday)
                    .HasColumnName("startday")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Statedivcd)
                    .IsRequired()
                    .HasColumnName("statedivcd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.Totalday)
                    .HasColumnName("totalday")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.WorkAgent)
                    .HasColumnName("workAgent")
                    .HasMaxLength(42)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVacationMaster>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_vacation_master");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Deleteyn)
                    .IsRequired()
                    .HasColumnName("deleteyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Divcd)
                    .IsRequired()
                    .HasColumnName("divcd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Endday)
                    .HasColumnName("endday")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JungsanDay)
                    .HasColumnName("jungsanDay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PromotionDay)
                    .HasColumnName("promotionDay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Registerid)
                    .IsRequired()
                    .HasColumnName("registerid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('system')");

                entity.Property(e => e.Requestedday).HasColumnName("requestedday");

                entity.Property(e => e.RetireJungsanDay)
                    .HasColumnName("retireJungsanDay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Startday)
                    .HasColumnName("startday")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Totalvacationday)
                    .HasColumnName("totalvacationday")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Usedvacationday).HasColumnName("usedvacationday");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Yyyy)
                    .HasColumnName("yyyy")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVacationMonth>(entity =>
            {
                entity.HasKey(e => new { e.Empno, e.Yyyymm });

                entity.ToTable("tbl_vacation_month");

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MonVacationDay).HasColumnName("monVacationDay");

                entity.Property(e => e.PositSn).HasColumnName("posit_sn");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblVitaminDetail>(entity =>
            {
                entity.HasKey(e => e.Didx)
                    .HasName("PK__tbl_vita__DBDF3DCB9D204DAF");

                entity.ToTable("tbl_vitamin_detail");

                entity.Property(e => e.Didx).HasColumnName("didx");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Midx).HasColumnName("midx");

                entity.Property(e => e.Paydate)
                    .HasColumnName("paydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Vmmoney)
                    .HasColumnName("vmmoney")
                    .HasColumnType("money");

                entity.Property(e => e.Vmstatus).HasColumnName("vmstatus");
            });

            modelBuilder.Entity<TblVitaminMaster>(entity =>
            {
                entity.HasKey(e => e.Midx)
                    .HasName("PK__tbl_vita__7C21E03FF2D630D5");

                entity.ToTable("tbl_vitamin_master");

                entity.Property(e => e.Midx).HasColumnName("midx");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Empno)
                    .IsRequired()
                    .HasColumnName("empno")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Endday)
                    .HasColumnName("endday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Startday)
                    .HasColumnName("startday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Totvm)
                    .HasColumnName("totvm")
                    .HasColumnType("money");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Usevm)
                    .HasColumnName("usevm")
                    .HasColumnType("money");

                entity.Property(e => e.Yyyy)
                    .IsRequired()
                    .HasColumnName("yyyy")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblXSiteBrandInfo>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_xSite_BrandInfo");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gubun)
                    .IsRequired()
                    .HasColumnName("gubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Useyn)
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.XSiteId)
                    .IsRequired()
                    .HasColumnName("xSiteId")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpPartnerCtrNew>(entity =>
            {
                entity.HasKey(e => e.CtrIdx)
                    .HasName("PK__tmp_part__9DE398700E030BF1");

                entity.ToTable("tmp_partner_ctr_New");

                entity.Property(e => e.CtrIdx).HasColumnName("ctrIdx");

                entity.Property(e => e.Brandid)
                    .HasColumnName("brandid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Ceoname)
                    .HasColumnName("ceoname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Comname)
                    .IsRequired()
                    .HasColumnName("comname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Compaddr)
                    .HasColumnName("compaddr")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("company_no")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Contractname)
                    .HasColumnName("contractname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Contracttype).HasColumnName("contracttype");

                entity.Property(e => e.Ctrno)
                    .HasColumnName("ctrno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Ctrstate).HasColumnName("ctrstate");

                entity.Property(e => e.Defaultmargin).HasColumnName("defaultmargin");

                entity.Property(e => e.Finuserid)
                    .HasColumnName("finuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Finusername)
                    .HasColumnName("finusername")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Groupid)
                    .IsRequired()
                    .HasColumnName("groupid")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsSubIn)
                    .HasColumnName("isSubIn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Jungsandate)
                    .HasColumnName("jungsandate")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Mcnt).HasColumnName("mcnt");

                entity.Property(e => e.Mwdiv)
                    .HasColumnName("mwdiv")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Newfinuserid)
                    .HasColumnName("newfinuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regusername)
                    .HasColumnName("regusername")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sellplace)
                    .HasColumnName("sellplace")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Senduserid)
                    .HasColumnName("senduserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sendusername)
                    .HasColumnName("sendusername")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Ucnt).HasColumnName("ucnt");

                entity.Property(e => e.Wcnt).HasColumnName("wcnt");
            });

            modelBuilder.Entity<TmpRawCtr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpRawCtr");

                entity.Property(e => e.Brandid)
                    .HasColumnName("brandid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Ceoname)
                    .HasColumnName("ceoname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Comname)
                    .IsRequired()
                    .HasColumnName("comname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Compaddr)
                    .HasColumnName("compaddr")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyNo)
                    .HasColumnName("company_no")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Contractname)
                    .HasColumnName("contractname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Contracttype).HasColumnName("contracttype");

                entity.Property(e => e.Ctrno)
                    .HasColumnName("ctrno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Ctrstate).HasColumnName("ctrstate");

                entity.Property(e => e.Defaultmargin).HasColumnName("defaultmargin");

                entity.Property(e => e.Finuserid)
                    .HasColumnName("finuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Groupid)
                    .IsRequired()
                    .HasColumnName("groupid")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Jungsandate)
                    .HasColumnName("jungsandate")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Mcnt).HasColumnName("mcnt");

                entity.Property(e => e.Mwdiv)
                    .HasColumnName("mwdiv")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sellplace)
                    .HasColumnName("sellplace")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Senduserid)
                    .HasColumnName("senduserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Ucnt).HasColumnName("ucnt");

                entity.Property(e => e.Wcnt).HasColumnName("wcnt");
            });

            modelBuilder.Entity<TmpWorkTableByMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpWorkTableByMonth");

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MonVacationDay).HasColumnName("monVacationDay");

                entity.Property(e => e.TotVacationDay).HasColumnName("totVacationDay");

                entity.Property(e => e.YearVacationDay).HasColumnName("yearVacationDay");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tmptable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmptable");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Cviewidx).HasColumnName("cviewidx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Menuname)
                    .HasColumnName("menuname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Viewidx).HasColumnName("viewidx");
            });

            modelBuilder.Entity<VwPartnerMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_partner_menu");

                entity.Property(e => e.Criticinfo).HasColumnName("criticinfo");

                entity.Property(e => e.Criticinfo1).HasColumnName("criticinfo1");

                entity.Property(e => e.Criticinfo2).HasColumnName("criticinfo2");

                entity.Property(e => e.Divcd).HasColumnName("divcd");

                entity.Property(e => e.Divcd1).HasColumnName("divcd1");

                entity.Property(e => e.Divcd2).HasColumnName("divcd2");

                entity.Property(e => e.Haschild)
                    .IsRequired()
                    .HasColumnName("haschild")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Haschild1)
                    .IsRequired()
                    .HasColumnName("haschild1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Haschild2)
                    .HasColumnName("haschild2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Id1).HasColumnName("id1");

                entity.Property(e => e.Id2).HasColumnName("id2");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isusing1)
                    .HasColumnName("isusing1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isusing2)
                    .HasColumnName("isusing2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Linkurl)
                    .HasColumnName("linkurl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Linkurl1)
                    .HasColumnName("linkurl1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Linkurl2)
                    .HasColumnName("linkurl2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Menucolor)
                    .HasColumnName("menucolor")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Menucolor1)
                    .HasColumnName("menucolor1")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Menucolor2)
                    .HasColumnName("menucolor2")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Menuname)
                    .IsRequired()
                    .HasColumnName("menuname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Menuname1)
                    .IsRequired()
                    .HasColumnName("menuname1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Menuname2)
                    .HasColumnName("menuname2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MenunameEn)
                    .HasColumnName("menuname_En")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MenunameEn1)
                    .IsRequired()
                    .HasColumnName("menuname_En1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MenunameEn2)
                    .HasColumnName("menuname_En2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Menuposhelp)
                    .HasColumnName("menuposhelp")
                    .HasColumnType("text");

                entity.Property(e => e.Menuposhelp1)
                    .HasColumnName("menuposhelp1")
                    .HasColumnType("text");

                entity.Property(e => e.Menuposhelp2)
                    .HasColumnName("menuposhelp2")
                    .HasColumnType("text");

                entity.Property(e => e.Menuposnotice)
                    .HasColumnName("menuposnotice")
                    .HasColumnType("text");

                entity.Property(e => e.Menuposnotice1)
                    .HasColumnName("menuposnotice1")
                    .HasColumnType("text");

                entity.Property(e => e.Menuposnotice2)
                    .HasColumnName("menuposnotice2")
                    .HasColumnType("text");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Parentid1).HasColumnName("parentid1");

                entity.Property(e => e.Parentid2).HasColumnName("parentid2");

                entity.Property(e => e.SaveLog).HasColumnName("saveLog");

                entity.Property(e => e.SaveLog1).HasColumnName("saveLog1");

                entity.Property(e => e.SaveLog2).HasColumnName("saveLog2");

                entity.Property(e => e.UseSslYn)
                    .HasColumnName("useSslYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseSslYn1)
                    .HasColumnName("useSslYN1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseSslYn2)
                    .HasColumnName("useSslYN2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Viewidx).HasColumnName("viewidx");

                entity.Property(e => e.Viewidx1).HasColumnName("viewidx1");

                entity.Property(e => e.Viewidx2).HasColumnName("viewidx2");
            });

            modelBuilder.Entity<VwUserDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_user_department");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Cid1).HasColumnName("cid1");

                entity.Property(e => e.Cid2).HasColumnName("cid2");

                entity.Property(e => e.Cid3).HasColumnName("cid3");

                entity.Property(e => e.Cid4).HasColumnName("cid4");

                entity.Property(e => e.Cid5).HasColumnName("cid5");

                entity.Property(e => e.Cid6).HasColumnName("cid6");

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("departmentName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName1)
                    .HasColumnName("departmentName1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName2)
                    .HasColumnName("departmentName2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName3)
                    .HasColumnName("departmentName3")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName4)
                    .HasColumnName("departmentName4")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName5)
                    .HasColumnName("departmentName5")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName6)
                    .HasColumnName("departmentName6")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentNameFull)
                    .HasColumnName("departmentNameFull")
                    .HasMaxLength(783)
                    .IsUnicode(false);

                entity.Property(e => e.DispOrderNo).HasColumnName("dispOrderNo");

                entity.Property(e => e.DispOrderNo1).HasColumnName("dispOrderNo1");

                entity.Property(e => e.DispOrderNo2).HasColumnName("dispOrderNo2");

                entity.Property(e => e.DispOrderNo3).HasColumnName("dispOrderNo3");

                entity.Property(e => e.DispOrderNo4).HasColumnName("dispOrderNo4");

                entity.Property(e => e.DispOrderNo5).HasColumnName("dispOrderNo5");

                entity.Property(e => e.DispOrderNo6).HasColumnName("dispOrderNo6");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdate1)
                    .HasColumnName("lastupdate1")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdate2)
                    .HasColumnName("lastupdate2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdate3)
                    .HasColumnName("lastupdate3")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdate4)
                    .HasColumnName("lastupdate4")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdate5)
                    .HasColumnName("lastupdate5")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdate6)
                    .HasColumnName("lastupdate6")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pid1).HasColumnName("pid1");

                entity.Property(e => e.Pid2).HasColumnName("pid2");

                entity.Property(e => e.Pid3).HasColumnName("pid3");

                entity.Property(e => e.Pid4).HasColumnName("pid4");

                entity.Property(e => e.Pid5).HasColumnName("pid5");

                entity.Property(e => e.Pid6).HasColumnName("pid6");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate1)
                    .HasColumnName("regdate1")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate2)
                    .HasColumnName("regdate2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate3)
                    .HasColumnName("regdate3")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate4)
                    .HasColumnName("regdate4")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate5)
                    .HasColumnName("regdate5")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate6)
                    .HasColumnName("regdate6")
                    .HasColumnType("datetime");

                entity.Property(e => e.UseYn)
                    .HasColumnName("useYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseYn1)
                    .HasColumnName("useYN1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseYn2)
                    .HasColumnName("useYN2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseYn3)
                    .HasColumnName("useYN3")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseYn4)
                    .HasColumnName("useYN4")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseYn5)
                    .HasColumnName("useYN5")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseYn6)
                    .HasColumnName("useYN6")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        } 
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        #region model
        public virtual DbSet<TblAccCdCategory> TblAccCdCategory { get; set; }
        public virtual DbSet<TblAccCdCategoryDetail> TblAccCdCategoryDetail { get; set; }
        public virtual DbSet<TblAdminKey> TblAdminKey { get; set; }
        public virtual DbSet<TblAraplinkedms> TblAraplinkedms { get; set; }
        public virtual DbSet<TblBizMonthProfit> TblBizMonthProfit { get; set; }
        public virtual DbSet<TblBizMonthProfitBizsection> TblBizMonthProfitBizsection { get; set; }
        public virtual DbSet<TblCompCalendar> TblCompCalendar { get; set; }
        public virtual DbSet<TblCompCalendarOpenList> TblCompCalendarOpenList { get; set; }
        public virtual DbSet<TblCompanyState> TblCompanyState { get; set; }
        public virtual DbSet<TblCompanyStateQueue> TblCompanyStateQueue { get; set; }
        public virtual DbSet<TblCooperateAns> TblCooperateAns { get; set; }
        public virtual DbSet<TblCooperateBoard> TblCooperateBoard { get; set; }
        public virtual DbSet<TblCooperateBoardComment> TblCooperateBoardComment { get; set; }
        public virtual DbSet<TblCooperateBoardPart> TblCooperateBoardPart { get; set; }
        public virtual DbSet<TblCooperateComCode> TblCooperateComCode { get; set; }
        public virtual DbSet<TblCooperateDocument> TblCooperateDocument { get; set; }
        public virtual DbSet<TblCooperateFile> TblCooperateFile { get; set; }
        public virtual DbSet<TblCooperateLog> TblCooperateLog { get; set; }
        public virtual DbSet<TblCooperateRefer> TblCooperateRefer { get; set; }
        public virtual DbSet<TblCooperateWorker> TblCooperateWorker { get; set; }
        public virtual DbSet<TblEAppAccount> TblEAppAccount { get; set; }
        public virtual DbSet<TblEAppAttachFile> TblEAppAttachFile { get; set; }
        public virtual DbSet<TblEAppAuthLine> TblEAppAuthLine { get; set; }
        public virtual DbSet<TblEAppCommCd> TblEAppCommCd { get; set; }
        public virtual DbSet<TblEAppComment> TblEAppComment { get; set; }
        public virtual DbSet<TblEAppPartMoney> TblEAppPartMoney { get; set; }
        public virtual DbSet<TblEAppPayDoc> TblEAppPayDoc { get; set; }
        public virtual DbSet<TblEAppPayRequest> TblEAppPayRequest { get; set; }
        public virtual DbSet<TblEAppPayRequestSubList> TblEAppPayRequestSubList { get; set; }
        public virtual DbSet<TblEAppReport> TblEAppReport { get; set; }
        public virtual DbSet<TblEappPart> TblEappPart { get; set; }
        public virtual DbSet<TblEappPayManager> TblEappPayManager { get; set; }
        public virtual DbSet<TblEdms> TblEdms { get; set; }
        public virtual DbSet<TblEdmsCategory> TblEdmsCategory { get; set; }
        public virtual DbSet<TblEquipmentGubun> TblEquipmentGubun { get; set; }
        public virtual DbSet<TblEquipmentInfoDtl> TblEquipmentInfoDtl { get; set; }
        public virtual DbSet<TblEquipmentInfoGbn> TblEquipmentInfoGbn { get; set; }
        public virtual DbSet<TblEquipmentIp> TblEquipmentIp { get; set; }
        public virtual DbSet<TblEquipmentList사용안함> TblEquipmentList사용안함 { get; set; }
        public virtual DbSet<TblEquipmentLog사용안함> TblEquipmentLog사용안함 { get; set; }
        public virtual DbSet<TblEquipmentMain> TblEquipmentMain { get; set; }
        public virtual DbSet<TblEquipmentMainLog> TblEquipmentMainLog { get; set; }
        public virtual DbSet<TblEquipmentMonthly> TblEquipmentMonthly { get; set; }
        public virtual DbSet<TblEseroAutoIcheMapData> TblEseroAutoIcheMapData { get; set; }
        public virtual DbSet<TblEseroTax> TblEseroTax { get; set; }
        public virtual DbSet<TblEseroTaxMatch> TblEseroTaxMatch { get; set; }
        public virtual DbSet<TblInternalOrder> TblInternalOrder { get; set; }
        public virtual DbSet<TblInternalOrderDetail> TblInternalOrderDetail { get; set; }
        public virtual DbSet<TblInternalPart> TblInternalPart { get; set; }
        public virtual DbSet<TblJobInfo> TblJobInfo { get; set; }
        public virtual DbSet<TblLevel> TblLevel { get; set; }
        public virtual DbSet<TblMdmenuCategory> TblMdmenuCategory { get; set; }
        public virtual DbSet<TblMdmenuPurpose> TblMdmenuPurpose { get; set; }
        public virtual DbSet<TblMenuPart> TblMenuPart { get; set; }
        public virtual DbSet<TblMenuUser> TblMenuUser { get; set; }
        public virtual DbSet<TblMonthlyBrandInfo> TblMonthlyBrandInfo { get; set; }
        public virtual DbSet<TblMonthlySoldoutCancel> TblMonthlySoldoutCancel { get; set; }
        public virtual DbSet<TblNewpartnerMenu> TblNewpartnerMenu { get; set; }
        public virtual DbSet<TblOffshopEmployeeWorkcode> TblOffshopEmployeeWorkcode { get; set; }
        public virtual DbSet<TblOffshopEmployeeWorkschedule> TblOffshopEmployeeWorkschedule { get; set; }
        public virtual DbSet<TblOpExpAccount> TblOpExpAccount { get; set; }
        public virtual DbSet<TblOpExpDaily> TblOpExpDaily { get; set; }
        public virtual DbSet<TblOpExpDailyCard> TblOpExpDailyCard { get; set; }
        public virtual DbSet<TblOpExpDepartmentInfo> TblOpExpDepartmentInfo { get; set; }
        public virtual DbSet<TblOpExpMonthly> TblOpExpMonthly { get; set; }
        public virtual DbSet<TblOpExpMonthlyCard> TblOpExpMonthlyCard { get; set; }
        public virtual DbSet<TblOpExpPart> TblOpExpPart { get; set; }
        public virtual DbSet<TblOpExpPartInfo> TblOpExpPartInfo { get; set; }
        public virtual DbSet<TblOpExpPartType> TblOpExpPartType { get; set; }
        public virtual DbSet<TblOutbrand> TblOutbrand { get; set; }
        public virtual DbSet<TblPartInfo> TblPartInfo { get; set; }
        public virtual DbSet<TblPartner> TblPartner { get; set; }
        public virtual DbSet<TblPartnerAddDepartment> TblPartnerAddDepartment { get; set; }
        public virtual DbSet<TblPartnerAddInfo> TblPartnerAddInfo { get; set; }
        public virtual DbSet<TblPartnerAddJungsanInfo> TblPartnerAddJungsanInfo { get; set; }
        public virtual DbSet<TblPartnerAddLevel> TblPartnerAddLevel { get; set; }
        public virtual DbSet<TblPartnerAuthToken> TblPartnerAuthToken { get; set; }
        public virtual DbSet<TblPartnerAuthlog> TblPartnerAuthlog { get; set; }
        public virtual DbSet<TblPartnerAutosms> TblPartnerAutosms { get; set; }
        public virtual DbSet<TblPartnerCommCode> TblPartnerCommCode { get; set; }
        public virtual DbSet<TblPartnerContract> TblPartnerContract { get; set; }
        public virtual DbSet<TblPartnerContractDetail> TblPartnerContractDetail { get; set; }
        public virtual DbSet<TblPartnerContractDetailType> TblPartnerContractDetailType { get; set; }
        public virtual DbSet<TblPartnerContractType> TblPartnerContractType { get; set; }
        public virtual DbSet<TblPartnerCtrDetail> TblPartnerCtrDetail { get; set; }
        public virtual DbSet<TblPartnerCtrHold> TblPartnerCtrHold { get; set; }
        public virtual DbSet<TblPartnerCtrLgToken> TblPartnerCtrLgToken { get; set; }
        public virtual DbSet<TblPartnerCtrMaster> TblPartnerCtrMaster { get; set; }
        public virtual DbSet<TblPartnerCtrStateLog> TblPartnerCtrStateLog { get; set; }
        public virtual DbSet<TblPartnerCtrSub> TblPartnerCtrSub { get; set; }
        public virtual DbSet<TblPartnerDispcate> TblPartnerDispcate { get; set; }
        public virtual DbSet<TblPartnerFingersAgreeHist> TblPartnerFingersAgreeHist { get; set; }
        public virtual DbSet<TblPartnerGroup> TblPartnerGroup { get; set; }
        public virtual DbSet<TblPartnerGroupAdddata> TblPartnerGroupAdddata { get; set; }
        public virtual DbSet<TblPartnerLoginBatchVendorIp> TblPartnerLoginBatchVendorIp { get; set; }
        public virtual DbSet<TblPartnerLoginIpAuthed> TblPartnerLoginIpAuthed { get; set; }
        public virtual DbSet<TblPartnerLoginRejectIp> TblPartnerLoginRejectIp { get; set; }
        public virtual DbSet<TblPartnerMenu> TblPartnerMenu { get; set; }
        public virtual DbSet<TblPartnerMenuFavorite> TblPartnerMenuFavorite { get; set; }
        public virtual DbSet<TblPartnerPenaltyLog> TblPartnerPenaltyLog { get; set; }
        public virtual DbSet<TblPartnerSearchPwdAuthno> TblPartnerSearchPwdAuthno { get; set; }
        public virtual DbSet<TblPartnerSearchPwdLog> TblPartnerSearchPwdLog { get; set; }
        public virtual DbSet<TblPartnerShopuser> TblPartnerShopuser { get; set; }
        public virtual DbSet<TblPartnerSignlist> TblPartnerSignlist { get; set; }
        public virtual DbSet<TblPartnerSummaryInfo> TblPartnerSummaryInfo { get; set; }
        public virtual DbSet<TblPartnerTempFile> TblPartnerTempFile { get; set; }
        public virtual DbSet<TblPartnerTempInfo> TblPartnerTempInfo { get; set; }
        public virtual DbSet<TblPartnerTempInfoAdddata> TblPartnerTempInfoAdddata { get; set; }
        public virtual DbSet<TblPartnerTempMakerid> TblPartnerTempMakerid { get; set; }
        public virtual DbSet<TblPartnerTpl> TblPartnerTpl { get; set; }
        public virtual DbSet<TblPartpersonCategory> TblPartpersonCategory { get; set; }
        public virtual DbSet<TblPartpersonCategory2> TblPartpersonCategory2 { get; set; }
        public virtual DbSet<TblPhotoBbs> TblPhotoBbs { get; set; }
        public virtual DbSet<TblPhotoCode> TblPhotoCode { get; set; }
        public virtual DbSet<TblPhotoFile> TblPhotoFile { get; set; }
        public virtual DbSet<TblPhotoOpendata> TblPhotoOpendata { get; set; }
        public virtual DbSet<TblPhotoReq> TblPhotoReq { get; set; }
        public virtual DbSet<TblPhotoReqConcept> TblPhotoReqConcept { get; set; }
        public virtual DbSet<TblPhotoReqUseType> TblPhotoReqUseType { get; set; }
        public virtual DbSet<TblPhotoSchedule> TblPhotoSchedule { get; set; }
        public virtual DbSet<TblPhotoUser> TblPhotoUser { get; set; }
        public virtual DbSet<TblPositInfo> TblPositInfo { get; set; }
        public virtual DbSet<TblRankInfo> TblRankInfo { get; set; }
        public virtual DbSet<TblSeminarRoom> TblSeminarRoom { get; set; }
        public virtual DbSet<TblSeminarSchedule> TblSeminarSchedule { get; set; }
        public virtual DbSet<TblTenAgitBooking> TblTenAgitBooking { get; set; }
        public virtual DbSet<TblTenAgitPenalty> TblTenAgitPenalty { get; set; }
        public virtual DbSet<TblTenAgitPoint> TblTenAgitPoint { get; set; }
        public virtual DbSet<TblTenAgitSmsInfo> TblTenAgitSmsInfo { get; set; }
        public virtual DbSet<TblTmsBaArapCd> TblTmsBaArapCd { get; set; }
        public virtual DbSet<TblTmsBaArapCd2015> TblTmsBaArapCd2015 { get; set; }
        public virtual DbSet<TblTmsBaBizsection> TblTmsBaBizsection { get; set; }
        public virtual DbSet<TblTmsBaBizsection2015> TblTmsBaBizsection2015 { get; set; }
        public virtual DbSet<TblTmsBaComCd> TblTmsBaComCd { get; set; }
        public virtual DbSet<TblTmsBaComCd2015> TblTmsBaComCd2015 { get; set; }
        public virtual DbSet<TblTmsBaCust> TblTmsBaCust { get; set; }
        public virtual DbSet<TblTmsBaCust2015> TblTmsBaCust2015 { get; set; }
        public virtual DbSet<TblTmsBaCustAcct> TblTmsBaCustAcct { get; set; }
        public virtual DbSet<TblTmsBaCustAcct2015> TblTmsBaCustAcct2015 { get; set; }
        public virtual DbSet<TblTmsBaCustSaleor> TblTmsBaCustSaleor { get; set; }
        public virtual DbSet<TblTmsBaCustSaleor2015> TblTmsBaCustSaleor2015 { get; set; }
        public virtual DbSet<TblTmsBaProd> TblTmsBaProd { get; set; }
        public virtual DbSet<TblTmsBaProd2015> TblTmsBaProd2015 { get; set; }
        public virtual DbSet<TblTmsSlAccCd> TblTmsSlAccCd { get; set; }
        public virtual DbSet<TblTmsSlAccCd2015> TblTmsSlAccCd2015 { get; set; }
        public virtual DbSet<TblTmsSlAccCdGrp> TblTmsSlAccCdGrp { get; set; }
        public virtual DbSet<TblTmsSlAccCdGrp2015> TblTmsSlAccCdGrp2015 { get; set; }
        public virtual DbSet<TblUserBizsection> TblUserBizsection { get; set; }
        public virtual DbSet<TblUserBizsectionAvg> TblUserBizsectionAvg { get; set; }
        public virtual DbSet<TblUserDailypay> TblUserDailypay { get; set; }
        public virtual DbSet<TblUserDefaultpay> TblUserDefaultpay { get; set; }
        public virtual DbSet<TblUserDefaultpayPattern> TblUserDefaultpayPattern { get; set; }
        public virtual DbSet<TblUserDepartment> TblUserDepartment { get; set; }
        public virtual DbSet<TblUserInouttimeLog> TblUserInouttimeLog { get; set; }
        public virtual DbSet<TblUserInouttimePlace> TblUserInouttimePlace { get; set; }
        public virtual DbSet<TblUserLoginIp> TblUserLoginIp { get; set; }
        public virtual DbSet<TblUserMonthlypay> TblUserMonthlypay { get; set; }
        public virtual DbSet<TblUserTenbyten> TblUserTenbyten { get; set; }
        public virtual DbSet<TblUserTenbytenModLog> TblUserTenbytenModLog { get; set; }
        public virtual DbSet<TblUserTmp> TblUserTmp { get; set; }
        public virtual DbSet<TblVacationDetail> TblVacationDetail { get; set; }
        public virtual DbSet<TblVacationMaster> TblVacationMaster { get; set; }
        public virtual DbSet<TblVacationMonth> TblVacationMonth { get; set; }
        public virtual DbSet<TblVitaminDetail> TblVitaminDetail { get; set; }
        public virtual DbSet<TblVitaminMaster> TblVitaminMaster { get; set; }
        public virtual DbSet<TblXSiteBrandInfo> TblXSiteBrandInfo { get; set; }
        public virtual DbSet<TmpPartnerCtrNew> TmpPartnerCtrNew { get; set; }
        public virtual DbSet<TmpRawCtr> TmpRawCtr { get; set; }
        public virtual DbSet<TmpWorkTableByMonth> TmpWorkTableByMonth { get; set; }
        public virtual DbSet<Tmptable> Tmptable { get; set; }
        public virtual DbSet<VwPartnerMenu> VwPartnerMenu { get; set; }
        public virtual DbSet<VwUserDepartment> VwUserDepartment { get; set; }

        #endregion
    }
}
