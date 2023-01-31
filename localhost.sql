-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Янв 19 2023 г., 22:56
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `exchangesratedb`
--
CREATE DATABASE IF NOT EXISTS `exchangesratedb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `exchangesratedb`;

-- --------------------------------------------------------

--
-- Структура таблицы `currencyname`
--

CREATE TABLE `currencyname` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `currencyname`
--

INSERT INTO `currencyname` (`id`, `name`) VALUES
(1, 'Доллар США'),
(2, 'Евро'),
(3, 'Китайский юань'),
(4, 'Фунт стерлингов');

-- --------------------------------------------------------

--
-- Структура таблицы `currencyvalue`
--

CREATE TABLE `currencyvalue` (
  `id` int(10) UNSIGNED NOT NULL,
  `CurrencyNameId` int(10) UNSIGNED NOT NULL,
  `SourceNameId` int(10) UNSIGNED NOT NULL,
  `Date` date NOT NULL,
  `Value` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `currencyvalue`
--

INSERT INTO `currencyvalue` (`id`, `CurrencyNameId`, `SourceNameId`, `Date`, `Value`) VALUES
(1, 1, 1, '2023-01-19', 68.8728),
(2, 2, 1, '2023-01-19', 74.5882),
(6, 3, 1, '2023-01-19', 10.1751),
(7, 4, 1, '2023-01-19', 84.5758),
(8, 1, 1, '2023-01-20', 68.8467),
(9, 2, 1, '2023-01-20', 74.4058),
(10, 3, 1, '2023-01-20', 10.132),
(11, 4, 1, '2023-01-20', 85.3286),
(12, 1, 1, '2023-01-18', 68.6644),
(13, 2, 1, '2023-01-18', 74.2646),
(14, 3, 1, '2023-01-18', 10.1146),
(15, 4, 1, '2023-01-18', 83.8118),
(16, 1, 1, '2023-01-17', 68.2892),
(17, 2, 1, '2023-01-17', 73.8298),
(18, 3, 1, '2023-01-17', 10.1368),
(19, 4, 1, '2023-01-17', 83.4153),
(20, 1, 1, '2023-01-16', 67.5744),
(21, 2, 1, '2023-01-16', 73.1131),
(22, 3, 1, '2023-01-16', 10.0307),
(23, 4, 1, '2023-01-16', 82.2853),
(24, 1, 1, '2023-01-15', 67.5744),
(25, 2, 1, '2023-01-15', 73.1131),
(26, 3, 1, '2023-01-15', 10.0307),
(27, 4, 1, '2023-01-15', 82.2853),
(28, 1, 1, '2023-01-14', 67.5744),
(29, 2, 1, '2023-01-14', 73.1131),
(30, 3, 1, '2023-01-14', 10.0307),
(31, 4, 1, '2023-01-14', 82.2853),
(32, 1, 1, '2023-01-13', 67.7775),
(33, 2, 1, '2023-01-13', 72.7908),
(34, 3, 1, '2023-01-13', 10.0016),
(35, 4, 1, '2023-01-13', 82.2141),
(36, 1, 1, '2023-01-12', 69.0202),
(37, 2, 1, '2023-01-12', 74.1361),
(38, 3, 1, '2023-01-12', 10.1396),
(39, 4, 1, '2023-01-12', 83.8457),
(40, 1, 1, '2023-01-11', 69.6094),
(41, 2, 1, '2023-01-11', 74.5438),
(42, 3, 1, '2023-01-11', 10.22),
(43, 4, 1, '2023-01-11', 84.8747),
(44, 1, 1, '2023-01-10', 70.3002),
(45, 2, 1, '2023-01-10', 75.0785),
(46, 3, 1, '2023-01-10', 10.2867),
(47, 4, 1, '2023-01-10', 84.6907),
(48, 1, 1, '2023-01-09', 70.3375),
(49, 2, 1, '2023-01-09', 75.6553),
(50, 3, 1, '2023-01-09', 10.32),
(51, 4, 1, '2023-01-09', 84.7919),
(52, 1, 1, '2023-01-08', 70.3375),
(53, 2, 1, '2023-01-08', 75.6553),
(54, 3, 1, '2023-01-08', 10.6),
(55, 4, 1, '2023-01-08', 84.7919),
(56, 1, 1, '2023-01-07', 70.3375),
(57, 2, 1, '2023-01-07', 75.6553),
(58, 3, 1, '2023-01-07', 10.28),
(59, 4, 1, '2023-01-07', 84.7919),
(60, 1, 1, '2023-01-06', 70.3375),
(61, 2, 1, '2023-01-06', 75.6553),
(62, 3, 1, '2023-01-06', 10.6),
(63, 4, 1, '2023-01-06', 84.7919),
(64, 1, 1, '2023-01-05', 70.3375),
(65, 2, 1, '2023-01-05', 75.6553),
(66, 3, 1, '2023-01-05', 10.55),
(67, 4, 1, '2023-01-05', 84.7919),
(68, 1, 1, '2023-01-03', 70.3375),
(69, 2, 1, '2023-01-03', 75.6553),
(70, 3, 1, '2023-01-03', 98.9492),
(71, 4, 1, '2023-01-03', 84.7919);

-- --------------------------------------------------------

--
-- Структура таблицы `sourcename`
--

CREATE TABLE `sourcename` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `sourcename`
--

INSERT INTO `sourcename` (`id`, `name`) VALUES
(1, 'CBR'),
(2, 'Coingate');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `currencyname`
--
ALTER TABLE `currencyname`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `currencyvalue`
--
ALTER TABLE `currencyvalue`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`),
  ADD KEY `CurrencyNameId` (`CurrencyNameId`,`SourceNameId`),
  ADD KEY `currencyvalue_ibfk_2` (`SourceNameId`);

--
-- Индексы таблицы `sourcename`
--
ALTER TABLE `sourcename`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `currencyname`
--
ALTER TABLE `currencyname`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `currencyvalue`
--
ALTER TABLE `currencyvalue`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;

--
-- AUTO_INCREMENT для таблицы `sourcename`
--
ALTER TABLE `sourcename`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `currencyvalue`
--
ALTER TABLE `currencyvalue`
  ADD CONSTRAINT `currencyvalue_ibfk_1` FOREIGN KEY (`CurrencyNameId`) REFERENCES `currencyname` (`id`),
  ADD CONSTRAINT `currencyvalue_ibfk_2` FOREIGN KEY (`SourceNameId`) REFERENCES `sourcename` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
