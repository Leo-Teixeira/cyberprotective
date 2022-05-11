-- --------------------------------------------------------
-- Hôte :                        127.0.0.1
-- Version du serveur:           10.1.34-MariaDB - mariadb.org binary distribution
-- SE du serveur:                Win32
-- HeidiSQL Version:             10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Listage de la structure de la base pour brouillondb
CREATE DATABASE IF NOT EXISTS `brouillondb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `brouillondb`;

-- Listage de la structure de la table brouillondb. client
CREATE TABLE IF NOT EXISTS `client` (
  `codeclient` varchar(15) NOT NULL,
  `nomclient` varchar(255) DEFAULT NULL,
  `adresse` varchar(255) DEFAULT NULL,
  `codepostal` varchar(5) DEFAULT NULL,
  `ville` varchar(80) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `email` varchar(70) DEFAULT NULL,
  `datenaissance` date DEFAULT NULL,
  `notemoy` float DEFAULT NULL,
  PRIMARY KEY (`codeclient`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Listage des données de la table brouillondb.client : 3 rows
DELETE FROM `client`;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` (`codeclient`, `nomclient`, `adresse`, `codepostal`, `ville`, `tel`, `email`, `datenaissance`, `notemoy`) VALUES
	('1', 'DUPONT FABRICE', '158 ALLEE DES NEFLES', '20600', 'FURIANI', '0495112233', 'dupontfabrice@freex.fr', '1979-02-23', 16),
	('2', 'MORVIX ALEXANDER', '15 impasse des prunes', '20290', 'Borgo', '0495445566', 'morvix@alexander.net', '1989-03-01', 14),
	('3', 'GARCIN Albin', '14 LOT Constance', '20600', 'BASTIA', '0495778899', 'albgarcin@rouge.fr', '1945-04-29', 15);
/*!40000 ALTER TABLE `client` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
