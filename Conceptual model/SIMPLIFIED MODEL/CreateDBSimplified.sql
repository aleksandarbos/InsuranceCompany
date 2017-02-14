/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2014                    */
/* Created on:     2/7/2017 4:57:18 PM                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AGE_GROUP') and o.name = 'FK_AGE_GROU_RELATIONS_COEFFICI')
alter table AGE_GROUP
   drop constraint FK_AGE_GROU_RELATIONS_COEFFICI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CAR') and o.name = 'FK_CAR_RELATIONS_CLIENT')
alter table CAR
   drop constraint FK_CAR_RELATIONS_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENT') and o.name = 'FK_CLIENT_IS_AGE_GROU')
alter table CLIENT
   drop constraint FK_CLIENT_IS_AGE_GROU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENT') and o.name = 'FK_CLIENT_RELATIONS_POLICY')
alter table CLIENT
   drop constraint FK_CLIENT_RELATIONS_POLICY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONTINENT') and o.name = 'FK_CONTINEN_RELATIONS_COEFFICI')
alter table CONTINENT
   drop constraint FK_CONTINEN_RELATIONS_COEFFICI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DESTINATION') and o.name = 'FK_DESTINAT_RELATIONS_STATE_OF')
alter table DESTINATION
   drop constraint FK_DESTINAT_RELATIONS_STATE_OF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INSURANCE_PACKAGE') and o.name = 'FK_INSURANC_RELATIONS_TYPE_OF_')
alter table INSURANCE_PACKAGE
   drop constraint FK_INSURANC_RELATIONS_TYPE_OF_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INSURANCE_PACKAGE') and o.name = 'FK_INSURANC_RELATIONS_PRICELIS')
alter table INSURANCE_PACKAGE
   drop constraint FK_INSURANC_RELATIONS_PRICELIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITEMS_OF_PACKAGE') and o.name = 'FK_ITEMS_OF_RELATIONS_INSURANC')
alter table ITEMS_OF_PACKAGE
   drop constraint FK_ITEMS_OF_RELATIONS_INSURANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_FOR_CALCT_PDV')
alter table POLICY
   drop constraint FK_POLICY_FOR_CALCT_PDV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_INSURANCE_PRICELIS')
alter table POLICY
   drop constraint FK_POLICY_INSURANCE_PRICELIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_OWNER_CLIENT')
alter table POLICY
   drop constraint FK_POLICY_OWNER_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_POSSIBLE__RISK')
alter table POLICY
   drop constraint FK_POLICY_POSSIBLE__RISK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_RELATIONS_SUBJECT_')
alter table POLICY
   drop constraint FK_POLICY_RELATIONS_SUBJECT_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_RELATIONS_INSURANC')
alter table POLICY
   drop constraint FK_POLICY_RELATIONS_INSURANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRICELIST_ITEM') and o.name = 'FK_PRICELIS_RELATIONS_PRICELIS')
alter table PRICELIST_ITEM
   drop constraint FK_PRICELIS_RELATIONS_PRICELIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RATE_OF_PDV') and o.name = 'FK_RATE_OF__IN_NEED_PDV')
alter table RATE_OF_PDV
   drop constraint FK_RATE_OF__IN_NEED_PDV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RISK') and o.name = 'FK_RISK_RELATIONS_COEFFICI')
alter table RISK
   drop constraint FK_RISK_RELATIONS_COEFFICI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RISK_OF_CAR') and o.name = 'FK_RISK_OF__RISK_OF_C_CAR')
alter table RISK_OF_CAR
   drop constraint FK_RISK_OF__RISK_OF_C_CAR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RISK_OF_CAR') and o.name = 'FK_RISK_OF__RISK_OF_C_RISK')
alter table RISK_OF_CAR
   drop constraint FK_RISK_OF__RISK_OF_C_RISK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RISK_OF_HOUSE') and o.name = 'FK_RISK_OF__RISK_OF_H_RISK')
alter table RISK_OF_HOUSE
   drop constraint FK_RISK_OF__RISK_OF_H_RISK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RISK_OF_HOUSE') and o.name = 'FK_RISK_OF__RISK_OF_H_HOME')
alter table RISK_OF_HOUSE
   drop constraint FK_RISK_OF__RISK_OF_H_HOME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STATE_OF_ORIGIN') and o.name = 'FK_STATE_OF_RELATIONS_CONTINEN')
alter table STATE_OF_ORIGIN
   drop constraint FK_STATE_OF_RELATIONS_CONTINEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUBJECT_OF_INSURANCE') and o.name = 'FK_SUBJECT__RELATIONS_TRAVEL_P')
alter table SUBJECT_OF_INSURANCE
   drop constraint FK_SUBJECT__RELATIONS_TRAVEL_P
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUBJECT_OF_INSURANCE') and o.name = 'FK_SUBJECT__RELATIONS_DESTINAT')
alter table SUBJECT_OF_INSURANCE
   drop constraint FK_SUBJECT__RELATIONS_DESTINAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUBJECT_OF_INSURANCE') and o.name = 'FK_SUBJECT__RELATIONS_HOME')
alter table SUBJECT_OF_INSURANCE
   drop constraint FK_SUBJECT__RELATIONS_HOME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUBJECT_OF_INSURANCE') and o.name = 'FK_SUBJECT__RELATIONS_CAR')
alter table SUBJECT_OF_INSURANCE
   drop constraint FK_SUBJECT__RELATIONS_CAR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAVEL_ACTIVITY_TRAVEL_PURPOSE') and o.name = 'FK_TRAVEL_A_TRAVEL_AC_RISK')
alter table TRAVEL_ACTIVITY_TRAVEL_PURPOSE
   drop constraint FK_TRAVEL_A_TRAVEL_AC_RISK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAVEL_ACTIVITY_TRAVEL_PURPOSE') and o.name = 'FK_TRAVEL_A_TRAVEL_AC_TRAVEL_P')
alter table TRAVEL_ACTIVITY_TRAVEL_PURPOSE
   drop constraint FK_TRAVEL_A_TRAVEL_AC_TRAVEL_P
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAVEL_PURPOSE') and o.name = 'FK_TRAVEL_P_RELATIONS_INSURANC')
alter table TRAVEL_PURPOSE
   drop constraint FK_TRAVEL_P_RELATIONS_INSURANC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AGE_GROUP')
            and   name  = 'RELATIONSHIP_25_FK'
            and   indid > 0
            and   indid < 255)
   drop index AGE_GROUP.RELATIONSHIP_25_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AGE_GROUP')
            and   type = 'U')
   drop table AGE_GROUP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CAR')
            and   name  = 'RELATIONSHIP_34_FK'
            and   indid > 0
            and   indid < 255)
   drop index CAR.RELATIONSHIP_34_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CAR')
            and   type = 'U')
   drop table CAR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENT')
            and   name  = 'RELATIONSHIP_22_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENT.RELATIONSHIP_22_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CLIENT')
            and   name  = 'IS_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENT.IS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLIENT')
            and   type = 'U')
   drop table CLIENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('COEFFICIENT')
            and   type = 'U')
   drop table COEFFICIENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CONTINENT')
            and   name  = 'RELATIONSHIP_27_FK'
            and   indid > 0
            and   indid < 255)
   drop index CONTINENT.RELATIONSHIP_27_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CONTINENT')
            and   type = 'U')
   drop table CONTINENT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DESTINATION')
            and   name  = 'RELATIONSHIP_42_FK'
            and   indid > 0
            and   indid < 255)
   drop index DESTINATION.RELATIONSHIP_42_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DESTINATION')
            and   type = 'U')
   drop table DESTINATION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOME')
            and   type = 'U')
   drop table HOME
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INSURANCE_PACKAGE')
            and   name  = 'RELATIONSHIP_26_FK'
            and   indid > 0
            and   indid < 255)
   drop index INSURANCE_PACKAGE.RELATIONSHIP_26_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('INSURANCE_PACKAGE')
            and   name  = 'RELATIONSHIP_36_FK'
            and   indid > 0
            and   indid < 255)
   drop index INSURANCE_PACKAGE.RELATIONSHIP_36_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INSURANCE_PACKAGE')
            and   type = 'U')
   drop table INSURANCE_PACKAGE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ITEMS_OF_PACKAGE')
            and   name  = 'RELATIONSHIP_32_FK'
            and   indid > 0
            and   indid < 255)
   drop index ITEMS_OF_PACKAGE.RELATIONSHIP_32_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITEMS_OF_PACKAGE')
            and   type = 'U')
   drop table ITEMS_OF_PACKAGE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PDV')
            and   type = 'U')
   drop table PDV
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('POLICY')
            and   name  = 'INSURANCE_PRICE_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.INSURANCE_PRICE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('POLICY')
            and   name  = 'RELATIONSHIP_30_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.RELATIONSHIP_30_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('POLICY')
            and   name  = 'RELATIONSHIP_23_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.RELATIONSHIP_23_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('POLICY')
            and   name  = 'FOR_CALCTULATION_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.FOR_CALCTULATION_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('POLICY')
            and   name  = 'POSSIBLE_RISK_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.POSSIBLE_RISK_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('POLICY')
            and   name  = 'OWNER_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.OWNER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('POLICY')
            and   type = 'U')
   drop table POLICY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRICELIST')
            and   type = 'U')
   drop table PRICELIST
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRICELIST_ITEM')
            and   name  = 'RELATIONSHIP_21_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRICELIST_ITEM.RELATIONSHIP_21_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRICELIST_ITEM')
            and   type = 'U')
   drop table PRICELIST_ITEM
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RATE_OF_PDV')
            and   name  = 'IN_NEED_FK'
            and   indid > 0
            and   indid < 255)
   drop index RATE_OF_PDV.IN_NEED_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RATE_OF_PDV')
            and   type = 'U')
   drop table RATE_OF_PDV
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RISK')
            and   name  = 'RELATIONSHIP_40_FK'
            and   indid > 0
            and   indid < 255)
   drop index RISK.RELATIONSHIP_40_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RISK')
            and   type = 'U')
   drop table RISK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RISK_OF_CAR')
            and   name  = 'RISK_OF_CAR2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RISK_OF_CAR.RISK_OF_CAR2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RISK_OF_CAR')
            and   name  = 'RISK_OF_CAR_FK'
            and   indid > 0
            and   indid < 255)
   drop index RISK_OF_CAR.RISK_OF_CAR_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RISK_OF_CAR')
            and   type = 'U')
   drop table RISK_OF_CAR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RISK_OF_HOUSE')
            and   name  = 'RISK_OF_HOUSE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index RISK_OF_HOUSE.RISK_OF_HOUSE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RISK_OF_HOUSE')
            and   name  = 'RISK_OF_HOUSE_FK'
            and   indid > 0
            and   indid < 255)
   drop index RISK_OF_HOUSE.RISK_OF_HOUSE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RISK_OF_HOUSE')
            and   type = 'U')
   drop table RISK_OF_HOUSE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STATE_OF_ORIGIN')
            and   name  = 'RELATIONSHIP_41_FK'
            and   indid > 0
            and   indid < 255)
   drop index STATE_OF_ORIGIN.RELATIONSHIP_41_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STATE_OF_ORIGIN')
            and   type = 'U')
   drop table STATE_OF_ORIGIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUBJECT_OF_INSURANCE')
            and   name  = 'RELATIONSHIP_39_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUBJECT_OF_INSURANCE.RELATIONSHIP_39_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUBJECT_OF_INSURANCE')
            and   name  = 'RELATIONSHIP_38_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUBJECT_OF_INSURANCE.RELATIONSHIP_38_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUBJECT_OF_INSURANCE')
            and   name  = 'RELATIONSHIP_37_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUBJECT_OF_INSURANCE.RELATIONSHIP_37_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUBJECT_OF_INSURANCE')
            and   name  = 'RELATIONSHIP_31_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUBJECT_OF_INSURANCE.RELATIONSHIP_31_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUBJECT_OF_INSURANCE')
            and   type = 'U')
   drop table SUBJECT_OF_INSURANCE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAVEL_ACTIVITY_TRAVEL_PURPOSE')
            and   name  = 'TRAVEL_ACTIVITY_TRAVEL_PURPOSE2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAVEL_ACTIVITY_TRAVEL_PURPOSE.TRAVEL_ACTIVITY_TRAVEL_PURPOSE2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAVEL_ACTIVITY_TRAVEL_PURPOSE')
            and   name  = 'TRAVEL_ACTIVITY_TRAVEL_PURPOSE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAVEL_ACTIVITY_TRAVEL_PURPOSE.TRAVEL_ACTIVITY_TRAVEL_PURPOSE_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRAVEL_ACTIVITY_TRAVEL_PURPOSE')
            and   type = 'U')
   drop table TRAVEL_ACTIVITY_TRAVEL_PURPOSE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAVEL_PURPOSE')
            and   name  = 'RELATIONSHIP_24_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAVEL_PURPOSE.RELATIONSHIP_24_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRAVEL_PURPOSE')
            and   type = 'U')
   drop table TRAVEL_PURPOSE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TYPE_OF_PACKAGE')
            and   type = 'U')
   drop table TYPE_OF_PACKAGE
go

/*==============================================================*/
/* Table: AGE_GROUP                                             */
/*==============================================================*/
create table AGE_GROUP (
   AG_ID                int                  not null,
   COEFF_ID             int                  null,
   AG_NAME_EN           varchar(30)          not null,
   AG_NAME_SRB          varchar(100)         null,
   constraint PK_AGE_GROUP primary key (AG_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_25_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_25_FK on AGE_GROUP (COEFF_ID ASC)
go

/*==============================================================*/
/* Table: CAR                                                   */
/*==============================================================*/
create table CAR (
   CARID                int                  identity,
   CLIENT_ID            int                  not null,
   YEAR                 datetime             null,
   CHASSIS_NUMBER       int                  null,
   LICENCE_PLATE        varchar(20)          null,
   CAR_TYPE             varchar(20)          null,
   CAR_MODEL            varchar(20)          null,
   CAR_START_DATE       datetime             null,
   CAR_END_DATE         datetime             null,
   constraint PK_CAR primary key (CARID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_34_FK on CAR (CLIENT_ID ASC)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   CLIENT_ID            int                  identity,
   AG_ID                int                  null,
   POLICY_ID            int                  null,
   FIRSTNAME            varchar(60)          not null,
   LASTNAME             varchar(70)          not null,
   DATE_OF_BIRTH        datetime             not null,
   JMBG                 varchar(30)          not null,
   PHONE                varchar(80)          null,
   PASSPORT_NUMBER      numeric(10)          null,
   SEX                  varchar(50)          null,
   constraint PK_CLIENT primary key (CLIENT_ID)
)
go

/*==============================================================*/
/* Index: IS_FK                                                 */
/*==============================================================*/




create nonclustered index IS_FK on CLIENT (AG_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_22_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_22_FK on CLIENT (POLICY_ID ASC)
go

/*==============================================================*/
/* Table: COEFFICIENT                                           */
/*==============================================================*/
create table COEFFICIENT (
<<<<<<< Updated upstream
   COEFF_ID             int                  identity,
   COEFF_VALUE          numeric(5,2)         null,
=======
   COEFF_ID             int                  not null,
   COEFF_VALUE          numeric(10,4)       null,
>>>>>>> Stashed changes
   COEFF_DATE           datetime             null,
   constraint PK_COEFFICIENT primary key (COEFF_ID)
)
go

/*==============================================================*/
/* Table: CONTINENT                                             */
/*==============================================================*/
create table CONTINENT (
   CONTINENT_ID         int                  identity,
   COEFF_ID             int                  null,
   CONTINENT_NAME_EN    varchar(50)          not null,
   CONTINENT_NAME_SRB   varchar(50)          null,
   constraint PK_CONTINENT primary key (CONTINENT_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_27_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_27_FK on CONTINENT (COEFF_ID ASC)
go

/*==============================================================*/
/* Table: DESTINATION                                           */
/*==============================================================*/
create table DESTINATION (
   DST_ID               int                  identity,
   ST_ID                int                  null,
   DST_DAYS             int                  not null,
   constraint PK_DESTINATION primary key (DST_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_42_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_42_FK on DESTINATION (ST_ID ASC)
go

/*==============================================================*/
/* Table: HOME                                                  */
/*==============================================================*/
create table HOME (
   HOME_ID              int                  identity,
   HOME_SQUARES         int                  not null,
   HOME_BUILDING_YEAR   datetime             null,
   HOME_ADDRESS         varchar(30)          not null,
   HOME_VALUE           int                  null,
   HOME_START_DATE      datetime             null,
   HOME_END_DATE        datetime             null,
   constraint PK_HOME primary key (HOME_ID)
)
go

/*==============================================================*/
/* Table: INSURANCE_PACKAGE                                     */
/*==============================================================*/
create table INSURANCE_PACKAGE (
   PACKAGE_ID           int                  identity,
   PL_ITEM_ID           int                  null,
   TOP_ID               int                  null,
   PACKAGE_NAME_EN      varchar(20)          null,
   PACKAGE_DESCRIPTION_EN varchar(1000)        null,
   PACKAGE_NAME_SRB     varchar(20)          null,
   PACKAGE_DESCRIPTION_SRB varchar(5000)        null,
   constraint PK_INSURANCE_PACKAGE primary key (PACKAGE_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_36_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_36_FK on INSURANCE_PACKAGE (PL_ITEM_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_26_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_26_FK on INSURANCE_PACKAGE (TOP_ID ASC)
go

/*==============================================================*/
/* Table: ITEMS_OF_PACKAGE                                      */
/*==============================================================*/
create table ITEMS_OF_PACKAGE (
   IOP_ACKAGE_ID        int                  identity,
   PACKAGE_ID           int                  null,
   IOF_DESCRIPTION_EN   varchar(5000)        null,
   IOF_DESCTIPTION_SRB  varchar(5000)        null,
   IOF_NAME_EN          varchar(50)          null,
   IOF_NAME_SRB         varchar(50)          null,
   constraint PK_ITEMS_OF_PACKAGE primary key (IOP_ACKAGE_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_32_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_32_FK on ITEMS_OF_PACKAGE (PACKAGE_ID ASC)
go

/*==============================================================*/
/* Table: PDV                                                   */
/*==============================================================*/
create table PDV (
   PDV_ID               int                  identity,
   NAME_PDV             varchar(30)          null,
   constraint PK_PDV primary key (PDV_ID)
)
go

/*==============================================================*/
/* Table: POLICY                                                */
/*==============================================================*/
create table POLICY (
   POLICY_ID            int                  identity,
   R_ID                 int                  not null,
   PACKAGE_ID           int                  null,
   CLIENT_ID            int                  not null,
   PDV_ID               int                  not null,
   PL_ITEM_ID           int                  null,
   II_ID                int                  not null,
   POLICY_START_OF_INSURANCE datetime             not null,
   POLICY_DST_END_OF_INSURANCE datetime             null,
   constraint PK_POLICY primary key (POLICY_ID)
)
go

/*==============================================================*/
/* Index: OWNER_FK                                              */
/*==============================================================*/




create nonclustered index OWNER_FK on POLICY (CLIENT_ID ASC)
go

/*==============================================================*/
/* Index: POSSIBLE_RISK_FK                                      */
/*==============================================================*/




create nonclustered index POSSIBLE_RISK_FK on POLICY (R_ID ASC)
go

/*==============================================================*/
/* Index: FOR_CALCTULATION_FK                                   */
/*==============================================================*/




create nonclustered index FOR_CALCTULATION_FK on POLICY (PDV_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_23_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_23_FK on POLICY (II_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_30_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_30_FK on POLICY (PACKAGE_ID ASC)
go

/*==============================================================*/
/* Index: INSURANCE_PRICE_FK                                    */
/*==============================================================*/




create nonclustered index INSURANCE_PRICE_FK on POLICY (PL_ITEM_ID ASC)
go

/*==============================================================*/
/* Table: PRICELIST                                             */
/*==============================================================*/
create table PRICELIST (
   PRICELIST_ID         int                  identity,
   PRICELIST_START_DATE datetime             not null,
   PRICELIST_END_DATE   datetime             null,
   constraint PK_PRICELIST primary key (PRICELIST_ID)
)
go

/*==============================================================*/
/* Table: PRICELIST_ITEM                                        */
/*==============================================================*/
create table PRICELIST_ITEM (
   PL_ITEM_ID           int                  identity,
   PRICELIST_ID         int                  not null,
   PL_PRICE             numeric(12,4)        null,
   constraint PK_PRICELIST_ITEM primary key (PL_ITEM_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_21_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_21_FK on PRICELIST_ITEM (PRICELIST_ID ASC)
go

/*==============================================================*/
/* Table: RATE_OF_PDV                                           */
/*==============================================================*/
create table RATE_OF_PDV (
   PDV_RATE_ID          int                  identity,
   PDV_ID               int                  not null,
   VALID_UNTIL          datetime             null,
   RATE                 numeric(10,4)       null,
   constraint PK_RATE_OF_PDV primary key (PDV_RATE_ID)
)
go

/*==============================================================*/
/* Index: IN_NEED_FK                                            */
/*==============================================================*/




create nonclustered index IN_NEED_FK on RATE_OF_PDV (PDV_ID ASC)
go

/*==============================================================*/
/* Table: RISK                                                  */
/*==============================================================*/
create table RISK (
   R_ID                 int                  identity,
   COEFF_ID             int                  not null,
   R_NAME_EN            varchar(30)          not null,
   R_DESCRIPTION_EN     varchar(2000)        not null,
   R_NAME_SRB           varchar(30)          null,
   R_DESCRIPTION_SRB    varchar(2000)        null,
   constraint PK_RISK primary key (R_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_40_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_40_FK on RISK (COEFF_ID ASC)
go

/*==============================================================*/
/* Table: RISK_OF_CAR                                           */
/*==============================================================*/
create table RISK_OF_CAR (
   CARID                int                  not null,
   R_ID                 int                  not null,
   ROC_ID               int                 IDENTITY,
   constraint PK_RISK_OF_CAR primary key (ROC_ID)
)
go

/*==============================================================*/
/* Index: RISK_OF_CAR_FK                                        */
/*==============================================================*/




create nonclustered index RISK_OF_CAR_FK on RISK_OF_CAR (CARID ASC)
go

/*==============================================================*/
/* Index: RISK_OF_CAR2_FK                                       */
/*==============================================================*/




create nonclustered index RISK_OF_CAR2_FK on RISK_OF_CAR (R_ID ASC)
go

/*==============================================================*/
/* Table: RISK_OF_HOUSE                                         */
/*==============================================================*/
create table RISK_OF_HOUSE (
   R_ID                 int                  not null,
   HOME_ID              int                  not null,
   ROH_ID               int                  identity,
   constraint PK_RISK_OF_HOUSE primary key (ROH_ID)
)
go

/*==============================================================*/
/* Index: RISK_OF_HOUSE_FK                                      */
/*==============================================================*/




create nonclustered index RISK_OF_HOUSE_FK on RISK_OF_HOUSE (R_ID ASC)
go

/*==============================================================*/
/* Index: RISK_OF_HOUSE2_FK                                     */
/*==============================================================*/




create nonclustered index RISK_OF_HOUSE2_FK on RISK_OF_HOUSE (HOME_ID ASC)
go

/*==============================================================*/
/* Table: STATE_OF_ORIGIN                                       */
/*==============================================================*/
create table STATE_OF_ORIGIN (
   ST_ID                int                  identity,
   CONTINENT_ID         int                  not null,
   ST_NAME_SRB          varchar(30)          not null,
   ST_NAME_EN           varchar(50)          null,
   constraint PK_STATE_OF_ORIGIN primary key (ST_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_41_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_41_FK on STATE_OF_ORIGIN (CONTINENT_ID ASC)
go

/*==============================================================*/
/* Table: SUBJECT_OF_INSURANCE                                  */
/*==============================================================*/
create table SUBJECT_OF_INSURANCE (
   II_ID                int                  identity,
   DST_ID               int                  null,
   TP_ID                int                  null,
   HOME_ID              int                  null,
   CARID                int                  null,
   constraint PK_SUBJECT_OF_INSURANCE primary key (II_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_31_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_31_FK on SUBJECT_OF_INSURANCE (TP_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_37_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_37_FK on SUBJECT_OF_INSURANCE (DST_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_38_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_38_FK on SUBJECT_OF_INSURANCE (HOME_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_39_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_39_FK on SUBJECT_OF_INSURANCE (CARID ASC)
go

/*==============================================================*/
/* Table: TRAVEL_ACTIVITY_TRAVEL_PURPOSE                        */
/*==============================================================*/
create table TRAVEL_ACTIVITY_TRAVEL_PURPOSE (
   R_ID                 int                  not null,
   TP_ID                int                  not null,
   TP_R_ID              int                  identity,
   constraint PK_TRAVEL_ACTIVITY_TRAVEL_PURP primary key (TP_R_ID)
)
go

/*==============================================================*/
/* Index: TRAVEL_ACTIVITY_TRAVEL_PURPOSE_FK                     */
/*==============================================================*/




create nonclustered index TRAVEL_ACTIVITY_TRAVEL_PURPOSE_FK on TRAVEL_ACTIVITY_TRAVEL_PURPOSE (R_ID ASC)
go

/*==============================================================*/
/* Index: TRAVEL_ACTIVITY_TRAVEL_PURPOSE2_FK                    */
/*==============================================================*/




create nonclustered index TRAVEL_ACTIVITY_TRAVEL_PURPOSE2_FK on TRAVEL_ACTIVITY_TRAVEL_PURPOSE (TP_ID ASC)
go

/*==============================================================*/
/* Table: TRAVEL_PURPOSE                                        */
/*==============================================================*/
create table TRAVEL_PURPOSE (
   TP_ID                int                  identity,
   PACKAGE_ID           int                  not null,
   TP_NAME_EN           varchar(30)          not null,
   TP_NAME_SRB          varchar(30)          null,
   constraint PK_TRAVEL_PURPOSE primary key (TP_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_24_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_24_FK on TRAVEL_PURPOSE (PACKAGE_ID ASC)
go

/*==============================================================*/
/* Table: TYPE_OF_PACKAGE                                       */
/*==============================================================*/
create table TYPE_OF_PACKAGE (
   TOP_ID               int                  identity,
   TOP_NAME             varchar(100)         null,
   constraint PK_TYPE_OF_PACKAGE primary key (TOP_ID)
)
go

alter table AGE_GROUP
   add constraint FK_AGE_GROU_RELATIONS_COEFFICI foreign key (COEFF_ID)
      references COEFFICIENT (COEFF_ID)
go

alter table CAR
   add constraint FK_CAR_RELATIONS_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table CLIENT
   add constraint FK_CLIENT_IS_AGE_GROU foreign key (AG_ID)
      references AGE_GROUP (AG_ID)
go

alter table CLIENT
   add constraint FK_CLIENT_RELATIONS_POLICY foreign key (POLICY_ID)
      references POLICY (POLICY_ID)
go

alter table CONTINENT
   add constraint FK_CONTINEN_RELATIONS_COEFFICI foreign key (COEFF_ID)
      references COEFFICIENT (COEFF_ID)
go

alter table DESTINATION
   add constraint FK_DESTINAT_RELATIONS_STATE_OF foreign key (ST_ID)
      references STATE_OF_ORIGIN (ST_ID)
go

alter table INSURANCE_PACKAGE
   add constraint FK_INSURANC_RELATIONS_TYPE_OF_ foreign key (TOP_ID)
      references TYPE_OF_PACKAGE (TOP_ID)
go

alter table INSURANCE_PACKAGE
   add constraint FK_INSURANC_RELATIONS_PRICELIS foreign key (PL_ITEM_ID)
      references PRICELIST_ITEM (PL_ITEM_ID)
go

alter table ITEMS_OF_PACKAGE
   add constraint FK_ITEMS_OF_RELATIONS_INSURANC foreign key (PACKAGE_ID)
      references INSURANCE_PACKAGE (PACKAGE_ID)
go

alter table POLICY
   add constraint FK_POLICY_FOR_CALCT_PDV foreign key (PDV_ID)
      references PDV (PDV_ID)
go

alter table POLICY
   add constraint FK_POLICY_INSURANCE_PRICELIS foreign key (PL_ITEM_ID)
      references PRICELIST_ITEM (PL_ITEM_ID)
go

alter table POLICY
   add constraint FK_POLICY_OWNER_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table POLICY
   add constraint FK_POLICY_POSSIBLE__RISK foreign key (R_ID)
      references RISK (R_ID)
go

alter table POLICY
   add constraint FK_POLICY_RELATIONS_SUBJECT_ foreign key (II_ID)
      references SUBJECT_OF_INSURANCE (II_ID)
go

alter table POLICY
   add constraint FK_POLICY_RELATIONS_INSURANC foreign key (PACKAGE_ID)
      references INSURANCE_PACKAGE (PACKAGE_ID)
go

alter table PRICELIST_ITEM
   add constraint FK_PRICELIS_RELATIONS_PRICELIS foreign key (PRICELIST_ID)
      references PRICELIST (PRICELIST_ID)
go

alter table RATE_OF_PDV
   add constraint FK_RATE_OF__IN_NEED_PDV foreign key (PDV_ID)
      references PDV (PDV_ID)
go

alter table RISK
   add constraint FK_RISK_RELATIONS_COEFFICI foreign key (COEFF_ID)
      references COEFFICIENT (COEFF_ID)
go

alter table RISK_OF_CAR
   add constraint FK_RISK_OF__RISK_OF_C_CAR foreign key (CARID)
      references CAR (CARID)
go

alter table RISK_OF_CAR
   add constraint FK_RISK_OF__RISK_OF_C_RISK foreign key (R_ID)
      references RISK (R_ID)
go

alter table RISK_OF_HOUSE
   add constraint FK_RISK_OF__RISK_OF_H_RISK foreign key (R_ID)
      references RISK (R_ID)
go

alter table RISK_OF_HOUSE
   add constraint FK_RISK_OF__RISK_OF_H_HOME foreign key (HOME_ID)
      references HOME (HOME_ID)
go

alter table STATE_OF_ORIGIN
   add constraint FK_STATE_OF_RELATIONS_CONTINEN foreign key (CONTINENT_ID)
      references CONTINENT (CONTINENT_ID)
go

alter table SUBJECT_OF_INSURANCE
   add constraint FK_SUBJECT__RELATIONS_TRAVEL_P foreign key (TP_ID)
      references TRAVEL_PURPOSE (TP_ID)
go

alter table SUBJECT_OF_INSURANCE
   add constraint FK_SUBJECT__RELATIONS_DESTINAT foreign key (DST_ID)
      references DESTINATION (DST_ID)
go

alter table SUBJECT_OF_INSURANCE
   add constraint FK_SUBJECT__RELATIONS_HOME foreign key (HOME_ID)
      references HOME (HOME_ID)
go

alter table SUBJECT_OF_INSURANCE
   add constraint FK_SUBJECT__RELATIONS_CAR foreign key (CARID)
      references CAR (CARID)
go

alter table TRAVEL_ACTIVITY_TRAVEL_PURPOSE
   add constraint FK_TRAVEL_A_TRAVEL_AC_RISK foreign key (R_ID)
      references RISK (R_ID)
go

alter table TRAVEL_ACTIVITY_TRAVEL_PURPOSE
   add constraint FK_TRAVEL_A_TRAVEL_AC_TRAVEL_P foreign key (TP_ID)
      references TRAVEL_PURPOSE (TP_ID)
go

alter table TRAVEL_PURPOSE
   add constraint FK_TRAVEL_P_RELATIONS_INSURANC foreign key (PACKAGE_ID)
      references INSURANCE_PACKAGE (PACKAGE_ID)
go

