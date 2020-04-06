DROP DATABASE IF EXISTS `3dSocial`;
CREATE DATABASE IF NOT EXISTS `3dSocial`;
USE `3dSocial`;

DROP TABLE IF EXISTS `tb_file`;
DROP TABLE IF EXISTS `tb_center`;
DROP TABLE IF EXISTS `tb_project`;
DROP TABLE IF EXISTS `tb_request`;
DROP TABLE IF EXISTS `tb_user`;

CREATE TABLE `tb_file` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Content` BLOB NOT NULL,
  `Created` datetime DEFAULT CURRENT_TIMESTAMP,
  `Modificated` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

CREATE TABLE `tb_center` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Street` varchar(500) DEFAULT NULL,
  `AddressNumber` varchar(50) DEFAULT NULL,
  `District` varchar(500) DEFAULT NULL,
  `City` varchar(500) DEFAULT NULL,
  `State` varchar(5) DEFAULT NULL,
  `Phone` varchar(10) DEFAULT NULL,
  `Ddd` varchar(5) DEFAULT NULL,
  `AllowShowInfo` tinyint(1) NOT NULL,
  `ZipCode` varchar(8) DEFAULT NULL,
  `Document` varchar(255) DEFAULT NULL,
  `Created` datetime DEFAULT CURRENT_TIMESTAMP,
  `Modificated` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

CREATE TABLE `tb_project` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Description` varchar(3000) DEFAULT NULL,
  `File` varchar(255) DEFAULT NULL,
  `Created` datetime DEFAULT CURRENT_TIMESTAMP,
  `Modificated` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

CREATE TABLE `tb_demand` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `ProjectID` int(11) NOT NULL,
  `CenterID` int(11) NOT NULL,
  `TotalNeed` int(11) NOT NULL,
  `TotalDelivered` int(11) NOT NULL,
  `Active` tinyint(1) NOT NULL,
  `Observations` varchar(3000) DEFAULT NULL,
  `Created` datetime DEFAULT CURRENT_TIMESTAMP,
  `Modificated` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;

CREATE TABLE `tb_user` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Pass` varchar(255) DEFAULT NULL,
  `CenterID` int(11) NOT NULL,
  `Created` datetime DEFAULT CURRENT_TIMESTAMP,
  `Modificated` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4;
