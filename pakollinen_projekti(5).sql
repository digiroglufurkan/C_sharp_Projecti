-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 10, 2022 at 09:38 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

--
-- Database: `pakollinenprojekti`
--

-- --------------------------------------------------------

--
-- Table structure for table `jaettavat_tiedostot`
--

CREATE TABLE `jaettavat_tiedostot` (
  `JaettevatID` varchar(32) NOT NULL,
  `Jakaja` varchar(32) NOT NULL,
  `JAETTU_KAYTTAJA` varchar(32) NOT NULL,
  `Jaettu_Tiedosto` int(32) NOT NULL,
  `DATE` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `kayttajat`
--

CREATE TABLE `kayttajat` (
  `KAYTTAJA_TUNNUS` varchar(32) NOT NULL,
  `ETUNIMI` varchar(32) NOT NULL,
  `SUKUNIMI` varchar(32) NOT NULL,
  `EMAIL` varchar(64) NOT NULL,
  `PUHELIN` int(32) NOT NULL,
  `OSAITE` varchar(64) NOT NULL,
  `POSTINUMERO` varchar(12) NOT NULL,
  `TOIMIPAIKKA` varchar(32) NOT NULL,
  `TITTELI` varchar(32) NOT NULL,
  `SALASANA` varchar(32) NOT NULL,
  `KUVA` longblob NOT NULL,
  `MAARAAIKA` datetime NOT NULL DEFAULT current_timestamp(),
  `ADMIN` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `keskustelualue`
--

CREATE TABLE `keskustelualue` (
  `KESKUSTELU_ID` int(32) NOT NULL,
  `KAYTTAJA_TUNNUS` varchar(32) NOT NULL,
  `TIEDOSTOT_ID` varchar(32) NOT NULL,
  `KOMMENTTI` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ladattavat_tiedostot`
--

CREATE TABLE `ladattavat_tiedostot` (
  `LadattavatID` int(32) NOT NULL,
  `KAYTTAJA_TUNNUS` varchar(32) NOT NULL,
  `TIEDOSTON_NIMI` varchar(64) NOT NULL,
  `kuvaus` varchar(200) NOT NULL,
  `file_size` mediumint(8) UNSIGNED NOT NULL,
  `Tiedosto` longblob NOT NULL,
  `extension` varchar(20) NOT NULL,
  `Date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `mita_uutta`
--

CREATE TABLE `mita_uutta` (
  `uutta_id` int(10) NOT NULL,
  `LadattavatID` int(32) NOT NULL,
  `TIEDOSTON_NIMI` varchar(64) NOT NULL,
  `kuvaus` varchar(200) NOT NULL,
  `Date` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `otayhteytta`
--

CREATE TABLE `otayhteytta` (
  `ID` int(32) NOT NULL,
  `lahettaja_email` varchar(64) NOT NULL,
  `Aihe` text NOT NULL,
  `Text` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `palaute`
--

CREATE TABLE `palaute` (
  `PALAUTE_ID` int(32) NOT NULL,
  `KAYTTAJA_TUNNUS` varchar(32) NOT NULL,
  `Aihe` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `jaettavat_tiedostot`
--
ALTER TABLE `jaettavat_tiedostot`
  ADD PRIMARY KEY (`JaettevatID`),
  ADD UNIQUE KEY `KAYTTAJA_TUNNUS` (`Jakaja`),
  ADD UNIQUE KEY `JAETTU_KAYTTAJA` (`JAETTU_KAYTTAJA`),
  ADD UNIQUE KEY `Jaettu_Tiedosto` (`Jaettu_Tiedosto`),
  ADD UNIQUE KEY `Jaettu_Tiedosto_2` (`Jaettu_Tiedosto`);

--
-- Indexes for table `kayttajat`
--
ALTER TABLE `kayttajat`
  ADD PRIMARY KEY (`KAYTTAJA_TUNNUS`);

--
-- Indexes for table `keskustelualue`
--
ALTER TABLE `keskustelualue`
  ADD PRIMARY KEY (`KESKUSTELU_ID`),
  ADD UNIQUE KEY `KAYTTAJA_TUNNUS` (`KAYTTAJA_TUNNUS`),
  ADD UNIQUE KEY `TIEDOSTOT_ID` (`TIEDOSTOT_ID`);

--
-- Indexes for table `ladattavat_tiedostot`
--
ALTER TABLE `ladattavat_tiedostot`
  ADD PRIMARY KEY (`LadattavatID`),
  ADD KEY `kayttaja_tunnus` (`KAYTTAJA_TUNNUS`);

--
-- Indexes for table `mita_uutta`
--
ALTER TABLE `mita_uutta`
  ADD PRIMARY KEY (`uutta_id`),
  ADD KEY `ladattat_id` (`LadattavatID`);

--
-- Indexes for table `otayhteytta`
--
ALTER TABLE `otayhteytta`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `palaute`
--
ALTER TABLE `palaute`
  ADD PRIMARY KEY (`PALAUTE_ID`),
  ADD UNIQUE KEY `KAYTTAJA_TUNNUS` (`KAYTTAJA_TUNNUS`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `keskustelualue`
--
ALTER TABLE `keskustelualue`
  MODIFY `KESKUSTELU_ID` int(32) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `ladattavat_tiedostot`
--
ALTER TABLE `ladattavat_tiedostot`
  MODIFY `LadattavatID` int(32) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `mita_uutta`
--
ALTER TABLE `mita_uutta`
  MODIFY `uutta_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `otayhteytta`
--
ALTER TABLE `otayhteytta`
  MODIFY `ID` int(32) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `jaettavat_tiedostot`
--
ALTER TABLE `jaettavat_tiedostot`
  ADD CONSTRAINT `jaettavat_tiedostot_ibfk_1` FOREIGN KEY (`Jakaja`) REFERENCES `kayttajat` (`KAYTTAJA_TUNNUS`),
  ADD CONSTRAINT `jaettavat_tiedostot_ibfk_2` FOREIGN KEY (`JAETTU_KAYTTAJA`) REFERENCES `kayttajat` (`KAYTTAJA_TUNNUS`),
  ADD CONSTRAINT `jaettavat_tiedostot_ibfk_3` FOREIGN KEY (`Jaettu_Tiedosto`) REFERENCES `ladattavat_tiedostot` (`LadattavatID`);

--
-- Constraints for table `keskustelualue`
--
ALTER TABLE `keskustelualue`
  ADD CONSTRAINT `keskustelualue_ibfk_1` FOREIGN KEY (`KAYTTAJA_TUNNUS`) REFERENCES `kayttajat` (`KAYTTAJA_TUNNUS`),
  ADD CONSTRAINT `keskustelualue_ibfk_2` FOREIGN KEY (`TIEDOSTOT_ID`) REFERENCES `jaettavat_tiedostot` (`JaettevatID`);

--
-- Constraints for table `ladattavat_tiedostot`
--
ALTER TABLE `ladattavat_tiedostot`
  ADD CONSTRAINT `kayttaja_tunnus` FOREIGN KEY (`KAYTTAJA_TUNNUS`) REFERENCES `kayttajat` (`KAYTTAJA_TUNNUS`);

--
-- Constraints for table `mita_uutta`
--
ALTER TABLE `mita_uutta`
  ADD CONSTRAINT `ladattat_id` FOREIGN KEY (`LadattavatID`) REFERENCES `ladattavat_tiedostot` (`LadattavatID`);

--
-- Constraints for table `palaute`
--
ALTER TABLE `palaute`
  ADD CONSTRAINT `palaute_ibfk_1` FOREIGN KEY (`KAYTTAJA_TUNNUS`) REFERENCES `kayttajat` (`KAYTTAJA_TUNNUS`);
COMMIT;