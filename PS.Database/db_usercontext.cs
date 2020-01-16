using Microsoft.EntityFrameworkCore;
using PS.Database.Models.db_user;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PS.Database
{
    public partial class db_usercontext : DbContext
    {
        public db_usercontext(IDbConnection dbConnection, bool isConsoleLogging = false) //: base(dbConnection, isConsoleLogging)
        {
        }
        public db_usercontext(DbContextOptions<db_usercontext> options) : base(options)
        {
        }
        public virtual DbSet<TblDeluser> TblDeluser { get; set; }
        public virtual DbSet<TblDepositGubun> TblDepositGubun { get; set; }
        public virtual DbSet<TblDepositlog> TblDepositlog { get; set; }
        public virtual DbSet<TblGiftcardCurrent> TblGiftcardCurrent { get; set; }
        public virtual DbSet<TblGiftcardGubun> TblGiftcardGubun { get; set; }
        public virtual DbSet<TblGiftcardLog> TblGiftcardLog { get; set; }
        public virtual DbSet<TblGiftcardRegList> TblGiftcardRegList { get; set; }
        public virtual DbSet<TblInvalidEmail> TblInvalidEmail { get; set; }
        public virtual DbSet<TblInvalidUser> TblInvalidUser { get; set; }
        public virtual DbSet<TblLogindata> TblLogindata { get; set; }
        public virtual DbSet<TblMailzineNotmember> TblMailzineNotmember { get; set; }
        public virtual DbSet<TblMileageAutoExtinctionLog> TblMileageAutoExtinctionLog { get; set; }
        public virtual DbSet<TblMileageAutoExtinctionMaster> TblMileageAutoExtinctionMaster { get; set; }
        public virtual DbSet<TblMileageGubun> TblMileageGubun { get; set; }
        public virtual DbSet<TblMileageMonthlyExpire> TblMileageMonthlyExpire { get; set; }
        public virtual DbSet<TblMileageYearExpire> TblMileageYearExpire { get; set; }
        public virtual DbSet<TblMileagelog> TblMileagelog { get; set; }
        public virtual DbSet<TblQrcodeLog> TblQrcodeLog { get; set; }
        public virtual DbSet<TblRejectSms> TblRejectSms { get; set; }
        public virtual DbSet<TblTagCouponMaster> TblTagCouponMaster { get; set; }
        public virtual DbSet<TblUserAllowSite> TblUserAllowSite { get; set; }
        public virtual DbSet<TblUserAutoLoginCpnEvalTarget> TblUserAutoLoginCpnEvalTarget { get; set; }
        public virtual DbSet<TblUserB> TblUserB { get; set; }
        public virtual DbSet<TblUserC> TblUserC { get; set; }
        public virtual DbSet<TblUserCDefaultdeliveryLog> TblUserCDefaultdeliveryLog { get; set; }
        public virtual DbSet<TblUserCHoliday> TblUserCHoliday { get; set; }
        public virtual DbSet<TblUserCoupon> TblUserCoupon { get; set; }
        public virtual DbSet<TblUserCouponMaster> TblUserCouponMaster { get; set; }
        public virtual DbSet<TblUserCouponOpenlist> TblUserCouponOpenlist { get; set; }
        public virtual DbSet<TblUserCurrentDeposit> TblUserCurrentDeposit { get; set; }
        public virtual DbSet<TblUserCurrentMileage> TblUserCurrentMileage { get; set; }
        public virtual DbSet<TblUserDiv> TblUserDiv { get; set; }
        public virtual DbSet<TblUserHitchhiker> TblUserHitchhiker { get; set; }
        public virtual DbSet<TblUserLoginLastguid> TblUserLoginLastguid { get; set; }
        public virtual DbSet<TblUserN> TblUserN { get; set; }
        public virtual DbSet<TblUserSns> TblUserSns { get; set; }
        public virtual DbSet<TblUserSnsToken> TblUserSnsToken { get; set; }
        public virtual DbSet<TblUserSsn> TblUserSsn { get; set; }
        public virtual DbSet<TblUsersegCate> TblUsersegCate { get; set; }
        public virtual DbSet<TblUsersegCateTmp> TblUsersegCateTmp { get; set; }
        public virtual DbSet<TrgTblUserC> TrgTblUserC { get; set; }
        public virtual DbSet<VwBrandList2017> VwBrandList2017 { get; set; }
        public virtual DbSet<VwUserBirthdayMailList> VwUserBirthdayMailList { get; set; }
        public virtual DbSet<VwUserMailList> VwUserMailList { get; set; }
        public virtual DbSet<VwUserMailListAgreeInfoTargetMail> VwUserMailListAgreeInfoTargetMail { get; set; }
        public virtual DbSet<VwUserMailListEventLuckyletter> VwUserMailListEventLuckyletter { get; set; }
        public virtual DbSet<VwUserMailListFingersClaim> VwUserMailListFingersClaim { get; set; }
        public virtual DbSet<VwUserMailListGradeFamily> VwUserMailListGradeFamily { get; set; }
        public virtual DbSet<VwUserMailListGradeRed> VwUserMailListGradeRed { get; set; }
        public virtual DbSet<VwUserMailListGradeStaff> VwUserMailListGradeStaff { get; set; }
        public virtual DbSet<VwUserMailListGradeVip> VwUserMailListGradeVip { get; set; }
        public virtual DbSet<VwUserMailListGradeVipGoldSilver> VwUserMailListGradeVipGoldSilver { get; set; }
        public virtual DbSet<VwUserMailListGradeVipGoldSilverBlue> VwUserMailListGradeVipGoldSilverBlue { get; set; }
        public virtual DbSet<VwUserMailListGradeVipgold> VwUserMailListGradeVipgold { get; set; }
        public virtual DbSet<VwUserMailListGradeVvip> VwUserMailListGradeVvip { get; set; }
        public virtual DbSet<VwUserMailListHalf> VwUserMailListHalf { get; set; }
        public virtual DbSet<VwUserMailListHalfAfter> VwUserMailListHalfAfter { get; set; }
        public virtual DbSet<VwUserMailListHalfBefore> VwUserMailListHalfBefore { get; set; }
        public virtual DbSet<VwUserMailListMetropolitan> VwUserMailListMetropolitan { get; set; }
        public virtual DbSet<VwUserMailListMetropolitan경상> VwUserMailListMetropolitan경상 { get; set; }
        public virtual DbSet<VwUserMailListMetropolitan수도권제주> VwUserMailListMetropolitan수도권제주 { get; set; }
        public virtual DbSet<VwUserMailListMetropolitan전주> VwUserMailListMetropolitan전주 { get; set; }
        public virtual DbSet<VwUserMailListMetropolitan제주> VwUserMailListMetropolitan제주 { get; set; }
        public virtual DbSet<VwUserMailListMileExpireTargetMail> VwUserMailListMileExpireTargetMail { get; set; }
        public virtual DbSet<VwUserMailListMonthUpgradeBlue> VwUserMailListMonthUpgradeBlue { get; set; }
        public virtual DbSet<VwUserMailListMonthUpgradeGreen> VwUserMailListMonthUpgradeGreen { get; set; }
        public virtual DbSet<VwUserMailListMonthUpgradeVipgold> VwUserMailListMonthUpgradeVipgold { get; set; }
        public virtual DbSet<VwUserMailListMonthUpgradeVipsilver> VwUserMailListMonthUpgradeVipsilver { get; set; }
        public virtual DbSet<VwUserMailListNotmember> VwUserMailListNotmember { get; set; }
        public virtual DbSet<VwUserMailListTargetMail> VwUserMailListTargetMail { get; set; }
        public virtual DbSet<VwUserMailListTemp> VwUserMailListTemp { get; set; }
        public virtual DbSet<VwUserMailListUserlevelDown> VwUserMailListUserlevelDown { get; set; }
        public virtual DbSet<XTblUserSsnV2> XTblUserSsnV2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = 192.168.50.3; Initial Catalog = db_user; User ID = udb_tenbytendevel; Password=ten101010#;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDeluser>(entity =>
            {
                entity.ToTable("tbl_deluser");

                entity.HasIndex(e => e.Userid)
                    .HasName("IX_tbl_deluser_USERID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChkMethod)
                    .HasColumnName("chkMethod")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('rnm')");

                entity.Property(e => e.Complaindiv)
                    .HasColumnName("complaindiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Complaintext)
                    .HasColumnName("complaintext")
                    .HasColumnType("text");

                entity.Property(e => e.Device)
                    .HasColumnName("device")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Joindate)
                    .HasColumnName("joindate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Juminno)
                    .HasColumnName("juminno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Useq).HasColumnName("useq");

                entity.Property(e => e.Useremail)
                    .HasColumnName("useremail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblDepositGubun>(entity =>
            {
                entity.HasKey(e => e.Jukyocd);

                entity.ToTable("tbl_deposit_gubun");

                entity.Property(e => e.Jukyocd)
                    .HasColumnName("jukyocd")
                    .ValueGeneratedNever();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Jukyoname)
                    .IsRequired()
                    .HasColumnName("jukyoname")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDepositlog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_depositlog");

                entity.HasIndex(e => e.Jukyocd);

                entity.HasIndex(e => e.Userid);

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Asid).HasColumnName("asid");

                entity.Property(e => e.Deleteyn)
                    .IsRequired()
                    .HasColumnName("deleteyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Deluserid)
                    .HasColumnName("deluserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Deposit).HasColumnName("deposit");

                entity.Property(e => e.Fixyyyymmdd)
                    .HasColumnName("fixyyyymmdd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Jukyo)
                    .HasColumnName("jukyo")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Jukyocd).HasColumnName("jukyocd");

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGiftcardCurrent>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__tbl_giftcard_cur__61F08603");

                entity.ToTable("tbl_giftcard_current");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCash)
                    .HasColumnName("currentCash")
                    .HasColumnType("money");

                entity.Property(e => e.GainCash)
                    .HasColumnName("gainCash")
                    .HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RefundCash)
                    .HasColumnName("refundCash")
                    .HasColumnType("money");

                entity.Property(e => e.SpendCash)
                    .HasColumnName("spendCash")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblGiftcardGubun>(entity =>
            {
                entity.HasKey(e => e.Jukyocd);

                entity.ToTable("tbl_giftcard_gubun");

                entity.Property(e => e.Jukyocd)
                    .HasColumnName("jukyocd")
                    .ValueGeneratedNever();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Jukyoname)
                    .IsRequired()
                    .HasColumnName("jukyoname")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGiftcardLog>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_giftcard_log__6F4A8121");

                entity.ToTable("tbl_giftcard_log");

                entity.HasIndex(e => e.Userid)
                    .HasName("IX_tbl_giftcard_log_USERID");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.DeleteYn)
                    .IsRequired()
                    .HasColumnName("deleteYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Deluserid)
                    .HasColumnName("deluserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Fixyyyymmdd)
                    .HasColumnName("fixyyyymmdd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fixyyyymmdd20121130before)
                    .HasColumnName("fixyyyymmdd_20121130before")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Jukyo)
                    .HasColumnName("jukyo")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Jukyocd).HasColumnName("jukyocd");

                entity.Property(e => e.NotRegGiftOrderSerial)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(16)
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

                entity.Property(e => e.SiteDiv)
                    .IsRequired()
                    .HasColumnName("siteDiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('T')");

                entity.Property(e => e.UseCash)
                    .HasColumnName("useCash")
                    .HasColumnType("money");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGiftcardRegList>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_giftcard_reg__79C80F94");

                entity.ToTable("tbl_giftcard_regList");

                entity.HasIndex(e => e.GiftOrderSerial)
                    .HasName("IX_tbl_giftcard_regList_giftOrderserial");

                entity.HasIndex(e => e.Userid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.BuyDate)
                    .HasColumnName("buyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardExpire)
                    .HasColumnName("cardExpire")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardItemid).HasColumnName("cardItemid");

                entity.Property(e => e.CardOption)
                    .IsRequired()
                    .HasColumnName("cardOption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CardPrice)
                    .HasColumnName("cardPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CardStatus)
                    .IsRequired()
                    .HasColumnName("cardStatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.GiftOrderSerial)
                    .IsRequired()
                    .HasColumnName("giftOrderSerial")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MasterCardCode)
                    .IsRequired()
                    .HasColumnName("masterCardCode")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("regDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInvalidEmail>(entity =>
            {
                entity.HasKey(e => e.InvalidEmail);

                entity.ToTable("tbl_invalid_Email");

                entity.Property(e => e.InvalidEmail)
                    .HasColumnName("invalidEmail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Fixgubun)
                    .IsRequired()
                    .HasColumnName("fixgubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblInvalidUser>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_invalid_user");

                entity.HasIndex(e => e.Gubun)
                    .HasName("IX_gubun");

                entity.HasIndex(e => e.Invaliduserid)
                    .HasName("IX_invaliduserid");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text");

                entity.Property(e => e.Gubun)
                    .IsRequired()
                    .HasColumnName("gubun")
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('ONEVT')");

                entity.Property(e => e.Invaliduserid)
                    .IsRequired()
                    .HasColumnName("invaliduserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastuserid)
                    .HasColumnName("lastuserid")
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
            });

            modelBuilder.Entity<TblLogindata>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_logindata");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EncUserpass)
                    .HasColumnName("Enc_userpass")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EncUserpass64)
                    .HasColumnName("Enc_userpass64")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastrefip)
                    .HasColumnName("lastrefip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Touchrenewdate)
                    .HasColumnName("touchrenewdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Touchusing)
                    .HasColumnName("touchusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Useq)
                    .HasColumnName("useq")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Userdiv)
                    .IsRequired()
                    .HasColumnName("userdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userlevel)
                    .HasColumnName("userlevel")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.Userpass)
                    .IsRequired()
                    .HasColumnName("userpass")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserpwA)
                    .HasColumnName("userpw_a")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UserpwQ)
                    .HasColumnName("userpw_q")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMailzineNotmember>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_mailzine_notlogin");

                entity.ToTable("tbl_mailzine_notmember");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Email10x10)
                    .HasColumnName("email_10x10")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EmailFingers)
                    .HasColumnName("email_fingers")
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
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Usermail)
                    .IsRequired()
                    .HasColumnName("usermail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMileageAutoExtinctionLog>(entity =>
            {
                entity.ToTable("tbl_mileage_auto_extinction_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChkPopulation).HasColumnName("chk_population");

                entity.Property(e => e.DoneDate)
                    .HasColumnName("done_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Jukyo)
                    .HasColumnName("jukyo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jukyocd).HasColumnName("jukyocd");

                entity.Property(e => e.TaskKey).HasColumnName("task_key");

                entity.Property(e => e.UpdatedUsersCnt).HasColumnName("updated_users_cnt");
            });

            modelBuilder.Entity<TblMileageAutoExtinctionMaster>(entity =>
            {
                entity.ToTable("tbl_mileage_auto_extinction_master");

                entity.HasIndex(e => e.Jukyo)
                    .HasName("UNIQUE_JUKYO")
                    .IsUnique();

                entity.HasIndex(e => e.Jukyocd)
                    .HasName("UNIQUE_JUKYOCD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChkDays).HasColumnName("chk_days");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Jukyo)
                    .IsRequired()
                    .HasColumnName("jukyo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Jukyocd).HasColumnName("jukyocd");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Useyn)
                    .HasColumnName("useyn")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblMileageGubun>(entity =>
            {
                entity.HasKey(e => e.Jukyocd);

                entity.ToTable("tbl_mileage_gubun");

                entity.Property(e => e.Jukyocd)
                    .HasColumnName("jukyocd")
                    .ValueGeneratedNever();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Jukyoname)
                    .IsRequired()
                    .HasColumnName("jukyoname")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMileageMonthlyExpire>(entity =>
            {
                entity.HasKey(e => e.Expireidx)
                    .HasName("PK__tbl_mile__56627606C5102EE7");

                entity.ToTable("tbl_mileage_monthly_expire");

                entity.Property(e => e.Expireidx).HasColumnName("expireidx");

                entity.Property(e => e.BonusMileage)
                    .HasColumnName("bonusMileage")
                    .HasColumnType("money");

                entity.Property(e => e.EapiredMileage)
                    .HasColumnName("eapiredMileage")
                    .HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderMileage)
                    .HasColumnName("orderMileage")
                    .HasColumnType("money");

                entity.Property(e => e.OrderMinusMileage)
                    .HasColumnName("orderMinusMileage")
                    .HasColumnType("money");

                entity.Property(e => e.Procdate)
                    .HasColumnName("procdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SpendMileage)
                    .HasColumnName("spendMileage")
                    .HasColumnType("money");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Yyyymm)
                    .IsRequired()
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMileageYearExpire>(entity =>
            {
                entity.HasKey(e => new { e.RegYear, e.Userid });

                entity.ToTable("tbl_mileage_Year_Expire");

                entity.HasIndex(e => e.Userid);

                entity.Property(e => e.RegYear)
                    .HasColumnName("regYear")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Bonusgainmileage)
                    .HasColumnName("bonusgainmileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Expiredate)
                    .IsRequired()
                    .HasColumnName("expiredate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ordergainmileage)
                    .HasColumnName("ordergainmileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orderminusmileage)
                    .HasColumnName("orderminusmileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PreYearAssignedSpendmileage)
                    .HasColumnName("preYearAssignedSpendmileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.RealExpiredMileage)
                    .HasColumnName("realExpiredMileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblMileagelog>(entity =>
            {
                entity.ToTable("tbl_mileagelog");

                entity.HasIndex(e => e.Userid);

                entity.HasIndex(e => new { e.Jukyocd, e.Deleteyn });

                entity.HasIndex(e => new { e.Userid, e.Jukyocd });

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Deldate)
                    .HasColumnName("deldate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleteyn)
                    .IsRequired()
                    .HasColumnName("deleteyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ItemOption)
                    .HasColumnName("itemOption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Jukyo)
                    .HasColumnName("jukyo")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Jukyocd).HasColumnName("jukyocd");

                entity.Property(e => e.Mileage)
                    .HasColumnName("mileage")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblQrcodeLog>(entity =>
            {
                entity.HasKey(e => e.LogSn)
                    .HasName("PK__tbl_QRCodeLog__4277DAAA");

                entity.ToTable("tbl_QRCodeLog");

                entity.Property(e => e.LogSn).HasColumnName("logSn");

                entity.Property(e => e.BrowserInfo)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DevDiv)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QrSn).HasColumnName("qrSn");

                entity.Property(e => e.RefIp)
                    .IsRequired()
                    .HasColumnName("refIP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblRejectSms>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_Reject_Sms");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.AssignDate)
                    .HasColumnName("assignDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssignNo).HasColumnName("assignNo");

                entity.Property(e => e.Cid)
                    .IsRequired()
                    .HasColumnName("cid")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Receive080)
                    .IsRequired()
                    .HasColumnName("receive080")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Refip)
                    .IsRequired()
                    .HasColumnName("refip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rejectnumber)
                    .IsRequired()
                    .HasColumnName("rejectnumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTagCouponMaster>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_tag_coupon_master");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Couponname)
                    .IsRequired()
                    .HasColumnName("couponname")
                    .HasMaxLength(128);

                entity.Property(e => e.Coupontype)
                    .IsRequired()
                    .HasColumnName("coupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Couponvalue).HasColumnName("couponvalue");

                entity.Property(e => e.Etcstr)
                    .IsRequired()
                    .HasColumnName("etcstr")
                    .HasColumnType("text");

                entity.Property(e => e.Expiredate)
                    .HasColumnName("expiredate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isopenlistcoupon)
                    .IsRequired()
                    .HasColumnName("isopenlistcoupon")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Minbuyprice).HasColumnName("minbuyprice");

                entity.Property(e => e.MxCpnDiscount).HasColumnName("mxCpnDiscount");

                entity.Property(e => e.Openfinishdate)
                    .HasColumnName("openfinishdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tagstr)
                    .IsRequired()
                    .HasColumnName("tagstr")
                    .HasMaxLength(128);

                entity.Property(e => e.TargetCpnSource)
                    .HasColumnName("targetCpnSource")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TargetCpnType)
                    .HasColumnName("targetCpnType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Validsitename)
                    .HasColumnName("validsitename")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserAllowSite>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Sitegubun });

                entity.ToTable("tbl_user_allow_site");

                entity.HasIndex(e => e.Userid);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sitegubun)
                    .HasColumnName("sitegubun")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Allowdate)
                    .HasColumnName("allowdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Disallowdate)
                    .HasColumnName("disallowdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Siteusing)
                    .IsRequired()
                    .HasColumnName("siteusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUserAutoLoginCpnEvalTarget>(entity =>
            {
                entity.HasKey(e => e.Logidx);

                entity.ToTable("tbl_user_autoLogin_cpnEvalTarget");

                entity.Property(e => e.Logidx).HasColumnName("logidx");

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

            modelBuilder.Entity<TblUserB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_user_b");

                entity.Property(e => e.Addr1)
                    .HasColumnName("addr1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasColumnName("addr2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ceoname)
                    .HasColumnName("ceoname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Counter)
                    .HasColumnName("counter")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Juminno)
                    .HasColumnName("juminno")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Majoritem)
                    .HasColumnName("majoritem")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasColumnType("text");

                entity.Property(e => e.Prcemail)
                    .HasColumnName("prcemail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Prchp)
                    .HasColumnName("prchp")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Prcjob)
                    .HasColumnName("prcjob")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Prcname)
                    .HasColumnName("prcname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Prcphone)
                    .HasColumnName("prcphone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Shopform)
                    .HasColumnName("shopform")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Socfax)
                    .HasColumnName("socfax")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Socname)
                    .HasColumnName("socname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Socno)
                    .HasColumnName("socno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Socphone)
                    .HasColumnName("socphone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Target)
                    .HasColumnName("target")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Targetjob)
                    .HasColumnName("targetjob")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Targetsex)
                    .HasColumnName("targetsex")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.Upjong)
                    .HasColumnName("upjong")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Uptae)
                    .HasColumnName("uptae")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Userdiv)
                    .IsRequired()
                    .HasColumnName("userdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userpass)
                    .IsRequired()
                    .HasColumnName("userpass")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserC>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_user_c");

                entity.HasIndex(e => e.Catecode);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Acountname)
                    .HasColumnName("acountname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Acountno)
                    .HasColumnName("acountno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Artistflg)
                    .HasColumnName("artistflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Bankname)
                    .HasColumnName("bankname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BrandBestItem).HasColumnName("brandBestItem");

                entity.Property(e => e.Catecode)
                    .HasColumnName("catecode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ceoname)
                    .HasColumnName("ceoname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Coname)
                    .HasColumnName("coname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultDeliverPay)
                    .HasColumnName("defaultDeliverPay")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DefaultDeliveryType)
                    .HasColumnName("defaultDeliveryType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultFreeBeasongLimit)
                    .HasColumnName("defaultFreeBeasongLimit")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Defaultmargine)
                    .HasColumnName("defaultmargine")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Dgncomment)
                    .HasColumnName("dgncomment")
                    .HasColumnType("text");

                entity.Property(e => e.Extstreetusing)
                    .HasColumnName("extstreetusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Giftflg)
                    .HasColumnName("giftflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Giftrank)
                    .HasColumnName("giftrank")
                    .HasDefaultValueSql("(9999)");

                entity.Property(e => e.Hitflg)
                    .HasColumnName("hitflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Hitrank)
                    .HasColumnName("hitrank")
                    .HasDefaultValueSql("(9999)");

                entity.Property(e => e.Isb2b)
                    .HasColumnName("isb2b")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Isextusing)
                    .HasColumnName("isextusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Isoffusing)
                    .HasColumnName("isoffusing")
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

                entity.Property(e => e.ItemSellStdate)
                    .HasColumnName("itemSellStdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemcount)
                    .HasColumnName("itemcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Kdesignflg)
                    .HasColumnName("kdesignflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Maeipdiv)
                    .HasColumnName("maeipdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mduserid)
                    .HasColumnName("mduserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mileage)
                    .HasColumnName("mileage")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Modelbimg)
                    .HasColumnName("modelbimg")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Modelbimg2)
                    .HasColumnName("modelbimg2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Modelimg)
                    .HasColumnName("modelimg")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Modelitem).HasColumnName("modelitem");

                entity.Property(e => e.Modelitem2).HasColumnName("modelitem2");

                entity.Property(e => e.Newflg)
                    .HasColumnName("newflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Onlyflg)
                    .HasColumnName("onlyflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Prcname)
                    .HasColumnName("prcname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Prtidx)
                    .HasColumnName("prtidx")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('9999')");

                entity.Property(e => e.Rackboxno).HasColumnName("rackboxno");

                entity.Property(e => e.Recenttopbrandyn)
                    .HasColumnName("recenttopbrandyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Recommendcount)
                    .HasColumnName("recommendcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Saleflg)
                    .HasColumnName("saleflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Salerank)
                    .HasColumnName("salerank")
                    .HasDefaultValueSql("(9999)");

                entity.Property(e => e.Samebrand)
                    .HasColumnName("samebrand")
                    .HasColumnType("text");

                entity.Property(e => e.Sellrank).HasColumnName("sellrank");

                entity.Property(e => e.Smileflg)
                    .HasColumnName("smileflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Smilerank)
                    .HasColumnName("smilerank")
                    .HasDefaultValueSql("(9999)");

                entity.Property(e => e.Socaddr)
                    .HasColumnName("socaddr")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Soccell)
                    .HasColumnName("soccell")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Soccomment)
                    .HasColumnName("soccomment")
                    .HasColumnType("text");

                entity.Property(e => e.Socfax)
                    .HasColumnName("socfax")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Socicon)
                    .HasColumnName("socicon")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Socitem)
                    .HasColumnName("socitem")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Soclogo)
                    .HasColumnName("soclogo")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Socmail)
                    .HasColumnName("socmail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Socname)
                    .IsRequired()
                    .HasColumnName("socname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SocnameKor)
                    .HasColumnName("socname_kor")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Socno)
                    .IsRequired()
                    .HasColumnName("socno")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Socphone)
                    .HasColumnName("socphone")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Soctype)
                    .HasColumnName("soctype")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Socurl)
                    .HasColumnName("socurl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Specialbrand)
                    .HasColumnName("specialbrand")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.StandardCateCode)
                    .HasColumnName("standardCateCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Streetusing)
                    .HasColumnName("streetusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Titleimgurl)
                    .HasColumnName("titleimgurl")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Todayrecommendcount)
                    .HasColumnName("todayrecommendcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Todayvisitcount)
                    .HasColumnName("todayvisitcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Topbrandcount)
                    .HasColumnName("topbrandcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Userdiv)
                    .HasColumnName("userdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('02')");

                entity.Property(e => e.Vatinclude)
                    .HasColumnName("vatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Visitcount)
                    .HasColumnName("visitcount")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUserCDefaultdeliveryLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_user_c_defaultdelivery_log");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd();

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

            modelBuilder.Entity<TblUserCHoliday>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Holiday });

                entity.ToTable("tbl_user_c_holiday");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Holiday)
                    .HasColumnName("holiday")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserCoupon>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_user_coupon");

                entity.HasIndex(e => e.Masteridx);

                entity.HasIndex(e => e.Userid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Couponimage)
                    .HasColumnName("couponimage")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Couponmeaipprice)
                    .HasColumnName("couponmeaipprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Couponname)
                    .IsRequired()
                    .HasColumnName("couponname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Coupontype)
                    .IsRequired()
                    .HasColumnName("coupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Couponvalue)
                    .HasColumnName("couponvalue")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Csorderserial)
                    .HasColumnName("csorderserial")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Deleteyn)
                    .HasColumnName("deleteyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EvtprizeCode).HasColumnName("evtprize_code");

                entity.Property(e => e.Exitemid).HasColumnName("exitemid");

                entity.Property(e => e.Expiredate)
                    .HasColumnName("expiredate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Masteridx).HasColumnName("masteridx");

                entity.Property(e => e.Minbuyprice)
                    .HasColumnName("minbuyprice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.MxCpnDiscount).HasColumnName("mxCpnDiscount");

                entity.Property(e => e.Notvalid10x10)
                    .HasColumnName("notvalid10x10")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Scratchcouponidx).HasColumnName("scratchcouponidx");

                entity.Property(e => e.Ssnkey)
                    .HasColumnName("ssnkey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TargetCpnSource)
                    .HasColumnName("targetCpnSource")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TargetCpnType)
                    .HasColumnName("targetCpnType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Targetitemlist)
                    .HasColumnName("targetitemlist")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UseLevel).HasColumnName("useLevel");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Validsitename)
                    .HasColumnName("validsitename")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserCouponMaster>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_user_coupon_master");

                entity.HasIndex(e => new { e.TargetCpnType, e.TargetCpnSource })
                    .HasName("IX_tbl_user_coupon_master_targetCpn");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Couponimage)
                    .HasColumnName("couponimage")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Couponmeaipprice)
                    .HasColumnName("couponmeaipprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Couponname)
                    .IsRequired()
                    .HasColumnName("couponname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Coupontype)
                    .IsRequired()
                    .HasColumnName("coupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Couponvalue).HasColumnName("couponvalue");

                entity.Property(e => e.Etcstr)
                    .HasColumnName("etcstr")
                    .HasColumnType("text");

                entity.Property(e => e.Expiredate)
                    .HasColumnName("expiredate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isopenlistcoupon)
                    .HasColumnName("isopenlistcoupon")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Isweekendcoupon)
                    .HasColumnName("isweekendcoupon")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Minbuyprice)
                    .HasColumnName("minbuyprice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MxCpnDiscount).HasColumnName("mxCpnDiscount");

                entity.Property(e => e.Openfinishdate)
                    .HasColumnName("openfinishdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TargetCpnSource)
                    .HasColumnName("targetCpnSource")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TargetCpnType)
                    .HasColumnName("targetCpnType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Targetitemlist)
                    .HasColumnName("targetitemlist")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Validsitename)
                    .HasColumnName("validsitename")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserCouponOpenlist>(entity =>
            {
                entity.HasKey(e => new { e.Masteridx, e.Userid });

                entity.ToTable("tbl_user_coupon_openlist");

                entity.Property(e => e.Masteridx).HasColumnName("masteridx");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblUserCurrentDeposit>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_user_current_deposit");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Currentdeposit)
                    .HasColumnName("currentdeposit")
                    .HasColumnType("money");

                entity.Property(e => e.Gaindeposit)
                    .HasColumnName("gaindeposit")
                    .HasColumnType("money");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Spenddeposit)
                    .HasColumnName("spenddeposit")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblUserCurrentMileage>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_user_current_mileage");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Academymileage)
                    .HasColumnName("academymileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Bonusmileage)
                    .HasColumnName("bonusmileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Currentmileage)
                    .HasColumnName("currentmileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ExpiredMile)
                    .HasColumnName("expiredMile")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Flowerjumunmileage)
                    .HasColumnName("flowerjumunmileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Jumunmileage)
                    .HasColumnName("jumunmileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Michulmile)
                    .HasColumnName("michulmile")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MichulmileAca)
                    .HasColumnName("michulmileACA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Spendmileage)
                    .HasColumnName("spendmileage")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblUserDiv>(entity =>
            {
                entity.HasKey(e => e.Divcode);

                entity.ToTable("tbl_user_div");

                entity.Property(e => e.Divcode)
                    .HasColumnName("divcode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Divename)
                    .IsRequired()
                    .HasColumnName("divename")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Divgbn)
                    .IsRequired()
                    .HasColumnName("divgbn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUserHitchhiker>(entity =>
            {
                entity.HasKey(e => new { e.Hvol, e.Userid })
                    .HasName("PK__tbl_user_hitchhi__114A936A");

                entity.ToTable("tbl_user_hitchhiker");

                entity.Property(e => e.Hvol).HasColumnName("HVol");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AdminId)
                    .HasColumnName("AdminID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RecevieName)
                    .HasColumnName("recevieName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Useraddr)
                    .HasColumnName("useraddr")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Usercell)
                    .HasColumnName("usercell")
                    .HasMaxLength(16)
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

            modelBuilder.Entity<TblUserLoginLastguid>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_user_login_lastguid");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastguid)
                    .IsRequired()
                    .HasColumnName("lastguid")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdt)
                    .HasColumnName("lastupdt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regdt)
                    .HasColumnName("regdt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblUserN>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_user_n");

                entity.HasIndex(e => e.ConnInfo);

                entity.HasIndex(e => e.Jumin1);

                entity.HasIndex(e => e.Juminno);

                entity.HasIndex(e => e.Usercell);

                entity.HasIndex(e => e.Usermail);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("datetime");

                entity.Property(e => e.ConnInfo)
                    .HasColumnName("connInfo")
                    .HasMaxLength(88)
                    .IsUnicode(false);

                entity.Property(e => e.DupeInfo)
                    .HasColumnName("dupeInfo")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Email10x10)
                    .HasColumnName("email_10x10")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmailWay2way)
                    .HasColumnName("email_way2way")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Emailok)
                    .HasColumnName("emailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EncJumin2)
                    .HasColumnName("Enc_jumin2")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eventid)
                    .HasColumnName("eventid")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.IPinCheck)
                    .HasColumnName("iPinCheck")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsEmailChk)
                    .HasColumnName("isEmailChk")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsMobileChk)
                    .HasColumnName("isMobileChk")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Issolar)
                    .HasColumnName("issolar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Jumin1)
                    .HasColumnName("jumin1")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Juminno)
                    .IsRequired()
                    .HasColumnName("juminno")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mileage)
                    .HasColumnName("mileage")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Rdsite)
                    .HasColumnName("rdsite")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Realnamecheck)
                    .HasColumnName("realnamecheck")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sexflag)
                    .HasColumnName("sexflag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sitegubun)
                    .HasColumnName("sitegubun")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Smsok)
                    .HasColumnName("smsok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmsokFingers)
                    .HasColumnName("smsok_fingers")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserStat)
                    .HasColumnName("userStat")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Useraddr)
                    .IsRequired()
                    .HasColumnName("useraddr")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Usercell)
                    .HasColumnName("usercell")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Usercomment)
                    .HasColumnName("usercomment")
                    .HasColumnType("text");

                entity.Property(e => e.Usericon)
                    .HasColumnName("usericon")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsericonNo).HasColumnName("usericonNo");

                entity.Property(e => e.Userlogo)
                    .HasColumnName("userlogo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Usermail)
                    .HasColumnName("usermail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
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
                    .IsRequired()
                    .HasColumnName("zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblUserSns>(entity =>
            {
                entity.HasKey(e => new { e.Snsgubun, e.Tenbytenid })
                    .HasName("PK_tbl_user_sns_1");

                entity.ToTable("tbl_user_sns");

                entity.HasIndex(e => new { e.Tenbytenid, e.Snsid, e.Isusing })
                    .HasName("IX_tbl_user_sns_tenbytenid");

                entity.Property(e => e.Snsgubun)
                    .HasColumnName("snsgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tenbytenid)
                    .HasColumnName("tenbytenid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Nickname)
                    .HasColumnName("nickname")
                    .HasMaxLength(50);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sexflag)
                    .HasColumnName("sexflag")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Snsid)
                    .IsRequired()
                    .HasColumnName("snsid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usermail)
                    .IsRequired()
                    .HasColumnName("usermail")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserSnsToken>(entity =>
            {
                entity.HasKey(e => new { e.Snsid, e.Snsgubun });

                entity.ToTable("tbl_user_sns_token");

                entity.Property(e => e.Snsid)
                    .HasColumnName("snsid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Snsgubun)
                    .HasColumnName("snsgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Snstoken)
                    .IsRequired()
                    .HasColumnName("snstoken")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<TblUserSsn>(entity =>
            {
                entity.HasKey(e => e.SsnHash);

                entity.ToTable("tbl_user_SSN");

                entity.HasIndex(e => e.Ssnuserid)
                    .HasName("IX_tbl_user_SSN_userid");

                entity.Property(e => e.SsnHash)
                    .HasColumnName("ssnHash")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lgnchannel)
                    .HasColumnName("lgnchannel")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ssndata)
                    .HasColumnName("ssndata")
                    .HasMaxLength(384);

                entity.Property(e => e.SsnkeepAddtime)
                    .HasColumnName("ssnkeepAddtime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ssnlogindt)
                    .IsRequired()
                    .HasColumnName("ssnlogindt")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Ssnuserid)
                    .IsRequired()
                    .HasColumnName("ssnuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUsersegCate>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Dispcate });

                entity.ToTable("tbl_userseg_cate");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Dispcate).HasColumnName("dispcate");

                entity.Property(e => e.Ratio).HasColumnName("ratio");
            });

            modelBuilder.Entity<TblUsersegCateTmp>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Dispcate });

                entity.ToTable("tbl_userseg_cate_tmp");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Dispcate).HasColumnName("dispcate");

                entity.Property(e => e.Ratio).HasColumnName("ratio");
            });

            modelBuilder.Entity<TrgTblUserC>(entity =>
            {
                entity.HasKey(e => e.Logidx);

                entity.ToTable("trg_tbl_user_c");

                entity.Property(e => e.Logidx).HasColumnName("logidx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrgMode)
                    .IsRequired()
                    .HasColumnName("trgMode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBrandList2017>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_BrandList2017");

                entity.Property(e => e.Artistflg)
                    .HasColumnName("artistflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EngDiv)
                    .HasColumnName("eng_div")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Giftflg)
                    .HasColumnName("giftflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hitflg)
                    .HasColumnName("hitflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Kdesignflg)
                    .HasColumnName("kdesignflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KorDiv)
                    .IsRequired()
                    .HasColumnName("kor_div")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Newflg)
                    .HasColumnName("newflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Onlyflg)
                    .HasColumnName("onlyflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recommendcount).HasColumnName("recommendcount");

                entity.Property(e => e.Saleflg)
                    .HasColumnName("saleflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sellrank).HasColumnName("sellrank");

                entity.Property(e => e.Smileflg)
                    .HasColumnName("smileflg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Socname)
                    .IsRequired()
                    .HasColumnName("socname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SocnameKor)
                    .HasColumnName("socname_kor")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SortEng).HasColumnName("sort_eng");

                entity.Property(e => e.SortKor).HasColumnName("sort_kor");

                entity.Property(e => e.Todayrecommendcount).HasColumnName("todayrecommendcount");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserBirthdayMailList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserBirthdayMailList");

                entity.Property(e => e.CpendDt)
                    .HasColumnName("CPEndDt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CpstartDt)
                    .HasColumnName("CPStartDt")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ubirth)
                    .HasColumnName("UBirth")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListAgreeInfoTargetMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_AgreeInfo_TargetMail");

                entity.Property(e => e.AgreeEmailTen)
                    .HasColumnName("agreeEmailTen")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.AgreeSmsten)
                    .HasColumnName("agreeSMSTen")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Currentdate)
                    .HasColumnName("currentdate")
                    .HasMaxLength(98);

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListEventLuckyletter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_event_luckyletter");

                entity.Property(e => e.Currentdate)
                    .HasColumnName("currentdate")
                    .HasMaxLength(98);

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListFingersClaim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_fingersClaim");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListGradeFamily>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_grade_Family");

                entity.Property(e => e.Currentdate)
                    .HasColumnName("currentdate")
                    .HasMaxLength(98);

                entity.Property(e => e.Currentmonth)
                    .HasColumnName("currentmonth")
                    .HasMaxLength(32);

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListGradeRed>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_grade_RED");

                entity.Property(e => e.Currentdate)
                    .HasColumnName("currentdate")
                    .HasMaxLength(98);

                entity.Property(e => e.Currentmonth)
                    .HasColumnName("currentmonth")
                    .HasMaxLength(32);

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListGradeStaff>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_grade_Staff");

                entity.Property(e => e.Currentdate)
                    .HasColumnName("currentdate")
                    .HasMaxLength(98);

                entity.Property(e => e.Currentmonth)
                    .HasColumnName("currentmonth")
                    .HasMaxLength(32);

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListGradeVip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_grade_VIP");

                entity.Property(e => e.Currentdate)
                    .HasColumnName("currentdate")
                    .HasMaxLength(98);

                entity.Property(e => e.Currentmonth)
                    .HasColumnName("currentmonth")
                    .HasMaxLength(32);

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListGradeVipGoldSilver>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_grade_VIP_GOLD_SILVER");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListGradeVipGoldSilverBlue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_grade_VIP_GOLD_SILVER_BLUE");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListGradeVipgold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_grade_VIPGOLD");

                entity.Property(e => e.Currentdate)
                    .HasColumnName("currentdate")
                    .HasMaxLength(98);

                entity.Property(e => e.Currentmonth)
                    .HasColumnName("currentmonth")
                    .HasMaxLength(32);

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListGradeVvip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_grade_VVIP");

                entity.Property(e => e.Currentdate)
                    .HasColumnName("currentdate")
                    .HasMaxLength(98);

                entity.Property(e => e.Currentmonth)
                    .HasColumnName("currentmonth")
                    .HasMaxLength(32);

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListHalf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_half");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(34)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListHalfAfter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_half_after");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rownum).HasColumnName("rownum");

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListHalfBefore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_half_before");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rownum).HasColumnName("rownum");

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMetropolitan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_Metropolitan");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMetropolitan경상>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_Metropolitan_경상");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMetropolitan수도권제주>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_Metropolitan_수도권_제주");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMetropolitan전주>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_Metropolitan_전주");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMetropolitan제주>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_Metropolitan_제주");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMileExpireTargetMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_MileExpire_TargetMail");

                entity.Property(e => e.Mayexpiremile)
                    .HasColumnName("mayexpiremile")
                    .HasMaxLength(4000);

                entity.Property(e => e.Totalmileage)
                    .HasColumnName("totalmileage")
                    .HasMaxLength(4000);

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("uname")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMonthUpgradeBlue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_MonthUPgrade_BLUE");

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMonthUpgradeGreen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_MonthUPgrade_GREEN");

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMonthUpgradeVipgold>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_MonthUPgrade_VIPGOLD");

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListMonthUpgradeVipsilver>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_MonthUPgrade_VIPSILVER");

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListNotmember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_notmember");

                entity.Property(e => e.Email10x10)
                    .HasColumnName("email_10x10")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmailFingers)
                    .HasColumnName("email_fingers")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usermail)
                    .HasColumnName("usermail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListTargetMail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_TargetMail");

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_temp");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("UName")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwUserMailListUserlevelDown>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserMailList_userlevel_down");

                entity.Property(e => e.Fingersmailok)
                    .HasColumnName("fingersmailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mailok)
                    .HasColumnName("mailok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Umail)
                    .HasColumnName("UMail")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .HasColumnName("UName")
                    .HasMaxLength(33)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XTblUserSsnV2>(entity =>
            {
                entity.HasKey(e => e.SsnHash)
                    .HasName("PK_tbl_user_SSN_V2");

                entity.ToTable("X_tbl_user_SSN_V2");

                entity.Property(e => e.SsnHash)
                    .HasColumnName("ssnHash")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lgnchannel)
                    .HasColumnName("lgnchannel")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ssndata)
                    .HasColumnName("ssndata")
                    .HasMaxLength(384);

                entity.Property(e => e.SsnkeepAddtime).HasColumnName("ssnkeepAddtime");

                entity.Property(e => e.Ssnlogindt)
                    .IsRequired()
                    .HasColumnName("ssnlogindt")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Ssnuserid)
                    .IsRequired()
                    .HasColumnName("ssnuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
