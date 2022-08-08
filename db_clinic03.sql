-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.14-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.0.0.5956
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for clinic_kanesha
CREATE DATABASE IF NOT EXISTS `clinic_kanesha` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `clinic_kanesha`;

-- Dumping structure for table clinic_kanesha.list_medicine
CREATE TABLE IF NOT EXISTS `list_medicine` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `med_code` varchar(10) DEFAULT NULL,
  `med_name` varchar(100) DEFAULT NULL,
  `med_price` int(11) DEFAULT NULL,
  `med_stock` int(11) DEFAULT NULL,
  `med_status` varchar(100) DEFAULT NULL,
  `med_date_in` date DEFAULT NULL,
  `med_date_ex` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table clinic_kanesha.list_medicine: ~4 rows (approximately)
DELETE FROM `list_medicine`;
/*!40000 ALTER TABLE `list_medicine` DISABLE KEYS */;
INSERT INTO `list_medicine` (`id`, `med_code`, `med_name`, `med_price`, `med_stock`, `med_status`, `med_date_in`, `med_date_ex`) VALUES
	(1, 'ME00001', 'Paracetamol 1 strip', 10000, 100, 'Expired', '2022-07-01', '2022-08-01'),
	(2, 'ME00001', 'Ambroxol 1 strip', 12000, 100, 'Good', '2022-08-01', '2022-09-01'),
	(3, 'ME00001', 'Ibuprofen x 1 strip', 36000, 100, 'Good', '2022-08-01', '2022-09-01'),
	(4, 'ME00001', 'CESPAN Cefixime x 1 strip', 36000, 5, 'Good', '2022-07-01', '2022-08-01');
/*!40000 ALTER TABLE `list_medicine` ENABLE KEYS */;

-- Dumping structure for table clinic_kanesha.list_patient
CREATE TABLE IF NOT EXISTS `list_patient` (
  `patient_id` varchar(6) NOT NULL,
  `patient_name` varchar(50) DEFAULT 'NULL',
  `patient_address` varchar(100) DEFAULT 'NULL',
  `patient_age` varchar(50) DEFAULT 'NULL',
  `patient_gender` varchar(550) DEFAULT 'NULL',
  `patient_status` varchar(50) DEFAULT 'New',
  `created` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `active` varchar(1) DEFAULT '1',
  PRIMARY KEY (`patient_id`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table clinic_kanesha.list_patient: ~6 rows (approximately)
DELETE FROM `list_patient`;
/*!40000 ALTER TABLE `list_patient` DISABLE KEYS */;
INSERT INTO `list_patient` (`patient_id`, `patient_name`, `patient_address`, `patient_age`, `patient_gender`, `patient_status`, `created`, `active`) VALUES
	('PTN001', 'Sabarudin', '-', '40', 'Male', 'New', '2022-08-05 10:32:57', '1'),
	('PTN002', 'Kintan Adelia', 'Jln. Bambu Apus', '15', 'Female', 'New', '2022-08-07 00:03:54', '1'),
	('PTN003', 'Mahmud Setyo', '-', '36', 'Male', 'Old', '2022-08-05 10:33:00', '1'),
	('PTN004', 'Fakhri Am', 'Jalan Merdeka', '25', 'Male', 'New', '2022-08-05 09:55:02', '1'),
	('PTN005', 'Marisa', '-', '26', 'Female', 'New', '2022-08-05 10:33:00', '1'),
	('PTN006', 'Mel', 'Ada', '21', 'Female', 'Old', '2022-08-05 11:34:50', '0');
/*!40000 ALTER TABLE `list_patient` ENABLE KEYS */;

-- Dumping structure for table clinic_kanesha.list_transaction
CREATE TABLE IF NOT EXISTS `list_transaction` (
  `id` int(11) NOT NULL,
  `trans_code` varchar(10) DEFAULT NULL,
  `trans_patient_id` int(11) DEFAULT NULL,
  `trans_med_id` int(11) DEFAULT NULL,
  `trans_med_id2` int(11) DEFAULT NULL,
  `trans_qty1_med_id` int(11) DEFAULT NULL,
  `trans_qty2_med_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table clinic_kanesha.list_transaction: ~0 rows (approximately)
DELETE FROM `list_transaction`;
/*!40000 ALTER TABLE `list_transaction` DISABLE KEYS */;
INSERT INTO `list_transaction` (`id`, `trans_code`, `trans_patient_id`, `trans_med_id`, `trans_med_id2`, `trans_qty1_med_id`, `trans_qty2_med_id`) VALUES
	(1, 'TR00001', 2, 2, 3, 1, 2);
/*!40000 ALTER TABLE `list_transaction` ENABLE KEYS */;

-- Dumping structure for table clinic_kanesha.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` char(50) NOT NULL DEFAULT '',
  `user_name` varchar(100) NOT NULL,
  `user_pass` varchar(50) NOT NULL,
  `user_auth` varchar(10) DEFAULT NULL,
  `created` timestamp NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table clinic_kanesha.users: ~3 rows (approximately)
DELETE FROM `users`;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `user_id`, `user_name`, `user_pass`, `user_auth`, `created`) VALUES
	(1, 'uid001', 'admin_ri', 'password123', 'admin', '2022-08-06 11:38:39'),
	(2, 'uid002', 'admin_niki', 'password', 'admin', '2022-08-06 11:38:39'),
	(3, 'uid003', 'user_yoga', 'pass', 'admin', '2022-08-06 11:55:52'),
	(6, 'uid0004', 'user_ani', 'password', 'admin', '2022-08-06 20:22:09');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
