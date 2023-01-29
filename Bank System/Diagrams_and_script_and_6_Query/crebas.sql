/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     29/05/2022 07:50:13 ã                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Bank') and o.name = 'FK_BANK_CONTROLL__ADMIN')
alter table Bank
   drop constraint FK_BANK_CONTROLL__ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Branch') and o.name = 'FK_BRANCH_HAS_BANK')
alter table Branch
   drop constraint FK_BRANCH_HAS_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('C_has_A') and o.name = 'FK_C_HAS_A_C_HAS_A_CUSTOMER')
alter table C_has_A
   drop constraint FK_C_HAS_A_C_HAS_A_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('C_has_A') and o.name = 'FK_C_HAS_A_C_HAS_A2_ACCOUNT')
alter table C_has_A
   drop constraint FK_C_HAS_A_C_HAS_A2_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DealWith') and o.name = 'FK_DEALWITH_DEALWITH_EMPLOYEE')
alter table DealWith
   drop constraint FK_DEALWITH_DEALWITH_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DealWith') and o.name = 'FK_DEALWITH_DEALWITH2_CUSTOMER')
alter table DealWith
   drop constraint FK_DEALWITH_DEALWITH2_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Employee') and o.name = 'FK_EMPLOYEE_B_HAS_E_BRANCH')
alter table Employee
   drop constraint FK_EMPLOYEE_B_HAS_E_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"Industey _Loan"') and o.name = 'FK_INDUSTEY_OVERLAP2_LOAN')
alter table "Industey _Loan"
   drop constraint FK_INDUSTEY_OVERLAP2_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Loan') and o.name = 'FK_LOAN_MAKE_EMPLOYEE')
alter table Loan
   drop constraint FK_LOAN_MAKE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Loan') and o.name = 'FK_LOAN_OFFER_BRANCH')
alter table Loan
   drop constraint FK_LOAN_OFFER_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Loan') and o.name = 'FK_LOAN_TAKE_CUSTOMER')
alter table Loan
   drop constraint FK_LOAN_TAKE_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('commercial_loan') and o.name = 'FK_COMMERCI_OVERLAP_LOAN')
alter table commercial_loan
   drop constraint FK_COMMERCI_OVERLAP_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('deal_with') and o.name = 'FK_DEAL_WIT_DEAL_WITH_CUSTOMER')
alter table deal_with
   drop constraint FK_DEAL_WIT_DEAL_WITH_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('deal_with') and o.name = 'FK_DEAL_WIT_DEAL_WITH_BRANCH')
alter table deal_with
   drop constraint FK_DEAL_WIT_DEAL_WITH_BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Account')
            and   type = 'U')
   drop table Account
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Admin')
            and   type = 'U')
   drop table Admin
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Bank')
            and   name  = 'controll_information_FK'
            and   indid > 0
            and   indid < 255)
   drop index Bank.controll_information_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Bank')
            and   type = 'U')
   drop table Bank
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Branch')
            and   name  = 'has_FK'
            and   indid > 0
            and   indid < 255)
   drop index Branch.has_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Branch')
            and   type = 'U')
   drop table Branch
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('C_has_A')
            and   name  = 'C_has_A_FK'
            and   indid > 0
            and   indid < 255)
   drop index C_has_A.C_has_A_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('C_has_A')
            and   name  = 'C_has_A2_FK'
            and   indid > 0
            and   indid < 255)
   drop index C_has_A.C_has_A2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('C_has_A')
            and   type = 'U')
   drop table C_has_A
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Customer')
            and   type = 'U')
   drop table Customer
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DealWith')
            and   name  = 'DealWith_FK'
            and   indid > 0
            and   indid < 255)
   drop index DealWith.DealWith_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DealWith')
            and   name  = 'DealWith2_FK'
            and   indid > 0
            and   indid < 255)
   drop index DealWith.DealWith2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DealWith')
            and   type = 'U')
   drop table DealWith
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Employee')
            and   name  = 'B_has_E_FK'
            and   indid > 0
            and   indid < 255)
   drop index Employee.B_has_E_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Employee')
            and   type = 'U')
   drop table Employee
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"Industey _Loan"')
            and   type = 'U')
   drop table "Industey _Loan"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Loan')
            and   name  = 'make_FK'
            and   indid > 0
            and   indid < 255)
   drop index Loan.make_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Loan')
            and   name  = 'take_FK'
            and   indid > 0
            and   indid < 255)
   drop index Loan.take_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Loan')
            and   name  = 'offer_FK'
            and   indid > 0
            and   indid < 255)
   drop index Loan.offer_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Loan')
            and   type = 'U')
   drop table Loan
go

if exists (select 1
            from  sysobjects
           where  id = object_id('commercial_loan')
            and   type = 'U')
   drop table commercial_loan
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('deal_with')
            and   name  = 'deal_with_FK'
            and   indid > 0
            and   indid < 255)
   drop index deal_with.deal_with_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('deal_with')
            and   name  = 'deal_with2_FK'
            and   indid > 0
            and   indid < 255)
   drop index deal_with.deal_with2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('deal_with')
            and   type = 'U')
   drop table deal_with
go

/*==============================================================*/
/* Table: Account                                               */
/*==============================================================*/
create table Account (
   A_type               varchar(255)         not null,
   A_Balance            numeric(38)          not null,
   A_num                int                  not null,
   constraint PK_ACCOUNT primary key (A_num)
)
go

/*==============================================================*/
/* Table: Admin                                                 */
/*==============================================================*/
create table Admin (
   Admin_ID             int                  not null,
   AttributeAdmin_name_29 varchar(255)         null,
   Admin_passward       int                  not null,
   constraint PK_ADMIN primary key (Admin_ID)
)
go

/*==============================================================*/
/* Table: Bank                                                  */
/*==============================================================*/
create table Bank (
   Admin_ID             int                  not null,
   Bank_addr            varchar(255)         not null,
   Bank_code            int                  not null,
   Bank_name            varchar(255)         not null,
   constraint PK_BANK primary key (Admin_ID, Bank_code)
)
go

/*==============================================================*/
/* Index: controll_information_FK                               */
/*==============================================================*/




create nonclustered index controll_information_FK on Bank (Admin_ID ASC)
go

/*==============================================================*/
/* Table: Branch                                                */
/*==============================================================*/
create table Branch (
   Admin_ID             int                  not null,
   Bank_code            int                  not null,
   Branch_addr          varchar(255)         not null,
   Branch_num           int                  not null,
   constraint PK_BRANCH primary key (Admin_ID, Bank_code, Branch_num)
)
go

/*==============================================================*/
/* Index: has_FK                                                */
/*==============================================================*/




create nonclustered index has_FK on Branch (Admin_ID ASC,
  Bank_code ASC)
go

/*==============================================================*/
/* Table: C_has_A                                               */
/*==============================================================*/
create table C_has_A (
   C_SSN                int                  not null,
   A_num                int                  not null,
   constraint PK_C_HAS_A primary key (C_SSN, A_num)
)
go

/*==============================================================*/
/* Index: C_has_A2_FK                                           */
/*==============================================================*/




create nonclustered index C_has_A2_FK on C_has_A (A_num ASC)
go

/*==============================================================*/
/* Index: C_has_A_FK                                            */
/*==============================================================*/




create nonclustered index C_has_A_FK on C_has_A (C_SSN ASC)
go

/*==============================================================*/
/* Table: Customer                                              */
/*==============================================================*/
create table Customer (
   C_SSN                int                  not null,
   C_name               varchar(255)         not null,
   C_addr               varchar(255)         not null,
   C_phone              int                  not null,
   constraint PK_CUSTOMER primary key (C_SSN)
)
go

/*==============================================================*/
/* Table: DealWith                                              */
/*==============================================================*/
create table DealWith (
   E_ID                 int                  not null,
   C_SSN                int                  not null,
   constraint PK_DEALWITH primary key (E_ID, C_SSN)
)
go

/*==============================================================*/
/* Index: DealWith2_FK                                          */
/*==============================================================*/




create nonclustered index DealWith2_FK on DealWith (C_SSN ASC)
go

/*==============================================================*/
/* Index: DealWith_FK                                           */
/*==============================================================*/




create nonclustered index DealWith_FK on DealWith (E_ID ASC)
go

/*==============================================================*/
/* Table: Employee                                              */
/*==============================================================*/
create table Employee (
   E_ID                 int                  not null,
   Admin_ID             int                  not null,
   Bank_code            int                  not null,
   Branch_num           int                  not null,
   E_name               varchar(255)         not null,
   E_phone              int                  not null,
   E_addr               varchar(255)         not null,
   constraint PK_EMPLOYEE primary key (E_ID)
)
go

/*==============================================================*/
/* Index: B_has_E_FK                                            */
/*==============================================================*/




create nonclustered index B_has_E_FK on Employee (Admin_ID ASC,
  Bank_code ASC,
  Branch_num ASC)
go

/*==============================================================*/
/* Table: "Industey _Loan"                                      */
/*==============================================================*/
create table "Industey _Loan" (
   L_num                int                  not null,
   Admin_ID             int                  not null,
   Bank_code            int                  not null,
   Branch_num           int                  not null,
   C_SSN                int                  not null,
   E_ID                 int                  not null,
   L_type               varchar(255)         not null,
   L_amount             numeric(38)          not null,
   Status               varchar(255)         null,
   factory_name         varchar(255)         not null,
   industury_type       varchar(255)         not null,
   constraint "PK_INDUSTEY _LOAN" primary key (L_num)
)
go

/*==============================================================*/
/* Table: Loan                                                  */
/*==============================================================*/
create table Loan (
   L_num                int                  not null,
   Admin_ID             int                  not null,
   Bank_code            int                  not null,
   Branch_num           int                  not null,
   C_SSN                int                  not null,
   E_ID                 int                  not null,
   L_type               varchar(255)         not null,
   L_amount             numeric(38)          not null,
   Status               varchar(255)         null,
   constraint PK_LOAN primary key (L_num)
)
go

/*==============================================================*/
/* Index: offer_FK                                              */
/*==============================================================*/




create nonclustered index offer_FK on Loan (Admin_ID ASC,
  Bank_code ASC,
  Branch_num ASC)
go

/*==============================================================*/
/* Index: take_FK                                               */
/*==============================================================*/




create nonclustered index take_FK on Loan (C_SSN ASC)
go

/*==============================================================*/
/* Index: make_FK                                               */
/*==============================================================*/




create nonclustered index make_FK on Loan (E_ID ASC)
go

/*==============================================================*/
/* Table: commercial_loan                                       */
/*==============================================================*/
create table commercial_loan (
   L_num                int                  not null,
   Admin_ID             int                  not null,
   Bank_code            int                  not null,
   Branch_num           int                  not null,
   C_SSN                int                  not null,
   E_ID                 int                  not null,
   L_type               varchar(255)         not null,
   L_amount             numeric(38)          not null,
   Status               varchar(255)         null,
   company_name         varchar(255)         not null,
   comerical_type       varchar(255)         not null,
   constraint PK_COMMERCIAL_LOAN primary key (L_num)
)
go

/*==============================================================*/
/* Table: deal_with                                             */
/*==============================================================*/
create table deal_with (
   C_SSN                int                  not null,
   Admin_ID             int                  not null,
   Bank_code            int                  not null,
   Branch_num           int                  not null,
   constraint PK_DEAL_WITH primary key (C_SSN, Admin_ID, Bank_code, Branch_num)
)
go

/*==============================================================*/
/* Index: deal_with2_FK                                         */
/*==============================================================*/




create nonclustered index deal_with2_FK on deal_with (Admin_ID ASC,
  Bank_code ASC,
  Branch_num ASC)
go

/*==============================================================*/
/* Index: deal_with_FK                                          */
/*==============================================================*/




create nonclustered index deal_with_FK on deal_with (C_SSN ASC)
go

alter table Bank
   add constraint FK_BANK_CONTROLL__ADMIN foreign key (Admin_ID)
      references Admin (Admin_ID)
go

alter table Branch
   add constraint FK_BRANCH_HAS_BANK foreign key (Admin_ID, Bank_code)
      references Bank (Admin_ID, Bank_code)
go

alter table C_has_A
   add constraint FK_C_HAS_A_C_HAS_A_CUSTOMER foreign key (C_SSN)
      references Customer (C_SSN)
go

alter table C_has_A
   add constraint FK_C_HAS_A_C_HAS_A2_ACCOUNT foreign key (A_num)
      references Account (A_num)
go

alter table DealWith
   add constraint FK_DEALWITH_DEALWITH_EMPLOYEE foreign key (E_ID)
      references Employee (E_ID)
go

alter table DealWith
   add constraint FK_DEALWITH_DEALWITH2_CUSTOMER foreign key (C_SSN)
      references Customer (C_SSN)
go

alter table Employee
   add constraint FK_EMPLOYEE_B_HAS_E_BRANCH foreign key (Admin_ID, Bank_code, Branch_num)
      references Branch (Admin_ID, Bank_code, Branch_num)
go

alter table "Industey _Loan"
   add constraint FK_INDUSTEY_OVERLAP2_LOAN foreign key (L_num)
      references Loan (L_num)
go

alter table Loan
   add constraint FK_LOAN_MAKE_EMPLOYEE foreign key (E_ID)
      references Employee (E_ID)
go

alter table Loan
   add constraint FK_LOAN_OFFER_BRANCH foreign key (Admin_ID, Bank_code, Branch_num)
      references Branch (Admin_ID, Bank_code, Branch_num)
go

alter table Loan
   add constraint FK_LOAN_TAKE_CUSTOMER foreign key (C_SSN)
      references Customer (C_SSN)
go

alter table commercial_loan
   add constraint FK_COMMERCI_OVERLAP_LOAN foreign key (L_num)
      references Loan (L_num)
go

alter table deal_with
   add constraint FK_DEAL_WIT_DEAL_WITH_CUSTOMER foreign key (C_SSN)
      references Customer (C_SSN)
go

alter table deal_with
   add constraint FK_DEAL_WIT_DEAL_WITH_BRANCH foreign key (Admin_ID, Bank_code, Branch_num)
      references Branch (Admin_ID, Bank_code, Branch_num)
go

