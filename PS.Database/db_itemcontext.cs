using Microsoft.EntityFrameworkCore;
using PS.Database.Models.db_Item;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PS.Database
{
    public partial class db_itemcontext : DbContext
    {
        public db_itemcontext(IDbConnection dbConnection, bool isConsoleLogging = false) //: base(dbConnection, isConsoleLogging)
        {
        }
        public db_itemcontext(DbContextOptions<db_itemcontext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAcademyProduct>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_academy_product");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsBest)
                    .IsRequired()
                    .HasColumnName("isBest")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAgirlRegItem>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption })
                    .HasName("PK_tbl_agirl_regedItem");

                entity.ToTable("tbl_agirl_reg_Item");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AgirlOptionCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkStockType).HasColumnName("linkStockType");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblAtseoulCategoryMapping>(entity =>
            {
                entity.HasKey(e => new { e.Tencdl, e.Tencdm, e.Tencdn });

                entity.ToTable("tbl_atseoul_category_mapping");

                entity.Property(e => e.Tencdl)
                    .HasColumnName("tencdl")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tencdm)
                    .HasColumnName("tencdm")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tencdn)
                    .HasColumnName("tencdn")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAtseoulRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_atseoul_reg_item");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAuction>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_action_tmp");

                entity.ToTable("tbl_auction");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.AuctionCateCode)
                    .HasColumnName("auction_cate_code")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(10060500)");

                entity.Property(e => e.AuctionIsusing)
                    .HasColumnName("auction_isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('n')");

                entity.Property(e => e.AuctionRealsel)
                    .HasColumnName("auction_realsel")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenItemid).HasColumnName("ten_itemid");

                entity.Property(e => e.TenOption)
                    .HasColumnName("ten_option")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaljuregBrand>(entity =>
            {
                entity.HasKey(e => e.Brandid);

                entity.ToTable("tbl_baljureg_brand");

                entity.Property(e => e.Brandid)
                    .HasColumnName("brandid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Divcd)
                    .HasColumnName("divcd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaljuregItem>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption });

                entity.ToTable("tbl_baljureg_item");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Divcd)
                    .HasColumnName("divcd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBetweenCate>(entity =>
            {
                entity.HasKey(e => e.Catecode);

                entity.ToTable("tbl_between_cate");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Catename)
                    .IsRequired()
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblBetweenCateItem>(entity =>
            {
                entity.HasKey(e => new { e.Catecode, e.Itemid });

                entity.ToTable("tbl_between_cate_item");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.ChgItemname)
                    .HasColumnName("chgItemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("isDefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isdisplay)
                    .IsRequired()
                    .HasColumnName("isdisplay")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");
            });

            modelBuilder.Entity<TblBetweenMain3banner>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_mobile_main_tpobanner");

                entity.ToTable("tbl_between_main_3banner");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Imglink)
                    .HasColumnName("imglink")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Imgurl)
                    .HasColumnName("imgurl")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Lastadminid)
                    .HasColumnName("lastadminid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sortno).HasColumnName("sortno");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Xmlregdate)
                    .HasColumnName("xmlregdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBetweenNoticefaq>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_between_noticefaq");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnName("contents")
                    .HasColumnType("text");

                entity.Property(e => e.Gubun)
                    .IsRequired()
                    .HasColumnName("gubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBetweenProject>(entity =>
            {
                entity.HasKey(e => e.PjtCode);

                entity.ToTable("tbl_between_project");

                entity.Property(e => e.PjtCode).HasColumnName("pjt_code");

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PjtGender)
                    .IsRequired()
                    .HasColumnName("pjt_gender")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PjtKind)
                    .IsRequired()
                    .HasColumnName("pjt_kind")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PjtLastupdate)
                    .HasColumnName("pjt_lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PjtName)
                    .IsRequired()
                    .HasColumnName("pjt_name")
                    .HasMaxLength(60);

                entity.Property(e => e.PjtRegdate)
                    .HasColumnName("pjt_regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PjtSortType)
                    .HasColumnName("pjt_sortType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PjtState).HasColumnName("pjt_state");

                entity.Property(e => e.PjtTopImgUrl)
                    .HasColumnName("pjt_topImgUrl")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PjtUsing)
                    .IsRequired()
                    .HasColumnName("pjt_using")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblBetweenProjectGroup>(entity =>
            {
                entity.HasKey(e => e.PjtgroupCode);

                entity.ToTable("tbl_between_project_group");

                entity.Property(e => e.PjtgroupCode).HasColumnName("pjtgroup_code");

                entity.Property(e => e.PjtCode).HasColumnName("pjt_code");

                entity.Property(e => e.PjtgroupBgcolor)
                    .HasColumnName("pjtgroup_BGColor")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PjtgroupDepth).HasColumnName("pjtgroup_depth");

                entity.Property(e => e.PjtgroupDesc)
                    .HasColumnName("pjtgroup_desc")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.PjtgroupFontColor)
                    .HasColumnName("pjtgroup_FontColor")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PjtgroupPcode).HasColumnName("pjtgroup_pcode");

                entity.Property(e => e.PjtgroupSort).HasColumnName("pjtgroup_sort");

                entity.Property(e => e.PjtgroupUsing)
                    .IsRequired()
                    .HasColumnName("pjtgroup_using")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBetweenProjectGroupItem>(entity =>
            {
                entity.HasKey(e => new { e.PjtCode, e.Itemid });

                entity.ToTable("tbl_between_project_groupItem");

                entity.Property(e => e.PjtCode).HasColumnName("pjt_code");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.PjtgroupCode).HasColumnName("pjtgroup_code");

                entity.Property(e => e.PjtitemSort).HasColumnName("pjtitem_sort");
            });

            modelBuilder.Entity<TblCameraItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_camera_item__4F67C174");

                entity.ToTable("tbl_camera_item");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommCd)
                    .IsRequired()
                    .HasColumnName("comm_cd")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A001')");

                entity.Property(e => e.GroupCd).HasColumnName("group_cd");
            });

            modelBuilder.Entity<TblCateAttribDiv>(entity =>
            {
                entity.HasKey(e => e.AttribCode)
                    .HasName("PK__tbl_Cate_Attrib___54EB90A0");

                entity.ToTable("tbl_Cate_Attrib_div");

                entity.Property(e => e.AttribCode).HasColumnName("attrib_Code");

                entity.Property(e => e.AttribName)
                    .HasColumnName("attrib_Name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CodeLarge)
                    .IsRequired()
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeMid)
                    .IsRequired()
                    .HasColumnName("code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblCateAttribItem>(entity =>
            {
                entity.HasKey(e => new { e.AttribCode, e.AitemCode })
                    .HasName("PK__tbl_Cate_Attrib___56D3D912");

                entity.ToTable("tbl_Cate_Attrib_item");

                entity.Property(e => e.AttribCode).HasColumnName("attrib_Code");

                entity.Property(e => e.AitemCode)
                    .HasColumnName("aitem_Code")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AitemName)
                    .HasColumnName("aitem_Name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCateLarge>(entity =>
            {
                entity.HasKey(e => e.CodeLarge)
                    .HasName("PK__tbl_Cate_large__5D80D6A1");

                entity.ToTable("tbl_Cate_large");

                entity.Property(e => e.CodeLarge)
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Channel)
                    .IsRequired()
                    .HasColumnName("channel")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeNm)
                    .IsRequired()
                    .HasColumnName("code_nm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayYn)
                    .IsRequired()
                    .HasColumnName("display_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.OrderNo).HasColumnName("orderNo");
            });

            modelBuilder.Entity<TblCateMid>(entity =>
            {
                entity.HasKey(e => new { e.CodeLarge, e.CodeMid })
                    .HasName("PK__tbl_Cate_mid__605D434C");

                entity.ToTable("tbl_Cate_mid");

                entity.Property(e => e.CodeLarge)
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeMid)
                    .HasColumnName("code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeNm)
                    .IsRequired()
                    .HasColumnName("code_nm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CodeNmCnBun)
                    .HasColumnName("code_nm_cn_bun")
                    .HasMaxLength(128);

                entity.Property(e => e.CodeNmCnGan)
                    .HasColumnName("code_nm_cn_gan")
                    .HasMaxLength(128);

                entity.Property(e => e.CodeNmEng)
                    .HasColumnName("code_nm_eng")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CopyNm)
                    .HasColumnName("copy_nm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CopyNmEng)
                    .HasColumnName("copy_nm_eng")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayYn)
                    .IsRequired()
                    .HasColumnName("display_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.OrderNo).HasColumnName("orderNo");
            });

            modelBuilder.Entity<TblCateRelateLink>(entity =>
            {
                entity.HasKey(e => e.LinkCode)
                    .HasName("PK__tbl_Cate_RelateL__6304A5CD");

                entity.ToTable("tbl_Cate_RelateLink");

                entity.HasIndex(e => new { e.CodeLarge, e.CodeMid, e.CodeSmall })
                    .HasName("IX_tbl_item_Category");

                entity.Property(e => e.LinkCode).HasColumnName("linkCode");

                entity.Property(e => e.CodeLarge)
                    .IsRequired()
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeMid)
                    .IsRequired()
                    .HasColumnName("code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeSmall)
                    .HasColumnName("code_small")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LinkKeyword)
                    .IsRequired()
                    .HasColumnName("linkKeyword")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("linkURL")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCateSmall>(entity =>
            {
                entity.HasKey(e => new { e.CodeLarge, e.CodeMid, e.CodeSmall })
                    .HasName("PK__tbl_Cate_small__642DD430");

                entity.ToTable("tbl_Cate_small");

                entity.Property(e => e.CodeLarge)
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeMid)
                    .HasColumnName("code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeSmall)
                    .HasColumnName("code_small")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeNm)
                    .IsRequired()
                    .HasColumnName("code_nm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CodeNmCnBun)
                    .HasColumnName("code_nm_cn_bun")
                    .HasMaxLength(128);

                entity.Property(e => e.CodeNmCnGan)
                    .HasColumnName("code_nm_cn_gan")
                    .HasMaxLength(128);

                entity.Property(e => e.CodeNmEng)
                    .HasColumnName("code_nm_eng")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CopyNm)
                    .HasColumnName("copy_nm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CopyNmEng)
                    .HasColumnName("copy_nm_eng")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayYn)
                    .IsRequired()
                    .HasColumnName("display_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnName("orderNo");
            });

            modelBuilder.Entity<TblCategoryMatching>(entity =>
            {
                entity.HasKey(e => e.Matchidx)
                    .HasName("PK__tbl_Cate__99E354E0571A2D10");

                entity.ToTable("tbl_Category_Matching");

                entity.Property(e => e.Matchidx).HasColumnName("matchidx");

                entity.Property(e => e.AdminId)
                    .IsRequired()
                    .HasColumnName("adminId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.CodeLarge)
                    .IsRequired()
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeMid)
                    .IsRequired()
                    .HasColumnName("code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeSmall)
                    .IsRequired()
                    .HasColumnName("code_small")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblCategoryMatching2>(entity =>
            {
                entity.HasKey(e => e.Matchidx)
                    .HasName("PK__tbl_Cate__99E354E0487FE801");

                entity.ToTable("tbl_Category_Matching2");

                entity.Property(e => e.Matchidx).HasColumnName("matchidx");

                entity.Property(e => e.AdminId)
                    .IsRequired()
                    .HasColumnName("adminId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.CodeLarge)
                    .IsRequired()
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeMid)
                    .IsRequired()
                    .HasColumnName("code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeSmall)
                    .IsRequired()
                    .HasColumnName("code_small")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblCjMallPrdDivMapping>(entity =>
            {
                entity.HasKey(e => new { e.CddKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_cjMall_prdDiv_mapping");

                entity.HasIndex(e => new { e.Infodiv, e.TenCateLarge, e.TenCateMid, e.TenCateSmall })
                    .HasName("IX_tbl_cjMall_prdDiv_mapping_infoDiv_cate");

                entity.Property(e => e.CddKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CdmKey)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Infodiv)
                    .HasColumnName("infodiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCjmallCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_cjmall_cate_mapping");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblCjmallPrddivMidMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_cjmall_PrddivMid_map");

                entity.Property(e => e.Cjcdm)
                    .IsRequired()
                    .HasColumnName("cjcdm")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Infodiv)
                    .IsRequired()
                    .HasColumnName("infodiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCjmallRegitem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_cjmall_regitem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cdmkey)
                    .HasColumnName("cdmkey")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CjmallLastUpdate)
                    .HasColumnName("cjmallLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CjmallPrdNo)
                    .HasColumnName("cjmallPrdNo")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CjmallPrice)
                    .HasColumnName("cjmallPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CjmallRegdate)
                    .HasColumnName("cjmallRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CjmallSellYn)
                    .IsRequired()
                    .HasColumnName("cjmallSellYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.CjmallStatCd).HasColumnName("cjmallStatCd");

                entity.Property(e => e.Infodiv)
                    .HasColumnName("infodiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastPriceCheckDate)
                    .HasColumnName("lastPriceCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegedOptCnt).HasColumnName("regedOptCnt");

                entity.Property(e => e.Regitemname)
                    .HasColumnName("regitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblColorChips>(entity =>
            {
                entity.HasKey(e => e.ColorCode)
                    .HasName("PK__tbl_colorChips__46BD6CDA");

                entity.ToTable("tbl_colorChips");

                entity.Property(e => e.ColorCode).HasColumnName("colorCode");

                entity.Property(e => e.ColorIcon)
                    .HasMaxLength(68)
                    .IsUnicode(false);

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasColumnName("colorName")
                    .HasMaxLength(12);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");
            });

            modelBuilder.Entity<TblColorfavorite>(entity =>
            {
                entity.HasKey(e => new { e.Favoriteidx, e.Colorcode, e.Userid });

                entity.ToTable("tbl_colorfavorite");

                entity.Property(e => e.Favoriteidx)
                    .HasColumnName("favoriteidx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Colorcode).HasColumnName("colorcode");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblColortrend>(entity =>
            {
                entity.HasKey(e => e.Ctcode);

                entity.ToTable("tbl_colortrend");

                entity.HasIndex(e => e.Colorcode)
                    .HasName("IX_colorcode");

                entity.Property(e => e.Ctcode).HasColumnName("ctcode");

                entity.Property(e => e.Colorcode).HasColumnName("colorcode");

                entity.Property(e => e.Colortitle)
                    .HasColumnName("colortitle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Lastadminid)
                    .HasColumnName("lastadminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Listimg)
                    .HasColumnName("listimg")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Mainimage)
                    .HasColumnName("mainimage")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Mainimagelink)
                    .HasColumnName("mainimagelink")
                    .HasColumnType("text");

                entity.Property(e => e.Mainimagelinknew)
                    .HasColumnName("mainimagelinknew")
                    .HasColumnType("text");

                entity.Property(e => e.Nmainimg)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Partmdid)
                    .HasColumnName("partmdid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Partwdid)
                    .HasColumnName("partwdid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Textimage)
                    .HasColumnName("textimage")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Viewno).HasColumnName("viewno");
            });

            modelBuilder.Entity<TblColortrendItem>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.ColorCode, e.Itemid })
                    .HasName("PK_tbl_colortrent_item");

                entity.ToTable("tbl_colortrend_item");

                entity.HasIndex(e => e.Orderno)
                    .HasName("IX_orderno");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ColorCode).HasColumnName("colorCode");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Orderno)
                    .HasColumnName("orderno")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblConstOptAddPriceExists>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_cons__56A22C924AB67D7F");

                entity.ToTable("tbl_const_OptAddPrice_Exists");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblDayexchageRate>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Yyyymmdd });

                entity.ToTable("tbl_dayexchageRate");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Yyyymmdd)
                    .HasColumnName("yyyymmdd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cny)
                    .HasColumnName("CNY")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUserid)
                    .HasColumnName("lastUserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Myr)
                    .HasColumnName("MYR")
                    .HasColumnType("money");

                entity.Property(e => e.RegUserid)
                    .IsRequired()
                    .HasColumnName("regUserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sgd)
                    .HasColumnName("SGD")
                    .HasColumnType("money");

                entity.Property(e => e.Usd)
                    .HasColumnName("USD")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblDisplayCate>(entity =>
            {
                entity.HasKey(e => e.Catecode);

                entity.ToTable("tbl_display_cate");

                entity.HasIndex(e => e.Depth);

                entity.HasIndex(e => new { e.Catecode, e.Catename, e.SortNo, e.Depth, e.Useyn })
                    .HasName("IX_tbl_display_cate_depth_useyn");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Catename)
                    .IsRequired()
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CatenameE)
                    .HasColumnName("catename_e")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.Isnew)
                    .IsRequired()
                    .HasColumnName("isnew")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('x')");

                entity.Property(e => e.Jaehuname)
                    .HasColumnName("jaehuname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Safetyinfotype)
                    .IsRequired()
                    .HasColumnName("safetyinfotype")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SearchKeywords)
                    .HasColumnName("searchKeywords")
                    .HasMaxLength(512);

                entity.Property(e => e.Sitegubun)
                    .IsRequired()
                    .HasColumnName("sitegubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('T')");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDisplayCate2>(entity =>
            {
                entity.HasKey(e => e.Catecode);

                entity.ToTable("tbl_display_cate2");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Catename)
                    .IsRequired()
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CatenameE)
                    .HasColumnName("catename_e")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.Isnew)
                    .IsRequired()
                    .HasColumnName("isnew")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('x')");

                entity.Property(e => e.Jaehuname)
                    .HasColumnName("jaehuname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Safetyinfotype)
                    .IsRequired()
                    .HasColumnName("safetyinfotype")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SearchKeywords)
                    .HasColumnName("searchKeywords")
                    .HasMaxLength(512);

                entity.Property(e => e.Sitegubun)
                    .IsRequired()
                    .HasColumnName("sitegubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('T')");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDisplayCate2Item>(entity =>
            {
                entity.HasKey(e => new { e.Catecode, e.Itemid });

                entity.ToTable("tbl_display_cate2_item");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("isDefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SortNo).HasColumnName("sortNo");
            });

            modelBuilder.Entity<TblDisplayCateItem>(entity =>
            {
                entity.HasKey(e => new { e.Catecode, e.Itemid });

                entity.ToTable("tbl_display_cate_item");

                entity.HasIndex(e => e.Catecode)
                    .HasName("IX_display_cate_item_catecode");

                entity.HasIndex(e => e.Depth);

                entity.HasIndex(e => e.Itemid)
                    .HasName("IX_display_cate_item_itemid");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("isDefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SortNo).HasColumnName("sortNo");
            });

            modelBuilder.Entity<TblDisplayCateMenu>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_display_cate_menu");

                entity.HasIndex(e => e.Catecode)
                    .HasName("IX_tbl_display_cate_menu");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDisplayCateMenuTop>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_display_cate_menu_top");

                entity.HasIndex(e => e.Disp1);

                entity.HasIndex(e => e.Type);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Disp1).HasColumnName("disp1");

                entity.Property(e => e.Edate)
                    .IsRequired()
                    .HasColumnName("edate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Imgurl)
                    .IsRequired()
                    .HasColumnName("imgurl")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Linkurl)
                    .IsRequired()
                    .HasColumnName("linkurl")
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Ordertext)
                    .HasColumnName("ordertext")
                    .HasColumnType("text");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sdate)
                    .IsRequired()
                    .HasColumnName("sdate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sortno).HasColumnName("sortno");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDisplayCateSubshop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_display_cate_subshop");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Subshopdiv)
                    .HasColumnName("subshopdiv")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDisplayTotalcategory>(entity =>
            {
                entity.HasKey(e => e.Catecode);

                entity.ToTable("tbl_display_totalcategory");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .ValueGeneratedNever();

                entity.Property(e => e.CateName)
                    .IsRequired()
                    .HasColumnName("cateName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CateName2)
                    .IsRequired()
                    .HasColumnName("cateName2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastcatecodeYn)
                    .HasColumnName("lastcatecodeYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lv).HasColumnName("LV");

                entity.Property(e => e.ParentCatecode).HasColumnName("parentCatecode");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");
            });

            modelBuilder.Entity<TblDnshopDspcategoryMapping>(entity =>
            {
                entity.HasKey(e => new { e.Tencdl, e.Tencdm, e.Tencdn });

                entity.ToTable("tbl_dnshop_dspcategory_mapping");

                entity.Property(e => e.Tencdl)
                    .HasColumnName("tencdl")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tencdm)
                    .HasColumnName("tencdm")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tencdn)
                    .HasColumnName("tencdn")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DnshopEcategory)
                    .HasColumnName("dnshopEcategory")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DnshopRcategory)
                    .HasColumnName("dnshopRcategory")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DnshopSeCategory)
                    .HasColumnName("dnshopSeCategory")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DnshopSpkey)
                    .HasColumnName("dnshopSpkey")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Dnshopdispcategory)
                    .IsRequired()
                    .HasColumnName("dnshopdispcategory")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Dnshopstorecategory)
                    .HasColumnName("dnshopstorecategory")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDnshopMngcategoryMapping>(entity =>
            {
                entity.HasKey(e => new { e.Tencdl, e.Tencdm });

                entity.ToTable("tbl_dnshop_mngcategory_mapping");

                entity.Property(e => e.Tencdl)
                    .HasColumnName("tencdl")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Tencdm)
                    .HasColumnName("tencdm")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Dnshopmngcategory)
                    .IsRequired()
                    .HasColumnName("dnshopmngcategory")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDnshopRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_dnshop_reg_item");

                entity.HasIndex(e => e.Regdate);

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dnshoplastupdate)
                    .HasColumnName("dnshoplastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblExchangeRate>(entity =>
            {
                entity.HasKey(e => new { e.Sitename, e.CountryLangCd, e.CurrencyUnit })
                    .HasName("PK_tbl_exchangeRate_2");

                entity.ToTable("tbl_exchangeRate");

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'10X10ONLINE')");

                entity.Property(e => e.CountryLangCd)
                    .HasColumnName("countryLangCD")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyUnit)
                    .HasColumnName("currencyUnit")
                    .HasMaxLength(16);

                entity.Property(e => e.Basedate)
                    .IsRequired()
                    .HasColumnName("basedate")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyChar)
                    .IsRequired()
                    .HasColumnName("currencyChar")
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchangeRate")
                    .HasColumnType("money");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastuserid)
                    .IsRequired()
                    .HasColumnName("lastuserid")
                    .HasMaxLength(32);

                entity.Property(e => e.LinkPriceType).HasColumnName("linkPriceType");

                entity.Property(e => e.Multiplerate)
                    .HasColumnName("multiplerate")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<TblExhibitionItemDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_exhibition_item_detail");

                entity.HasIndex(e => new { e.Optioncode, e.Detailcode, e.Gubuncode, e.Idx, e.Itemid })
                    .HasName("IX_tbl_item_exhibition_item_detail_idx_gubuncode_optioncode,detailcode");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Detailcode).HasColumnName("detailcode");

                entity.Property(e => e.Gubuncode).HasColumnName("gubuncode");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mastercode).HasColumnName("mastercode");

                entity.Property(e => e.Optioncode)
                    .HasColumnName("optioncode")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblExhibitionItemDetail2>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .IsClustered(false);

                entity.ToTable("tbl_exhibition_item_detail2");

                entity.HasIndex(e => e.Detailcode)
                    .HasName("CX_tbl_exhibition_item_detail2")
                    .IsClustered();

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Detailcode).HasColumnName("detailcode");

                entity.Property(e => e.Gubuncode).HasColumnName("gubuncode");

                entity.Property(e => e.Isusing).HasColumnName("isusing");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mastercode).HasColumnName("mastercode");

                entity.Property(e => e.Optioncode)
                    .HasColumnName("optioncode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblExhibitionItemMaster>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_exhibition_item_master");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemscore).HasColumnName("itemscore");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mastercode).HasColumnName("mastercode");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblExhibitioneventGroupcode>(entity =>
            {
                entity.HasKey(e => e.Gidx)
                    .HasName("PK_tbl_eventitem_groupcode");

                entity.ToTable("tbl_exhibitionevent_groupcode");

                entity.Property(e => e.Gidx).HasColumnName("gidx");

                entity.Property(e => e.Detailcode).HasColumnName("detailcode");

                entity.Property(e => e.Gubuncode).HasColumnName("gubuncode");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mastercode).HasColumnName("mastercode");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(32);

                entity.Property(e => e.Typename)
                    .HasColumnName("typename")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<TblFujiTempleteCode>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption });

                entity.ToTable("tbl_fuji_templete_code");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasColumnName("pcode")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Tplcode)
                    .IsRequired()
                    .HasColumnName("tplcode")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Tplname)
                    .IsRequired()
                    .HasColumnName("tplname")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGiftcardDesign>(entity =>
            {
                entity.HasKey(e => e.DesignId)
                    .HasName("PK__tbl_giftcard_des__5689C04F");

                entity.ToTable("tbl_giftcard_design");

                entity.Property(e => e.DesignId)
                    .HasColumnName("designId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardDesignName)
                    .HasColumnName("cardDesignName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CardItemid).HasColumnName("cardItemid");

                entity.Property(e => e.EmailImage)
                    .HasColumnName("emailImage")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EmailText)
                    .HasColumnName("emailText")
                    .HasColumnType("text");

                entity.Property(e => e.EmailThumb)
                    .HasColumnName("emailThumb")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.GroupDiv)
                    .IsRequired()
                    .HasColumnName("groupDiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Mmsimage)
                    .HasColumnName("MMSImage")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Mmstext)
                    .HasColumnName("MMSText")
                    .HasColumnType("text");

                entity.Property(e => e.Mmsthumb)
                    .HasColumnName("MMSThumb")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SortNo)
                    .HasColumnName("sortNo")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblGiftcardItem>(entity =>
            {
                entity.HasKey(e => e.Carditemid)
                    .HasName("PK__Tbl_Giftcard_Ite__59662CFA");

                entity.ToTable("Tbl_Giftcard_Item");

                entity.Property(e => e.Basicimage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Basicimage600)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Carddesc).HasColumnType("text");

                entity.Property(e => e.Cardinfo)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Carditemname)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Cardsellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('y')");

                entity.Property(e => e.Icon1Image)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Listimage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Listimage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Smallimage)
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGiftcardOption>(entity =>
            {
                entity.HasKey(e => new { e.CardItemid, e.CardOption })
                    .HasName("PK__tbl_giftcard_opt__5E2AE217");

                entity.ToTable("tbl_giftcard_option");

                entity.Property(e => e.CardItemid).HasColumnName("cardItemid");

                entity.Property(e => e.CardOption)
                    .HasColumnName("cardOption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CardOptionName)
                    .IsRequired()
                    .HasColumnName("cardOptionName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CardOrgPrice)
                    .HasColumnName("cardOrgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CardSalePrice)
                    .HasColumnName("cardSalePrice")
                    .HasColumnType("money");

                entity.Property(e => e.CardSaleYn)
                    .IsRequired()
                    .HasColumnName("cardSaleYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CardSellCash)
                    .HasColumnName("cardSellCash")
                    .HasColumnType("money");

                entity.Property(e => e.OptIsUsing)
                    .IsRequired()
                    .HasColumnName("optIsUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.OptSellYn)
                    .IsRequired()
                    .HasColumnName("optSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblGsshopBrandDeliveryMapping>(entity =>
            {
                entity.HasKey(e => e.Makerid);

                entity.ToTable("tbl_gsshop_brandDelivery_mapping");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Brandcd)
                    .HasColumnName("brandcd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryAddrCd)
                    .IsRequired()
                    .HasColumnName("deliveryAddrCd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryCd)
                    .IsRequired()
                    .HasColumnName("deliveryCd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regid)
                    .IsRequired()
                    .HasColumnName("regid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Updateid)
                    .HasColumnName("updateid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGsshopCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_gsshop_cate_mapping");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGsshopMdidMapping>(entity =>
            {
                entity.HasKey(e => e.Catekey);

                entity.ToTable("tbl_gsshop_mdid_mapping");

                entity.Property(e => e.Catekey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mdid)
                    .IsRequired()
                    .HasColumnName("mdid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGsshopPrdDivMapping>(entity =>
            {
                entity.HasKey(e => new { e.Divcode, e.Infodiv, e.TenCateLarge, e.TenCateMid, e.TenCateSmall })
                    .HasName("PK_tbl_gsshop_prdDiv_mapping_1");

                entity.ToTable("tbl_gsshop_prdDiv_mapping");

                entity.Property(e => e.Divcode)
                    .HasColumnName("divcode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Infodiv)
                    .HasColumnName("infodiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isvat)
                    .IsRequired()
                    .HasColumnName("isvat")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Safecode)
                    .IsRequired()
                    .HasColumnName("safecode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblGsshopRegitem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_gsshop_regitem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GsshopGoodNo)
                    .HasColumnName("GSShopGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GsshopLastUpdate)
                    .HasColumnName("GSShopLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GsshopPrice)
                    .HasColumnName("GSShopPrice")
                    .HasColumnType("money");

                entity.Property(e => e.GsshopRegdate)
                    .HasColumnName("GSShopRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.GsshopSellYn)
                    .IsRequired()
                    .HasColumnName("GSShopSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.GsshopStatCd).HasColumnName("GSShopStatCd");

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastconfirmdate)
                    .HasColumnName("lastconfirmdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegedOptCnt).HasColumnName("regedOptCnt");

                entity.Property(e => e.Regitemname)
                    .HasColumnName("regitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGsshopSafeCode>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_gsshop_safeCode");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.SafeCertDt)
                    .HasColumnName("safeCertDt")
                    .HasColumnType("datetime");

                entity.Property(e => e.SafeCertGbnCd)
                    .HasColumnName("safeCertGbnCd")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SafeCertModelNm)
                    .HasColumnName("safeCertModelNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SafeCertNo)
                    .HasColumnName("safeCertNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SafeCertOrgCd)
                    .HasColumnName("safeCertOrgCd")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInfinitystaticCategory>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_infinitystatic_category");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mainidx).HasColumnName("mainidx");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblInfinitystaticHistory>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_infinitystatic_history");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Mainidx).HasColumnName("mainidx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblInfinitystaticMain>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_infinitystatic_main");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Contents)
                    .HasColumnName("contents")
                    .HasColumnType("ntext");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Parameter)
                    .HasColumnName("parameter")
                    .HasMaxLength(2000);

                entity.Property(e => e.Regid)
                    .HasColumnName("regid")
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblInterparkDspcategoryMapping>(entity =>
            {
                entity.HasKey(e => new { e.Tencdl, e.Tencdm, e.Tencdn });

                entity.ToTable("tbl_interpark_dspcategory_mapping");

                entity.Property(e => e.Tencdl)
                    .HasColumnName("tencdl")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tencdm)
                    .HasColumnName("tencdm")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tencdn)
                    .HasColumnName("tencdn")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Interparkdispcategory)
                    .IsRequired()
                    .HasColumnName("interparkdispcategory")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Interparkstorecategory)
                    .HasColumnName("interparkstorecategory")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInterparkRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_interpark_reg_item");

                entity.HasIndex(e => e.InterParkPrdNo)
                    .HasName("IX_tbl_interpark_reg_Item_interParkPrdNo");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InterParkPrdNo)
                    .HasColumnName("interParkPrdNo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InterParkStoreCategory)
                    .HasColumnName("interParkStoreCategory")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InterParkSupplyCtrtSeq).HasColumnName("interParkSupplyCtrtSeq");

                entity.Property(e => e.Interparklastupdate)
                    .HasColumnName("interparklastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Interparkregdate)
                    .HasColumnName("interparkregdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MayiParkPrice)
                    .HasColumnName("mayiParkPrice")
                    .HasColumnType("money");

                entity.Property(e => e.MayiParkSellYn)
                    .HasColumnName("mayiParkSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PinterParkDispCategory)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regcatecode)
                    .HasColumnName("regcatecode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegedOptCnt).HasColumnName("regedOptCnt");

                entity.Property(e => e.RegimageName)
                    .HasColumnName("regimageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regitemname)
                    .HasColumnName("regitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK_dbo_tbl_item_itemid");

                entity.ToTable("tbl_item");

                entity.HasIndex(e => e.Dispcate1);

                entity.HasIndex(e => e.Itemscore);

                entity.HasIndex(e => e.Regdate);

                entity.HasIndex(e => new { e.Itemscore, e.Makerid })
                    .HasName("IX_tbl_item_makerid");

                entity.HasIndex(e => new { e.Isusing, e.Sellyn, e.Sailyn, e.Itemdiv, e.Itemgubun, e.Limityn })
                    .HasName("IX_tbl_item_Using");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdultType)
                    .HasColumnName("adultType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AvailPayType)
                    .HasColumnName("availPayType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Basicimage)
                    .HasColumnName("basicimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Basicimage1000)
                    .HasColumnName("basicimage1000")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Basicimage600)
                    .HasColumnName("basicimage600")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Brandname)
                    .HasColumnName("brandname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money");

                entity.Property(e => e.CateLarge)
                    .HasColumnName("cate_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CateMid)
                    .HasColumnName("cate_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CateSmall)
                    .HasColumnName("cate_small")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Curritemcouponidx).HasColumnName("curritemcouponidx");

                entity.Property(e => e.Danjongyn)
                    .HasColumnName("danjongyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DeliverOverseas)
                    .HasColumnName("deliverOverseas")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Deliverarea)
                    .HasColumnName("deliverarea")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deliverfixday)
                    .HasColumnName("deliverfixday")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Dispcate1)
                    .HasColumnName("dispcate1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EvalCntPhoto)
                    .HasColumnName("evalCnt_photo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Evalcnt).HasColumnName("evalcnt");

                entity.Property(e => e.Evaloffcnt)
                    .HasColumnName("evaloffcnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FrontMakerid)
                    .HasColumnName("frontMakerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Icon1image)
                    .HasColumnName("icon1image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2image)
                    .HasColumnName("icon2image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Isextusing)
                    .IsRequired()
                    .HasColumnName("isextusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Ismobileitem)
                    .IsRequired()
                    .HasColumnName("ismobileitem")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ItemWeight)
                    .HasColumnName("itemWeight")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Itemcoupontype)
                    .HasColumnName("itemcoupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Itemcouponvalue)
                    .HasColumnName("itemcouponvalue")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Itemcouponyn)
                    .HasColumnName("itemcouponyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.Itemgubun)
                    .IsRequired()
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('10')");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemrackcode)
                    .IsRequired()
                    .HasColumnName("itemrackcode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Itemscore)
                    .HasColumnName("itemscore")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Limitdispyn)
                    .HasColumnName("limitdispyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Limitno)
                    .HasColumnName("limitno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Limitsold)
                    .HasColumnName("limitsold")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Limityn)
                    .IsRequired()
                    .HasColumnName("limityn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Listimage)
                    .HasColumnName("listimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Listimage120)
                    .HasColumnName("listimage120")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.MainImage2)
                    .HasColumnName("mainImage2")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mainimage)
                    .HasColumnName("mainimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mainimage3)
                    .HasColumnName("mainimage3")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Maskimage)
                    .HasColumnName("maskimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Maskimage1000)
                    .HasColumnName("maskimage1000")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mileage)
                    .HasColumnName("mileage")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Mwdiv)
                    .IsRequired()
                    .HasColumnName("mwdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('W')");

                entity.Property(e => e.Optioncnt).HasColumnName("optioncnt");

                entity.Property(e => e.OrderMaxNum)
                    .HasColumnName("orderMaxNum")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.OrderMinNum)
                    .HasColumnName("orderMinNum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Orgprice)
                    .HasColumnName("orgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Orgsuplycash)
                    .HasColumnName("orgsuplycash")
                    .HasColumnType("money");

                entity.Property(e => e.Pojangok)
                    .IsRequired()
                    .HasColumnName("pojangok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reipgodate)
                    .HasColumnName("reipgodate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReserveItemTp)
                    .HasColumnName("reserveItemTp")
                    .HasComment("1:단독(예약)구매상품");

                entity.Property(e => e.Sailprice)
                    .HasColumnName("sailprice")
                    .HasColumnType("money");

                entity.Property(e => e.Sailsuplycash)
                    .HasColumnName("sailsuplycash")
                    .HasColumnType("money");

                entity.Property(e => e.Sailyn)
                    .IsRequired()
                    .HasColumnName("sailyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SellEndDate)
                    .HasColumnName("sellEndDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SellStdate)
                    .HasColumnName("sellSTDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasColumnName("sellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Smallimage)
                    .HasColumnName("smallimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Specialuseritem).HasColumnName("specialuseritem");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Tentenimage)
                    .HasColumnName("tentenimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Tentenimage1000)
                    .HasColumnName("tentenimage1000")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Tentenimage200)
                    .HasColumnName("tentenimage200")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Tentenimage400)
                    .HasColumnName("tentenimage400")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Tentenimage50)
                    .HasColumnName("tentenimage50")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Tentenimage600)
                    .HasColumnName("tentenimage600")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Titleimage)
                    .HasColumnName("titleimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Upchemanagecode)
                    .HasColumnName("upchemanagecode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Vatinclude)
                    .IsRequired()
                    .HasColumnName("vatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblItem2>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_item_2");

                entity.HasIndex(e => e.Makerid);

                entity.HasIndex(e => e.Regdate);

                entity.HasIndex(e => new { e.CateLarge, e.CateMid, e.CateSmall, e.Itemid })
                    .HasName("IX_tbl_item_2_Category");

                entity.HasIndex(e => new { e.Isusing, e.Sellyn, e.Sailyn, e.Itemdiv, e.Itemgubun, e.Limityn })
                    .HasName("IX_tbl_item_2_Using");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AvailPayType)
                    .HasColumnName("availPayType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Basicimage)
                    .HasColumnName("basicimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Brandname)
                    .HasColumnName("brandname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money");

                entity.Property(e => e.CateLarge)
                    .HasColumnName("cate_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CateMid)
                    .HasColumnName("cate_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CateSmall)
                    .HasColumnName("cate_small")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Curritemcouponidx).HasColumnName("curritemcouponidx");

                entity.Property(e => e.Danjongyn)
                    .HasColumnName("danjongyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deliverarea)
                    .HasColumnName("deliverarea")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deliverfixday)
                    .HasColumnName("deliverfixday")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Evalcnt).HasColumnName("evalcnt");

                entity.Property(e => e.Icon1image)
                    .HasColumnName("icon1image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2image)
                    .HasColumnName("icon2image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Isextusing)
                    .IsRequired()
                    .HasColumnName("isextusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ismobileitem)
                    .IsRequired()
                    .HasColumnName("ismobileitem")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemcoupontype)
                    .HasColumnName("itemcoupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemcouponvalue).HasColumnName("itemcouponvalue");

                entity.Property(e => e.Itemcouponyn)
                    .HasColumnName("itemcouponyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemgubun)
                    .IsRequired()
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemrackcode)
                    .IsRequired()
                    .HasColumnName("itemrackcode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Itemscore).HasColumnName("itemscore");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Limitno).HasColumnName("limitno");

                entity.Property(e => e.Limitsold).HasColumnName("limitsold");

                entity.Property(e => e.Limityn)
                    .IsRequired()
                    .HasColumnName("limityn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Listimage)
                    .HasColumnName("listimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Listimage120)
                    .HasColumnName("listimage120")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mainimage)
                    .HasColumnName("mainimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mileage)
                    .HasColumnName("mileage")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Mwdiv)
                    .IsRequired()
                    .HasColumnName("mwdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Optioncnt).HasColumnName("optioncnt");

                entity.Property(e => e.Orgprice)
                    .HasColumnName("orgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Orgsuplycash)
                    .HasColumnName("orgsuplycash")
                    .HasColumnType("money");

                entity.Property(e => e.Pojangok)
                    .IsRequired()
                    .HasColumnName("pojangok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reipgodate)
                    .HasColumnName("reipgodate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sailprice)
                    .HasColumnName("sailprice")
                    .HasColumnType("money");

                entity.Property(e => e.Sailsuplycash)
                    .HasColumnName("sailsuplycash")
                    .HasColumnType("money");

                entity.Property(e => e.Sailyn)
                    .IsRequired()
                    .HasColumnName("sailyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SellEndDate)
                    .HasColumnName("sellEndDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasColumnName("sellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Smallimage)
                    .HasColumnName("smallimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Specialuseritem).HasColumnName("specialuseritem");

                entity.Property(e => e.Titleimage)
                    .HasColumnName("titleimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Upchemanagecode)
                    .HasColumnName("upchemanagecode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vatinclude)
                    .IsRequired()
                    .HasColumnName("vatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblItemAddimage>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_item_addimage");

                entity.HasIndex(e => e.Imgtype);

                entity.HasIndex(e => e.Itemid)
                    .HasName("IX_tbl_item_addimage_itemid");

                entity.HasIndex(e => new { e.Itemid, e.Imgtype, e.Gubun })
                    .HasName("IX_tbl_item_addimage")
                    .IsUnique();

                entity.Property(e => e.Idx).HasColumnName("IDX");

                entity.Property(e => e.Addimage1000)
                    .HasColumnName("ADDIMAGE_1000")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Addimage400)
                    .HasColumnName("ADDIMAGE_400")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Addimage600)
                    .HasColumnName("ADDIMAGE_600")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Gubun).HasColumnName("GUBUN");

                entity.Property(e => e.Imgtype)
                    .HasColumnName("IMGTYPE")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");
            });

            modelBuilder.Entity<TblItemAttribDispCate>(entity =>
            {
                entity.HasKey(e => new { e.AttribDiv, e.Catecode })
                    .HasName("PK__tbl_itemAttrib_d__743A1EC7");

                entity.ToTable("tbl_itemAttrib_dispCate");

                entity.Property(e => e.AttribDiv)
                    .HasColumnName("attribDiv")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Catecode).HasColumnName("catecode");
            });

            modelBuilder.Entity<TblItemAttribItem>(entity =>
            {
                entity.HasKey(e => new { e.AttribCd, e.Itemid })
                    .HasName("PK__tbl_itemAttrib_i__76226739");

                entity.ToTable("tbl_itemAttrib_item");

                entity.HasIndex(e => e.Itemid);

                entity.Property(e => e.AttribCd)
                    .HasColumnName("attribCd")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblItemAttribute>(entity =>
            {
                entity.HasKey(e => new { e.AttribCode, e.AitemCode, e.Itemid })
                    .HasName("PK__tbl_Item_Attribu__58BC2184");

                entity.ToTable("tbl_Item_Attribute");

                entity.Property(e => e.AttribCode).HasColumnName("attrib_Code");

                entity.Property(e => e.AitemCode).HasColumnName("aitem_Code");

                entity.Property(e => e.Itemid).HasColumnName("itemid");
            });

            modelBuilder.Entity<TblItemAttribute1>(entity =>
            {
                entity.HasKey(e => e.AttribCd)
                    .HasName("PK__tbl_itemAttribut__7FABD173");

                entity.ToTable("tbl_itemAttribute");

                entity.Property(e => e.AttribCd)
                    .HasColumnName("attribCd")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AttribDiv)
                    .IsRequired()
                    .HasColumnName("attribDiv")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AttribDivName)
                    .HasColumnName("attribDivName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AttribName)
                    .IsRequired()
                    .HasColumnName("attribName")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AttribNameAdd)
                    .IsRequired()
                    .HasColumnName("attribNameAdd")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.AttribSortNo).HasColumnName("attribSortNo");

                entity.Property(e => e.AttribUsing)
                    .IsRequired()
                    .HasColumnName("attribUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblItemBuyseq>(entity =>
            {
                entity.HasKey(e => new { e.Baseitem, e.Targetitem });

                entity.ToTable("tbl_item_buyseq");

                entity.Property(e => e.Baseitem).HasColumnName("baseitem");

                entity.Property(e => e.Targetitem).HasColumnName("targetitem");

                entity.Property(e => e.Frequence).HasColumnName("frequence");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblItemBuyseqTmp>(entity =>
            {
                entity.HasKey(e => new { e.Baseitem, e.Targetitem });

                entity.ToTable("tbl_item_buyseq_tmp");

                entity.Property(e => e.Baseitem).HasColumnName("baseitem");

                entity.Property(e => e.Targetitem).HasColumnName("targetitem");

                entity.Property(e => e.Frequence).HasColumnName("frequence");
            });

            modelBuilder.Entity<TblItemCategory>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.CodeLarge, e.CodeMid, e.CodeSmall })
                    .HasName("PK__tbl_Item_categor__5AA469F6");

                entity.ToTable("tbl_Item_category");

                entity.HasIndex(e => new { e.Itemid, e.CodeLarge })
                    .HasName("IX_tbl_item_category_itemid_code_large");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.CodeLarge)
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeMid)
                    .HasColumnName("code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeSmall)
                    .HasColumnName("code_small")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeDiv)
                    .IsRequired()
                    .HasColumnName("code_div")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<TblItemChannel>(entity =>
            {
                entity.HasKey(e => e.Channel)
                    .HasName("PK__tbl_item_channel__5708E33C");

                entity.ToTable("tbl_item_channel");

                entity.Property(e => e.Channel)
                    .HasColumnName("channel")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChannelNm)
                    .IsRequired()
                    .HasColumnName("channel_nm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayYn)
                    .IsRequired()
                    .HasColumnName("display_yn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblItemColorOption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.ColorCode })
                    .HasName("PK__tbl_item_colorOp__4C764630");

                entity.ToTable("tbl_item_colorOption");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.ColorCode).HasColumnName("colorCode");

                entity.Property(e => e.BasicImage)
                    .HasColumnName("basicImage")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage1000)
                    .HasColumnName("basicImage1000")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage600)
                    .HasColumnName("basicImage600")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Icon1image)
                    .HasColumnName("icon1image")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2image)
                    .HasColumnName("icon2image")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0000')");

                entity.Property(e => e.Listimage)
                    .HasColumnName("listimage")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Listimage120)
                    .HasColumnName("listimage120")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Smallimage)
                    .HasColumnName("smallimage")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemContents>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_item_Contents");

                entity.HasIndex(e => new { e.Recentsellcount, e.Itemid })
                    .HasName("IX_tbl_item_contents_item");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Addbox)
                    .HasColumnName("addbox")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Addcarve)
                    .HasColumnName("addcarve")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Addcustom)
                    .HasColumnName("addcustom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Addmsg)
                    .HasColumnName("addmsg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Addset)
                    .HasColumnName("addset")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AvgDlvDate)
                    .HasColumnName("avgDlvDate")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Designercomment)
                    .HasColumnName("designercomment")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Favcount)
                    .HasColumnName("favcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FreightMax)
                    .HasColumnName("freight_max")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FreightMin)
                    .HasColumnName("freight_min")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InfoDiv)
                    .HasColumnName("infoDiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isbn10)
                    .HasColumnName("isbn10")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isbn13)
                    .HasColumnName("isbn13")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.IsbnSub)
                    .HasColumnName("isbn_sub")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Itemcontent)
                    .HasColumnName("itemcontent")
                    .HasColumnType("text");

                entity.Property(e => e.Itemsize)
                    .HasColumnName("itemsize")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemsource)
                    .HasColumnName("itemsource")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .IsRequired()
                    .HasColumnName("keywords")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Makername)
                    .IsRequired()
                    .HasColumnName("makername")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ordercomment)
                    .HasColumnName("ordercomment")
                    .HasColumnType("text");

                entity.Property(e => e.Qnacnt)
                    .HasColumnName("qnacnt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recentfavcount)
                    .HasColumnName("recentfavcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recentpcount)
                    .HasColumnName("recentpcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recentpoints)
                    .HasColumnName("recentpoints")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Recentsellcount)
                    .HasColumnName("recentsellcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RequireMakeDay).HasColumnName("requireMakeDay");

                entity.Property(e => e.SafetyDiv)
                    .HasColumnName("safetyDiv")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SafetyNum)
                    .HasColumnName("safetyNum")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SafetyYn)
                    .HasColumnName("safetyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Sellcount)
                    .HasColumnName("sellcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Sourcearea)
                    .IsRequired()
                    .HasColumnName("sourcearea")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Sourcekind).HasColumnName("sourcekind");

                entity.Property(e => e.Usinghtml)
                    .IsRequired()
                    .HasColumnName("usinghtml")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblItemCouponDetail>(entity =>
            {
                entity.HasKey(e => new { e.Itemcouponidx, e.Itemid });

                entity.ToTable("tbl_item_coupon_detail");

                entity.HasIndex(e => e.Itemid);

                entity.Property(e => e.Itemcouponidx).HasColumnName("itemcouponidx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Couponbuyprice)
                    .HasColumnName("couponbuyprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Couponmargin).HasColumnName("couponmargin");
            });

            modelBuilder.Entity<TblItemCouponMaster>(entity =>
            {
                entity.HasKey(e => e.Itemcouponidx);

                entity.ToTable("tbl_item_coupon_master");

                entity.HasIndex(e => new { e.CouponGubun, e.Openstate, e.Itemcouponstartdate, e.Itemcouponexpiredate })
                    .HasName("IX_tbl_item_coupon_masterToCNT_couponGubun_openstate_itemcouponstartdate_itemcouponexpiredate");

                entity.Property(e => e.Itemcouponidx).HasColumnName("itemcouponidx");

                entity.Property(e => e.Applyitemcount)
                    .HasColumnName("applyitemcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CouponGubun)
                    .HasColumnName("couponGubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.Coupontype)
                    .HasColumnName("coupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Defaultmargin)
                    .HasColumnName("defaultmargin")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.EvtgroupCode).HasColumnName("evtgroup_code");

                entity.Property(e => e.Itemcouponexpiredate)
                    .HasColumnName("itemcouponexpiredate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemcouponexplain)
                    .HasColumnName("itemcouponexplain")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemcouponimage)
                    .HasColumnName("itemcouponimage")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Itemcouponname)
                    .HasColumnName("itemcouponname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemcouponstartdate)
                    .HasColumnName("itemcouponstartdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemcoupontype)
                    .HasColumnName("itemcoupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemcouponvalue)
                    .HasColumnName("itemcouponvalue")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastupDt)
                    .HasColumnName("lastupDt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Margintype)
                    .HasColumnName("margintype")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('00')");

                entity.Property(e => e.Openstate)
                    .HasColumnName("openstate")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemDiv>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("tbl_item_div");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codename)
                    .IsRequired()
                    .HasColumnName("codename")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemEndlog>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_item__56A22C92E52B6A31");

                entity.ToTable("tbl_item_endlog");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Endtype).HasColumnName("endtype");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblItemGubun>(entity =>
            {
                entity.HasKey(e => e.Gubuncd);

                entity.ToTable("tbl_item_gubun");

                entity.Property(e => e.Gubuncd)
                    .HasColumnName("gubuncd")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gubunname)
                    .IsRequired()
                    .HasColumnName("gubunname")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemInfoCode>(entity =>
            {
                entity.HasKey(e => e.InfoCd)
                    .HasName("PK__tbl_item_infoCod__7D6E8346");

                entity.ToTable("tbl_item_infoCode");

                entity.Property(e => e.InfoCd)
                    .HasColumnName("infoCd")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InfoDesc)
                    .HasColumnName("infoDesc")
                    .IsUnicode(false);

                entity.Property(e => e.InfoDiv)
                    .IsRequired()
                    .HasColumnName("infoDiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InfoDivName)
                    .IsRequired()
                    .HasColumnName("infoDivName")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InfoItemName)
                    .IsRequired()
                    .HasColumnName("infoItemName")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InfoReq)
                    .IsRequired()
                    .HasColumnName("infoReq")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InfoSort).HasColumnName("infoSort");

                entity.Property(e => e.InfoType)
                    .IsRequired()
                    .HasColumnName("infoType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsUsing)
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblItemInfoCont>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.InfoCd })
                    .HasName("PK__tbl_item_infoCon__73E5190C");

                entity.ToTable("tbl_item_infoCont");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.InfoCd)
                    .HasColumnName("infoCd")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChkDiv)
                    .IsRequired()
                    .HasColumnName("chkDiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.InfoContent)
                    .HasColumnName("infoContent")
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.LastinputDt)
                    .HasColumnName("lastinputDt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblItemInfoDiv>(entity =>
            {
                entity.HasKey(e => e.InfoDiv);

                entity.ToTable("tbl_item_infoDiv");

                entity.Property(e => e.InfoDiv)
                    .HasColumnName("infoDiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InfoDivName)
                    .IsRequired()
                    .HasColumnName("infoDivName")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InfoValidCnt).HasColumnName("infoValidCnt");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Lastadminid)
                    .HasColumnName("lastadminid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SafetyCertYn)
                    .HasColumnName("SafetyCertYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SafetyComply)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SafetyConfirmYn)
                    .HasColumnName("SafetyConfirmYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SafetySupplyYn)
                    .HasColumnName("SafetySupplyYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SafetyTargetYn)
                    .HasColumnName("SafetyTargetYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblItemLogicsAddinfo>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_item_logics_addinfo");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasDefaultValueSql("('9999')");

                entity.Property(e => e.ItemManageType)
                    .HasColumnName("itemManageType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastcheckusersn)
                    .HasColumnName("lastcheckusersn")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SubItemRackcode)
                    .HasColumnName("subItemRackcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemMultiLang>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.CountryCd });

                entity.ToTable("tbl_item_multiLang");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.CountryCd)
                    .HasColumnName("countryCd")
                    .HasMaxLength(32);

                entity.Property(e => e.AreaCode11st)
                    .HasColumnName("areaCode11st")
                    .HasMaxLength(4);

                entity.Property(e => e.ItemContent)
                    .IsRequired()
                    .HasColumnName("itemContent")
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Itemcopy)
                    .IsRequired()
                    .HasColumnName("itemcopy")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Itemsize)
                    .HasColumnName("itemsize")
                    .HasMaxLength(128);

                entity.Property(e => e.Itemsource)
                    .HasColumnName("itemsource")
                    .HasMaxLength(128);

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(512);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Makername)
                    .HasColumnName("makername")
                    .HasMaxLength(64);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sourcearea)
                    .HasColumnName("sourcearea")
                    .HasMaxLength(128);

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblItemMultiLangOption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.CountryCd, e.Itemoption })
                    .HasName("PK_tbl_item_multiLang_option_1");

                entity.ToTable("tbl_item_multiLang_option");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.CountryCd)
                    .HasColumnName("countryCd")
                    .HasMaxLength(32);

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

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

                entity.Property(e => e.OptionTypeName)
                    .IsRequired()
                    .HasColumnName("optionTypeName")
                    .HasMaxLength(32);

                entity.Property(e => e.Optionname)
                    .HasColumnName("optionname")
                    .HasMaxLength(96);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblItemMultiLangPrice>(entity =>
            {
                entity.HasKey(e => new { e.Sitename, e.Itemid, e.CurrencyUnit });

                entity.ToTable("tbl_item_multiLang_price");

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(32);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.CurrencyUnit)
                    .HasColumnName("currencyUnit")
                    .HasMaxLength(16);

                entity.Property(e => e.LastexchangeRate)
                    .HasColumnName("lastexchangeRate")
                    .HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastuserid)
                    .HasColumnName("lastuserid")
                    .HasMaxLength(32);

                entity.Property(e => e.MaydiscountPrice)
                    .HasColumnName("maydiscountPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Orgprice)
                    .HasColumnName("orgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32);

                entity.Property(e => e.Wonprice)
                    .HasColumnName("wonprice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblItemMultiLangPriceTemp>(entity =>
            {
                entity.HasKey(e => new { e.Sitename, e.Itemid, e.CurrencyUnit });

                entity.ToTable("tbl_item_multiLang_price_temp");

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(32);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.CurrencyUnit)
                    .HasColumnName("currencyUnit")
                    .HasMaxLength(16);

                entity.Property(e => e.LastexchangeRate)
                    .HasColumnName("lastexchangeRate")
                    .HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastuserid)
                    .HasColumnName("lastuserid")
                    .HasMaxLength(32);

                entity.Property(e => e.MaydiscountPrice)
                    .HasColumnName("maydiscountPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Orgprice)
                    .HasColumnName("orgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32);

                entity.Property(e => e.Wonprice)
                    .HasColumnName("wonprice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblItemMultiSiteRegItem>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Sitename })
                    .HasName("PK_tbl_multilang_regItem");

                entity.ToTable("tbl_item_multiSite_regItem");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(32);

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
                    .HasMaxLength(32);

                entity.Property(e => e.Multilangcnt).HasColumnName("multilangcnt");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32);

                entity.Property(e => e.SiteScore).HasColumnName("siteScore");
            });

            modelBuilder.Entity<TblItemOption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption })
                    .HasName("PK_dbo_tbl_item_option");

                entity.ToTable("tbl_item_option");

                entity.HasIndex(e => e.Isusing);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Optaddbuyprice)
                    .HasColumnName("optaddbuyprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Optaddprice)
                    .HasColumnName("optaddprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OptionTypeName)
                    .IsRequired()
                    .HasColumnName("optionTypeName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Optionname)
                    .HasColumnName("optionname")
                    .HasMaxLength(96)
                    .IsUnicode(false);

                entity.Property(e => e.Optlimitno)
                    .HasColumnName("optlimitno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Optlimitsold)
                    .HasColumnName("optlimitsold")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Optlimityn)
                    .IsRequired()
                    .HasColumnName("optlimityn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Optrackcode)
                    .HasColumnName("optrackcode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Optsellyn)
                    .IsRequired()
                    .HasColumnName("optsellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblItemOptionMultiple>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.TypeSeq, e.KindSeq });

                entity.ToTable("tbl_item_option_Multiple");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.KindSeq)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Optaddbuyprice)
                    .HasColumnName("optaddbuyprice")
                    .HasColumnType("money");

                entity.Property(e => e.Optaddprice)
                    .HasColumnName("optaddprice")
                    .HasColumnType("money");

                entity.Property(e => e.OptionKindName)
                    .IsRequired()
                    .HasColumnName("optionKindName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OptionTypeName)
                    .IsRequired()
                    .HasColumnName("optionTypeName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemOptionStock>(entity =>
            {
                entity.HasKey(e => new { e.Itemgubun, e.Itemid, e.Itemoption });

                entity.ToTable("tbl_item_option_stock");

                entity.HasIndex(e => e.Barcode);

                entity.Property(e => e.Itemgubun)
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Currstockno)
                    .HasColumnName("currstockno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Limitsellno)
                    .HasColumnName("limitsellno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Limitsellyn)
                    .HasColumnName("limitsellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Limitsoldno)
                    .HasColumnName("limitsoldno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Stockreipgodate)
                    .HasColumnName("stockreipgodate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Upcheitemcode)
                    .HasColumnName("upcheitemcode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Upchemanagecode)
                    .HasColumnName("upchemanagecode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Upcheoptioncode)
                    .HasColumnName("upcheoptioncode")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemPackVolumn>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_item_pack_Volumn");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lastupdt)
                    .HasColumnName("lastupdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VolX).HasColumnName("volX");

                entity.Property(e => e.VolY).HasColumnName("volY");

                entity.Property(e => e.VolZ).HasColumnName("volZ");
            });

            modelBuilder.Entity<TblItemQuickdlv>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_item_quickdlv");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblItemQuickdlvAvailable>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK_tbl_item_quickdlv_valid");

                entity.ToTable("tbl_item_quickdlv_available");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastuserid)
                    .IsRequired()
                    .HasColumnName("lastuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemQuickdlvInvalid>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_item_quickdlv_invalid");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastuserid)
                    .IsRequired()
                    .HasColumnName("lastuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemRelation>(entity =>
            {
                entity.HasKey(e => new { e.MainItemid, e.SubItemid })
                    .HasName("PK__tbl_item_Relatio__3DBE1285");

                entity.ToTable("tbl_item_Relation");

                entity.Property(e => e.MainItemid).HasColumnName("mainItemid");

                entity.Property(e => e.SubItemid).HasColumnName("subItemid");
            });

            modelBuilder.Entity<TblItemSaleInfo>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_item_saleInf__29572725");

                entity.ToTable("tbl_item_saleInfo");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LastRegId)
                    .IsRequired()
                    .HasColumnName("lastRegId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblItemSellReserve>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_item_sellReserve");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Canceldate)
                    .HasColumnName("canceldate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regid)
                    .IsRequired()
                    .HasColumnName("regid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sellreservedate)
                    .HasColumnName("sellreservedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sellstartdate)
                    .HasColumnName("sellstartdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblItemStandingItem>(entity =>
            {
                entity.HasKey(e => new { e.Orgitemid, e.Orgitemoption });

                entity.ToTable("tbl_item_standing_item");

                entity.Property(e => e.Orgitemid).HasColumnName("orgitemid");

                entity.Property(e => e.Orgitemoption)
                    .HasColumnName("orgitemoption")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endreserveidx).HasColumnName("endreserveidx");

                entity.Property(e => e.Startreserveidx).HasColumnName("startreserveidx");
            });

            modelBuilder.Entity<TblItemStandingOrder>(entity =>
            {
                entity.HasKey(e => new { e.Orgitemid, e.Orgitemoption, e.Reserveidx });

                entity.ToTable("tbl_item_standing_order");

                entity.Property(e => e.Orgitemid).HasColumnName("orgitemid");

                entity.Property(e => e.Orgitemoption)
                    .HasColumnName("orgitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Reserveidx).HasColumnName("reserveidx");

                entity.Property(e => e.Lastadminid)
                    .IsRequired()
                    .HasColumnName("lastadminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regadminid)
                    .IsRequired()
                    .HasColumnName("regadminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReserveDlvDate)
                    .HasColumnName("reserveDlvDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveItemGubun)
                    .HasColumnName("reserveItemGubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveItemId).HasColumnName("reserveItemID");

                entity.Property(e => e.ReserveItemName)
                    .HasColumnName("reserveItemName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveItemOption)
                    .HasColumnName("reserveItemOption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SendkeyX).HasColumnName("sendkey_x");

                entity.Property(e => e.TotalsendkeyX)
                    .HasColumnName("totalsendkey_x")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblItemStandingOrderLog>(entity =>
            {
                entity.HasKey(e => e.Logidx);

                entity.ToTable("tbl_item_standing_order_log");

                entity.Property(e => e.Logidx).HasColumnName("logidx");

                entity.Property(e => e.Orgitemid).HasColumnName("orgitemid");

                entity.Property(e => e.Orgitemoption)
                    .IsRequired()
                    .HasColumnName("orgitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Regadminid)
                    .IsRequired()
                    .HasColumnName("regadminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReserveDlvDate)
                    .HasColumnName("reserveDlvDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveItemGubun)
                    .HasColumnName("reserveItemGubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveItemId).HasColumnName("reserveItemID");

                entity.Property(e => e.ReserveItemName)
                    .HasColumnName("reserveItemName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReserveItemOption)
                    .HasColumnName("reserveItemOption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Reserveidx).HasColumnName("reserveidx");

                entity.Property(e => e.Sendkey).HasColumnName("sendkey");

                entity.Property(e => e.Totalsendkey).HasColumnName("totalsendkey");
            });

            modelBuilder.Entity<TblItemStandingUser>(entity =>
            {
                entity.HasKey(e => e.Uidx);

                entity.ToTable("tbl_item_standing_user");

                entity.HasIndex(e => e.Orgitemid)
                    .HasName("IX_orgitemid");

                entity.HasIndex(e => e.Orgitemoption)
                    .HasName("IX_orgitemoption");

                entity.HasIndex(e => e.Reserveidx)
                    .HasName("IX_reserveidx");

                entity.Property(e => e.Uidx).HasColumnName("uidx");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Itemno)
                    .HasColumnName("itemno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jukyogubun)
                    .IsRequired()
                    .HasColumnName("jukyogubun")
                    .HasMaxLength(16);

                entity.Property(e => e.Lastadminid)
                    .IsRequired()
                    .HasColumnName("lastadminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orgitemid).HasColumnName("orgitemid");

                entity.Property(e => e.Orgitemoption)
                    .IsRequired()
                    .HasColumnName("orgitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Rebeasongbeforeuidx).HasColumnName("rebeasongbeforeuidx");

                entity.Property(e => e.Regadminid)
                    .IsRequired()
                    .HasColumnName("regadminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reqzipaddr)
                    .HasColumnName("reqzipaddr")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Reserveidx).HasColumnName("reserveidx");

                entity.Property(e => e.Senddate)
                    .HasColumnName("senddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SendkeyX).HasColumnName("sendkey_x");

                entity.Property(e => e.Sendstatus).HasColumnName("sendstatus");

                entity.Property(e => e.Sudongmachinguidx).HasColumnName("sudongmachinguidx");

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

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userphone)
                    .HasColumnName("userphone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemVideos>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_item_videos");

                entity.HasIndex(e => e.Itemid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Modifydate)
                    .HasColumnName("modifydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Videofullurl)
                    .HasColumnName("videofullurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Videogubun)
                    .HasColumnName("videogubun")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Videoheight).HasColumnName("videoheight");

                entity.Property(e => e.Videotype)
                    .HasColumnName("videotype")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Videourl)
                    .HasColumnName("videourl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Videowidth).HasColumnName("videowidth");
            });

            modelBuilder.Entity<TblItemVolumn>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption });

                entity.ToTable("tbl_item_Volumn");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemWeight).HasColumnName("itemWeight");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VolX).HasColumnName("volX");

                entity.Property(e => e.VolY).HasColumnName("volY");

                entity.Property(e => e.VolZ).HasColumnName("volZ");
            });

            modelBuilder.Entity<TblIthinksoCategoryInfo>(entity =>
            {
                entity.HasKey(e => e.CateSeq)
                    .HasName("PK__tbl_CategoryInfo__33D4B598");

                entity.ToTable("tbl_ithinkso_CategoryInfo");

                entity.HasIndex(e => e.CateTypeSeq)
                    .HasName("IX_CateTypeSeq");

                entity.HasIndex(e => e.SubCateSeq1)
                    .HasName("IX_subCateSeq1");

                entity.HasIndex(e => e.SubCateSeq2)
                    .HasName("IX_subCateSeq2");

                entity.Property(e => e.CateName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubCateSeq1).HasColumnName("subCateSeq1");

                entity.Property(e => e.SubCateSeq2).HasColumnName("subCateSeq2");
            });

            modelBuilder.Entity<TblIthinksoCategoryType>(entity =>
            {
                entity.HasKey(e => e.CateTypeSeq)
                    .HasName("PK__tbl_CategoryType__7D78A4E7");

                entity.ToTable("tbl_ithinkso_CategoryType");

                entity.Property(e => e.CateTypeName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblIthinksoCategoryWp>(entity =>
            {
                entity.HasKey(e => e.CateInfoSeq)
                    .HasName("PK_tbl_ithinkso_CategoryInfo");

                entity.ToTable("tbl_ithinkso_CategoryWP");

                entity.Property(e => e.CateInfoImg)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.ItemserialLarge)
                    .IsRequired()
                    .HasColumnName("itemserial_large")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemserialMid)
                    .IsRequired()
                    .HasColumnName("itemserial_mid")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemserialSmall)
                    .IsRequired()
                    .HasColumnName("itemserial_small")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblIthinksoCategoryitem>(entity =>
            {
                entity.HasKey(e => e.CateDispSeq)
                    .HasName("PK_tbl_Category_Display");

                entity.ToTable("tbl_ithinkso_Categoryitem");

                entity.HasIndex(e => e.CateSeq1)
                    .HasName("IX_CateSeq1");

                entity.HasIndex(e => e.CateSeq2)
                    .HasName("IX_CateSeq2");

                entity.HasIndex(e => e.CateSeq3)
                    .HasName("IX_CateSeq3");

                entity.HasIndex(e => e.CateTypeSeq)
                    .HasName("IX_CateTypeSeq");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblIthinksoRecipe>(entity =>
            {
                entity.HasKey(e => e.RecipeSeq);

                entity.ToTable("tbl_ithinkso_Recipe");

                entity.Property(e => e.Hit).HasDefaultValueSql("(0)");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.RecipeBanner)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecipeHtml).HasColumnType("text");

                entity.Property(e => e.RecipeImgUrl)
                    .HasColumnName("RecipeImgURL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecipeTitle)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblKaffaBrandMapping>(entity =>
            {
                entity.HasKey(e => e.TenMakerid)
                    .HasName("PK__tbl_kaffa_brand___30B91D22");

                entity.ToTable("tbl_kaffa_brand_mapping");

                entity.Property(e => e.TenMakerid)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.KaffaMakerid).HasColumnName("kaffaMakerid");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblKaffaCategory>(entity =>
            {
                entity.HasKey(e => new { e.Cate1, e.Cate2, e.Cate3 });

                entity.ToTable("tbl_kaffa_category");

                entity.Property(e => e.Cate1)
                    .HasColumnName("cate1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cate2)
                    .HasColumnName("cate2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cate3)
                    .HasColumnName("cate3")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CateNm)
                    .IsRequired()
                    .HasColumnName("cate_nm")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblKaffaCategoryMapping>(entity =>
            {
                entity.HasKey(e => new { e.Tencdl, e.Tencdm, e.Tencds });

                entity.ToTable("tbl_kaffa_category_mapping");

                entity.Property(e => e.Tencdl)
                    .HasColumnName("tencdl")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tencdm)
                    .HasColumnName("tencdm")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tencds)
                    .HasColumnName("tencds")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Kaffacate1)
                    .IsRequired()
                    .HasColumnName("kaffacate1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Kaffacate2)
                    .IsRequired()
                    .HasColumnName("kaffacate2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Kaffacate3)
                    .IsRequired()
                    .HasColumnName("kaffacate3")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblKaffaDiscountItem>(entity =>
            {
                entity.HasKey(e => new { e.DiscountKey, e.Itemid });

                entity.ToTable("tbl_kaffa_Discount_Item");

                entity.Property(e => e.DiscountKey).HasColumnName("discountKey");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.DiscountPrice)
                    .HasColumnName("discountPrice")
                    .HasColumnType("money");

                entity.Property(e => e.DiscountbuyMoney)
                    .HasColumnName("discountbuyMoney")
                    .HasColumnType("money");

                entity.Property(e => e.ExpiredDate)
                    .HasColumnName("expiredDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpUserId)
                    .HasColumnName("lastUpUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegUserId)
                    .HasColumnName("regUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblKaffaDiscountList>(entity =>
            {
                entity.HasKey(e => e.DiscountKey);

                entity.ToTable("tbl_kaffa_Discount_List");

                entity.Property(e => e.DiscountKey).HasColumnName("discountKey");

                entity.Property(e => e.DiscountPro).HasColumnName("discountPro");

                entity.Property(e => e.DiscountTitle)
                    .IsRequired()
                    .HasColumnName("discountTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountbuyPro).HasColumnName("discountbuyPro");

                entity.Property(e => e.DiscountbuyRule).HasColumnName("discountbuyRule");

                entity.Property(e => e.EdDt)
                    .HasColumnName("edDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate)
                    .HasColumnName("expiredDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpUserId)
                    .HasColumnName("lastUpUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OpenDate)
                    .HasColumnName("openDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PromotionType).HasColumnName("promotionType");

                entity.Property(e => e.RegUserId)
                    .HasColumnName("regUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StDt)
                    .HasColumnName("stDT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblKaffaRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_kaffa_reg_item");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt).HasColumnName("accFailCnt");

                entity.Property(e => e.KaffaConsumerPrice)
                    .HasColumnName("kaffaConsumerPrice")
                    .HasColumnType("money");

                entity.Property(e => e.KaffaDiscountBeginDateTime)
                    .HasColumnName("kaffaDiscount_Begin_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.KaffaDiscountEndDateTime)
                    .HasColumnName("kaffaDiscount_End_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.KaffaDiscountPrice)
                    .HasColumnName("kaffaDiscountPrice")
                    .HasColumnType("money");

                entity.Property(e => e.KaffaDiscountRate).HasColumnName("kaffaDiscountRate");

                entity.Property(e => e.KaffaGoodNo).HasColumnName("kaffaGoodNo");

                entity.Property(e => e.KaffaIsDeleted).HasColumnName("kaffaIsDeleted");

                entity.Property(e => e.KaffaIsDisplay).HasColumnName("kaffaIsDisplay");

                entity.Property(e => e.KaffaIsShippingfree).HasColumnName("kaffaIsShippingfree");

                entity.Property(e => e.KaffaMaxium).HasColumnName("kaffaMaxium");

                entity.Property(e => e.KaffaMinimum).HasColumnName("kaffaMinimum");

                entity.Property(e => e.KaffaPrice)
                    .HasColumnName("kaffaPrice")
                    .HasColumnType("money");

                entity.Property(e => e.KaffaRegDateTime)
                    .HasColumnName("kaffaRegDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.KaffaSellyn)
                    .HasColumnName("kaffaSellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KaffaSuplyPrice)
                    .HasColumnName("kaffaSuplyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.KaffaWeight).HasColumnName("kaffaWeight");

                entity.Property(e => e.Kaffamakerid).HasColumnName("kaffamakerid");

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OptAddPrcCnt).HasColumnName("optAddPrcCnt");

                entity.Property(e => e.OptAddPrcRegType).HasColumnName("optAddPrcRegType");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegedoptCnt).HasColumnName("regedoptCnt");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('n')");
            });

            modelBuilder.Entity<TblKeywordDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_keyword_detail");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Midx).HasColumnName("midx");

                entity.Property(e => e.Submitkeyword)
                    .HasColumnName("submitkeyword")
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblKeywordMaster>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_keyword_master");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Etc)
                    .HasColumnName("etc")
                    .HasColumnType("text");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasColumnName("mode")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nextkeyword)
                    .HasColumnName("nextkeyword")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prekeyword)
                    .HasColumnName("prekeyword")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regid)
                    .IsRequired()
                    .HasColumnName("regid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLotteBrandMapping>(entity =>
            {
                entity.HasKey(e => e.TenMakerid)
                    .HasName("PK__tbl_lotte_brand___11AA861D");

                entity.ToTable("tbl_lotte_brand_mapping");

                entity.Property(e => e.TenMakerid)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LotteBrandCd).HasColumnName("lotteBrandCD");

                entity.Property(e => e.LotteBrandName)
                    .HasColumnName("lotteBrandName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblLotteCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DispNo, e.TenCateLarge, e.TenCateMid, e.TenCateSmall })
                    .HasName("PK__tbl_lotte_cate_m__157B1701");

                entity.ToTable("tbl_lotte_cate_mapping");

                entity.Property(e => e.DispNo)
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblLotteMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_lotte_material");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Mallid)
                    .IsRequired()
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MallinfoDiv)
                    .IsRequired()
                    .HasColumnName("mallinfoDiv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasColumnName("material")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLotteRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_lotte_regIte__1F04813B");

                entity.ToTable("tbl_lotte_regItem");

                entity.HasIndex(e => e.LastStatCheckDate);

                entity.HasIndex(e => e.LotteTmpGoodNo);

                entity.HasIndex(e => e.TnLastupdate)
                    .HasName("IX_tbl_lotte_regItem_tnLastUpdate");

                entity.HasIndex(e => new { e.Itemid, e.LotteLastUpdate, e.LastStatCheckDate, e.LotteSellYn, e.LotteGoodNo })
                    .HasName("IX_tbl_lotte_regItem_LotteGoodNo");

                entity.HasIndex(e => new { e.Itemid, e.LotteLastUpdate, e.LottePrice, e.LotteRegdate, e.LotteStatCd, e.LotteTmpGoodNo, e.OptAddPrcCnt, e.OptAddPrcRegType, e.RctSellCnt, e.Regdate, e.Reguserid, e.LotteGoodNo, e.LotteSellYn })
                    .HasName("IX_tbl_lotte_regItem_LotteGoodNo_LotteSellYn");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemTableUpdateChkdate)
                    .HasColumnName("itemTableUpdateChkdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastConfirmdate)
                    .HasColumnName("lastConfirmdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastcateChgDate)
                    .HasColumnName("lastcateChgDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LotteLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LottePrice).HasColumnType("money");

                entity.Property(e => e.LotteRegdate).HasColumnType("datetime");

                entity.Property(e => e.LotteSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LotteStatCd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('10')");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegedOptCnt).HasColumnName("regedOptCnt");

                entity.Property(e => e.Regitemname)
                    .HasColumnName("regitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TnLastupdate)
                    .HasColumnName("tnLastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLotteimallCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DispNo, e.TenCateLarge, e.TenCateMid, e.TenCateSmall })
                    .HasName("PK__tbl_lotteimall_cate_m__257C74A0");

                entity.ToTable("tbl_lotteimall_cate_mapping");

                entity.Property(e => e.DispNo)
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblLtiMallCateGbnMapping>(entity =>
            {
                entity.HasKey(e => new { e.TenCateLarge, e.TenCateMid, e.TenCateSmall })
                    .HasName("PK__tbl_LTiMall_cateGbn_mapping");

                entity.ToTable("tbl_LTiMall_cateGbn_mapping");

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CateKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblLtiMallCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall })
                    .HasName("PK__tbl_LTiMall_cate_mapping");

                entity.ToTable("tbl_LTiMall_cate_mapping");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblLtiMallRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_LTiMall_regItem");

                entity.ToTable("tbl_LTiMall_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastConfirmdate)
                    .HasColumnName("lastConfirmdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LtiMallGoodNo)
                    .HasColumnName("LTiMallGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LtiMallLastUpdate)
                    .HasColumnName("LTiMallLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LtiMallPrice)
                    .HasColumnName("LTiMallPrice")
                    .HasColumnType("money");

                entity.Property(e => e.LtiMallRegdate)
                    .HasColumnName("LTiMallRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LtiMallSellYn)
                    .IsRequired()
                    .HasColumnName("LTiMallSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LtiMallStatCd).HasColumnName("LTiMallStatCd");

                entity.Property(e => e.LtiMallTmpGoodNo)
                    .HasColumnName("LTiMallTmpGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegedOptCnt).HasColumnName("regedOptCnt");

                entity.Property(e => e.Regitemname)
                    .HasColumnName("regitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMakeglobCateMatching>(entity =>
            {
                entity.HasKey(e => new { e.MgCateCd, e.DispCate, e.Makerid })
                    .HasName("PK__tbl_make__D1B1A8B0630F39FA");

                entity.ToTable("tbl_makeglob_Cate_matching");

                entity.Property(e => e.MgCateCd).HasColumnName("MG_cateCd");

                entity.Property(e => e.DispCate).HasColumnName("dispCate");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblMakeglobCategory>(entity =>
            {
                entity.HasKey(e => e.MgCateCd)
                    .HasName("PK__tbl_make__5ADE9D6415AB1331");

                entity.ToTable("tbl_makeglob_Category");

                entity.Property(e => e.MgCateCd)
                    .HasColumnName("MG_cateCd")
                    .ValueGeneratedNever();

                entity.Property(e => e.CateNm)
                    .HasColumnName("cateNm")
                    .HasMaxLength(40);

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParentCd).HasColumnName("parentCd");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");
            });

            modelBuilder.Entity<TblMakeglobProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductKey, e.ProductCode });

                entity.ToTable("tbl_makeglob_product");

                entity.Property(e => e.ProductKey)
                    .HasColumnName("product_key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.Basic1000ImgUrl)
                    .HasColumnName("basic1000_img_url")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Basic600ImgUrl)
                    .HasColumnName("basic600_img_url")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brand_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cateindex)
                    .HasColumnName("cateindex")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .IsUnicode(false);

                entity.Property(e => e.DetailImgUrl)
                    .HasColumnName("detail_img_url")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Hidden)
                    .IsRequired()
                    .HasColumnName("hidden")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemsize)
                    .HasColumnName("itemsize")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Itemsource)
                    .HasColumnName("itemsource")
                    .IsUnicode(false);

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LaunchingDate)
                    .HasColumnName("launching_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ListImgUrl)
                    .HasColumnName("list_img_url")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Madein)
                    .HasColumnName("madein")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MakeglobYn)
                    .HasColumnName("makeglobYN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MakerName)
                    .HasColumnName("maker_name")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Makeupdate)
                    .HasColumnName("makeupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ManufactureDate)
                    .HasColumnName("manufacture_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mileage).HasColumnName("mileage");

                entity.Property(e => e.OriginalPrice)
                    .HasColumnName("original_price")
                    .HasColumnType("money");

                entity.Property(e => e.PdtStock).HasColumnName("pdt_stock");

                entity.Property(e => e.ProductLanguage)
                    .IsRequired()
                    .HasColumnName("product_language")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("product_name")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("product_price")
                    .HasColumnType("money");

                entity.Property(e => e.ProductUrl)
                    .HasColumnName("product_url")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Soldout)
                    .IsRequired()
                    .HasColumnName("soldout")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplyPrice)
                    .HasColumnName("supply_price")
                    .HasColumnType("money");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.ZoomImgUrl)
                    .HasColumnName("zoom_img_url")
                    .HasMaxLength(800)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMakeglobProductOption>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.ProductKey, e.ProductCode });

                entity.ToTable("tbl_makeglob_product_option");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductKey).HasColumnName("product_key");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.Hidden)
                    .HasColumnName("hidden")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OptionIndexName)
                    .HasColumnName("option_index_name")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OptionIndexPrice)
                    .HasColumnName("option_index_price")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OptionIndexValue)
                    .HasColumnName("option_index_value")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Soldout)
                    .HasColumnName("soldout")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.Property(e => e.Tenoptioncode)
                    .HasColumnName("tenoptioncode")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblMileageshopItem>(entity =>
            {
                entity.HasKey(e => e.MileageShopItemId);

                entity.ToTable("tbl_Mileageshop_Item");

                entity.Property(e => e.MileageShopItemId)
                    .HasColumnName("mileageShopItemId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblOptionDiv01>(entity =>
            {
                entity.HasKey(e => e.Optioncode01);

                entity.ToTable("tbl_option_div01");

                entity.HasIndex(e => e.Disporder);

                entity.Property(e => e.Optioncode01)
                    .HasColumnName("optioncode01")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codename)
                    .IsRequired()
                    .HasColumnName("codename")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Disporder)
                    .HasColumnName("disporder")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Optiondispyn)
                    .HasColumnName("optiondispyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblOptionDiv02>(entity =>
            {
                entity.HasKey(e => new { e.Optioncode01, e.Optioncode02 });

                entity.ToTable("tbl_option_div02");

                entity.HasIndex(e => e.Disporder);

                entity.Property(e => e.Optioncode01)
                    .HasColumnName("optioncode01")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Optioncode02)
                    .HasColumnName("optioncode02")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codevalue)
                    .IsRequired()
                    .HasColumnName("codevalue")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Codeview)
                    .IsRequired()
                    .HasColumnName("codeview")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Disporder)
                    .HasColumnName("disporder")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Optiondispyn)
                    .HasColumnName("optiondispyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblOutMallBrandReturnCode>(entity =>
            {
                entity.HasKey(e => new { e.Mallid, e.Makerid });

                entity.ToTable("tbl_OutMall_BrandReturnCode");

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnCode)
                    .IsRequired()
                    .HasColumnName("returnCode")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutMallCateMapSummary>(entity =>
            {
                entity.HasKey(e => new { e.Mallid, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_OutMall_CateMap_Summary");

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MapCnt).HasColumnName("mapCnt");
            });

            modelBuilder.Entity<TblOutMallEtcLink>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Mallid, e.Linkgbn });

                entity.ToTable("tbl_OutMall_etcLink");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Linkgbn)
                    .HasColumnName("linkgbn")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EdDt)
                    .HasColumnName("edDt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Intval).HasColumnName("intval");

                entity.Property(e => e.Linkyn)
                    .IsRequired()
                    .HasColumnName("linkyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MadeDate)
                    .HasColumnName("madeDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShortVal)
                    .HasColumnName("shortVal")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.StDt)
                    .HasColumnName("stDt")
                    .HasColumnType("datetime");

                entity.Property(e => e.TextVal)
                    .HasColumnName("textVal")
                    .HasColumnType("text");

                entity.Property(e => e.UseDate)
                    .HasColumnName("useDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Valtype).HasColumnName("valtype");
            });

            modelBuilder.Entity<TblOutMallEtcLinkGubun>(entity =>
            {
                entity.HasKey(e => e.Linkgbn);

                entity.ToTable("tbl_OutMall_etcLinkGubun");

                entity.Property(e => e.Linkgbn)
                    .HasColumnName("linkgbn")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LinkDesc)
                    .HasColumnName("linkDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Valtype).HasColumnName("valtype");
            });

            modelBuilder.Entity<TblOutMallInfoCodeMap>(entity =>
            {
                entity.HasKey(e => new { e.Mallid, e.MallinfoCd, e.MallinfoDiv });

                entity.ToTable("tbl_OutMall_infoCodeMap");

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MallinfoCd)
                    .HasColumnName("mallinfoCd")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.MallinfoDiv)
                    .HasColumnName("mallinfoDiv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCd)
                    .IsRequired()
                    .HasColumnName("infoCd")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InfoCdAdd)
                    .HasColumnName("infoCdAdd")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InfoEtc)
                    .HasColumnName("infoETC")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutMallRegedoption>(entity =>
            {
                entity.HasKey(e => new { e.Mallid, e.Itemid, e.Itemoption })
                    .HasName("PK_tbl_LTiMall_regoption");

                entity.ToTable("tbl_OutMall_regedoption");

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Checkdate)
                    .HasColumnName("checkdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OutmallAddPrice)
                    .HasColumnName("outmallAddPrice")
                    .HasColumnType("money");

                entity.Property(e => e.OutmallOptCode)
                    .IsRequired()
                    .HasColumnName("outmallOptCode")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OutmallOptName)
                    .HasColumnName("outmallOptName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OutmallSellyn)
                    .IsRequired()
                    .HasColumnName("outmallSellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.OutmallleadTime)
                    .HasColumnName("outmallleadTime")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Outmalllimitno).HasColumnName("outmalllimitno");

                entity.Property(e => e.Outmalllimityn)
                    .IsRequired()
                    .HasColumnName("outmalllimityn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutmallsuppPrc)
                    .HasColumnName("outmallsuppPrc")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblOutmallRdsiteGubun>(entity =>
            {
                entity.HasKey(e => new { e.Gubun, e.Rdsite });

                entity.ToTable("tbl_Outmall_RdsiteGubun");

                entity.Property(e => e.Gubun)
                    .HasColumnName("gubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Rdsite)
                    .HasColumnName("rdsite")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Explain)
                    .HasColumnName("explain")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ischarge)
                    .IsRequired()
                    .HasColumnName("ischarge")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ismobile).HasColumnName("ismobile");
            });

            modelBuilder.Entity<TblPhotoAuthItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_photo_authItem");

                entity.Property(e => e.Itemid).HasColumnName("itemid");
            });

            modelBuilder.Entity<TblPlusSaleLinkItemList>(entity =>
            {
                entity.HasKey(e => new { e.PlusSaleItemId, e.PlusSaleLinkItemId })
                    .HasName("PK_tbl_SetSaleLinkItemList");

                entity.ToTable("tbl_PlusSaleLinkItemList");

                entity.HasIndex(e => e.PlusSaleLinkItemId);

                entity.Property(e => e.PlusSaleItemId).HasColumnName("plusSaleItemID");

                entity.Property(e => e.PlusSaleLinkItemId).HasColumnName("plusSaleLinkItemID");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblPlusSaleRegedItem>(entity =>
            {
                entity.HasKey(e => e.PlusSaleItemId)
                    .HasName("PK_tbl_SetSaleRegedItem");

                entity.ToTable("tbl_PlusSaleRegedItem");

                entity.Property(e => e.PlusSaleItemId)
                    .HasColumnName("plusSaleItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PlusSaleEndDate)
                    .HasColumnName("plusSaleEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlusSaleMaginFlag)
                    .IsRequired()
                    .HasColumnName("plusSaleMaginFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlusSaleMargin)
                    .HasColumnName("plusSaleMargin")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PlusSalePro)
                    .HasColumnName("plusSalePro")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PlusSaleStartDate)
                    .HasColumnName("plusSaleStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblPublicBarcodeReserved>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_public_Barcode_reserved_1");

                entity.ToTable("tbl_public_Barcode_reserved");

                entity.HasIndex(e => e.Barcode)
                    .HasName("IX_tbl_public_Barcode_reserved")
                    .IsUnique();

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasColumnName("barcode")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Itemgubun)
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReservedCont)
                    .HasColumnName("reservedCont")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReservedDate)
                    .HasColumnName("reservedDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSafetycertImage>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_safetycert_image");

                entity.HasIndex(e => e.Itemid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CertNum)
                    .HasColumnName("certNum")
                    .HasMaxLength(50);

                entity.Property(e => e.ImageUrls).HasMaxLength(150);

                entity.Property(e => e.Itemid).HasColumnName("itemid");
            });

            modelBuilder.Entity<TblSafetycertInfo>(entity =>
            {
                entity.HasKey(e => e.Infoidx)
                    .HasName("PK_tbl_satefycert_info_1");

                entity.ToTable("tbl_safetycert_info");

                entity.HasIndex(e => e.CertNum)
                    .HasName("IX_certNum");

                entity.HasIndex(e => e.Itemid)
                    .HasName("IX_itemid");

                entity.Property(e => e.Infoidx).HasColumnName("infoidx");

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(150);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(200);

                entity.Property(e => e.CertChgDate)
                    .HasColumnName("certChgDate")
                    .HasMaxLength(10);

                entity.Property(e => e.CertChgReason)
                    .HasColumnName("certChgReason")
                    .HasMaxLength(300);

                entity.Property(e => e.CertDate)
                    .HasColumnName("certDate")
                    .HasMaxLength(10);

                entity.Property(e => e.CertDiv)
                    .HasColumnName("certDiv")
                    .HasMaxLength(150);

                entity.Property(e => e.CertNum)
                    .IsRequired()
                    .HasColumnName("certNum")
                    .HasMaxLength(50);

                entity.Property(e => e.CertOrganName)
                    .HasColumnName("certOrganName")
                    .HasMaxLength(100);

                entity.Property(e => e.CertState)
                    .HasColumnName("certState")
                    .HasMaxLength(30);

                entity.Property(e => e.CertUid)
                    .HasColumnName("certUid")
                    .HasMaxLength(30);

                entity.Property(e => e.FirstCertNum)
                    .HasColumnName("firstCertNum")
                    .HasMaxLength(50);

                entity.Property(e => e.ImportDiv)
                    .HasColumnName("importDiv")
                    .HasMaxLength(70);

                entity.Property(e => e.ImporterName)
                    .HasColumnName("importerName")
                    .HasMaxLength(150);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MakerCntryName)
                    .HasColumnName("makerCntryName")
                    .HasMaxLength(70);

                entity.Property(e => e.MakerName)
                    .HasColumnName("makerName")
                    .HasMaxLength(150);

                entity.Property(e => e.ModelName)
                    .HasColumnName("modelName")
                    .HasMaxLength(100);

                entity.Property(e => e.ProductName)
                    .HasColumnName("productName")
                    .HasMaxLength(200);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblSafetycertTenReg>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.SafetyDiv })
                    .HasName("PK_tbl_safetycert_tenReg_1");

                entity.ToTable("tbl_safetycert_tenReg");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.SafetyDiv)
                    .HasColumnName("safetyDiv")
                    .HasMaxLength(3);

                entity.Property(e => e.CertNum)
                    .IsRequired()
                    .HasColumnName("certNum")
                    .HasMaxLength(50);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblShoplinkerOutmall>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Shoplinker_Outmall");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MallName)
                    .HasColumnName("mall_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MallProductId)
                    .HasColumnName("mall_product_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MallProductName)
                    .HasColumnName("mall_product_name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MallUserId)
                    .HasColumnName("mall_user_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalePrice).HasColumnName("sale_price");

                entity.Property(e => e.ShoplinkerId)
                    .HasColumnName("shoplinker_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplyPrice).HasColumnName("supply_price");
            });

            modelBuilder.Entity<TblShoplinkerOutmallControl>(entity =>
            {
                entity.HasKey(e => e.Makerid)
                    .HasName("PK_tbl_Shoplinker_OutmallControl_1");

                entity.ToTable("tbl_Shoplinker_OutmallControl");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultDeliverPay)
                    .HasColumnName("defaultDeliverPay")
                    .HasColumnType("money");

                entity.Property(e => e.DefaultFreeBeasongLimit)
                    .HasColumnName("defaultFreeBeasongLimit")
                    .HasColumnType("money");

                entity.Property(e => e.MallName)
                    .HasColumnName("mall_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MallUserId)
                    .IsRequired()
                    .HasColumnName("mall_user_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShoplinkerRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_Shoplinker_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertInfoCd)
                    .HasColumnName("insert_infoCD")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastConfirmdate)
                    .HasColumnName("lastConfirmdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegedOptCnt).HasColumnName("regedOptCnt");

                entity.Property(e => e.Regitemname)
                    .HasColumnName("regitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShoplinkerGoodNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShoplinkerLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ShoplinkerOutMallConnect)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShoplinkerPrice).HasColumnType("money");

                entity.Property(e => e.ShoplinkerRegdate).HasColumnType("datetime");

                entity.Property(e => e.ShoplinkerSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblSpecialShop>(entity =>
            {
                entity.ToTable("tbl_specialShop");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OpenDate)
                    .HasColumnName("openDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TblSpecialShopitem>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_specialShopitem");

                entity.HasIndex(e => e.Id);

                entity.HasIndex(e => e.Itemid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblTicketItemInfo>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_ticket_itemInfo");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingCharge)
                    .HasColumnName("bookingCharge")
                    .HasColumnType("money")
                    .HasComment("예매수수료");

                entity.Property(e => e.BookingEdDt)
                    .HasColumnName("bookingEdDt")
                    .HasColumnType("datetime");

                entity.Property(e => e.BookingStDt)
                    .HasColumnName("bookingStDt")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdDt)
                    .HasColumnName("edDt")
                    .HasColumnType("smalldatetime")
                    .HasComment("공연종료일");

                entity.Property(e => e.RefundInfoType).HasColumnName("refundInfoType");

                entity.Property(e => e.StDt)
                    .HasColumnName("stDt")
                    .HasColumnType("smalldatetime")
                    .HasComment("공연시작일");

                entity.Property(e => e.TicketDlvType).HasColumnName("ticketDlvType");

                entity.Property(e => e.TicketPlaceIdx).HasColumnName("ticketPlaceIdx");

                entity.Property(e => e.TxGenre)
                    .HasColumnName("txGenre")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("장르");

                entity.Property(e => e.TxGrade)
                    .HasColumnName("txGrade")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasComment("관람등급");

                entity.Property(e => e.TxRunTime)
                    .HasColumnName("txRunTime")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasComment("관람시간");

                entity.Property(e => e.TxplayTimInfo)
                    .HasColumnName("txplayTimInfo")
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTicketPlaceInfo>(entity =>
            {
                entity.HasKey(e => e.TicketPlaceIdx);

                entity.ToTable("tbl_ticket_placeInfo");

                entity.Property(e => e.TicketPlaceIdx).HasColumnName("ticketPlaceIdx");

                entity.Property(e => e.ParkingGuide)
                    .HasColumnName("parkingGuide")
                    .HasColumnType("text");

                entity.Property(e => e.PlaceContents)
                    .HasColumnName("placeContents")
                    .HasColumnType("text");

                entity.Property(e => e.PlaceImgUrl)
                    .HasColumnName("placeImgURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceLinkUrl)
                    .HasColumnName("placeLinkURL")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.PlacecontentsImage1)
                    .HasColumnName("placecontentsImage1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlacecontentsImage2)
                    .HasColumnName("placecontentsImage2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlacecontentsImage3)
                    .HasColumnName("placecontentsImage3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TPaddress)
                    .HasColumnName("tPAddress")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TPhomeUrl)
                    .HasColumnName("tPHomeURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TPtel)
                    .HasColumnName("tPTel")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TicketPlaceName)
                    .IsRequired()
                    .HasColumnName("ticketPlaceName")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTicketSchedule>(entity =>
            {
                entity.HasKey(e => new { e.TkItemid, e.TkItemoption });

                entity.ToTable("tbl_ticket_Schedule");

                entity.Property(e => e.TkItemid).HasColumnName("Tk_itemid");

                entity.Property(e => e.TkItemoption)
                    .HasColumnName("Tk_itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnExpireDate)
                    .HasColumnName("returnExpireDate")
                    .HasColumnType("datetime")
                    .HasComment("예매취소마감일");

                entity.Property(e => e.TkEdSchedule)
                    .HasColumnName("Tk_EdSchedule")
                    .HasColumnType("datetime");

                entity.Property(e => e.TkStSchedule)
                    .HasColumnName("Tk_StSchedule")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblTtlRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_ttl_reg_item");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserItemCoupon>(entity =>
            {
                entity.HasKey(e => e.Couponidx);

                entity.ToTable("tbl_user_item_coupon");

                entity.HasIndex(e => e.Itemcouponexpiredate);

                entity.HasIndex(e => e.Itemcouponidx);

                entity.HasIndex(e => e.Itemcouponstartdate);

                entity.HasIndex(e => e.Userid);

                entity.Property(e => e.Couponidx).HasColumnName("couponidx");

                entity.Property(e => e.CouponGubun)
                    .HasColumnName("couponGubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Issuedno)
                    .HasColumnName("issuedno")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Itemcouponexpiredate)
                    .HasColumnName("itemcouponexpiredate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemcouponidx).HasColumnName("itemcouponidx");

                entity.Property(e => e.Itemcouponimage)
                    .HasColumnName("itemcouponimage")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Itemcouponname)
                    .HasColumnName("itemcouponname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemcouponstartdate)
                    .HasColumnName("itemcouponstartdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemcoupontype)
                    .HasColumnName("itemcoupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.Itemcouponvalue)
                    .HasColumnName("itemcouponvalue")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Usedyn)
                    .HasColumnName("usedyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserItemCouponDownLog>(entity =>
            {
                entity.HasKey(e => e.Logidx);

                entity.ToTable("tbl_user_item_coupon_down_log");

                entity.Property(e => e.Logidx).HasColumnName("logidx");

                entity.Property(e => e.Couponidx).HasColumnName("couponidx");

                entity.Property(e => e.Downidx).HasColumnName("downidx");

                entity.Property(e => e.Itemcouponidx).HasColumnName("itemcouponidx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Regdt)
                    .HasColumnName("regdt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserItemCouponDownable>(entity =>
            {
                entity.HasKey(e => e.Downidx)
                    .IsClustered(false);

                entity.ToTable("tbl_user_item_coupon_downable");

                entity.HasIndex(e => new { e.Userid, e.Itemid, e.Expirestartdt, e.Expireenddt })
                    .HasName("IX_CL_tbl_user_item_coupon_downable")
                    .IsClustered();

                entity.Property(e => e.Downidx).HasColumnName("downidx");

                entity.Property(e => e.Couponbuyprice)
                    .HasColumnName("couponbuyprice")
                    .HasColumnType("money");

                entity.Property(e => e.Defaultmargin).HasColumnName("defaultmargin");

                entity.Property(e => e.Downstate)
                    .IsRequired()
                    .HasColumnName("downstate")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Expireenddt)
                    .HasColumnName("expireenddt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Expirestartdt)
                    .HasColumnName("expirestartdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemcoupontype)
                    .HasColumnName("itemcoupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemcouponvalue)
                    .HasColumnName("itemcouponvalue")
                    .HasColumnType("money");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Margintype)
                    .HasColumnName("margintype")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Regdt)
                    .HasColumnName("regdt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regtype).HasColumnName("regtype");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Testtable1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testtable1");

                entity.Property(e => e.C).HasColumnName("c");
            });

            modelBuilder.Entity<TrgTblItem>(entity =>
            {
                entity.HasKey(e => e.Logidx);

                entity.ToTable("trg_tbl_item");

                entity.Property(e => e.Logidx).HasColumnName("logidx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Logdate)
                    .HasColumnName("logdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrgMode)
                    .HasColumnName("trgMode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TrgTblItemContents>(entity =>
            {
                entity.HasKey(e => e.Logidx);

                entity.ToTable("trg_tbl_item_contents");

                entity.Property(e => e.Logidx).HasColumnName("logidx");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Logdate)
                    .HasColumnName("logdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrgMode)
                    .HasColumnName("trgMode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TrgTblItemTarget>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("trg_tbl_item_target");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<VwAllOption>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_all_option");

                entity.Property(e => e.Codename)
                    .IsRequired()
                    .HasColumnName("codename")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Codevalue)
                    .IsRequired()
                    .HasColumnName("codevalue")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Codeview)
                    .IsRequired()
                    .HasColumnName("codeview")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Optioncode)
                    .IsRequired()
                    .HasColumnName("optioncode")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwBrandBestItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_brand_best_item");

                entity.Property(e => e.JsonItem)
                    .HasColumnName("json_item")
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_category");

                entity.Property(e => e.Cdlarge)
                    .IsRequired()
                    .HasColumnName("cdlarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cdmid)
                    .IsRequired()
                    .HasColumnName("cdmid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cdsmall)
                    .IsRequired()
                    .HasColumnName("cdsmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nmlarge)
                    .IsRequired()
                    .HasColumnName("nmlarge")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nmmid)
                    .IsRequired()
                    .HasColumnName("nmmid")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Nmsmall)
                    .IsRequired()
                    .HasColumnName("nmsmall")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCurrentPlusSaleItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Current_PlusSaleItem");

                entity.Property(e => e.PlusSaleItemId).HasColumnName("plusSaleItemID");

                entity.Property(e => e.PlusSaleLinkItemId).HasColumnName("plusSaleLinkItemID");

                entity.Property(e => e.PlusSaleMaginFlag)
                    .IsRequired()
                    .HasColumnName("plusSaleMaginFlag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PlusSaleMargin).HasColumnName("plusSaleMargin");

                entity.Property(e => e.PlusSalePro).HasColumnName("plusSalePro");
            });

            modelBuilder.Entity<VwItemCate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_item_Cate");

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CdlName)
                    .HasColumnName("cdl_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CdmName)
                    .HasColumnName("cdm_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CdsName)
                    .HasColumnName("cds_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDiv)
                    .IsRequired()
                    .HasColumnName("code_div")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeLarge)
                    .IsRequired()
                    .HasColumnName("Code_Large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeMid)
                    .IsRequired()
                    .HasColumnName("Code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeSmall)
                    .IsRequired()
                    .HasColumnName("code_Small")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.ReipgoDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwItemColorCate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_itemColor_Cate");

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CdlName)
                    .HasColumnName("cdl_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CdmName)
                    .HasColumnName("cdm_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CdsName)
                    .HasColumnName("cds_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDiv)
                    .IsRequired()
                    .HasColumnName("code_div")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeLarge)
                    .IsRequired()
                    .HasColumnName("Code_Large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeMid)
                    .IsRequired()
                    .HasColumnName("Code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeSmall)
                    .IsRequired()
                    .HasColumnName("code_Small")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ColorCode).HasColumnName("colorCode");

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.ReipgoDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SortNo).HasColumnName("sortNo");

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwItemDispAttrib>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_item_DispAttrib");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AttribName)
                    .HasColumnName("attribName")
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CatecodeExt).HasColumnName("catecodeExt");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .IsRequired()
                    .HasColumnName("colorCd");

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReipgoDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwItemDispCate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_item_DispCate");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd");

                entity.Property(e => e.BasicImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BrandRank).HasColumnName("brandRank");

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CatecodeExt).HasColumnName("catecodeExt");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .IsRequired()
                    .HasColumnName("colorCd");

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReipgoDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwItemDispCate2015>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_item_DispCate2015");

                entity.Property(e => e.Addimage)
                    .IsRequired()
                    .HasColumnName("addimage")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AdultType).HasColumnName("adultType");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Attribgrp)
                    .IsRequired()
                    .HasColumnName("attribgrp")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Attriblist)
                    .IsRequired()
                    .HasColumnName("attriblist")
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Basicimage600)
                    .HasColumnName("basicimage600")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.BestYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bestkeylist)
                    .HasColumnName("bestkeylist")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BrandRank).HasColumnName("brandRank");

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Cateboostkeylist)
                    .HasColumnName("cateboostkeylist")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CatecodeExt).HasColumnName("catecodeExt");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1sort)
                    .HasColumnName("cd1sort")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2sort)
                    .HasColumnName("cd2sort")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3sort)
                    .HasColumnName("cd3sort")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .IsRequired()
                    .HasColumnName("colorCd")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Colorbasicimage)
                    .IsRequired()
                    .HasColumnName("colorbasicimage")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Colorgrp)
                    .IsRequired()
                    .HasColumnName("colorgrp")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dealmasteritem).HasColumnName("dealmasteritem");

                entity.Property(e => e.Deliverfixday)
                    .IsRequired()
                    .HasColumnName("deliverfixday")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Giftdiv)
                    .IsRequired()
                    .HasColumnName("giftdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(1531);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Makername)
                    .HasColumnName("makername")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Optioncnt).HasColumnName("optioncnt");

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Pojangcnt).HasColumnName("pojangcnt");

                entity.Property(e => e.Pojangok)
                    .IsRequired()
                    .HasColumnName("pojangok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recentsellcount).HasColumnName("recentsellcount");

                entity.Property(e => e.RegDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReipgoDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SellCnt).HasColumnName("sellCnt");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subshoplist)
                    .IsRequired()
                    .HasColumnName("subshoplist");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tentenimage)
                    .HasColumnName("tentenimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Totalpoint).HasColumnName("totalpoint");
            });

            modelBuilder.Entity<VwItemDispCate2015Dev20190425>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_item_DispCate2015_DEV_20190425");

                entity.Property(e => e.Addimage)
                    .IsRequired()
                    .HasColumnName("addimage")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AdultType).HasColumnName("adultType");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Attribgrp)
                    .IsRequired()
                    .HasColumnName("attribgrp")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Basicimage600)
                    .HasColumnName("basicimage600")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Bestkeylist)
                    .HasColumnName("bestkeylist")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BrandRank).HasColumnName("brandRank");

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Cateboostkeylist)
                    .HasColumnName("cateboostkeylist")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CatecodeExt).HasColumnName("catecodeExt");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1sort)
                    .HasColumnName("cd1sort")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2sort)
                    .HasColumnName("cd2sort")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3sort)
                    .HasColumnName("cd3sort")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .IsRequired()
                    .HasColumnName("colorCd")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Colorbasicimage)
                    .IsRequired()
                    .HasColumnName("colorbasicimage")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Colorgrp)
                    .IsRequired()
                    .HasColumnName("colorgrp")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dealmasteritem).HasColumnName("dealmasteritem");

                entity.Property(e => e.Deliverfixday)
                    .IsRequired()
                    .HasColumnName("deliverfixday")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(1540);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Optioncnt).HasColumnName("optioncnt");

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Pojangcnt).HasColumnName("pojangcnt");

                entity.Property(e => e.Pojangok)
                    .IsRequired()
                    .HasColumnName("pojangok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recentsellcount).HasColumnName("recentsellcount");

                entity.Property(e => e.RegDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReipgoDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SellCnt).HasColumnName("sellCnt");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Totalpoint).HasColumnName("totalpoint");
            });

            modelBuilder.Entity<VwItemDispColor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_item_DispColor");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd");

                entity.Property(e => e.BasicImage)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CatecodeExt).HasColumnName("catecodeExt");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .HasColumnName("colorCd")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ColorIcon)
                    .HasColumnName("colorIcon")
                    .HasMaxLength(68)
                    .IsUnicode(false);

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasColumnName("colorName")
                    .HasMaxLength(12);

                entity.Property(e => e.ColorSortNo).HasColumnName("colorSortNo");

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReipgoDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwItemDispStyle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_item_DispStyle");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd");

                entity.Property(e => e.BasicImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CatecodeExt).HasColumnName("catecodeExt");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .IsRequired()
                    .HasColumnName("colorCd");

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReipgoDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .HasColumnName("styleCd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StyleName)
                    .IsRequired()
                    .HasColumnName("styleName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwItemRecentsellDiary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_item_recentsell_diary");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VwItemoption>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_itemoption");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Opt1name)
                    .IsRequired()
                    .HasColumnName("opt1name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Opt2name)
                    .IsRequired()
                    .HasColumnName("opt2name")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOpenItemViewAgirl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OpenItemViewAgirl");

                entity.Property(e => e.AgirlOptionCode)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryType)
                    .IsRequired()
                    .HasColumnName("deliveryType")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemUsingYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemusing)
                    .IsRequired()
                    .HasColumnName("itemusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimitNo).HasColumnName("limitNo");

                entity.Property(e => e.LimitSold).HasColumnName("limitSold");

                entity.Property(e => e.Limityn)
                    .IsRequired()
                    .HasColumnName("limityn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LinkStockType).HasColumnName("linkStockType");

                entity.Property(e => e.Optaddprice)
                    .HasColumnName("optaddprice")
                    .HasColumnType("money");

                entity.Property(e => e.Optionname)
                    .IsRequired()
                    .HasColumnName("optionname")
                    .HasMaxLength(96)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasColumnName("sellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwTenCategoryListMain>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Ten_CategoryList_Main");

                entity.Property(e => e.Brandname)
                    .HasColumnName("brandname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDiv)
                    .IsRequired()
                    .HasColumnName("code_div")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodeLarge)
                    .IsRequired()
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Evalcnt).HasColumnName("evalcnt");

                entity.Property(e => e.Icon1image)
                    .HasColumnName("icon1image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Itemcoupontype)
                    .HasColumnName("itemcoupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemcouponvalue).HasColumnName("itemcouponvalue");

                entity.Property(e => e.Itemcouponyn)
                    .HasColumnName("itemcouponyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemscore).HasColumnName("itemscore");

                entity.Property(e => e.Limitno).HasColumnName("limitno");

                entity.Property(e => e.Limitsold).HasColumnName("limitsold");

                entity.Property(e => e.Limityn)
                    .IsRequired()
                    .HasColumnName("limityn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Listimage)
                    .HasColumnName("listimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Orgprice)
                    .HasColumnName("orgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasColumnName("sellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VwTestdev>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_testdev");

                entity.Property(e => e.Addimage)
                    .IsRequired()
                    .HasColumnName("addimage")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AdultType).HasColumnName("adultType");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Attribgrp)
                    .IsRequired()
                    .HasColumnName("attribgrp")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Attribnm)
                    .IsRequired()
                    .HasColumnName("attribnm")
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Basicimage600)
                    .HasColumnName("basicimage600")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Bestkeylist)
                    .HasColumnName("bestkeylist")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BrandRank).HasColumnName("brandRank");

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.Cateboostkeylist)
                    .HasColumnName("cateboostkeylist")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CatecodeExt).HasColumnName("catecodeExt");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1sort)
                    .HasColumnName("cd1sort")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2sort)
                    .HasColumnName("cd2sort")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3sort)
                    .HasColumnName("cd3sort")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .IsRequired()
                    .HasColumnName("colorCd")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Colorbasicimage)
                    .IsRequired()
                    .HasColumnName("colorbasicimage")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Colorgrp)
                    .IsRequired()
                    .HasColumnName("colorgrp")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Colornm)
                    .IsRequired()
                    .HasColumnName("colornm")
                    .IsUnicode(false);

                entity.Property(e => e.Dealmasteritem).HasColumnName("dealmasteritem");

                entity.Property(e => e.Deliverfixday)
                    .IsRequired()
                    .HasColumnName("deliverfixday")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(1540);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Optioncnt).HasColumnName("optioncnt");

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Pojangcnt).HasColumnName("pojangcnt");

                entity.Property(e => e.Pojangok)
                    .IsRequired()
                    .HasColumnName("pojangok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recentsellcount).HasColumnName("recentsellcount");

                entity.Property(e => e.RegDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReipgoDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SellCnt).HasColumnName("sellCnt");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stylegrp)
                    .IsRequired()
                    .HasColumnName("stylegrp")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Stylenm)
                    .IsRequired()
                    .HasColumnName("stylenm")
                    .IsUnicode(false);

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Totalpoint).HasColumnName("totalpoint");
            });

            modelBuilder.Entity<XVwItemDispAttrib>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("X_vw_item_DispAttrib");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AttribName)
                    .HasColumnName("attribName")
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .IsRequired()
                    .HasColumnName("colorCd");

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("isDefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.ReipgoDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<XVwItemDispCate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("X_vw_item_DispCate");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd");

                entity.Property(e => e.BasicImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BrandRank).HasColumnName("brandRank");

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .IsRequired()
                    .HasColumnName("colorCd");

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("isDefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.ReipgoDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<XVwItemDispColor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("X_vw_item_DispColor");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd");

                entity.Property(e => e.BasicImage)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .HasColumnName("colorCd")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ColorIcon)
                    .HasColumnName("colorIcon")
                    .HasMaxLength(68)
                    .IsUnicode(false);

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasColumnName("colorName")
                    .HasMaxLength(12);

                entity.Property(e => e.ColorSortNo).HasColumnName("colorSortNo");

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("isDefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.ReipgoDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .IsRequired()
                    .HasColumnName("styleCd");

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<XVwItemDispStyle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("X_vw_item_DispStyle");

                entity.Property(e => e.AttribCd)
                    .IsRequired()
                    .HasColumnName("attribCd");

                entity.Property(e => e.BasicImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("brandName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.CateDepth).HasColumnName("cateDepth");

                entity.Property(e => e.CateSortNo).HasColumnName("cateSortNo");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Catename)
                    .HasColumnName("catename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cd1)
                    .HasColumnName("cd1")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd2)
                    .HasColumnName("cd2")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Cd3)
                    .HasColumnName("cd3")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCd)
                    .IsRequired()
                    .HasColumnName("colorCd");

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EvalCnt).HasColumnName("evalCnt");

                entity.Property(e => e.EvalCntPhoto).HasColumnName("evalCnt_photo");

                entity.Property(e => e.Favcount).HasColumnName("favcount");

                entity.Property(e => e.Icon1Image)
                    .HasColumnName("icon1Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2Image)
                    .HasColumnName("icon2Image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.IsAboard)
                    .IsRequired()
                    .HasColumnName("isAboard")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsBestBrand)
                    .HasColumnName("isBestBrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("isDefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsFreeBeasong)
                    .IsRequired()
                    .HasColumnName("isFreeBeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCouponType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCouponYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWords)
                    .HasColumnName("keyWords")
                    .HasMaxLength(770)
                    .IsUnicode(false);

                entity.Property(e => e.LimitYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ListImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.ListImage120)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.MaskImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewYn)
                    .IsRequired()
                    .HasColumnName("NewYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.ReipgoDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SalePercent).HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.SaleYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallImage)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Stritemid).HasColumnName("stritemid");

                entity.Property(e => e.StyleCd)
                    .HasColumnName("styleCd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StyleName)
                    .IsRequired()
                    .HasColumnName("styleName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<XxTblItemAttributeSameKey>(entity =>
            {
                entity.HasKey(e => new { e.AttribName, e.SameName })
                    .HasName("PK_tbl_itemAttribute_SameKey");

                entity.ToTable("XX_tbl_itemAttribute_SameKey");

                entity.Property(e => e.AttribName)
                    .HasColumnName("attribName")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SameName)
                    .HasColumnName("sameName")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        #region model

        public virtual DbSet<TblAcademyProduct> TblAcademyProduct { get; set; }
        public virtual DbSet<TblAgirlRegItem> TblAgirlRegItem { get; set; }
        public virtual DbSet<TblAtseoulCategoryMapping> TblAtseoulCategoryMapping { get; set; }
        public virtual DbSet<TblAtseoulRegItem> TblAtseoulRegItem { get; set; }
        public virtual DbSet<TblAuction> TblAuction { get; set; }
        public virtual DbSet<TblBaljuregBrand> TblBaljuregBrand { get; set; }
        public virtual DbSet<TblBaljuregItem> TblBaljuregItem { get; set; }
        public virtual DbSet<TblBetweenCate> TblBetweenCate { get; set; }
        public virtual DbSet<TblBetweenCateItem> TblBetweenCateItem { get; set; }
        public virtual DbSet<TblBetweenMain3banner> TblBetweenMain3banner { get; set; }
        public virtual DbSet<TblBetweenNoticefaq> TblBetweenNoticefaq { get; set; }
        public virtual DbSet<TblBetweenProject> TblBetweenProject { get; set; }
        public virtual DbSet<TblBetweenProjectGroup> TblBetweenProjectGroup { get; set; }
        public virtual DbSet<TblBetweenProjectGroupItem> TblBetweenProjectGroupItem { get; set; }
        public virtual DbSet<TblCameraItem> TblCameraItem { get; set; }
        public virtual DbSet<TblCateAttribDiv> TblCateAttribDiv { get; set; }
        public virtual DbSet<TblCateAttribItem> TblCateAttribItem { get; set; }
        public virtual DbSet<TblCateLarge> TblCateLarge { get; set; }
        public virtual DbSet<TblCateMid> TblCateMid { get; set; }
        public virtual DbSet<TblCateRelateLink> TblCateRelateLink { get; set; }
        public virtual DbSet<TblCateSmall> TblCateSmall { get; set; }
        public virtual DbSet<TblCategoryMatching> TblCategoryMatching { get; set; }
        public virtual DbSet<TblCategoryMatching2> TblCategoryMatching2 { get; set; }
        public virtual DbSet<TblCjMallPrdDivMapping> TblCjMallPrdDivMapping { get; set; }
        public virtual DbSet<TblCjmallCateMapping> TblCjmallCateMapping { get; set; }
        public virtual DbSet<TblCjmallPrddivMidMap> TblCjmallPrddivMidMap { get; set; }
        public virtual DbSet<TblCjmallRegitem> TblCjmallRegitem { get; set; }
        public virtual DbSet<TblColorChips> TblColorChips { get; set; }
        public virtual DbSet<TblColorfavorite> TblColorfavorite { get; set; }
        public virtual DbSet<TblColortrend> TblColortrend { get; set; }
        public virtual DbSet<TblColortrendItem> TblColortrendItem { get; set; }
        public virtual DbSet<TblConstOptAddPriceExists> TblConstOptAddPriceExists { get; set; }
        public virtual DbSet<TblDayexchageRate> TblDayexchageRate { get; set; }
        public virtual DbSet<TblDisplayCate> TblDisplayCate { get; set; }
        public virtual DbSet<TblDisplayCate2> TblDisplayCate2 { get; set; }
        public virtual DbSet<TblDisplayCate2Item> TblDisplayCate2Item { get; set; }
        public virtual DbSet<TblDisplayCateItem> TblDisplayCateItem { get; set; }
        public virtual DbSet<TblDisplayCateMenu> TblDisplayCateMenu { get; set; }
        public virtual DbSet<TblDisplayCateMenuTop> TblDisplayCateMenuTop { get; set; }
        public virtual DbSet<TblDisplayCateSubshop> TblDisplayCateSubshop { get; set; }
        public virtual DbSet<TblDisplayTotalcategory> TblDisplayTotalcategory { get; set; }
        public virtual DbSet<TblDnshopDspcategoryMapping> TblDnshopDspcategoryMapping { get; set; }
        public virtual DbSet<TblDnshopMngcategoryMapping> TblDnshopMngcategoryMapping { get; set; }
        public virtual DbSet<TblDnshopRegItem> TblDnshopRegItem { get; set; }
        public virtual DbSet<TblExchangeRate> TblExchangeRate { get; set; }
        public virtual DbSet<TblExhibitionItemDetail> TblExhibitionItemDetail { get; set; }
        public virtual DbSet<TblExhibitionItemDetail2> TblExhibitionItemDetail2 { get; set; }
        public virtual DbSet<TblExhibitionItemMaster> TblExhibitionItemMaster { get; set; }
        public virtual DbSet<TblExhibitioneventGroupcode> TblExhibitioneventGroupcode { get; set; }
        public virtual DbSet<TblFujiTempleteCode> TblFujiTempleteCode { get; set; }
        public virtual DbSet<TblGiftcardDesign> TblGiftcardDesign { get; set; }
        public virtual DbSet<TblGiftcardItem> TblGiftcardItem { get; set; }
        public virtual DbSet<TblGiftcardOption> TblGiftcardOption { get; set; }
        public virtual DbSet<TblGsshopBrandDeliveryMapping> TblGsshopBrandDeliveryMapping { get; set; }
        public virtual DbSet<TblGsshopCateMapping> TblGsshopCateMapping { get; set; }
        public virtual DbSet<TblGsshopMdidMapping> TblGsshopMdidMapping { get; set; }
        public virtual DbSet<TblGsshopPrdDivMapping> TblGsshopPrdDivMapping { get; set; }
        public virtual DbSet<TblGsshopRegitem> TblGsshopRegitem { get; set; }
        public virtual DbSet<TblGsshopSafeCode> TblGsshopSafeCode { get; set; }
        public virtual DbSet<TblInfinitystaticCategory> TblInfinitystaticCategory { get; set; }
        public virtual DbSet<TblInfinitystaticHistory> TblInfinitystaticHistory { get; set; }
        public virtual DbSet<TblInfinitystaticMain> TblInfinitystaticMain { get; set; }
        public virtual DbSet<TblInterparkDspcategoryMapping> TblInterparkDspcategoryMapping { get; set; }
        public virtual DbSet<TblInterparkRegItem> TblInterparkRegItem { get; set; }
        public virtual DbSet<TblItem> TblItem { get; set; }
        public virtual DbSet<TblItem2> TblItem2 { get; set; }
        public virtual DbSet<TblItemAddimage> TblItemAddimage { get; set; }
        public virtual DbSet<TblItemAttribDispCate> TblItemAttribDispCate { get; set; }
        public virtual DbSet<TblItemAttribItem> TblItemAttribItem { get; set; }
        public virtual DbSet<TblItemAttribute> TblItemAttribute { get; set; }
        public virtual DbSet<TblItemAttribute1> TblItemAttribute1 { get; set; }
        public virtual DbSet<TblItemBuyseq> TblItemBuyseq { get; set; }
        public virtual DbSet<TblItemBuyseqTmp> TblItemBuyseqTmp { get; set; }
        public virtual DbSet<TblItemCategory> TblItemCategory { get; set; }
        public virtual DbSet<TblItemChannel> TblItemChannel { get; set; }
        public virtual DbSet<TblItemColorOption> TblItemColorOption { get; set; }
        public virtual DbSet<TblItemContents> TblItemContents { get; set; }
        public virtual DbSet<TblItemCouponDetail> TblItemCouponDetail { get; set; }
        public virtual DbSet<TblItemCouponMaster> TblItemCouponMaster { get; set; }
        public virtual DbSet<TblItemDiv> TblItemDiv { get; set; }
        public virtual DbSet<TblItemEndlog> TblItemEndlog { get; set; }
        public virtual DbSet<TblItemGubun> TblItemGubun { get; set; }
        public virtual DbSet<TblItemInfoCode> TblItemInfoCode { get; set; }
        public virtual DbSet<TblItemInfoCont> TblItemInfoCont { get; set; }
        public virtual DbSet<TblItemInfoDiv> TblItemInfoDiv { get; set; }
        public virtual DbSet<TblItemLogicsAddinfo> TblItemLogicsAddinfo { get; set; }
        public virtual DbSet<TblItemMultiLang> TblItemMultiLang { get; set; }
        public virtual DbSet<TblItemMultiLangOption> TblItemMultiLangOption { get; set; }
        public virtual DbSet<TblItemMultiLangPrice> TblItemMultiLangPrice { get; set; }
        public virtual DbSet<TblItemMultiLangPriceTemp> TblItemMultiLangPriceTemp { get; set; }
        public virtual DbSet<TblItemMultiSiteRegItem> TblItemMultiSiteRegItem { get; set; }
        public virtual DbSet<TblItemOption> TblItemOption { get; set; }
        public virtual DbSet<TblItemOptionMultiple> TblItemOptionMultiple { get; set; }
        public virtual DbSet<TblItemOptionStock> TblItemOptionStock { get; set; }
        public virtual DbSet<TblItemPackVolumn> TblItemPackVolumn { get; set; }
        public virtual DbSet<TblItemQuickdlv> TblItemQuickdlv { get; set; }
        public virtual DbSet<TblItemQuickdlvAvailable> TblItemQuickdlvAvailable { get; set; }
        public virtual DbSet<TblItemQuickdlvInvalid> TblItemQuickdlvInvalid { get; set; }
        public virtual DbSet<TblItemRelation> TblItemRelation { get; set; }
        public virtual DbSet<TblItemSaleInfo> TblItemSaleInfo { get; set; }
        public virtual DbSet<TblItemSellReserve> TblItemSellReserve { get; set; }
        public virtual DbSet<TblItemStandingItem> TblItemStandingItem { get; set; }
        public virtual DbSet<TblItemStandingOrder> TblItemStandingOrder { get; set; }
        public virtual DbSet<TblItemStandingOrderLog> TblItemStandingOrderLog { get; set; }
        public virtual DbSet<TblItemStandingUser> TblItemStandingUser { get; set; }
        public virtual DbSet<TblItemVideos> TblItemVideos { get; set; }
        public virtual DbSet<TblItemVolumn> TblItemVolumn { get; set; }
        public virtual DbSet<TblIthinksoCategoryInfo> TblIthinksoCategoryInfo { get; set; }
        public virtual DbSet<TblIthinksoCategoryType> TblIthinksoCategoryType { get; set; }
        public virtual DbSet<TblIthinksoCategoryWp> TblIthinksoCategoryWp { get; set; }
        public virtual DbSet<TblIthinksoCategoryitem> TblIthinksoCategoryitem { get; set; }
        public virtual DbSet<TblIthinksoRecipe> TblIthinksoRecipe { get; set; }
        public virtual DbSet<TblKaffaBrandMapping> TblKaffaBrandMapping { get; set; }
        public virtual DbSet<TblKaffaCategory> TblKaffaCategory { get; set; }
        public virtual DbSet<TblKaffaCategoryMapping> TblKaffaCategoryMapping { get; set; }
        public virtual DbSet<TblKaffaDiscountItem> TblKaffaDiscountItem { get; set; }
        public virtual DbSet<TblKaffaDiscountList> TblKaffaDiscountList { get; set; }
        public virtual DbSet<TblKaffaRegItem> TblKaffaRegItem { get; set; }
        public virtual DbSet<TblKeywordDetail> TblKeywordDetail { get; set; }
        public virtual DbSet<TblKeywordMaster> TblKeywordMaster { get; set; }
        public virtual DbSet<TblLotteBrandMapping> TblLotteBrandMapping { get; set; }
        public virtual DbSet<TblLotteCateMapping> TblLotteCateMapping { get; set; }
        public virtual DbSet<TblLotteMaterial> TblLotteMaterial { get; set; }
        public virtual DbSet<TblLotteRegItem> TblLotteRegItem { get; set; }
        public virtual DbSet<TblLotteimallCateMapping> TblLotteimallCateMapping { get; set; }
        public virtual DbSet<TblLtiMallCateGbnMapping> TblLtiMallCateGbnMapping { get; set; }
        public virtual DbSet<TblLtiMallCateMapping> TblLtiMallCateMapping { get; set; }
        public virtual DbSet<TblLtiMallRegItem> TblLtiMallRegItem { get; set; }
        public virtual DbSet<TblMakeglobCateMatching> TblMakeglobCateMatching { get; set; }
        public virtual DbSet<TblMakeglobCategory> TblMakeglobCategory { get; set; }
        public virtual DbSet<TblMakeglobProduct> TblMakeglobProduct { get; set; }
        public virtual DbSet<TblMakeglobProductOption> TblMakeglobProductOption { get; set; }
        public virtual DbSet<TblMileageshopItem> TblMileageshopItem { get; set; }
        public virtual DbSet<TblOptionDiv01> TblOptionDiv01 { get; set; }
        public virtual DbSet<TblOptionDiv02> TblOptionDiv02 { get; set; }
        public virtual DbSet<TblOutMallBrandReturnCode> TblOutMallBrandReturnCode { get; set; }
        public virtual DbSet<TblOutMallCateMapSummary> TblOutMallCateMapSummary { get; set; }
        public virtual DbSet<TblOutMallEtcLink> TblOutMallEtcLink { get; set; }
        public virtual DbSet<TblOutMallEtcLinkGubun> TblOutMallEtcLinkGubun { get; set; }
        public virtual DbSet<TblOutMallInfoCodeMap> TblOutMallInfoCodeMap { get; set; }
        public virtual DbSet<TblOutMallRegedoption> TblOutMallRegedoption { get; set; }
        public virtual DbSet<TblOutmallRdsiteGubun> TblOutmallRdsiteGubun { get; set; }
        public virtual DbSet<TblPhotoAuthItem> TblPhotoAuthItem { get; set; }
        public virtual DbSet<TblPlusSaleLinkItemList> TblPlusSaleLinkItemList { get; set; }
        public virtual DbSet<TblPlusSaleRegedItem> TblPlusSaleRegedItem { get; set; }
        public virtual DbSet<TblPublicBarcodeReserved> TblPublicBarcodeReserved { get; set; }
        public virtual DbSet<TblSafetycertImage> TblSafetycertImage { get; set; }
        public virtual DbSet<TblSafetycertInfo> TblSafetycertInfo { get; set; }
        public virtual DbSet<TblSafetycertTenReg> TblSafetycertTenReg { get; set; }
        public virtual DbSet<TblShoplinkerOutmall> TblShoplinkerOutmall { get; set; }
        public virtual DbSet<TblShoplinkerOutmallControl> TblShoplinkerOutmallControl { get; set; }
        public virtual DbSet<TblShoplinkerRegItem> TblShoplinkerRegItem { get; set; }
        public virtual DbSet<TblSpecialShop> TblSpecialShop { get; set; }
        public virtual DbSet<TblSpecialShopitem> TblSpecialShopitem { get; set; }
        public virtual DbSet<TblTicketItemInfo> TblTicketItemInfo { get; set; }
        public virtual DbSet<TblTicketPlaceInfo> TblTicketPlaceInfo { get; set; }
        public virtual DbSet<TblTicketSchedule> TblTicketSchedule { get; set; }
        public virtual DbSet<TblTtlRegItem> TblTtlRegItem { get; set; }
        public virtual DbSet<TblUserItemCoupon> TblUserItemCoupon { get; set; }
        public virtual DbSet<TblUserItemCouponDownLog> TblUserItemCouponDownLog { get; set; }
        public virtual DbSet<TblUserItemCouponDownable> TblUserItemCouponDownable { get; set; }
        public virtual DbSet<Testtable1> Testtable1 { get; set; }
        public virtual DbSet<TrgTblItem> TrgTblItem { get; set; }
        public virtual DbSet<TrgTblItemContents> TrgTblItemContents { get; set; }
        public virtual DbSet<TrgTblItemTarget> TrgTblItemTarget { get; set; }
        public virtual DbSet<VwAllOption> VwAllOption { get; set; }
        public virtual DbSet<VwBrandBestItem> VwBrandBestItem { get; set; }
        public virtual DbSet<VwCategory> VwCategory { get; set; }
        public virtual DbSet<VwCurrentPlusSaleItem> VwCurrentPlusSaleItem { get; set; }
        public virtual DbSet<VwItemCate> VwItemCate { get; set; }
        public virtual DbSet<VwItemColorCate> VwItemColorCate { get; set; }
        public virtual DbSet<VwItemDispAttrib> VwItemDispAttrib { get; set; }
        public virtual DbSet<VwItemDispCate> VwItemDispCate { get; set; }
        public virtual DbSet<VwItemDispCate2015> VwItemDispCate2015 { get; set; }
        public virtual DbSet<VwItemDispCate2015Dev20190425> VwItemDispCate2015Dev20190425 { get; set; }
        public virtual DbSet<VwItemDispColor> VwItemDispColor { get; set; }
        public virtual DbSet<VwItemDispStyle> VwItemDispStyle { get; set; }
        public virtual DbSet<VwItemRecentsellDiary> VwItemRecentsellDiary { get; set; }
        public virtual DbSet<VwItemoption> VwItemoption { get; set; }
        public virtual DbSet<VwOpenItemViewAgirl> VwOpenItemViewAgirl { get; set; }
        public virtual DbSet<VwTenCategoryListMain> VwTenCategoryListMain { get; set; }
        public virtual DbSet<VwTestdev> VwTestdev { get; set; }
        public virtual DbSet<XVwItemDispAttrib> XVwItemDispAttrib { get; set; }
        public virtual DbSet<XVwItemDispCate> XVwItemDispCate { get; set; }
        public virtual DbSet<XVwItemDispColor> XVwItemDispColor { get; set; }
        public virtual DbSet<XVwItemDispStyle> XVwItemDispStyle { get; set; }
        public virtual DbSet<XxTblItemAttributeSameKey> XxTblItemAttributeSameKey { get; set; }


        #endregion
    }
}
