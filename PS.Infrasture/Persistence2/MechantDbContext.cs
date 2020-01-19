using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PS.Applications.Common.Interfaces;
using PS.Database.Models.db_Mechant;
using PS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PS.Infrasture.Persistence2
{
    public class MechantDbContext : DbContext, IMechantDbContext
    {
        public DbSet<Tblbrand> brand { get; set; }
        public DbSet<TblbrandHis> tbltest { get; set; }

        

        public MechantDbContext(
           DbContextOptions options
           ) : base(options)
        {
           
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            foreach (var entry in ChangeTracker.Entries<ScaffordTableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        break;
                    case EntityState.Modified:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tblbrand>(entity =>
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

            builder.Entity<TblbrandHis>(entity =>
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


            base.OnModelCreating(builder);
        }
    }
}
