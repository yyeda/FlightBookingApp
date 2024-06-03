-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 28 May 2024, 18:02:14
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `reservasyon`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `books`
--

CREATE TABLE `books` (
  `id` int(11) NOT NULL,
  `book_type` int(11) NOT NULL,
  `book_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci ROW_FORMAT=DYNAMIC;

--
-- Tablo döküm verisi `books`
--

INSERT INTO `books` (`id`, `book_type`, `book_date`) VALUES
(11, 0, '2023-12-28 08:59:04'),
(12, 0, '2023-12-28 09:11:41'),
(13, 1, '2023-12-28 09:14:51'),
(14, 0, '2023-12-28 09:17:35'),
(15, 0, '2023-12-28 23:24:43'),
(16, 1, '2023-12-28 23:26:08'),
(17, 0, '2023-12-28 23:46:11'),
(18, 0, '2023-12-29 19:40:06'),
(19, 0, '2023-12-29 19:40:48'),
(20, 1, '2023-12-29 19:41:28'),
(21, 0, '2024-05-27 00:44:51'),
(22, 0, '2024-05-28 14:52:37'),
(23, 0, '2024-05-28 15:46:51'),
(24, 1, '2024-05-28 18:01:33');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cities`
--

CREATE TABLE `cities` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Tablo döküm verisi `cities`
--

INSERT INTO `cities` (`id`, `name`) VALUES
(1, 'Adana'),
(2, 'Adıyaman'),
(3, 'Afyonkarahisar'),
(4, 'Ağrı'),
(5, 'Amasya'),
(6, 'Ankara'),
(7, 'Antalya'),
(8, 'Artvin'),
(9, 'Aydın'),
(10, 'Balıkesir'),
(11, 'Bilecik'),
(12, 'Bingöl'),
(13, 'Bitlis'),
(14, 'Bolu'),
(15, 'Burdur'),
(16, 'Bursa'),
(17, 'Çanakkale'),
(18, 'Çankırı'),
(19, 'Çorum'),
(20, 'Denizli'),
(21, 'Diyarbakır'),
(22, 'Edirne'),
(23, 'Elazığ'),
(24, 'Erzincan'),
(25, 'Erzurum'),
(26, 'Eskişehir'),
(27, 'Gaziantep'),
(28, 'Giresun'),
(29, 'Gümüşhane'),
(30, 'Hakkari'),
(31, 'Hatay'),
(32, 'Isparta'),
(33, 'Mersin'),
(34, 'İstanbul'),
(35, 'İzmir'),
(36, 'Kars'),
(37, 'Kastamonu'),
(38, 'Kayseri'),
(39, 'Kırklareli'),
(40, 'Kırşehir'),
(41, 'Kocaeli'),
(42, 'Konya'),
(43, 'Kütahya'),
(44, 'Malatya'),
(45, 'Manisa'),
(46, 'Kahramanmaraş'),
(47, 'Mardin'),
(48, 'Muğla'),
(49, 'Muş'),
(50, 'Nevşehir'),
(51, 'Niğde'),
(52, 'Ordu'),
(53, 'Rize'),
(54, 'Sakarya'),
(55, 'Samsun'),
(56, 'Siirt'),
(57, 'Sinop'),
(58, 'Sivas'),
(59, 'Tekirdağ'),
(60, 'Tokat'),
(61, 'Trabzon'),
(62, 'Tunceli'),
(63, 'Şanlıurfa'),
(64, 'Uşak'),
(65, 'Van'),
(66, 'Yozgat'),
(67, 'Zonguldak'),
(68, 'Aksaray'),
(69, 'Bayburt'),
(70, 'Karaman'),
(71, 'Kırıkkale'),
(72, 'Batman'),
(73, 'Şırnak'),
(74, 'Bartın'),
(75, 'Ardahan'),
(76, 'Iğdır'),
(77, 'Yalova'),
(78, 'Karabük'),
(79, 'Kilis'),
(80, 'Osmaniye'),
(81, 'Düzce');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `flights`
--

CREATE TABLE `flights` (
  `id` int(11) NOT NULL,
  `book_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `flight_date` date NOT NULL,
  `flight_time` time NOT NULL,
  `seat_no` int(11) NOT NULL,
  `from_city` int(11) NOT NULL,
  `to_city` int(11) NOT NULL,
  `flight_type` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci ROW_FORMAT=DYNAMIC;

--
-- Tablo döküm verisi `flights`
--

INSERT INTO `flights` (`id`, `book_id`, `name`, `flight_date`, `flight_time`, `seat_no`, `from_city`, `to_city`, `flight_type`) VALUES
(25, 11, 'Serdar Turan', '2023-12-28', '09:00:00', 15, 6, 34, 0),
(26, 100, 'Mert Mısırlı', '2023-12-28', '09:00:00', 12, 6, 34, 0),
(27, 12, 'Ali Gelir', '2023-12-28', '09:00:00', 36, 6, 34, 0),
(28, 13, 'Mehmet Can', '2023-12-28', '09:00:00', 9, 6, 34, 0),
(29, 13, 'Serhat Can', '2023-12-28', '09:00:00', 10, 6, 34, 0),
(30, 13, 'Mehmet Can', '2023-12-28', '06:00:00', 15, 34, 6, 1),
(31, 13, 'Serhat Can', '2023-12-28', '06:00:00', 16, 34, 6, 1),
(32, 14, 'Veli Tak', '2023-12-28', '06:00:00', 24, 34, 6, 0),
(33, 15, 'aslı ünal', '2023-12-28', '11:00:00', 25, 34, 7, 0),
(34, 15, 'mer musırlu', '2023-12-28', '11:00:00', 6, 34, 7, 0),
(35, 16, 'selen sekkkkk', '2023-12-28', '11:00:00', 1, 34, 7, 0),
(36, 16, 'eda hhhh', '2023-12-28', '11:00:00', 4, 34, 7, 0),
(37, 16, 'eda', '2023-12-28', '11:00:00', 1, 7, 34, 1),
(38, 16, 'sekefn', '2023-12-28', '11:00:00', 4, 7, 34, 1),
(39, 17, 'aslı ünal', '2023-12-28', '11:00:00', 1, 34, 6, 0),
(40, 18, 'Aslıhan Ünal', '2023-12-29', '07:39:00', 2, 34, 6, 0),
(41, 19, 'Aslıhan Ünal', '2023-12-29', '07:40:00', 4, 34, 6, 0),
(42, 20, 'Aslıhan ÜNal', '2023-12-29', '07:41:00', 11, 34, 6, 0),
(43, 20, 'Aslıhan Ünal', '2024-01-02', '07:41:00', 6, 6, 34, 1),
(44, 21, 'aa', '2024-05-27', '12:44:00', 6, 20, 19, 0),
(45, 22, 'aaa', '2024-05-28', '02:52:00', 6, 19, 18, 0),
(46, 23, '333', '2024-05-28', '03:46:00', 7, 23, 22, 0),
(47, 24, 'Mert Mısırlı', '2024-05-28', '06:00:00', 5, 5, 4, 0),
(48, 24, 'Mert Mısırlı', '2024-05-29', '06:01:00', 5, 4, 5, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanici`
--

CREATE TABLE `kullanici` (
  `id` int(11) NOT NULL,
  `isim` varchar(255) NOT NULL,
  `soyisim` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `sifre` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`) USING BTREE;

--
-- Tablo için indeksler `cities`
--
ALTER TABLE `cities`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `flights`
--
ALTER TABLE `flights`
  ADD PRIMARY KEY (`id`) USING BTREE;

--
-- Tablo için indeksler `kullanici`
--
ALTER TABLE `kullanici`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `books`
--
ALTER TABLE `books`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Tablo için AUTO_INCREMENT değeri `cities`
--
ALTER TABLE `cities`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=82;

--
-- Tablo için AUTO_INCREMENT değeri `flights`
--
ALTER TABLE `flights`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- Tablo için AUTO_INCREMENT değeri `kullanici`
--
ALTER TABLE `kullanici`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
