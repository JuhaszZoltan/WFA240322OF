-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Már 22. 16:41
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `teszt240322`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `genres`
--

CREATE TABLE `genres` (
  `ID` int(11) NOT NULL,
  `Name` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `genres`
--

INSERT INTO `genres` (`ID`, `Name`) VALUES
(1, 'Drama'),
(2, 'Action'),
(3, 'Comedy'),
(4, 'Mystery');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `movies`
--

CREATE TABLE `movies` (
  `ID` int(11) NOT NULL,
  `Title` varchar(30) DEFAULT NULL,
  `ReleaseDate` int(11) DEFAULT NULL,
  `GenreID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `movies`
--

INSERT INTO `movies` (`ID`, `Title`, `ReleaseDate`, `GenreID`) VALUES
(1, 'Fight Club', 1999, 1),
(2, 'Cloud Atlas', 2012, 1),
(3, 'Kill Bill: Vol. 1', 2003, 2),
(4, 'The Truman Show', 1998, 3),
(5, 'The Thirteenth Floor', 1999, 4);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `GenreID` (`GenreID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `movies`
--
ALTER TABLE `movies`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `movies`
--
ALTER TABLE `movies`
  ADD CONSTRAINT `movies_ibfk_1` FOREIGN KEY (`GenreID`) REFERENCES `genres` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
