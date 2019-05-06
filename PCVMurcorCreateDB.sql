Use pcvmurcordb;
CREATE TABLE `applicationaccess` (
    `userID` INT(11) NOT NULL,
    `VMSroleGroup` VARCHAR(255) DEFAULT NULL,
    `addAccess` VARCHAR(4) DEFAULT NULL,
    `OTSAccess` VARCHAR(255) DEFAULT NULL,
    `BPORoleGroup` VARCHAR(255) DEFAULT NULL,
    `LRVroleGroup` VARCHAR(255) DEFAULT NULL,
    `mas500Access` VARCHAR(255) DEFAULT NULL,
    PRIMARY KEY (`userID`),
    CONSTRAINT `applicationaccess_ibfk_1` FOREIGN KEY (`userID`)
        REFERENCES `user_table` (`userID`)
)  ENGINE=INNODB DEFAULT CHARSET=UTF8MB4 COLLATE = UTF8MB4_0900_AI_CI;

CREATE TABLE `requestinfo` (
  `today_Date` date DEFAULT NULL,
  `requestType` varchar(7) DEFAULT NULL,
  `requestByName` varchar(25) DEFAULT NULL,
  `effectiveStart` datetime DEFAULT NULL,
  `effectiveEnd` datetime DEFAULT NULL,
  `user_ID` int(11) NOT NULL,
  PRIMARY KEY (`user_ID`),
  CONSTRAINT `userID` FOREIGN KEY (`user_ID`) REFERENCES `user_table` (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `user` (
  `username` varchar(16) NOT NULL,
  `password` varchar(32) NOT NULL,
  `user_ID` int(11) NOT NULL,
  PRIMARY KEY (`user_ID`),
  CONSTRAINT `user_ID` FOREIGN KEY (`user_ID`) REFERENCES `user_table` (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `user_requirements` (
  `userID` int(11) NOT NULL,
  `floorNum` int(11) DEFAULT NULL,
  `cubeNum` int(11) DEFAULT NULL,
  `didNum` tinyint(4) DEFAULT NULL,
  `dualMon` tinyint(4) DEFAULT NULL,
  `remoAcc` tinyint(4) DEFAULT NULL,
  `remoLap` tinyint(4) DEFAULT NULL,
  `mobile` tinyint(4) DEFAULT NULL,
  `userStatus` varchar(3) DEFAULT NULL,
  `userName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`userID`),
  CONSTRAINT `user_requirements_ibfk_1` FOREIGN KEY (`userID`) REFERENCES `user_table` (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `user_table` (
  `userID` int(11) NOT NULL,
  `LastName` varchar(255) DEFAULT NULL,
  `FirstName` varchar(255) DEFAULT NULL,
  `department` varchar(255) DEFAULT NULL,
  `office` varchar(255) DEFAULT NULL,
  `managerName` varchar(255) DEFAULT NULL,
  `isManager` bit(1) DEFAULT NULL,
  `dateStart` date DEFAULT NULL,
  `dateEnd` date DEFAULT NULL,
  PRIMARY KEY (`userID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

