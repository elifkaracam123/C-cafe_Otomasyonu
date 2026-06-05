-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 10 Haz 2025, 08:54:00
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
-- Veritabanı: `projecafe`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `kullaniciId` int(11) NOT NULL,
  `ad` varchar(50) DEFAULT NULL,
  `soyad` varchar(50) DEFAULT NULL,
  `telefon` varchar(15) DEFAULT NULL,
  `mail` varchar(100) DEFAULT NULL,
  `sifre` varchar(200) DEFAULT NULL,
  `kayitTarihi` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`kullaniciId`, `ad`, `soyad`, `telefon`, `mail`, `sifre`, `kayitTarihi`) VALUES
(1, 'Merve', 'Şen', '555', 'merve@gmail.com', '209044e8592a64718590f5419fa6a146d9b3eee6f1518fffd4fc32d4ff8938ca', '2025-05-31 22:02:24'),
(2, 'ayse', 'yılmaz', '5555555555', 'ayse@gmail.com', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', '2025-06-01 02:13:21'),
(3, 'Ayşe', 'Yılmaz', '5423181867', '', 'd30c08315ed807bbb336e154343ccabe8d84b9aae27972531c7d932fe5aa3f95', '2025-06-01 20:35:19'),
(4, 'elif', 'karaçam', '1234567890', '', 'a91dced05f3b630383446f3a82f8956c92c3e677d45f38bec61a3c0ea3d60cf8', '2025-06-02 14:28:58'),
(5, 'ayşe', 'yılmaz', '0123456789', '', 'fbfacb4ffa765177e89d25e9a31ec3ddbd91facab971f83763e7340f535fb985', '2025-06-02 15:04:27'),
(6, 'merve', 'şen', '1234567800', '', '8aa403cd5a4945ee3b8b2b7b2b8ceb1347a36b0010fb72486dc31dd521d54542', '2025-06-02 16:05:49'),
(7, 'esma', 'yılmaz', '5423181861', '', 'd30c08315ed807bbb336e154343ccabe8d84b9aae27972531c7d932fe5aa3f95', '2025-06-02 16:41:18');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `masalar`
--

CREATE TABLE `masalar` (
  `masaId` int(11) NOT NULL,
  `masaNo` int(11) DEFAULT NULL,
  `doluMu` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `masalar`
--

INSERT INTO `masalar` (`masaId`, `masaNo`, `doluMu`) VALUES
(1, 1, 1),
(2, 2, 0),
(3, 3, 0),
(4, 4, 0),
(5, 5, 0),
(6, 6, 0),
(7, 7, 0),
(8, 8, 0),
(9, 9, 0),
(10, 10, 1),
(11, 11, 0),
(12, 12, 0),
(13, 13, 0),
(14, 14, 0),
(15, 15, 1),
(16, 16, 0),
(17, 17, 0),
(18, 18, 0),
(19, 19, 0),
(20, 20, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sepet`
--

CREATE TABLE `sepet` (
  `sepetId` int(11) NOT NULL,
  `kullaniciId` int(11) DEFAULT NULL,
  `urunId` int(11) DEFAULT NULL,
  `adet` int(11) DEFAULT 1,
  `eklenmeTarihi` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `siparisler`
--

CREATE TABLE `siparisler` (
  `siparisId` int(11) NOT NULL,
  `kullaniciId` int(11) DEFAULT NULL,
  `masaId` int(11) DEFAULT NULL,
  `toplamFiyat` decimal(10,2) DEFAULT NULL,
  `tarih` datetime DEFAULT current_timestamp(),
  `urunId` int(11) DEFAULT NULL,
  `adet` int(11) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `siparisler`
--

INSERT INTO `siparisler` (`siparisId`, `kullaniciId`, `masaId`, `toplamFiyat`, `tarih`, `urunId`, `adet`) VALUES
(20, NULL, 7, 300.00, '2025-06-02 15:02:56', NULL, 1),
(21, NULL, 15, 220.00, '2025-06-02 15:03:47', NULL, 1),
(22, NULL, 10, 340.00, '2025-06-02 15:05:33', NULL, 1),
(23, NULL, NULL, 310.00, '2025-06-02 15:06:15', NULL, 1),
(24, NULL, 20, 60.00, '2025-06-02 15:11:23', NULL, 1),
(25, NULL, NULL, 350.00, '2025-06-02 16:43:03', NULL, 1),
(26, NULL, 1, 280.00, '2025-06-02 16:43:46', NULL, 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `siparis_detay`
--

CREATE TABLE `siparis_detay` (
  `detayId` int(11) NOT NULL,
  `siparisId` int(11) DEFAULT NULL,
  `urunId` int(11) DEFAULT NULL,
  `adet` int(11) DEFAULT 1,
  `birimFiyat` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `siparis_detay`
--

INSERT INTO `siparis_detay` (`detayId`, `siparisId`, `urunId`, `adet`, `birimFiyat`) VALUES
(7, 20, 1, 1, 200.00),
(8, 20, 11, 1, 100.00),
(9, 21, 14, 1, 200.00),
(10, 21, 16, 1, 20.00),
(11, 22, 1, 1, 200.00),
(12, 22, 12, 1, 110.00),
(13, 22, 13, 1, 30.00),
(14, 23, 5, 1, 100.00),
(15, 23, 7, 1, 180.00),
(16, 23, 13, 1, 30.00),
(17, 24, 16, 3, 20.00),
(18, 25, 3, 1, 180.00),
(19, 25, 16, 1, 20.00),
(20, 25, 21, 1, 150.00),
(21, 26, 1, 1, 200.00),
(22, 26, 2, 1, 80.00);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urunler`
--

CREATE TABLE `urunler` (
  `urunId` int(11) NOT NULL,
  `ad` varchar(100) DEFAULT NULL,
  `kategori` varchar(50) DEFAULT NULL,
  `fiyat` decimal(10,2) DEFAULT NULL,
  `resimYolu` varchar(255) DEFAULT NULL,
  `stokAdeti` int(11) DEFAULT NULL,
  `stoktaMi` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `urunler`
--

INSERT INTO `urunler` (`urunId`, `ad`, `kategori`, `fiyat`, `resimYolu`, `stokAdeti`, `stoktaMi`) VALUES
(1, 'Makarna', 'Yemek', 200.00, 'resimler/makarna.jpg', 200, 1),
(2, 'Patates', 'Yemek', 80.00, 'resimler/patates.jpg', 200, 1),
(3, 'Browni', 'Tatlı', 180.00, 'resimler/browni.jpg', 200, 1),
(4, 'Çikolatalı Pasta', 'Tatlı', 200.00, 'resimler/cikolatali.jpg', 200, 1),
(5, 'Dondurma', 'Yemek', 100.00, 'resimler/dondurma.jpg', 200, 1),
(6, 'Frambuazlı Cheesecake', 'Tatlı', 200.00, 'resimler/frambuazli.jpg', 200, 1),
(7, 'Kruvasan', 'Tatlı', 180.00, 'resimler/kruvasan.jpg', 200, 1),
(8, 'Hamburger', 'Yemek', 200.00, 'resimler/hamburger.jpg', 200, 1),
(9, 'Kola', 'Soğuk İçecek', 80.00, 'resimler/kola.jpg', 200, 1),
(10, 'Buzlu Latte', 'Soğuk İçecekler', 180.00, 'resimler/buzluLatte.jpg', 200, 1),
(11, 'Limonata', 'Soğuk İçecekler', 100.00, 'resimler/limonata.jpg', 200, 1),
(12, 'Portakal Suyu', 'Soğuk İçecekler', 110.00, 'resimler/portakalSuyu.jpg', 200, 1),
(13, 'Su', 'Soğuk İçecekler', 30.00, 'resimler/su.jpg', 200, 1),
(14, 'Profiterol', 'Tatlı', 200.00, 'resimler/profiterol-2.jpg', 200, 1),
(15, 'Lotus Pasta', 'Tatlı', 210.00, 'resimler/lotusPasta.jpg', 200, 1),
(16, 'Çay', 'Sıcak İçecekler', 20.00, 'resimler/cay.jpg', 200, 1),
(18, 'Latte', 'Sıcak İçecekler', 160.00, 'resimler/latte.jpg', 200, 1),
(20, 'San Sebastian', 'Tatlı', 220.00, 'resimler/sansebastian.jpg', 200, 1),
(21, 'Türk Kahvesi', 'Sıcak İçecekler', 150.00, 'resimler/turkKahvesi.jpg', 200, 1),
(22, 'Espresso', 'Sıcak İçecekler', 120.00, 'resimler/espresso.jpg', 200, 1);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`kullaniciId`),
  ADD UNIQUE KEY `telefon` (`telefon`);

--
-- Tablo için indeksler `masalar`
--
ALTER TABLE `masalar`
  ADD PRIMARY KEY (`masaId`),
  ADD UNIQUE KEY `masaNo` (`masaNo`);

--
-- Tablo için indeksler `sepet`
--
ALTER TABLE `sepet`
  ADD PRIMARY KEY (`sepetId`),
  ADD KEY `kullaniciId` (`kullaniciId`),
  ADD KEY `urunId` (`urunId`);

--
-- Tablo için indeksler `siparisler`
--
ALTER TABLE `siparisler`
  ADD PRIMARY KEY (`siparisId`),
  ADD KEY `kullaniciId` (`kullaniciId`),
  ADD KEY `masaId` (`masaId`),
  ADD KEY `urunId` (`urunId`);

--
-- Tablo için indeksler `siparis_detay`
--
ALTER TABLE `siparis_detay`
  ADD PRIMARY KEY (`detayId`),
  ADD KEY `siparisId` (`siparisId`),
  ADD KEY `urunId` (`urunId`);

--
-- Tablo için indeksler `urunler`
--
ALTER TABLE `urunler`
  ADD PRIMARY KEY (`urunId`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `kullaniciId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Tablo için AUTO_INCREMENT değeri `masalar`
--
ALTER TABLE `masalar`
  MODIFY `masaId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Tablo için AUTO_INCREMENT değeri `sepet`
--
ALTER TABLE `sepet`
  MODIFY `sepetId` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `siparisler`
--
ALTER TABLE `siparisler`
  MODIFY `siparisId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Tablo için AUTO_INCREMENT değeri `siparis_detay`
--
ALTER TABLE `siparis_detay`
  MODIFY `detayId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- Tablo için AUTO_INCREMENT değeri `urunler`
--
ALTER TABLE `urunler`
  MODIFY `urunId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `sepet`
--
ALTER TABLE `sepet`
  ADD CONSTRAINT `sepet_ibfk_1` FOREIGN KEY (`kullaniciId`) REFERENCES `kullanicilar` (`kullaniciId`),
  ADD CONSTRAINT `sepet_ibfk_2` FOREIGN KEY (`urunId`) REFERENCES `urunler` (`urunId`);

--
-- Tablo kısıtlamaları `siparisler`
--
ALTER TABLE `siparisler`
  ADD CONSTRAINT `siparisler_ibfk_1` FOREIGN KEY (`kullaniciId`) REFERENCES `kullanicilar` (`kullaniciId`),
  ADD CONSTRAINT `siparisler_ibfk_2` FOREIGN KEY (`masaId`) REFERENCES `masalar` (`masaId`),
  ADD CONSTRAINT `siparisler_ibfk_3` FOREIGN KEY (`urunId`) REFERENCES `urunler` (`urunId`);

--
-- Tablo kısıtlamaları `siparis_detay`
--
ALTER TABLE `siparis_detay`
  ADD CONSTRAINT `siparis_detay_ibfk_1` FOREIGN KEY (`siparisId`) REFERENCES `siparisler` (`siparisId`),
  ADD CONSTRAINT `siparis_detay_ibfk_2` FOREIGN KEY (`urunId`) REFERENCES `urunler` (`urunId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
