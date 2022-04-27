-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 27, 2022 at 08:57 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.27

SET FOREIGN_KEY_CHECKS=0;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pakollinenprojekti`
--

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
  `MAARAAIKA` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `kayttajat`
--

INSERT INTO `kayttajat` (`KAYTTAJA_TUNNUS`, `ETUNIMI`, `SUKUNIMI`, `EMAIL`, `PUHELIN`, `OSAITE`, `POSTINUMERO`, `TOIMIPAIKKA`, `TITTELI`, `SALASANA`, `KUVA`, `MAARAAIKA`) VALUES
('furdigir', 'Furkan ', 'Digiroglu', 'furkan.digiroglu@keuda.fi', 45371100, 'viljo sohkasen katu ', '01370', 'Vantaa', 'aaa', 'tICE618UaVkRlJdubRUdl1TCT+49hJLi', '', '2022-04-27 09:47:40');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kayttajat`
--
ALTER TABLE `kayttajat`
  ADD PRIMARY KEY (`KAYTTAJA_TUNNUS`);
SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
