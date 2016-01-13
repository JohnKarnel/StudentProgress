CREATE DATABASE StudentProgressDB
ON
(
	NAME = 'StudentProgressDB',
	FILENAME = 'D:\STUDING\Projects_C#\Visual Studio 2013\Projects\StudentProgress\Data\StudentProgressDB.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'LogStudentProgressDB',
	FILENAME = 'D:\STUDING\Projects_C#\Visual Studio 2013\Projects\StudentProgress\Data\StudentProgressDB.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)
COLLATE Cyrillic_General_CI_AS
GO
 
use StudentProgressDB

create table Teacher
(
	TeacherID varchar(50) primary key not null,
	SName varchar(25) not null,
	Name varchar(25) not null,
	PName varchar(25) not null,
	[Login] varchar(25) unique not null,
	[Password] varchar(25) not null,
)

create table [Group]
(
	GroupID varchar(50) primary key not null,
	Name varchar(25) not null
)

create table [Subject]
(
	SubjectID varchar(50) primary key not null,
	Name varchar(25) not null
)

create table StudingTheSubject
(
	StudingTheSubjectID varchar(50) primary key not null,
	SubjectID varchar(50) foreign key references [Subject](SubjectID) not null,
	GroupID varchar(50) foreign key references [Group](GroupID) not null,
	TeacherID varchar(50) foreign key references Teacher(TeacherID) not null,
	[Day] varchar(25) not null,
	TypeOfWeek varchar(25) not null,
	TypeOfPair varchar(25) not null,
	ClassRoom int not null
)

create table Student
(
	StudentID varchar(50) primary key not null,
	SName varchar(25) not null,
	Name varchar(25) not null,
	PName varchar(25) not null,
	GroupID varchar(50) foreign key references [Group](GroupID) not null
)

insert into Teacher
values('F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4', 'Хмелюк', 'Володимир','Сергійович','111', '111')

create table Presence
(
	PresenceID varchar(50) primary key not null,
	StudentID varchar(50) foreign key references Student(StudentID) not null,
	PairID varchar(50) foreign key references [StudingTheSubject](StudingTheSubjectID) not null,
	[Date] smalldatetime not null,
	Presence bit not null
)

create table TimeTable
(
	TimeTableID varchar(50) primary key not null,
	FirstWeek date not null,
	SecondWeek date not null,
	TeacherID varchar(50) foreign key references Teacher(TeacherID) not null
)

drop table Presence
drop table [Group]

delete Teacher

select * from Teacher