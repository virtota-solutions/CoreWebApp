DROP DATABASE IF EXISTS pcvmurcordb;

CREATE DATABASE pcvmurcordb;

USE pcvmurcordb;

CREATE TABLE applicationaccess (
  userID int(11) NOT NULL,
  VMSroleGroup varchar(255) DEFAULT NULL,
  addAccess varchar(4) DEFAULT NULL,
  OTSAccess varchar(255) DEFAULT NULL,
  BPORoleGroup varchar(255) DEFAULT NULL,
  LRVroleGroup varchar(255) DEFAULT NULL,
  mas500Access varchar(255) DEFAULT NULL,
  PRIMARY KEY (userID),
  CONSTRAINT applicationaccess_ibfk_1 FOREIGN KEY (userID) REFERENCES user_table (userID)
) 

CREATE TABLE requestinfo (
  today_Date date DEFAULT NULL,
  requestType varchar(7) DEFAULT NULL,
  requestByName varchar(25) DEFAULT NULL,
  effectiveStart datetime DEFAULT NULL,
  effectiveEnd datetime DEFAULT NULL,
  user_ID int(11) NOT NULL,
  PRIMARY KEY (user_ID),
  CONSTRAINT userID FOREIGN KEY (user_ID) REFERENCES user_table (userID)
) 

CREATE TABLE user (
  username varchar(16) NOT NULL,
  password varchar(32) NOT NULL,
  user_ID int(11) NOT NULL,
  PRIMARY KEY (user_ID),
  CONSTRAINT user_ID FOREIGN KEY (user_ID) REFERENCES user_table (userID)
) 

CREATE TABLE user_requirements (
  userID int(11) NOT NULL,
  floorNum int(11) DEFAULT NULL,
  cubeNum int(11) DEFAULT NULL,
  didNum tinyint(4) DEFAULT NULL,
  dualMon tinyint(4) DEFAULT NULL,
  remoAcc tinyint(4) DEFAULT NULL,
  remoLap tinyint(4) DEFAULT NULL,
  mobile tinyint(4) DEFAULT NULL,
  userStatus varchar(3) DEFAULT NULL,
  userName varchar(255) DEFAULT NULL,
  PRIMARY KEY (userID),
  CONSTRAINT user_requirements_ibfk_1 FOREIGN KEY (userID) REFERENCES user_table (userID)
) 

CREATE TABLE user_table (
  userID int(11) NOT NULL,
  LastName varchar(255) DEFAULT NULL,
  FirstName varchar(255) DEFAULT NULL,
  department varchar(255) DEFAULT NULL,
  office varchar(255) DEFAULT NULL,
  managerName varchar(255) DEFAULT NULL,
  isManager bit(1) DEFAULT NULL,
  dateStart date DEFAULT NULL,
  dateEnd date DEFAULT NULL,
  PRIMARY KEY (userID)
) 



