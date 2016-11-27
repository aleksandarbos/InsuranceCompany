using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InsuranceCompany.Models
{
    public partial class InsuranceCompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=InsuranceCompanyModel;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("BANK");

                entity.Property(e => e.BankId)
                    .HasColumnName("BANK_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnName("BANK_NAME")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.HasKey(e => e.Ac1Id)
                    .HasName("PK_BANK_ACCOUNT");

                entity.ToTable("BANK_ACCOUNT");

                entity.HasIndex(e => e.BankId)
                    .HasName("OF_FK");

                entity.HasIndex(e => e.ClientId)
                    .HasName("CLIENT_ACCOUNT_FK");

                entity.HasIndex(e => e.CpId)
                    .HasName("RELATIONSHIP_19_FK");

                entity.Property(e => e.Ac1Id)
                    .HasColumnName("AC1_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BankId).HasColumnName("BANK_ID");

                entity.Property(e => e.ClientId).HasColumnName("CLIENT_ID");

                entity.Property(e => e.CpId).HasColumnName("CP_ID");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.BankAccount)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BANK_ACC_OF_BANK");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.BankAccount)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BANK_ACC_CLIENT_AC_CLIENT");

                entity.HasOne(d => d.Cp)
                    .WithMany(p => p.BankAccount)
                    .HasForeignKey(d => d.CpId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BANK_ACC_RELATIONS_INSURANC");
            });

            modelBuilder.Entity<BusinessYear>(entity =>
            {
                entity.HasKey(e => e.YearId)
                    .HasName("PK_BUSINESS_YEAR");

                entity.ToTable("BUSINESS_YEAR");

                entity.HasIndex(e => e.CpId)
                    .HasName("RELATIONSHIP_28_FK");

                entity.Property(e => e.YearId)
                    .HasColumnName("YEAR_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CpId).HasColumnName("CP_ID");

                entity.HasOne(d => d.Cp)
                    .WithMany(p => p.BusinessYear)
                    .HasForeignKey(d => d.CpId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BUSINESS_RELATIONS_INSURANC");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("CAR");

                entity.HasIndex(e => e.ClientId)
                    .HasName("RELATIONSHIP_40_FK");

                entity.Property(e => e.Carid)
                    .HasColumnName("CARID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarModel)
                    .HasColumnName("CAR_MODEL")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CarType)
                    .HasColumnName("CAR_TYPE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ChassisNumber).HasColumnName("CHASSIS_NUMBER");

                entity.Property(e => e.ClientId).HasColumnName("CLIENT_ID");

                entity.Property(e => e.LicencePlate)
                    .HasColumnName("LICENCE_PLATE")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CAR_RELATIONS_CLIENT");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("CITY");

                entity.HasIndex(e => e.StId)
                    .HasName("IS_SITUATED_IN_FK");

                entity.Property(e => e.CityId)
                    .HasColumnName("CITY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("CITY_NAME")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.StId).HasColumnName("ST_ID");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.StId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CITY_IS_SITUAT_STATE_OF");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("CLIENT");

                entity.HasIndex(e => e.CtId)
                    .HasName("IS_FK");

                entity.HasIndex(e => e.PolicyId)
                    .HasName("RELATIONSHIP_22_FK");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CtId).HasColumnName("CT_ID");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("DATE_OF_BIRTH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Jmbg)
                    .IsRequired()
                    .HasColumnName("JMBG")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("LASTNAME")
                    .HasColumnType("varchar(70)");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.CtId)
                    .HasConstraintName("FK_CLIENT_IS_TYPE_OF_");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.PolicyId)
                    .HasConstraintName("FK_CLIENT_RELATIONS_POLICY");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("CURRENCY");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CURRENCY_ID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.HasKey(e => e.DstId)
                    .HasName("PK_DESTINATION");

                entity.ToTable("DESTINATION");

                entity.Property(e => e.DstId)
                    .HasColumnName("DST_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DstDays).HasColumnName("DST_DAYS");

                entity.Property(e => e.DstName)
                    .IsRequired()
                    .HasColumnName("DST_NAME")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EnId)
                    .HasName("PK_EMPLOYEE");

                entity.ToTable("EMPLOYEE");

                entity.HasIndex(e => e.CpId)
                    .HasName("RELATIONSHIP_18_FK");

                entity.HasIndex(e => e.RoleId)
                    .HasName("RESPONSIBLE_FOR_FK");

                entity.Property(e => e.EnId)
                    .HasColumnName("EN_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CpId).HasColumnName("CP_ID");

                entity.Property(e => e.EnFirstname)
                    .IsRequired()
                    .HasColumnName("EN_FIRSTNAME")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.EnLastname)
                    .IsRequired()
                    .HasColumnName("EN_LASTNAME")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.HasOne(d => d.Cp)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.CpId)
                    .HasConstraintName("FK_EMPLOYEE_RELATIONS_INSURANC");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EMPLOYEE_RESPONSIB_EMPLOYEE");
            });

            modelBuilder.Entity<EmployeeRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_EMPLOYEE_ROLE");

                entity.ToTable("EMPLOYEE_ROLE");

                entity.Property(e => e.RoleId)
                    .HasColumnName("ROLE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("ROLE_NAME")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("HOME");

                entity.HasIndex(e => e.HtId)
                    .HasName("RELATIONSHIP_26_FK");

                entity.Property(e => e.HomeId)
                    .HasColumnName("HOME_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HomeAddress)
                    .IsRequired()
                    .HasColumnName("HOME_ADDRESS")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.HomeBuildingYear)
                    .HasColumnName("HOME_BUILDING_YEAR")
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.HomeSquares).HasColumnName("HOME_SQUARES");

                entity.Property(e => e.HtId).HasColumnName("HT_ID");

                entity.HasOne(d => d.Ht)
                    .WithMany(p => p.Home)
                    .HasForeignKey(d => d.HtId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_HOME_RELATIONS_TYPE_OF_");
            });

            modelBuilder.Entity<InsuranceCompanyModel>(entity =>
            {
                entity.HasKey(e => e.CpId)
                    .HasName("PK_INSURANCE_COMPANY");

                entity.ToTable("INSURANCE_COMPANY");

                entity.HasIndex(e => e.CityId)
                    .HasName("IS_FROM_FK");

                entity.Property(e => e.CpId)
                    .HasColumnName("CP_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("CITY_ID");

                entity.Property(e => e.CpName)
                    .HasColumnName("CP_NAME")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Pib).HasColumnName("PIB");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.InsuranceCompany)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_INSURANC_IS_FROM_CITY");
            });

            modelBuilder.Entity<ItemsOfPackage>(entity =>
            {
                entity.ToTable("ITEMS_OF_PACKAGE");

                entity.HasIndex(e => e.PackageId)
                    .HasName("RELATIONSHIP_32_FK");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PackageId).HasColumnName("PACKAGE_ID");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.ItemsOfPackage)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_ITEMS_OF_RELATIONS_PACKAGE");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.ToTable("PACKAGE");

                entity.Property(e => e.PackageId)
                    .HasColumnName("PACKAGE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Pdv>(entity =>
            {
                entity.ToTable("PDV");

                entity.Property(e => e.PdvId)
                    .HasColumnName("PDV_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NamePdv)
                    .HasColumnName("NAME_PDV")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.ToTable("POLICY");

                entity.HasIndex(e => e.ClientId)
                    .HasName("OWNER_FK");

                entity.HasIndex(e => e.CpId)
                    .HasName("HANDS_OUT_FK");

                entity.HasIndex(e => e.CurrencyId)
                    .HasName("CURENT_FK");

                entity.HasIndex(e => e.EnId)
                    .HasName("IN_CHARGE_OF_FK");

                entity.HasIndex(e => e.IiId)
                    .HasName("RELATIONSHIP_23_FK");

                entity.HasIndex(e => e.PackageId)
                    .HasName("RELATIONSHIP_30_FK");

                entity.HasIndex(e => e.PdvId)
                    .HasName("FOR_CALCTULATION_FK");

                entity.HasIndex(e => e.RtId)
                    .HasName("POSSIBLE_RISK_FK");

                entity.HasIndex(e => e.YearId)
                    .HasName("RELATIONSHIP_29_FK");

                entity.Property(e => e.PolicyId)
                    .HasColumnName("POLICY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("CLIENT_ID");

                entity.Property(e => e.CpId).HasColumnName("CP_ID");

                entity.Property(e => e.CurrencyId).HasColumnName("CURRENCY_ID");

                entity.Property(e => e.EnId).HasColumnName("EN_ID");

                entity.Property(e => e.IiId).HasColumnName("II_ID");

                entity.Property(e => e.PackageId).HasColumnName("PACKAGE_ID");

                entity.Property(e => e.PdvId).HasColumnName("PDV_ID");

                entity.Property(e => e.PolicyDstEndOfInsurance)
                    .HasColumnName("POLICY_DST_END_OF_INSURANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PolicyStartOfInsurance)
                    .HasColumnName("POLICY_START_OF_INSURANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RtId).HasColumnName("RT_ID");

                entity.Property(e => e.YearId).HasColumnName("YEAR_ID");

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.PolicyNavigation)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_OWNER_CLIENT");

                entity.HasOne(d => d.Cp)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.CpId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_HANDS_OUT_INSURANC");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_CURENT_CURRENCY");

                entity.HasOne(d => d.En)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.EnId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_IN_CHARGE_EMPLOYEE");

                entity.HasOne(d => d.Ii)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.IiId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_RELATIONS_SUBJECT_");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_POLICY_RELATIONS_PACKAGE");

                entity.HasOne(d => d.Pdv)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.PdvId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_FOR_CALCT_PDV");

                entity.HasOne(d => d.Rt)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.RtId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_POSSIBLE__RISK");

                entity.HasOne(d => d.Year)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.YearId)
                    .HasConstraintName("FK_POLICY_RELATIONS_BUSINESS");
            });

            modelBuilder.Entity<Pricelist>(entity =>
            {
                entity.ToTable("PRICELIST");

                entity.HasIndex(e => e.CpId)
                    .HasName("BELONGS_TO_FK");

                entity.Property(e => e.PricelistId)
                    .HasColumnName("PRICELIST_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CpId).HasColumnName("CP_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Cp)
                    .WithMany(p => p.Pricelist)
                    .HasForeignKey(d => d.CpId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PRICELIS_BELONGS_T_INSURANC");
            });

            modelBuilder.Entity<PricelistItem>(entity =>
            {
                entity.HasKey(e => e.PlItemId)
                    .HasName("PK_PRICELIST_ITEM");

                entity.ToTable("PRICELIST_ITEM");

                entity.HasIndex(e => e.PackageId)
                    .HasName("RELATIONSHIP_36_FK");

                entity.HasIndex(e => e.PricelistId)
                    .HasName("RELATIONSHIP_21_FK");

                entity.Property(e => e.PlItemId)
                    .HasColumnName("PL_ITEM_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PackageId).HasColumnName("PACKAGE_ID");

                entity.Property(e => e.PricelistId).HasColumnName("PRICELIST_ID");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PricelistItem)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_PRICELIS_RELATIONS_PACKAGE");

                entity.HasOne(d => d.Pricelist)
                    .WithMany(p => p.PricelistItem)
                    .HasForeignKey(d => d.PricelistId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PRICELIS_RELATIONS_PRICELIS");
            });

            modelBuilder.Entity<RateOfPdv>(entity =>
            {
                entity.HasKey(e => e.PdvRateId)
                    .HasName("PK_RATE_OF_PDV");

                entity.ToTable("RATE_OF_PDV");

                entity.HasIndex(e => e.PdvId)
                    .HasName("IN_NEED_FK");

                entity.Property(e => e.PdvRateId)
                    .HasColumnName("PDV_RATE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PdvId).HasColumnName("PDV_ID");

                entity.Property(e => e.Rate)
                    .HasColumnName("RATE")
                    .HasColumnType("numeric");

                entity.Property(e => e.ValidUntil)
                    .HasColumnName("VALID_UNTIL")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Pdv)
                    .WithMany(p => p.RateOfPdv)
                    .HasForeignKey(d => d.PdvId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RATE_OF__IN_NEED_PDV");
            });

            modelBuilder.Entity<Risk>(entity =>
            {
                entity.HasKey(e => e.RtId)
                    .HasName("PK_RISK");

                entity.ToTable("RISK");

                entity.Property(e => e.RtId)
                    .HasColumnName("RT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RtCoefficient)
                    .HasColumnName("RT_COEFFICIENT")
                    .HasColumnType("numeric");

                entity.Property(e => e.RtName)
                    .IsRequired()
                    .HasColumnName("RT_NAME")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<RiskTypeOfInsurance>(entity =>
            {
                entity.HasKey(e => new { e.RtId, e.ItId })
                    .HasName("PK_RISK_TYPE_OF_INSURANCE");

                entity.ToTable("RISK_TYPE_OF_INSURANCE");

                entity.HasIndex(e => e.ItId)
                    .HasName("RELATIONSHIP_34_FK");

                entity.HasIndex(e => e.RtId)
                    .HasName("RELATIONSHIP_33_FK");

                entity.Property(e => e.RtId).HasColumnName("RT_ID");

                entity.Property(e => e.ItId).HasColumnName("IT_ID");

                entity.HasOne(d => d.It)
                    .WithMany(p => p.RiskTypeOfInsurance)
                    .HasForeignKey(d => d.ItId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RISK_TYP_RELATIONS_TYPE_OF_");

                entity.HasOne(d => d.Rt)
                    .WithMany(p => p.RiskTypeOfInsurance)
                    .HasForeignKey(d => d.RtId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RISK_TYP_RELATIONS_RISK");
            });

            modelBuilder.Entity<StateOfOrigin>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK_STATE_OF_ORIGIN");

                entity.ToTable("STATE_OF_ORIGIN");

                entity.Property(e => e.StId)
                    .HasColumnName("ST_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StName)
                    .IsRequired()
                    .HasColumnName("ST_NAME")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<SubjectOfInsurance>(entity =>
            {
                entity.HasKey(e => e.IiId)
                    .HasName("PK_SUBJECT_OF_INSURANCE");

                entity.ToTable("SUBJECT_OF_INSURANCE");

                entity.HasIndex(e => e.Carid)
                    .HasName("RELATIONSHIP_39_FK");

                entity.HasIndex(e => e.DstId)
                    .HasName("RELATIONSHIP_37_FK");

                entity.HasIndex(e => e.HomeId)
                    .HasName("RELATIONSHIP_38_FK");

                entity.HasIndex(e => e.ItId)
                    .HasName("RELATIONSHIP_31_FK");

                entity.Property(e => e.IiId)
                    .HasColumnName("II_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Carid).HasColumnName("CARID");

                entity.Property(e => e.DstId).HasColumnName("DST_ID");

                entity.Property(e => e.HomeId).HasColumnName("HOME_ID");

                entity.Property(e => e.ItId).HasColumnName("IT_ID");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.SubjectOfInsurance)
                    .HasForeignKey(d => d.Carid)
                    .HasConstraintName("FK_SUBJECT__RELATIONS_CAR");

                entity.HasOne(d => d.Dst)
                    .WithMany(p => p.SubjectOfInsurance)
                    .HasForeignKey(d => d.DstId)
                    .HasConstraintName("FK_SUBJECT__RELATIONS_DESTINAT");

                entity.HasOne(d => d.Home)
                    .WithMany(p => p.SubjectOfInsurance)
                    .HasForeignKey(d => d.HomeId)
                    .HasConstraintName("FK_SUBJECT__RELATIONS_HOME");

                entity.HasOne(d => d.It)
                    .WithMany(p => p.SubjectOfInsurance)
                    .HasForeignKey(d => d.ItId)
                    .HasConstraintName("FK_SUBJECT__RELATIONS_TYPE_OF_");
            });

            modelBuilder.Entity<TypeOfClient>(entity =>
            {
                entity.HasKey(e => e.CtId)
                    .HasName("PK_TYPE_OF_CLIENT");

                entity.ToTable("TYPE_OF_CLIENT");

                entity.Property(e => e.CtId)
                    .HasColumnName("CT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CtName)
                    .IsRequired()
                    .HasColumnName("CT_NAME")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<TypeOfHome>(entity =>
            {
                entity.HasKey(e => e.HtId)
                    .HasName("PK_TYPE_OF_HOME");

                entity.ToTable("TYPE_OF_HOME");

                entity.Property(e => e.HtId)
                    .HasColumnName("HT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HtName)
                    .IsRequired()
                    .HasColumnName("HT_NAME")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<TypeOfInsurance>(entity =>
            {
                entity.HasKey(e => e.ItId)
                    .HasName("PK_TYPE_OF_INSURANCE");

                entity.ToTable("TYPE_OF_INSURANCE");

                entity.HasIndex(e => e.PackageId)
                    .HasName("RELATIONSHIP_24_FK");

                entity.Property(e => e.ItId)
                    .HasColumnName("IT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItName)
                    .IsRequired()
                    .HasColumnName("IT_NAME")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.PackageId).HasColumnName("PACKAGE_ID");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TypeOfInsurance)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TYPE_OF__RELATIONS_PACKAGE");
            });

            modelBuilder.Entity<TypeOfRisk>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PK_TYPE_OF_RISK");

                entity.ToTable("TYPE_OF_RISK");

                entity.HasIndex(e => e.RtId)
                    .HasName("RELATIONSHIP_35_FK");

                entity.Property(e => e.IdType)
                    .HasColumnName("ID_TYPE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RtId).HasColumnName("RT_ID");

                entity.HasOne(d => d.Rt)
                    .WithMany(p => p.TypeOfRisk)
                    .HasForeignKey(d => d.RtId)
                    .HasConstraintName("FK_TYPE_OF__RELATIONS_RISK");
            });
        }

        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankAccount> BankAccount { get; set; }
        public virtual DbSet<BusinessYear> BusinessYear { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Destination> Destination { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRole { get; set; }
        public virtual DbSet<Home> Home { get; set; }
        public virtual DbSet<InsuranceCompanyModel> InsuranceCompany { get; set; }
        public virtual DbSet<ItemsOfPackage> ItemsOfPackage { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<Pdv> Pdv { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }
        public virtual DbSet<Pricelist> Pricelist { get; set; }
        public virtual DbSet<PricelistItem> PricelistItem { get; set; }
        public virtual DbSet<RateOfPdv> RateOfPdv { get; set; }
        public virtual DbSet<Risk> Risk { get; set; }
        public virtual DbSet<RiskTypeOfInsurance> RiskTypeOfInsurance { get; set; }
        public virtual DbSet<StateOfOrigin> StateOfOrigin { get; set; }
        public virtual DbSet<SubjectOfInsurance> SubjectOfInsurance { get; set; }
        public virtual DbSet<TypeOfClient> TypeOfClient { get; set; }
        public virtual DbSet<TypeOfHome> TypeOfHome { get; set; }
        public virtual DbSet<TypeOfInsurance> TypeOfInsurance { get; set; }
        public virtual DbSet<TypeOfRisk> TypeOfRisk { get; set; }
    }
}