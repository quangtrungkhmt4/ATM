USE MASTER
GO
-------------------------
IF EXISTS(SELECT * FROM SYSDATABASES WHERE NAME = 'DBATM')
	DROP DATABASE DBATM

CREATE DATABASE DBATM
-------------------------
USE DBATM
GO
-------------------------
CREATE TABLE Config(
	ConfigID VARCHAR(30) NOT NULL PRIMARY KEY,
	MinWithdraw INT,
	MaxWithdraw INT,
	DateModified TEXT,
	NumPerPage int
)
-------------------------
CREATE TABLE LogType(
	LogTypeID VARCHAR(30) NOT NULL PRIMARY KEY,
	Description NVARCHAR(100)
)
-------------------------
CREATE TABLE Money(
	MoneyID VARCHAR(30) NOT NULL PRIMARY KEY,
	MoneyValue INT
)
-------------------------
CREATE TABLE ATM(
	ATMID VARCHAR(30) NOT NULL PRIMARY KEY,
	Branch NVARCHAR(100),
	Address NVARCHAR(100)
)
-------------------------
CREATE TABLE Stock(
	StockID VARCHAR(30) NOT NULL PRIMARY KEY,
	Quantity INT,
	MoneyID VARCHAR(30),
	ATMID VARCHAR(30),

	CONSTRAINT FK_MONEY FOREIGN KEY(MoneyID)
		REFERENCES Money(MoneyID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_ATM FOREIGN KEY(ATMID)
		REFERENCES ATM(ATMID) ON UPDATE CASCADE ON DELETE CASCADE
)
-------------------------
CREATE TABLE Customer(
	CustID VARCHAR(30) NOT NULL PRIMARY KEY,
	Name NVARCHAR(50),
	Email TEXT,
	Phone TEXT,
	Addr NVARCHAR(100)
)
-------------------------
CREATE TABLE OverDraft(
	ODID VARCHAR(30) NOT NULL PRIMARY KEY,
	Value INT
)
-------------------------
CREATE TABLE WithdrawLimit(
	WDID VARCHAR(30) NOT NULL PRIMARY KEY,
	Value INT
)
-------------------------
CREATE TABLE Account(
	AccountID VARCHAR(30) NOT NULL PRIMARY KEY,
	Balance INT,
	AccountNo TEXT,
	CustID VARCHAR(30),
	ODID VARCHAR(30),
	WDID VARCHAR(30),
	
	CONSTRAINT FK_CUSTOMER FOREIGN KEY(CustID)
		REFERENCES Customer(CustID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_OVER FOREIGN KEY(ODID)
		REFERENCES OverDraft(ODID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_WITHDRAW FOREIGN KEY(WDID)
		REFERENCES WithdrawLimit(WDID) ON UPDATE CASCADE ON DELETE CASCADE
)
-------------------------
CREATE TABLE Card(
	CardNo VARCHAR(30) NOT NULL PRIMARY KEY,
	PIN TEXT,
	Status TEXT,
	StartDate TEXT,
	ExpiredDate TEXT,
	Attempt INT,
	AccountID VARCHAR(30),

	CONSTRAINT FK_ACCOUNT FOREIGN KEY(AccountID)
		REFERENCES Account(AccountID) ON UPDATE CASCADE ON DELETE CASCADE
)
-------------------------
CREATE TABLE Log(
	LogID VARCHAR(30) NOT NULL PRIMARY KEY,
	LogDate TEXT,
	Amount INT,
	Details NVARCHAR(200),
	CardNoTo VARCHAR(30),
	LogTypeID VARCHAR(30),
	ATMID VARCHAR(30),
	CardNo VARCHAR(30),

	CONSTRAINT FK_LOGTYPE FOREIGN KEY(LogTypeID)
		REFERENCES LogType(LogTypeID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_ATMLOG FOREIGN KEY(ATMID)
		REFERENCES ATM(ATMID) ON UPDATE CASCADE ON DELETE CASCADE,
	CONSTRAINT FK_CARD FOREIGN KEY(CardNo)
		REFERENCES Card(CardNo) ON UPDATE CASCADE ON DELETE CASCADE
)

-------------------------
insert into Customer values('cust01',N'Lê Quang Trung','quangtrung0597@gmail.com','0979391619',N'Phú Thọ')
insert into Customer values('cust02',N'Nguyễn Duy Linh','linhskipper@gmail.com','0982610708',N'Hà Nội')
insert into Customer values('cust03',N'Nguyễn Phùng Hải Chung','haichung97@gmail.com','0971472897',N'Hà Nội')
select * from Customer

insert into ATM values('atm01',N'Cầu Giấy',N'Đại học Công Nghiệp Hà Nội')
insert into ATM values('atm02',N'Cầu Giấy',N'Đại học Thương mại Hà Hội')
insert into ATM values('atm03',N'Hà Đông',N'Học viện công nghệ Bưu chính viễn thông')
select * from ATM

insert into Money values('money01',10000)
insert into Money values('money02',20000)
insert into Money values('money03',50000)
insert into Money values('money04',100000)
insert into Money values('money05',200000)
insert into Money values('money06',500000)
select * from Money

insert into Stock values('stock01',500000000,'money01','atm01')
insert into Stock values('stock02',500000000,'money02','atm01')
insert into Stock values('stock03',500000000,'money03','atm01')
insert into Stock values('stock04',500000000,'money04','atm01')
insert into Stock values('stock05',500000000,'money05','atm01')
insert into Stock values('stock06',500000000,'money06','atm01')

insert into Stock values('stock07',500000000,'money01','atm02')
insert into Stock values('stock08',500000000,'money02','atm02')
insert into Stock values('stock09',500000000,'money03','atm02')
insert into Stock values('stock10',500000000,'money04','atm02')
insert into Stock values('stock11',500000000,'money05','atm02')
insert into Stock values('stock12',500000000,'money06','atm02')

insert into Stock values('stock13',500000000,'money01','atm03')
insert into Stock values('stock14',500000000,'money02','atm03')
insert into Stock values('stock15',500000000,'money03','atm03')
insert into Stock values('stock16',500000000,'money04','atm03')
insert into Stock values('stock17',500000000,'money05','atm03')
insert into Stock values('stock18',500000000,'money06','atm03')
select * from Stock
select Quantity from Stock  where ATMID = 'atm01' and MoneyID ='money01'


insert into OverDraft values('od01',0)

insert into WithdrawLimit values('wd01',25000000)

insert into Account values('account01',40000000,'123','cust01','od01','wd01')
insert into Account values('account02',50000000,'456','cust02','od01','wd01')
insert into Account values('account03',10000000,'789','cust03','od01','wd01')
select * from Account


insert into Card values('123456789','12345','normal','01/05/2018','30/05/2019',0,'account01')
insert into Card values('987654321','23456','normal','12/07/2017','12/07/2018',0,'account02')
insert into Card values('112233445','34567','block','04/06/2016','04/06/2017',0,'account03')
select * from Card


insert into LogType values('logtype01','withdraw')
insert into LogType values('logtype02','transfer')
insert into LogType values('logtype03','checkBalance')
insert into LogType values('logtype04','changePIN')
select * from LogType

insert into Log values('log01','05/08/2018',1000000,'success','987654321','logtype02','atm01','123456789')
insert into Log values('log02','07/09/2017',51000000,'success','','logtype03','atm02','987654321')
select * from Log

insert into Config values('config01',50000,25000000,'21/05/2017',5)
select * from Config
