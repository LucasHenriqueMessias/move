using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using oraclebam.Models;

namespace oraclebam.Models
{
    public partial class ModelContext : DbContext
    {

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MvSysSegEmailGroup> MvSysSegEmailGroups { get; set; } = null!;
        public virtual DbSet<MvSysSeoExchangeOperation> MvSysSeoExchangeOperations { get; set; } = null!;
        public virtual DbSet<MvSysSefExchangeFile> MvSysSefExchangeFiles { get; set; } = null!;
        public virtual DbSet<QvSysSelExchangeLog> QvSysSelExchangeLogs { get; set; } = null!;
        public virtual DbSet<MvSysSehExchangeHost> MvSysSehExchangeHosts { get; set; } = null!;
        public virtual DbSet<QvSysSsmSystemMail> QvSysSsmSystemMails { get; set; } = null!;
        public virtual DbSet<MvSysSjqJobQueue> MvSysSjqJobQueues { get; set; } = null!;
        public virtual DbSet<MvSysSjJob> MvSysSjJobs { get; set; } = null!;
        public virtual DbSet<MvSysSxException> MvSysSxExceptions { get; set; } = null!; 
        public virtual DbSet<MvSysSvxValueException> MvSysSvxValueExceptions { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("PROJECT");

             modelBuilder.Entity<MvSysSvxValueException>(entity =>
            {
                entity.ToTable("\"MV_SYS_SVX_VALUE_EXCEPTION").HasKey(e => new
                {
                    e.SvxCompany
                });

                entity.ToView("MV_SYS_SVX_VALUE_EXCEPTION");

                entity.Property(e => e.SvxActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SVX_ACTIVE");

                entity.Property(e => e.SvxAlphanumericValue)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SVX_ALPHANUMERIC_VALUE");

                entity.Property(e => e.SvxCompany)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SVX_COMPANY");

                entity.Property(e => e.SvxDatetimeAltered)
                    .HasColumnType("DATE")
                    .HasColumnName("SVX_DATETIME_ALTERED");

                entity.Property(e => e.SvxDatetimeCreated)
                    .HasColumnType("DATE")
                    .HasColumnName("SVX_DATETIME_CREATED");

                entity.Property(e => e.SvxDatetimeValue)
                    .HasColumnType("DATE")
                    .HasColumnName("SVX_DATETIME_VALUE");

               /* entity.Property(e => e.SvxException)
                    .HasPrecision(4)
                    .HasColumnName("SVX_EXCEPTION");
               */
                entity.Property(e => e.SvxNumericValue)
                    .HasColumnType("NUMBER(14,4)")
                    .HasColumnName("SVX_NUMERIC_VALUE");

                entity.Property(e => e.SvxUserAltered)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SVX_USER_ALTERED");

                entity.Property(e => e.SvxUserCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SVX_USER_CREATED");

                entity.Property(e => e.SxDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SX_DESCRIPTION");
            });
            
            modelBuilder.Entity<MvSysSxException>(entity =>
            {
                entity.ToTable("MV_SYS_SX_EXCEPTION").HasKey(e => new
                {
                    e.SxCompany
                });

                entity.ToView("MV_SYS_SX_EXCEPTION");

                entity.Property(e => e.SxColumn)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SX_COLUMN");

                entity.Property(e => e.SxCompany)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SX_COMPANY");

                entity.Property(e => e.SxComparison)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SX_COMPARISON");

                entity.Property(e => e.SxDatetimeAltered)
                    .HasColumnType("DATE")
                    .HasColumnName("SX_DATETIME_ALTERED");

                entity.Property(e => e.SxDatetimeCreated)
                    .HasColumnType("DATE")
                    .HasColumnName("SX_DATETIME_CREATED");

                entity.Property(e => e.SxDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SX_DESCRIPTION");

               /* entity.Property(e => e.SxException)
                    .HasPrecision(4)
                    .HasColumnName("SX_EXCEPTION");
               */
                entity.Property(e => e.SxModule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SX_MODULE");

                entity.Property(e => e.SxNote)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SX_NOTE");

                entity.Property(e => e.SxTable)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SX_TABLE");

                entity.Property(e => e.SxUserAltered)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SX_USER_ALTERED");

                entity.Property(e => e.SxUserCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SX_USER_CREATED");

                entity.Property(e => e.SxValue)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SX_VALUE");
            });

              modelBuilder.Entity<MvSysSjJob>(entity =>
            {
                entity.ToTable("MV_SYS_SJ_JOB").HasKey(e => new
                {
                    e.SjProcedureName
                });

                entity.ToView("MV_SYS_SJ_JOB");

                entity.Property(e => e.SjDatetimeCreated)
                    .HasColumnType("DATE")
                    .HasColumnName("SJ_DATETIME_CREATED");

                entity.Property(e => e.SjDatetimeUpdated)
                    .HasColumnType("DATE")
                    .HasColumnName("SJ_DATETIME_UPDATED");

                entity.Property(e => e.SjDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SJ_DESCRIPTION");

                entity.Property(e => e.SjProcedureName)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("SJ_PROCEDURE_NAME");

                entity.Property(e => e.SjUserCreated)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SJ_USER_CREATED");

                entity.Property(e => e.SjUserUpdated)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SJ_USER_UPDATED");
            });

            modelBuilder.Entity<MvSysSjqJobQueue>(entity =>
            {
                entity.ToTable("MV_SYS_SJQ_JOB_QUEUE").HasKey(e => new
                {
                    e.SjqProcedureName
                });

                entity.ToView("MV_SYS_SJQ_JOB_QUEUE");

                entity.Property(e => e.SjDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SJ_DESCRIPTION");

                entity.Property(e => e.SjqCurrentIteration)
                    .HasPrecision(3)
                    .HasColumnName("SJQ_CURRENT_ITERATION");

                entity.Property(e => e.SjqDatetimeCreated)
                    .HasColumnType("DATE")
                    .HasColumnName("SJQ_DATETIME_CREATED");

                entity.Property(e => e.SjqDatetimeScheduled)
                    .HasColumnType("DATE")
                    .HasColumnName("SJQ_DATETIME_SCHEDULED");

                entity.Property(e => e.SjqDatetimeUpdated)
                    .HasColumnType("DATE")
                    .HasColumnName("SJQ_DATETIME_UPDATED");

                entity.Property(e => e.SjqFollowedByMail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_FOLLOWED_BY_MAIL");

                entity.Property(e => e.SjqFriday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_FRIDAY");

                entity.Property(e => e.SjqInterval)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_INTERVAL");

                entity.Property(e => e.SjqJob)
                    .HasPrecision(6)
                    .HasColumnName("SJQ_JOB");

                entity.Property(e => e.SjqMessage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_MESSAGE");

                entity.Property(e => e.SjqMonday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_MONDAY");

                entity.Property(e => e.SjqProcedureName)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_PROCEDURE_NAME");

                entity.Property(e => e.SjqSaturday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_SATURDAY");

                entity.Property(e => e.SjqStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_STATUS");

                entity.Property(e => e.SjqSunday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_SUNDAY");

                entity.Property(e => e.SjqThursday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_THURSDAY");

                entity.Property(e => e.SjqTotalIteration)
                    .HasPrecision(3)
                    .HasColumnName("SJQ_TOTAL_ITERATION");

                entity.Property(e => e.SjqTuesday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_TUESDAY");

                entity.Property(e => e.SjqUserCreated)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_USER_CREATED");

                entity.Property(e => e.SjqUserUpdated)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_USER_UPDATED");

                entity.Property(e => e.SjqWednesday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SJQ_WEDNESDAY");
            });

             modelBuilder.Entity<QvSysSsmSystemMail>(entity =>
            {
                entity.ToTable("QV_SYS_SSM_SYSTEM_MAIL").HasKey(e => new
                {
                    e.SsmSentDatetime
                });

                entity.ToView("QV_SYS_SSM_SYSTEM_MAIL");

                entity.Property(e => e.SsmMessage)
                    .IsUnicode(false)
                    .HasColumnName("SSM_MESSAGE");

                entity.Property(e => e.SsmSentDatetime)
                    .HasColumnType("DATE")
                    .HasColumnName("SSM_SENT_DATETIME");

                entity.Property(e => e.SsmSubject)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("SSM_SUBJECT");

                entity.Property(e => e.SsmUsername)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SSM_USERNAME");
            });

              modelBuilder.Entity<MvSysSegEmailGroup>(entity =>
            {
                entity.ToTable("MV_SYS_SEG_EMAIL_GROUP").HasKey(e => new
                {
                    e.SegGroupName
                });

                entity.ToView("MV_SYS_SEG_EMAIL_GROUP");

                entity.Property(e => e.SegCompany)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SEG_COMPANY");

                entity.Property(e => e.SegDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEG_DESCRIPTION");

                entity.Property(e => e.SegGroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEG_GROUP_NAME");
            });
            
            modelBuilder.Entity<MvSysSefExchangeFile>(entity =>
            {
                entity.ToTable("MV_SYS_SEF_EXCHANGE_FILE").HasKey(e => new
                {
                    e.SefId
                });

                entity.ToView("MV_SYS_SEF_EXCHANGE_FILE");

                entity.Property(e => e.SefAppend)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEF_APPEND");

                entity.Property(e => e.SefBackupDir)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEF_BACKUP_DIR");

                entity.Property(e => e.SefCompany)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SEF_COMPANY");

                entity.Property(e => e.SefDateAlt)
                    .HasColumnType("DATE")
                    .HasColumnName("SEF_DATE_ALT");

                entity.Property(e => e.SefDeleteSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEF_DELETE_SOURCE");

                entity.Property(e => e.SefDestDir)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEF_DEST_DIR");

                entity.Property(e => e.SefDestFile)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SEF_DEST_FILE");

                entity.Property(e => e.SefDestFtpUser)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SEF_DEST_FTP_USER");

                entity.Property(e => e.SefDestHost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEF_DEST_HOST");

                entity.Property(e => e.SefDestShare)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SEF_DEST_SHARE");

                entity.Property(e => e.SefId)
                    .HasPrecision(15)
                    .HasColumnName("SEF_ID");

                entity.Property(e => e.SefModule)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SEF_MODULE");

                entity.Property(e => e.SefOperation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEF_OPERATION");

                entity.Property(e => e.SefShare)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SEF_SHARE");

                entity.Property(e => e.SefSourceDir)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SEF_SOURCE_DIR");

                entity.Property(e => e.SefSourceFile)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("SEF_SOURCE_FILE");

                entity.Property(e => e.SefSourceFtpUser)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SEF_SOURCE_FTP_USER");

                entity.Property(e => e.SefSourceHost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEF_SOURCE_HOST");

                entity.Property(e => e.SefUserAlt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEF_USER_ALT");
            });
            modelBuilder.Entity<QvSysSelExchangeLog>(entity =>
            {
                entity.ToTable("QV_SYS_SEL_EXCHANGE_LOG").HasKey(e => new
                {
                    e.SelId
                });

                entity.ToView("QV_SYS_SEL_EXCHANGE_LOG");

                entity.Property(e => e.SelCompany)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SEL_COMPANY");

                entity.Property(e => e.SelDate)
                    .HasColumnType("DATE")
                    .HasColumnName("SEL_DATE");

                entity.Property(e => e.SelDateAlt)
                    .HasColumnType("DATE")
                    .HasColumnName("SEL_DATE_ALT");

                entity.Property(e => e.SelId)
                    .HasPrecision(15)
                    .HasColumnName("SEL_ID");

                entity.Property(e => e.SelMessage)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SEL_MESSAGE");

                entity.Property(e => e.SelType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEL_TYPE");

                entity.Property(e => e.SelUserAlt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEL_USER_ALT");
            });

            modelBuilder.Entity<MvSysSehExchangeHost>(entity =>
            {
                entity.ToTable("MV_SYS_SEH_EXCHANGE_HOST").HasKey(e => new
                {
                    e.SehCompany
                });

                entity.ToView("MV_SYS_SEH_EXCHANGE_HOST");

                entity.Property(e => e.SehCompany)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SEH_COMPANY");

                entity.Property(e => e.SehDateAlt)
                    .HasColumnType("DATE")
                    .HasColumnName("SEH_DATE_ALT");

                entity.Property(e => e.SehFileProtocol)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SEH_FILE_PROTOCOL");

                entity.Property(e => e.SehHost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEH_HOST");

                entity.Property(e => e.SehPassword)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SEH_PASSWORD");

                entity.Property(e => e.SehPortFtp)
                    .HasPrecision(5)
                    .HasColumnName("SEH_PORT_FTP");

                entity.Property(e => e.SehUserAlt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEH_USER_ALT");

                entity.Property(e => e.SehUsername)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SEH_USERNAME");
            });

            modelBuilder.Entity<MvSysSeoExchangeOperation>(entity =>
            {
                entity.ToTable("MV_SYS_SEO_EXCHANGE_OPERATION").HasKey(e => new
                {
                    e.SeoOperation
                });

                entity.ToView("MV_SYS_SEO_EXCHANGE_OPERATION");

                entity.Property(e => e.SeoCompany)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("SEO_COMPANY");

                entity.Property(e => e.SeoDateAlt)
                    .HasColumnType("DATE")
                    .HasColumnName("SEO_DATE_ALT");

                entity.Property(e => e.SeoDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SEO_DESCRIPTION");

                entity.Property(e => e.SeoDestFtpUser)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SEO_DEST_FTP_USER");

                entity.Property(e => e.SeoDestHost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEO_DEST_HOST");

                entity.Property(e => e.SeoOperation)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEO_OPERATION");

                entity.Property(e => e.SeoSourceFtpUser)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SEO_SOURCE_FTP_USER");

                entity.Property(e => e.SeoSourceHost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SEO_SOURCE_HOST");

                entity.Property(e => e.SeoUserAlt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SEO_USER_ALT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

      
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
