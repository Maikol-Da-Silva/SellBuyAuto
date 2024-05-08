-- --------------------------------------------------------
-- Hôte:                         web24.swisscenter.com
-- Version du serveur:           8.0.33-cll-lve - MySQL Community Server - GPL
-- SE du serveur:                Linux
-- HeidiSQL Version:             12.5.0.6677
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour 2024mca_auto
CREATE DATABASE IF NOT EXISTS `2024mca_auto` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `2024mca_auto`;

-- Listage de la structure de la table 2024mca_auto. Brands
DROP TABLE IF EXISTS `Brands`;
CREATE TABLE IF NOT EXISTS `Brands` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Name_UNIQUE` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table 2024mca_auto.Brands : ~20 rows (environ)
INSERT INTO `Brands` (`id`, `Name`) VALUES
	(7, 'Audi'),
	(3, 'BMW'),
	(8, 'Chevrolet'),
	(18, 'Fiat'),
	(2, 'Ford'),
	(4, 'Honda'),
	(9, 'Hyundai'),
	(15, 'Jeep'),
	(11, 'Kia'),
	(16, 'Lexus'),
	(14, 'Mazda'),
	(6, 'Mercedes-Benz'),
	(10, 'Nissan'),
	(19, 'Peugeot'),
	(20, 'Renault'),
	(13, 'Subaru'),
	(17, 'Tesla'),
	(1, 'Toyota'),
	(5, 'Volkswagen'),
	(12, 'Volvo');

-- Listage de la structure de la table 2024mca_auto. Cars
DROP TABLE IF EXISTS `Cars`;
CREATE TABLE IF NOT EXISTS `Cars` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Year` smallint unsigned NOT NULL,
  `mileage` mediumint unsigned NOT NULL,
  `Images` varchar(255) NOT NULL,
  `Description` longtext,
  `model_id` int NOT NULL,
  `engineType_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Cars_Brands1_idx` (`model_id`),
  KEY `fk_Cars_EngineTypes1_idx` (`engineType_id`),
  CONSTRAINT `fk_Cars_Brands1` FOREIGN KEY (`model_id`) REFERENCES `Models` (`id`),
  CONSTRAINT `fk_Cars_EngineTypes1` FOREIGN KEY (`engineType_id`) REFERENCES `EngineTypes` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table 2024mca_auto.Cars : ~43 rows (environ)
INSERT INTO `Cars` (`id`, `Year`, `mileage`, `Images`, `Description`, `model_id`, `engineType_id`) VALUES
	(1, 2020, 150000, '1_1.jpg/1_2.jpg', 'La Toyota Corolla est une voiture compacte produite depuis 1966 par le constructeur automobile japonais Toyota.', 1, 1),
	(2, 2019, 20000, '2_1.jpg/2_2.jpg', 'La Toyota Camry est une berline intermédiaire produite par Toyota, lancée pour la première fois en 1982.', 2, 1),
	(3, 2000, 40000, '3_1.jpg/3_2.jpg', 'La Toyota Supra est une voiture de sport produite par le constructeur automobile japonais Toyota.', 3, 1),
	(4, 2021, 10000, '4_1.jpg/4_2.jpg', 'Le Ford F-150 est un modèle de camionnette produit par le constructeur automobile américain Ford depuis 1948.', 4, 1),
	(5, 2018, 30000, '5_1.jpg/5_2.jpg', 'La Ford Focus est une voiture compacte produite par le constructeur automobile américain Ford depuis 1998.', 5, 1),
	(6, 2022, 5000, '6_1.jpg/6_2.jpg', 'La BMW Série 3 est une gamme de modèles de voitures compactes de luxe fabriquée par la filiale allemande du constructeur automobile BMW depuis mai 1975.', 6, 1),
	(7, 2021, 120000, '7_1.jpg/7_2.jpg', 'La BMW Série 5 est une gamme de modèles de voitures de luxe produite par la filiale allemande du constructeur automobile BMW.', 7, 1),
	(8, 2020, 18000, '8_1.jpg/8_2.jpg', 'La Honda Accord est une automobile produite par le constructeur automobile japonais Honda.', 8, 1),
	(9, 2019, 220000, '9_1.jpg/9_2.jpg', 'La Honda Civic est un modèle d\'automobile fabriqué par Honda.', 9, 1),
	(10, 2021, 9000, '10_1.jpg/10_2.jpg', 'La Volkswagen Golf est une voiture familiale compacte produite par le constructeur automobile allemand Volkswagen depuis 1974.', 10, 1),
	(11, 2022, 7000, '11_1.jpg/11_2.jpg', 'La Volkswagen Passat est une grande familiale fabriquée par Volkswagen AG depuis 1973.', 11, 1),
	(12, 2022, 6000, '12_1.jpg/12_2.jpg', 'La Mercedes-Benz Classe C est une gamme de voitures compactes de luxe produites par le constructeur allemand Mercedes-Benz.', 12, 1),
	(13, 2021, 10000, '13_1.jpg/13_2.jpg', 'La Mercedes-Benz Classe E est une gamme de voitures exécutives produites par le constructeur automobile allemand Mercedes-Benz.', 13, 1),
	(14, 2020, 11000, '14_1.jpg/14_2.jpg', 'L\'Audi A4 est une berline familiale du constructeur automobile allemand Audi.', 14, 1),
	(15, 2021, 8000, '15_1.jpg/15_2.jpg', 'L\'Audi A6 est une berline de luxe produite par Audi, filiale du groupe allemand Volkswagen AG.', 15, 1),
	(16, 2019, 80000, '16_1.jpg/16_2.jpg/16_3.jpg', 'La Audi RS3 est une voiture compacte sportive produite par le constructeur automobile allemand Audi AG.', 16, 1),
	(17, 2020, 14000, '17_1.jpg/17_2.jpg', 'La Chevrolet Camaro est une automobile de type pony car produite par General Motors Chevrolet.', 17, 1),
	(18, 2021, 110000, '18_1.jpg/18_2.jpg', 'Le Chevrolet Silverado et son jumeau le GMC Sierra sont des pick-up de grande taille construits par General Motors.', 18, 1),
	(19, 2021, 16000, '19_1.jpg/19_2.jpg', 'Le Hyundai Tucson est un SUV compact produit par le constructeur automobile sud-coréen Hyundai Motor Company depuis 2004.', 19, 1),
	(20, 2020, 13000, '20_1.jpg/20_2.jpg', 'Le Hyundai Santa Fe est un SUV familial produit par le constructeur automobile sud-coréen Hyundai depuis 2000.', 20, 1),
	(21, 2019, 19000, '21_1.jpg/21_2.jpg', 'La Nissan Altima est une automobile de taille moyenne produite par Nissan, constructeur automobile japonais.', 21, 1),
	(22, 2020, 5000, '22_1.jpg/22_2.jpg', 'La Nissan GT-R est une voiture de sport 2+2 places produite par le constructeur automobile japonais Nissan.', 22, 1),
	(23, 2020, 12000, '23_1.jpg/23_2.jpg', 'La Nissan Maxima est une voiture berline intermédiaire produite par Nissan.', 23, 1),
	(24, 2021, 15000, '24_1.jpg/24_2.jpg', 'Le Kia Sorento est un SUV produit par le constructeur automobile sud-coréen Kia Motors.', 24, 1),
	(25, 2020, 11000, '25_1.jpg/25_2.jpg', 'La Kia Optima est une berline familiale produite par Kia Motors.', 25, 1),
	(26, 2021, 8000, '26_1.jpg/26_2.jpg', 'La Volvo S60 est une voiture berline produite par Volvo Cars depuis 2000.', 26, 1),
	(27, 2022, 7000, '27_1.jpg/27_2.jpg', 'Le Volvo XC90 est un SUV de luxe fabriqué par le constructeur automobile suédois Volvo Cars.', 27, 1),
	(28, 2021, 10000, '28_1.jpg/28_2.jpg', 'La Subaru Outback est une voiture familiale crossover / SUV fabriquée par Subaru depuis 1994.', 28, 1),
	(29, 2022, 6000, '29_1.jpg/29_2.jpg', 'Le Subaru Forester est un véhicule utilitaire sportif (SUV) compact fabriqué par Subaru.', 29, 1),
	(30, 2020, 13000, '30_1.jpg/30_2.jpg', 'Le Mazda CX-5 est un véhicule utilitaire sportif (SUV) compact fabriqué par Mazda.', 30, 1),
	(31, 2021, 9000, '31_1.jpg/31_2.jpg', 'La Mazda3 est une berline compacte produite par le constructeur automobile japonais Mazda depuis 2003.', 31, 1),
	(32, 2022, 4000, '32_1.jpg/32_2.jpg', 'La Jeep Wrangler est un véhicule utilitaire sportif compact, produit par le constructeur automobile américain Jeep.', 32, 1),
	(33, 2020, 8000, '33_1.jpg/33_2.jpg', 'Le Jeep Cherokee est un SUV compact fabriqué par Jeep depuis 1974.', 33, 1),
	(34, 2021, 7000, '34_1.jpg/34_2.jpg', 'Le Lexus UX est un crossover compact produit par Lexus, la division de luxe de Toyota.', 34, 1),
	(35, 2020, 100000, '35_1.jpg/35_2.jpg', 'Le Lexus RX est un véhicule utilitaire sportif de luxe fabriqué par Lexus.', 35, 1),
	(36, 2022, 3000, '36_1.jpg/36_2.jpg', 'La Tesla Model S est une berline électrique produite par Tesla, Inc.', 36, 3),
	(37, 2021, 5000, '37_1.jpg/37_2.jpg', 'La Tesla Model 3 est une voiture électrique compacte de Tesla, Inc.', 37, 3),
	(38, 2021, 8000, '38_1.jpg/38_2.jpg', 'La Fiat 500 est une petite voiture citadine fabriquée par le constructeur italien Fiat depuis 2007.', 38, 1),
	(39, 2020, 9000, '39_1.jpg/39_2.jpg', 'La Fiat Panda est une petite voiture produite par le constructeur automobile italien Fiat.', 39, 1),
	(40, 2022, 4000, '40_1.jpg/40_2.jpg', 'La Peugeot 208 est une citadine du constructeur automobile français Peugeot, commercialisée depuis 2019.', 40, 1),
	(41, 2021, 60000, '41_1.jpg/41_2.jpg', 'La Peugeot 3008 est un crossover compact produit par le constructeur français Peugeot depuis 2008.', 41, 1),
	(42, 2020, 11000, '42_1.jpg/42_2.jpg', 'La Renault Clio est une citadine polyvalente fabriquée par le constructeur français Renault.', 42, 1),
	(43, 2021, 7000, '43_1.jpg/43_2.jpg', 'Le Renault Captur est un SUV urbain polyvalent produit par le constructeur français Renault.', 43, 1);

-- Listage de la structure de la table 2024mca_auto. EngineTypes
DROP TABLE IF EXISTS `EngineTypes`;
CREATE TABLE IF NOT EXISTS `EngineTypes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Type` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Name_UNIQUE` (`Type`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table 2024mca_auto.EngineTypes : ~3 rows (environ)
INSERT INTO `EngineTypes` (`id`, `Type`) VALUES
	(2, 'Diesel'),
	(3, 'Électrique'),
	(1, 'Essence');

-- Listage de la structure de la table 2024mca_auto. Models
DROP TABLE IF EXISTS `Models`;
CREATE TABLE IF NOT EXISTS `Models` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `brand_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `Name_UNIQUE` (`Name`),
  KEY `fk_Models_Brands1_idx` (`brand_id`),
  CONSTRAINT `fk_Models_Brands1` FOREIGN KEY (`brand_id`) REFERENCES `Brands` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table 2024mca_auto.Models : ~43 rows (environ)
INSERT INTO `Models` (`id`, `Name`, `brand_id`) VALUES
	(1, 'Corolla', 1),
	(2, 'Camry', 1),
	(3, 'Supra', 1),
	(4, 'F-150', 2),
	(5, 'Focus', 2),
	(6, 'Série 3', 3),
	(7, 'Série 5', 3),
	(8, 'Accord', 4),
	(9, 'Civic', 4),
	(10, 'Golf', 5),
	(11, 'Passat', 5),
	(12, 'Classe C', 6),
	(13, 'Classe E', 6),
	(14, 'A4', 7),
	(15, 'A6', 7),
	(16, 'RS3', 7),
	(17, 'Camaro', 8),
	(18, 'Silverado', 8),
	(19, 'Tucson', 9),
	(20, 'Santa Fe', 9),
	(21, 'Altima', 10),
	(22, 'GTR R35', 10),
	(23, 'Maxima', 10),
	(24, 'Sorento', 11),
	(25, 'Optima', 11),
	(26, 'S60', 12),
	(27, 'XC90', 12),
	(28, 'Outback', 13),
	(29, 'Forester', 13),
	(30, 'CX-5', 14),
	(31, 'Mazda3', 14),
	(32, 'Wrangler', 15),
	(33, 'Cherokee', 15),
	(34, 'UX', 16),
	(35, 'RX', 16),
	(36, 'Model S', 17),
	(37, 'Model 3', 17),
	(38, '500', 18),
	(39, 'Panda', 18),
	(40, '208', 19),
	(41, '3008', 19),
	(42, 'Clio', 20),
	(43, 'Captur', 20);

-- Listage de la structure de la table 2024mca_auto. Notices
DROP TABLE IF EXISTS `Notices`;
CREATE TABLE IF NOT EXISTS `Notices` (
  `id` int NOT NULL AUTO_INCREMENT,
  `PublicationDate` date NOT NULL,
  `BuyDate` date DEFAULT NULL,
  `Price` int unsigned NOT NULL,
  `Active` tinyint DEFAULT '1',
  `Blocked` tinyint DEFAULT '0',
  `buyer_id` int DEFAULT NULL,
  `seller_id` int NOT NULL,
  `car_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Notices_Users2_idx` (`buyer_id`),
  KEY `fk_Notices_Cars1_idx` (`car_id`),
  KEY `fk_Notices_Users1_idx` (`seller_id`),
  CONSTRAINT `fk_Notices_Cars1` FOREIGN KEY (`car_id`) REFERENCES `Cars` (`id`),
  CONSTRAINT `fk_Notices_Users1` FOREIGN KEY (`seller_id`) REFERENCES `Users` (`id`),
  CONSTRAINT `fk_Notices_Users2` FOREIGN KEY (`buyer_id`) REFERENCES `Users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table 2024mca_auto.Notices : ~43 rows (environ)
INSERT INTO `Notices` (`id`, `PublicationDate`, `BuyDate`, `Price`, `Active`, `Blocked`, `buyer_id`, `seller_id`, `car_id`) VALUES
	(1, '2024-04-01', NULL, 15000, 1, 0, NULL, 13, 1),
	(2, '2024-04-02', NULL, 20000, 1, 0, NULL, 5, 2),
	(3, '2024-04-03', NULL, 40000, 1, 0, NULL, 17, 3),
	(4, '2024-04-04', NULL, 35000, 1, 0, NULL, 14, 4),
	(5, '2024-04-05', NULL, 25000, 1, 0, NULL, 10, 5),
	(6, '2024-04-06', NULL, 40000, 1, 0, NULL, 12, 6),
	(7, '2024-04-07', NULL, 55000, 1, 0, NULL, 11, 7),
	(8, '2024-04-08', NULL, 30000, 1, 0, NULL, 8, 8),
	(9, '2024-04-09', NULL, 25000, 1, 0, NULL, 4, 9),
	(10, '2024-04-10', NULL, 35000, 1, 0, NULL, 13, 10),
	(11, '2024-04-11', NULL, 30000, 1, 0, NULL, 15, 11),
	(12, '2024-04-12', NULL, 45000, 1, 0, NULL, 2, 12),
	(13, '2024-04-13', NULL, 60000, 1, 0, NULL, 3, 13),
	(14, '2024-04-14', NULL, 40000, 1, 0, NULL, 7, 14),
	(15, '2024-04-15', NULL, 50000, 1, 0, NULL, 9, 15),
	(16, '2024-04-16', NULL, 60000, 1, 0, NULL, 16, 16),
	(17, '2024-04-17', NULL, 35000, 1, 0, NULL, 1, 17),
	(18, '2024-04-18', NULL, 40000, 1, 0, NULL, 4, 18),
	(19, '2024-04-19', NULL, 30000, 1, 0, NULL, 6, 19),
	(20, '2024-04-20', NULL, 25000, 1, 0, NULL, 8, 20),
	(21, '2024-04-21', NULL, 35000, 1, 0, NULL, 11, 21),
	(22, '2024-04-22', NULL, 80000, 1, 0, NULL, 17, 22),
	(23, '2024-04-23', NULL, 40000, 1, 0, NULL, 15, 23),
	(24, '2024-04-24', NULL, 30000, 1, 0, NULL, 1, 24),
	(25, '2024-04-25', NULL, 25000, 1, 0, NULL, 3, 25),
	(26, '2024-04-26', NULL, 40000, 1, 0, NULL, 5, 26),
	(27, '2024-04-27', NULL, 70000, 1, 0, NULL, 7, 27),
	(28, '2024-04-28', NULL, 45000, 1, 0, NULL, 9, 28),
	(29, '2024-04-29', NULL, 35000, 1, 0, NULL, 11, 29),
	(30, '2024-04-30', NULL, 30000, 1, 0, NULL, 13, 30),
	(31, '2024-05-01', NULL, 25000, 1, 0, NULL, 15, 31),
	(32, '2024-05-02', NULL, 50000, 1, 0, NULL, 2, 32),
	(33, '2024-05-03', NULL, 40000, 1, 0, NULL, 4, 33),
	(34, '2024-05-04', NULL, 45000, 1, 0, NULL, 6, 34),
	(35, '2024-05-05', NULL, 60000, 1, 0, NULL, 8, 35),
	(36, '2024-05-06', NULL, 80000, 1, 0, NULL, 10, 36),
	(37, '2024-05-07', NULL, 70000, 1, 0, NULL, 12, 37),
	(38, '2024-05-08', NULL, 35000, 1, 0, NULL, 14, 38),
	(39, '2024-05-09', NULL, 25000, 1, 0, NULL, 2, 39),
	(40, '2024-05-10', NULL, 40000, 1, 0, NULL, 7, 40),
	(41, '2024-05-11', NULL, 55000, 1, 0, NULL, 14, 41),
	(42, '2024-05-12', NULL, 30000, 1, 0, NULL, 1, 42),
	(43, '2024-05-13', NULL, 35000, 1, 0, NULL, 11, 43);

-- Listage de la structure de la table 2024mca_auto. Users
DROP TABLE IF EXISTS `Users`;
CREATE TABLE IF NOT EXISTS `Users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(255) NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Admin` tinyint DEFAULT '0',
  `Blocked` tinyint DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `Email_UNIQUE` (`Email`),
  UNIQUE KEY `Username_UNIQUE` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table 2024mca_auto.Users : ~17 rows (environ)
INSERT INTO `Users` (`id`, `Email`, `Username`, `Password`, `Admin`, `Blocked`) VALUES
	(1, 'utilisateur1@example.com', 'JohnDoe', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(2, 'utilisateur2@example.com', 'AliceSmith', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(3, 'utilisateur3@example.com', 'DavidBrown', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(4, 'utilisateur4@example.com', 'EmilyJohnson', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(5, 'utilisateur5@example.com', 'MichaelWilliams', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(6, 'utilisateur6@example.com', 'SarahWilson', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(7, 'utilisateur7@example.com', 'JamesTaylor', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(8, 'utilisateur8@example.com', 'EmmaMartinez', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(9, 'utilisateur9@example.com', 'DanielJones', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(10, 'utilisateur10@example.com', 'OliviaBrown', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(11, 'utilisateur11@example.com', 'MatthewThomas', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(12, 'utilisateur12@example.com', 'AvaGarcia', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(13, 'utilisateur13@example.com', 'WilliamRodriguez', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(14, 'utilisateur14@example.com', 'SophiaLopez', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(15, 'utilisateur15@example.com', 'JosephLee', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(16, 'utilisateur16@example.com', 'Dragtsu', '3CC31CD246149AEC68079241E71E98F6', 0, 0),
	(17, 'admin@example.com', 'Admin', '3CC31CD246149AEC68079241E71E98F6', 1, 0);

-- Listage de la structure de la table 2024mca_auto. Users_Bookmark_Notice
DROP TABLE IF EXISTS `Users_Bookmark_Notice`;
CREATE TABLE IF NOT EXISTS `Users_Bookmark_Notice` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `notice_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `unique_index` (`user_id`,`notice_id`),
  KEY `fk_Users_has_Notice_Notice1_idx` (`notice_id`),
  KEY `fk_Users_has_Notice_Users1_idx` (`user_id`),
  CONSTRAINT `fk_Users_has_Notice_Notice1` FOREIGN KEY (`notice_id`) REFERENCES `Notices` (`id`),
  CONSTRAINT `fk_Users_has_Notice_Users1` FOREIGN KEY (`user_id`) REFERENCES `Users` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb3;

-- Listage des données de la table 2024mca_auto.Users_Bookmark_Notice : ~14 rows (environ)
INSERT INTO `Users_Bookmark_Notice` (`id`, `user_id`, `notice_id`) VALUES
	(1, 1, 1),
	(2, 1, 2),
	(3, 1, 3),
	(4, 2, 4),
	(5, 2, 5),
	(6, 2, 6),
	(7, 3, 7),
	(8, 3, 8),
	(9, 4, 9),
	(10, 4, 10),
	(11, 5, 11),
	(12, 5, 12),
	(13, 16, 3),
	(14, 16, 22);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
