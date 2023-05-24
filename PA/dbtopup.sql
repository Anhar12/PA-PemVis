-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2023 at 06:31 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbtopup`
--

-- --------------------------------------------------------

--
-- Table structure for table `akun`
--

CREATE TABLE `akun` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `level` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`username`, `password`, `level`) VALUES
('admin', 'admin', 'admin'),
('ayam', 'jago', 'customer'),
('udin', 'petot', 'customer'),
('user', 'user', 'customer');

-- --------------------------------------------------------

--
-- Table structure for table `game`
--

CREATE TABLE `game` (
  `nama` varchar(50) NOT NULL,
  `mataUang` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `game`
--

INSERT INTO `game` (`nama`, `mataUang`) VALUES
('Fifa Mobile', 'POINTS'),
('Mobile Legends', 'Diamonds'),
('Valorant', 'VP');

-- --------------------------------------------------------

--
-- Table structure for table `pesanan`
--

CREATE TABLE `pesanan` (
  `id` int(10) NOT NULL,
  `jumlah` int(10) NOT NULL,
  `harga` int(11) NOT NULL,
  `id_akun` varchar(50) NOT NULL,
  `nickname` varchar(50) NOT NULL,
  `game` varchar(50) NOT NULL,
  `waktu` datetime DEFAULT current_timestamp(),
  `username` varchar(50) NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pesanan`
--

INSERT INTO `pesanan` (`id`, `jumlah`, `harga`, `id_akun`, `nickname`, `game`, `waktu`, `username`, `status`) VALUES
(64, 150, 60000, 'asda', '123', 'Fifa Mobile', '2023-05-23 03:10:10', 'user', 'Gagal'),
(65, 550, 300000, '94354872', 'AyamBetelor', 'Fifa Mobile', '2023-05-23 23:56:26', 'udin', 'Berhasil'),
(67, 350, 85000, '9523987', 'Asiappp', 'Valorant', '2023-05-24 01:15:26', 'ayam', 'Gagal'),
(68, 350, 85000, '1432987', 'bebekmancing', 'Valorant', '2023-05-24 01:16:26', 'ayam', 'Berhasil');

-- --------------------------------------------------------

--
-- Table structure for table `varian`
--

CREATE TABLE `varian` (
  `game` varchar(50) NOT NULL,
  `harga` int(10) NOT NULL,
  `id` int(10) NOT NULL,
  `jumlah` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `varian`
--

INSERT INTO `varian` (`game`, `harga`, `id`, `jumlah`) VALUES
('Fifa Mobile', 25000, 2, 30),
('Fifa Mobile', 60000, 6, 150),
('Fifa Mobile', 300000, 20, 550),
('Fifa Mobile', 500000, 23, 1000),
('Mobile Legends', 35000, 26, 100),
('Mobile Legends', 60000, 27, 300),
('Valorant', 85000, 28, 350),
('Valorant', 30000, 29, 150);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `game`
--
ALTER TABLE `game`
  ADD PRIMARY KEY (`nama`);

--
-- Indexes for table `pesanan`
--
ALTER TABLE `pesanan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pesan` (`game`);

--
-- Indexes for table `varian`
--
ALTER TABLE `varian`
  ADD PRIMARY KEY (`id`),
  ADD KEY `TopUp` (`game`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pesanan`
--
ALTER TABLE `pesanan`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;

--
-- AUTO_INCREMENT for table `varian`
--
ALTER TABLE `varian`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pesanan`
--
ALTER TABLE `pesanan`
  ADD CONSTRAINT `pesan` FOREIGN KEY (`game`) REFERENCES `game` (`nama`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `varian`
--
ALTER TABLE `varian`
  ADD CONSTRAINT `TopUp` FOREIGN KEY (`game`) REFERENCES `game` (`nama`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
