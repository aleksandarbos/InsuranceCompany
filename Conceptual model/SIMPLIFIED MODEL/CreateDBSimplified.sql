/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2014                    */
/* Created on:     2/2/2017 11:22:50 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AGE_GROUP') and o.name = 'FK_AGE_GROU_RELATIONS_COEFFICI')
alter table AGE_GROUP
   drop constraint FK_AGE_GROU_RELATIONS_COEFFICI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AGE_GROUP') and o.name = 'FK_AGE_GROU_RELATIONS_TRANSLAT')
alter table AGE_GROUP
   drop constraint FK_AGE_GROU_RELATIONS_TRANSLAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CAR') and o.name = 'FK_CAR_RELATIONS_CLIENT')
alter table CAR
   drop constraint FK_CAR_RELATIONS_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CAR') and o.name = 'FK_CAR_RELATIONS_TRANSLAT')
alter table CAR
   drop constraint FK_CAR_RELATIONS_TRANSLAT
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
   where r.fkeyid = object_id('CLIENT') and o.name = 'FK_CLIENT_RELATIONS_TRANSLAT')
alter table CLIENT
   drop constraint FK_CLIENT_RELATIONS_TRANSLAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONTINENT') and o.name = 'FK_CONTINEN_RELATIONS_COEFFICI')
alter table CONTINENT
   drop constraint FK_CONTINEN_RELATIONS_COEFFICI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CONTINENT') and o.name = 'FK_CONTINEN_RELATIONS_TRANSLAT')
alter table CONTINENT
   drop constraint FK_CONTINEN_RELATIONS_TRANSLAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DESTINATION') and o.name = 'FK_DESTINAT_RELATIONS_STATE_OF')
alter table DESTINATION
   drop constraint FK_DESTINAT_RELATIONS_STATE_OF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOME') and o.name = 'FK_HOME_RELATIONS_TYPE_OF_')
alter table HOME
   drop constraint FK_HOME_RELATIONS_TYPE_OF_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOME') and o.name = 'FK_HOME_RELATIONS_TRANSLAT')
alter table HOME
   drop constraint FK_HOME_RELATIONS_TRANSLAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INSURANCE_PACKAGE') and o.name = 'FK_INSURANC_RELATIONS_PRICELIS')
alter table INSURANCE_PACKAGE
   drop constraint FK_INSURANC_RELATIONS_PRICELIS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INSURANCE_PACKAGE') and o.name = 'FK_INSURANC_RELATIONS_TRANSLAT')
alter table INSURANCE_PACKAGE
   drop constraint FK_INSURANC_RELATIONS_TRANSLAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITEMS_OF_PACKAGE') and o.name = 'FK_ITEMS_OF_RELATIONS_INSURANC')
alter table ITEMS_OF_PACKAGE
   drop constraint FK_ITEMS_OF_RELATIONS_INSURANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITEMS_OF_PACKAGE') and o.name = 'FK_ITEMS_OF_RELATIONS_TRANSLAT')
alter table ITEMS_OF_PACKAGE
   drop constraint FK_ITEMS_OF_RELATIONS_TRANSLAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_FOR_CALCT_PDV')
alter table POLICY
   drop constraint FK_POLICY_FOR_CALCT_PDV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_OWNER_CLIENT')
alter table POLICY
   drop constraint FK_POLICY_OWNER_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_POSSIBLE__TRAVEL_A')
alter table POLICY
   drop constraint FK_POLICY_POSSIBLE__TRAVEL_A
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
   where r.fkeyid = object_id('RELATIONSHIP_51') and o.name = 'FK_RELATION_RELATIONS_TRAVEL_A')
alter table RELATIONSHIP_51
   drop constraint FK_RELATION_RELATIONS_TRAVEL_A
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RELATIONSHIP_51') and o.name = 'FK_RELATION_RELATIONS_TRAVEL_P')
alter table RELATIONSHIP_51
   drop constraint FK_RELATION_RELATIONS_TRAVEL_P
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STATE_OF_ORIGIN') and o.name = 'FK_STATE_OF_RELATIONS_TRANSLAT')
alter table STATE_OF_ORIGIN
   drop constraint FK_STATE_OF_RELATIONS_TRANSLAT
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
   where r.fkeyid = object_id('TRAVEL_ACTIVITY') and o.name = 'FK_TRAVEL_A_RELATIONS_COEFFICI')
alter table TRAVEL_ACTIVITY
   drop constraint FK_TRAVEL_A_RELATIONS_COEFFICI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAVEL_ACTIVITY') and o.name = 'FK_TRAVEL_A_RELATIONS_TRANSLAT')
alter table TRAVEL_ACTIVITY
   drop constraint FK_TRAVEL_A_RELATIONS_TRANSLAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAVEL_PURPOSE') and o.name = 'FK_TRAVEL_P_RELATIONS_INSURANC')
alter table TRAVEL_PURPOSE
   drop constraint FK_TRAVEL_P_RELATIONS_INSURANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAVEL_PURPOSE') and o.name = 'FK_TRAVEL_P_RELATIONS_TRANSLAT')
alter table TRAVEL_PURPOSE
   drop constraint FK_TRAVEL_P_RELATIONS_TRANSLAT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TYPE_OF_HOME') and o.name = 'FK_TYPE_OF__RELATIONS_TRANSLAT')
alter table TYPE_OF_HOME
   drop constraint FK_TYPE_OF__RELATIONS_TRANSLAT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AGE_GROUP')
            and   name  = 'RELATIONSHIP_50_FK'
            and   indid > 0
            and   indid < 255)
   drop index AGE_GROUP.RELATIONSHIP_50_FK
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
            and   name  = 'RELATIONSHIP_45_FK'
            and   indid > 0
            and   indid < 255)
   drop index CAR.RELATIONSHIP_45_FK
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
            and   name  = 'RELATIONSHIP_44_FK'
            and   indid > 0
            and   indid < 255)
   drop index CLIENT.RELATIONSHIP_44_FK
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
            and   name  = 'RELATIONSHIP_28_FK'
            and   indid > 0
            and   indid < 255)
   drop index CONTINENT.RELATIONSHIP_28_FK
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
            from  sysindexes
           where  id    = object_id('HOME')
            and   name  = 'RELATIONSHIP_43_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOME.RELATIONSHIP_43_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HOME')
            and   name  = 'RELATIONSHIP_26_FK'
            and   indid > 0
            and   indid < 255)
   drop index HOME.RELATIONSHIP_26_FK
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
            and   name  = 'RELATIONSHIP_47_FK'
            and   indid > 0
            and   indid < 255)
   drop index INSURANCE_PACKAGE.RELATIONSHIP_47_FK
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
            and   name  = 'RELATIONSHIP_48_FK'
            and   indid > 0
            and   indid < 255)
   drop index ITEMS_OF_PACKAGE.RELATIONSHIP_48_FK
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
           where  id    = object_id('RELATIONSHIP_51')
            and   name  = 'RELATIONSHIP_52_FK'
            and   indid > 0
            and   indid < 255)
   drop index RELATIONSHIP_51.RELATIONSHIP_52_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RELATIONSHIP_51')
            and   type = 'U')
   drop table RELATIONSHIP_51
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STATE_OF_ORIGIN')
            and   name  = 'RELATIONSHIP_29_FK'
            and   indid > 0
            and   indid < 255)
   drop index STATE_OF_ORIGIN.RELATIONSHIP_29_FK
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
            from  sysobjects
           where  id = object_id('TRANSLATE')
            and   type = 'U')
   drop table TRANSLATE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAVEL_ACTIVITY')
            and   name  = 'RELATIONSHIP_49_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAVEL_ACTIVITY.RELATIONSHIP_49_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAVEL_ACTIVITY')
            and   name  = 'RELATIONSHIP_40_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAVEL_ACTIVITY.RELATIONSHIP_40_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRAVEL_ACTIVITY')
            and   type = 'U')
   drop table TRAVEL_ACTIVITY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRAVEL_PURPOSE')
            and   name  = 'RELATIONSHIP_46_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRAVEL_PURPOSE.RELATIONSHIP_46_FK
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
            from  sysindexes
           where  id    = object_id('TYPE_OF_HOME')
            and   name  = 'RELATIONSHIP_35_FK'
            and   indid > 0
            and   indid < 255)
   drop index TYPE_OF_HOME.RELATIONSHIP_35_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TYPE_OF_HOME')
            and   type = 'U')
   drop table TYPE_OF_HOME
go

/*==============================================================*/
/* Table: AGE_GROUP                                             */
/*==============================================================*/
create table AGE_GROUP (
   CT_ID                int                  not null,
   TRANSLATE_ID         int                  null,
   COEFF_ID             int                  null,
   CT_NAME              varchar(30)          not null,
   constraint PK_AGE_GROUP primary key (CT_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_25_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_25_FK on AGE_GROUP (COEFF_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_50_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_50_FK on AGE_GROUP (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: CAR                                                   */
/*==============================================================*/
create table CAR (
   CARID                int                  not null,
   CLIENT_ID            int                  not null,
   TRANSLATE_ID         int                  null,
   YEAR                 datetime             null,
   CHASSIS_NUMBER       int                  null,
   LICENCE_PLATE        varchar(20)          null,
   CAR_TYPE             varchar(20)          null,
   CAR_MODEL            varchar(20)          null,
   constraint PK_CAR primary key (CARID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_34_FK on CAR (CLIENT_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_45_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_45_FK on CAR (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT (
   FIRSTNAME            varchar(60)          not null,
   LASTNAME             varchar(70)          not null,
   DATE_OF_BIRTH        datetime             not null,
   JMBG                 varchar(30)          not null,
   PHONE                varchar(80)          null,
   CLIENT_ID            int                  not null,
   TRANSLATE_ID         int                  null,
   CT_ID                int                  null,
   POLICY_ID            int                  null,
   PASSPORT_NUMBER      numeric(10)          null,
   SEX                  varchar(50)          null,
   constraint PK_CLIENT primary key (CLIENT_ID)
)
go

/*==============================================================*/
/* Index: IS_FK                                                 */
/*==============================================================*/




create nonclustered index IS_FK on CLIENT (CT_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_22_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_22_FK on CLIENT (POLICY_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_44_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_44_FK on CLIENT (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: COEFFICIENT                                           */
/*==============================================================*/
create table COEFFICIENT (
   COEFF_ID             int                  not null,
   COEFF_VALUE          numeric(10,10)       null,
   COEFF_DATE           datetime             null,
   constraint PK_COEFFICIENT primary key (COEFF_ID)
)
go

/*==============================================================*/
/* Table: CONTINENT                                             */
/*==============================================================*/
create table CONTINENT (
   CONTINENT_ID         int                  not null,
   COEFF_ID             int                  null,
   TRANSLATE_ID         int                  null,
   CONTINENT_NAME       varchar(50)          not null,
   constraint PK_CONTINENT primary key (CONTINENT_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_27_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_27_FK on CONTINENT (COEFF_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_28_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_28_FK on CONTINENT (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: DESTINATION                                           */
/*==============================================================*/
create table DESTINATION (
   DST_ID               int                  not null,
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
   HOME_ID              int                  not null,
   TRANSLATE_ID         int                  null,
   HT_ID                int                  not null,
   HOME_SQUARES         int                  not null,
   HOME_BUILDING_YEAR   varchar(4)           null,
   HOME_ADDRESS         varchar(30)          not null,
   constraint PK_HOME primary key (HOME_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_26_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_26_FK on HOME (HT_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_43_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_43_FK on HOME (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: INSURANCE_PACKAGE                                     */
/*==============================================================*/
create table INSURANCE_PACKAGE (
   PACKAGE_ID           int                  not null,
   PL_ITEM_ID           int                  null,
   TRANSLATE_ID         int                  null,
   TOR_NAME             varchar(20)          null,
   PACKAGE_DESCRIPTION  varchar(1000)        null,
   constraint PK_INSURANCE_PACKAGE primary key (PACKAGE_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_36_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_36_FK on INSURANCE_PACKAGE (PL_ITEM_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_47_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_47_FK on INSURANCE_PACKAGE (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: ITEMS_OF_PACKAGE                                      */
/*==============================================================*/
create table ITEMS_OF_PACKAGE (
   ITEM_OF_PACKAGE_ID   int                  not null,
   TRANSLATE_ID         int                  null,
   PACKAGE_ID           int                  null,
   ITEM_OF_PACKAGE_DESCRIPTION varchar(5000)        null,
   constraint PK_ITEMS_OF_PACKAGE primary key (ITEM_OF_PACKAGE_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_32_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_32_FK on ITEMS_OF_PACKAGE (PACKAGE_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_48_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_48_FK on ITEMS_OF_PACKAGE (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: PDV                                                   */
/*==============================================================*/
create table PDV (
   PDV_ID               int                  not null,
   NAME_PDV             varchar(30)          null,
   constraint PK_PDV primary key (PDV_ID)
)
go

/*==============================================================*/
/* Table: POLICY                                                */
/*==============================================================*/
create table POLICY (
   POLICY_ID            int                  not null,
   R_ID                 int                  not null,
   PACKAGE_ID           int                  null,
   CLIENT_ID            int                  not null,
   PDV_ID               int                  not null,
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
/* Table: PRICELIST                                             */
/*==============================================================*/
create table PRICELIST (
   PRICELIST_ID         int                  not null,
   START_DATE           datetime             not null,
   END_DATE             datetime             null,
   constraint PK_PRICELIST primary key (PRICELIST_ID)
)
go

/*==============================================================*/
/* Table: PRICELIST_ITEM                                        */
/*==============================================================*/
create table PRICELIST_ITEM (
   PL_ITEM_ID           int                  not null,
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
   PDV_RATE_ID          int                  not null,
   PDV_ID               int                  not null,
   VALID_UNTIL          datetime             null,
   RATE                 numeric(10,10)       null,
   constraint PK_RATE_OF_PDV primary key (PDV_RATE_ID)
)
go

/*==============================================================*/
/* Index: IN_NEED_FK                                            */
/*==============================================================*/




create nonclustered index IN_NEED_FK on RATE_OF_PDV (PDV_ID ASC)
go

/*==============================================================*/
/* Table: RELATIONSHIP_51                                       */
/*==============================================================*/
create table RELATIONSHIP_51 (
   R_ID                 int                  not null,
   IT_ID                int                  not null,
   constraint PK_RELATIONSHIP_51 primary key (R_ID, IT_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_52_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_52_FK on RELATIONSHIP_51 (IT_ID ASC)
go

/*==============================================================*/
/* Table: STATE_OF_ORIGIN                                       */
/*==============================================================*/
create table STATE_OF_ORIGIN (
   ST_ID                int                  not null,
   TRANSLATE_ID         int                  null,
   CONTINENT_ID         int                  not null,
   ST_NAME              varchar(30)          not null,
   constraint PK_STATE_OF_ORIGIN primary key (ST_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_41_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_41_FK on STATE_OF_ORIGIN (CONTINENT_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_29_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_29_FK on STATE_OF_ORIGIN (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: SUBJECT_OF_INSURANCE                                  */
/*==============================================================*/
create table SUBJECT_OF_INSURANCE (
   II_ID                int                  not null,
   DST_ID               int                  null,
   IT_ID                int                  null,
   HOME_ID              int                  null,
   CARID                int                  null,
   constraint PK_SUBJECT_OF_INSURANCE primary key (II_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_31_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_31_FK on SUBJECT_OF_INSURANCE (IT_ID ASC)
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
/* Table: TRANSLATE                                             */
/*==============================================================*/
create table TRANSLATE (
   TRANSLATE_ID         int                  not null,
   TRANSLATE_WORD_EN    varchar(2000)        null,
   constraint PK_TRANSLATE primary key (TRANSLATE_ID)
)
go

/*==============================================================*/
/* Table: TRAVEL_ACTIVITY                                       */
/*==============================================================*/
create table TRAVEL_ACTIVITY (
   R_ID                 int                  not null,
   COEFF_ID             int                  not null,
   TRANSLATE_ID         int                  null,
   R_NAME               varchar(30)          not null,
   constraint PK_TRAVEL_ACTIVITY primary key (R_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_40_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_40_FK on TRAVEL_ACTIVITY (COEFF_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_49_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_49_FK on TRAVEL_ACTIVITY (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: TRAVEL_PURPOSE                                        */
/*==============================================================*/
create table TRAVEL_PURPOSE (
   IT_ID                int                  not null,
   PACKAGE_ID           int                  not null,
   TRANSLATE_ID         int                  null,
   IT_NAME              varchar(30)          not null,
   constraint PK_TRAVEL_PURPOSE primary key (IT_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_24_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_24_FK on TRAVEL_PURPOSE (PACKAGE_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_46_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_46_FK on TRAVEL_PURPOSE (TRANSLATE_ID ASC)
go

/*==============================================================*/
/* Table: TYPE_OF_HOME                                          */
/*==============================================================*/
create table TYPE_OF_HOME (
   HT_ID                int                  not null,
   TRANSLATE_ID         int                  null,
   HT_NAME              varchar(30)          not null,
   constraint PK_TYPE_OF_HOME primary key (HT_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_35_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_35_FK on TYPE_OF_HOME (TRANSLATE_ID ASC)
go

alter table AGE_GROUP
   add constraint FK_AGE_GROU_RELATIONS_COEFFICI foreign key (COEFF_ID)
      references COEFFICIENT (COEFF_ID)
go

alter table AGE_GROUP
   add constraint FK_AGE_GROU_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table CAR
   add constraint FK_CAR_RELATIONS_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table CAR
   add constraint FK_CAR_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table CLIENT
   add constraint FK_CLIENT_IS_AGE_GROU foreign key (CT_ID)
      references AGE_GROUP (CT_ID)
go

alter table CLIENT
   add constraint FK_CLIENT_RELATIONS_POLICY foreign key (POLICY_ID)
      references POLICY (POLICY_ID)
go

alter table CLIENT
   add constraint FK_CLIENT_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table CONTINENT
   add constraint FK_CONTINEN_RELATIONS_COEFFICI foreign key (COEFF_ID)
      references COEFFICIENT (COEFF_ID)
go

alter table CONTINENT
   add constraint FK_CONTINEN_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table DESTINATION
   add constraint FK_DESTINAT_RELATIONS_STATE_OF foreign key (ST_ID)
      references STATE_OF_ORIGIN (ST_ID)
go

alter table HOME
   add constraint FK_HOME_RELATIONS_TYPE_OF_ foreign key (HT_ID)
      references TYPE_OF_HOME (HT_ID)
go

alter table HOME
   add constraint FK_HOME_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table INSURANCE_PACKAGE
   add constraint FK_INSURANC_RELATIONS_PRICELIS foreign key (PL_ITEM_ID)
      references PRICELIST_ITEM (PL_ITEM_ID)
go

alter table INSURANCE_PACKAGE
   add constraint FK_INSURANC_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table ITEMS_OF_PACKAGE
   add constraint FK_ITEMS_OF_RELATIONS_INSURANC foreign key (PACKAGE_ID)
      references INSURANCE_PACKAGE (PACKAGE_ID)
go

alter table ITEMS_OF_PACKAGE
   add constraint FK_ITEMS_OF_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table POLICY
   add constraint FK_POLICY_FOR_CALCT_PDV foreign key (PDV_ID)
      references PDV (PDV_ID)
go

alter table POLICY
   add constraint FK_POLICY_OWNER_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table POLICY
   add constraint FK_POLICY_POSSIBLE__TRAVEL_A foreign key (R_ID)
      references TRAVEL_ACTIVITY (R_ID)
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

alter table RELATIONSHIP_51
   add constraint FK_RELATION_RELATIONS_TRAVEL_A foreign key (R_ID)
      references TRAVEL_ACTIVITY (R_ID)
go

alter table RELATIONSHIP_51
   add constraint FK_RELATION_RELATIONS_TRAVEL_P foreign key (IT_ID)
      references TRAVEL_PURPOSE (IT_ID)
go

alter table STATE_OF_ORIGIN
   add constraint FK_STATE_OF_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table STATE_OF_ORIGIN
   add constraint FK_STATE_OF_RELATIONS_CONTINEN foreign key (CONTINENT_ID)
      references CONTINENT (CONTINENT_ID)
go

alter table SUBJECT_OF_INSURANCE
   add constraint FK_SUBJECT__RELATIONS_TRAVEL_P foreign key (IT_ID)
      references TRAVEL_PURPOSE (IT_ID)
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

alter table TRAVEL_ACTIVITY
   add constraint FK_TRAVEL_A_RELATIONS_COEFFICI foreign key (COEFF_ID)
      references COEFFICIENT (COEFF_ID)
go

alter table TRAVEL_ACTIVITY
   add constraint FK_TRAVEL_A_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table TRAVEL_PURPOSE
   add constraint FK_TRAVEL_P_RELATIONS_INSURANC foreign key (PACKAGE_ID)
      references INSURANCE_PACKAGE (PACKAGE_ID)
go

alter table TRAVEL_PURPOSE
   add constraint FK_TRAVEL_P_RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

alter table TYPE_OF_HOME
   add constraint FK_TYPE_OF__RELATIONS_TRANSLAT foreign key (TRANSLATE_ID)
      references TRANSLATE (TRANSLATE_ID)
go

