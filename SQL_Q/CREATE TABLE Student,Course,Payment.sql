USE MelodyMusic;

CREATE TABLE Student(
RegNo varchar(50) PRIMARY KEY NOT NULL,
FName varchar(50),
LName varchar(50),
Address varchar(500),
DOB varchar(50),
Contact varchar(50),
Age varchar(50)
);


CREATE TABLE Course(
COID varchar(50) PRIMARY KEY NOT NULL,
CName varchar(50),
Division varchar(50),
CDuration varchar(50),
CFee varchar(50),
);


CREATE TABLE Payment(
RegNO varchar(50) PRIMARY KEY NOT NULL,
CName varchar(50),
Payment varchar(50),
Amount varchar(50)
);
