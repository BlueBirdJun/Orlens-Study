using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace db_migration.etcmall
{
    public partial class db_etcmallContext : DbContext
    {
        public db_etcmallContext()
        {
        }

        public db_etcmallContext(DbContextOptions<db_etcmallContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tbl11stCateMapping> Tbl11stCateMapping { get; set; }
        public virtual DbSet<Tbl11stRegItem> Tbl11stRegItem { get; set; }
        public virtual DbSet<TblApiKeyLog> TblApiKeyLog { get; set; }
        public virtual DbSet<TblApiKeyManager> TblApiKeyManager { get; set; }
        public virtual DbSet<TblAuction1010RegItem> TblAuction1010RegItem { get; set; }
        public virtual DbSet<TblAuctionCateMapping> TblAuctionCateMapping { get; set; }
        public virtual DbSet<TblAuctionRegItem> TblAuctionRegItem { get; set; }
        public virtual DbSet<TblBetweenCate> TblBetweenCate { get; set; }
        public virtual DbSet<TblBetweenCateItem> TblBetweenCateItem { get; set; }
        public virtual DbSet<TblBetweenEventComment> TblBetweenEventComment { get; set; }
        public virtual DbSet<TblBetweenMain3banner> TblBetweenMain3banner { get; set; }
        public virtual DbSet<TblBetweenMainTopbanner> TblBetweenMainTopbanner { get; set; }
        public virtual DbSet<TblBetweenNoticefaq> TblBetweenNoticefaq { get; set; }
        public virtual DbSet<TblBetweenProject> TblBetweenProject { get; set; }
        public virtual DbSet<TblBetweenProjectGroup> TblBetweenProjectGroup { get; set; }
        public virtual DbSet<TblBetweenProjectGroupItem> TblBetweenProjectGroupItem { get; set; }
        public virtual DbSet<TblBetweenSearchLikeWord> TblBetweenSearchLikeWord { get; set; }
        public virtual DbSet<TblBetweenUserInfo> TblBetweenUserInfo { get; set; }
        public virtual DbSet<TblCjMallPrdDivMapping> TblCjMallPrdDivMapping { get; set; }
        public virtual DbSet<TblCjmallCateMapping> TblCjmallCateMapping { get; set; }
        public virtual DbSet<TblCjmallCategory> TblCjmallCategory { get; set; }
        public virtual DbSet<TblColorImageVisionApiKserchMap> TblColorImageVisionApiKserchMap { get; set; }
        public virtual DbSet<TblColorImageVisionApiQue> TblColorImageVisionApiQue { get; set; }
        public virtual DbSet<TblColorImageVisionApiResult> TblColorImageVisionApiResult { get; set; }
        public virtual DbSet<TblColorImageVisionApiResultRow> TblColorImageVisionApiResultRow { get; set; }
        public virtual DbSet<TblColorImageVisionApiTopColor> TblColorImageVisionApiTopColor { get; set; }
        public virtual DbSet<TblCoupangBranddeliveryMapping> TblCoupangBranddeliveryMapping { get; set; }
        public virtual DbSet<TblCoupangCateMapping> TblCoupangCateMapping { get; set; }
        public virtual DbSet<TblCoupangCategory> TblCoupangCategory { get; set; }
        public virtual DbSet<TblCoupangCouponCateDetail> TblCoupangCouponCateDetail { get; set; }
        public virtual DbSet<TblCoupangCouponItemDetail> TblCoupangCouponItemDetail { get; set; }
        public virtual DbSet<TblCoupangCouponMaster> TblCoupangCouponMaster { get; set; }
        public virtual DbSet<TblCoupangDeliveryLog> TblCoupangDeliveryLog { get; set; }
        public virtual DbSet<TblCoupangInfoCodeMap> TblCoupangInfoCodeMap { get; set; }
        public virtual DbSet<TblCoupangRegItem> TblCoupangRegItem { get; set; }
        public virtual DbSet<TblCoupangRegedoption> TblCoupangRegedoption { get; set; }
        public virtual DbSet<TblCpApilog> TblCpApilog { get; set; }
        public virtual DbSet<TblCpInfocdCheck> TblCpInfocdCheck { get; set; }
        public virtual DbSet<TblCpManager> TblCpManager { get; set; }
        public virtual DbSet<TblEbayCateMapping> TblEbayCateMapping { get; set; }
        public virtual DbSet<TblEbayEsmCategory> TblEbayEsmCategory { get; set; }
        public virtual DbSet<TblEzwelCateMapping> TblEzwelCateMapping { get; set; }
        public virtual DbSet<TblEzwelNewcateMapping> TblEzwelNewcateMapping { get; set; }
        public virtual DbSet<TblEzwelRegItem> TblEzwelRegItem { get; set; }
        public virtual DbSet<TblForeignMallRegedoption> TblForeignMallRegedoption { get; set; }
        public virtual DbSet<TblGmarket1010RegItem> TblGmarket1010RegItem { get; set; }
        public virtual DbSet<TblGmarketAddressBook> TblGmarketAddressBook { get; set; }
        public virtual DbSet<TblGmarketBrandMapping> TblGmarketBrandMapping { get; set; }
        public virtual DbSet<TblGmarketCateMapping> TblGmarketCateMapping { get; set; }
        public virtual DbSet<TblGmarketRegItem> TblGmarketRegItem { get; set; }
        public virtual DbSet<TblGsshopAddoptionRegitem> TblGsshopAddoptionRegitem { get; set; }
        public virtual DbSet<TblGsshopBrandDeliveryMapping> TblGsshopBrandDeliveryMapping { get; set; }
        public virtual DbSet<TblGsshopCateMapping> TblGsshopCateMapping { get; set; }
        public virtual DbSet<TblGsshopPrdDivMapping> TblGsshopPrdDivMapping { get; set; }
        public virtual DbSet<TblHalfclubCateMapping> TblHalfclubCateMapping { get; set; }
        public virtual DbSet<TblHalfclubRegItem> TblHalfclubRegItem { get; set; }
        public virtual DbSet<TblHmallCateMapping> TblHmallCateMapping { get; set; }
        public virtual DbSet<TblHmallCategory> TblHmallCategory { get; set; }
        public virtual DbSet<TblHmallInfoCodeMap> TblHmallInfoCodeMap { get; set; }
        public virtual DbSet<TblHmallProductReq> TblHmallProductReq { get; set; }
        public virtual DbSet<TblHmallRegItem> TblHmallRegItem { get; set; }
        public virtual DbSet<TblHmallRegedOption> TblHmallRegedOption { get; set; }
        public virtual DbSet<TblHmallSepcialCateMapping> TblHmallSepcialCateMapping { get; set; }
        public virtual DbSet<TblHmallSpecialCategory> TblHmallSpecialCategory { get; set; }
        public virtual DbSet<TblHomeplusBrandCategoryMapping> TblHomeplusBrandCategoryMapping { get; set; }
        public virtual DbSet<TblHomeplusBrandcategory> TblHomeplusBrandcategory { get; set; }
        public virtual DbSet<TblHomeplusCateMapping> TblHomeplusCateMapping { get; set; }
        public virtual DbSet<TblHomeplusDispcategory> TblHomeplusDispcategory { get; set; }
        public virtual DbSet<TblHomeplusPrdDivMapping> TblHomeplusPrdDivMapping { get; set; }
        public virtual DbSet<TblHomeplusRegItem> TblHomeplusRegItem { get; set; }
        public virtual DbSet<TblJaehumallHopeSell> TblJaehumallHopeSell { get; set; }
        public virtual DbSet<TblJaehumallHopeSellLog> TblJaehumallHopeSellLog { get; set; }
        public virtual DbSet<TblKakaoGiftCateMapping> TblKakaoGiftCateMapping { get; set; }
        public virtual DbSet<TblKakaoGiftCategory> TblKakaoGiftCategory { get; set; }
        public virtual DbSet<TblKakaoGiftRegItem> TblKakaoGiftRegItem { get; set; }
        public virtual DbSet<TblKakaogiftRegitemoption> TblKakaogiftRegitemoption { get; set; }
        public virtual DbSet<TblLfmallCateMapping> TblLfmallCateMapping { get; set; }
        public virtual DbSet<TblLfmallCategory> TblLfmallCategory { get; set; }
        public virtual DbSet<TblLfmallNotiMapping> TblLfmallNotiMapping { get; set; }
        public virtual DbSet<TblLfmallNotilist> TblLfmallNotilist { get; set; }
        public virtual DbSet<TblLfmallRegItem> TblLfmallRegItem { get; set; }
        public virtual DbSet<TblLfmallRegedoption> TblLfmallRegedoption { get; set; }
        public virtual DbSet<TblLotteAddOptionRegItem> TblLotteAddOptionRegItem { get; set; }
        public virtual DbSet<TblLtimallAddoptionRegitem> TblLtimallAddoptionRegitem { get; set; }
        public virtual DbSet<TblMy11stCateMapping> TblMy11stCateMapping { get; set; }
        public virtual DbSet<TblMy11stCategory> TblMy11stCategory { get; set; }
        public virtual DbSet<TblMy11stOption> TblMy11stOption { get; set; }
        public virtual DbSet<TblMy11stRegItem> TblMy11stRegItem { get; set; }
        public virtual DbSet<TblNvshopMapItem> TblNvshopMapItem { get; set; }
        public virtual DbSet<TblNvstorefarmCateMapping> TblNvstorefarmCateMapping { get; set; }
        public virtual DbSet<TblNvstorefarmCategory> TblNvstorefarmCategory { get; set; }
        public virtual DbSet<TblNvstorefarmImage> TblNvstorefarmImage { get; set; }
        public virtual DbSet<TblNvstorefarmRegItem> TblNvstorefarmRegItem { get; set; }
        public virtual DbSet<TblNvstorefarmUploadimage> TblNvstorefarmUploadimage { get; set; }
        public virtual DbSet<TblNvstorefarmclassImage> TblNvstorefarmclassImage { get; set; }
        public virtual DbSet<TblNvstorefarmclassRegItem> TblNvstorefarmclassRegItem { get; set; }
        public virtual DbSet<TblOutmallApiQue> TblOutmallApiQue { get; set; }
        public virtual DbSet<TblOutmallChangePoint> TblOutmallChangePoint { get; set; }
        public virtual DbSet<TblOutmallConstExceptItem> TblOutmallConstExceptItem { get; set; }
        public virtual DbSet<TblOutmallConstExceptItemCjmall> TblOutmallConstExceptItemCjmall { get; set; }
        public virtual DbSet<TblOutmallConstExceptItemCoupang> TblOutmallConstExceptItemCoupang { get; set; }
        public virtual DbSet<TblOutmallConstExceptItemGseshop> TblOutmallConstExceptItemGseshop { get; set; }
        public virtual DbSet<TblOutmallConstExceptItemLottecom> TblOutmallConstExceptItemLottecom { get; set; }
        public virtual DbSet<TblOutmallConstExceptItemSsg> TblOutmallConstExceptItemSsg { get; set; }
        public virtual DbSet<TblOutmallDiffOrder> TblOutmallDiffOrder { get; set; }
        public virtual DbSet<TblOutmallEtcTextItem> TblOutmallEtcTextItem { get; set; }
        public virtual DbSet<TblOutmallIni> TblOutmallIni { get; set; }
        public virtual DbSet<TblOutmallItemManager> TblOutmallItemManager { get; set; }
        public virtual DbSet<TblOutmallKeywords> TblOutmallKeywords { get; set; }
        public virtual DbSet<TblOutmallLimtBrand> TblOutmallLimtBrand { get; set; }
        public virtual DbSet<TblOutmallMarginCheck> TblOutmallMarginCheck { get; set; }
        public virtual DbSet<TblOutmallMustPriceItem> TblOutmallMustPriceItem { get; set; }
        public virtual DbSet<TblOutmallNewItemApiQue> TblOutmallNewItemApiQue { get; set; }
        public virtual DbSet<TblOutmallNotKeywords> TblOutmallNotKeywords { get; set; }
        public virtual DbSet<TblOutmallOptionApiQue> TblOutmallOptionApiQue { get; set; }
        public virtual DbSet<TblOutmallOptionManager> TblOutmallOptionManager { get; set; }
        public virtual DbSet<TblOverseasSale> TblOverseasSale { get; set; }
        public virtual DbSet<TblOverseasSaleItem> TblOverseasSaleItem { get; set; }
        public virtual DbSet<TblSabangnetRegItem> TblSabangnetRegItem { get; set; }
        public virtual DbSet<TblShopifyCateMapping> TblShopifyCateMapping { get; set; }
        public virtual DbSet<TblShopifyCollections> TblShopifyCollections { get; set; }
        public virtual DbSet<TblShopifyRegItem> TblShopifyRegItem { get; set; }
        public virtual DbSet<TblSsgCateMapping> TblSsgCateMapping { get; set; }
        public virtual DbSet<TblSsgCategory> TblSsgCategory { get; set; }
        public virtual DbSet<TblSsgDispCateMapping> TblSsgDispCateMapping { get; set; }
        public virtual DbSet<TblSsgMarginCateDetail> TblSsgMarginCateDetail { get; set; }
        public virtual DbSet<TblSsgMarginCateMaster> TblSsgMarginCateMaster { get; set; }
        public virtual DbSet<TblSsgMarginItemDetail> TblSsgMarginItemDetail { get; set; }
        public virtual DbSet<TblSsgMarginItemMaster> TblSsgMarginItemMaster { get; set; }
        public virtual DbSet<TblSsgMmgCategory> TblSsgMmgCategory { get; set; }
        public virtual DbSet<TblSsgRegItem> TblSsgRegItem { get; set; }
        public virtual DbSet<TblSyrupCouponLog> TblSyrupCouponLog { get; set; }
        public virtual DbSet<TblTargetMallNotInItemid> TblTargetMallNotInItemid { get; set; }
        public virtual DbSet<TblTargetMallNotInMakerid> TblTargetMallNotInMakerid { get; set; }
        public virtual DbSet<TblWemakeCateMapping> TblWemakeCateMapping { get; set; }
        public virtual DbSet<TblWemakeCategory> TblWemakeCategory { get; set; }
        public virtual DbSet<TblWemakeCategory2> TblWemakeCategory2 { get; set; }
        public virtual DbSet<TblWemakeDealItem> TblWemakeDealItem { get; set; }
        public virtual DbSet<TblWemakeDealOption> TblWemakeDealOption { get; set; }
        public virtual DbSet<TblWemakeInfoCodeMap> TblWemakeInfoCodeMap { get; set; }
        public virtual DbSet<TblWemakeRegItem> TblWemakeRegItem { get; set; }
        public virtual DbSet<TblZilingoAttrMapping> TblZilingoAttrMapping { get; set; }
        public virtual DbSet<TblZilingoCateMapping> TblZilingoCateMapping { get; set; }
        public virtual DbSet<TblZilingoCategory> TblZilingoCategory { get; set; }
        public virtual DbSet<TblZilingoRegItem> TblZilingoRegItem { get; set; }
        public virtual DbSet<TblZilingoSubCategory> TblZilingoSubCategory { get; set; }

        // Unable to generate entity type for table 'dbo.tbl_outmall_API_Que_Summary'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ebay_siteCategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ebay_matchCategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_coupang_categorynoti'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_coupang_categorymeta'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_gmarket_brand'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_outmall_daily_regSTAT'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_gmarket_tmpCate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_gmarket_category'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_11st_category'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_apiKey_ipaddress'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_auction_category'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_homeplus_dftcategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ezwel_Newcategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_auction_Nation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_halfclub_category'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_jikbang_oneDay'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_nvshop_mapItem_TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_lfmall_InfoCodeMap'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ezwel_category'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_cjMall_prdDiv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_cjmall_PrddivMid_map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_gsshop_category'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_gsshop_prddiv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_kakaoGift_regItem2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_hmall_fakeInfoCodeMap'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = 192.168.50.3; Initial Catalog = db_etcmall; User ID = udb_tenbytendevel; Password=ten101010#;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Tbl11stCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_11st_cate_mapping");

                entity.Property(e => e.DepthCode).HasColumnName("depthCode");

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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tbl11stRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_st11_regItem");

                entity.ToTable("tbl_11st_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

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

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

                entity.Property(e => e.SaleRegdate)
                    .HasColumnName("saleRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.St11GoodNo)
                    .HasColumnName("st11GoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.St11LastUpdate)
                    .HasColumnName("st11LastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.St11Price)
                    .HasColumnName("st11Price")
                    .HasColumnType("money");

                entity.Property(e => e.St11Regdate)
                    .HasColumnName("st11Regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.St11SellYn)
                    .IsRequired()
                    .HasColumnName("st11SellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.St11StatCd).HasColumnName("st11StatCd");
            });

            modelBuilder.Entity<TblApiKeyLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_apiKey_Log");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ApiKey)
                    .HasColumnName("apiKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Gubun)
                    .IsRequired()
                    .HasColumnName("gubun")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Xmldata)
                    .HasColumnName("xmldata")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblApiKeyManager>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_apiKey_manager");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ApiKey)
                    .IsRequired()
                    .HasColumnName("apiKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAuction1010RegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_Auction1010_regItem");

                entity.ToTable("tbl_auction1010_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AuctionGoodNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuctionLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.AuctionPrice).HasColumnType("money");

                entity.Property(e => e.AuctionRegdate).HasColumnType("datetime");

                entity.Property(e => e.AuctionSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.DisplayDate).HasColumnType("datetime");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

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

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

            modelBuilder.Entity<TblAuctionCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_auction_cate_mapping");

                entity.Property(e => e.DepthCode).HasColumnName("depthCode");

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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAuctionRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_Auction_regItem");

                entity.ToTable("tbl_auction_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apiaddgosi)
                    .HasColumnName("APIaddgosi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Apiadditem)
                    .HasColumnName("APIadditem")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Apiaddopt)
                    .HasColumnName("APIaddopt")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuctionGoodNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuctionLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.AuctionPrice).HasColumnType("money");

                entity.Property(e => e.AuctionRegdate).HasColumnType("datetime");

                entity.Property(e => e.AuctionSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

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

                entity.Property(e => e.OnSaleRegdate).HasColumnType("datetime");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

                entity.Property(e => e.Dispyn)
                    .HasColumnName("dispyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBetweenCateItem>(entity =>
            {
                entity.HasKey(e => new { e.Catecode, e.Itemid });

                entity.ToTable("tbl_between_cate_item");

                entity.HasIndex(e => e.Itemid);

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
                    .IsUnicode(false);

                entity.Property(e => e.Isdisplay)
                    .IsRequired()
                    .HasColumnName("isdisplay")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");
            });

            modelBuilder.Entity<TblBetweenEventComment>(entity =>
            {
                entity.HasKey(e => e.EvtcomIdx);

                entity.ToTable("tbl_between_event_comment");

                entity.Property(e => e.EvtcomIdx).HasColumnName("evtcom_idx");

                entity.Property(e => e.Blogurl)
                    .HasColumnName("blogurl")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Device)
                    .HasColumnName("device")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.EvtbbsIdx).HasColumnName("evtbbs_idx");

                entity.Property(e => e.EvtcomPoint).HasColumnName("evtcom_point");

                entity.Property(e => e.EvtcomRegdate)
                    .HasColumnName("evtcom_regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EvtcomTxt)
                    .IsRequired()
                    .HasColumnName("evtcom_txt")
                    .IsUnicode(false);

                entity.Property(e => e.EvtcomUsing)
                    .IsRequired()
                    .HasColumnName("evtcom_using")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EvtgroupCode).HasColumnName("evtgroup_code");

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Userphone)
                    .HasColumnName("userphone")
                    .HasMaxLength(15)
                    .IsUnicode(false);
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
                    .IsUnicode(false);

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

            modelBuilder.Entity<TblBetweenMainTopbanner>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_between_main_topbanner");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BanBgcolor)
                    .IsRequired()
                    .HasColumnName("BanBGColor")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.BanTxtColor)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Bantext1)
                    .IsRequired()
                    .HasColumnName("bantext1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Bantext2)
                    .IsRequired()
                    .HasColumnName("bantext2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Imgurl)
                    .IsRequired()
                    .HasColumnName("imgurl")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lastadminid)
                    .HasColumnName("lastadminid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("linkURL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerNmColor)
                    .IsRequired()
                    .HasColumnName("partnerNmColor")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PjtKind)
                    .IsRequired()
                    .HasColumnName("pjt_kind")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
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
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(150)
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
                    .IsUnicode(false);

                entity.Property(e => e.PjtKind)
                    .IsRequired()
                    .HasColumnName("pjt_kind")
                    .HasMaxLength(1)
                    .IsUnicode(false);

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
                    .IsUnicode(false);

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
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBetweenProjectGroupItem>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.PjtCode, e.Itemid });

                entity.ToTable("tbl_between_project_groupItem");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PjtCode).HasColumnName("pjt_code");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.MainMdpickXmlregdate)
                    .HasColumnName("MainMdpickXMLRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PjtgroupCode).HasColumnName("pjtgroup_code");

                entity.Property(e => e.PjtitemSort)
                    .HasColumnName("pjtitem_sort")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblBetweenSearchLikeWord>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_between_search_likeWord");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Likeword)
                    .IsRequired()
                    .HasColumnName("likeword")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("updateDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBetweenUserInfo>(entity =>
            {
                entity.HasKey(e => e.UserSn)
                    .HasName("PK__tbl_between_user__1A14E395");

                entity.ToTable("tbl_between_userInfo");

                entity.HasIndex(e => e.BtwUserCd);

                entity.Property(e => e.UserSn).HasColumnName("userSn");

                entity.Property(e => e.BtwUserCd)
                    .IsRequired()
                    .HasColumnName("btwUserCd")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtnGender)
                    .HasColumnName("ptnGender")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PtnUserCd)
                    .HasColumnName("ptnUserCd")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCjMallPrdDivMapping>(entity =>
            {
                entity.HasKey(e => new { e.CddKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_cjMall_prdDiv_mapping");

                entity.Property(e => e.CddKey)
                    .HasMaxLength(20)
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
                    .IsUnicode(false);

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblCjmallCategory>(entity =>
            {
                entity.HasKey(e => e.CateKey)
                    .HasName("PK_tbl_cjmall_Category2");

                entity.ToTable("tbl_cjmall_Category");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Categbn)
                    .HasColumnName("categbn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DName)
                    .IsRequired()
                    .HasColumnName("D_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("L_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MName)
                    .IsRequired()
                    .HasColumnName("M_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("S_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblColorImageVisionApiKserchMap>(entity =>
            {
                entity.HasKey(e => e.ColorName);

                entity.ToTable("tbl_colorImage_Vision_Api_KserchMap");

                entity.Property(e => e.ColorName)
                    .HasColumnName("colorName")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ColorCode)
                    .IsRequired()
                    .HasColumnName("colorCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ColorGrpCode)
                    .IsRequired()
                    .HasColumnName("colorGrpCode")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblColorImageVisionApiQue>(entity =>
            {
                entity.HasKey(e => e.ImgQueIdx);

                entity.ToTable("tbl_colorImage_Vision_Api_Que");

                entity.HasIndex(e => e.Itemid);

                entity.Property(e => e.ImgQueIdx).HasColumnName("imgQueIdx");

                entity.Property(e => e.Basicimagename)
                    .IsRequired()
                    .HasColumnName("basicimagename")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Findate)
                    .HasColumnName("findate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Readdate)
                    .HasColumnName("readdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Resultcd)
                    .HasColumnName("resultcd")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblColorImageVisionApiResult>(entity =>
            {
                entity.HasKey(e => new { e.ImgQueIdx, e.ColorRank });

                entity.ToTable("tbl_colorImage_Vision_Api_Result");

                entity.Property(e => e.ImgQueIdx).HasColumnName("imgQueIdx");

                entity.Property(e => e.Basicimagename)
                    .IsRequired()
                    .HasColumnName("basicimagename")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblColorImageVisionApiResultRow>(entity =>
            {
                entity.HasKey(e => new { e.ImgQueIdx, e.Rowidx });

                entity.ToTable("tbl_colorImage_Vision_Api_Result_ROW");

                entity.Property(e => e.ImgQueIdx).HasColumnName("imgQueIdx");

                entity.Property(e => e.Basicimagename)
                    .IsRequired()
                    .HasColumnName("basicimagename")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ColorRgb)
                    .IsRequired()
                    .HasColumnName("colorRGB")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");
            });

            modelBuilder.Entity<TblColorImageVisionApiTopColor>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Basicimagename });

                entity.ToTable("tbl_colorImage_Vision_Api_TopColor");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Basicimagename)
                    .HasColumnName("basicimagename")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LastImgQueIdx).HasColumnName("lastImgQueIdx");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblCoupangBranddeliveryMapping>(entity =>
            {
                entity.HasKey(e => e.Makerid)
                    .HasName("PK_tbl_coupang_brandmapping");

                entity.ToTable("tbl_coupang_branddelivery_mapping");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressType)
                    .HasColumnName("addressType")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyContactNumber)
                    .HasColumnName("companyContactNumber")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("countryCode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryCode)
                    .HasColumnName("deliveryCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Global)
                    .HasColumnName("global")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Jeju)
                    .HasColumnName("jeju")
                    .HasColumnType("money");

                entity.Property(e => e.NotJeju).HasColumnType("money");

                entity.Property(e => e.OutboundShippingPlaceCode)
                    .HasColumnName("outboundShippingPlaceCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber2)
                    .HasColumnName("phoneNumber2")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReturnAddress)
                    .HasColumnName("returnAddress")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnAddressDetail)
                    .HasColumnName("returnAddressDetail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnZipCode)
                    .HasColumnName("returnZipCode")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPlaceName)
                    .HasColumnName("shippingPlaceName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .IsRequired()
                    .HasColumnName("vendorId")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCoupangCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_coupang_cate_mapping");

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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Teninfodiv)
                    .HasColumnName("teninfodiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCoupangCategory>(entity =>
            {
                entity.HasKey(e => e.CateKey);

                entity.ToTable("tbl_coupang_category");

                entity.Property(e => e.CateKey).ValueGeneratedNever();

                entity.Property(e => e.Depth1Name)
                    .HasColumnName("depth1Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Name)
                    .HasColumnName("depth2Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Name)
                    .HasColumnName("depth3Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth4Name)
                    .HasColumnName("depth4Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth5Name)
                    .HasColumnName("depth5Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth6Name)
                    .HasColumnName("depth6Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsAllowSingleItem)
                    .HasColumnName("isAllowSingleItem")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCoupangCouponCateDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_coupang_CouponCate_detail");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Cdl)
                    .IsRequired()
                    .HasColumnName("cdl")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cdm)
                    .IsRequired()
                    .HasColumnName("cdm")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Midx).HasColumnName("midx");
            });

            modelBuilder.Entity<TblCoupangCouponItemDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_coupang_CouponItem_detail");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ItemType)
                    .HasColumnName("itemType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Midx).HasColumnName("midx");
            });

            modelBuilder.Entity<TblCoupangCouponMaster>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_coupang_CouponCate_master");

                entity.ToTable("tbl_coupang_Coupon_master");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CouponId)
                    .HasColumnName("couponId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CouponName)
                    .IsRequired()
                    .HasColumnName("couponName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CouponType)
                    .IsRequired()
                    .HasColumnName("couponType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxDiscountPrice).HasColumnName("maxDiscountPrice");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestedId)
                    .HasColumnName("requestedId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCoupangDeliveryLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_coupang_delivery_LOG");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.FailCnt).HasColumnName("failCnt");

                entity.Property(e => e.LastErrMsg)
                    .HasColumnName("lastErrMsg")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResultCode)
                    .HasColumnName("resultCode")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCoupangInfoCodeMap>(entity =>
            {
                entity.HasKey(e => new { e.NoticeCategoryName, e.MallinfoDiv, e.NoticeCategoryDetailName })
                    .HasName("PK_tbl_OutMall_infoCodeMap");

                entity.ToTable("tbl_coupang_infoCodeMap");

                entity.Property(e => e.NoticeCategoryName)
                    .HasColumnName("noticeCategoryName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MallinfoDiv)
                    .HasColumnName("mallinfoDiv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoticeCategoryDetailName)
                    .HasColumnName("noticeCategoryDetailName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCd)
                    .IsRequired()
                    .HasColumnName("infoCd")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCdAdd)
                    .HasColumnName("infoCdAdd")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCoupangRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_Coupang_regItem");

                entity.ToTable("tbl_coupang_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoupangGoodNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoupangLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.CoupangPrice).HasColumnType("money");

                entity.Property(e => e.CoupangRegdate).HasColumnType("datetime");

                entity.Property(e => e.CoupangSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

                entity.Property(e => e.FirstVendorItemId)
                    .HasColumnName("firstVendorItemId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

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

                entity.Property(e => e.ProductId)
                    .HasColumnName("productId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

            modelBuilder.Entity<TblCoupangRegedoption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption });

                entity.ToTable("tbl_coupang_regedoption");

                entity.HasIndex(e => e.VendorItemId);

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

                entity.Property(e => e.OutmallOptName)
                    .HasColumnName("outmallOptName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OutmallSellyn)
                    .IsRequired()
                    .HasColumnName("outmallSellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Outmalllimitno).HasColumnName("outmalllimitno");

                entity.Property(e => e.Outmalllimityn)
                    .IsRequired()
                    .HasColumnName("outmalllimityn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SellerProductItemId)
                    .IsRequired()
                    .HasColumnName("sellerProductItemId")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VendorItemId)
                    .IsRequired()
                    .HasColumnName("vendorItemId")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCpApilog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_CP_APILog");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Certkey)
                    .HasColumnName("certkey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Cpid)
                    .HasColumnName("cpid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Gubun)
                    .HasColumnName("gubun")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Xmldata)
                    .HasColumnName("xmldata")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblCpInfocdCheck>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_CP_infocd_check");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ChkDiv)
                    .IsRequired()
                    .HasColumnName("chkDiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCd)
                    .IsRequired()
                    .HasColumnName("infoCd")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InfoDiv)
                    .IsRequired()
                    .HasColumnName("infoDiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCpManager>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_CP_manager");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Certkey)
                    .IsRequired()
                    .HasColumnName("certkey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Cpid)
                    .IsRequired()
                    .HasColumnName("cpid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEbayCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.SdcategoryCode, e.CateCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_ebay_cate_mapping");

                entity.Property(e => e.SdcategoryCode)
                    .HasColumnName("SDCategoryCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CateCode)
                    .HasColumnName("cateCode")
                    .HasMaxLength(50)
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

                entity.Property(e => e.Gubun)
                    .HasColumnName("gubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEbayEsmCategory>(entity =>
            {
                entity.HasKey(e => e.SdcategoryCode);

                entity.ToTable("tbl_ebay_esmCategory");

                entity.Property(e => e.SdcategoryCode)
                    .HasColumnName("SDCategoryCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Lv)
                    .IsRequired()
                    .HasColumnName("LV")
                    .HasMaxLength(10);

                entity.Property(e => e.ParentSdcategoryCode)
                    .IsRequired()
                    .HasColumnName("parentSDCategoryCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SdcategoryName)
                    .IsRequired()
                    .HasColumnName("SDCategoryName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SdcategoryName2)
                    .IsRequired()
                    .HasColumnName("SDCategoryName2")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEzwelCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_ezwel_cate_mapping");

                entity.Property(e => e.DepthCode).HasColumnName("depthCode");

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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEzwelNewcateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_ezwel_Newcate_mapping");

                entity.Property(e => e.DepthCode).HasColumnName("depthCode");

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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEzwelRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_ezwel_regItem");

                entity.ToTable("tbl_ezwel_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EzwelGoodNo)
                    .HasColumnName("ezwelGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EzwelLastUpdate)
                    .HasColumnName("ezwelLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EzwelPrice)
                    .HasColumnName("ezwelPrice")
                    .HasColumnType("money");

                entity.Property(e => e.EzwelRegdate)
                    .HasColumnName("ezwelRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EzwelSellYn)
                    .IsRequired()
                    .HasColumnName("ezwelSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.EzwelStatCd).HasColumnName("ezwelStatCd");

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

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

            modelBuilder.Entity<TblForeignMallRegedoption>(entity =>
            {
                entity.HasKey(e => new { e.Mallid, e.Itemid, e.Itemoption })
                    .HasName("PK_tbl_foreignMall_regoption");

                entity.ToTable("tbl_foreignMall_regedoption");

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
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Outmalllimitno).HasColumnName("outmalllimitno");

                entity.Property(e => e.Outmalllimityn)
                    .IsRequired()
                    .HasColumnName("outmalllimityn")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGmarket1010RegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_gmarket1010_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

                entity.Property(e => e.G9goodNo)
                    .HasColumnName("G9GoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GmarketGoodNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GmarketLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.GmarketPrice).HasColumnType("money");

                entity.Property(e => e.GmarketRegdate).HasColumnType("datetime");

                entity.Property(e => e.GmarketSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

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

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

            modelBuilder.Entity<TblGmarketAddressBook>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_gmarket_AddressBook");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.AddressName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Reqaddress)
                    .IsRequired()
                    .HasColumnName("reqaddress")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Reqzipaddr)
                    .IsRequired()
                    .HasColumnName("reqzipaddr")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Reqzipcode)
                    .IsRequired()
                    .HasColumnName("reqzipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGmarketBrandMapping>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_gmarket_brand_mapping");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGmarketCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_gmarket_cate_mapping");

                entity.Property(e => e.DepthCode).HasColumnName("depthCode");

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

                entity.Property(e => e.Depth4Code)
                    .HasColumnName("depth4Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGmarketRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_gmarket_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apiaddgosi)
                    .HasColumnName("APIaddgosi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Apiadditem)
                    .HasColumnName("APIadditem")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Apiaddopt)
                    .HasColumnName("APIaddopt")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

                entity.Property(e => e.G9goodNo)
                    .HasColumnName("G9GoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GmarketFirstPrice).HasColumnType("money");

                entity.Property(e => e.GmarketGoodNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GmarketLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.GmarketPrice).HasColumnType("money");

                entity.Property(e => e.GmarketRegdate).HasColumnType("datetime");

                entity.Property(e => e.GmarketSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

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

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

            modelBuilder.Entity<TblGsshopAddoptionRegitem>(entity =>
            {
                entity.HasKey(e => e.Midx);

                entity.ToTable("tbl_gsshopAddoption_regitem");

                entity.Property(e => e.Midx)
                    .HasColumnName("midx")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt).HasColumnName("accFailCNT");

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
                    .HasColumnName("GSShopSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

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

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

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

            modelBuilder.Entity<TblGsshopBrandDeliveryMapping>(entity =>
            {
                entity.HasKey(e => e.Makerid);

                entity.ToTable("tbl_gsshop_brandDelivery_mapping");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

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
                    .IsUnicode(false);

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
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
                    .IsUnicode(false);

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("tenCateSmall")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Isvat)
                    .IsRequired()
                    .HasColumnName("isvat")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Safecode)
                    .IsRequired()
                    .HasColumnName("safecode")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHalfclubCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_halfclub_cate_mapping");

                entity.Property(e => e.DepthCode)
                    .HasColumnName("depthCode")
                    .HasMaxLength(10)
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

                entity.Property(e => e.BrandCode)
                    .IsRequired()
                    .HasColumnName("brandCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHalfclubRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_Halfclub_regItem");

                entity.ToTable("tbl_halfclub_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

                entity.Property(e => e.HalfclubGoodNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HalfclubLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.HalfclubPrice).HasColumnType("money");

                entity.Property(e => e.HalfclubRegdate).HasColumnType("datetime");

                entity.Property(e => e.HalfclubSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

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

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

            modelBuilder.Entity<TblHmallCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_hmall_cate_mapping");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(20)
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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.Teninfodiv)
                    .HasColumnName("teninfodiv")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHmallCategory>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_hmall_category");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CateKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoreMngYn)
                    .HasColumnName("coreMngYn")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Depth1Name)
                    .HasColumnName("depth1Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Name)
                    .HasColumnName("depth2Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Name)
                    .HasColumnName("depth3Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth4Name)
                    .HasColumnName("depth4Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth5Name)
                    .HasColumnName("depth5Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth6Name)
                    .HasColumnName("depth6Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InfNotfBsicCd)
                    .HasColumnName("infNotfBsicCd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItstDlbrYn)
                    .HasColumnName("itstDlbrYn")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.QaTrgtYn)
                    .HasColumnName("qaTrgtYn")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SafeCertTrgtYn)
                    .HasColumnName("safeCertTrgtYn")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SafeCertTypeGbcd)
                    .HasColumnName("safeCertTypeGbcd")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHmallInfoCodeMap>(entity =>
            {
                entity.HasKey(e => new { e.MallinfoDiv, e.ItstTitl })
                    .HasName("PK_tbl_hmall_InfoCodeMap_1");

                entity.ToTable("tbl_hmall_InfoCodeMap");

                entity.Property(e => e.MallinfoDiv)
                    .HasColumnName("mallinfoDiv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItstTitl)
                    .HasColumnName("itstTitl")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCd)
                    .IsRequired()
                    .HasColumnName("infoCd")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCdAdd)
                    .HasColumnName("infoCdAdd")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItstCd)
                    .IsRequired()
                    .HasColumnName("itstCd")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrdg).HasColumnName("sortOrdg");
            });

            modelBuilder.Entity<TblHmallProductReq>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_hmall_ProductReq");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.BlcwdIdxYn)
                    .HasColumnName("blcwdIdxYn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Catekey)
                    .HasColumnName("catekey")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InfNotfBsicCd)
                    .HasColumnName("infNotfBsicCd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InfNotfBsicTitl)
                    .HasColumnName("infNotfBsicTitl")
                    .HasMaxLength(100);

                entity.Property(e => e.ItstCd)
                    .HasColumnName("itstCd")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItstTitl)
                    .HasColumnName("itstTitl")
                    .HasMaxLength(100);

                entity.Property(e => e.MinInsrByteLen)
                    .HasColumnName("minInsrByteLen")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrdg)
                    .HasColumnName("sortOrdg")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHmallRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_hmall_regItem");

                entity.ToTable("tbl_hmall_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApiaddImg)
                    .HasColumnName("APIaddImg")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ApiconfirmImg)
                    .HasColumnName("APIconfirmImg")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

                entity.Property(e => e.HmallGoodNo)
                    .HasColumnName("hmallGoodNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HmallGoodNo2)
                    .HasColumnName("hmallGoodNo2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HmallLastUpdate)
                    .HasColumnName("hmallLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HmallPrice)
                    .HasColumnName("hmallPrice")
                    .HasColumnType("money");

                entity.Property(e => e.HmallRegdate)
                    .HasColumnName("hmallRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HmallSellYn)
                    .IsRequired()
                    .HasColumnName("hmallSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.HmallStatCd).HasColumnName("hmallStatCd");

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

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

                entity.Property(e => e.SetMargin).HasColumnName("setMargin");
            });

            modelBuilder.Entity<TblHmallRegedOption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.OutmallOptCode });

                entity.ToTable("tbl_hmall_regedOption");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.OutmallOptCode)
                    .HasColumnName("outmallOptCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutmallOptName)
                    .IsRequired()
                    .HasColumnName("outmallOptName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OutmallSellyn)
                    .IsRequired()
                    .HasColumnName("outmallSellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Outmalllimitno).HasColumnName("outmalllimitno");
            });

            modelBuilder.Entity<TblHmallSepcialCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.TenCateLarge, e.TenCateMid });

                entity.ToTable("tbl_hmall_sepcial_cate_mapping");

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("tenCateLarge")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("tenCateMid")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SectId1).HasColumnName("sectId1");

                entity.Property(e => e.SectId2).HasColumnName("sectId2");
            });

            modelBuilder.Entity<TblHmallSpecialCategory>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_hmall_special_category");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Depth1Name)
                    .IsRequired()
                    .HasColumnName("depth1Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Name)
                    .IsRequired()
                    .HasColumnName("depth2Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SectId1).HasColumnName("sectId1");

                entity.Property(e => e.SectId2).HasColumnName("sectId2");
            });

            modelBuilder.Entity<TblHomeplusBrandCategoryMapping>(entity =>
            {
                entity.HasKey(e => new { e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_homeplus_brandCategory_mapping");

                entity.Property(e => e.DepthCode)
                    .HasColumnName("depthCode")
                    .HasMaxLength(20)
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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHomeplusBrandcategory>(entity =>
            {
                entity.HasKey(e => e.DepthCode);

                entity.ToTable("tbl_homeplus_brandcategory");

                entity.Property(e => e.DepthCode)
                    .HasColumnName("depthCode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Depth2Nm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Nm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth4Nm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth5Nm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth6Nm)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHomeplusCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_homeplus_cate_mapping");

                entity.Property(e => e.DepthCode).HasColumnName("depthCode");

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

                entity.Property(e => e.Infodiv)
                    .HasColumnName("infodiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHomeplusDispcategory>(entity =>
            {
                entity.HasKey(e => e.DepthCode)
                    .HasName("PK_tbl_homeplus_dispCategory");

                entity.ToTable("tbl_homeplus_dispcategory");

                entity.Property(e => e.DepthCode)
                    .HasColumnName("depthCode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Depth2Nm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Nm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth4Nm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth5Nm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth6Nm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHomeplusPrdDivMapping>(entity =>
            {
                entity.HasKey(e => new { e.HDivision, e.HGroup, e.HDept, e.HClass, e.HSubclass, e.HCategoryId, e.TenCateLarge, e.TenCateMid, e.TenCateSmall })
                    .HasName("PK_tbl_homeplus_prdDiv_mapping_1");

                entity.ToTable("tbl_homeplus_prdDiv_mapping");

                entity.Property(e => e.HDivision)
                    .HasColumnName("hDIVISION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HGroup)
                    .HasColumnName("hGROUP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HDept)
                    .HasColumnName("hDEPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HClass)
                    .HasColumnName("hCLASS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HSubclass)
                    .HasColumnName("hSUBCLASS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HCategoryId)
                    .HasColumnName("hCATEGORY_ID")
                    .HasMaxLength(50)
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

                entity.Property(e => e.Infodiv)
                    .HasColumnName("infodiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHomeplusRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_homeplus_regItem");

                entity.ToTable("tbl_homeplus_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HomeplusGoodNo)
                    .HasColumnName("homeplusGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HomeplusLastUpdate)
                    .HasColumnName("homeplusLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HomeplusPrice)
                    .HasColumnName("homeplusPrice")
                    .HasColumnType("money");

                entity.Property(e => e.HomeplusRegdate)
                    .HasColumnName("homeplusRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HomeplusSellYn)
                    .IsRequired()
                    .HasColumnName("homeplusSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.HomeplusStatCd).HasColumnName("homeplusStatCd");

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
            });

            modelBuilder.Entity<TblJaehumallHopeSell>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_jaehumall_hopeSell");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.AdminRegdate)
                    .HasColumnName("adminRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AdminText)
                    .HasColumnName("adminText")
                    .HasColumnType("text");

                entity.Property(e => e.Currstat).HasColumnName("currstat");

                entity.Property(e => e.Hoperegdate)
                    .HasColumnName("hoperegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hopesellstat)
                    .IsRequired()
                    .HasColumnName("hopesellstat")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsComplete)
                    .IsRequired()
                    .HasColumnName("isComplete")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mallgubun)
                    .IsRequired()
                    .HasColumnName("mallgubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Whyhope)
                    .IsRequired()
                    .HasColumnName("whyhope")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblJaehumallHopeSellLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_jaehumall_hopeSell_Log");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.HopeStr)
                    .HasColumnName("hopeStr")
                    .HasColumnType("text");

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mallgubun)
                    .IsRequired()
                    .HasColumnName("mallgubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UseYn)
                    .IsRequired()
                    .HasColumnName("useYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblKakaoGiftCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_kakaoGift_cate_mapping");

                entity.Property(e => e.DepthCode)
                    .HasColumnName("depthCode")
                    .HasMaxLength(8)
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

                entity.Property(e => e.BrandCode).HasColumnName("brandCode");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NeedInfoDiv).HasColumnName("needInfoDiv");
            });

            modelBuilder.Entity<TblKakaoGiftCategory>(entity =>
            {
                entity.HasKey(e => e.DepthCode);

                entity.ToTable("tbl_kakaoGift_category");

                entity.Property(e => e.DepthCode)
                    .HasColumnName("depthCode")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandCode).HasColumnName("brandCode");

                entity.Property(e => e.Depth1Nm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Nm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Nm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth4Nm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NeedInfoDiv).HasColumnName("needInfoDiv");
            });

            modelBuilder.Entity<TblKakaoGiftRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_kakaoGift_regItem");

                entity.ToTable("tbl_kakaoGift_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AddDlvPrice)
                    .HasColumnName("addDlvPrice")
                    .HasColumnType("money");

                entity.Property(e => e.AddKakaoPrice)
                    .HasColumnName("addKakaoPrice")
                    .HasColumnType("money");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

                entity.Property(e => e.KakaoGiftGoodNo)
                    .HasColumnName("kakaoGiftGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KakaoGiftGoodNo2)
                    .HasColumnName("kakaoGiftGoodNo2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KakaoGiftLastUpdate)
                    .HasColumnName("kakaoGiftLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.KakaoGiftPrice)
                    .HasColumnName("kakaoGiftPrice")
                    .HasColumnType("money");

                entity.Property(e => e.KakaoGiftRegdate)
                    .HasColumnName("kakaoGiftRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.KakaoGiftSellYn)
                    .IsRequired()
                    .HasColumnName("kakaoGiftSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.KakaoGiftStatCd).HasColumnName("kakaoGiftStatCd");

                entity.Property(e => e.Kakaocategorycode)
                    .HasColumnName("kakaocategorycode")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Kakaoitemname)
                    .HasColumnName("kakaoitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kakaosaleprice)
                    .HasColumnName("kakaosaleprice")
                    .HasColumnType("money");

                entity.Property(e => e.Kakaostate)
                    .HasColumnName("kakaostate")
                    .HasMaxLength(1)
                    .IsUnicode(false);

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

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

                entity.Property(e => e.Updchkdata)
                    .HasColumnName("updchkdata")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblKakaogiftRegitemoption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Optioncode });

                entity.ToTable("Tbl_Kakaogift_regitemoption");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Optioncode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OptionName).HasMaxLength(100);

                entity.Property(e => e.OutmallCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutmallCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutmallOptionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SellYn)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SyncYn)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Typename)
                    .HasColumnName("typename")
                    .HasMaxLength(100);

                entity.Property(e => e.VisibleYn)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLfmallCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_lfmall_cate_mapping");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(20)
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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLfmallCategory>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_lfmall_category");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CateKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Depth1Name)
                    .HasColumnName("depth1Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Name)
                    .HasColumnName("depth2Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Name)
                    .HasColumnName("depth3Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth4Name)
                    .HasColumnName("depth4Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLfmallNotiMapping>(entity =>
            {
                entity.HasKey(e => new { e.Itemkindcode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_lfmall_noti_mapping");

                entity.Property(e => e.Itemkindcode)
                    .HasColumnName("itemkindcode")
                    .HasMaxLength(10)
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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nitypecd)
                    .IsRequired()
                    .HasColumnName("nitypecd")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLfmallNotilist>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_lfmall_notilist");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Categorykey).HasColumnName("categorykey");

                entity.Property(e => e.Itemkindcode)
                    .HasColumnName("itemkindcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Itemkindname)
                    .HasColumnName("itemkindname")
                    .HasMaxLength(100);

                entity.Property(e => e.Nitypecd)
                    .HasColumnName("nitypecd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nitypenm)
                    .HasColumnName("nitypenm")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblLfmallRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_lfmall_regItem");

                entity.ToTable("tbl_lfmall_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Catekey)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

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

                entity.Property(e => e.LfmallGoodNo)
                    .HasColumnName("lfmallGoodNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LfmallLastUpdate)
                    .HasColumnName("lfmallLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LfmallPrice)
                    .HasColumnName("lfmallPrice")
                    .HasColumnType("money");

                entity.Property(e => e.LfmallRegdate)
                    .HasColumnName("lfmallRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LfmallSellYn)
                    .IsRequired()
                    .HasColumnName("lfmallSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LfmallStatCd).HasColumnName("lfmallStatCd");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductGroupNoticeNo).HasColumnName("productGroupNoticeNo");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

                entity.Property(e => e.SellStartDate)
                    .HasColumnName("sellStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetMargin).HasColumnName("setMargin");
            });

            modelBuilder.Entity<TblLfmallRegedoption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption, e.OutmallOptName })
                    .HasName("PK_tbl_LFMall_regoption");

                entity.ToTable("tbl_lfmall_regedoption");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OutmallOptName)
                    .HasColumnName("outmallOptName")
                    .HasMaxLength(200)
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

                entity.Property(e => e.OutmallSellyn)
                    .IsRequired()
                    .HasColumnName("outmallSellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
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
                    .IsUnicode(false);

                entity.Property(e => e.OutmallsuppPrc)
                    .HasColumnName("outmallsuppPrc")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblLotteAddOptionRegItem>(entity =>
            {
                entity.HasKey(e => e.Midx)
                    .HasName("PK__tbl_lotteAddOption_regItem");

                entity.ToTable("tbl_lotteAddOption_regItem");

                entity.Property(e => e.Midx)
                    .HasColumnName("midx")
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

                entity.Property(e => e.LotteLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LottePrice).HasColumnType("money");

                entity.Property(e => e.LotteRegdate).HasColumnType("datetime");

                entity.Property(e => e.LotteSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LotteStatCd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('10')");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
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

                entity.Property(e => e.TnLastupdate)
                    .HasColumnName("tnLastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLtimallAddoptionRegitem>(entity =>
            {
                entity.HasKey(e => e.Midx);

                entity.ToTable("tbl_ltimallAddoption_regitem");

                entity.Property(e => e.Midx)
                    .HasColumnName("midx")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt).HasColumnName("accFailCnt");

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

                entity.Property(e => e.LtiMallRegdate).HasColumnType("datetime");

                entity.Property(e => e.LtiMallSellYn)
                    .HasColumnName("LTiMallSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LtiMallStatCd).HasColumnName("LTiMallStatCd");

                entity.Property(e => e.LtiMallTmpGoodNo)
                    .HasColumnName("LTiMallTmpGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMy11stCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_my11st_cate_mapping");

                entity.Property(e => e.CateKey).HasMaxLength(10);

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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMy11stCategory>(entity =>
            {
                entity.HasKey(e => e.CateKey);

                entity.ToTable("tbl_my11st_category");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Depth1Nm).HasMaxLength(255);

                entity.Property(e => e.Depth2Nm).HasMaxLength(255);

                entity.Property(e => e.Depth3Nm).HasMaxLength(255);
            });

            modelBuilder.Entity<TblMy11stOption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption })
                    .HasName("PK_tbl_item_my11st_option_1");

                entity.ToTable("tbl_my11st_option");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.OptionTypeName)
                    .IsRequired()
                    .HasColumnName("optionTypeName")
                    .HasMaxLength(32);

                entity.Property(e => e.Optionname)
                    .HasColumnName("optionname")
                    .HasMaxLength(96);
            });

            modelBuilder.Entity<TblMy11stRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_my11st_regItem");

                entity.ToTable("tbl_my11st_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchangeRate")
                    .HasColumnType("money");

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastOptConfirmdate)
                    .HasColumnName("lastOptConfirmdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Multiplerate).HasColumnName("multiplerate");

                entity.Property(e => e.My11stGoodNo)
                    .HasColumnName("my11stGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.My11stLastUpdate)
                    .HasColumnName("my11stLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.My11stPrice)
                    .HasColumnName("my11stPrice")
                    .HasColumnType("money");

                entity.Property(e => e.My11stRegdate)
                    .HasColumnName("my11stRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.My11stSellYn)
                    .IsRequired()
                    .HasColumnName("my11stSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.My11stStatCd).HasColumnName("my11stStatCd");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RegOrgprice)
                    .HasColumnName("regOrgprice")
                    .HasColumnType("money");

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

                entity.Property(e => e.TransItemname)
                    .IsRequired()
                    .HasColumnName("transItemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNvshopMapItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_nvshop_mapItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MatchNvMid)
                    .IsRequired()
                    .HasColumnName("matchNvMid")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Minprice)
                    .HasColumnName("minprice")
                    .HasColumnType("money");

                entity.Property(e => e.Nvitemid)
                    .IsRequired()
                    .HasColumnName("nvitemid")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Nvtensellcash)
                    .HasColumnName("nvtensellcash")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblNvstorefarmCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_nvstorefarm_cate_mapping");

                entity.Property(e => e.CateKey).HasMaxLength(10);

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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblNvstorefarmCategory>(entity =>
            {
                entity.HasKey(e => e.CateKey)
                    .HasName("PK_Sheet0$");

                entity.ToTable("tbl_nvstorefarm_category");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Depth1Nm).HasMaxLength(255);

                entity.Property(e => e.Depth2Nm).HasMaxLength(255);

                entity.Property(e => e.Depth3Nm).HasMaxLength(255);

                entity.Property(e => e.Depth4Nm).HasMaxLength(255);
            });

            modelBuilder.Entity<TblNvstorefarmImage>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Itemid, e.ImgType });

                entity.ToTable("tbl_nvstorefarm_Image");

                entity.HasIndex(e => e.Itemid)
                    .HasName("IX_tbl_nvstorefarm__itemid");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.ImgType)
                    .HasColumnName("imgType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StorefarmUrl)
                    .HasColumnName("storefarmURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TenUrl)
                    .HasColumnName("tenURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNvstorefarmRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_nvstorefarm_regItem");

                entity.ToTable("tbl_nvstorefarm_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApiaddImg)
                    .HasColumnName("APIaddImg")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

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

                entity.Property(e => e.NvstorefarmGoodNo)
                    .HasColumnName("nvstorefarmGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NvstorefarmLastUpdate)
                    .HasColumnName("nvstorefarmLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NvstorefarmPrice)
                    .HasColumnName("nvstorefarmPrice")
                    .HasColumnType("money");

                entity.Property(e => e.NvstorefarmRegdate)
                    .HasColumnName("nvstorefarmRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NvstorefarmSellYn)
                    .IsRequired()
                    .HasColumnName("nvstorefarmSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.NvstorefarmStatCd).HasColumnName("nvstorefarmStatCd");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

            modelBuilder.Entity<TblNvstorefarmUploadimage>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_nvstorefarm_uploadimage");

                entity.Property(e => e.Idx).HasColumnName("IDX");

                entity.Property(e => e.Gubun).HasColumnName("GUBUN");

                entity.Property(e => e.Imagename)
                    .HasColumnName("IMAGENAME")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");
            });

            modelBuilder.Entity<TblNvstorefarmclassImage>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Itemid, e.ImgType });

                entity.ToTable("tbl_nvstorefarmclass_Image");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.ImgType)
                    .HasColumnName("imgType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StorefarmUrl)
                    .HasColumnName("storefarmURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TenUrl)
                    .HasColumnName("tenURL")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNvstorefarmclassRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_nvstorefarmclass_regItem");

                entity.ToTable("tbl_nvstorefarmclass_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ApiaddImg)
                    .HasColumnName("APIaddImg")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

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

                entity.Property(e => e.NvClassGoodNo)
                    .HasColumnName("nvClassGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NvClassLastUpdate)
                    .HasColumnName("nvClassLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NvClassPrice)
                    .HasColumnName("nvClassPrice")
                    .HasColumnType("money");

                entity.Property(e => e.NvClassRegdate)
                    .HasColumnName("nvClassRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NvClassSellYn)
                    .IsRequired()
                    .HasColumnName("nvClassSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.NvClassStatCd).HasColumnName("nvClassStatCd");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

            modelBuilder.Entity<TblOutmallApiQue>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_outmall_API_Que");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ApiAction)
                    .IsRequired()
                    .HasColumnName("apiAction")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Findate)
                    .HasColumnName("findate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.LastErrMsg)
                    .HasColumnName("lastErrMsg")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastUserid)
                    .HasColumnName("lastUserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mallid)
                    .IsRequired()
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Readdate)
                    .HasColumnName("readdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResultCode)
                    .HasColumnName("resultCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutmallChangePoint>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tblOutmallChangePoint");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Changelogidx)
                    .HasColumnName("changelogidx")
                    .HasMaxLength(10);

                entity.Property(e => e.Gubun)
                    .HasColumnName("gubun")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(200);

                entity.Property(e => e.Processingdate)
                    .HasColumnName("processingdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Processingyn)
                    .HasColumnName("processingyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblOutmallConstExceptItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_outmall_const_Except_item");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblOutmallConstExceptItemCjmall>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_outmall_const_Except_item_cjmall");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblOutmallConstExceptItemCoupang>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK_tbl_outmall_const_Except_item_coupnag");

                entity.ToTable("tbl_outmall_const_Except_item_coupang");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblOutmallConstExceptItemGseshop>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_outmall_const_Except_item_gseshop");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblOutmallConstExceptItemLottecom>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_outmall_const_Except_item_lottecom");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblOutmallConstExceptItemSsg>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_outmall_const_Except_item_ssg");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblOutmallDiffOrder>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_outmall_diffOrder");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.DiffPrice)
                    .HasColumnName("diffPrice")
                    .HasColumnType("money");

                entity.Property(e => e.IsOk)
                    .HasColumnName("isOk")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Limitno).HasColumnName("limitno");

                entity.Property(e => e.Limitsold).HasColumnName("limitsold");

                entity.Property(e => e.Limityn)
                    .IsRequired()
                    .HasColumnName("limityn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Matchitemoption)
                    .HasColumnName("matchitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Optaddprice)
                    .HasColumnName("optaddprice")
                    .HasColumnType("money");

                entity.Property(e => e.Optlimitno).HasColumnName("optlimitno");

                entity.Property(e => e.Optlimitsold).HasColumnName("optlimitsold");

                entity.Property(e => e.Optlimityn)
                    .HasColumnName("optlimityn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Optsellyn)
                    .HasColumnName("optsellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutMallGoodsNo)
                    .HasColumnName("outMallGoodsNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Outmallsellprice)
                    .HasColumnName("outmallsellprice")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellsite)
                    .IsRequired()
                    .HasColumnName("sellsite")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasColumnName("sellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutmallEtcTextItem>(entity =>
            {
                entity.HasKey(e => new { e.Mallid, e.Itemid });

                entity.ToTable("tbl_Outmall_etcTextItem");

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");
            });

            modelBuilder.Entity<TblOutmallIni>(entity =>
            {
                entity.HasKey(e => new { e.Mallid, e.Inikey });

                entity.ToTable("tbl_outmall_ini");

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Inikey)
                    .HasColumnName("inikey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IniVal)
                    .IsRequired()
                    .HasColumnName("iniVal")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOutmallItemManager>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_outmall_items_manager");

                entity.ToTable("tbl_outmall_item_manager");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.LastUpDate)
                    .HasColumnName("lastUpDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MallId)
                    .IsRequired()
                    .HasColumnName("mallId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MallItemName)
                    .HasColumnName("mallItemName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("regDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOutmallKeywords>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_outmall_keywords");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mallid)
                    .IsRequired()
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOutmallLimtBrand>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Makerid })
                    .HasName("PK_tbl_outmall_limt_brand");

                entity.ToTable("tbl_Outmall_limt_brand");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblOutmallMarginCheck>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_outmall_margin_check");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Brand2MonthMargin).HasColumnName("brand2MonthMargin");

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money");

                entity.Property(e => e.BuycashCouponNotApplied)
                    .HasColumnName("buycashCouponNotApplied")
                    .HasColumnType("money");

                entity.Property(e => e.ChkDate)
                    .HasColumnName("chkDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Etc1)
                    .HasColumnName("etc1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Etc2)
                    .HasColumnName("etc2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsOk)
                    .HasColumnName("isOK")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Issailitem)
                    .HasColumnName("issailitem")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itemcost)
                    .HasColumnName("itemcost")
                    .HasColumnType("money");

                entity.Property(e => e.ItemcostCouponNotApplied)
                    .HasColumnName("itemcostCouponNotApplied")
                    .HasColumnType("money");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LogDiffbuycash)
                    .HasColumnName("logDiffbuycash")
                    .HasColumnType("money");

                entity.Property(e => e.Logbuycash)
                    .HasColumnName("logbuycash")
                    .HasColumnType("money");

                entity.Property(e => e.LogbuycashDate)
                    .HasColumnName("logbuycashDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Margin).HasColumnName("margin");

                entity.Property(e => e.MinusPrice)
                    .HasColumnName("minusPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Minusbuycash)
                    .HasColumnName("minusbuycash")
                    .HasColumnType("money");

                entity.Property(e => e.Mwdiv)
                    .HasColumnName("mwdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NowDiffCost)
                    .HasColumnName("nowDiffCost")
                    .HasColumnType("money");

                entity.Property(e => e.NowDiffbuycash)
                    .HasColumnName("nowDiffbuycash")
                    .HasColumnType("money");

                entity.Property(e => e.NowselladdoptCost)
                    .HasColumnName("nowselladdoptCost")
                    .HasColumnType("money");

                entity.Property(e => e.Nowselladdoptbuycash)
                    .HasColumnName("nowselladdoptbuycash")
                    .HasColumnType("money");

                entity.Property(e => e.Optaddbuyprice)
                    .HasColumnName("optaddbuyprice")
                    .HasColumnType("money");

                entity.Property(e => e.Optaddprice)
                    .HasColumnName("optaddprice")
                    .HasColumnType("money");

                entity.Property(e => e.OptaddpriceYn)
                    .HasColumnName("optaddpriceYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Orderserial)
                    .IsRequired()
                    .HasColumnName("orderserial")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sellsite)
                    .IsRequired()
                    .HasColumnName("sellsite")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutmallMustPriceItem>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_outmall_mustPriceItem");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdateUserId)
                    .HasColumnName("lastUpdateUserId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mallgubun)
                    .IsRequired()
                    .HasColumnName("mallgubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MustPrice)
                    .HasColumnName("mustPrice")
                    .HasColumnType("money");

                entity.Property(e => e.RegDate)
                    .HasColumnName("regDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegUserId)
                    .IsRequired()
                    .HasColumnName("regUserId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOutmallNewItemApiQue>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_outmall_newItem_API_Que");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ApiAction)
                    .IsRequired()
                    .HasColumnName("apiAction")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Findate)
                    .HasColumnName("findate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LastErrMsg)
                    .HasColumnName("lastErrMsg")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastUserid)
                    .HasColumnName("lastUserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mallid)
                    .IsRequired()
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Readdate)
                    .HasColumnName("readdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResultCode)
                    .HasColumnName("resultCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutmallNotKeywords>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_outmall_notKeywords");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasColumnType("text");

                entity.Property(e => e.Mallid)
                    .IsRequired()
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutmallOptionApiQue>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_outmall_Option_API_Que");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ApiAction)
                    .IsRequired()
                    .HasColumnName("apiAction")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Findate)
                    .HasColumnName("findate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastErrMsg)
                    .HasColumnName("lastErrMsg")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastUserid)
                    .HasColumnName("lastUserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mallid)
                    .IsRequired()
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Midx).HasColumnName("midx");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Readdate)
                    .HasColumnName("readdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResultCode)
                    .HasColumnName("resultCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOutmallOptionManager>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Mallid, e.Itemid, e.Itemoption });

                entity.ToTable("tbl_Outmall_option_Manager");

                entity.HasIndex(e => e.Itemid);

                entity.HasIndex(e => e.Itemoption);

                entity.HasIndex(e => e.Mallid);

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemnameChange)
                    .HasColumnName("itemnameChange")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MallGoodNo)
                    .HasColumnName("mallGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Newitemname)
                    .HasColumnName("newitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Optionname)
                    .IsRequired()
                    .HasColumnName("optionname")
                    .HasMaxLength(96)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOverseasSale>(entity =>
            {
                entity.HasKey(e => new { e.Sitename, e.SaleCode })
                    .HasName("PK__tbl_overseas_sale__05D8E0BE");

                entity.ToTable("tbl_overseas_sale");

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(32);

                entity.Property(e => e.SaleCode)
                    .HasColumnName("sale_code")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(50);

                entity.Property(e => e.Closedate)
                    .HasColumnName("closedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Opendate)
                    .HasColumnName("opendate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SaleEnddate)
                    .HasColumnName("sale_enddate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SaleGubun)
                    .IsRequired()
                    .HasColumnName("saleGubun")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SaleRate).HasColumnName("sale_rate");

                entity.Property(e => e.SaleStartdate)
                    .HasColumnName("sale_startdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SaleStatus).HasColumnName("sale_status");

                entity.Property(e => e.SaleUsing)
                    .IsRequired()
                    .HasColumnName("sale_using")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblOverseasSaleItem>(entity =>
            {
                entity.HasKey(e => e.SaleitemIdx);

                entity.ToTable("tbl_overseas_saleItem");

                entity.Property(e => e.SaleitemIdx).HasColumnName("saleitem_idx");

                entity.Property(e => e.Closedate)
                    .HasColumnName("closedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Limitno).HasColumnName("limitno");

                entity.Property(e => e.Opendate)
                    .HasColumnName("opendate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orglimityn)
                    .IsRequired()
                    .HasColumnName("orglimityn")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Orgsailprice)
                    .HasColumnName("orgsailprice")
                    .HasColumnType("money");

                entity.Property(e => e.Orgsailsuplycash)
                    .HasColumnName("orgsailsuplycash")
                    .HasColumnType("money");

                entity.Property(e => e.Orgsailyn)
                    .HasColumnName("orgsailyn")
                    .HasMaxLength(1);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SaleCode).HasColumnName("sale_code");

                entity.Property(e => e.SaleItemStatus).HasColumnName("saleItem_status");

                entity.Property(e => e.Saleprice)
                    .HasColumnName("saleprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Salesupplycash)
                    .HasColumnName("salesupplycash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblSabangnetRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_sabangnet_regItem");

                entity.ToTable("tbl_sabangnet_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Apiaddgosi)
                    .HasColumnName("APIaddgosi")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Apiadditem)
                    .HasColumnName("APIadditem")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Apiaddopt)
                    .HasColumnName("APIaddopt")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

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

                entity.Property(e => e.OnSaleRegdate).HasColumnType("datetime");

                entity.Property(e => e.OptAddPrcCnt)
                    .HasColumnName("optAddPrcCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OptAddPrcRegType)
                    .HasColumnName("optAddPrcRegType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

                entity.Property(e => e.SabangnetGoodNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SabangnetLastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SabangnetPrice).HasColumnType("money");

                entity.Property(e => e.SabangnetRegdate).HasColumnType("datetime");

                entity.Property(e => e.SabangnetSellYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblShopifyCateMapping>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tbl_shopify_cate_mapping_pk")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_shopify_cate_mapping");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.ShopifyCollectionId).HasColumnName("shopify_collection_id");

                entity.Property(e => e.TenCateLarge)
                    .HasColumnName("ten_cate_large")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateMid)
                    .HasColumnName("ten_cate_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TenCateSmall)
                    .HasColumnName("ten_cate_small")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShopifyCollections>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tbl_shopify_collections_pk")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_shopify_collections");

                entity.HasIndex(e => e.Title)
                    .HasName("tbl_shopify_collections_title_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Collectionid)
                    .HasColumnName("collectionid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Collectiontype).HasColumnName("collectiontype");

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishedAt)
                    .HasColumnName("published_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Var1)
                    .HasColumnName("var1")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShopifyRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_shopify_regItem");

                entity.HasIndex(e => e.ShopifyGoodNo);

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchangeRate")
                    .HasColumnType("money");

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Multiplerate).HasColumnName("multiplerate");

                entity.Property(e => e.ProductType)
                    .HasColumnName("product_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RegOrgprice)
                    .HasColumnName("regOrgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regitemname)
                    .HasColumnName("regitemname")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShopifyGoodNo)
                    .HasColumnName("shopifyGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShopifyLastUpdate)
                    .HasColumnName("shopifyLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShopifyPrice)
                    .HasColumnName("shopifyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ShopifyRegdate)
                    .HasColumnName("shopifyRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShopifySellYn)
                    .IsRequired()
                    .HasColumnName("shopifySellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ShopifyStatCd).HasColumnName("shopifyStatCd");

                entity.Property(e => e.Shopifyhandle)
                    .HasColumnName("shopifyhandle")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSsgCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.StdCtgDclsCd, e.DepthCode, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_ssg_cate_mapping");

                entity.Property(e => e.StdCtgDclsCd)
                    .HasColumnName("stdCtgDClsCd")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DepthCode)
                    .HasColumnName("depthCode")
                    .HasMaxLength(16)
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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SiteNo)
                    .HasColumnName("siteNo")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSsgCategory>(entity =>
            {
                entity.HasKey(e => new { e.StdCtgDclsCd, e.DepthCode });

                entity.ToTable("tbl_ssg_category");

                entity.HasIndex(e => e.DispCtgClsCd);

                entity.Property(e => e.StdCtgDclsCd)
                    .HasColumnName("stdCtgDClsCd")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DepthCode)
                    .HasColumnName("depthCode")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgClsCd)
                    .IsRequired()
                    .HasColumnName("dispCtgClsCd")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgClsNm)
                    .IsRequired()
                    .HasColumnName("dispCtgClsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgDclsId)
                    .IsRequired()
                    .HasColumnName("dispCtgDclsId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgDclsNm)
                    .IsRequired()
                    .HasColumnName("dispCtgDclsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgLclsId)
                    .IsRequired()
                    .HasColumnName("dispCtgLclsId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgLclsNm)
                    .IsRequired()
                    .HasColumnName("dispCtgLclsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgMclsId)
                    .IsRequired()
                    .HasColumnName("dispCtgMclsId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgMclsNm)
                    .IsRequired()
                    .HasColumnName("dispCtgMclsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgSclsId)
                    .IsRequired()
                    .HasColumnName("dispCtgSclsId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgSclsNm)
                    .IsRequired()
                    .HasColumnName("dispCtgSclsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgSdclsId)
                    .IsRequired()
                    .HasColumnName("dispCtgSdclsId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DispCtgSdclsNm)
                    .IsRequired()
                    .HasColumnName("dispCtgSdclsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DispctgLvl).HasColumnName("dispctgLvl");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.SiteNo)
                    .IsRequired()
                    .HasColumnName("siteNo")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSsgDispCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.DispCtgId, e.TenCateLarge, e.TenCateMid, e.TenCateSmall, e.SiteNo });

                entity.ToTable("tbl_ssg_DispCate_mapping");

                entity.Property(e => e.DispCtgId)
                    .HasColumnName("dispCtgId")
                    .HasMaxLength(16)
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

                entity.Property(e => e.SiteNo)
                    .HasColumnName("siteNo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSsgMarginCateDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_ssg_marginCate_detail");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Cdl)
                    .IsRequired()
                    .HasColumnName("cdl")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Cdm)
                    .HasColumnName("cdm")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Midx).HasColumnName("midx");
            });

            modelBuilder.Entity<TblSsgMarginCateMaster>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_ssg_cateMargin_master");

                entity.ToTable("tbl_ssg_marginCate_master");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Margin).HasColumnName("margin");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSsgMarginItemDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_ssg_marginItem_detail");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Midx).HasColumnName("midx");
            });

            modelBuilder.Entity<TblSsgMarginItemMaster>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_ssg_marginItem_master");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Margin).HasColumnName("margin");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSsgMmgCategory>(entity =>
            {
                entity.HasKey(e => e.StdCtgDclsId);

                entity.ToTable("tbl_ssg_mmg_category");

                entity.Property(e => e.StdCtgDclsId)
                    .HasColumnName("stdCtgDclsId")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BuyFrmCd)
                    .IsRequired()
                    .HasColumnName("buyFrmCd")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChldCertTgtYn)
                    .IsRequired()
                    .HasColumnName("chldCertTgtYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ElecCertTgtYn)
                    .IsRequired()
                    .HasColumnName("elecCertTgtYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HarmCertTgtYn)
                    .IsRequired()
                    .HasColumnName("harmCertTgtYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMngPropClsId)
                    .IsRequired()
                    .HasColumnName("itemMngPropClsId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMngPropClsNm)
                    .IsRequired()
                    .HasColumnName("itemMngPropClsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SafeCertTgtYn)
                    .IsRequired()
                    .HasColumnName("safeCertTgtYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNm)
                    .IsRequired()
                    .HasColumnName("siteNm")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo)
                    .IsRequired()
                    .HasColumnName("siteNo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.StdCtgDclsNm)
                    .IsRequired()
                    .HasColumnName("stdCtgDclsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StdCtgGrpCd)
                    .IsRequired()
                    .HasColumnName("stdCtgGrpCd")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StdCtgGrpNm)
                    .IsRequired()
                    .HasColumnName("stdCtgGrpNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StdCtgLclsId)
                    .IsRequired()
                    .HasColumnName("stdCtgLclsId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.StdCtgLclsNm)
                    .IsRequired()
                    .HasColumnName("stdCtgLclsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StdCtgMclsId)
                    .IsRequired()
                    .HasColumnName("stdCtgMclsId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.StdCtgMclsNm)
                    .IsRequired()
                    .HasColumnName("stdCtgMclsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StdCtgSclsId)
                    .IsRequired()
                    .HasColumnName("stdCtgSclsId")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.StdCtgSclsNm)
                    .IsRequired()
                    .HasColumnName("stdCtgSclsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TxnPermitDivCd)
                    .IsRequired()
                    .HasColumnName("txnPermitDivCd")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TxnPermitDivNm)
                    .IsRequired()
                    .HasColumnName("txnPermitDivNm")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSsgRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_ssg_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

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

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

                entity.Property(e => e.SetMargin).HasColumnName("setMargin");

                entity.Property(e => e.SsgFirstPrice)
                    .HasColumnName("ssgFirstPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SsgGoodNo)
                    .HasColumnName("ssgGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SsgLastUpdate)
                    .HasColumnName("ssgLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SsgPrice)
                    .HasColumnName("ssgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SsgRegdate)
                    .HasColumnName("ssgRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SsgSellYn)
                    .IsRequired()
                    .HasColumnName("ssgSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SsgStatCd).HasColumnName("ssgStatCd");
            });

            modelBuilder.Entity<TblSyrupCouponLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_syrup_couponLog");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Couponidx).HasColumnName("couponidx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTargetMallNotInItemid>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Mallgubun })
                    .HasName("PK__tbl_targetMall_n__72E607DB");

                entity.ToTable("tbl_targetMall_not_in_itemid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bigo)
                    .HasColumnName("bigo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblTargetMallNotInMakerid>(entity =>
            {
                entity.HasKey(e => new { e.Makerid, e.Mallgubun })
                    .HasName("PK_tbl_tbl_targetMall_not_in_makerid");

                entity.ToTable("tbl_targetMall_not_in_makerid");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWemakeCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_wemake_cate_mapping");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(20)
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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblWemakeCategory>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_wemake_category");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CateKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Depth1Name)
                    .HasColumnName("depth1Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Name)
                    .HasColumnName("depth2Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Name)
                    .HasColumnName("depth3Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth4Name)
                    .HasColumnName("depth4Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SafeCertTrgtYn)
                    .HasColumnName("safeCertTrgtYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWemakeCategory2>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_wemake_category2");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CateKey)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Depth1Name)
                    .HasColumnName("depth1Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Name)
                    .HasColumnName("depth2Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Name)
                    .HasColumnName("depth3Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Depth4Name)
                    .HasColumnName("depth4Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SafeCertTrgtYn)
                    .HasColumnName("safeCertTrgtYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWemakeDealItem>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_wemake_dealItem");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdateUserId)
                    .HasColumnName("lastUpdateUserId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LimitCount).HasColumnName("limitCount");

                entity.Property(e => e.NewItemName)
                    .IsRequired()
                    .HasColumnName("newItemName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnName("regDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegUserId)
                    .IsRequired()
                    .HasColumnName("regUserId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblWemakeDealOption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption });

                entity.ToTable("tbl_wemake_dealOption");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblWemakeInfoCodeMap>(entity =>
            {
                entity.HasKey(e => new { e.GroupNoticeNo, e.NoticeNo })
                    .HasName("PK_tbl_wemake_InfoCodeMap_1");

                entity.ToTable("tbl_wemake_InfoCodeMap");

                entity.Property(e => e.GroupNoticeNo).HasColumnName("groupNoticeNo");

                entity.Property(e => e.NoticeNo).HasColumnName("noticeNo");

                entity.Property(e => e.DefaltValue)
                    .HasColumnName("defaltValue")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.GroupNoticeNoName)
                    .IsRequired()
                    .HasColumnName("groupNoticeNoName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NoticeName)
                    .IsRequired()
                    .HasColumnName("noticeName")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWemakeRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_wemake_regItem");

                entity.ToTable("tbl_wemake_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

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

                entity.Property(e => e.ProductGroupNoticeNo).HasColumnName("productGroupNoticeNo");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

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

                entity.Property(e => e.SellStartDate)
                    .HasColumnName("sellStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SetMargin).HasColumnName("setMargin");

                entity.Property(e => e.WemakeGoodNo)
                    .HasColumnName("wemakeGoodNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WemakeLastUpdate)
                    .HasColumnName("wemakeLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WemakePrice)
                    .HasColumnName("wemakePrice")
                    .HasColumnType("money");

                entity.Property(e => e.WemakeRegdate)
                    .HasColumnName("wemakeRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WemakeSellYn)
                    .IsRequired()
                    .HasColumnName("wemakeSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.WemakeStatCd).HasColumnName("wemakeStatCd");
            });

            modelBuilder.Entity<TblZilingoAttrMapping>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_zilingo_attr_mapping");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Attributes)
                    .IsRequired()
                    .HasColumnName("attributes")
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblZilingoCateMapping>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.TenCateLarge, e.TenCateMid, e.TenCateSmall });

                entity.ToTable("tbl_zilingo_cate_mapping");

                entity.Property(e => e.CateKey).HasMaxLength(10);

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

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblZilingoCategory>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_zilingo_category2");

                entity.ToTable("tbl_zilingo_category");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Depth1Name)
                    .IsRequired()
                    .HasColumnName("depth1Name")
                    .HasMaxLength(150);

                entity.Property(e => e.Depth2Code)
                    .IsRequired()
                    .HasColumnName("depth2Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Name)
                    .IsRequired()
                    .HasColumnName("depth2Name")
                    .HasMaxLength(150);

                entity.Property(e => e.Depth3Code)
                    .IsRequired()
                    .HasColumnName("depth3Code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Name)
                    .IsRequired()
                    .HasColumnName("depth3Name")
                    .HasMaxLength(150);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblZilingoRegItem>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_zilingo_regItem");

                entity.ToTable("tbl_zilingo_regItem");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccFailCnt)
                    .HasColumnName("accFailCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EditQuecnt).HasColumnName("editQuecnt");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchangeRate")
                    .HasColumnType("money");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LastErrStr)
                    .HasColumnName("lastErrStr")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastStatCheckDate)
                    .HasColumnName("lastStatCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Multiplerate).HasColumnName("multiplerate");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RctSellCnt).HasColumnName("rctSellCNT");

                entity.Property(e => e.RegImageName)
                    .HasColumnName("regImageName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RegOrgprice)
                    .HasColumnName("regOrgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Regitemname)
                    .HasColumnName("regitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reguserid)
                    .IsRequired()
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ZilingoGoodNo)
                    .HasColumnName("zilingoGoodNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZilingoLastUpdate)
                    .HasColumnName("zilingoLastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ZilingoPrice)
                    .HasColumnName("zilingoPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ZilingoRegdate)
                    .HasColumnName("zilingoRegdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ZilingoSellYn)
                    .IsRequired()
                    .HasColumnName("zilingoSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ZilingoStatCd).HasColumnName("zilingoStatCd");
            });

            modelBuilder.Entity<TblZilingoSubCategory>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_zilingo_subCategory");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Depth1Id)
                    .IsRequired()
                    .HasColumnName("depth1Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth1Name)
                    .IsRequired()
                    .HasColumnName("depth1Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Id)
                    .HasColumnName("depth2Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth2Name)
                    .HasColumnName("depth2Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Id)
                    .HasColumnName("depth3Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depth3Name)
                    .HasColumnName("depth3Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gubun)
                    .IsRequired()
                    .HasColumnName("gubun")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsMultiSelectable)
                    .HasColumnName("isMultiSelectable")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsOptional)
                    .HasColumnName("isOptional")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });
        }
    }
}
