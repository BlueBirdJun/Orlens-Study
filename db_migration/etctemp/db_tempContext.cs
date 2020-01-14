using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace db_migration.etctemp
{
    public partial class db_tempContext : DbContext
    {
        public db_tempContext()
        {
        }

        public db_tempContext(DbContextOptions<db_tempContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DboTempChild> DboTempChild { get; set; }
        public virtual DbSet<KakaoInvite> KakaoInvite { get; set; }
        public virtual DbSet<KakaoResult> KakaoResult { get; set; }
        public virtual DbSet<Tbl13th55075> Tbl13th55075 { get; set; }
        public virtual DbSet<Tbl14thAnniversaryOurstoryItem> Tbl14thAnniversaryOurstoryItem { get; set; }
        public virtual DbSet<Tbl3comdalcomCoupon2015> Tbl3comdalcomCoupon2015 { get; set; }
        public virtual DbSet<Tbl3comdalcomCoupon2015Log> Tbl3comdalcomCoupon2015Log { get; set; }
        public virtual DbSet<Tbl3comdalcomCoupon2015Megabox> Tbl3comdalcomCoupon2015Megabox { get; set; }
        public virtual DbSet<Tbl3comdalcomCoupon2015Yogiyo> Tbl3comdalcomCoupon2015Yogiyo { get; set; }
        public virtual DbSet<TblAdminshoppingbag> TblAdminshoppingbag { get; set; }
        public virtual DbSet<TblAgreeEmailTarget> TblAgreeEmailTarget { get; set; }
        public virtual DbSet<TblAppRealtimeSellItems> TblAppRealtimeSellItems { get; set; }
        public virtual DbSet<TblAppfirstOrderUser> TblAppfirstOrderUser { get; set; }
        public virtual DbSet<TblApplayerClicklog> TblApplayerClicklog { get; set; }
        public virtual DbSet<TblAutoPush> TblAutoPush { get; set; }
        public virtual DbSet<TblBackupDispCateSecretSale> TblBackupDispCateSecretSale { get; set; }
        public virtual DbSet<TblBackupItemCateSecretSale> TblBackupItemCateSecretSale { get; set; }
        public virtual DbSet<TblBaljuitem> TblBaljuitem { get; set; }
        public virtual DbSet<TblBaljuitemOfflineCustomer> TblBaljuitemOfflineCustomer { get; set; }
        public virtual DbSet<TblBankmailSendlist> TblBankmailSendlist { get; set; }
        public virtual DbSet<TblBarcodeprintItembag> TblBarcodeprintItembag { get; set; }
        public virtual DbSet<TblBreakdownComCode> TblBreakdownComCode { get; set; }
        public virtual DbSet<TblBreakdownRequest> TblBreakdownRequest { get; set; }
        public virtual DbSet<TblBreakdownRequestDetail> TblBreakdownRequestDetail { get; set; }
        public virtual DbSet<TblBreakdownWorkCode> TblBreakdownWorkCode { get; set; }
        public virtual DbSet<TblCjmallCategory> TblCjmallCategory { get; set; }
        public virtual DbSet<TblConstSearchKey> TblConstSearchKey { get; set; }
        public virtual DbSet<TblCouponTempUser> TblCouponTempUser { get; set; }
        public virtual DbSet<TblCsmifinishList> TblCsmifinishList { get; set; }
        public virtual DbSet<TblDiaryDecoItemRanking> TblDiaryDecoItemRanking { get; set; }
        public virtual DbSet<TblDisplayCateWaitItem> TblDisplayCateWaitItem { get; set; }
        public virtual DbSet<TblDisplayNotInItemid> TblDisplayNotInItemid { get; set; }
        public virtual DbSet<TblDotNetTestBoard> TblDotNetTestBoard { get; set; }
        public virtual DbSet<TblEmsServiceArea2014> TblEmsServiceArea2014 { get; set; }
        public virtual DbSet<TblEmsWeigthPrice2014> TblEmsWeigthPrice2014 { get; set; }
        public virtual DbSet<TblEpShopMakerid3depthName> TblEpShopMakerid3depthName { get; set; }
        public virtual DbSet<TblEpShopMappingItem> TblEpShopMappingItem { get; set; }
        public virtual DbSet<TblEpShopNotInItemid> TblEpShopNotInItemid { get; set; }
        public virtual DbSet<TblEpShopNotInMakerid> TblEpShopNotInMakerid { get; set; }
        public virtual DbSet<TblEpShopRecentsellItem> TblEpShopRecentsellItem { get; set; }
        public virtual DbSet<TblEpshop> TblEpshop { get; set; }
        public virtual DbSet<TblEpshopFixedprice> TblEpshopFixedprice { get; set; }
        public virtual DbSet<TblEpshopItemcouponExceptBrand> TblEpshopItemcouponExceptBrand { get; set; }
        public virtual DbSet<TblEpshopItemcouponExceptItem> TblEpshopItemcouponExceptItem { get; set; }
        public virtual DbSet<TblErrMaillist> TblErrMaillist { get; set; }
        public virtual DbSet<TblEtcSpecial> TblEtcSpecial { get; set; }
        public virtual DbSet<TblEtcStyleMaster> TblEtcStyleMaster { get; set; }
        public virtual DbSet<TblEvaluatePushUser> TblEvaluatePushUser { get; set; }
        public virtual DbSet<TblEvaluatedCountPush> TblEvaluatedCountPush { get; set; }
        public virtual DbSet<TblEvent14thTemp> TblEvent14thTemp { get; set; }
        public virtual DbSet<TblEvent16thPickcount> TblEvent16thPickcount { get; set; }
        public virtual DbSet<TblEvent16thPickshow> TblEvent16thPickshow { get; set; }
        public virtual DbSet<TblEvent45262> TblEvent45262 { get; set; }
        public virtual DbSet<TblEvent45883> TblEvent45883 { get; set; }
        public virtual DbSet<TblEvent59086> TblEvent59086 { get; set; }
        public virtual DbSet<TblEvent66520> TblEvent66520 { get; set; }
        public virtual DbSet<TblEvent68736> TblEvent68736 { get; set; }
        public virtual DbSet<TblEvent70029> TblEvent70029 { get; set; }
        public virtual DbSet<TblEvent70875> TblEvent70875 { get; set; }
        public virtual DbSet<TblEvent71730> TblEvent71730 { get; set; }
        public virtual DbSet<TblEvent73053> TblEvent73053 { get; set; }
        public virtual DbSet<TblEvent75840> TblEvent75840 { get; set; }
        public virtual DbSet<TblEvent76299> TblEvent76299 { get; set; }
        public virtual DbSet<TblEvent76711> TblEvent76711 { get; set; }
        public virtual DbSet<TblEvent78942> TblEvent78942 { get; set; }
        public virtual DbSet<TblEvent84539> TblEvent84539 { get; set; }
        public virtual DbSet<TblEvent85916> TblEvent85916 { get; set; }
        public virtual DbSet<TblEventAttendance> TblEventAttendance { get; set; }
        public virtual DbSet<TblEventClickLog> TblEventClickLog { get; set; }
        public virtual DbSet<TblEventEtcYongman> TblEventEtcYongman { get; set; }
        public virtual DbSet<TblEventItemwish> TblEventItemwish { get; set; }
        public virtual DbSet<TblEventMobile74315> TblEventMobile74315 { get; set; }
        public virtual DbSet<TblEventTemp54791> TblEventTemp54791 { get; set; }
        public virtual DbSet<TblEventWinnerExcel> TblEventWinnerExcel { get; set; }
        public virtual DbSet<TblExTmpAca> TblExTmpAca { get; set; }
        public virtual DbSet<TblExTmpBns> TblExTmpBns { get; set; }
        public virtual DbSet<TblExTmpOgn> TblExTmpOgn { get; set; }
        public virtual DbSet<TblExTmpOmm> TblExTmpOmm { get; set; }
        public virtual DbSet<TblExportCsv> TblExportCsv { get; set; }
        public virtual DbSet<TblExtsiteDeliverLink> TblExtsiteDeliverLink { get; set; }
        public virtual DbSet<TblFocusmOrderInfo> TblFocusmOrderInfo { get; set; }
        public virtual DbSet<TblForyouUserDamnbang> TblForyouUserDamnbang { get; set; }
        public virtual DbSet<TblForyouUserDamnbangTemp> TblForyouUserDamnbangTemp { get; set; }
        public virtual DbSet<TblGs25nfcInfo> TblGs25nfcInfo { get; set; }
        public virtual DbSet<TblHmalltemp> TblHmalltemp { get; set; }
        public virtual DbSet<TblITsBuycash> TblITsBuycash { get; set; }
        public virtual DbSet<TblITsItemLink> TblITsItemLink { get; set; }
        public virtual DbSet<TblIdentityTest1> TblIdentityTest1 { get; set; }
        public virtual DbSet<TblInboundItemImage> TblInboundItemImage { get; set; }
        public virtual DbSet<TblInnisfreeCoupon2014> TblInnisfreeCoupon2014 { get; set; }
        public virtual DbSet<TblInterparkTmpDispCategory> TblInterparkTmpDispCategory { get; set; }
        public virtual DbSet<TblInterparkTmpStoreCategory> TblInterparkTmpStoreCategory { get; set; }
        public virtual DbSet<TblItemAttribWaitItem> TblItemAttribWaitItem { get; set; }
        public virtual DbSet<TblItemEditTemp> TblItemEditTemp { get; set; }
        public virtual DbSet<TblItemSearchKeyword> TblItemSearchKeyword { get; set; }
        public virtual DbSet<TblItsTmpBuycacsh20140430> TblItsTmpBuycacsh20140430 { get; set; }
        public virtual DbSet<TblJaehyumallInfoCode> TblJaehyumallInfoCode { get; set; }
        public virtual DbSet<TblJaehyumallNotEditItemid> TblJaehyumallNotEditItemid { get; set; }
        public virtual DbSet<TblJaehyumallNotInItemid> TblJaehyumallNotInItemid { get; set; }
        public virtual DbSet<TblJaehyumallNotInMakerid> TblJaehyumallNotInMakerid { get; set; }
        public virtual DbSet<TblJaehyumallReturnInfo> TblJaehyumallReturnInfo { get; set; }
        public virtual DbSet<TblJungsanTmp> TblJungsanTmp { get; set; }
        public virtual DbSet<TblJust1DayShinhan> TblJust1DayShinhan { get; set; }
        public virtual DbSet<TblKakaotemp> TblKakaotemp { get; set; }
        public virtual DbSet<TblKsearchAttrCd> TblKsearchAttrCd { get; set; }
        public virtual DbSet<TblKsearchAttrListByOption> TblKsearchAttrListByOption { get; set; }
        public virtual DbSet<TblKsearchColorCd> TblKsearchColorCd { get; set; }
        public virtual DbSet<TblKsearchStyleCd> TblKsearchStyleCd { get; set; }
        public virtual DbSet<TblLogAppdownStore> TblLogAppdownStore { get; set; }
        public virtual DbSet<TblLotteCategory> TblLotteCategory { get; set; }
        public virtual DbSet<TblLotteMdcateGrp> TblLotteMdcateGrp { get; set; }
        public virtual DbSet<TblLotteMdinfo> TblLotteMdinfo { get; set; }
        public virtual DbSet<TblLotteNotInMakeridByKimJinYoung> TblLotteNotInMakeridByKimJinYoung { get; set; }
        public virtual DbSet<TblLotteiMallCategory> TblLotteiMallCategory { get; set; }
        public virtual DbSet<TblLotteiMallMdcateGrp> TblLotteiMallMdcateGrp { get; set; }
        public virtual DbSet<TblLotteiMallMdinfo> TblLotteiMallMdinfo { get; set; }
        public virtual DbSet<TblLtiMallCategory> TblLtiMallCategory { get; set; }
        public virtual DbSet<TblLtiMallCategoryBuf> TblLtiMallCategoryBuf { get; set; }
        public virtual DbSet<TblLtiMallCsnoti> TblLtiMallCsnoti { get; set; }
        public virtual DbSet<TblLtiMallOrdNoti> TblLtiMallOrdNoti { get; set; }
        public virtual DbSet<TblLtimallSourceAreaCode> TblLtimallSourceAreaCode { get; set; }
        public virtual DbSet<TblMaeliageDate17thFirst> TblMaeliageDate17thFirst { get; set; }
        public virtual DbSet<TblMaeliageDate17thSecond> TblMaeliageDate17thSecond { get; set; }
        public virtual DbSet<TblMaeliagePush> TblMaeliagePush { get; set; }
        public virtual DbSet<TblMaeliagePush17th> TblMaeliagePush17th { get; set; }
        public virtual DbSet<TblManito2013> TblManito2013 { get; set; }
        public virtual DbSet<TblManito2013Item> TblManito2013Item { get; set; }
        public virtual DbSet<TblMemoryUsage> TblMemoryUsage { get; set; }
        public virtual DbSet<TblMibeasongList> TblMibeasongList { get; set; }
        public virtual DbSet<TblMibeasongOrdermaster> TblMibeasongOrdermaster { get; set; }
        public virtual DbSet<TblMibeasongOrdermasterCanceled> TblMibeasongOrdermasterCanceled { get; set; }
        public virtual DbSet<TblMibeasongOrderserial> TblMibeasongOrderserial { get; set; }
        public virtual DbSet<TblMibeasongSum> TblMibeasongSum { get; set; }
        public virtual DbSet<TblMichulgoMileRecalcuQue> TblMichulgoMileRecalcuQue { get; set; }
        public virtual DbSet<TblMileExpireEmailTarget> TblMileExpireEmailTarget { get; set; }
        public virtual DbSet<TblMiracleOf10Won> TblMiracleOf10Won { get; set; }
        public virtual DbSet<TblMiracleOf10WonList> TblMiracleOf10WonList { get; set; }
        public virtual DbSet<TblMiracleof10secMaster> TblMiracleof10secMaster { get; set; }
        public virtual DbSet<TblMiracleof10secProduct> TblMiracleof10secProduct { get; set; }
        public virtual DbSet<TblMlayerCount> TblMlayerCount { get; set; }
        public virtual DbSet<TblMonthlyAccumulatedLogisstockSummaryBuf> TblMonthlyAccumulatedLogisstockSummaryBuf { get; set; }
        public virtual DbSet<TblMonthlyAccumulatedShopstockSummaryBuf> TblMonthlyAccumulatedShopstockSummaryBuf { get; set; }
        public virtual DbSet<TblMonthlyStockIpgoLedgerSumTemp> TblMonthlyStockIpgoLedgerSumTemp { get; set; }
        public virtual DbSet<TblMulti2mileage> TblMulti2mileage { get; set; }
        public virtual DbSet<TblNateScraplog> TblNateScraplog { get; set; }
        public virtual DbSet<TblNaverItemMap> TblNaverItemMap { get; set; }
        public virtual DbSet<TblNoItemInfoForceSoldOut> TblNoItemInfoForceSoldOut { get; set; }
        public virtual DbSet<TblNvsMinprofit> TblNvsMinprofit { get; set; }
        public virtual DbSet<TblNvsMinprofitLog> TblNvsMinprofitLog { get; set; }
        public virtual DbSet<TblOldStock> TblOldStock { get; set; }
        public virtual DbSet<TblOldStock2012real> TblOldStock2012real { get; set; }
        public virtual DbSet<TblOldStock2012realL> TblOldStock2012realL { get; set; }
        public virtual DbSet<TblOldStock2013real> TblOldStock2013real { get; set; }
        public virtual DbSet<TblOnBeasongExcZipcode> TblOnBeasongExcZipcode { get; set; }
        public virtual DbSet<TblOnlineAppLogTmp> TblOnlineAppLogTmp { get; set; }
        public virtual DbSet<TblOnlineAppNotMatchReasonCode> TblOnlineAppNotMatchReasonCode { get; set; }
        public virtual DbSet<TblOrderDetailForCancel> TblOrderDetailForCancel { get; set; }
        public virtual DbSet<TblOutMallRecentSellData> TblOutMallRecentSellData { get; set; }
        public virtual DbSet<TblPlusSaleLinkItemListBack> TblPlusSaleLinkItemListBack { get; set; }
        public virtual DbSet<TblPlusSaleRegedItemBack> TblPlusSaleRegedItemBack { get; set; }
        public virtual DbSet<TblRedRibbonBrand> TblRedRibbonBrand { get; set; }
        public virtual DbSet<TblRedRibbonItem> TblRedRibbonItem { get; set; }
        public virtual DbSet<TblRedRibbonLog> TblRedRibbonLog { get; set; }
        public virtual DbSet<TblRedRibbonRelateItem> TblRedRibbonRelateItem { get; set; }
        public virtual DbSet<TblRedRibbonWinner> TblRedRibbonWinner { get; set; }
        public virtual DbSet<TblRejectMailTUniq> TblRejectMailTUniq { get; set; }
        public virtual DbSet<TblRelaymileInfo> TblRelaymileInfo { get; set; }
        public virtual DbSet<TblSabannetCs> TblSabannetCs { get; set; }
        public virtual DbSet<TblSabannetDetail> TblSabannetDetail { get; set; }
        public virtual DbSet<TblSabannetLog> TblSabannetLog { get; set; }
        public virtual DbSet<TblSafetycertImageTemp> TblSafetycertImageTemp { get; set; }
        public virtual DbSet<TblSafetycertImageWaititem> TblSafetycertImageWaititem { get; set; }
        public virtual DbSet<TblSafetycertInboundTemp> TblSafetycertInboundTemp { get; set; }
        public virtual DbSet<TblSafetycertInfoTemp> TblSafetycertInfoTemp { get; set; }
        public virtual DbSet<TblSafetycertInfoWaititem> TblSafetycertInfoWaititem { get; set; }
        public virtual DbSet<TblSafetycertTenRegWaititem> TblSafetycertTenRegWaititem { get; set; }
        public virtual DbSet<TblSagawaDeliverArea> TblSagawaDeliverArea { get; set; }
        public virtual DbSet<TblScheduleNotInItemid> TblScheduleNotInItemid { get; set; }
        public virtual DbSet<TblSearchKey> TblSearchKey { get; set; }
        public virtual DbSet<TblShopjumunCardAppLogTmp> TblShopjumunCardAppLogTmp { get; set; }
        public virtual DbSet<TblShopjumunOrdertemp> TblShopjumunOrdertemp { get; set; }
        public virtual DbSet<TblShoplinkerNotInItemid> TblShoplinkerNotInItemid { get; set; }
        public virtual DbSet<TblShoplinkerNotInMakerid> TblShoplinkerNotInMakerid { get; set; }
        public virtual DbSet<TblSnslayerClicklog> TblSnslayerClicklog { get; set; }
        public virtual DbSet<TblTbUser> TblTbUser { get; set; }
        public virtual DbSet<TblTemp2017orderUserPrice> TblTemp2017orderUserPrice { get; set; }
        public virtual DbSet<TblTempCheckLog> TblTempCheckLog { get; set; }
        public virtual DbSet<TblTempEventAddr> TblTempEventAddr { get; set; }
        public virtual DbSet<TblTempItemLarge> TblTempItemLarge { get; set; }
        public virtual DbSet<TblTempItemMid> TblTempItemMid { get; set; }
        public virtual DbSet<TblTempItemSmall> TblTempItemSmall { get; set; }
        public virtual DbSet<TblTempItemcategory> TblTempItemcategory { get; set; }
        public virtual DbSet<TblTempPushtarget405> TblTempPushtarget405 { get; set; }
        public virtual DbSet<TblTempSecreteventUserid> TblTempSecreteventUserid { get; set; }
        public virtual DbSet<TblTempSysEvtcount> TblTempSysEvtcount { get; set; }
        public virtual DbSet<TblTestdevAttribeAlvArray> TblTestdevAttribeAlvArray { get; set; }
        public virtual DbSet<TblTmpCategoryBestChoice> TblTmpCategoryBestChoice { get; set; }
        public virtual DbSet<TblTmpGsOrder> TblTmpGsOrder { get; set; }
        public virtual DbSet<TblTmpMileSum> TblTmpMileSum { get; set; }
        public virtual DbSet<TblToastpopupItemid> TblToastpopupItemid { get; set; }
        public virtual DbSet<TblTodoTest> TblTodoTest { get; set; }
        public virtual DbSet<TblTodoTozzinet> TblTodoTozzinet { get; set; }
        public virtual DbSet<TblUpcheItemedit> TblUpcheItemedit { get; set; }
        public virtual DbSet<TblUserRelateInfo> TblUserRelateInfo { get; set; }
        public virtual DbSet<TblUserRelateList> TblUserRelateList { get; set; }
        public virtual DbSet<TblUserVvip> TblUserVvip { get; set; }
        public virtual DbSet<TblUserinfoUpdateTmp> TblUserinfoUpdateTmp { get; set; }
        public virtual DbSet<TblUserlevelMakeTmp> TblUserlevelMakeTmp { get; set; }
        public virtual DbSet<TblVcharTest> TblVcharTest { get; set; }
        public virtual DbSet<TblWaitItem> TblWaitItem { get; set; }
        public virtual DbSet<TblWaitItemColorOption> TblWaitItemColorOption { get; set; }
        public virtual DbSet<TblWaitItemImage> TblWaitItemImage { get; set; }
        public virtual DbSet<TblWaitItemInfoCont> TblWaitItemInfoCont { get; set; }
        public virtual DbSet<TblWaitItemLog> TblWaitItemLog { get; set; }
        public virtual DbSet<TblWaitItemOptionMultiple> TblWaitItemOptionMultiple { get; set; }
        public virtual DbSet<TblWaitItemoption> TblWaitItemoption { get; set; }
        public virtual DbSet<TblWeekwork> TblWeekwork { get; set; }
        public virtual DbSet<TblWishEventUserfolder> TblWishEventUserfolder { get; set; }
        public virtual DbSet<TblWishlistEvent> TblWishlistEvent { get; set; }
        public virtual DbSet<TblXSiteCsDetail> TblXSiteCsDetail { get; set; }
        public virtual DbSet<TblXSiteCsMaster> TblXSiteCsMaster { get; set; }
        public virtual DbSet<TblXSiteEtcItemLink> TblXSiteEtcItemLink { get; set; }
        public virtual DbSet<TblXSiteJungsanData> TblXSiteJungsanData { get; set; }
        public virtual DbSet<TblXSiteJungsanTmp> TblXSiteJungsanTmp { get; set; }
        public virtual DbSet<TblXSiteTmp11stOrder> TblXSiteTmp11stOrder { get; set; }
        public virtual DbSet<TblXSiteTmpcheckIdx> TblXSiteTmpcheckIdx { get; set; }
        public virtual DbSet<TblXSiteTmpcheckItemStat> TblXSiteTmpcheckItemStat { get; set; }
        public virtual DbSet<TblXSiteTmpcs> TblXSiteTmpcs { get; set; }
        public virtual DbSet<TblXSiteTmpcsTimestamp> TblXSiteTmpcsTimestamp { get; set; }
        public virtual DbSet<TblXSiteTmporder> TblXSiteTmporder { get; set; }
        public virtual DbSet<TblXSiteTmporderBack> TblXSiteTmporderBack { get; set; }
        public virtual DbSet<TblXSiteTmporderBatchAct> TblXSiteTmporderBatchAct { get; set; }
        public virtual DbSet<TblXSiteTmporderTest> TblXSiteTmporderTest { get; set; }
        public virtual DbSet<TblXSiteTmporderTimestamp> TblXSiteTmporderTimestamp { get; set; }
        public virtual DbSet<TblXsiteMayDelOrder> TblXsiteMayDelOrder { get; set; }
        public virtual DbSet<TblXsiteRegItemCheck> TblXsiteRegItemCheck { get; set; }
        public virtual DbSet<TempMailYtw> TempMailYtw { get; set; }
        public virtual DbSet<TempMailYtw1> TempMailYtw1 { get; set; }
        public virtual DbSet<XxTblKsearchAttrSummary> XxTblKsearchAttrSummary { get; set; }

        // Unable to generate entity type for table 'dbo.tbl_xSite_JungsanTmp3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.T2011'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Event_ParentDayExam_Detail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.seasonoff_20140807'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Event_ParentDayExam_Master'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_TMP_BUNGAE'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_tenSurvey'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_saleItem_Upload'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Just1DayViewCnt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_tempDistroDojoUserDataYes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_maeliageDate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_dojo_ex6'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_xSite_jungsanData_imall_2014_01'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Cate_중국인이입력해준거$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_oldStock_2012Real_S'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.yogiyo_coupon_list$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.megebox_coupon_list$'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_display_catemain_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_shopjumun_cardCharge_log_tmp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_event_69627'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TC20000'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.jeon_20141002'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.reject_list'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_cjmall_itemdiv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_count'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_daily_valid_maillist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_interpark_test'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_temp_Send_UserMail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_disEvent'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_rejectMail_T'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Item_Evaluate_OffShop_backup20190530'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Item_Evaluate_backup20190530'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_xSite_jungsanData_imall_2014_02'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_search_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_rejectMail_T2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_xSite_jungsanData_imall_2014_03'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_xSite_JungsanData_dnshop_T'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_11stItem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_11stoption'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_temp_rankmaketable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_gsshop_category'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_oracle1000'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_test_email'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_couponevent'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spUser_20140314'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_reject_thunder'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_itemmod'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SK_201502_H_7005'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SK_201502_I_7005'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LotteeIMallMngCate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_cjmall_SourceAreaCode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_cjmall_makerName'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_cjMall_prdDiv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.spUser_20140326'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_temp_userid'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LTiMall_BrandCate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_gsshop_prddiv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_gsshop_mdid'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_11st_tmpCategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_snslogin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_LTIMall_CateXL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_xxxxx'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_temp_Send_UserSMS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SK_201503_J_7505'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SK_201503_K_7505'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_2008_category_mapping'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.xxx_20160620'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_xxxxx1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_event_instagram'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.emsPrice201110'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.innisfree_couponlist_csv'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_wedding_temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_event_72730'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.wconcept_wizwid_temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_mileExpire_Boru'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_xSite_JungsanData_iMall'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lotte_cateERRItem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_monthly_accumulated_shopstock_summary_BUF2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.T2012'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_xSite_JungsanTmp2'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = 192.168.50.3; Initial Catalog = db_temp; User ID = udb_tenbytendevel; Password=ten101010*;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<DboTempChild>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("dbo_temp_child");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Sexflag)
                    .HasColumnName("sexflag")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KakaoInvite>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("kakao_invite");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.Invitecnt).HasColumnName("invitecnt");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ridx).HasColumnName("ridx");

                entity.Property(e => e.UName)
                    .IsRequired()
                    .HasColumnName("uName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UPhone)
                    .IsRequired()
                    .HasColumnName("uPhone")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Uip)
                    .HasColumnName("uip")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KakaoResult>(entity =>
            {
                entity.HasKey(e => e.Finidx);

                entity.ToTable("kakao_result");

                entity.Property(e => e.Finidx).HasColumnName("finidx");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.Inviteidx).HasColumnName("inviteidx");

                entity.Property(e => e.Okcode)
                    .HasColumnName("okcode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Prizecode)
                    .HasColumnName("prizecode")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Prizeopt1)
                    .HasColumnName("prizeopt1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Prizeopt2)
                    .HasColumnName("prizeopt2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uname)
                    .HasColumnName("uname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uphone)
                    .HasColumnName("uphone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbl13th55075>(entity =>
            {
                entity.HasKey(e => new { e.EvtDate, e.WinNo });

                entity.ToTable("tbl_13th_55075");

                entity.Property(e => e.EvtDate).HasColumnName("evtDate");

                entity.Property(e => e.WinNo).HasColumnName("winNo");

                entity.Property(e => e.Orgcnt).HasColumnName("orgcnt");

                entity.Property(e => e.Sellcnt).HasColumnName("sellcnt");
            });

            modelBuilder.Entity<Tbl14thAnniversaryOurstoryItem>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.Itemid });

                entity.ToTable("tbl_14th_anniversary_ourstory_item");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbl3comdalcomCoupon2015>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_3comdalcom_coupon_2015");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Couponkey)
                    .IsRequired()
                    .HasColumnName("couponkey")
                    .HasMaxLength(150);

                entity.Property(e => e.Gubun).HasColumnName("gubun");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbl3comdalcomCoupon2015Log>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_3comdalcom_coupon_2015_log");

                entity.HasIndex(e => e.Userid)
                    .HasName("IX_Table_1_userid");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Gubun).HasColumnName("gubun");

                entity.Property(e => e.Refip)
                    .IsRequired()
                    .HasColumnName("refip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Renloop).HasColumnName("renloop");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbl3comdalcomCoupon2015Megabox>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_3comdalcom_coupon_2015_megabox");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Couponkey)
                    .IsRequired()
                    .HasColumnName("couponkey")
                    .HasMaxLength(150);

                entity.Property(e => e.Gubun).HasColumnName("gubun");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Subcouponkey)
                    .IsRequired()
                    .HasColumnName("subcouponkey")
                    .HasMaxLength(10);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbl3comdalcomCoupon2015Yogiyo>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_3comdalcom_coupon_2015_yogiyo");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Couponkey)
                    .IsRequired()
                    .HasColumnName("couponkey")
                    .HasMaxLength(150);

                entity.Property(e => e.Gubun).HasColumnName("gubun");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAdminshoppingbag>(entity =>
            {
                entity.HasKey(e => e.Bagidx)
                    .HasName("PK_tbl_shoppingbag");

                entity.ToTable("tbl_adminshoppingbag");

                entity.HasIndex(e => new { e.Userid, e.Shopid })
                    .HasName("IX_tbl_adminshoppingbag_shopid_userid");

                entity.HasIndex(e => new { e.Itemgubun, e.Itemid, e.Itemoption })
                    .HasName("IX_tbl_adminshoppingbag_items");

                entity.Property(e => e.Bagidx).HasColumnName("bagidx");

                entity.Property(e => e.Itemgubun)
                    .IsRequired()
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

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

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAgreeEmailTarget>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymmdd, e.Userid });

                entity.ToTable("tbl_Agree_email_Target");

                entity.Property(e => e.Yyyymmdd)
                    .HasColumnName("yyyymmdd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AgreeEmailFinger)
                    .IsRequired()
                    .HasColumnName("agreeEmailFinger")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgreeEmailTen)
                    .IsRequired()
                    .HasColumnName("agreeEmailTen")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgreePushFinger)
                    .HasColumnName("agreePushFinger")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgreePushTen)
                    .HasColumnName("agreePushTEN")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgreeSmsfinger)
                    .IsRequired()
                    .HasColumnName("agreeSMSFinger")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.AgreeSmsten)
                    .IsRequired()
                    .HasColumnName("agreeSMSTen")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Uidsimple)
                    .HasColumnName("uidsimple")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("uname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Uregdate)
                    .HasColumnName("uregdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usermail)
                    .IsRequired()
                    .HasColumnName("usermail")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAppRealtimeSellItems>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_app_realtime_sell_items");

                entity.HasIndex(e => e.Itemid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Orderno).HasColumnName("orderno");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Selldate)
                    .HasColumnName("selldate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAppfirstOrderUser>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_appfirst_order_User");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblApplayerClicklog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_applayer_clicklog");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rdsite)
                    .HasColumnName("rdsite")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAutoPush>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Userid });

                entity.ToTable("tbl_auto_push");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblBackupDispCateSecretSale>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Catecode })
                    .HasName("PK__tbl_Backup_DispC__43E1002F");

                entity.ToTable("tbl_Backup_DispCate_SecretSale");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.BackupDate)
                    .HasColumnName("backupDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isdefault)
                    .IsRequired()
                    .HasColumnName("isdefault")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('y')");
            });

            modelBuilder.Entity<TblBackupItemCateSecretSale>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.CodeLarge, e.CodeMid, e.CodeSmall })
                    .HasName("PK__tbl_Backup_ItemC__0C90CB45");

                entity.ToTable("tbl_Backup_ItemCate_SecretSale");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.CodeLarge)
                    .HasColumnName("code_large")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMid)
                    .HasColumnName("code_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSmall)
                    .HasColumnName("code_small")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BackupDate)
                    .HasColumnName("backupDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CodeDiv)
                    .IsRequired()
                    .HasColumnName("code_div")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<TblBaljuitem>(entity =>
            {
                entity.HasKey(e => new { e.Baljuid, e.Itemid, e.Itemoption });

                entity.ToTable("tbl_baljuitem");

                entity.Property(e => e.Baljuid).HasColumnName("baljuid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Baljuno)
                    .HasColumnName("baljuno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ipgono)
                    .HasColumnName("ipgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoptionname)
                    .HasColumnName("itemoptionname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemrackcode)
                    .HasColumnName("itemrackcode")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Listimage)
                    .HasColumnName("listimage")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Orgsellprice)
                    .HasColumnName("orgsellprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Printno)
                    .HasColumnName("printno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rackcode)
                    .HasColumnName("rackcode")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Smallimage)
                    .HasColumnName("smallimage")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBaljuitemOfflineCustomer>(entity =>
            {
                entity.HasKey(e => new { e.Baljuid, e.Itemgubun, e.Itemid, e.Itemoption });

                entity.ToTable("tbl_baljuitem_offline_customer");

                entity.Property(e => e.Baljuid).HasColumnName("baljuid");

                entity.Property(e => e.Itemgubun)
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Baljuno)
                    .HasColumnName("baljuno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ipgono)
                    .HasColumnName("ipgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoptionname)
                    .HasColumnName("itemoptionname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemrackcode)
                    .HasColumnName("itemrackcode")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Listimage)
                    .HasColumnName("listimage")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Orgsellprice)
                    .HasColumnName("orgsellprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Printno)
                    .HasColumnName("printno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rackcode)
                    .HasColumnName("rackcode")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Smallimage)
                    .HasColumnName("smallimage")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBankmailSendlist>(entity =>
            {
                entity.HasKey(e => e.Orderserial);

                entity.ToTable("tbl_bankmail_sendlist");

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Senddate)
                    .HasColumnName("senddate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblBarcodeprintItembag>(entity =>
            {
                entity.HasKey(e => e.Bagidx);

                entity.ToTable("tbl_barcodeprint_itembag");

                entity.Property(e => e.Bagidx).HasColumnName("bagidx");

                entity.Property(e => e.Itemgubun)
                    .IsRequired()
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

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

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBreakdownComCode>(entity =>
            {
                entity.HasKey(e => new { e.CodeType, e.CodeValue });

                entity.ToTable("tbl_breakdown_comCode");

                entity.Property(e => e.CodeType)
                    .HasColumnName("code_type")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeValue).HasColumnName("code_value");

                entity.Property(e => e.CodeComp)
                    .HasColumnName("code_comp")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CodeDesc)
                    .HasColumnName("code_desc")
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeProd)
                    .HasColumnName("code_prod")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSort).HasColumnName("code_sort");

                entity.Property(e => e.CodeUseyn)
                    .IsRequired()
                    .HasColumnName("code_useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblBreakdownRequest>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_breakdown_request");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ReqPartSn).HasColumnName("req_part_sn");

                entity.Property(e => e.ReqRegdate)
                    .HasColumnName("req_regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqUserid)
                    .IsRequired()
                    .HasColumnName("req_userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBreakdownRequestDetail>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.ReqIdx });

                entity.ToTable("tbl_breakdown_request_detail");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReqIdx).HasColumnName("req_idx");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.NowWorker)
                    .HasColumnName("now_worker")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReqCaptimage)
                    .HasColumnName("req_captimage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReqComment)
                    .HasColumnName("req_comment")
                    .HasColumnType("text");

                entity.Property(e => e.ReqEquipment).HasColumnName("req_equipment");

                entity.Property(e => e.WorkComment)
                    .HasColumnName("work_comment")
                    .HasColumnType("text");

                entity.Property(e => e.WorkLastupdate)
                    .HasColumnName("work_lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkPartSn).HasColumnName("work_part_sn");

                entity.Property(e => e.WorkStartdate)
                    .HasColumnName("work_startdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkState).HasColumnName("work_state");

                entity.Property(e => e.WorkTarget)
                    .IsRequired()
                    .HasColumnName("work_target")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WorkType).HasColumnName("work_type");

                entity.HasOne(d => d.ReqIdxNavigation)
                    .WithMany(p => p.TblBreakdownRequestDetail)
                    .HasForeignKey(d => d.ReqIdx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_breakdown_request_detail_tbl_breakdown_request");
            });

            modelBuilder.Entity<TblBreakdownWorkCode>(entity =>
            {
                entity.HasKey(e => new { e.PartSn, e.WorkType, e.WorkTarget });

                entity.ToTable("tbl_breakdown_work_code");

                entity.Property(e => e.PartSn).HasColumnName("part_sn");

                entity.Property(e => e.WorkType).HasColumnName("work_type");

                entity.Property(e => e.WorkTarget)
                    .HasColumnName("work_target")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WorkSortno).HasColumnName("work_sortno");

                entity.Property(e => e.WorkTargetName)
                    .HasColumnName("work_target_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WorkTypeName)
                    .HasColumnName("work_type_name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WorkUseyn)
                    .IsRequired()
                    .HasColumnName("work_useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);
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

            modelBuilder.Entity<TblConstSearchKey>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("tbl_const_search_key");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Overlapcount).HasColumnName("overlapcount");
            });

            modelBuilder.Entity<TblCouponTempUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tbl_couponTempUs__05A3D694");

                entity.ToTable("tbl_couponTempUser");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Div)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCsmifinishList>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_csmifinish_list");

                entity.HasIndex(e => new { e.Ipgodate, e.Csdetailidx })
                    .HasName("IX_tbl_csmifinish_list_csdetailidx");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Csdetailidx).HasColumnName("csdetailidx");

                entity.Property(e => e.Finishstr)
                    .HasColumnName("finishstr")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ipgodate)
                    .HasColumnName("ipgodate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsSendCall)
                    .HasColumnName("isSendCall")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsSendEmail)
                    .HasColumnName("isSendEmail")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsSendSms)
                    .HasColumnName("isSendSMS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemlackno).HasColumnName("itemlackno");

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoptionname)
                    .HasColumnName("itemoptionname")
                    .HasMaxLength(96)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orderserial)
                    .IsRequired()
                    .HasColumnName("orderserial")
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

                entity.Property(e => e.Reqstr)
                    .HasColumnName("reqstr")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblDiaryDecoItemRanking>(entity =>
            {
                entity.HasKey(e => new { e.Rankdate, e.Itemid });

                entity.ToTable("tbl_DiaryDecoItemRanking");

                entity.Property(e => e.Rankdate)
                    .HasColumnName("rankdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Itemscore).HasColumnName("itemscore");
            });

            modelBuilder.Entity<TblDisplayCateWaitItem>(entity =>
            {
                entity.HasKey(e => new { e.Catecode, e.Itemid })
                    .HasName("PK_tbl_display_cate_WaitItem");

                entity.ToTable("tbl_display_cate_waitItem");

                entity.HasIndex(e => e.Catecode)
                    .HasName("IX_display_cate_waitItem_catecode");

                entity.HasIndex(e => e.Itemid)
                    .HasName("IX_display_cate_waitItem_itemid");

                entity.Property(e => e.Catecode).HasColumnName("catecode");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.IsDefault)
                    .IsRequired()
                    .HasColumnName("isDefault")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SortNo).HasColumnName("sortNo");
            });

            modelBuilder.Entity<TblDisplayNotInItemid>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Mallgubun })
                    .HasName("PK__tbl_display_n__72E607DB");

                entity.ToTable("tbl_display_not_in_itemid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

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

            modelBuilder.Entity<TblDotNetTestBoard>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_dotNet_TestBoard");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnName("contents")
                    .HasColumnType("text");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmsServiceArea2014>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("PK_tbl_ems_ServeiceArea_2014");

                entity.ToTable("tbl_ems_serviceArea_2014");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("countryCode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryNameEn)
                    .IsRequired()
                    .HasColumnName("countryNameEn")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryNameKr)
                    .IsRequired()
                    .HasColumnName("countryNameKr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmsAreaCode)
                    .IsRequired()
                    .HasColumnName("emsAreaCode")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EmsMaxWeight).HasColumnName("emsMaxWeight");

                entity.Property(e => e.EtcContents)
                    .HasColumnName("etcContents")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ReceiverPay)
                    .IsRequired()
                    .HasColumnName("receiverPay")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblEmsWeigthPrice2014>(entity =>
            {
                entity.HasKey(e => new { e.EmsAreaCode, e.WeightLimit });

                entity.ToTable("tbl_ems_weigthPrice_2014");

                entity.Property(e => e.EmsAreaCode)
                    .HasColumnName("emsAreaCode")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmsPrice)
                    .HasColumnName("emsPrice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblEpShopMakerid3depthName>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Makerid, e.Mallgubun });

                entity.ToTable("tbl_EpShop_makerid_3depthName");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Depthname)
                    .IsRequired()
                    .HasColumnName("depthname")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
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
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updateid)
                    .HasColumnName("updateid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEpShopMappingItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_EpShop_Mapping_item");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Highcash)
                    .HasColumnName("highcash")
                    .HasColumnType("money");

                entity.Property(e => e.Lowcash)
                    .HasColumnName("lowcash")
                    .HasColumnType("money");

                entity.Property(e => e.Malllowrank).HasColumnName("malllowrank");

                entity.Property(e => e.Mallmaxrank).HasColumnName("mallmaxrank");

                entity.Property(e => e.MatchNvMid)
                    .HasColumnName("matchNvMid")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Myrank).HasColumnName("myrank");

                entity.Property(e => e.Rank2price)
                    .HasColumnName("rank2price")
                    .HasColumnType("money");

                entity.Property(e => e.Rank3price)
                    .HasColumnName("rank3price")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SamecashCnt).HasColumnName("samecashCnt");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblEpShopNotInItemid>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_EpShop_not_in_itemid");

                entity.HasIndex(e => e.Itemid)
                    .HasName("IX_tbl_EpShop_not_in_itemid");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mallgubun)
                    .IsRequired()
                    .HasColumnName("mallgubun")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regid)
                    .IsRequired()
                    .HasColumnName("regid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updateid)
                    .HasColumnName("updateid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEpShopNotInMakerid>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_EpShop_not_in_makerid");

                entity.HasIndex(e => e.Makerid)
                    .HasName("IX_tbl_EpShop_not_in_makerid");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mallgubun)
                    .IsRequired()
                    .HasColumnName("mallgubun")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regid)
                    .IsRequired()
                    .HasColumnName("regid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updateid)
                    .HasColumnName("updateid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEpShopRecentsellItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_EpShop_recentsell_item");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ord1Days).HasColumnName("ord1Days");

                entity.Property(e => e.OrdNdays).HasColumnName("ordNDays");

                entity.Property(e => e.Sell1Days).HasColumnName("sell1Days");

                entity.Property(e => e.SellNdays).HasColumnName("sellNDays");
            });

            modelBuilder.Entity<TblEpshop>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Mallgubun });

                entity.ToTable("tbl_Epshop");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEpshopFixedprice>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_Epsh__56A22C92F09D05A8");

                entity.ToTable("tbl_Epshop_fixedprice");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fixedcash)
                    .HasColumnName("fixedcash")
                    .HasColumnType("money");

                entity.Property(e => e.Regdt)
                    .HasColumnName("regdt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Upddt)
                    .HasColumnName("upddt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblEpshopItemcouponExceptBrand>(entity =>
            {
                entity.HasKey(e => e.Makerid);

                entity.ToTable("tbl_Epshop_itemcoupon_Except_Brand");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AsignMaxDt).HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguser)
                    .HasColumnName("reguser")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEpshopItemcouponExceptItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_Epshop_itemcoupon_Except_item");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AsignMaxDt).HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguser)
                    .HasColumnName("reguser")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblErrMaillist>(entity =>
            {
                entity.HasKey(e => e.Usermail);

                entity.ToTable("tbl_err_maillist");

                entity.Property(e => e.Usermail)
                    .HasColumnName("usermail")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblEtcSpecial>(entity =>
            {
                entity.HasKey(e => new { e.Sitename, e.Itemid });

                entity.ToTable("tbl_etc_special");

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Dispnum)
                    .HasColumnName("dispnum")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Disptitle)
                    .HasColumnName("disptitle")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblEtcStyleMaster>(entity =>
            {
                entity.HasKey(e => new { e.Styleserial, e.Sitename });

                entity.ToTable("tbl_etc_style_master");

                entity.Property(e => e.Styleserial)
                    .HasColumnName("styleserial")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Dispnum)
                    .HasColumnName("dispnum")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Imagemain)
                    .HasColumnName("imagemain")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Imageoff)
                    .HasColumnName("imageoff")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Imageon)
                    .HasColumnName("imageon")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Imagetitle)
                    .HasColumnName("imagetitle")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Styletitle)
                    .HasColumnName("styletitle")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Useimagemain)
                    .HasColumnName("useimagemain")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvaluatePushUser>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_Evaluate_push_user");

                entity.HasIndex(e => e.Sendyn);

                entity.HasIndex(e => e.Userid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Pushidx).HasColumnName("pushidx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sendyn)
                    .IsRequired()
                    .HasColumnName("sendyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Writeyn)
                    .IsRequired()
                    .HasColumnName("writeyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblEvaluatedCountPush>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_evaluated_count_push");

                entity.HasIndex(e => e.Pushidx);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pushidx).HasColumnName("pushidx");

                entity.Property(e => e.ReviewCount).HasColumnName("reviewCount");
            });

            modelBuilder.Entity<TblEvent14thTemp>(entity =>
            {
                entity.ToTable("tbl_event_14th_temp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Joincnt).HasColumnName("joincnt");

                entity.Property(e => e.Snscnt).HasColumnName("snscnt");
            });

            modelBuilder.Entity<TblEvent16thPickcount>(entity =>
            {
                entity.HasKey(e => new { e.EvtCode, e.EvtSubCode, e.Itemid });

                entity.ToTable("tbl_event_16th_pickcount");

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.EvtSubCode).HasColumnName("evt_sub_code");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Pickcount).HasColumnName("pickcount");
            });

            modelBuilder.Entity<TblEvent16thPickshow>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_16th_pickshow");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.EvtSubCode).HasColumnName("evt_sub_code");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Pickitem1).HasColumnName("pickitem1");

                entity.Property(e => e.Pickitem2).HasColumnName("pickitem2");

                entity.Property(e => e.Pickitem3).HasColumnName("pickitem3");

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

            modelBuilder.Entity<TblEvent45262>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_event_45262_1");

                entity.ToTable("tbl_event_45262");

                entity.HasIndex(e => e.Userid)
                    .HasName("IX_tbl_event_45262");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.IsClear)
                    .IsRequired()
                    .HasColumnName("isClear")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nowtime).HasColumnName("nowtime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvent45883>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_event_45883__4C764630");

                entity.ToTable("tbl_event_45883");

                entity.HasIndex(e => e.Regdate)
                    .HasName("IX_tbl_event_45883_date");

                entity.HasIndex(e => e.Userid)
                    .HasName("IX_tbl_event_45883");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Chktime).HasColumnName("chktime");

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

            modelBuilder.Entity<TblEvent59086>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_59086");

                entity.HasIndex(e => e.LikeCnt);

                entity.HasIndex(e => e.Question);

                entity.HasIndex(e => e.Userid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Device)
                    .IsRequired()
                    .HasColumnName("device")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LikeCnt).HasColumnName("likeCnt");

                entity.Property(e => e.Question).HasColumnName("question");

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

            modelBuilder.Entity<TblEvent66520>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_66520");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Device)
                    .HasColumnName("device")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('W')");

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubOpt1)
                    .HasColumnName("sub_opt1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SubOpt2)
                    .HasColumnName("sub_opt2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubOpt3)
                    .HasColumnName("sub_opt3")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvent68736>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_68736");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvent70029>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_70029");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.LineNum).HasColumnName("lineNum");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvent70875>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_70875");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Gubun)
                    .HasColumnName("gubun")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblEvent71730>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_event_71730");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblEvent73053>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.Time, e.Device });

                entity.ToTable("tbl_event_73053");

                entity.HasIndex(e => e.Device)
                    .HasName("IX_tbl_event_73053");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Device)
                    .HasColumnName("device")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Count).HasColumnName("count");
            });

            modelBuilder.Entity<TblEvent75840>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_75840");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Etc)
                    .HasColumnName("etc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ex1)
                    .HasColumnName("ex1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ex10)
                    .HasColumnName("ex10")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ex2)
                    .HasColumnName("ex2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ex3)
                    .HasColumnName("ex3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ex4)
                    .HasColumnName("ex4")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ex5)
                    .HasColumnName("ex5")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ex6)
                    .HasColumnName("ex6")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ex7)
                    .HasColumnName("ex7")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ex8)
                    .HasColumnName("ex8")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ex9)
                    .HasColumnName("ex9")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvent76299>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_76299");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Ex1)
                    .HasColumnName("ex1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ex2)
                    .HasColumnName("ex2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ex3)
                    .HasColumnName("ex3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ex4)
                    .HasColumnName("ex4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ex5)
                    .HasColumnName("ex5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ex6)
                    .HasColumnName("ex6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ex7)
                    .HasColumnName("ex7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvent76711>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_76711");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Ex2).HasColumnName("ex2");

                entity.Property(e => e.Ex3).HasColumnName("ex3");

                entity.Property(e => e.Ex4).HasColumnName("ex4");

                entity.Property(e => e.Ex5).HasColumnName("ex5");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vtype)
                    .HasColumnName("vtype")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Yyyymmdd)
                    .IsRequired()
                    .HasColumnName("yyyymmdd")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvent78942>(entity =>
            {
                entity.HasKey(e => e.Couponnum);

                entity.ToTable("tbl_event_78942");

                entity.Property(e => e.Couponnum)
                    .HasColumnName("couponnum")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvent84539>(entity =>
            {
                entity.HasKey(e => e.Hellokey);

                entity.ToTable("tbl_event_84539");

                entity.Property(e => e.Hellokey)
                    .HasColumnName("hellokey")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Usedate)
                    .HasColumnName("usedate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEvent85916>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_event_85916");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblEventAttendance>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_attendance");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEventClickLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_click_log");

                entity.HasIndex(e => e.Chkid);

                entity.HasIndex(e => e.Eventid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Chkid)
                    .IsRequired()
                    .HasColumnName("chkid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Eventid)
                    .IsRequired()
                    .HasColumnName("eventid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Temp1).HasColumnName("temp1");
            });

            modelBuilder.Entity<TblEventEtcYongman>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_etc_event_yongman");

                entity.ToTable("tbl_event_etc_yongman");

                entity.HasIndex(e => e.Couponidx)
                    .HasName("IX_couponidx");

                entity.HasIndex(e => e.EventCode)
                    .HasName("IX_event_code");

                entity.HasIndex(e => e.Userid)
                    .HasName("IX_userid");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Bigo)
                    .HasColumnName("bigo")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Couponidx).HasColumnName("couponidx");

                entity.Property(e => e.Email10x10)
                    .HasColumnName("email_10x10")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Emailok)
                    .HasColumnName("emailok")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EventCode).HasColumnName("event_code");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Smsok)
                    .HasColumnName("smsok")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Usercell)
                    .HasColumnName("usercell")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Usermail)
                    .HasColumnName("usermail")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Winnerdate)
                    .HasColumnName("winnerdate")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEventItemwish>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_itemwish");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Device)
                    .HasColumnName("device")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.Gubun).HasColumnName("gubun");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEventMobile74315>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_event_Mobile_74315");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Dispsunseo).HasColumnName("dispsunseo");

                entity.Property(e => e.IsOnlyYn)
                    .IsRequired()
                    .HasColumnName("isOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");

                entity.Property(e => e.UnderGubun)
                    .HasColumnName("underGubun")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEventTemp54791>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_event_temp_54791");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblEventWinnerExcel>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.EvtCode });

                entity.ToTable("tbl_event_winner_excel");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");
            });

            modelBuilder.Entity<TblExTmpAca>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_Ex_tmp_ACA");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Academyordergainmileage)
                    .HasColumnName("academyordergainmileage")
                    .HasColumnType("money");

                entity.Property(e => e.Academyorderminusmileage)
                    .HasColumnName("academyorderminusmileage")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblExTmpBns>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_Ex_tmp_BNS");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Bonusgainmileage)
                    .HasColumnName("bonusgainmileage")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblExTmpOgn>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_Ex_tmp_OGN");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ordergainmileage)
                    .HasColumnName("ordergainmileage")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblExTmpOmm>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_Ex_tmp_OMM");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Orderminusmileage)
                    .HasColumnName("orderminusmileage")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblExportCsv>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_export_csv");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ColumnNames)
                    .IsRequired()
                    .HasColumnName("columnNames")
                    .IsUnicode(false);

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnName("params")
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SqlStr)
                    .IsRequired()
                    .HasColumnName("sqlStr")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblExtsiteDeliverLink>(entity =>
            {
                entity.HasKey(e => new { e.Sitename, e.Extbaljuno, e.Extorderno });

                entity.ToTable("tbl_extsite_deliverLink");

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Extbaljuno)
                    .HasColumnName("extbaljuno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Extorderno)
                    .HasColumnName("extorderno")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Isfinished)
                    .HasColumnName("isfinished")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblFocusmOrderInfo>(entity =>
            {
                entity.HasKey(e => new { e.Orderserial, e.Itemid })
                    .HasName("PK_tbl_focusm_orderInfo_orderserial");

                entity.ToTable("tbl_focusm_orderInfo");

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.AdCode)
                    .HasColumnName("adCode")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Gadid)
                    .HasColumnName("gadid")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.MediaCode)
                    .HasColumnName("mediaCode")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NumOfItem).HasColumnName("numOfItem");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transactionId")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblForyouUserDamnbang>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Itemid });

                entity.ToTable("tbl_foryou_user_damnbang");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Gubun).HasColumnName("gubun");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TblForyouUserDamnbangTemp>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Itemid });

                entity.ToTable("tbl_foryou_user_damnbang_temp");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Gubun).HasColumnName("gubun");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<TblGs25nfcInfo>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_gs25nfcInfo__7172C0B5");

                entity.ToTable("tbl_gs25nfcInfo");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CpAuthNo)
                    .HasColumnName("cpAuthNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Div)
                    .IsRequired()
                    .HasColumnName("div")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('G')");

                entity.Property(e => e.Hp)
                    .IsRequired()
                    .HasColumnName("hp")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Stat)
                    .IsRequired()
                    .HasColumnName("stat")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblHmalltemp>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_hmalltemp");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.Regstate)
                    .HasColumnName("regstate")
                    .HasMaxLength(50);

                entity.Property(e => e.SlitmCd)
                    .HasColumnName("slitmCd")
                    .HasMaxLength(20);

                entity.Property(e => e.StateName).HasMaxLength(20);

                entity.Property(e => e.Stcd)
                    .HasColumnName("stcd")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorItemid).HasMaxLength(30);
            });

            modelBuilder.Entity<TblITsBuycash>(entity =>
            {
                entity.HasKey(e => new { e.Itemgubun, e.Itemid, e.Itemoption });

                entity.ToTable("tbl_iTs_buycash");

                entity.Property(e => e.Itemgubun)
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasColumnName("barcode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ITsSellcash)
                    .HasColumnName("iTsSellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Itsbuycash)
                    .HasColumnName("itsbuycash")
                    .HasColumnType("money");

                entity.Property(e => e.OptAddprice)
                    .HasColumnName("optAddprice")
                    .HasColumnType("money");

                entity.Property(e => e.Pbuycash)
                    .HasColumnName("pbuycash")
                    .HasColumnType("money");

                entity.Property(e => e.Psellcash)
                    .HasColumnName("psellcash")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblITsItemLink>(entity =>
            {
                entity.HasKey(e => new { e.ItemSeq, e.OptionCode });

                entity.ToTable("tbl_iTS_itemLink");

                entity.Property(e => e.ItemSeq).HasColumnName("itemSeq");

                entity.Property(e => e.OptionCode)
                    .HasColumnName("optionCode")
                    .HasMaxLength(2);

                entity.Property(e => e.Barcode).HasMaxLength(20);

                entity.Property(e => e.ConsumerPrice).HasColumnType("money");

                entity.Property(e => e.ItemName)
                    .HasColumnName("itemName")
                    .HasMaxLength(100);

                entity.Property(e => e.LastItsipgoMonth)
                    .HasColumnName("lastITSIpgoMonth")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.OptionCodeName).HasMaxLength(200);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("productPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellPrice).HasColumnType("money");

                entity.Property(e => e.SubProductPrice).HasColumnType("money");

                entity.Property(e => e.SupplyPrice).HasColumnType("money");
            });

            modelBuilder.Entity<TblIdentityTest1>(entity =>
            {
                entity.HasKey(e => e.T1);

                entity.ToTable("tbl_identity_test1");

                entity.Property(e => e.T1)
                    .HasColumnName("t1")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Col1)
                    .HasColumnName("col1")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Col2)
                    .HasColumnName("col2")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdt)
                    .HasColumnName("regdt")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Useq)
                    .HasColumnName("useq")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblInboundItemImage>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_inbound_item_image");

                entity.ToTable("tbl_Inbound_item_image");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImgAdd1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgAdd2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgAdd3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgAdd4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgAdd5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgBasic)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain10)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain4)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain5)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain6)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain7)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain8)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMain9)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ImgMask)
                    .HasColumnName("imgMask")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain)
                    .HasColumnName("mobileimgmain")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain10)
                    .HasColumnName("mobileimgmain10")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain11)
                    .HasColumnName("mobileimgmain11")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain12)
                    .HasColumnName("mobileimgmain12")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain2)
                    .HasColumnName("mobileimgmain2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain3)
                    .HasColumnName("mobileimgmain3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain4)
                    .HasColumnName("mobileimgmain4")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain5)
                    .HasColumnName("mobileimgmain5")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain6)
                    .HasColumnName("mobileimgmain6")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain7)
                    .HasColumnName("mobileimgmain7")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain8)
                    .HasColumnName("mobileimgmain8")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimgmain9)
                    .HasColumnName("mobileimgmain9")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Regid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInnisfreeCoupon2014>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Couponkey });

                entity.ToTable("tbl_innisfree_coupon_2014");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Couponkey)
                    .HasColumnName("couponkey")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Gubun)
                    .IsRequired()
                    .HasColumnName("gubun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblInterparkTmpDispCategory>(entity =>
            {
                entity.HasKey(e => e.DispCateCode);

                entity.ToTable("tbl_interpark_Tmp_DispCategory");

                entity.Property(e => e.DispCateCode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DispCateName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dispyn)
                    .HasColumnName("dispyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.IParkmodDts)
                    .HasColumnName("iParkmodDts")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IParkregDts)
                    .HasColumnName("iParkregDts")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IsChildrenCate)
                    .HasColumnName("isChildrenCate")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsElecCate)
                    .HasColumnName("isElecCate")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsLifeCate)
                    .HasColumnName("isLifeCate")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastRegDate)
                    .HasColumnName("lastRegDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblInterparkTmpStoreCategory>(entity =>
            {
                entity.HasKey(e => new { e.SupplyCtrtSeqName, e.StoreCateCode });

                entity.ToTable("tbl_interpark_Tmp_StoreCategory");

                entity.Property(e => e.StoreCateCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Dispyn)
                    .HasColumnName("dispyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.StoreCateName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemAttribWaitItem>(entity =>
            {
                entity.HasKey(e => new { e.AttribCd, e.Itemid })
                    .HasName("PK__tbl_itemAttrib_w__532343BF");

                entity.ToTable("tbl_itemAttrib_waitItem");

                entity.Property(e => e.AttribCd)
                    .HasColumnName("attribCd")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItemEditTemp>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_item_edit_temp");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Failtype)
                    .HasColumnName("failtype")
                    .HasMaxLength(1);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Ordertempstatus)
                    .HasColumnName("ordertempstatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Orgprice)
                    .HasColumnName("orgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Regadminid)
                    .IsRequired()
                    .HasColumnName("regadminid")
                    .HasMaxLength(32);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblItemSearchKeyword>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_item_searchK__361CF0BD");

                entity.ToTable("tbl_item_searchKeyword");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblItsTmpBuycacsh20140430>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK_tbl_ITS_tmp_buycacsh");

                entity.ToTable("tbl_ITS_tmp_buycacsh_20140430");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money");

                entity.Property(e => e.Orgprice)
                    .HasColumnName("orgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Orgsuplycash)
                    .HasColumnName("orgsuplycash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblJaehyumallInfoCode>(entity =>
            {
                entity.HasKey(e => new { e.Mallgubun, e.InfoCd, e.InfoDiv });

                entity.ToTable("tbl_jaehyumall_infoCode");

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCd)
                    .HasColumnName("infoCd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InfoDiv)
                    .HasColumnName("infoDiv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InfoDesc)
                    .HasColumnName("infoDesc")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InfoDivName)
                    .IsRequired()
                    .HasColumnName("infoDivName")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InfoItemName)
                    .IsRequired()
                    .HasColumnName("infoItemName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.SortNo).HasColumnName("sortNo");
            });

            modelBuilder.Entity<TblJaehyumallNotEditItemid>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Mallgubun });

                entity.ToTable("tbl_jaehyumall_not_edit_itemid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EdDt)
                    .HasColumnName("edDt")
                    .HasColumnType("datetime");

                entity.Property(e => e.StDt)
                    .HasColumnName("stDt")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblJaehyumallNotInItemid>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Mallgubun })
                    .HasName("PK__tbl_jaehyumall_n__72E607DB");

                entity.ToTable("tbl_jaehyumall_not_in_itemid");

                entity.HasIndex(e => e.Idx)
                    .HasName("IX_tbl_jaehyumall_not_in_itemid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

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

            modelBuilder.Entity<TblJaehyumallNotInMakerid>(entity =>
            {
                entity.HasKey(e => new { e.Makerid, e.Mallgubun })
                    .HasName("PK_tbl_interpark_not_in_makerid");

                entity.ToTable("tbl_jaehyumall_not_in_makerid");

                entity.HasIndex(e => e.Idx)
                    .HasName("IX_tbl_jaehyumall_not_in_makerid");

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

            modelBuilder.Entity<TblJaehyumallReturnInfo>(entity =>
            {
                entity.HasKey(e => new { e.Mallgubun, e.ReturnCode });

                entity.ToTable("tbl_jaehyumall_returnInfo");

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MapPid)
                    .HasColumnName("mapPid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnAddress)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblJungsanTmp>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.Makerid, e.Mwgubun });

                entity.ToTable("tbl_jungsanTmp");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mwgubun)
                    .HasColumnName("mwgubun")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cnt)
                    .HasColumnName("cnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Execcnt)
                    .HasColumnName("execcnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Execok)
                    .HasColumnName("execok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblJust1DayShinhan>(entity =>
            {
                entity.HasKey(e => e.JustDate)
                    .HasName("PK__tbl_just1Day_Shi__53D770D6");

                entity.ToTable("tbl_just1Day_Shinhan");

                entity.Property(e => e.JustDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Adminid)
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.JustDesc)
                    .HasColumnName("justDesc")
                    .HasColumnType("text");

                entity.Property(e => e.JustSalePrice)
                    .HasColumnName("justSalePrice")
                    .HasColumnType("money");

                entity.Property(e => e.LimitNo).HasColumnName("limitNo");

                entity.Property(e => e.LimitSold).HasColumnName("limitSold");

                entity.Property(e => e.OrgPrice)
                    .HasColumnName("orgPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SaleSuplyCash)
                    .HasColumnName("saleSuplyCash")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblKakaotemp>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("Tbl_kakaotemp");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.BasicShip).HasMaxLength(50);

                entity.Property(e => e.ChanelNo)
                    .HasColumnName("chanelNo")
                    .HasMaxLength(50);

                entity.Property(e => e.Chanelname)
                    .HasColumnName("chanelname")
                    .HasMaxLength(200);

                entity.Property(e => e.Changelog)
                    .HasColumnName("changelog")
                    .HasMaxLength(50);

                entity.Property(e => e.DirectOrder).HasMaxLength(50);

                entity.Property(e => e.EventName).HasMaxLength(50);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(50);

                entity.Property(e => e.KakaoNo).HasMaxLength(50);

                entity.Property(e => e.Lognship).HasMaxLength(50);

                entity.Property(e => e.Maibgubun).HasMaxLength(50);

                entity.Property(e => e.ModelName).HasMaxLength(200);

                entity.Property(e => e.NormalPrice).HasMaxLength(50);

                entity.Property(e => e.OneSell).HasMaxLength(50);

                entity.Property(e => e.Options)
                    .HasColumnName("options")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.Property(e => e.Productinfo)
                    .HasColumnName("productinfo")
                    .HasMaxLength(50);

                entity.Property(e => e.RemainQty).HasMaxLength(50);

                entity.Property(e => e.SailQty).HasMaxLength(50);

                entity.Property(e => e.SaliJehan).HasMaxLength(50);

                entity.Property(e => e.SellEnd).HasMaxLength(50);

                entity.Property(e => e.SellNumber).HasMaxLength(50);

                entity.Property(e => e.SellPrice).HasMaxLength(50);

                entity.Property(e => e.SellQty).HasMaxLength(50);

                entity.Property(e => e.SellStart).HasMaxLength(50);

                entity.Property(e => e.SellState).HasMaxLength(50);

                entity.Property(e => e.Selljudge).HasMaxLength(50);

                entity.Property(e => e.ShipKind).HasMaxLength(50);

                entity.Property(e => e.StockQty).HasMaxLength(50);

                entity.Property(e => e.SusuPrice).HasMaxLength(50);

                entity.Property(e => e.WholePrice).HasMaxLength(50);
            });

            modelBuilder.Entity<TblKsearchAttrCd>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_ksearch_attrCd");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttrCdArr)
                    .IsRequired()
                    .HasColumnName("attrCdArr")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AttrGrpArr)
                    .IsRequired()
                    .HasColumnName("attrGrpArr")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.AttrNmArr)
                    .HasColumnName("attrNmArr")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblKsearchAttrListByOption>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_ksearch_attrListByOption");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.OptAttriblist)
                    .IsRequired()
                    .HasColumnName("opt_attriblist")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblKsearchColorCd>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_ksearch_colorCd");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.ColorBasicImgArr)
                    .IsRequired()
                    .HasColumnName("colorBasicImgArr")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ColorCdArr)
                    .IsRequired()
                    .HasColumnName("colorCdArr")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ColorGrpArr)
                    .IsRequired()
                    .HasColumnName("colorGrpArr")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblKsearchStyleCd>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK_tbl_kserch_styleCd");

                entity.ToTable("tbl_ksearch_styleCd");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.StyleCdArr)
                    .IsRequired()
                    .HasColumnName("styleCdArr")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLogAppdownStore>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_log_appdown_store");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Store)
                    .HasColumnName("store")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLotteCategory>(entity =>
            {
                entity.HasKey(e => e.DispNo)
                    .HasName("PK__tbl_lotte_Catego__6B44E613");

                entity.ToTable("tbl_lotte_Category");

                entity.Property(e => e.DispNo)
                    .HasMaxLength(38)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DispLrgNm)
                    .HasColumnName("dispLrgNm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DispMidNm)
                    .HasColumnName("dispMidNm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DispNm)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DispSmlNm)
                    .HasColumnName("dispSmlNm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DispThnNm)
                    .HasColumnName("dispThnNm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Disptpcd)
                    .HasColumnName("disptpcd")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode).HasColumnName("groupCode");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblLotteMdcateGrp>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.Mdcode })
                    .HasName("PK__tbl_lotte_MDCate__63A3C44B");

                entity.ToTable("tbl_lotte_MDCateGrp");

                entity.Property(e => e.GroupCode).HasColumnName("groupCode");

                entity.Property(e => e.Mdcode)
                    .HasColumnName("MDCode")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SuperGroupName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLotteMdinfo>(entity =>
            {
                entity.HasKey(e => e.Mdcode)
                    .HasName("PK__tbl_lotte_MDInfo__5CF6C6BC");

                entity.ToTable("tbl_lotte_MDInfo");

                entity.Property(e => e.Mdcode)
                    .HasColumnName("MDCode")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.EventSellFee)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mdname)
                    .HasColumnName("MDName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NormalSellFee)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SellFeeType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLotteNotInMakeridByKimJinYoung>(entity =>
            {
                entity.HasKey(e => e.Makerid)
                    .HasName("PK_tbl_Lotte_not_in_makerid_By_KimJinYoung_1");

                entity.ToTable("tbl_Lotte_not_in_makerid_By_KimJinYoung");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastupdateId)
                    .HasColumnName("lastupdateId")
                    .HasMaxLength(10);

                entity.Property(e => e.RegId)
                    .IsRequired()
                    .HasColumnName("regId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLotteiMallCategory>(entity =>
            {
                entity.HasKey(e => e.DispNo)
                    .HasName("PK__tbl_lotteiMall_Catego__3D491139");

                entity.ToTable("tbl_lotteiMall_Category");

                entity.Property(e => e.DispNo)
                    .HasMaxLength(38)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DispLrgNm)
                    .HasColumnName("dispLrgNm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DispMidNm)
                    .HasColumnName("dispMidNm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DispNm)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DispSmlNm)
                    .HasColumnName("dispSmlNm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DispThnNm)
                    .HasColumnName("dispThnNm")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Disptpcd)
                    .HasColumnName("disptpcd")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode).HasColumnName("groupCode");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblLotteiMallMdcateGrp>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.Mdcode })
                    .HasName("PK__tbl_lotteiMall_M__6C23FBB3");

                entity.ToTable("tbl_lotteiMall_MDCateGrp");

                entity.Property(e => e.GroupCode).HasColumnName("groupCode");

                entity.Property(e => e.Mdcode)
                    .HasColumnName("MDCode")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SuperGroupName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLotteiMallMdinfo>(entity =>
            {
                entity.HasKey(e => e.Mdcode)
                    .HasName("PK__tbl_lotteiMall_M__666B225D");

                entity.ToTable("tbl_lotteiMall_MDInfo");

                entity.Property(e => e.Mdcode)
                    .HasColumnName("MDCode")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.EventSellFee)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mdname)
                    .HasColumnName("MDName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.NormalSellFee)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SellFeeType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLtiMallCategory>(entity =>
            {
                entity.HasKey(e => e.CateKey);

                entity.ToTable("tbl_LTiMall_Category");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CateGbn)
                    .IsRequired()
                    .HasColumnName("cateGbn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.DCode)
                    .IsRequired()
                    .HasColumnName("D_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DName)
                    .IsRequired()
                    .HasColumnName("D_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LCode)
                    .IsRequired()
                    .HasColumnName("L_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("L_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MCode)
                    .IsRequired()
                    .HasColumnName("M_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MName)
                    .IsRequired()
                    .HasColumnName("M_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCode)
                    .IsRequired()
                    .HasColumnName("S_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("S_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLtiMallCategoryBuf>(entity =>
            {
                entity.HasKey(e => new { e.CateKey, e.CateGbn })
                    .HasName("PK_tbl_lotteiMall_Category_BUF_1");

                entity.ToTable("tbl_LTiMall_Category_BUF");

                entity.Property(e => e.CateKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CateGbn)
                    .HasColumnName("cateGbn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.DCode)
                    .IsRequired()
                    .HasColumnName("D_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DName)
                    .IsRequired()
                    .HasColumnName("D_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LCode)
                    .IsRequired()
                    .HasColumnName("L_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LName)
                    .IsRequired()
                    .HasColumnName("L_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MCode)
                    .IsRequired()
                    .HasColumnName("M_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MName)
                    .IsRequired()
                    .HasColumnName("M_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCode)
                    .IsRequired()
                    .HasColumnName("S_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("S_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLtiMallCsnoti>(entity =>
            {
                entity.HasKey(e => new { e.Mallid, e.OrderNo, e.OrderSeq });

                entity.ToTable("tbl_LTiMall_CSNoti");

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSeq)
                    .HasColumnName("ORDER_SEQ")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CnclAmt)
                    .HasColumnName("CNCL_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.CnclCnt).HasColumnName("CNCL_CNT");

                entity.Property(e => e.CnclDt)
                    .HasColumnName("CNCL_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderDt)
                    .HasColumnName("ORDER_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderStts)
                    .HasColumnName("ORDER_STTS")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('01:취소, 02:반품, 03:교환')");

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblLtiMallOrdNoti>(entity =>
            {
                entity.HasKey(e => new { e.OrderNo, e.OrderSeq });

                entity.ToTable("tbl_LTiMall_OrdNoti");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSeq)
                    .HasColumnName("ORDER_SEQ")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CsMsg)
                    .IsRequired()
                    .HasColumnName("CS_MSG")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Datetime)
                    .HasColumnName("DATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelyCost)
                    .HasColumnName("DELY_COST")
                    .HasColumnType("money");

                entity.Property(e => e.DelyType)
                    .IsRequired()
                    .HasColumnName("DELY_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Documentid)
                    .IsRequired()
                    .HasColumnName("DOCUMENTID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntpDtCode)
                    .IsRequired()
                    .HasColumnName("ENTP_DT_CODE")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasColumnName("GOODS_ID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasColumnName("GOODS_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsdtInfo)
                    .IsRequired()
                    .HasColumnName("GOODSDT_INFO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NotiStatus)
                    .HasColumnName("notiStatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OEmail)
                    .IsRequired()
                    .HasColumnName("O_EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OHtel)
                    .IsRequired()
                    .HasColumnName("O_HTEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OName)
                    .IsRequired()
                    .HasColumnName("O_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OTel)
                    .IsRequired()
                    .HasColumnName("O_TEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDt)
                    .HasColumnName("ORDER_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayDt)
                    .HasColumnName("PAY_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddr)
                    .IsRequired()
                    .HasColumnName("S_ADDR")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SHtel)
                    .IsRequired()
                    .HasColumnName("S_HTEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("S_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPost)
                    .IsRequired()
                    .HasColumnName("S_POST")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.STel)
                    .IsRequired()
                    .HasColumnName("S_TEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalePrice)
                    .HasColumnName("SALE_PRICE")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblLtimallSourceAreaCode>(entity =>
            {
                entity.HasKey(e => new { e.AreaCode, e.DiffKey });

                entity.ToTable("tbl_LTIMall_SourceAreaCode");

                entity.Property(e => e.AreaCode)
                    .HasColumnName("areaCode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DiffKey).HasColumnName("diffKey");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("areaName")
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblMaeliageDate17thFirst>(entity =>
            {
                entity.HasKey(e => e.MaeliageDate);

                entity.ToTable("tbl_maeliageDate17th_First");

                entity.Property(e => e.MaeliageDate)
                    .HasColumnName("maeliageDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMaeliageDate17thSecond>(entity =>
            {
                entity.HasKey(e => e.MaeliageDate);

                entity.ToTable("tbl_maeliageDate17th_Second");

                entity.Property(e => e.MaeliageDate)
                    .HasColumnName("maeliageDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMaeliagePush>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Userid });

                entity.ToTable("tbl_maeliagePush");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblMaeliagePush17th>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Userid });

                entity.ToTable("tbl_maeliagePush17th");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendStatus)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblManito2013>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_manito_2013");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Device)
                    .IsRequired()
                    .HasColumnName("device")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('w')");

                entity.Property(e => e.Etc1)
                    .HasColumnName("etc1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.Icon2image)
                    .IsRequired()
                    .HasColumnName("icon2image")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tagno)
                    .IsRequired()
                    .HasColumnName("tagno")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Useyn)
                    .IsRequired()
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('y')");
            });

            modelBuilder.Entity<TblManito2013Item>(entity =>
            {
                entity.HasKey(e => new { e.Topidx, e.Itemid });

                entity.ToTable("tbl_manito_2013_item");

                entity.Property(e => e.Topidx).HasColumnName("topidx");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblMemoryUsage>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_memory_Usage_1");

                entity.ToTable("tbl_memory_Usage");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CntrValue)
                    .IsRequired()
                    .HasColumnName("cntr_value")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CounterName)
                    .IsRequired()
                    .HasColumnName("counter_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gb).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.Inputdate)
                    .HasColumnName("inputdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMibeasongList>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_mibeasong_list");

                entity.HasIndex(e => e.Detailidx);

                entity.HasIndex(e => e.Itemid);

                entity.HasIndex(e => e.Orderserial);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Detailidx).HasColumnName("detailidx");

                entity.Property(e => e.Finishstr)
                    .HasColumnName("finishstr")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ipgodate)
                    .HasColumnName("ipgodate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsSendApi)
                    .HasColumnName("isSendAPI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsSendCall)
                    .HasColumnName("isSendCall")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsSendEmail)
                    .HasColumnName("isSendEmail")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsSendSms)
                    .HasColumnName("isSendSMS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemlackno).HasColumnName("itemlackno");

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoptionname)
                    .HasColumnName("itemoptionname")
                    .HasMaxLength(96)
                    .IsUnicode(false);

                entity.Property(e => e.LastSendDate)
                    .HasColumnName("lastSendDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastSendUserid)
                    .HasColumnName("lastSendUserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Modidate)
                    .HasColumnName("modidate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Modiuserid)
                    .HasColumnName("modiuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Orderserial)
                    .IsRequired()
                    .HasColumnName("orderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Prevcode)
                    .HasColumnName("prevcode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reguserid)
                    .HasColumnName("reguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Reqaddstr)
                    .HasColumnName("reqaddstr")
                    .HasColumnType("text");

                entity.Property(e => e.Reqreguserid)
                    .HasColumnName("reqreguserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Reqstr)
                    .HasColumnName("reqstr")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SendCount)
                    .HasColumnName("sendCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblMibeasongOrdermaster>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_mibeasong_ordermaster");

                entity.HasIndex(e => e.Orderserial);

                entity.HasIndex(e => new { e.Boxno, e.WorkGroup })
                    .HasName("IX_tbl_mibeasong_ordermaster_WorkGroup_boxno")
                    .IsUnique();

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Boxno).HasColumnName("boxno");

                entity.Property(e => e.Orderserial)
                    .IsRequired()
                    .HasColumnName("orderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkGroup)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Z')");
            });

            modelBuilder.Entity<TblMibeasongOrdermasterCanceled>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_mibeasong_ordermaster_canceled");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Boxno).HasColumnName("boxno");

                entity.Property(e => e.Orderserial)
                    .IsRequired()
                    .HasColumnName("orderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WorkGroup)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Z')");
            });

            modelBuilder.Entity<TblMibeasongOrderserial>(entity =>
            {
                entity.HasKey(e => e.Orderserial);

                entity.ToTable("tbl_mibeasong_orderserial");

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblMibeasongSum>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_mibeasong_SUM");

                entity.HasIndex(e => e.Itemid);

                entity.HasIndex(e => new { e.Itemid, e.Itemoption });

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedNever();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemlackno).HasColumnName("itemlackno");

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoptionname)
                    .HasColumnName("itemoptionname")
                    .HasMaxLength(96)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Orderserial)
                    .IsRequired()
                    .HasColumnName("orderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Realorderserial)
                    .IsRequired()
                    .HasColumnName("realorderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMichulgoMileRecalcuQue>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_michulgoMile_Recalcu_Que");

                entity.Property(e => e.Idx).HasColumnName("idx");

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

            modelBuilder.Entity<TblMileExpireEmailTarget>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymmdd, e.Userid });

                entity.ToTable("tbl_mile_Expire_email_Target");

                entity.Property(e => e.Yyyymmdd)
                    .HasColumnName("yyyymmdd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MayExpireMile).HasColumnType("money");

                entity.Property(e => e.TotalMileage).HasColumnType("money");

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasColumnName("uname")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Usermail)
                    .IsRequired()
                    .HasColumnName("usermail")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMiracleOf10Won>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_MiracleOf10Won");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.AuctionMaxPrice).HasColumnName("auctionMaxPrice");

                entity.Property(e => e.AuctionMinPrice).HasColumnName("auctionMinPrice");

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eviewdate)
                    .HasColumnName("eviewdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ProductBigImg)
                    .IsRequired()
                    .HasColumnName("productBigImg")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("productCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("productName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnName("productPrice");

                entity.Property(e => e.ProductSmallImg)
                    .IsRequired()
                    .HasColumnName("productSmallImg")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Roundnum).HasColumnName("roundnum");

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sviewdate)
                    .HasColumnName("sviewdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WinnerPrice).HasColumnName("winnerPrice");

                entity.Property(e => e.Winneruserid)
                    .HasColumnName("winneruserid")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMiracleOf10WonList>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_MiracleOf10Won_list");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Device)
                    .HasColumnName("device")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EvtCode)
                    .HasColumnName("evt_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kakaochk)
                    .HasColumnName("kakaochk")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lprice)
                    .HasColumnName("lprice")
                    .HasColumnType("money");

                entity.Property(e => e.Prizecode).HasColumnName("prizecode");

                entity.Property(e => e.Prizename)
                    .HasColumnName("prizename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Roundnum).HasColumnName("roundnum");

                entity.Property(e => e.Usercell)
                    .HasColumnName("usercell")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Userlevel).HasColumnName("userlevel");
            });

            modelBuilder.Entity<TblMiracleof10secMaster>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_miracleof10sec_Master");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Miracledate)
                    .HasColumnName("miracledate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Miraclegiftitemid).HasColumnName("miraclegiftitemid");

                entity.Property(e => e.Miracleprice).HasColumnName("miracleprice");

                entity.Property(e => e.Miracleprice2).HasColumnName("miracleprice2");

                entity.Property(e => e.Miracleprice3).HasColumnName("miracleprice3");

                entity.Property(e => e.Miracleprice4).HasColumnName("miracleprice4");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblMiracleof10secProduct>(entity =>
            {
                entity.HasKey(e => new { e.Idx, e.Masteridx });

                entity.ToTable("tbl_miracleof10sec_product");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Masteridx).HasColumnName("masteridx");

                entity.Property(e => e.Itemid1).HasColumnName("itemid1");

                entity.Property(e => e.Itemid2).HasColumnName("itemid2");

                entity.Property(e => e.Itemname1)
                    .IsRequired()
                    .HasColumnName("itemname1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itemname2)
                    .IsRequired()
                    .HasColumnName("itemname2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itemprice1).HasColumnName("itemprice1");

                entity.Property(e => e.Itemprice2).HasColumnName("itemprice2");

                entity.Property(e => e.Orderby).HasColumnName("orderby");
            });

            modelBuilder.Entity<TblMlayerCount>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_mlayer_count");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Gubun)
                    .HasColumnName("gubun")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Movetype)
                    .HasColumnName("movetype")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblMonthlyAccumulatedLogisstockSummaryBuf>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.Itemgubun, e.Itemid, e.Itemoption });

                entity.ToTable("tbl_monthly_accumulated_logisstock_summary_BUF");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
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

                entity.Property(e => e.Availsysstock)
                    .HasColumnName("availsysstock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AvgipgoPrice)
                    .HasColumnName("avgipgoPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Errbaditemno)
                    .HasColumnName("errbaditemno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Errcsno)
                    .HasColumnName("errcsno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Erretcno)
                    .HasColumnName("erretcno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Errrealcheckno)
                    .HasColumnName("errrealcheckno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Etcchulgono)
                    .HasColumnName("etcchulgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Etcrechulgono)
                    .HasColumnName("etcrechulgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ipgono)
                    .HasColumnName("ipgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastbuyPrice)
                    .HasColumnName("lastbuyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Lastmakerid)
                    .HasColumnName("lastmakerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastmwdiv)
                    .HasColumnName("lastmwdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lossno)
                    .HasColumnName("lossno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Offchulgono)
                    .HasColumnName("offchulgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Offrechulgono)
                    .HasColumnName("offrechulgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Offsellno)
                    .HasColumnName("offsellno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Realstock)
                    .HasColumnName("realstock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reipgono)
                    .HasColumnName("reipgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Resellno)
                    .HasColumnName("resellno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellno)
                    .HasColumnName("sellno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetGbn)
                    .HasColumnName("targetGbn")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Totchulgono)
                    .HasColumnName("totchulgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Toterrno)
                    .HasColumnName("toterrno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Totipgono)
                    .HasColumnName("totipgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Totsellno)
                    .HasColumnName("totsellno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Totsysstock)
                    .HasColumnName("totsysstock")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblMonthlyAccumulatedShopstockSummaryBuf>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.Shopid, e.Itemgubun, e.Itemid, e.Itemoption })
                    .HasName("PK_tbl_monthly_saccumulated_hopstock_summary_BUF");

                entity.ToTable("tbl_monthly_accumulated_shopstock_summary_BUF");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasMaxLength(16)
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

                entity.Property(e => e.Brandipgono)
                    .HasColumnName("brandipgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Brandreipgono)
                    .HasColumnName("brandreipgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Errbaditemno)
                    .HasColumnName("errbaditemno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Errrealcheckno)
                    .HasColumnName("errrealcheckno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Errsampleitemno)
                    .HasColumnName("errsampleitemno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Logicsipgono)
                    .HasColumnName("logicsipgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Logicsreipgono)
                    .HasColumnName("logicsreipgono")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LstBuyCash).HasColumnType("money");

                entity.Property(e => e.LstCommCd)
                    .HasColumnName("LstComm_cd")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LstMakerid)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LstSuplycash).HasColumnType("money");

                entity.Property(e => e.Realstockno)
                    .HasColumnName("realstockno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Resellno)
                    .HasColumnName("resellno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sellno)
                    .HasColumnName("sellno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sysstockno)
                    .HasColumnName("sysstockno")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblMonthlyStockIpgoLedgerSumTemp>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.StockPlace, e.Shopid, e.TargetGbn, e.Itemgubun, e.Itemid, e.Itemoption, e.IpgoMwdiv })
                    .HasName("PK_tbl_monthly_Stock_IpgoLedger_Sum");

                entity.ToTable("tbl_monthly_Stock_IpgoLedger_Sum_TEMP");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.StockPlace)
                    .HasColumnName("stockPlace")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TargetGbn)
                    .HasColumnName("targetGbn")
                    .HasMaxLength(2)
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

                entity.Property(e => e.IpgoMwdiv)
                    .HasColumnName("ipgoMWdiv")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IpgoType)
                    .HasColumnName("ipgoType")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMwdiv)
                    .IsRequired()
                    .HasColumnName("itemMWdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemVatInclude)
                    .IsRequired()
                    .HasColumnName("itemVatInclude")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastIpgoBuyCash)
                    .HasColumnName("lastIpgoBuyCash")
                    .HasColumnType("money");

                entity.Property(e => e.LastIpgoCode)
                    .HasColumnName("lastIpgoCode")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Lastmakerid)
                    .HasColumnName("lastmakerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastmwdiv)
                    .HasColumnName("lastmwdiv")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastvatinclude)
                    .HasColumnName("lastvatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotBuyCash)
                    .HasColumnName("totBuyCash")
                    .HasColumnType("money");

                entity.Property(e => e.TotItemNo).HasColumnName("totItemNo");
            });

            modelBuilder.Entity<TblMulti2mileage>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_multi2mileage");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("money");

                entity.Property(e => e.Payid)
                    .HasColumnName("payid")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNateScraplog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_nate_scraplog");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Ref)
                    .HasColumnName("ref")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblNaverItemMap>(entity =>
            {
                entity.HasKey(e => e.Tenitemid)
                    .HasName("PK__tbl_nave__2197F073B70AF15A");

                entity.ToTable("tbl_naver_item_map");

                entity.Property(e => e.Tenitemid)
                    .HasColumnName("tenitemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Matchnvmid).HasColumnName("matchnvmid");

                entity.Property(e => e.Naveritemid).HasColumnName("naveritemid");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Serviceyn)
                    .HasColumnName("serviceyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNoItemInfoForceSoldOut>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_NoItemInfo_Force_soldOut");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Itemsellyn)
                    .IsRequired()
                    .HasColumnName("itemsellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResellDate)
                    .HasColumnName("resellDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SoldoutDate)
                    .HasColumnName("soldoutDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblNvsMinprofit>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__tbl_nvs___56A22C937625FE1A")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("tbl_nvs_minprofit");

                entity.HasIndex(e => e.Pendingyn)
                    .HasName("cx_tbl_nvs_minprofit")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money");

                entity.Property(e => e.Couponamt).HasColumnName("couponamt");

                entity.Property(e => e.Nvsprice)
                    .HasColumnName("nvsprice")
                    .HasColumnType("money");

                entity.Property(e => e.Pendingyn)
                    .IsRequired()
                    .HasColumnName("pendingyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sailyn)
                    .IsRequired()
                    .HasColumnName("sailyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('wait')");

                entity.Property(e => e.Upddate)
                    .HasColumnName("upddate")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblNvsMinprofitLog>(entity =>
            {
                entity.HasKey(e => new { e.Regdate, e.Itemid })
                    .HasName("PK__tbl_nvs___651B3165350D5653");

                entity.ToTable("tbl_nvs_minprofit_log");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money");

                entity.Property(e => e.Couponamt).HasColumnName("couponamt");

                entity.Property(e => e.Nvsprice)
                    .HasColumnName("nvsprice")
                    .HasColumnType("money");

                entity.Property(e => e.Pendingyn)
                    .IsRequired()
                    .HasColumnName("pendingyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Sailyn)
                    .IsRequired()
                    .HasColumnName("sailyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('wait')");
            });

            modelBuilder.Entity<TblOldStock>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.Stockplace, e.Shopid, e.Itemgubun, e.Itemid, e.Itemoption });

                entity.ToTable("tbl_oldStock");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Stockplace)
                    .HasColumnName("stockplace")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasMaxLength(32)
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

                entity.Property(e => e.Barcode)
                    .HasColumnName("barcode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastmakerid)
                    .IsRequired()
                    .HasColumnName("lastmakerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lastmwdiv)
                    .IsRequired()
                    .HasColumnName("lastmwdiv")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lastvatinclude)
                    .IsRequired()
                    .HasColumnName("lastvatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sysstock).HasColumnName("sysstock");

                entity.Property(e => e.Sysstocksum)
                    .HasColumnName("sysstocksum")
                    .HasColumnType("money");

                entity.Property(e => e.SysstocksumNoVat)
                    .HasColumnName("sysstocksumNoVat")
                    .HasColumnType("money");

                entity.Property(e => e.TargetGbn)
                    .IsRequired()
                    .HasColumnName("targetGbn")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOldStock2012real>(entity =>
            {
                entity.HasKey(e => new { e.Shopid, e.Itemgubun, e.Itemid, e.Itemoption })
                    .HasName("PK_tbl_oldStock_2012Real_1");

                entity.ToTable("tbl_oldStock_2012Real");

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasMaxLength(32)
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

                entity.Property(e => e.Realstock).HasColumnName("realstock");
            });

            modelBuilder.Entity<TblOldStock2012realL>(entity =>
            {
                entity.HasKey(e => new { e.Itemgubun, e.Itemid, e.Itemoption });

                entity.ToTable("tbl_oldStock_2012Real_L");

                entity.Property(e => e.Itemgubun)
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lastbuyprice)
                    .HasColumnName("lastbuyprice")
                    .HasColumnType("money");

                entity.Property(e => e.Lastipgodate)
                    .IsRequired()
                    .HasColumnName("lastipgodate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Realstock).HasColumnName("realstock");
            });

            modelBuilder.Entity<TblOldStock2013real>(entity =>
            {
                entity.HasKey(e => new { e.Shopid, e.Itemgubun, e.Itemid, e.Itemoption });

                entity.ToTable("tbl_oldStock_2013Real");

                entity.Property(e => e.Shopid)
                    .HasColumnName("shopid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itemgubun)
                    .HasColumnName("itemgubun")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOnBeasongExcZipcode>(entity =>
            {
                entity.HasKey(e => e.ZipCode);

                entity.ToTable("tbl_onBeasongExcZipcode");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zipCode")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblOnlineAppLogTmp>(entity =>
            {
                entity.HasKey(e => new { e.Pggubun, e.Pgkey, e.Pgcskey });

                entity.ToTable("tbl_onlineApp_log_tmp");

                entity.HasIndex(e => e.Pgkey)
                    .HasName("IDX_tbl_onlineApp_log_tmp_PGkey");

                entity.Property(e => e.Pggubun)
                    .HasColumnName("PGgubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Pgkey)
                    .HasColumnName("PGkey")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Pgcskey)
                    .HasColumnName("PGCSkey")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AppDate)
                    .HasColumnName("appDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AppDivCode)
                    .IsRequired()
                    .HasColumnName("appDivCode")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AppMethod)
                    .IsRequired()
                    .HasColumnName("appMethod")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AppPrice)
                    .HasColumnName("appPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CancelDate)
                    .HasColumnName("cancelDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommPrice)
                    .HasColumnName("commPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CommVatPrice)
                    .HasColumnName("commVatPrice")
                    .HasColumnType("money");

                entity.Property(e => e.EtcPoint)
                    .HasColumnName("etcPoint")
                    .HasColumnType("money");

                entity.Property(e => e.Ipkumdate)
                    .IsRequired()
                    .HasColumnName("ipkumdate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JungsanPrice)
                    .HasColumnName("jungsanPrice")
                    .HasColumnType("money");

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PgmeachulDate)
                    .HasColumnName("PGmeachulDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pguserid)
                    .HasColumnName("PGuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sitename)
                    .IsRequired()
                    .HasColumnName("sitename")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOnlineAppNotMatchReasonCode>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_onlineApp_notMatch_reasonCode");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedNever();

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Pgcskey)
                    .IsRequired()
                    .HasColumnName("PGCSkey")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Pggubun)
                    .IsRequired()
                    .HasColumnName("PGgubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Pgkey)
                    .IsRequired()
                    .HasColumnName("PGkey")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Pguserid)
                    .IsRequired()
                    .HasColumnName("PGuserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonGubun)
                    .HasColumnName("reasonGubun")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblOrderDetailForCancel>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_order_detail");

                entity.ToTable("tbl_order_detail_for_cancel");

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cancelitemno).HasColumnName("cancelitemno");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblOutMallRecentSellData>(entity =>
            {
                entity.HasKey(e => new { e.Sitename, e.Itemid });

                entity.ToTable("tbl_OutMall_recentSellData");

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.SellCnt).HasColumnName("sellCnt");
            });

            modelBuilder.Entity<TblPlusSaleLinkItemListBack>(entity =>
            {
                entity.HasKey(e => new { e.PlusSaleItemId, e.PlusSaleLinkItemId })
                    .HasName("PK_tbl_SetSaleLinkItemList_BACK");

                entity.ToTable("tbl_PlusSaleLinkItemList_BACK");

                entity.Property(e => e.PlusSaleItemId).HasColumnName("plusSaleItemID");

                entity.Property(e => e.PlusSaleLinkItemId).HasColumnName("plusSaleLinkItemID");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblPlusSaleRegedItemBack>(entity =>
            {
                entity.HasKey(e => e.PlusSaleItemId)
                    .HasName("PK_tbl_SetSaleRegedItem_BACK");

                entity.ToTable("tbl_PlusSaleRegedItem_BACK");

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
                    .IsUnicode(false);

                entity.Property(e => e.PlusSaleMargin).HasColumnName("plusSaleMargin");

                entity.Property(e => e.PlusSalePro).HasColumnName("plusSalePro");

                entity.Property(e => e.PlusSaleStartDate)
                    .HasColumnName("plusSaleStartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblRedRibbonBrand>(entity =>
            {
                entity.HasKey(e => new { e.BrdSn, e.RedSn })
                    .HasName("PK__tbl_redRibbon_br__5165187F");

                entity.ToTable("tbl_redRibbon_brand");

                entity.Property(e => e.BrdSn)
                    .HasColumnName("brdSn")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RedSn).HasColumnName("redSn");

                entity.Property(e => e.DesignerId)
                    .IsRequired()
                    .HasColumnName("designerId")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRedRibbonItem>(entity =>
            {
                entity.HasKey(e => e.RedSn)
                    .HasName("PK__redRibbon_item__019E3B86");

                entity.ToTable("tbl_redRibbon_item");

                entity.Property(e => e.RedSn).HasColumnName("redSn");

                entity.Property(e => e.AddImage1)
                    .HasColumnName("addImage1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.AddImage2)
                    .HasColumnName("addImage2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.AddImage3)
                    .HasColumnName("addImage3")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage1)
                    .HasColumnName("basicImage1")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage2)
                    .HasColumnName("basicImage2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.BasicImage3)
                    .HasColumnName("basicImage3")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ItemContent)
                    .HasColumnName("itemContent")
                    .HasColumnType("text");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("itemName")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ItemQuant)
                    .HasColumnName("itemQuant")
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRedRibbonLog>(entity =>
            {
                entity.HasKey(e => e.LogSn)
                    .HasName("PK__tbl_redRibbon_lo__534D60F1");

                entity.ToTable("tbl_redRibbon_log");

                entity.HasIndex(e => e.Userid)
                    .HasName("IX_tbl_redRibbon_log");

                entity.HasIndex(e => e.WinYn);

                entity.Property(e => e.LogSn)
                    .HasColumnName("logSn")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RedItemid)
                    .IsRequired()
                    .HasColumnName("redItemid")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WinYn)
                    .IsRequired()
                    .HasColumnName("winYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblRedRibbonRelateItem>(entity =>
            {
                entity.HasKey(e => new { e.RedSn, e.Itemid })
                    .HasName("PK__tbl_redRibbon_Re__5441852A");

                entity.ToTable("tbl_redRibbon_RelateItem");

                entity.Property(e => e.RedSn).HasColumnName("redSn");

                entity.Property(e => e.Itemid).HasColumnName("itemid");
            });

            modelBuilder.Entity<TblRedRibbonWinner>(entity =>
            {
                entity.HasKey(e => new { e.RedItemid, e.RedSn })
                    .HasName("PK__redRibbon_winner__0662F0A3");

                entity.ToTable("tbl_redRibbon_winner");

                entity.HasIndex(e => e.WinUserid)
                    .HasName("IX_tbl_redRibbon_winner");

                entity.Property(e => e.RedItemid)
                    .HasColumnName("redItemid")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RedSn).HasColumnName("redSn");

                entity.Property(e => e.ItemSortNo).HasDefaultValueSql("(0)");

                entity.Property(e => e.WinDate)
                    .HasColumnName("winDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WinUserid)
                    .HasColumnName("winUserid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRejectMailTUniq>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("tbl_rejectMail_T_UNIQ");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstAct)
                    .IsRequired()
                    .HasColumnName("firstACT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IisOrDb)
                    .HasColumnName("iisOrDB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Lastact)
                    .IsRequired()
                    .HasColumnName("LASTACT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RjCnt).HasColumnName("rjCnt");
            });

            modelBuilder.Entity<TblRelaymileInfo>(entity =>
            {
                entity.HasKey(e => new { e.Yyyymm, e.Userid })
                    .HasName("PK__tbl_rela__0185BEE851B64078");

                entity.ToTable("tbl_relaymile_info");

                entity.Property(e => e.Yyyymm)
                    .HasColumnName("yyyymm")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CompleteDate)
                    .HasColumnName("completeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnName("dueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsComplete)
                    .IsRequired()
                    .HasColumnName("isComplete")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsPay)
                    .IsRequired()
                    .HasColumnName("isPay")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsUsing)
                    .IsRequired()
                    .HasColumnName("isUsing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderTotal)
                    .HasColumnName("orderTotal")
                    .HasColumnType("money");

                entity.Property(e => e.PayDate)
                    .HasColumnName("payDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RelayCount).HasColumnName("relayCount");

                entity.Property(e => e.Relaymileidx)
                    .HasColumnName("relaymileidx")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblSabannetCs>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_Sabannet_CS");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CsdetailKey)
                    .HasColumnName("CSDetailKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Currstate)
                    .HasColumnName("currstate")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Deleteyn)
                    .HasColumnName("deleteyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Divcd)
                    .HasColumnName("divcd")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FinUserId)
                    .HasColumnName("finUserId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Gubunname)
                    .HasColumnName("gubunname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSerial)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDetailKey)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallItemName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallItemOptionName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallOrderSerial)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallRegDate).HasColumnType("datetime");

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SellSite)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSabannetDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_Sabannet_Detail");

                entity.HasIndex(e => e.OrderId);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Cnts)
                    .HasColumnName("CNTS")
                    .HasMaxLength(4000);

                entity.Property(e => e.CompaynyGoodsCd)
                    .HasColumnName("COMPAYNY_GOODS_CD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CsGubun)
                    .HasColumnName("CS_GUBUN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CsStatus)
                    .HasColumnName("CS_STATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsDm)
                    .HasColumnName("INS_DM")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsNm)
                    .HasColumnName("INS_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.MallId)
                    .HasColumnName("MALL_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MallProdId)
                    .HasColumnName("MALL_PROD_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MallUserId)
                    .HasColumnName("MALL_USER_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNm)
                    .HasColumnName("ProductNM")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RegDm)
                    .HasColumnName("REG_DM")
                    .HasColumnType("datetime");

                entity.Property(e => e.RplyCnts)
                    .HasColumnName("RPLY_CNTS")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SabanetNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SellSite)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SendDm)
                    .HasColumnName("SEND_DM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(2000);

                entity.Property(e => e.TenStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDm)
                    .HasColumnName("UPD_DM")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdNm)
                    .HasColumnName("UPD_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSabannetLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tblSabannet_log");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Getcontents)
                    .HasColumnName("getcontents")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Getcount).HasColumnName("getcount");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSafetycertImageTemp>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_safetycert_image_temp");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CertNum)
                    .HasColumnName("certNum")
                    .HasMaxLength(50);

                entity.Property(e => e.ImageUrls).HasMaxLength(150);

                entity.Property(e => e.Topidx).HasColumnName("topidx");
            });

            modelBuilder.Entity<TblSafetycertImageWaititem>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_safetycert_image_waititem");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CertNum)
                    .HasColumnName("certNum")
                    .HasMaxLength(50);

                entity.Property(e => e.ImageUrls).HasMaxLength(150);

                entity.Property(e => e.Itemid).HasColumnName("itemid");
            });

            modelBuilder.Entity<TblSafetycertInboundTemp>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_safetycert_inbound_temp");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CertNum)
                    .HasColumnName("certNum")
                    .HasMaxLength(50);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SafetyDiv)
                    .HasColumnName("safetyDiv")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSafetycertInfoTemp>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_satefycert_info_temp");

                entity.ToTable("tbl_safetycert_info_temp");

                entity.HasIndex(e => e.CertNum)
                    .HasName("IX_certNum");

                entity.Property(e => e.Idx).HasColumnName("idx");

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

            modelBuilder.Entity<TblSafetycertInfoWaititem>(entity =>
            {
                entity.HasKey(e => e.Waitinfoidx)
                    .HasName("PK_tbl_satefycert_info_waititem");

                entity.ToTable("tbl_safetycert_info_waititem");

                entity.HasIndex(e => e.CertNum)
                    .HasName("IX_certNum");

                entity.HasIndex(e => e.Itemid)
                    .HasName("IX_itemid");

                entity.Property(e => e.Waitinfoidx).HasColumnName("waitinfoidx");

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

            modelBuilder.Entity<TblSafetycertTenRegWaititem>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.SafetyDiv })
                    .HasName("PK_tbl_safetycert_tenReg_waititem_1");

                entity.ToTable("tbl_safetycert_tenReg_waititem");

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

            modelBuilder.Entity<TblSagawaDeliverArea>(entity =>
            {
                entity.HasKey(e => e.ZipNo);

                entity.ToTable("tbl_sagawa_deliver_area");

                entity.Property(e => e.ZipNo)
                    .HasColumnName("ZIP_NO")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TrBranNm)
                    .HasColumnName("TR_BRAN_NM")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblScheduleNotInItemid>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Mallgubun })
                    .HasName("PK__tbl_schedule_n__72E607DB");

                entity.ToTable("tbl_schedule_not_in_itemid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

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

            modelBuilder.Entity<TblSearchKey>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_search_key");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblShopjumunCardAppLogTmp>(entity =>
            {
                entity.HasKey(e => new { e.Pggubun, e.Pgkey });

                entity.ToTable("tbl_shopjumun_cardApp_log_tmp");

                entity.HasIndex(e => new { e.Pgkey, e.AppDivCode })
                    .HasName("IDX_tbl_shopjumun_cardApp_log_tmp_PGgubun_PGkey")
                    .IsUnique();

                entity.HasIndex(e => new { e.CardAppNo, e.CardComp, e.CardAffiliateNo })
                    .HasName("IX_tbl_shopjumun_cardApp_log_tmp_cardComp");

                entity.Property(e => e.Pggubun)
                    .HasColumnName("PGgubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Pgkey)
                    .HasColumnName("PGkey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AppDate)
                    .HasColumnName("appDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AppDivCode)
                    .IsRequired()
                    .HasColumnName("appDivCode")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CardAffiliateNo)
                    .IsRequired()
                    .HasColumnName("cardAffiliateNo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CardAppNo)
                    .IsRequired()
                    .HasColumnName("cardAppNo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CardComp)
                    .IsRequired()
                    .HasColumnName("cardComp")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CardGubun)
                    .IsRequired()
                    .HasColumnName("cardGubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CardPrice)
                    .HasColumnName("cardPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CardReaderId)
                    .IsRequired()
                    .HasColumnName("cardReaderID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Ipkumdate)
                    .IsRequired()
                    .HasColumnName("ipkumdate")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShopjumunOrdertemp>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_tbl_shopjumun_manual");

                entity.ToTable("tbl_shopjumun_ordertemp");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasColumnName("barcode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Failtype)
                    .HasColumnName("failtype")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Itemgubun)
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ordertempstatus)
                    .HasColumnName("ordertempstatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Regadminid)
                    .IsRequired()
                    .HasColumnName("regadminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sellprice)
                    .HasColumnName("sellprice")
                    .HasColumnType("money");

                entity.Property(e => e.Shopid)
                    .IsRequired()
                    .HasColumnName("shopid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Shopjumundetailidx).HasColumnName("shopjumundetailidx");

                entity.Property(e => e.Yyyymmdd)
                    .IsRequired()
                    .HasColumnName("yyyymmdd")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblShoplinkerNotInItemid>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Mallgubun });

                entity.ToTable("tbl_shoplinker_not_in_itemid");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastuserid)
                    .HasColumnName("lastuserid")
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
            });

            modelBuilder.Entity<TblShoplinkerNotInMakerid>(entity =>
            {
                entity.HasKey(e => new { e.Makerid, e.Mallgubun });

                entity.ToTable("tbl_shoplinker_not_in_makerid");

                entity.Property(e => e.Makerid)
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mallgubun)
                    .HasColumnName("mallgubun")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idx)
                    .HasColumnName("idx")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastuserid)
                    .HasColumnName("lastuserid")
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
            });

            modelBuilder.Entity<TblSnslayerClicklog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_Snslayer_clicklog");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rdsite)
                    .HasColumnName("rdsite")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTbUser>(entity =>
            {
                entity.HasKey(e => e.Num)
                    .HasName("PK__tbl_TB_U__C7D1B76B18CF8CB7");

                entity.ToTable("tbl_TB_USER");

                entity.Property(e => e.Num).HasColumnName("NUM");

                entity.Property(e => e.Age)
                    .HasColumnName("AGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTemp2017orderUserPrice>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__tbl_temp__CBA1B257FF152FA5");

                entity.ToTable("tbl_temp_2017OrderUserPrice");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("totalPrice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblTempCheckLog>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_temp_check_log");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.RefIp)
                    .IsRequired()
                    .HasColumnName("refIP")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Val)
                    .IsRequired()
                    .HasColumnName("val")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblTempEventAddr>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_temp_event_addr");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Addr1)
                    .HasColumnName("addr1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Addr2)
                    .HasColumnName("addr2")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Device)
                    .HasColumnName("device")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Etc1).HasColumnName("etc1");

                entity.Property(e => e.Etc2)
                    .HasColumnName("etc2")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.Usercell)
                    .HasColumnName("usercell")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTempItemLarge>(entity =>
            {
                entity.HasKey(e => e.CodeLarge);

                entity.ToTable("tbl_temp_item_large");

                entity.Property(e => e.CodeLarge)
                    .HasColumnName("code_large")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodeNm)
                    .IsRequired()
                    .HasColumnName("code_nm")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTempItemMid>(entity =>
            {
                entity.HasKey(e => new { e.CodeLarge, e.CodeMid });

                entity.ToTable("tbl_temp_item_mid");

                entity.Property(e => e.CodeLarge)
                    .HasColumnName("code_large")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMid)
                    .HasColumnName("code_mid")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeNm)
                    .IsRequired()
                    .HasColumnName("code_nm")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTempItemSmall>(entity =>
            {
                entity.HasKey(e => new { e.CodeLarge, e.CodeMid, e.CodeSmall });

                entity.ToTable("tbl_temp_item_small");

                entity.Property(e => e.CodeLarge)
                    .HasColumnName("code_large")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeMid)
                    .HasColumnName("code_mid")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeSmall)
                    .HasColumnName("code_small")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodeNm)
                    .IsRequired()
                    .HasColumnName("code_nm")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTempItemcategory>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_temp_itemcategory");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cdlarge)
                    .IsRequired()
                    .HasColumnName("cdlarge")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cdmid)
                    .IsRequired()
                    .HasColumnName("cdmid")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cdsmall)
                    .IsRequired()
                    .HasColumnName("cdsmall")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTempPushtarget405>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("tbl_temp_pushtarget_405");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrLevel).HasColumnName("currLevel");

                entity.Property(e => e.FingerBuySum).HasColumnType("money");

                entity.Property(e => e.PlusFingerBuyCount).HasColumnName("plusFingerBuyCount");

                entity.Property(e => e.PlusTenBuyCount).HasColumnName("plusTenBuyCount");

                entity.Property(e => e.TargetIdx).HasColumnName("targetIDX");

                entity.Property(e => e.TenBuySum).HasColumnType("money");
            });

            modelBuilder.Entity<TblTempSecreteventUserid>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_temp_secretevent_userid");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gubun).HasColumnName("gubun");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTempSysEvtcount>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_temp_sys_evtcount");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Evtname)
                    .IsRequired()
                    .HasColumnName("evtname")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblTestdevAttribeAlvArray>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_testdev_AttribeAlvArray");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttrValArr)
                    .IsRequired()
                    .HasColumnName("attrValArr");
            });

            modelBuilder.Entity<TblTmpCategoryBestChoice>(entity =>
            {
                entity.HasKey(e => new { e.CateLarge, e.CateMid, e.CateSmall, e.Itemid });

                entity.ToTable("tbl_Tmp_category_BestChoice");

                entity.Property(e => e.CateLarge)
                    .HasColumnName("cate_large")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CateMid)
                    .HasColumnName("cate_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CateSmall)
                    .HasColumnName("cate_small")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemscore)
                    .HasColumnName("itemscore")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblTmpGsOrder>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_tmp_gsOrder");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Refip)
                    .HasColumnName("refip")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.XmlData)
                    .HasColumnName("xmlData")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblTmpMileSum>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.MType });

                entity.ToTable("tbl_TMP_mileSum");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MType)
                    .HasColumnName("mType")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Umileage).HasColumnType("money");
            });

            modelBuilder.Entity<TblToastpopupItemid>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_toastpopup_itemid");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Gubun)
                    .IsRequired()
                    .HasColumnName("gubun")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");
            });

            modelBuilder.Entity<TblTodoTest>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_todo_test");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnName("contents")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTodoTozzinet>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_todo_tozzinet");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Contents).HasColumnName("contents");

                entity.Property(e => e.Isusing)
                    .IsRequired()
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(256);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<TblUpcheItemedit>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_upche_itemedit");

                entity.HasIndex(e => e.Itemid)
                    .HasName("IX_tbl_upche_itemedit__itemid");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money");

                entity.Property(e => e.Dispyn)
                    .HasColumnName("dispyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Edittype)
                    .HasColumnName("edittype")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Etcstr)
                    .HasColumnName("etcstr")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FinishId)
                    .HasColumnName("finishID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Finishdate)
                    .HasColumnName("finishdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsCancel)
                    .IsRequired()
                    .HasColumnName("isCancel")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Isfinish)
                    .HasColumnName("isfinish")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Isupchebeasong)
                    .HasColumnName("isupchebeasong")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoptionname)
                    .HasColumnName("itemoptionname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Limitno)
                    .HasColumnName("limitno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Limitsold)
                    .HasColumnName("limitsold")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Limityn)
                    .HasColumnName("limityn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Oldbuycash)
                    .HasColumnName("oldbuycash")
                    .HasColumnType("money");

                entity.Property(e => e.Olddispyn)
                    .HasColumnName("olddispyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Olditemname)
                    .HasColumnName("olditemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Oldlimitno)
                    .HasColumnName("oldlimitno")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Oldlimitsold)
                    .HasColumnName("oldlimitsold")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Oldlimityn)
                    .HasColumnName("oldlimityn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Oldsellcash)
                    .HasColumnName("oldsellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Oldsellyn)
                    .HasColumnName("oldsellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rejectstr)
                    .HasColumnName("rejectstr")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .HasColumnName("sellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");
            });

            modelBuilder.Entity<TblUserRelateInfo>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__tbl_UserRelate_I__473C8FC7");

                entity.ToTable("tbl_UserRelate_Info");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BuySum).HasColumnType("money");
            });

            modelBuilder.Entity<TblUserRelateList>(entity =>
            {
                entity.HasKey(e => e.Sn)
                    .HasName("PK__tbl_UserRelate_L__558AAF1E");

                entity.ToTable("tbl_UserRelate_List");

                entity.Property(e => e.Sn).HasColumnName("sn");

                entity.Property(e => e.LinkDesc)
                    .HasColumnName("linkDesc")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUser)
                    .IsRequired()
                    .HasColumnName("linkUser")
                    .HasMaxLength(32)
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

            modelBuilder.Entity<TblUserVvip>(entity =>
            {
                entity.HasKey(e => new { e.Vvol, e.Userid });

                entity.ToTable("tbl_user_VVip");

                entity.Property(e => e.Vvol)
                    .HasColumnName("VVol")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SubmitDate).HasColumnType("datetime");

                entity.Property(e => e.Userlevel).HasColumnName("userlevel");
            });

            modelBuilder.Entity<TblUserinfoUpdateTmp>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_userinfo_update_tmp");

                entity.Property(e => e.Idx).HasColumnName("idx");

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

                entity.Property(e => e.Sitegubun)
                    .IsRequired()
                    .HasColumnName("sitegubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserlevelMakeTmp>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.GbnCd });

                entity.ToTable("tbl_userlevelMake_Tmp");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.GbnCd)
                    .HasColumnName("gbnCD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MinusBuyCount).HasColumnName("minusBuyCount");

                entity.Property(e => e.PlusBuyCount).HasColumnName("plusBuyCount");
            });

            modelBuilder.Entity<TblVcharTest>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_vchar_TEST");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Ival)
                    .IsRequired()
                    .HasColumnName("ival")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWaitItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_wait_item");

                entity.HasIndex(e => e.Makerid);

                entity.HasIndex(e => e.Upchemanagecode);

                entity.HasIndex(e => new { e.Itemid, e.Currstate })
                    .HasName("IX_tbl_wait_item_currstate");

                entity.HasIndex(e => new { e.Makerid, e.Itemid, e.Itemname, e.Currstate })
                    .HasName("IX_tbl_wait_item_SearchByupche");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Addbox)
                    .HasColumnName("addbox")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Addcarve)
                    .HasColumnName("addcarve")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Addcustom)
                    .HasColumnName("addcustom")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Addimage)
                    .HasColumnName("addimage")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Addmsg)
                    .HasColumnName("addmsg")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Addset)
                    .HasColumnName("addset")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Basicimage)
                    .HasColumnName("basicimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money");

                entity.Property(e => e.CateLarge)
                    .HasColumnName("cate_large")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CateMid)
                    .HasColumnName("cate_mid")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CateSmall)
                    .HasColumnName("cate_small")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Currstate)
                    .HasColumnName("currstate")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverOverseas)
                    .HasColumnName("deliverOverseas")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Deliverarea)
                    .HasColumnName("deliverarea")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Deliverfixday)
                    .HasColumnName("deliverfixday")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Deliverytype)
                    .IsRequired()
                    .HasColumnName("deliverytype")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Designercomment)
                    .HasColumnName("designercomment")
                    .HasColumnType("text");

                entity.Property(e => e.Discountrate)
                    .HasColumnName("discountrate")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Favcount)
                    .HasColumnName("favcount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FreightMax)
                    .HasColumnName("freight_max")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FreightMin)
                    .HasColumnName("freight_min")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Icon1image)
                    .HasColumnName("icon1image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2image)
                    .HasColumnName("icon2image")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imagecontent)
                    .HasColumnName("imagecontent")
                    .HasColumnType("text");

                entity.Property(e => e.InfoDiv)
                    .HasColumnName("infoDiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Infoimage)
                    .HasColumnName("infoimage")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Isextusing)
                    .HasColumnName("isextusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Istenusing)
                    .HasColumnName("istenusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Isutotypeusing)
                    .HasColumnName("isutotypeusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ItemWeight).HasColumnName("itemWeight");

                entity.Property(e => e.Itemcontent)
                    .HasColumnName("itemcontent")
                    .HasColumnType("text");

                entity.Property(e => e.Itemdiv)
                    .IsRequired()
                    .HasColumnName("itemdiv")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemgubun)
                    .HasColumnName("itemgubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ItemserialLarge)
                    .HasColumnName("itemserial_large")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ItemserialMid)
                    .HasColumnName("itemserial_mid")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ItemserialSmall)
                    .HasColumnName("itemserial_small")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Itemsize)
                    .HasColumnName("itemsize")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemsource)
                    .HasColumnName("itemsource")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Itemstyle)
                    .HasColumnName("itemstyle")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasColumnName("keywords")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Limitdiv)
                    .HasColumnName("limitdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Limitend)
                    .HasColumnName("limitend")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Limitno).HasColumnName("limitno");

                entity.Property(e => e.Limitsold).HasColumnName("limitsold");

                entity.Property(e => e.Limitstart)
                    .HasColumnName("limitstart")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Limityn)
                    .IsRequired()
                    .HasColumnName("limityn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Linkitemid).HasColumnName("linkitemid");

                entity.Property(e => e.Listimage)
                    .HasColumnName("listimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mainimage)
                    .HasColumnName("mainimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mainimage2)
                    .HasColumnName("mainimage2")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Makerid)
                    .IsRequired()
                    .HasColumnName("makerid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Makername)
                    .HasColumnName("makername")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Mileage)
                    .HasColumnName("mileage")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Mwdiv)
                    .HasColumnName("mwdiv")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Optioncnt)
                    .HasColumnName("optioncnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderMaxNum)
                    .HasColumnName("orderMaxNum")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.OrderMinNum)
                    .HasColumnName("orderMinNum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ordercomment)
                    .HasColumnName("ordercomment")
                    .HasColumnType("text");

                entity.Property(e => e.Oregdate)
                    .HasColumnName("oregdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pojangok)
                    .HasColumnName("pojangok")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ReRegDate)
                    .HasColumnName("reRegDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReRegMsg)
                    .HasColumnName("reRegMsg")
                    .HasColumnType("text");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RejectDate)
                    .HasColumnName("rejectDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RejectMsg)
                    .HasColumnName("rejectMsg")
                    .HasColumnType("text");

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
                    .HasDefaultValueSql("('N')");

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
                    .IsUnicode(false);

                entity.Property(e => e.Smallimage)
                    .HasColumnName("smallimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Sourcearea)
                    .HasColumnName("sourcearea")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Sourcekind).HasColumnName("sourcekind");

                entity.Property(e => e.Storyimage)
                    .HasColumnName("storyimage")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stylegubun)
                    .HasColumnName("stylegubun")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TenOnlyYn)
                    .HasColumnName("tenOnlyYn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Titleimage)
                    .HasColumnName("titleimage")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Upchemanagecode)
                    .HasColumnName("upchemanagecode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Usinghtml)
                    .HasColumnName("usinghtml")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Vatinclude)
                    .HasColumnName("vatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblWaitItemColorOption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.ColorCode })
                    .HasName("PK__tbl_wait_item_co__60FC61CA");

                entity.ToTable("tbl_wait_item_colorOption");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.ColorCode).HasColumnName("colorCode");

                entity.Property(e => e.BasicImage)
                    .HasColumnName("basicImage")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0000')");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblWaitItemImage>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("tbl_wait_item_image");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Icon1)
                    .HasColumnName("icon1")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Icon2)
                    .HasColumnName("icon2")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgadd)
                    .HasColumnName("imgadd")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Imgbasic)
                    .HasColumnName("imgbasic")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imglist)
                    .HasColumnName("imglist")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain)
                    .HasColumnName("imgmain")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain10)
                    .HasColumnName("imgmain10")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain2)
                    .HasColumnName("imgmain2")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain3)
                    .HasColumnName("imgmain3")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain4)
                    .HasColumnName("imgmain4")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain5)
                    .HasColumnName("imgmain5")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain6)
                    .HasColumnName("imgmain6")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain7)
                    .HasColumnName("imgmain7")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain8)
                    .HasColumnName("imgmain8")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmain9)
                    .HasColumnName("imgmain9")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgmask)
                    .HasColumnName("imgmask")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgsmall)
                    .HasColumnName("imgsmall")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Imgstory)
                    .HasColumnName("imgstory")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Imgtitle)
                    .HasColumnName("imgtitle")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Itemaddcontent)
                    .HasColumnName("itemaddcontent")
                    .HasColumnType("text");

                entity.Property(e => e.Listimage120)
                    .HasColumnName("listimage120")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg)
                    .HasColumnName("mobileimg")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg10)
                    .HasColumnName("mobileimg10")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg11)
                    .HasColumnName("mobileimg11")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg12)
                    .HasColumnName("mobileimg12")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg2)
                    .HasColumnName("mobileimg2")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg3)
                    .HasColumnName("mobileimg3")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg4)
                    .HasColumnName("mobileimg4")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg5)
                    .HasColumnName("mobileimg5")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg6)
                    .HasColumnName("mobileimg6")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg7)
                    .HasColumnName("mobileimg7")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg8)
                    .HasColumnName("mobileimg8")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Mobileimg9)
                    .HasColumnName("mobileimg9")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Oregdate)
                    .HasColumnName("oregdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblWaitItemInfoCont>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.InfoCd })
                    .HasName("PK__tbl_wait_item_in__113584D1");

                entity.ToTable("tbl_wait_item_infoCont");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.InfoCd)
                    .HasColumnName("infoCd")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChkDiv)
                    .IsRequired()
                    .HasColumnName("chkDiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.InfoContent)
                    .HasColumnName("infoContent")
                    .HasMaxLength(6000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWaitItemLog>(entity =>
            {
                entity.HasKey(e => e.LogIdx);

                entity.ToTable("tbl_wait_item_log");

                entity.HasIndex(e => e.Itemid)
                    .HasName("IX_tbl_wait_item_log");

                entity.Property(e => e.LogIdx).HasColumnName("logIdx");

                entity.Property(e => e.Adminid)
                    .IsRequired()
                    .HasColumnName("adminid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Currstate)
                    .IsRequired()
                    .HasColumnName("currstate")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Logmsg)
                    .HasColumnName("logmsg")
                    .HasColumnType("text");

                entity.Property(e => e.Logmsgcd)
                    .HasColumnName("logmsgcd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblWaitItemOptionMultiple>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.TypeSeq, e.KindSeq });

                entity.ToTable("tbl_wait_item_option_Multiple");

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

            modelBuilder.Entity<TblWaitItemoption>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption });

                entity.ToTable("tbl_wait_itemoption");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Isusing)
                    .HasColumnName("isusing")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.OptaddBuyPrice)
                    .HasColumnName("optaddBuyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OptaddPrice)
                    .HasColumnName("optaddPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OptionTypeName)
                    .HasColumnName("optionTypeName")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Optionimage)
                    .HasColumnName("optionimage")
                    .HasMaxLength(24)
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
                    .HasColumnName("optlimityn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Optsellyn)
                    .HasColumnName("optsellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblWeekwork>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("XPKtbl_weekwork");

                entity.ToTable("tbl_weekwork");

                entity.HasIndex(e => e.Userid);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Gubun)
                    .HasColumnName("gubun")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Lastweek)
                    .HasColumnName("lastweek")
                    .HasColumnType("text");

                entity.Property(e => e.RewriteDate)
                    .HasColumnName("rewrite_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Thisweek)
                    .HasColumnName("thisweek")
                    .HasColumnType("text");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WeekMonth).HasColumnName("week_month");

                entity.Property(e => e.WeekNum).HasColumnName("week_num");

                entity.Property(e => e.WriteDate)
                    .HasColumnName("write_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblWishEventUserfolder>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_wish_event_userfolder");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.Fidx).HasColumnName("fidx");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Viewcnt).HasColumnName("viewcnt");
            });

            modelBuilder.Entity<TblWishlistEvent>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Itemid, e.Fidx });

                entity.ToTable("tbl_wishlist_event");

                entity.HasIndex(e => e.EvtCode)
                    .HasName("IX_tbl_wishlist_event_evtcode");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Fidx).HasColumnName("fidx");

                entity.Property(e => e.CateLarge)
                    .HasColumnName("cate_large")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Curritemcouponidx).HasColumnName("curritemcouponidx");

                entity.Property(e => e.EvtCode).HasColumnName("evt_code");

                entity.Property(e => e.Itemcoupontype)
                    .HasColumnName("itemcoupontype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.Itemcouponyn)
                    .HasColumnName("itemcouponyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Orgprice)
                    .HasColumnName("orgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasColumnName("sellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblXSiteCsDetail>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_xSite_CS_detail");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemOrderCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Masteridx).HasColumnName("masteridx");

                entity.Property(e => e.OutMallItemId)
                    .HasColumnName("OutMallItemID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallItemName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallItemOption)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallItemOptionName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.RealSellPrice).HasColumnType("money");

                entity.Property(e => e.SellPrice).HasColumnType("money");

                entity.Property(e => e.Vatinclude)
                    .HasColumnName("vatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblXSiteCsMaster>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK__tbl_xSite_CS_master__668030F6");

                entity.ToTable("tbl_xSite_CS_master");

                entity.HasIndex(e => new { e.SellSite, e.OutMallOrderSerial, e.OutMallCsserial })
                    .HasName("IDX_tbl_xSite_CS_master_SellSite_OutMallOrgOrderSerial_OutMallCSSerial")
                    .IsUnique();

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.Deliverymemo)
                    .HasColumnName("deliverymemo")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Divcd)
                    .HasColumnName("divcd")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSerial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallCsserial)
                    .IsRequired()
                    .HasColumnName("OutMallCSSerial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallOrderSerial)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallRegDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveAddr1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveAddr2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveZipCode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SellSite)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblXSiteEtcItemLink>(entity =>
            {
                entity.HasKey(e => new { e.Itemid, e.Itemoption, e.MallId })
                    .HasName("PK_tbl_xSite_EtcItemLink_1");

                entity.ToTable("tbl_xSite_EtcItemLink");

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MallId)
                    .HasColumnName("mallID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutmallPrice)
                    .HasColumnName("outmallPrice")
                    .HasColumnType("money");

                entity.Property(e => e.OutmallSellYn)
                    .HasColumnName("outmallSellYn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OutmallitemOptionname)
                    .HasColumnName("outmallitemOptionname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Outmallitemid)
                    .HasColumnName("outmallitemid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Outmallitemname)
                    .HasColumnName("outmallitemname")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblXSiteJungsanData>(entity =>
            {
                entity.HasKey(e => new { e.Sellsite, e.OrdNo, e.OrdSeq, e.ClmSeq, e.SetlDt });

                entity.ToTable("tbl_xSite_JungsanData");

                entity.HasIndex(e => e.Orderserial);

                entity.HasIndex(e => e.SetlDt);

                entity.Property(e => e.Sellsite)
                    .HasColumnName("sellsite")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrdNo)
                    .HasColumnName("ORD_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrdSeq)
                    .HasColumnName("ORD_SEQ")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClmSeq).HasColumnName("CLM_SEQ");

                entity.Property(e => e.SetlDt)
                    .HasColumnName("SETL_DT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClmNo)
                    .HasColumnName("CLM_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompAmt)
                    .HasColumnName("COMP_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.DcCouponAmt)
                    .HasColumnName("DC_COUPON_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.DelAmt)
                    .HasColumnName("DEL_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.Dtlidx).HasColumnName("dtlidx");

                entity.Property(e => e.EntrDcCouponAmt)
                    .HasColumnName("ENTR_DC_COUPON_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.EntrPrdNo)
                    .HasColumnName("ENTR_PRD_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpnAmt)
                    .HasColumnName("EXPN_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.IpointPayAmt)
                    .HasColumnName("IPOINT_PAY_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.IpointSaveAmt)
                    .HasColumnName("IPOINT_SAVE_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.OldSaleUnitcost)
                    .HasColumnName("OLD_SALE_UNITCOST")
                    .HasColumnType("money");

                entity.Property(e => e.OnInterestFee)
                    .HasColumnName("ON_INTEREST_FEE")
                    .HasColumnType("money");

                entity.Property(e => e.OptNo)
                    .HasColumnName("OPT_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OptPrdNo)
                    .HasColumnName("OPT_PRD_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrdAmt)
                    .HasColumnName("ORD_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.OrdNm)
                    .HasColumnName("ORD_NM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdQty).HasColumnName("ORD_QTY");

                entity.Property(e => e.OrderDt)
                    .HasColumnName("ORDER_DT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Orderserial)
                    .HasColumnName("orderserial")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PrdNo)
                    .HasColumnName("PRD_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreUseAmt)
                    .HasColumnName("PRE_USE_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.PreUseUnitcost)
                    .HasColumnName("PRE_USE_UNITCOST")
                    .HasColumnType("money");

                entity.Property(e => e.SaleFee)
                    .HasColumnName("SALE_FEE")
                    .HasColumnType("money");

                entity.Property(e => e.SaleUnitcost)
                    .HasColumnName("SALE_UNITCOST")
                    .HasColumnType("money");

                entity.Property(e => e.ShopPayAmt)
                    .HasColumnName("SHOP_PAY_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.SmoneyExpnAmt)
                    .HasColumnName("SMONEY_EXPN_AMT")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblXSiteJungsanTmp>(entity =>
            {
                entity.HasKey(e => new { e.Sellsite, e.ExtOrderserial, e.ExtOrderserSeq });

                entity.ToTable("tbl_xSite_JungsanTmp");

                entity.Property(e => e.Sellsite)
                    .HasColumnName("sellsite")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExtOrderserial)
                    .HasColumnName("extOrderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExtOrderserSeq)
                    .HasColumnName("extOrderserSeq")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExtCommPrice)
                    .HasColumnName("extCommPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtCommSupplyPrice)
                    .HasColumnName("extCommSupplyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtCommSupplyVatPrice)
                    .HasColumnName("extCommSupplyVatPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtItemCost)
                    .HasColumnName("extItemCost")
                    .HasColumnType("money");

                entity.Property(e => e.ExtItemId)
                    .HasColumnName("extItemID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ExtItemName)
                    .HasColumnName("extItemName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ExtItemNo).HasColumnName("extItemNo");

                entity.Property(e => e.ExtItemOption)
                    .HasColumnName("extItemOption")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExtItemOptionName)
                    .HasColumnName("extItemOptionName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ExtJungsanDate)
                    .IsRequired()
                    .HasColumnName("extJungsanDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExtJungsanType)
                    .IsRequired()
                    .HasColumnName("extJungsanType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExtMeachulDate)
                    .IsRequired()
                    .HasColumnName("extMeachulDate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExtOrgOrderserial)
                    .IsRequired()
                    .HasColumnName("extOrgOrderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExtOwnCouponPrice)
                    .HasColumnName("extOwnCouponPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtReducedPrice)
                    .HasColumnName("extReducedPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtTenCouponPrice)
                    .HasColumnName("extTenCouponPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtTenJungsanPrice)
                    .HasColumnName("extTenJungsanPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtTenMeachulPrice)
                    .HasColumnName("extTenMeachulPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtTenMeachulSupplyPrice)
                    .HasColumnName("extTenMeachulSupplyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtTenMeachulSupplyVatPrice)
                    .HasColumnName("extTenMeachulSupplyVatPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ExtVatYn)
                    .IsRequired()
                    .HasColumnName("extVatYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrgOrderserial)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SiteNo)
                    .HasColumnName("siteNo")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblXSiteTmp11stOrder>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_xSite_TMP11stOrder");

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.BeasongNum11st)
                    .IsRequired()
                    .HasColumnName("beasongNum11st")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsbaljuConfirmSend)
                    .IsRequired()
                    .HasColumnName("isbaljuConfirmSend")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mallid)
                    .HasColumnName("mallid")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDetailKey)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Outmallorderserial)
                    .IsRequired()
                    .HasColumnName("outmallorderserial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblXSiteTmpcheckIdx>(entity =>
            {
                entity.HasKey(e => e.LastcheckOrderSeq)
                    .HasName("PK_tbl_xSiteTMPCheckIDX");

                entity.ToTable("tbl_xSite_TMPCheckIDX");

                entity.Property(e => e.LastcheckOrderSeq)
                    .HasColumnName("lastcheckOrderSeq")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastcheckDt)
                    .HasColumnName("lastcheckDT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblXSiteTmpcheckItemStat>(entity =>
            {
                entity.HasKey(e => e.OutmallOrderSeq);

                entity.ToTable("tbl_xSite_TMPCheckItemStat");

                entity.Property(e => e.OutmallOrderSeq)
                    .HasColumnName("outmallOrderSeq")
                    .ValueGeneratedNever();

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Itemoption)
                    .IsRequired()
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Limitno).HasColumnName("limitno");

                entity.Property(e => e.Limitsold).HasColumnName("limitsold");

                entity.Property(e => e.Limityn)
                    .IsRequired()
                    .HasColumnName("limityn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MallGoodsNo)
                    .HasColumnName("mallGoodsNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MallSnapDt)
                    .HasColumnName("mallSnapDt")
                    .HasColumnType("datetime");

                entity.Property(e => e.MallSnapLastCheckDt)
                    .HasColumnName("mallSnapLastCheckDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.MallSnapLastUpDt)
                    .HasColumnName("mallSnapLastUpDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.MallSnapSellprice)
                    .HasColumnName("mallSnapSellprice")
                    .HasColumnType("money");

                entity.Property(e => e.MallSnapSellyn)
                    .HasColumnName("mallSnapSellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MallSnapStatcd)
                    .HasColumnName("mallSnapStatcd")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Optaddbuyprice)
                    .HasColumnName("optaddbuyprice")
                    .HasColumnType("money");

                entity.Property(e => e.Optaddprice)
                    .HasColumnName("optaddprice")
                    .HasColumnType("money");

                entity.Property(e => e.Optionname)
                    .IsRequired()
                    .HasColumnName("optionname")
                    .HasMaxLength(96)
                    .IsUnicode(false);

                entity.Property(e => e.Optiontypename)
                    .IsRequired()
                    .HasColumnName("optiontypename")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Optlimitno).HasColumnName("optlimitno");

                entity.Property(e => e.Optlimitsold).HasColumnName("optlimitsold");

                entity.Property(e => e.Optlimityn)
                    .IsRequired()
                    .HasColumnName("optlimityn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Optsellyn)
                    .IsRequired()
                    .HasColumnName("optsellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Orgprice)
                    .HasColumnName("orgprice")
                    .HasColumnType("money");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sellcash)
                    .HasColumnName("sellcash")
                    .HasColumnType("money");

                entity.Property(e => e.Sellsite)
                    .HasColumnName("sellsite")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sellyn)
                    .IsRequired()
                    .HasColumnName("sellyn")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TmpOrderSellPrice)
                    .HasColumnName("tmpOrderSellPrice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TblXSiteTmpcs>(entity =>
            {
                entity.HasKey(e => e.Idx);

                entity.ToTable("tbl_xSite_TMPCS");

                entity.HasIndex(e => e.Currstate);

                entity.HasIndex(e => new { e.SellSite, e.OutMallOrderSerial, e.OrgDetailKey, e.CsdetailKey })
                    .HasName("tbl_xSite_TMPCS_SellSite_OutMallOrderSerial_OrgDetailKey_CSDetailKey")
                    .IsUnique();

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.CheckCount).HasColumnName("checkCount");

                entity.Property(e => e.CsdetailKey)
                    .IsRequired()
                    .HasColumnName("CSDetailKey")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Currstate)
                    .HasColumnName("currstate")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('B001')");

                entity.Property(e => e.Deleteyn)
                    .HasColumnName("deleteyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Deliverymemo)
                    .HasColumnName("deliverymemo")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Divcd)
                    .HasColumnName("divcd")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FinUserId)
                    .HasColumnName("finUserId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Gubunname)
                    .HasColumnName("gubunname")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Itemoption)
                    .HasColumnName("itemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSerial)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDetailKey)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrgOutMallOrderSerial)
                    .HasColumnName("orgOutMallOrderSerial")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallItemName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallItemOptionName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallOrderSerial)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallRegDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiveAddr1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveAddr2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveZipCode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SellSite)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblXSiteTmpcsTimestamp>(entity =>
            {
                entity.HasKey(e => new { e.SellSite, e.CsGubun });

                entity.ToTable("tbl_xSite_TMPCS_timestamp");

                entity.Property(e => e.SellSite)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CsGubun)
                    .HasColumnName("csGubun")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsSuccess)
                    .HasColumnName("isSuccess")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastCheckDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblXSiteTmporder>(entity =>
            {
                entity.HasKey(e => e.OutMallOrderSeq)
                    .HasName("PK__tbl_xSite_TMPOrder__668030F6");

                entity.ToTable("tbl_xSite_TMPOrder");

                entity.HasIndex(e => e.OrderSerial)
                    .HasName("IX_tbl_xSite_TMPOrder_Orderserial");

                entity.HasIndex(e => e.OutMallOrderSerial);

                entity.HasIndex(e => new { e.OutMallOrderSeq, e.OrderSerial, e.SellSite })
                    .HasName("IX_tbl_xSite_TMPOrder_sellsite_otmallorderserial_orderseq");

                entity.HasIndex(e => new { e.SellSite, e.MatchItemId, e.Matchitemoption })
                    .HasName("tbl_xSite_TMPOrder_sellsite_itemid_itemoption");

                entity.Property(e => e.BeasongNum11st)
                    .HasColumnName("beasongNum11st")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Changeitemid).HasColumnName("changeitemid");

                entity.Property(e => e.Changeitemoption)
                    .HasColumnName("changeitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("countryCode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('KR')");

                entity.Property(e => e.DeliveryType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Deliverymemo)
                    .HasColumnName("deliverymemo")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Deliveryprice)
                    .HasColumnName("deliveryprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EtcFinUser)
                    .HasColumnName("etcFinUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ItemOrderCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Locationidmaker)
                    .HasColumnName("locationidmaker")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MallCpnUnit)
                    .HasColumnName("mallCpnUnit")
                    .HasColumnType("money");

                entity.Property(e => e.MatchItemId).HasColumnName("matchItemID");

                entity.Property(e => e.MatchState)
                    .HasColumnName("matchState")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.Matchitemoption)
                    .IsRequired()
                    .HasColumnName("matchitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCsGbn).HasColumnName("orderCsGbn");

                entity.Property(e => e.OrderDlvPay)
                    .HasColumnName("orderDlvPay")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("orderItemID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemName)
                    .HasColumnName("orderItemName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemOption)
                    .HasColumnName("orderItemOption")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemOptionName)
                    .HasColumnName("orderItemOptionName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSerial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDetailKey)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrgOrderCnt).HasColumnName("orgOrderCNT");

                entity.Property(e => e.OutMallGoodsNo)
                    .HasColumnName("outMallGoodsNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallJmonth)
                    .HasColumnName("outMallJMonth")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallOptionNo)
                    .HasColumnName("outMallOptionNo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallOrderSerial)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OverseasDeliveryPrice)
                    .HasColumnName("overseasDeliveryPrice")
                    .HasColumnType("money");

                entity.Property(e => e.OverseasPrice)
                    .HasColumnName("overseasPrice")
                    .HasColumnType("money");

                entity.Property(e => e.OverseasRealPrice)
                    .HasColumnName("overseasRealPrice")
                    .HasColumnType("money");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayType)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Prdcode)
                    .HasColumnName("prdcode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PreUseUnitcost)
                    .HasColumnName("PRE_USE_UNITCOST")
                    .HasColumnType("money");

                entity.Property(e => e.RealSellPrice).HasColumnType("money");

                entity.Property(e => e.ReceiveAddr1)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveAddr2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveZipCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecvSendReqCnt)
                    .HasColumnName("recvSendReqCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecvSendState)
                    .HasColumnName("recvSendState")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefCsid).HasColumnName("ref_CSID");

                entity.Property(e => e.RefOutMallOrderSerial)
                    .HasColumnName("ref_OutMallOrderSerial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequireDetail)
                    .HasColumnName("requireDetail")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.RequireDetail11stYn)
                    .HasColumnName("requireDetail11stYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredetailUtf8).HasColumnName("requiredetailUTF8");

                entity.Property(e => e.Reserve01)
                    .HasColumnName("reserve01")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SellDate).HasColumnType("datetime");

                entity.Property(e => e.SellPrice).HasColumnType("money");

                entity.Property(e => e.SellSite)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SellSiteName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SellsiteUserId)
                    .HasColumnName("sellsiteUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SendReqCnt)
                    .HasColumnName("sendReqCNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendSongjangNo)
                    .HasColumnName("sendSongjangNo")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SendState)
                    .HasColumnName("sendState")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShoplinkerOrderId)
                    .HasColumnName("shoplinkerOrderID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SubSellSite)
                    .HasColumnName("subSellSite")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TenCpnUint)
                    .HasColumnName("tenCpnUint")
                    .HasColumnType("money");

                entity.Property(e => e.Vatinclude)
                    .HasColumnName("vatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblXSiteTmporderBack>(entity =>
            {
                entity.HasKey(e => e.OutMallOrderSeq)
                    .HasName("PK__tbl_xSite_TMPOrder_Back");

                entity.ToTable("tbl_xSite_TMPOrder_Back");

                entity.HasIndex(e => e.OrderSerial)
                    .HasName("IX_tbl_xsite_TmpOrder_Back_orderserial");

                entity.Property(e => e.OutMallOrderSeq).ValueGeneratedNever();

                entity.Property(e => e.Changeitemid).HasColumnName("changeitemid");

                entity.Property(e => e.Changeitemoption)
                    .HasColumnName("changeitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("countryCode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Deliverymemo)
                    .HasColumnName("deliverymemo")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Deliveryprice)
                    .HasColumnName("deliveryprice")
                    .HasColumnType("money");

                entity.Property(e => e.EtcFinUser)
                    .HasColumnName("etcFinUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Locationidmaker)
                    .HasColumnName("locationidmaker")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MallCpnUnit)
                    .HasColumnName("mallCpnUnit")
                    .HasColumnType("money");

                entity.Property(e => e.MatchItemId).HasColumnName("matchItemID");

                entity.Property(e => e.MatchState)
                    .HasColumnName("matchState")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Matchitemoption)
                    .IsRequired()
                    .HasColumnName("matchitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCsGbn).HasColumnName("orderCsGbn");

                entity.Property(e => e.OrderDlvPay)
                    .HasColumnName("orderDlvPay")
                    .HasColumnType("money");

                entity.Property(e => e.OrderEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("orderItemID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemName)
                    .HasColumnName("orderItemName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemOption)
                    .HasColumnName("orderItemOption")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemOptionName)
                    .HasColumnName("orderItemOptionName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSerial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDetailKey)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrgOrderCnt).HasColumnName("orgOrderCNT");

                entity.Property(e => e.OutMallGoodsNo)
                    .HasColumnName("outMallGoodsNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallJmonth)
                    .HasColumnName("outMallJMonth")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallOrderSerial)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayType)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Prdcode)
                    .HasColumnName("prdcode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PreUseUnitcost)
                    .HasColumnName("PRE_USE_UNITCOST")
                    .HasColumnType("money");

                entity.Property(e => e.RealSellPrice).HasColumnType("money");

                entity.Property(e => e.ReceiveAddr1)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveAddr2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveZipCode)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.RecvSendReqCnt).HasColumnName("recvSendReqCnt");

                entity.Property(e => e.RecvSendState).HasColumnName("recvSendState");

                entity.Property(e => e.RefCsid).HasColumnName("ref_CSID");

                entity.Property(e => e.RefOutMallOrderSerial)
                    .HasColumnName("ref_OutMallOrderSerial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.RequireDetail)
                    .HasColumnName("requireDetail")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredetailUtf8).HasColumnName("requiredetailUTF8");

                entity.Property(e => e.SellDate).HasColumnType("datetime");

                entity.Property(e => e.SellPrice).HasColumnType("money");

                entity.Property(e => e.SellSite)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SellSiteName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SellsiteUserId)
                    .HasColumnName("sellsiteUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SendReqCnt).HasColumnName("sendReqCNT");

                entity.Property(e => e.SendState).HasColumnName("sendState");

                entity.Property(e => e.ShoplinkerOrderId)
                    .HasColumnName("shoplinkerOrderID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TenCpnUint)
                    .HasColumnName("tenCpnUint")
                    .HasColumnType("money");

                entity.Property(e => e.Vatinclude)
                    .HasColumnName("vatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblXSiteTmporderBatchAct>(entity =>
            {
                entity.HasKey(e => e.Outmallorderseq)
                    .HasName("PK_tbl_xSite_TMPOrder_Batch");

                entity.ToTable("tbl_xSite_TMPOrder_BatchAct");

                entity.Property(e => e.Outmallorderseq)
                    .HasColumnName("outmallorderseq")
                    .ValueGeneratedNever();

                entity.Property(e => e.Actdate)
                    .HasColumnName("actdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Actuser)
                    .IsRequired()
                    .HasColumnName("actuser")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblXSiteTmporderTest>(entity =>
            {
                entity.HasKey(e => e.OutMallOrderSeq)
                    .HasName("PK__tbl_xSite_TMPOrder_TEST__668030F6");

                entity.ToTable("tbl_xSite_TMPOrder_TEST");

                entity.Property(e => e.BeasongNum11st)
                    .HasColumnName("beasongNum11st")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Changeitemid).HasColumnName("changeitemid");

                entity.Property(e => e.Changeitemoption)
                    .HasColumnName("changeitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("countryCode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('KR')");

                entity.Property(e => e.DeliveryType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Deliverymemo)
                    .HasColumnName("deliverymemo")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Deliveryprice)
                    .HasColumnName("deliveryprice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EtcFinUser)
                    .HasColumnName("etcFinUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ItemOrderCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Locationidmaker)
                    .HasColumnName("locationidmaker")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MallCpnUnit)
                    .HasColumnName("mallCpnUnit")
                    .HasColumnType("money");

                entity.Property(e => e.MatchItemId).HasColumnName("matchItemID");

                entity.Property(e => e.MatchState)
                    .HasColumnName("matchState")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.Matchitemoption)
                    .IsRequired()
                    .HasColumnName("matchitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCsGbn).HasColumnName("orderCsGbn");

                entity.Property(e => e.OrderDlvPay)
                    .HasColumnName("orderDlvPay")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("orderItemID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemName)
                    .HasColumnName("orderItemName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemOption)
                    .HasColumnName("orderItemOption")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemOptionName)
                    .HasColumnName("orderItemOptionName")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSerial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDetailKey)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrgOrderCnt).HasColumnName("orgOrderCNT");

                entity.Property(e => e.OutMallGoodsNo)
                    .HasColumnName("outMallGoodsNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallJmonth)
                    .HasColumnName("outMallJMonth")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallOrderSerial)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OverseasDeliveryPrice)
                    .HasColumnName("overseasDeliveryPrice")
                    .HasColumnType("money");

                entity.Property(e => e.OverseasPrice)
                    .HasColumnName("overseasPrice")
                    .HasColumnType("money");

                entity.Property(e => e.OverseasRealPrice)
                    .HasColumnName("overseasRealPrice")
                    .HasColumnType("money");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayType)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Prdcode)
                    .HasColumnName("prdcode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PreUseUnitcost)
                    .HasColumnName("PRE_USE_UNITCOST")
                    .HasColumnType("money");

                entity.Property(e => e.RealSellPrice).HasColumnType("money");

                entity.Property(e => e.ReceiveAddr1)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveAddr2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveZipCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecvSendReqCnt)
                    .HasColumnName("recvSendReqCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecvSendState)
                    .HasColumnName("recvSendState")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefCsid).HasColumnName("ref_CSID");

                entity.Property(e => e.RefOutMallOrderSerial)
                    .HasColumnName("ref_OutMallOrderSerial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequireDetail)
                    .HasColumnName("requireDetail")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.RequireDetail11stYn)
                    .HasColumnName("requireDetail11stYN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredetailUtf8).HasColumnName("requiredetailUTF8");

                entity.Property(e => e.Reserve01)
                    .HasColumnName("reserve01")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SellDate).HasColumnType("datetime");

                entity.Property(e => e.SellPrice).HasColumnType("money");

                entity.Property(e => e.SellSite)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SellSiteName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SellsiteUserId)
                    .HasColumnName("sellsiteUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SendReqCnt)
                    .HasColumnName("sendReqCNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendState)
                    .HasColumnName("sendState")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShoplinkerOrderId)
                    .HasColumnName("shoplinkerOrderID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TenCpnUint)
                    .HasColumnName("tenCpnUint")
                    .HasColumnType("money");

                entity.Property(e => e.Vatinclude)
                    .HasColumnName("vatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblXSiteTmporderTimestamp>(entity =>
            {
                entity.HasKey(e => e.SellSite);

                entity.ToTable("tbl_xSite_TMPOrder_timestamp");

                entity.Property(e => e.SellSite)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsSuccess)
                    .IsRequired()
                    .HasColumnName("isSuccess")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastCheckDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblXsiteMayDelOrder>(entity =>
            {
                entity.HasKey(e => e.OutMallOrderSeq)
                    .HasName("PK__tbl_xsite_mayDelOrder__668030F6");

                entity.ToTable("tbl_xsite_mayDelOrder");

                entity.Property(e => e.Changeitemid).HasColumnName("changeitemid");

                entity.Property(e => e.Changeitemoption)
                    .HasColumnName("changeitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("countryCode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('KR')");

                entity.Property(e => e.DeliveryType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Deliverymemo)
                    .HasColumnName("deliverymemo")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Deliveryprice)
                    .HasColumnName("deliveryprice")
                    .HasColumnType("money");

                entity.Property(e => e.EtcFinUser)
                    .HasColumnName("etcFinUser")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ItemOrderCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.Locationidmaker)
                    .HasColumnName("locationidmaker")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MallCpnUnit)
                    .HasColumnName("mallCpnUnit")
                    .HasColumnType("money");

                entity.Property(e => e.MatchItemId).HasColumnName("matchItemID");

                entity.Property(e => e.MatchState)
                    .HasColumnName("matchState")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.Matchitemoption)
                    .IsRequired()
                    .HasColumnName("matchitemoption")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCsGbn).HasColumnName("orderCsGbn");

                entity.Property(e => e.OrderDlvPay)
                    .HasColumnName("orderDlvPay")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("orderItemID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemName)
                    .HasColumnName("orderItemName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemOption)
                    .HasColumnName("orderItemOption")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemOptionName)
                    .HasColumnName("orderItemOptionName")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OrderName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSerial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrgDetailKey)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OrgOrderCnt).HasColumnName("orgOrderCNT");

                entity.Property(e => e.OutMallGoodsNo)
                    .HasColumnName("outMallGoodsNo")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallJmonth)
                    .HasColumnName("outMallJMonth")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.OutMallOrderSerial)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PayType)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Prdcode)
                    .HasColumnName("prdcode")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PreUseUnitcost)
                    .HasColumnName("PRE_USE_UNITCOST")
                    .HasColumnType("money");

                entity.Property(e => e.RealSellPrice).HasColumnType("money");

                entity.Property(e => e.ReceiveAddr1)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveAddr2)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveHpNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTelNo)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveZipCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecvSendReqCnt)
                    .HasColumnName("recvSendReqCnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecvSendState)
                    .HasColumnName("recvSendState")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefCsid).HasColumnName("ref_CSID");

                entity.Property(e => e.RefOutMallOrderSerial)
                    .HasColumnName("ref_OutMallOrderSerial")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequireDetail)
                    .HasColumnName("requireDetail")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SellDate).HasColumnType("datetime");

                entity.Property(e => e.SellPrice).HasColumnType("money");

                entity.Property(e => e.SellSite)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SellSiteName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.SellsiteUserId)
                    .HasColumnName("sellsiteUserID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SendReqCnt)
                    .HasColumnName("sendReqCNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendState)
                    .HasColumnName("sendState")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShoplinkerOrderId)
                    .HasColumnName("shoplinkerOrderID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.TenCpnUint)
                    .HasColumnName("tenCpnUint")
                    .HasColumnType("money");

                entity.Property(e => e.Vatinclude)
                    .HasColumnName("vatinclude")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<TblXsiteRegItemCheck>(entity =>
            {
                entity.HasKey(e => new { e.SellSite, e.Goodsno });

                entity.ToTable("tbl_XSite_regItemCheck");

                entity.Property(e => e.SellSite)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Goodsno)
                    .HasColumnName("goodsno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DispYn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsNm)
                    .IsRequired()
                    .HasColumnName("goodsNm")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsRegDtime).HasColumnType("smalldatetime");

                entity.Property(e => e.MayTenItemId).HasColumnName("mayTenItemID");

                entity.Property(e => e.Maymidx).HasColumnName("maymidx");

                entity.Property(e => e.RegDtKey)
                    .HasColumnName("regDtKey")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SalePrc).HasColumnType("money");

                entity.Property(e => e.SaleStatCd)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempMailYtw>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("temp_mail_ytw");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TempMailYtw1>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("temp_mail_ytw1");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<XxTblKsearchAttrSummary>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK_tbl_ksearch_attrSummary");

                entity.ToTable("XX_tbl_ksearch_attrSummary");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttrGrpArr)
                    .IsRequired()
                    .HasColumnName("attrGrpArr")
                    .IsUnicode(false);

                entity.Property(e => e.AttrValArr)
                    .IsRequired()
                    .HasColumnName("attrValArr")
                    .IsUnicode(false);
            });
        }
    }
}
