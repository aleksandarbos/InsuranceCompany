/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2014                    */
/* Created on:     1/7/2017 4:59:55 PM                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK_ACCOUNT') and o.name = 'FK_BANK_ACC_CLIENT_AC_CLIENT')
alter table BANK_ACCOUNT
   drop constraint FK_BANK_ACC_CLIENT_AC_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK_ACCOUNT') and o.name = 'FK_BANK_ACC_OF_BANK')
alter table BANK_ACCOUNT
   drop constraint FK_BANK_ACC_OF_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK_ACCOUNT') and o.name = 'FK_BANK_ACC_RELATIONS_INSURANC')
alter table BANK_ACCOUNT
   drop constraint FK_BANK_ACC_RELATIONS_INSURANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BUSINESS_YEAR') and o.name = 'FK_BUSINESS_RELATIONS_INSURANC')
alter table BUSINESS_YEAR
   drop constraint FK_BUSINESS_RELATIONS_INSURANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CAR') and o.name = 'FK_CAR_RELATIONS_CLIENT')
alter table CAR
   drop constraint FK_CAR_RELATIONS_CLIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CITY') and o.name = 'FK_CITY_IS_SITUAT_STATE_OF')
alter table CITY
   drop constraint FK_CITY_IS_SITUAT_STATE_OF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENT') and o.name = 'FK_CLIENT_IS_TYPE_OF_')
alter table CLIENT
   drop constraint FK_CLIENT_IS_TYPE_OF_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLIENT') and o.name = 'FK_CLIENT_RELATIONS_POLICY')
alter table CLIENT
   drop constraint FK_CLIENT_RELATIONS_POLICY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DESTINATION') and o.name = 'FK_DESTINAT_RELATIONS_STATE_OF')
alter table DESTINATION
   drop constraint FK_DESTINAT_RELATIONS_STATE_OF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_RELATIONS_INSURANC')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_RELATIONS_INSURANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_RESPONSIB_EMPLOYEE')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_RESPONSIB_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HOME') and o.name = 'FK_HOME_RELATIONS_TYPE_OF_')
alter table HOME
   drop constraint FK_HOME_RELATIONS_TYPE_OF_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INSURANCE_COMPANY') and o.name = 'FK_INSURANC_IS_FROM_CITY')
alter table INSURANCE_COMPANY
   drop constraint FK_INSURANC_IS_FROM_CITY
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
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_CURENT_CURRENCY')
alter table POLICY
   drop constraint FK_POLICY_CURENT_CURRENCY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_FOR_CALCT_PDV')
alter table POLICY
   drop constraint FK_POLICY_FOR_CALCT_PDV
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_HANDS_OUT_INSURANC')
alter table POLICY
   drop constraint FK_POLICY_HANDS_OUT_INSURANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_IN_CHARGE_EMPLOYEE')
alter table POLICY
   drop constraint FK_POLICY_IN_CHARGE_EMPLOYEE
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
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_RELATIONS_BUSINESS')
alter table POLICY
   drop constraint FK_POLICY_RELATIONS_BUSINESS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('POLICY') and o.name = 'FK_POLICY_RELATIONS_INSURANC')
alter table POLICY
   drop constraint FK_POLICY_RELATIONS_INSURANC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRICELIST') and o.name = 'FK_PRICELIS_BELONGS_T_INSURANC')
alter table PRICELIST
   drop constraint FK_PRICELIS_BELONGS_T_INSURANC
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
   where r.fkeyid = object_id('RISK') and o.name = 'FK_RISK_RELATIONS_TYPE_OF_')
alter table RISK
   drop constraint FK_RISK_RELATIONS_TYPE_OF_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RISK') and o.name = 'FK_RISK_RELATIONS_COEFFICI')
alter table RISK
   drop constraint FK_RISK_RELATIONS_COEFFICI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RISK_TYPE_OF_INSURANCE') and o.name = 'FK_RISK_TYP_RELATIONS_RISK')
alter table RISK_TYPE_OF_INSURANCE
   drop constraint FK_RISK_TYP_RELATIONS_RISK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('RISK_TYPE_OF_INSURANCE') and o.name = 'FK_RISK_TYP_RELATIONS_TYPE_OF_')
alter table RISK_TYPE_OF_INSURANCE
   drop constraint FK_RISK_TYP_RELATIONS_TYPE_OF_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STATE_OF_ORIGIN') and o.name = 'FK_STATE_OF_RELATIONS_CONTINEN')
alter table STATE_OF_ORIGIN
   drop constraint FK_STATE_OF_RELATIONS_CONTINEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUBJECT_OF_INSURANCE') and o.name = 'FK_SUBJECT__RELATIONS_TYPE_OF_')
alter table SUBJECT_OF_INSURANCE
   drop constraint FK_SUBJECT__RELATIONS_TYPE_OF_
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
   where r.fkeyid = object_id('TYPE_OF_INSURANCE') and o.name = 'FK_TYPE_OF__RELATIONS_INSURANC')
alter table TYPE_OF_INSURANCE
   drop constraint FK_TYPE_OF__RELATIONS_INSURANC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANK_ACCOUNT')
            and   name  = 'RELATIONSHIP_19_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK_ACCOUNT.RELATIONSHIP_19_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANK_ACCOUNT')
            and   name  = 'CLIENT_ACCOUNT_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK_ACCOUNT.CLIENT_ACCOUNT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANK_ACCOUNT')
            and   name  = 'OF_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK_ACCOUNT.OF_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK_ACCOUNT')
            and   type = 'U')
   drop table BANK_ACCOUNT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BUSINESS_YEAR')
            and   name  = 'RELATIONSHIP_28_FK'
            and   indid > 0
            and   indid < 255)
   drop index BUSINESS_YEAR.RELATIONSHIP_28_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BUSINESS_YEAR')
            and   type = 'U')
   drop table BUSINESS_YEAR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CAR')
            and   name  = 'RELATIONSHIP_40_FK'
            and   indid > 0
            and   indid < 255)
   drop index CAR.RELATIONSHIP_40_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CAR')
            and   type = 'U')
   drop table CAR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CITY')
            and   name  = 'IS_SITUATED_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index CITY.IS_SITUATED_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CITY')
            and   type = 'U')
   drop table CITY
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
            from  sysobjects
           where  id = object_id('CONTINENT')
            and   type = 'U')
   drop table CONTINENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CURRENCY')
            and   type = 'U')
   drop table CURRENCY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DESTINATION')
            and   name  = 'RELATIONSHIP_43_FK'
            and   indid > 0
            and   indid < 255)
   drop index DESTINATION.RELATIONSHIP_43_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DESTINATION')
            and   type = 'U')
   drop table DESTINATION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'RELATIONSHIP_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.RELATIONSHIP_18_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'RESPONSIBLE_FOR_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.RESPONSIBLE_FOR_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE_ROLE')
            and   type = 'U')
   drop table EMPLOYEE_ROLE
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
           where  id    = object_id('INSURANCE_COMPANY')
            and   name  = 'IS_FROM_FK'
            and   indid > 0
            and   indid < 255)
   drop index INSURANCE_COMPANY.IS_FROM_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INSURANCE_COMPANY')
            and   type = 'U')
   drop table INSURANCE_COMPANY
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
            and   name  = 'RELATIONSHIP_30_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.RELATIONSHIP_30_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('POLICY')
            and   name  = 'RELATIONSHIP_29_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.RELATIONSHIP_29_FK
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
            and   name  = 'CURENT_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.CURENT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('POLICY')
            and   name  = 'IN_CHARGE_OF_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.IN_CHARGE_OF_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('POLICY')
            and   name  = 'HANDS_OUT_FK'
            and   indid > 0
            and   indid < 255)
   drop index POLICY.HANDS_OUT_FK
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
            from  sysindexes
           where  id    = object_id('PRICELIST')
            and   name  = 'BELONGS_TO_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRICELIST.BELONGS_TO_FK
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
            and   name  = 'RELATIONSHIP_41_FK'
            and   indid > 0
            and   indid < 255)
   drop index RISK.RELATIONSHIP_41_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RISK')
            and   name  = 'RELATIONSHIP_35_FK'
            and   indid > 0
            and   indid < 255)
   drop index RISK.RELATIONSHIP_35_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RISK')
            and   type = 'U')
   drop table RISK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('RISK_TYPE_OF_INSURANCE')
            and   name  = 'RELATIONSHIP_34_FK'
            and   indid > 0
            and   indid < 255)
   drop index RISK_TYPE_OF_INSURANCE.RELATIONSHIP_34_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RISK_TYPE_OF_INSURANCE')
            and   type = 'U')
   drop table RISK_TYPE_OF_INSURANCE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STATE_OF_ORIGIN')
            and   name  = 'RELATIONSHIP_42_FK'
            and   indid > 0
            and   indid < 255)
   drop index STATE_OF_ORIGIN.RELATIONSHIP_42_FK
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
           where  id = object_id('TYPE_OF_CLIENT')
            and   type = 'U')
   drop table TYPE_OF_CLIENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TYPE_OF_HOME')
            and   type = 'U')
   drop table TYPE_OF_HOME
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TYPE_OF_INSURANCE')
            and   name  = 'RELATIONSHIP_24_FK'
            and   indid > 0
            and   indid < 255)
   drop index TYPE_OF_INSURANCE.RELATIONSHIP_24_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TYPE_OF_INSURANCE')
            and   type = 'U')
   drop table TYPE_OF_INSURANCE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TYPE_OF_RISK')
            and   type = 'U')
   drop table TYPE_OF_RISK
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   BANK_ID              int                  identity,
   BANK_NAME            varchar(30)          not null,
   constraint PK_BANK primary key (BANK_ID)
)
go

/*==============================================================*/
/* Table: BANK_ACCOUNT                                          */
/*==============================================================*/
create table BANK_ACCOUNT (
   AC1_ID               int                  identity,
   CLIENT_ID            int                  not null,
   CP_ID                int                  not null,
   BANK_ID              int                  not null,
   constraint PK_BANK_ACCOUNT primary key (AC1_ID)
)
go

/*==============================================================*/
/* Index: OF_FK                                                 */
/*==============================================================*/




create nonclustered index OF_FK on BANK_ACCOUNT (BANK_ID ASC)
go

/*==============================================================*/
/* Index: CLIENT_ACCOUNT_FK                                     */
/*==============================================================*/




create nonclustered index CLIENT_ACCOUNT_FK on BANK_ACCOUNT (CLIENT_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_19_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_19_FK on BANK_ACCOUNT (CP_ID ASC)
go

/*==============================================================*/
/* Table: BUSINESS_YEAR                                         */
/*==============================================================*/
create table BUSINESS_YEAR (
   YEAR_ID              int                  identity,
   CP_ID                int                  not null,
   constraint PK_BUSINESS_YEAR primary key (YEAR_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_28_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_28_FK on BUSINESS_YEAR (CP_ID ASC)
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
   constraint PK_CAR primary key (CARID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_40_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_40_FK on CAR (CLIENT_ID ASC)
go

/*==============================================================*/
/* Table: CITY                                                  */
/*==============================================================*/
create table CITY (
   CITY_ID              int                  identity,
   ST_ID                int                  not null,
   CITY_NAME            varchar(30)          not null,
   constraint PK_CITY primary key (CITY_ID)
)
go

/*==============================================================*/
/* Index: IS_SITUATED_IN_FK                                     */
/*==============================================================*/




create nonclustered index IS_SITUATED_IN_FK on CITY (ST_ID ASC)
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
   CLIENT_ID            int                  identity,
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
/* Table: COEFFICIENT                                           */
/*==============================================================*/
create table COEFFICIENT (
   COEFF_ID             int                  identity,
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
   CONTINENT_NAME       varchar(50)          not null,
   constraint PK_CONTINENT primary key (CONTINENT_ID)
)
go

/*==============================================================*/
/* Table: CURRENCY                                              */
/*==============================================================*/
create table CURRENCY (
   CURRENCY_ID          int                  identity,
   CURRENCY_NAME        varchar(50)          null,
   constraint PK_CURRENCY primary key (CURRENCY_ID)
)
go

/*==============================================================*/
/* Table: DESTINATION                                           */
/*==============================================================*/
create table DESTINATION (
   DST_ID               int                  identity,
   ST_ID                int                  null,
   DST_NAME             varchar(30)          not null,
   DST_DAYS             int                  not null,
   constraint PK_DESTINATION primary key (DST_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_43_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_43_FK on DESTINATION (ST_ID ASC)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EN_ID                int                  identity,
   ROLE_ID              int                  not null,
   CP_ID                int                  null,
   EN_FIRSTNAME         varchar(30)          not null,
   EN_LASTNAME          varchar(30)          not null,
   constraint PK_EMPLOYEE primary key (EN_ID)
)
go

/*==============================================================*/
/* Index: RESPONSIBLE_FOR_FK                                    */
/*==============================================================*/




create nonclustered index RESPONSIBLE_FOR_FK on EMPLOYEE (ROLE_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_18_FK on EMPLOYEE (CP_ID ASC)
go

/*==============================================================*/
/* Table: EMPLOYEE_ROLE                                         */
/*==============================================================*/
create table EMPLOYEE_ROLE (
   ROLE_ID              int                  identity,
   ROLE_NAME            varchar(30)          not null,
   constraint PK_EMPLOYEE_ROLE primary key (ROLE_ID)
)
go

/*==============================================================*/
/* Table: HOME                                                  */
/*==============================================================*/
create table HOME (
   HOME_ID              int                  identity,
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
/* Table: INSURANCE_COMPANY                                     */
/*==============================================================*/
create table INSURANCE_COMPANY (
   CP_ID                int                  identity,
   CITY_ID              int                  not null,
   CP_NAME              varchar(30)          null,
   PIB                  int                  not null,
   constraint PK_INSURANCE_COMPANY primary key (CP_ID)
)
go

/*==============================================================*/
/* Index: IS_FROM_FK                                            */
/*==============================================================*/




create nonclustered index IS_FROM_FK on INSURANCE_COMPANY (CITY_ID ASC)
go

/*==============================================================*/
/* Table: INSURANCE_PACKAGE                                     */
/*==============================================================*/
create table INSURANCE_PACKAGE (
   PACKAGE_ID           int                  identity,
   PL_ITEM_ID           int                  null,
   TOR_NAME             varchar(20)          null,
   constraint PK_INSURANCE_PACKAGE primary key (PACKAGE_ID)
)
go

/*==============================================================*/
/* Table: ITEMS_OF_PACKAGE                                      */
/*==============================================================*/
create table ITEMS_OF_PACKAGE (
   ITEMS_OF_PACKAGE_ID  int                  identity,
   PACKAGE_ID           int                  null,
   constraint PK_ITEMS_OF_PACKAGE primary key (ITEMS_OF_PACKAGE_ID)
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
   PDV_ID               int                  not null,
   CLIENT_ID            int                  not null,
   PACKAGE_ID           int                  null,
   YEAR_ID              int                  null,
   EN_ID                int                  not null,
   CURRENCY_ID          int                  not null,
   CP_ID                int                  not null,
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
/* Index: HANDS_OUT_FK                                          */
/*==============================================================*/




create nonclustered index HANDS_OUT_FK on POLICY (CP_ID ASC)
go

/*==============================================================*/
/* Index: IN_CHARGE_OF_FK                                       */
/*==============================================================*/




create nonclustered index IN_CHARGE_OF_FK on POLICY (EN_ID ASC)
go

/*==============================================================*/
/* Index: CURENT_FK                                             */
/*==============================================================*/




create nonclustered index CURENT_FK on POLICY (CURRENCY_ID ASC)
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
/* Index: RELATIONSHIP_29_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_29_FK on POLICY (YEAR_ID ASC)
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
   PRICELIST_ID         int                  identity,
   CP_ID                int                  not null,
   START_DATE           datetime             not null,
   END_DATE             datetime             null,
   constraint PK_PRICELIST primary key (PRICELIST_ID)
)
go

/*==============================================================*/
/* Index: BELONGS_TO_FK                                         */
/*==============================================================*/




create nonclustered index BELONGS_TO_FK on PRICELIST (CP_ID ASC)
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
/* Table: RISK                                                  */
/*==============================================================*/
create table RISK (
   R_ID                 int                  identity,
   TOR_ID               int                  not null,
   COEFF_ID             int                  not null,
   R_NAME               varchar(30)          not null,
   constraint PK_RISK primary key (R_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_35_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_35_FK on RISK (TOR_ID ASC)
go

/*==============================================================*/
/* Index: RELATIONSHIP_41_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_41_FK on RISK (COEFF_ID ASC)
go

/*==============================================================*/
/* Table: RISK_TYPE_OF_INSURANCE                                */
/*==============================================================*/
create table RISK_TYPE_OF_INSURANCE (
   R_ID                 int                  not null,
   IT_ID                int                  not null,
   constraint PK_RISK_TYPE_OF_INSURANCE primary key (R_ID, IT_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_34_FK on RISK_TYPE_OF_INSURANCE (IT_ID ASC)
go

/*==============================================================*/
/* Table: STATE_OF_ORIGIN                                       */
/*==============================================================*/
create table STATE_OF_ORIGIN (
   ST_ID                int                  identity,
   CONTINENT_ID         int                  not null,
   ST_NAME              varchar(30)          not null,
   constraint PK_STATE_OF_ORIGIN primary key (ST_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_42_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_42_FK on STATE_OF_ORIGIN (CONTINENT_ID ASC)
go

/*==============================================================*/
/* Table: SUBJECT_OF_INSURANCE                                  */
/*==============================================================*/
create table SUBJECT_OF_INSURANCE (
   II_ID                int                  identity,
   IT_ID                int                  null,
   CARID                int                  null,
   DST_ID               int                  null,
   HOME_ID              int                  null,
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
/* Table: TYPE_OF_CLIENT                                        */
/*==============================================================*/
create table TYPE_OF_CLIENT (
   CT_ID                int                  identity,
   CT_NAME              varchar(30)          not null,
   constraint PK_TYPE_OF_CLIENT primary key (CT_ID)
)
go

/*==============================================================*/
/* Table: TYPE_OF_HOME                                          */
/*==============================================================*/
create table TYPE_OF_HOME (
   HT_ID                int                  identity,
   HT_NAME              varchar(30)          not null,
   constraint PK_TYPE_OF_HOME primary key (HT_ID)
)
go

/*==============================================================*/
/* Table: TYPE_OF_INSURANCE                                     */
/*==============================================================*/
create table TYPE_OF_INSURANCE (
   IT_ID                int                  identity,
   PACKAGE_ID           int                  not null,
   IT_NAME              varchar(30)          not null,
   constraint PK_TYPE_OF_INSURANCE primary key (IT_ID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_24_FK                                    */
/*==============================================================*/




create nonclustered index RELATIONSHIP_24_FK on TYPE_OF_INSURANCE (PACKAGE_ID ASC)
go

/*==============================================================*/
/* Table: TYPE_OF_RISK                                          */
/*==============================================================*/
create table TYPE_OF_RISK (
   TOR_NAME             varchar(20)          null,
   TOR_ID               int                  identity,
   constraint PK_TYPE_OF_RISK primary key (TOR_ID)
)
go

alter table BANK_ACCOUNT
   add constraint FK_BANK_ACC_CLIENT_AC_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table BANK_ACCOUNT
   add constraint FK_BANK_ACC_OF_BANK foreign key (BANK_ID)
      references BANK (BANK_ID)
go

alter table BANK_ACCOUNT
   add constraint FK_BANK_ACC_RELATIONS_INSURANC foreign key (CP_ID)
      references INSURANCE_COMPANY (CP_ID)
go

alter table BUSINESS_YEAR
   add constraint FK_BUSINESS_RELATIONS_INSURANC foreign key (CP_ID)
      references INSURANCE_COMPANY (CP_ID)
go

alter table CAR
   add constraint FK_CAR_RELATIONS_CLIENT foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID)
go

alter table CITY
   add constraint FK_CITY_IS_SITUAT_STATE_OF foreign key (ST_ID)
      references STATE_OF_ORIGIN (ST_ID)
go

alter table CLIENT
   add constraint FK_CLIENT_IS_TYPE_OF_ foreign key (CT_ID)
      references TYPE_OF_CLIENT (CT_ID)
go

alter table CLIENT
   add constraint FK_CLIENT_RELATIONS_POLICY foreign key (POLICY_ID)
      references POLICY (POLICY_ID)
go

alter table DESTINATION
   add constraint FK_DESTINAT_RELATIONS_STATE_OF foreign key (ST_ID)
      references STATE_OF_ORIGIN (ST_ID)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_RELATIONS_INSURANC foreign key (CP_ID)
      references INSURANCE_COMPANY (CP_ID)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_RESPONSIB_EMPLOYEE foreign key (ROLE_ID)
      references EMPLOYEE_ROLE (ROLE_ID)
go

alter table HOME
   add constraint FK_HOME_RELATIONS_TYPE_OF_ foreign key (HT_ID)
      references TYPE_OF_HOME (HT_ID)
go

alter table INSURANCE_COMPANY
   add constraint FK_INSURANC_IS_FROM_CITY foreign key (CITY_ID)
      references CITY (CITY_ID)
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
   add constraint FK_POLICY_CURENT_CURRENCY foreign key (CURRENCY_ID)
      references CURRENCY (CURRENCY_ID)
go

alter table POLICY
   add constraint FK_POLICY_FOR_CALCT_PDV foreign key (PDV_ID)
      references PDV (PDV_ID)
go

alter table POLICY
   add constraint FK_POLICY_HANDS_OUT_INSURANC foreign key (CP_ID)
      references INSURANCE_COMPANY (CP_ID)
go

alter table POLICY
   add constraint FK_POLICY_IN_CHARGE_EMPLOYEE foreign key (EN_ID)
      references EMPLOYEE (EN_ID)
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
   add constraint FK_POLICY_RELATIONS_BUSINESS foreign key (YEAR_ID)
      references BUSINESS_YEAR (YEAR_ID)
go

alter table POLICY
   add constraint FK_POLICY_RELATIONS_INSURANC foreign key (PACKAGE_ID)
      references INSURANCE_PACKAGE (PACKAGE_ID)
go

alter table PRICELIST
   add constraint FK_PRICELIS_BELONGS_T_INSURANC foreign key (CP_ID)
      references INSURANCE_COMPANY (CP_ID)
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
   add constraint FK_RISK_RELATIONS_TYPE_OF_ foreign key (TOR_ID)
      references TYPE_OF_RISK (TOR_ID)
go

alter table RISK
   add constraint FK_RISK_RELATIONS_COEFFICI foreign key (COEFF_ID)
      references COEFFICIENT (COEFF_ID)
go

alter table RISK_TYPE_OF_INSURANCE
   add constraint FK_RISK_TYP_RELATIONS_RISK foreign key (R_ID)
      references RISK (R_ID)
go

alter table RISK_TYPE_OF_INSURANCE
   add constraint FK_RISK_TYP_RELATIONS_TYPE_OF_ foreign key (IT_ID)
      references TYPE_OF_INSURANCE (IT_ID)
go

alter table STATE_OF_ORIGIN
   add constraint FK_STATE_OF_RELATIONS_CONTINEN foreign key (CONTINENT_ID)
      references CONTINENT (CONTINENT_ID)
go

alter table SUBJECT_OF_INSURANCE
   add constraint FK_SUBJECT__RELATIONS_TYPE_OF_ foreign key (IT_ID)
      references TYPE_OF_INSURANCE (IT_ID)
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

alter table TYPE_OF_INSURANCE
   add constraint FK_TYPE_OF__RELATIONS_INSURANC foreign key (PACKAGE_ID)
      references INSURANCE_PACKAGE (PACKAGE_ID)
go

