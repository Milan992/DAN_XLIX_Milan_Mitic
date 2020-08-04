IF DB_ID('Hotel') IS NULL
CREATE DATABASE Hotel
GO
USE Hotel;


if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblAccount')
drop table tblAccount;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblManager')
drop table tblManager;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblEmployee')
drop table tblEmployee;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblEngagement')
drop table tblEngagement;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblApplication')
drop table tblApplication;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblApplicationStatus')
drop table tblApplicationStatus;


create table tblAccount(
AccountID int identity(1,1) primary key,
FullName varchar(30) not null,
DateOfBirth date not null,
Email varchar(30),
UserName varchar(30) not null unique,
Pass varchar(30) not null)

create table tblEmployee(
EmployeeID int identity(1,1) primary key,
AccountID int foreign key (AccountID) references tblAccount(AccountID) not null,
HotelFloor int,
Gender char(1) check(Gender in ('M', 'F', 'X')) not null,
Cityzenship varchar(30),
EngagementID int foreign key (EngagementID) references tblEngagement(EngagementID) not null,
Salary int)

create table tblManager(
ManagerID int identity(1,1) primary key,
AccountID int foreign key (AccountID) references tblAccount(AccountID) not null,
HotelFloor int,
Experience int,
QualificationsLevel varchar(3) check(QualificationsLevel in ('I', 'II', 'III', 'IV', 'V', 'VI', 'VII')) not null)