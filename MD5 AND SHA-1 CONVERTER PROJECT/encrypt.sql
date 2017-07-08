-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 31, 2016 at 11:02 AM
-- Server version: 5.6.26
-- PHP Version: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `encrypt`
--

-- --------------------------------------------------------

--
-- Table structure for table `data`
--

CREATE TABLE IF NOT EXISTS `data` (
  `id` int(255) NOT NULL,
  `word` varchar(255) NOT NULL,
  `ensha1` varchar(255) NOT NULL,
  `enmd5` varchar(255) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data`
--

INSERT INTO `data` (`id`, `word`, `ensha1`, `enmd5`) VALUES
(14, 'test', 'a94a8fe5ccb19ba61c4c0873d391e987982fbbd3', '098f6bcd4621d373cade4e832627b4f6'),
(15, 'elamer', '9b4737507cc2fd337e1760b9b4eac88a3c2a2c8a', 'e4b429c71461c7b6c5a3781c406d96b5'),
(16, '123123{}', 'd383a1a482e43672f6c1247c22ecc2ab3e2a037b', '2fed9c14ca19d1d7339a872a7df7fcb0'),
(17, 'LMDKN', 'c5c36666b335f89f8e2d27a300ac351e034e17e5', 'b83f00da6cdd5d1215ca487147dd97fc'),
(18, '123', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', '202cb962ac59075b964b07152d234b70'),
(19, 'test', 'a94a8fe5ccb19ba61c4c0873d391e987982fbbd3', '098f6bcd4621d373cade4e832627b4f6'),
(20, 'kristian', 'ec7bf92637e134663c52416998a70b7ad4c68f04', 'f82b3a3f2786107859afbe386cca8255'),
(21, 'test', 'a94a8fe5ccb19ba61c4c0873d391e987982fbbd3', '098f6bcd4621d373cade4e832627b4f6'),
(22, '123123', '601f1889667efaebb33b8c12572835da3f027f78', '4297f44b13955235245b2497399d7a93'),
(23, 'bye', '78c9a53e2f28b543ea62c8266acfdf36d5c63e61', 'bfa99df33b137bc8fb5f5407d7e58da8'),
(24, 'cagasca', '4a3e75ec4ddd6b3a27f46668982635668db31b46', '3a1ad961ad160514f0d992b247e8105d'),
(25, 'cagasca', '4a3e75ec4ddd6b3a27f46668982635668db31b46', '3a1ad961ad160514f0d992b247e8105d');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data`
--
ALTER TABLE `data`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `data`
--
ALTER TABLE `data`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=26;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
