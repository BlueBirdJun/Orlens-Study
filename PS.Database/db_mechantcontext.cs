using Microsoft.EntityFrameworkCore;
using PS.Database.Models.db_Mechant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PS.Database
{
    public partial class db_mechantcontext : DbContext
    {
        public db_mechantcontext(IDbConnection dbConnection, bool isConsoleLogging = false) //: base(dbConnection, isConsoleLogging)
        {
        }
        public db_mechantcontext(DbContextOptions<db_mechantcontext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Matchcategory>(entity =>
            {
                entity.HasKey(e => e.Matchkey);

                entity.ToTable("matchcategory");

                entity.Property(e => e.Matchkey).HasColumnName("matchkey");

                entity.Property(e => e.Categorykey).HasColumnName("categorykey");

                entity.Property(e => e.Catelarge)
                    .HasColumnName("catelarge")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Catemid)
                    .HasColumnName("catemid")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Catesmall)
                    .HasColumnName("catesmall")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tblbrand>(entity =>
            {
                entity.HasKey(e => e.Brandname)
                    .HasName("PK_tblbrand_1");

                entity.ToTable("tblbrand");

                entity.HasComment("브랜드정보");

                entity.Property(e => e.Brandname)
                    .HasColumnName("brandname")
                    .HasMaxLength(100)
                    .HasComment("브랜드이름");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(200)
                    .HasComment("주소1");

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(200)
                    .HasComment("주소2");

                entity.Property(e => e.Addressdetail1)
                    .HasColumnName("addressdetail1")
                    .HasMaxLength(200)
                    .HasComment("주소상세1");

                entity.Property(e => e.Addressdetail2)
                    .HasColumnName("addressdetail2")
                    .HasMaxLength(200)
                    .HasComment("주소상세2");

                entity.Property(e => e.Brandkey)
                    .HasColumnName("brandkey")
                    .HasComment("브랜드키")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cellnumber1)
                    .HasColumnName("cellnumber1")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("핸폰번호1");

                entity.Property(e => e.Cellnumber2)
                    .HasColumnName("cellnumber2")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("핸폰번호2");

                entity.Property(e => e.Companyname)
                    .HasColumnName("companyname")
                    .HasMaxLength(100);

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasComment("생성일");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Engname)
                    .HasColumnName("engname")
                    .HasMaxLength(100)
                    .HasComment("브랜드영문이름");

                entity.Property(e => e.Homepage)
                    .HasColumnName("homepage")
                    .HasMaxLength(100);

                entity.Property(e => e.Korname)
                    .HasColumnName("korname")
                    .HasMaxLength(100)
                    .HasComment("브랜드한글이름");

                entity.Property(e => e.Managername)
                    .HasColumnName("managername")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("담당자이름");

                entity.Property(e => e.Ownername)
                    .HasColumnName("ownername")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("대표자이름");

                entity.Property(e => e.Socnumber)
                    .HasColumnName("socnumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasColumnName("tel1")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("전화번호1");

                entity.Property(e => e.Tel2)
                    .HasColumnName("tel2")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("전화번호2");

                entity.Property(e => e.Zipcode1)
                    .HasColumnName("zipcode1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("우편번호1");

                entity.Property(e => e.Zipcode2)
                    .HasColumnName("zipcode2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("우편번호2");
            });

            modelBuilder.Entity<TblbrandHis>(entity =>
            {
                entity.HasKey(e => e.Brandkey)
                    .HasName("PK_TBLBRAND_HIS");

                entity.ToTable("tblbrand_his");

                entity.HasComment("브랜드정보");

                entity.Property(e => e.Brandkey)
                    .HasColumnName("brandkey")
                    .HasComment("브랜드키");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(200)
                    .HasComment("주소1");

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(200)
                    .HasComment("주소2");

                entity.Property(e => e.Addressdetail1)
                    .HasColumnName("addressdetail1")
                    .HasMaxLength(200)
                    .HasComment("주소상세1");

                entity.Property(e => e.Addressdetail2)
                    .HasColumnName("addressdetail2")
                    .HasMaxLength(200)
                    .HasComment("주소상세2");

                entity.Property(e => e.Brandname)
                    .HasColumnName("brandname")
                    .HasMaxLength(100)
                    .HasComment("브랜드이름");

                entity.Property(e => e.Cellnumber1)
                    .HasColumnName("cellnumber1")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("핸폰번호1");

                entity.Property(e => e.Cellnumber2)
                    .HasColumnName("cellnumber2")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("핸폰번호2");

                entity.Property(e => e.Companyname)
                    .HasColumnName("companyname")
                    .HasMaxLength(100)
                    .HasComment("회사이름");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("생성일");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .HasComment("email");

                entity.Property(e => e.Engname)
                    .HasColumnName("engname")
                    .HasMaxLength(100)
                    .HasComment("브랜드영문이름");

                entity.Property(e => e.Homepage)
                    .HasColumnName("homepage")
                    .HasMaxLength(100)
                    .HasComment("홈페이지");

                entity.Property(e => e.Korname)
                    .HasColumnName("korname")
                    .HasMaxLength(100)
                    .HasComment("브랜드한글이름");

                entity.Property(e => e.Managername)
                    .HasColumnName("managername")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("담당자이름");

                entity.Property(e => e.OriginBrandKey).HasComment("원 브랜드키");

                entity.Property(e => e.Ownername)
                    .HasColumnName("ownername")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("대표자이름");

                entity.Property(e => e.Socnumber)
                    .HasColumnName("socnumber")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("사업자등록번호");

                entity.Property(e => e.Tel1)
                    .HasColumnName("tel1")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("전화번호1");

                entity.Property(e => e.Tel2)
                    .HasColumnName("tel2")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("전화번호2");

                entity.Property(e => e.Versionkey)
                    .HasColumnName("versionkey")
                    .HasComment("버전키");

                entity.Property(e => e.Zipcode1)
                    .HasColumnName("zipcode1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("우편번호1");

                entity.Property(e => e.Zipcode2)
                    .HasColumnName("zipcode2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("우편번호2");
            });

            modelBuilder.Entity<Tblcategory>(entity =>
            {
                entity.HasKey(e => e.Categorykey)
                    .HasName("PK_TBLCATEGORY");

                entity.ToTable("tblcategory");

                entity.Property(e => e.Categorykey)
                    .HasColumnName("categorykey")
                    .HasComment("카테고리키");

                entity.Property(e => e.Categoryname)
                    .HasColumnName("categoryname")
                    .HasMaxLength(200)
                    .HasComment("카테고리이름");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("생성일");

                entity.Property(e => e.Depth)
                    .HasColumnName("depth")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("깊이");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500)
                    .HasComment("설명");

                entity.Property(e => e.Parentkey)
                    .HasColumnName("parentkey")
                    .HasComment("부모카테고리");
            });

            modelBuilder.Entity<Tblcert>(entity =>
            {
                entity.HasKey(e => new { e.Certkey, e.Productkey })
                    .HasName("PK_TBLCERT");

                entity.ToTable("tblcert");

                entity.Property(e => e.Certkey)
                    .HasColumnName("certkey")
                    .HasComment("인증키")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Productkey)
                    .HasColumnName("productkey")
                    .HasComment("상품키");

                entity.Property(e => e.Certcode)
                    .HasColumnName("certcode")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("인증코드");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(200)
                    .HasComment("내용");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasComment("생성일");

                entity.Property(e => e.Useyn)
                    .HasColumnName("useyn")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("사용여부");
            });

            modelBuilder.Entity<Tblcode>(entity =>
            {
                entity.HasKey(e => e.Codekey)
                    .HasName("PK_TBLCODE");

                entity.ToTable("tblcode");

                entity.Property(e => e.Codekey).HasColumnName("codekey");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(100);

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblimage>(entity =>
            {
                entity.HasKey(e => new { e.Productkey, e.Imagekey })
                    .HasName("PK_TBLIMAGE");

                entity.ToTable("tblimage");

                entity.Property(e => e.Productkey)
                    .HasColumnName("productkey")
                    .HasComment("상품키");

                entity.Property(e => e.Imagekey)
                    .HasColumnName("imagekey")
                    .HasComment("이미지키")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasComment("생성일");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("상품종류");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasComment("이미지url");

                entity.Property(e => e.Useyn)
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("사용여부");
            });

            modelBuilder.Entity<Tbloption>(entity =>
            {
                entity.HasKey(e => new { e.Optionkey, e.Productkey })
                    .HasName("PK_TBLOPTION");

                entity.ToTable("tbloption");

                entity.Property(e => e.Optionkey)
                    .HasColumnName("optionkey")
                    .HasComment("옵션키")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Productkey)
                    .HasColumnName("productkey")
                    .HasComment("상품키");

                entity.Property(e => e.Addbuyprice)
                    .HasColumnName("addbuyprice")
                    .HasColumnType("money");

                entity.Property(e => e.Addprice)
                    .HasColumnName("addprice")
                    .HasColumnType("money")
                    .HasComment("추가가격");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasComment("생성일");

                entity.Property(e => e.Optionname)
                    .HasColumnName("optionname")
                    .HasMaxLength(500)
                    .HasComment("옵션이름");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasComment("재고");

                entity.Property(e => e.Typename)
                    .HasColumnName("typename")
                    .HasMaxLength(500)
                    .HasComment("옵션타입이름");
            });

            modelBuilder.Entity<Tblprice>(entity =>
            {
                entity.HasKey(e => new { e.Pricekey, e.Productkey })
                    .HasName("PK_TBLPRICE");

                entity.ToTable("tblprice");

                entity.Property(e => e.Pricekey)
                    .HasColumnName("pricekey")
                    .HasComment("가격키")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Productkey)
                    .HasColumnName("productkey")
                    .HasComment("상품키");

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money")
                    .HasComment("공급가격");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("생성일");

                entity.Property(e => e.Customerbuycash)
                    .HasColumnName("customerbuycash")
                    .HasColumnType("money")
                    .HasComment("소비자대비판매가");

                entity.Property(e => e.Customerprice)
                    .HasColumnName("customerprice")
                    .HasColumnType("money")
                    .HasComment("소비자가");

                entity.Property(e => e.Salebuyprice)
                    .HasColumnName("salebuyprice")
                    .HasColumnType("money")
                    .HasComment("할인매입가");

                entity.Property(e => e.Saleprice)
                    .HasColumnName("saleprice")
                    .HasColumnType("money")
                    .HasComment("할인가");

                entity.Property(e => e.Sellprice)
                    .HasColumnName("sellprice")
                    .HasColumnType("money")
                    .HasComment("판매가격");
            });

            modelBuilder.Entity<TblpriceHis>(entity =>
            {
                entity.HasKey(e => new { e.Versionkey, e.Pricekey })
                    .HasName("PK_TBLPRICE_HIS");

                entity.ToTable("tblprice_his");

                entity.Property(e => e.Versionkey)
                    .HasColumnName("versionkey")
                    .HasComment("버전키");

                entity.Property(e => e.Pricekey)
                    .HasColumnName("pricekey")
                    .HasComment("상품가격키")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Buycash)
                    .HasColumnName("buycash")
                    .HasColumnType("money")
                    .HasComment("공급가격");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("생성일");

                entity.Property(e => e.Customerbuycash)
                    .HasColumnName("customerbuycash")
                    .HasColumnType("money")
                    .HasComment("소비자대비판매가");

                entity.Property(e => e.Customerprice)
                    .HasColumnName("customerprice")
                    .HasColumnType("money")
                    .HasComment("소비자가");

                entity.Property(e => e.Originpricekey)
                    .HasColumnName("originpricekey")
                    .HasComment("원상품가격키");

                entity.Property(e => e.Productkey)
                    .HasColumnName("productkey")
                    .HasComment("상품키");

                entity.Property(e => e.Salebuyprice)
                    .HasColumnName("salebuyprice")
                    .HasColumnType("money")
                    .HasComment("할인매입가");

                entity.Property(e => e.Saleprice)
                    .HasColumnName("saleprice")
                    .HasColumnType("money")
                    .HasComment("할인가");

                entity.Property(e => e.Sellprice)
                    .HasColumnName("sellprice")
                    .HasColumnType("money")
                    .HasComment("판매가격");
            });

            modelBuilder.Entity<Tblproduct>(entity =>
            {
                entity.HasKey(e => e.Productkey)
                    .HasName("PK_TBLPRODUCT");

                entity.ToTable("tblproduct");

                entity.Property(e => e.Productkey)
                    .HasColumnName("productkey")
                    .HasComment("상품키");

                entity.Property(e => e.Brandkey)
                    .HasColumnName("brandkey")
                    .HasComment("브랜드키");

                entity.Property(e => e.Buydlv)
                    .HasColumnName("buydlv")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("매입구분");

                entity.Property(e => e.Categorykey)
                    .HasColumnName("categorykey")
                    .HasComment("카테고리키");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("생성일");

                entity.Property(e => e.Productattribute)
                    .HasColumnName("productattribute")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("상품속성");

                entity.Property(e => e.Productcode)
                    .HasColumnName("productcode")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("상품코드");

                entity.Property(e => e.Productkind)
                    .HasColumnName("productkind")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("상품종류");

                entity.Property(e => e.Productname)
                    .HasColumnName("productname")
                    .HasMaxLength(200)
                    .HasComment("상품이름");

                entity.Property(e => e.Saleyn)
                    .HasColumnName("saleyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("판매여부");

                entity.Property(e => e.Taxyn)
                    .HasColumnName("taxyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("과세구분");

                entity.Property(e => e.Useyn)
                    .HasColumnName("useyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("사용여부");
            });

            modelBuilder.Entity<Tblproductdetail>(entity =>
            {
                entity.HasKey(e => new { e.Detailkey, e.Productkey })
                    .HasName("PK_TBLPRODUCTDETAIL");

                entity.ToTable("tblproductdetail");

                entity.Property(e => e.Detailkey)
                    .HasColumnName("detailkey")
                    .HasComment("상세키")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Productkey)
                    .HasColumnName("productkey")
                    .HasComment("상품키");

                entity.Property(e => e.Adultyn)
                    .HasColumnName("adultyn")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("성인용품");

                entity.Property(e => e.Caution)
                    .HasColumnName("caution")
                    .HasMaxLength(2000)
                    .HasComment("주의점");

                entity.Property(e => e.Colorcode)
                    .HasColumnName("colorcode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("컬러코드");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasComment("생성일");

                entity.Property(e => e.Deschtml)
                    .HasColumnName("deschtml")
                    .HasColumnType("ntext")
                    .HasComment("상품설명(html)");

                entity.Property(e => e.Desctext)
                    .HasColumnName("desctext")
                    .HasColumnType("ntext")
                    .HasComment("상품설명(텍스트)");

                entity.Property(e => e.Orderperiod)
                    .HasColumnName("orderperiod")
                    .HasComment("제작일수");

                entity.Property(e => e.Pojanyn)
                    .HasColumnName("pojanyn")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("포장여부");

                entity.Property(e => e.Useyn)
                    .HasColumnName("useyn")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("사용여부");
            });

            modelBuilder.Entity<Tblsearch>(entity =>
            {
                entity.HasKey(e => new { e.Searchkey, e.Productkey })
                    .HasName("PK_TBLSEARCH");

                entity.ToTable("tblsearch");

                entity.HasComment("검색키");

                entity.Property(e => e.Searchkey)
                    .HasColumnName("searchkey")
                    .HasComment("검색키")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Productkey)
                    .HasColumnName("productkey")
                    .HasComment("상품키");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasComment("생성일");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasMaxLength(50)
                    .HasComment("검색어");
            });

            modelBuilder.Entity<Tblshipinfo>(entity =>
            {
                entity.HasKey(e => new { e.Brandkey, e.Shipinfokey })
                    .HasName("PK_TBLSHIPINFO");

                entity.ToTable("tblshipinfo");

                entity.HasComment("배송정보");

                entity.Property(e => e.Brandkey)
                    .HasColumnName("brandkey")
                    .HasComment("브랜드키");

                entity.Property(e => e.Shipinfokey)
                    .HasColumnName("shipinfokey")
                    .HasComment("배송정보키")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime")
                    .HasComment("생성일");

                entity.Property(e => e.Returnaddress)
                    .HasColumnName("returnaddress")
                    .HasMaxLength(200)
                    .HasComment("반품주소");

                entity.Property(e => e.Returnaddressdetail)
                    .HasColumnName("returnaddressdetail")
                    .HasMaxLength(200)
                    .HasComment("반품주소상세");

                entity.Property(e => e.Returnaddresszipcode)
                    .HasColumnName("returnaddresszipcode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("반품주소우편번호");

                entity.Property(e => e.Shipaddress)
                    .HasColumnName("shipaddress")
                    .HasMaxLength(200)
                    .HasComment("배송지");

                entity.Property(e => e.Shipaddressdetail)
                    .HasColumnName("shipaddressdetail")
                    .HasMaxLength(200)
                    .HasComment("배송지상세");

                entity.Property(e => e.Shipaddresszipcode)
                    .HasColumnName("shipaddresszipcode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("배송지우편번호");

                entity.Property(e => e.Shiparead)
                    .HasColumnName("shiparead")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("배송가능지역");

                entity.Property(e => e.Shippricekey)
                    .HasColumnName("shippricekey")
                    .HasComment("배송키");
            });

            modelBuilder.Entity<Tblshipinfoprice>(entity =>
            {
                entity.HasKey(e => e.Shippricekey)
                    .HasName("PK_TBLSHIPINFOPRICE");

                entity.ToTable("tblshipinfoprice");

                entity.HasComment("배송비정책");

                entity.Property(e => e.Shippricekey)
                    .HasColumnName("shippricekey")
                    .HasComment("배송비키");

                entity.Property(e => e.Basicprice)
                    .HasColumnName("basicprice")
                    .HasColumnType("money")
                    .HasComment("기본배송비");

                entity.Property(e => e.Conditonprice)
                    .HasColumnName("conditonprice")
                    .HasColumnType("money")
                    .HasComment("무료배송금액");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Exchagneprice)
                    .HasColumnName("exchagneprice")
                    .HasColumnType("money")
                    .HasComment("교환비");

                entity.Property(e => e.Productkey)
                    .HasColumnName("productkey")
                    .HasComment("상품키");

                entity.Property(e => e.Returnprice)
                    .HasColumnName("returnprice")
                    .HasColumnType("money")
                    .HasComment("반품비");

                entity.Property(e => e.Shipmethod)
                    .HasColumnName("shipmethod")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("배송방법");
            });

            modelBuilder.Entity<Tblversion>(entity =>
            {
                entity.HasKey(e => e.Versionkey)
                    .HasName("PK_TBLVERSION");

                entity.ToTable("tblversion");

                entity.HasComment("버전정보");

                entity.Property(e => e.Versionkey).HasColumnName("versionkey");

                entity.Property(e => e.Accept)
                    .HasColumnName("accept")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Starttime)
                    .HasColumnName("starttime")
                    .HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        #region model
        public virtual DbSet<Matchcategory> Matchcategory { get; set; }
        public virtual DbSet<Tblbrand> Tblbrand { get; set; }
        public virtual DbSet<TblbrandHis> TblbrandHis { get; set; }
        public virtual DbSet<Tblcategory> Tblcategory { get; set; }
        public virtual DbSet<Tblcert> Tblcert { get; set; }
        public virtual DbSet<Tblcode> Tblcode { get; set; }
        public virtual DbSet<Tblimage> Tblimage { get; set; }
        public virtual DbSet<Tbloption> Tbloption { get; set; }
        public virtual DbSet<Tblprice> Tblprice { get; set; }
        public virtual DbSet<TblpriceHis> TblpriceHis { get; set; }
        public virtual DbSet<Tblproduct> Tblproduct { get; set; }
        public virtual DbSet<Tblproductdetail> Tblproductdetail { get; set; }
        public virtual DbSet<Tblsearch> Tblsearch { get; set; }
        public virtual DbSet<Tblshipinfo> Tblshipinfo { get; set; }
        public virtual DbSet<Tblshipinfoprice> Tblshipinfoprice { get; set; }
        public virtual DbSet<Tblversion> Tblversion { get; set; }
        #endregion

    }
}
