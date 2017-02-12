using Microsoft.EntityFrameworkCore;
using AspNetCoreSPA.Model.POCOs;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AspNetCoreSPA.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<AgeGroup> AgeGroup { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Coefficient> Coefficient { get; set; }
        public virtual DbSet<Continent> Continent { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Destination> Destination { get; set; }
        public virtual DbSet<Home> Home { get; set; }
        public virtual DbSet<InsurancePackage> InsurancePackage { get; set; }
        public virtual DbSet<ItemsOfPackage> ItemsOfPackage { get; set; }
        public virtual DbSet<Pdv> Pdv { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }
        public virtual DbSet<Pricelist> Pricelist { get; set; }
        public virtual DbSet<PricelistItem> PricelistItem { get; set; }
        public virtual DbSet<RateOfPdv> RateOfPdv { get; set; }
        public virtual DbSet<Risk> Risk { get; set; }
        public virtual DbSet<RiskOfCar> RiskOfCar { get; set; }
        public virtual DbSet<RiskOfHouse> RiskOfHouse { get; set; }
        public virtual DbSet<SubjectOfInsurance> SubjectOfInsurance { get; set; }
        public virtual DbSet<TravelActivityTravelPurpose> TravelActivityTravelPurpose { get; set; }
        public virtual DbSet<TravelPurpose> TravelPurpose { get; set; }
        public virtual DbSet<TypeOfPackage> TypeOfPackage { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgeGroup>(entity =>
            {
                entity.HasKey(e => e.AgId)
                    .HasName("PK_AGE_GROUP");

                entity.ToTable("AGE_GROUP");

                entity.HasIndex(e => e.CoeffId)
                    .HasName("RELATIONSHIP_25_FK");

                entity.Property(e => e.AgId)
                    .HasColumnName("AG_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgNameEn)
                    .IsRequired()
                    .HasColumnName("AG_NAME_EN")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.AgNameSrb)
                    .HasColumnName("AG_NAME_SRB")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CoeffId).HasColumnName("COEFF_ID");

                entity.HasOne(d => d.Coeff)
                    .WithMany(p => p.AgeGroup)
                    .HasForeignKey(d => d.CoeffId)
                    .HasConstraintName("FK_AGE_GROU_RELATIONS_COEFFICI");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("CAR");

                entity.HasIndex(e => e.ClientId)
                    .HasName("RELATIONSHIP_34_FK");

                entity.Property(e => e.Carid).HasColumnName("CARID");

                entity.Property(e => e.CarEndDate)
                    .HasColumnName("CAR_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarModel)
                    .HasColumnName("CAR_MODEL")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CarStartDate)
                    .HasColumnName("CAR_START_DATE")
                    .HasColumnType("datetime");

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

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("CLIENT");

                entity.HasIndex(e => e.AgId)
                    .HasName("IS_FK");

                entity.HasIndex(e => e.PolicyId)
                    .HasName("RELATIONSHIP_22_FK");

                entity.Property(e => e.ClientId).HasColumnName("CLIENT_ID");

                entity.Property(e => e.AgId).HasColumnName("AG_ID");

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

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("PASSPORT_NUMBER")
                    .HasColumnType("numeric");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasColumnType("varchar(80)");

                entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Ag)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.AgId)
                    .HasConstraintName("FK_CLIENT_IS_AGE_GROU");

                entity.HasOne(d => d.Policy)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.PolicyId)
                    .HasConstraintName("FK_CLIENT_RELATIONS_POLICY");
            });

            modelBuilder.Entity<Coefficient>(entity =>
            {
                entity.HasKey(e => e.CoeffId)
                    .HasName("PK_COEFFICIENT");

                entity.ToTable("COEFFICIENT");

                entity.Property(e => e.CoeffId).HasColumnName("COEFF_ID");

                entity.Property(e => e.CoeffDate)
                    .HasColumnName("COEFF_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoeffValue)
                    .HasColumnName("COEFF_VALUE")
                    .HasColumnType("numeric");
            });

            modelBuilder.Entity<Continent>(entity =>
            {
                entity.ToTable("CONTINENT");

                entity.HasIndex(e => e.CoeffId)
                    .HasName("RELATIONSHIP_27_FK");

                entity.Property(e => e.ContinentId).HasColumnName("CONTINENT_ID");

                entity.Property(e => e.CoeffId).HasColumnName("COEFF_ID");

                entity.Property(e => e.ContinentNameEn)
                    .IsRequired()
                    .HasColumnName("CONTINENT_NAME_EN")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ContinentNameSrb)
                    .HasColumnName("CONTINENT_NAME_SRB")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Coeff)
                    .WithMany(p => p.Continent)
                    .HasForeignKey(d => d.CoeffId)
                    .HasConstraintName("FK_CONTINEN_RELATIONS_COEFFICI");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK_STATE_OF_ORIGIN");

                entity.ToTable("STATE_OF_ORIGIN");

                entity.HasIndex(e => e.ContinentId)
                    .HasName("RELATIONSHIP_41_FK");

                entity.Property(e => e.StId).HasColumnName("ST_ID");

                entity.Property(e => e.ContinentId).HasColumnName("CONTINENT_ID");

                entity.Property(e => e.StNameEn)
                    .HasColumnName("ST_NAME_EN")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StNameSrb)
                    .IsRequired()
                    .HasColumnName("ST_NAME_SRB")
                    .HasColumnType("varchar(30)");

                entity.HasOne(d => d.Continent)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.ContinentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_STATE_OF_RELATIONS_CONTINEN");
            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.HasKey(e => e.DstId)
                    .HasName("PK_DESTINATION");

                entity.ToTable("DESTINATION");

                entity.HasIndex(e => e.StId)
                    .HasName("RELATIONSHIP_42_FK");

                entity.Property(e => e.DstId).HasColumnName("DST_ID");

                entity.Property(e => e.DstDays).HasColumnName("DST_DAYS");

                entity.Property(e => e.StId).HasColumnName("ST_ID");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.Destination)
                    .HasForeignKey(d => d.StId)
                    .HasConstraintName("FK_DESTINAT_RELATIONS_STATE_OF");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("HOME");

                entity.Property(e => e.HomeId).HasColumnName("HOME_ID");

                entity.Property(e => e.HomeAddress)
                    .IsRequired()
                    .HasColumnName("HOME_ADDRESS")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.HomeBuildingYear)
                    .HasColumnName("HOME_BUILDING_YEAR")
                    .HasColumnType("datetime");

                entity.Property(e => e.HomeEndDate)
                    .HasColumnName("HOME_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.HomeSquares).HasColumnName("HOME_SQUARES");

                entity.Property(e => e.HomeStartDate)
                    .HasColumnName("HOME_START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.HomeValue).HasColumnName("HOME_VALUE");
            });

            modelBuilder.Entity<InsurancePackage>(entity =>
            {
                entity.HasKey(e => e.PackageId)
                    .HasName("PK_INSURANCE_PACKAGE");

                entity.ToTable("INSURANCE_PACKAGE");

                entity.HasIndex(e => e.PlItemId)
                    .HasName("RELATIONSHIP_36_FK");

                entity.HasIndex(e => e.TopId)
                    .HasName("RELATIONSHIP_26_FK");

                entity.Property(e => e.PackageId).HasColumnName("PACKAGE_ID");

                entity.Property(e => e.PackageDescriptionEn)
                    .HasColumnName("PACKAGE_DESCRIPTION_EN")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.PackageDescriptionSrb)
                    .HasColumnName("PACKAGE_DESCRIPTION_SRB")
                    .HasColumnType("varchar(5000)");

                entity.Property(e => e.PackageNameEn)
                    .HasColumnName("PACKAGE_NAME_EN")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PackageNameSrb)
                    .HasColumnName("PACKAGE_NAME_SRB")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PlItemId).HasColumnName("PL_ITEM_ID");

                entity.Property(e => e.TopId).HasColumnName("TOP_ID");

                entity.HasOne(d => d.PlItem)
                    .WithMany(p => p.InsurancePackage)
                    .HasForeignKey(d => d.PlItemId)
                    .HasConstraintName("FK_INSURANC_RELATIONS_PRICELIS");

                entity.HasOne(d => d.Top)
                    .WithMany(p => p.InsurancePackage)
                    .HasForeignKey(d => d.TopId)
                    .HasConstraintName("FK_INSURANC_RELATIONS_TYPE_OF_");
            });

            modelBuilder.Entity<ItemsOfPackage>(entity =>
            {
                entity.HasKey(e => e.IopAckageId)
                    .HasName("PK_ITEMS_OF_PACKAGE");

                entity.ToTable("ITEMS_OF_PACKAGE");

                entity.HasIndex(e => e.PackageId)
                    .HasName("RELATIONSHIP_32_FK");

                entity.Property(e => e.IopAckageId).HasColumnName("IOP_ACKAGE_ID");

                entity.Property(e => e.IofDescriptionEn)
                    .HasColumnName("IOF_DESCRIPTION_EN")
                    .HasColumnType("varchar(5000)");

                entity.Property(e => e.IofDesctiptionSrb)
                    .HasColumnName("IOF_DESCTIPTION_SRB")
                    .HasColumnType("varchar(5000)");

                entity.Property(e => e.IofNameEn)
                    .HasColumnName("IOF_NAME_EN")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IofNameSrb)
                    .HasColumnName("IOF_NAME_SRB")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PackageId).HasColumnName("PACKAGE_ID");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.ItemsOfPackage)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_ITEMS_OF_RELATIONS_INSURANC");
            });

            modelBuilder.Entity<Pdv>(entity =>
            {
                entity.ToTable("PDV");

                entity.Property(e => e.PdvId).HasColumnName("PDV_ID");

                entity.Property(e => e.NamePdv)
                    .HasColumnName("NAME_PDV")
                    .HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.ToTable("POLICY");

                entity.HasIndex(e => e.ClientId)
                    .HasName("OWNER_FK");

                entity.HasIndex(e => e.IiId)
                    .HasName("RELATIONSHIP_23_FK");

                entity.HasIndex(e => e.PackageId)
                    .HasName("RELATIONSHIP_30_FK");

                entity.HasIndex(e => e.PdvId)
                    .HasName("FOR_CALCTULATION_FK");

                entity.HasIndex(e => e.PlItemId)
                    .HasName("INSURANCE_PRICE_FK");

                entity.HasIndex(e => e.RId)
                    .HasName("POSSIBLE_RISK_FK");

                entity.Property(e => e.PolicyId).HasColumnName("POLICY_ID");

                entity.Property(e => e.ClientId).HasColumnName("CLIENT_ID");

                entity.Property(e => e.IiId).HasColumnName("II_ID");

                entity.Property(e => e.PackageId).HasColumnName("PACKAGE_ID");

                entity.Property(e => e.PdvId).HasColumnName("PDV_ID");

                entity.Property(e => e.PlItemId).HasColumnName("PL_ITEM_ID");

                entity.Property(e => e.PolicyDstEndOfInsurance)
                    .HasColumnName("POLICY_DST_END_OF_INSURANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PolicyStartOfInsurance)
                    .HasColumnName("POLICY_START_OF_INSURANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.RId).HasColumnName("R_ID");

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.PolicyNavigation)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_OWNER_CLIENT");

                entity.HasOne(d => d.Ii)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.IiId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_RELATIONS_SUBJECT_");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_POLICY_RELATIONS_INSURANC");

                entity.HasOne(d => d.Pdv)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.PdvId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_FOR_CALCT_PDV");

                entity.HasOne(d => d.PlItem)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.PlItemId)
                    .HasConstraintName("FK_POLICY_INSURANCE_PRICELIS");

                entity.HasOne(d => d.R)
                    .WithMany(p => p.Policy)
                    .HasForeignKey(d => d.RId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POLICY_POSSIBLE__RISK");
            });

            modelBuilder.Entity<Pricelist>(entity =>
            {
                entity.ToTable("PRICELIST");

                entity.Property(e => e.PricelistId).HasColumnName("PRICELIST_ID");

                entity.Property(e => e.PricelistEndDate)
                    .HasColumnName("PRICELIST_END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PricelistStartDate)
                    .HasColumnName("PRICELIST_START_DATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PricelistItem>(entity =>
            {
                entity.HasKey(e => e.PlItemId)
                    .HasName("PK_PRICELIST_ITEM");

                entity.ToTable("PRICELIST_ITEM");

                entity.HasIndex(e => e.PricelistId)
                    .HasName("RELATIONSHIP_21_FK");

                entity.Property(e => e.PlItemId).HasColumnName("PL_ITEM_ID");

                entity.Property(e => e.PlPrice)
                    .HasColumnName("PL_PRICE")
                    .HasColumnType("numeric");

                entity.Property(e => e.PricelistId).HasColumnName("PRICELIST_ID");

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

                entity.Property(e => e.PdvRateId).HasColumnName("PDV_RATE_ID");

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
                entity.HasKey(e => e.RId)
                    .HasName("PK_RISK");

                entity.ToTable("RISK");

                entity.HasIndex(e => e.CoeffId)
                    .HasName("RELATIONSHIP_40_FK");

                entity.Property(e => e.RId).HasColumnName("R_ID");

                entity.Property(e => e.CoeffId).HasColumnName("COEFF_ID");

                entity.Property(e => e.RDescriptionEn)
                    .IsRequired()
                    .HasColumnName("R_DESCRIPTION_EN")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.RDescriptionSrb)
                    .HasColumnName("R_DESCRIPTION_SRB")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.RNameEn)
                    .IsRequired()
                    .HasColumnName("R_NAME_EN")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.RNameSrb)
                    .HasColumnName("R_NAME_SRB")
                    .HasColumnType("varchar(30)");

                entity.HasOne(d => d.Coeff)
                    .WithMany(p => p.Risk)
                    .HasForeignKey(d => d.CoeffId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RISK_RELATIONS_COEFFICI");
            });

            modelBuilder.Entity<RiskOfCar>(entity =>
            {
                entity.HasKey(e => e.RocId)
                    .HasName("PK_RISK_OF_CAR");

                entity.ToTable("RISK_OF_CAR");

                entity.HasIndex(e => e.Carid)
                    .HasName("RISK_OF_CAR_FK");

                entity.HasIndex(e => e.RId)
                    .HasName("RISK_OF_CAR2_FK");

                entity.Property(e => e.RocId)
                    .HasColumnName("ROC_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Carid).HasColumnName("CARID");

                entity.Property(e => e.RId).HasColumnName("R_ID");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.RiskOfCar)
                    .HasForeignKey(d => d.Carid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RISK_OF__RISK_OF_C_CAR");

                entity.HasOne(d => d.R)
                    .WithMany(p => p.RiskOfCar)
                    .HasForeignKey(d => d.RId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RISK_OF__RISK_OF_C_RISK");
            });

            modelBuilder.Entity<RiskOfHouse>(entity =>
            {
                entity.HasKey(e => e.RohId)
                    .HasName("PK_RISK_OF_HOUSE");

                entity.ToTable("RISK_OF_HOUSE");

                entity.HasIndex(e => e.HomeId)
                    .HasName("RISK_OF_HOUSE2_FK");

                entity.HasIndex(e => e.RId)
                    .HasName("RISK_OF_HOUSE_FK");

                entity.Property(e => e.RohId)
                    .HasColumnName("ROH_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HomeId).HasColumnName("HOME_ID");

                entity.Property(e => e.RId).HasColumnName("R_ID");

                entity.HasOne(d => d.Home)
                    .WithMany(p => p.RiskOfHouse)
                    .HasForeignKey(d => d.HomeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RISK_OF__RISK_OF_H_HOME");

                entity.HasOne(d => d.R)
                    .WithMany(p => p.RiskOfHouse)
                    .HasForeignKey(d => d.RId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RISK_OF__RISK_OF_H_RISK");
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

                entity.HasIndex(e => e.TpId)
                    .HasName("RELATIONSHIP_31_FK");

                entity.Property(e => e.IiId).HasColumnName("II_ID");

                entity.Property(e => e.Carid).HasColumnName("CARID");

                entity.Property(e => e.DstId).HasColumnName("DST_ID");

                entity.Property(e => e.HomeId).HasColumnName("HOME_ID");

                entity.Property(e => e.TpId).HasColumnName("TP_ID");

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

                entity.HasOne(d => d.Tp)
                    .WithMany(p => p.SubjectOfInsurance)
                    .HasForeignKey(d => d.TpId)
                    .HasConstraintName("FK_SUBJECT__RELATIONS_TRAVEL_P");
            });

            modelBuilder.Entity<TravelActivityTravelPurpose>(entity =>
            {
                entity.HasKey(e => e.TpRId)
                    .HasName("PK_TRAVEL_ACTIVITY_TRAVEL_PURP");

                entity.ToTable("TRAVEL_ACTIVITY_TRAVEL_PURPOSE");

                entity.HasIndex(e => e.RId)
                    .HasName("TRAVEL_ACTIVITY_TRAVEL_PURPOSE_FK");

                entity.HasIndex(e => e.TpId)
                    .HasName("TRAVEL_ACTIVITY_TRAVEL_PURPOSE2_FK");

                entity.Property(e => e.TpRId).HasColumnName("TP_R_ID");

                entity.Property(e => e.RId).HasColumnName("R_ID");

                entity.Property(e => e.TpId).HasColumnName("TP_ID");

                entity.HasOne(d => d.R)
                    .WithMany(p => p.TravelActivityTravelPurpose)
                    .HasForeignKey(d => d.RId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TRAVEL_A_TRAVEL_AC_RISK");

                entity.HasOne(d => d.Tp)
                    .WithMany(p => p.TravelActivityTravelPurpose)
                    .HasForeignKey(d => d.TpId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TRAVEL_A_TRAVEL_AC_TRAVEL_P");
            });

            modelBuilder.Entity<TravelPurpose>(entity =>
            {
                entity.HasKey(e => e.TpId)
                    .HasName("PK_TRAVEL_PURPOSE");

                entity.ToTable("TRAVEL_PURPOSE");

                entity.HasIndex(e => e.PackageId)
                    .HasName("RELATIONSHIP_24_FK");

                entity.Property(e => e.TpId).HasColumnName("TP_ID");

                entity.Property(e => e.PackageId).HasColumnName("PACKAGE_ID");

                entity.Property(e => e.TpNameEn)
                    .IsRequired()
                    .HasColumnName("TP_NAME_EN")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TpNameSrb)
                    .HasColumnName("TP_NAME_SRB")
                    .HasColumnType("varchar(30)");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TravelPurpose)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TRAVEL_P_RELATIONS_INSURANC");
            });

            modelBuilder.Entity<TypeOfPackage>(entity =>
            {
                entity.HasKey(e => e.TopId)
                    .HasName("PK_TYPE_OF_PACKAGE");

                entity.ToTable("TYPE_OF_PACKAGE");

                entity.Property(e => e.TopId).HasColumnName("TOP_ID");

                entity.Property(e => e.TopName)
                    .HasColumnName("TOP_NAME")
                    .HasColumnType("varchar(100)");
            });
        }
    }
}
