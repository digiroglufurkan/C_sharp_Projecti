-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 27, 2022 at 08:12 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `catering`
--

-- --------------------------------------------------------

--
-- Table structure for table `ateriat`
--

CREATE TABLE `ateriat` (
  `AteriaID` int(3) NOT NULL,
  `AterianNimi` varchar(40) NOT NULL,
  `Kuvaus` varchar(200) NOT NULL,
  `Kategoria` varchar(20) NOT NULL,
  `Hinta` float NOT NULL,
  `Varasto_saldo` int(5) NOT NULL,
  `Varattu` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ateriat`
--

INSERT INTO `ateriat` (`AteriaID`, `AterianNimi`, `Kuvaus`, `Kategoria`, `Hinta`, `Varasto_saldo`, `Varattu`) VALUES
(1, 'Pizza', 'Vehnäjauhoista tehty pohja, tomaattikastiketta, juustoa, kinkkua, pekonia, ananasta', 'Ruoka', 8, 0, 45),
(2, 'KalaKeitto', 'Kala, Patato ...', 'Soup', 10, 20, 5),
(3, 'Burger', 'Pihvi, Salatti ...', 'Soup', 10, 20, 5);

-- --------------------------------------------------------

--
-- Table structure for table `juomatalkoholilliset`
--

CREATE TABLE `juomatalkoholilliset` (
  `JuomaAlkoID` int(4) NOT NULL,
  `Nimi` varchar(30) NOT NULL,
  `Vol` varchar(10) NOT NULL,
  `Hinta` float NOT NULL,
  `Varasto_saldo` int(5) NOT NULL,
  `Varattu` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `juomatalkoholilliset`
--

INSERT INTO `juomatalkoholilliset` (`JuomaAlkoID`, `Nimi`, `Vol`, `Hinta`, `Varasto_saldo`, `Varattu`) VALUES
(1, 'Konjakki', '40%', 12.2, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `juomatalkoholittomat`
--

CREATE TABLE `juomatalkoholittomat` (
  `JuomaID` int(4) NOT NULL,
  `Nimi` varchar(20) NOT NULL,
  `Hinta` float NOT NULL,
  `Varasto_saldo` int(5) NOT NULL,
  `Varattu` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `juomatalkoholittomat`
--

INSERT INTO `juomatalkoholittomat` (`JuomaID`, `Nimi`, `Hinta`, `Varasto_saldo`, `Varattu`) VALUES
(1, 'Kahvi', 2.5, 50, 30),
(2, 'Coca-Cola 0,5', 2.5, 30, 15);

-- --------------------------------------------------------

--
-- Table structure for table `kayttajat`
--

CREATE TABLE `kayttajat` (
  `KayttajaID` int(4) NOT NULL,
  `RoolitID` int(3) NOT NULL,
  `KayttajaTunnus` varchar(20) NOT NULL,
  `Salasana` varchar(35) NOT NULL,
  `Etunimi` varchar(30) NOT NULL,
  `Sukunimi` varchar(35) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Puhelin` int(15) NOT NULL,
  `Titteli` varchar(40) NOT NULL,
  `Osoite` varchar(40) NOT NULL,
  `Postitoimipaikka` varchar(30) NOT NULL,
  `Postinumero` int(5) NOT NULL,
  `YhtioID` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kayttajat`
--

INSERT INTO `kayttajat` (`KayttajaID`, `RoolitID`, `KayttajaTunnus`, `Salasana`, `Etunimi`, `Sukunimi`, `Email`, `Puhelin`, `Titteli`, `Osoite`, `Postitoimipaikka`, `Postinumero`, `YhtioID`) VALUES
(1, 1, 'test', 'sala', 'Enimi', 'Snimi', 'email', 1233232132, '', 'gregerg', 'wrbwbww', 12345, 0),
(3, 2, 'kayt', '5p1JyJ2eO8ZLbj4YdCEWyA==', 'ka', 'ka', 'email', 2563245, '', 'Jokin', 'paikka', 12345, 6),
(4, 3, 'kokki', 'kokki', 'ko', 'ko', 'email', 2563245, '', 'Jokin', 'paikka', 12345, 0),
(5, 2, 'furkan', 'rTNIPc13XS2bVwJ4icYSiw==', 'furkan', 'digiroglu', 'furkan.digiroglu@gmail.com', 452613111, 'mr', 'vantaa', 'vantaa', 1370, 4);

-- --------------------------------------------------------

--
-- Table structure for table `lennot`
--

CREATE TABLE `lennot` (
  `LentoID` int(5) NOT NULL,
  `Lahtopaikka` varchar(50) NOT NULL,
  `Maaranpaa` varchar(50) NOT NULL,
  `LentoAika` double NOT NULL,
  `ICAOkoodi` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lennot`
--

INSERT INTO `lennot` (`LentoID`, `Lahtopaikka`, `Maaranpaa`, `LentoAika`, `ICAOkoodi`) VALUES
(2, 'Helsinki-Vantaa', 'Charles de Gaulle', 3.05, 'FIN');

-- --------------------------------------------------------

--
-- Table structure for table `lentoyhtionyhteyshenkilot`
--

CREATE TABLE `lentoyhtionyhteyshenkilot` (
  `YhtioID` int(4) NOT NULL,
  `YhtionNimi` varchar(40) NOT NULL,
  `ICAOkoodi` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `lentoyhtionyhteyshenkilot`
--

INSERT INTO `lentoyhtionyhteyshenkilot` (`YhtioID`, `YhtionNimi`, `ICAOkoodi`) VALUES
(6, 'Finnair', 'FIN');

-- --------------------------------------------------------

--
-- Table structure for table `roolit`
--

CREATE TABLE `roolit` (
  `RooliId` int(3) NOT NULL,
  `Rooli` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `roolit`
--

INSERT INTO `roolit` (`RooliId`, `Rooli`) VALUES
(1, 'Admin'),
(2, 'Kayttaja'),
(3, 'Kokki');

-- --------------------------------------------------------

--
-- Table structure for table `status`
--

CREATE TABLE `status` (
  `StatusID` int(2) NOT NULL,
  `Status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `status`
--

INSERT INTO `status` (`StatusID`, `Status`) VALUES
(1, 'Odottaa'),
(2, 'Työnalla'),
(3, 'Valmis');

-- --------------------------------------------------------

--
-- Table structure for table `tilaus`
--

CREATE TABLE `tilaus` (
  `TilausID` int(5) NOT NULL,
  `kayttajaID` int(4) NOT NULL,
  `LentoID` int(5) NOT NULL,
  `AteriaID` int(3) NOT NULL,
  `JuomaID` int(4) NOT NULL,
  `JuomaAlkoID` int(4) NOT NULL,
  `Hinta` float NOT NULL,
  `Status` int(2) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tilaus`
--

INSERT INTO `tilaus` (`TilausID`, `kayttajaID`, `LentoID`, `AteriaID`, `JuomaID`, `JuomaAlkoID`, `Hinta`, `Status`) VALUES
(5, 0, 0, 1, 2, 1, 24.6, 1),
(21, 3, 2, 0, 0, 0, 34.7, 1),
(22, 5, 2, 0, 0, 0, 27.2, 1),
(23, 5, 2, 0, 0, 0, 37.2, 1),
(24, 5, 2, 0, 0, 0, 37.2, 1),
(25, 5, 2, 0, 0, 0, 24.7, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tilausyhdiste`
--

CREATE TABLE `tilausyhdiste` (
  `TilausID` int(4) NOT NULL,
  `AteriatID` int(3) DEFAULT NULL,
  `JuomaAlkoID` int(4) DEFAULT NULL,
  `JuomaID` int(4) DEFAULT NULL,
  `Maara` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tilausyhdiste`
--

INSERT INTO `tilausyhdiste` (`TilausID`, `AteriatID`, `JuomaAlkoID`, `JuomaID`, `Maara`) VALUES
(21, 2, NULL, NULL, 1),
(21, 3, NULL, NULL, 1),
(21, NULL, 1, NULL, 1),
(21, NULL, NULL, 2, 1),
(22, 2, NULL, NULL, 1),
(22, NULL, 1, NULL, 1),
(22, NULL, NULL, 1, 1),
(22, NULL, NULL, 2, 1),
(23, 2, NULL, NULL, 1),
(23, 3, NULL, NULL, 1),
(23, NULL, 1, NULL, 1),
(23, NULL, NULL, 1, 1),
(23, NULL, NULL, 2, 1),
(24, 2, NULL, NULL, 1),
(24, 3, NULL, NULL, 1),
(24, NULL, 1, NULL, 1),
(24, NULL, NULL, 1, 1),
(24, NULL, NULL, 2, 1),
(25, 2, NULL, NULL, 1),
(25, NULL, 1, NULL, 1),
(25, NULL, NULL, 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tyotilanne`
--

CREATE TABLE `tyotilanne` (
  `TyoID` int(4) NOT NULL,
  `Kayttajatunnus` varchar(30) NOT NULL,
  `TilausID` int(4) NOT NULL,
  `Status` int(2) NOT NULL,
  `LentoID` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ateriat`
--
ALTER TABLE `ateriat`
  ADD PRIMARY KEY (`AteriaID`);

--
-- Indexes for table `juomatalkoholilliset`
--
ALTER TABLE `juomatalkoholilliset`
  ADD PRIMARY KEY (`JuomaAlkoID`);

--
-- Indexes for table `juomatalkoholittomat`
--
ALTER TABLE `juomatalkoholittomat`
  ADD PRIMARY KEY (`JuomaID`);

--
-- Indexes for table `kayttajat`
--
ALTER TABLE `kayttajat`
  ADD PRIMARY KEY (`KayttajaID`),
  ADD KEY `RooliAvain` (`RoolitID`),
  ADD KEY `KayttajaTunnus` (`KayttajaTunnus`),
  ADD KEY `YhtioID` (`YhtioID`) USING BTREE;

--
-- Indexes for table `lennot`
--
ALTER TABLE `lennot`
  ADD PRIMARY KEY (`LentoID`),
  ADD KEY `Yhtio` (`ICAOkoodi`);

--
-- Indexes for table `lentoyhtionyhteyshenkilot`
--
ALTER TABLE `lentoyhtionyhteyshenkilot`
  ADD PRIMARY KEY (`YhtioID`),
  ADD UNIQUE KEY `ICAOkoodi` (`ICAOkoodi`);

--
-- Indexes for table `roolit`
--
ALTER TABLE `roolit`
  ADD PRIMARY KEY (`RooliId`);

--
-- Indexes for table `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`StatusID`);

--
-- Indexes for table `tilaus`
--
ALTER TABLE `tilaus`
  ADD PRIMARY KEY (`TilausID`),
  ADD KEY `StatusID` (`Status`);

--
-- Indexes for table `tilausyhdiste`
--
ALTER TABLE `tilausyhdiste`
  ADD KEY `AteriatID` (`AteriatID`) USING BTREE,
  ADD KEY `JuomaID` (`JuomaID`) USING BTREE,
  ADD KEY `JuomaAlkoID` (`JuomaAlkoID`) USING BTREE,
  ADD KEY `TilausID` (`TilausID`);

--
-- Indexes for table `tyotilanne`
--
ALTER TABLE `tyotilanne`
  ADD PRIMARY KEY (`TyoID`),
  ADD KEY `Lento` (`LentoID`),
  ADD KEY `Tekija` (`Kayttajatunnus`),
  ADD KEY `Tilaus` (`TilausID`),
  ADD KEY `Status` (`Status`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ateriat`
--
ALTER TABLE `ateriat`
  MODIFY `AteriaID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `juomatalkoholilliset`
--
ALTER TABLE `juomatalkoholilliset`
  MODIFY `JuomaAlkoID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `juomatalkoholittomat`
--
ALTER TABLE `juomatalkoholittomat`
  MODIFY `JuomaID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `kayttajat`
--
ALTER TABLE `kayttajat`
  MODIFY `KayttajaID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `lennot`
--
ALTER TABLE `lennot`
  MODIFY `LentoID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `lentoyhtionyhteyshenkilot`
--
ALTER TABLE `lentoyhtionyhteyshenkilot`
  MODIFY `YhtioID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `roolit`
--
ALTER TABLE `roolit`
  MODIFY `RooliId` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `status`
--
ALTER TABLE `status`
  MODIFY `StatusID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tilaus`
--
ALTER TABLE `tilaus`
  MODIFY `TilausID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `tyotilanne`
--
ALTER TABLE `tyotilanne`
  MODIFY `TyoID` int(4) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kayttajat`
--
ALTER TABLE `kayttajat`
  ADD CONSTRAINT `RooliAvain` FOREIGN KEY (`RoolitID`) REFERENCES `roolit` (`RooliId`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `lennot`
--
ALTER TABLE `lennot`
  ADD CONSTRAINT `Yhtio` FOREIGN KEY (`ICAOkoodi`) REFERENCES `lentoyhtionyhteyshenkilot` (`ICAOkoodi`) ON DELETE CASCADE;

--
-- Constraints for table `lentoyhtionyhteyshenkilot`
--
ALTER TABLE `lentoyhtionyhteyshenkilot`
  ADD CONSTRAINT `YhtioAvain` FOREIGN KEY (`ICAOkoodi`) REFERENCES `lennot` (`ICAOkoodi`) ON DELETE CASCADE;

--
-- Constraints for table `tilaus`
--
ALTER TABLE `tilaus`
  ADD CONSTRAINT `StatusAvain` FOREIGN KEY (`Status`) REFERENCES `status` (`StatusID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tilausyhdiste`
--
ALTER TABLE `tilausyhdiste`
  ADD CONSTRAINT `AteriaAvain` FOREIGN KEY (`AteriatID`) REFERENCES `ateriat` (`AteriaID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `JuomaAlkoAvain` FOREIGN KEY (`JuomaAlkoID`) REFERENCES `juomatalkoholilliset` (`JuomaAlkoID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `JuomaAvain` FOREIGN KEY (`JuomaID`) REFERENCES `juomatalkoholittomat` (`JuomaID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `TilausAvain` FOREIGN KEY (`TilausID`) REFERENCES `tilaus` (`TilausID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tyotilanne`
--
ALTER TABLE `tyotilanne`
  ADD CONSTRAINT `Lento` FOREIGN KEY (`LentoID`) REFERENCES `lennot` (`LentoID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `Status` FOREIGN KEY (`Status`) REFERENCES `status` (`StatusID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `Tekija` FOREIGN KEY (`Kayttajatunnus`) REFERENCES `kayttajat` (`KayttajaTunnus`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `Tilaus` FOREIGN KEY (`TilausID`) REFERENCES `tilaus` (`TilausID`) ON DELETE CASCADE ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
