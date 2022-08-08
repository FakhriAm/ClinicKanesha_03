-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.19-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for clinic_kanesha
CREATE DATABASE IF NOT EXISTS `clinic_kanesha` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `clinic_kanesha`;

-- Dumping structure for table clinic_kanesha.list_detail_transaction
CREATE TABLE IF NOT EXISTS `list_detail_transaction` (
  `tsc_code` varchar(10) NOT NULL DEFAULT 'TSC',
  `med_id` varchar(10) DEFAULT NULL,
  `med_name` varchar(10) DEFAULT NULL,
  `tsc_qty` int(11) DEFAULT NULL,
  `tsc_sub_total` int(11) DEFAULT NULL,
  KEY `tsc_code` (`tsc_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table clinic_kanesha.list_detail_transaction: ~0 rows (approximately)
DELETE FROM `list_detail_transaction`;
/*!40000 ALTER TABLE `list_detail_transaction` DISABLE KEYS */;
/*!40000 ALTER TABLE `list_detail_transaction` ENABLE KEYS */;

-- Dumping structure for table clinic_kanesha.list_medicine
CREATE TABLE IF NOT EXISTS `list_medicine` (
  `med_id` varchar(6) NOT NULL DEFAULT 'MED',
  `med_name` varchar(100) DEFAULT NULL,
  `med_price` int(11) DEFAULT NULL,
  `med_stock` int(11) DEFAULT NULL,
  `med_status` varchar(100) DEFAULT 'Good',
  `med_unit` varchar(10) DEFAULT NULL,
  `med_date_in` datetime DEFAULT current_timestamp(),
  `med_date_ex` date DEFAULT NULL,
  PRIMARY KEY (`med_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table clinic_kanesha.list_medicine: ~4 rows (approximately)
DELETE FROM `list_medicine`;
/*!40000 ALTER TABLE `list_medicine` DISABLE KEYS */;
INSERT INTO `list_medicine` (`med_id`, `med_name`, `med_price`, `med_stock`, `med_status`, `med_unit`, `med_date_in`, `med_date_ex`) VALUES
	('MED001', 'Antasida', 3400, 100, 'Good', 'Syrup', '2022-08-08 00:00:00', NULL),
	('MED002', 'Paracetamol 500mg', 5000, 100, 'Good', 'Tablet', '2022-08-08 00:00:00', NULL),
	('MED003', 'Ibuprofen 500 mg', 14000, 100, 'Good', 'Capsule', '2022-08-08 00:00:00', NULL),
	('MED004', 'Mexime Antibiotic', 38000, 100, 'Good', 'Tablet', '2022-08-08 00:00:00', NULL);
/*!40000 ALTER TABLE `list_medicine` ENABLE KEYS */;

-- Dumping structure for table clinic_kanesha.list_patient
CREATE TABLE IF NOT EXISTS `list_patient` (
  `patient_id` varchar(10) NOT NULL,
  `patient_name` varchar(50) DEFAULT 'NULL',
  `patient_address` varchar(100) DEFAULT 'NULL',
  `patient_age` varchar(50) DEFAULT 'NULL',
  `patient_gender` varchar(550) DEFAULT 'NULL',
  `patient_status` varchar(50) DEFAULT 'New',
  `created` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `latest_visit` datetime DEFAULT current_timestamp(),
  `active` varchar(1) DEFAULT '1',
  PRIMARY KEY (`patient_id`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table clinic_kanesha.list_patient: ~8 rows (approximately)
DELETE FROM `list_patient`;
/*!40000 ALTER TABLE `list_patient` DISABLE KEYS */;
INSERT INTO `list_patient` (`patient_id`, `patient_name`, `patient_address`, `patient_age`, `patient_gender`, `patient_status`, `created`, `latest_visit`, `active`) VALUES
	('PTN001', 'Sabarudin', 'Jln. Kakatua', '40', 'Male', 'New', '2022-08-08 06:29:52', '2022-08-07 21:30:32', '1'),
	('PTN002', 'Sarah Adelia', 'Jln Perintis 2', '15', 'Female', 'New', '2022-08-08 06:29:53', '2022-08-07 21:30:32', '1'),
	('PTN003', 'Mahmud Setyo', 'Jln Sutan Sahir XI', '36', 'Male', 'Old', '2022-08-08 06:30:31', '2022-04-07 21:30:32', '0'),
	('PTN004', 'Fakhri Am', 'Jalan Merdeka', '25', 'Male', 'New', '2022-08-08 06:29:54', '2022-08-07 21:30:32', '1'),
	('PTN005', 'Ida Bagus Oka', 'Jln Diponogoro', '28', 'Male', 'New', '2022-08-08 06:29:54', '2022-08-07 21:30:32', '1'),
	('PTN006', 'Linda Isnan', 'Jln Pembangunan', '23', 'Felame', 'Old', '2022-08-08 06:30:31', '2022-04-07 21:30:32', '0'),
	('PTN007', 'Sinta', 'Jln Menur', '21', 'NULL', 'New', '2022-08-08 13:44:49', '2022-08-08 13:44:49', '1'),
	('PTN008', 'Salahudin', 'Jln Sabar, Depok', '42', 'NULL', 'Old', '2022-08-08 14:20:30', '2022-08-08 14:20:30', '1');
/*!40000 ALTER TABLE `list_patient` ENABLE KEYS */;

-- Dumping structure for table clinic_kanesha.list_transaction
CREATE TABLE IF NOT EXISTS `list_transaction` (
  `tsc_code` varchar(10) NOT NULL DEFAULT 'TSC',
  `tsc_patient_id` varchar(10) DEFAULT NULL,
  `tsc_user_id` varchar(10) DEFAULT NULL,
  `tsc_date` date DEFAULT NULL,
  `tsc_time` time DEFAULT NULL,
  `tsc_total_item` int(11) DEFAULT NULL,
  `tsc_cash_in` int(11) DEFAULT NULL,
  `tsc_change_in` int(11) DEFAULT NULL,
  PRIMARY KEY (`tsc_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table clinic_kanesha.list_transaction: ~0 rows (approximately)
DELETE FROM `list_transaction`;
/*!40000 ALTER TABLE `list_transaction` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table clinic_kanesha.users: ~5 rows (approximately)
DELETE FROM `users`;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `user_id`, `user_name`, `user_pass`, `user_auth`, `created`) VALUES
	(1, 'uid001', 'admin_ri', 'pass', 'admin', '2022-08-06 11:38:39'),
	(2, 'uid002', 'admin_niki', 'pass', 'admin', '2022-08-06 11:38:39'),
	(3, 'uid003', 'user_yoga', 'pass', 'user', '2022-08-06 11:55:52'),
	(4, 'UID004', 'user_nimas', 'pass', 'user', '2022-08-08 14:19:05'),
	(5, 'UID005', 'admin_windah', 'pass', 'admin', '2022-08-08 14:19:59');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

-- Dumping structure for procedure clinic_kanesha.3month_patient_active_check
DELIMITER //
CREATE PROCEDURE `3month_patient_active_check`()
BEGIN
	UPDATE list_patient
	SET active = 0 , patient_status = "Old"
	WHERE TIMESTAMPDIFF(MONTH, latest_visit,NOW()) >= 3 ;
END//
DELIMITER ;

-- Dumping structure for procedure clinic_kanesha.expiration_date_set
DELIMITER //
CREATE PROCEDURE `expiration_date_set`()
BEGIN
	UPDATE list_medicine 
	SET med_status = 'Expired'
	WHERE TIMESTAMPDIFF(DAY, NOW(), med_date_ex) <= 1;
END//
DELIMITER ;

-- Dumping structure for event clinic_kanesha.check_active_patient
DELIMITER //
CREATE EVENT `check_active_patient` ON SCHEDULE EVERY 1 DAY STARTS '2022-08-01 00:00:00' ON COMPLETION NOT PRESERVE ENABLE DO BEGIN
	CALL 3month_patient_active_check();
END//
DELIMITER ;

-- Dumping structure for event clinic_kanesha.check_expiration_medicine
DELIMITER //
CREATE EVENT `check_expiration_medicine` ON SCHEDULE EVERY 1 DAY STARTS '2022-08-01 00:00:00' ON COMPLETION NOT PRESERVE ENABLE DO BEGIN
	CALL expiration_date_set();
END//
DELIMITER ;

-- Dumping structure for trigger clinic_kanesha.list_detail_transaction_after_insert
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `list_detail_transaction_after_insert` AFTER INSERT ON `list_detail_transaction` FOR EACH ROW BEGIN
	UPDATE list_medicine SET med_stock = med_stock - NEW.tsc_qty WHERE NEW.med_id = med_id;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

-- Dumping structure for trigger clinic_kanesha.set_expired
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_ZERO_IN_DATE,NO_ZERO_DATE,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `set_expired` BEFORE INSERT ON `list_medicine` FOR EACH ROW BEGIN
	IF(NEW.med_stock = '' OR NEW.med_stock = NULL or NEW.med_stock = 'Syrup') THEN
		SET new.med_date_ex = DATE_ADD(new.med_date_in, INTERVAL 1 MONTH);
	ELSEIF (NEW.med_unit = 'Capsule') THEN
      SET new.med_date_ex = DATE_ADD(new.med_date_in, INTERVAL 6 MONTH);		
   ELSEIF (NEW.med_unit = 'Tablet') THEN
      SET new.med_date_ex = DATE_ADD(new.med_date_in, INTERVAL 12 MONTH);	
	ELSEIF (NEW.med_unit = 'Suplement') THEN
      SET new.med_date_ex = DATE_ADD(new.med_date_in, INTERVAL 12 MONTH);
	END IF;
END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
