-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 04-11-2019 a las 23:27:48
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `seguridad`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `procedimientoLogin` (IN `usuario` VARCHAR(25), IN `clave` VARCHAR(25))  NO SQL
Select tbl_usuario.PK_id_Usuario FROM tbl_usuario where tbl_usuario.PK_id_Usuario = usuario and tbl_usuario.password_usuario = MD5(clave) AND tbl_usuario.estado_usuario=1$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_aplicacion`
--

CREATE TABLE `tbl_aplicacion` (
  `PK_id_aplicacion` int(11) NOT NULL,
  `PK_id_modulo` int(11) NOT NULL,
  `nombre_aplicacion` varchar(45) DEFAULT NULL,
  `descripcion_aplicacion` varchar(200) DEFAULT NULL,
  `no_reporteAsociado` int(11) DEFAULT NULL,
  `estado_aplicacion` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_aplicacion`
--

INSERT INTO `tbl_aplicacion` (`PK_id_aplicacion`, `PK_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `no_reporteAsociado`, `estado_aplicacion`) VALUES
(1, 1, 'recepcion', 'recepcion', NULL, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacora`
--

CREATE TABLE `tbl_bitacora` (
  `PK_id_bitacora` int(11) NOT NULL,
  `PK_id_usuario` varchar(25) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `host` varchar(45) DEFAULT NULL,
  `ip` varchar(25) DEFAULT NULL,
  `accion` varchar(50) DEFAULT NULL,
  `tabla` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_bitacora`
--

INSERT INTO `tbl_bitacora` (`PK_id_bitacora`, `PK_id_usuario`, `fecha`, `hora`, `host`, `ip`, `accion`, `tabla`) VALUES
(1, 'rchocm', '2019-09-19', '10:46:20', 'AMAZING', '192.168.43.248', 'Se logeo al sistema', 'Login'),
(2, 'rchocm', '2019-09-19', '10:47:04', 'AMAZING', '192.168.43.248', 'Inserto un nuevo modulo: 1 - hoteleria', 'tbl_modulo'),
(3, 'rchocm', '2019-09-19', '10:47:16', 'AMAZING', '192.168.43.248', 'Inserto un nuevo perfil: 1 - admin', 'tbl_perfil'),
(4, 'rchocm', '2019-09-19', '10:47:24', 'AMAZING', '192.168.43.248', 'Inserto un nuevo perfil: 2 - usuario', 'tbl_perfil'),
(5, 'rchocm', '2019-09-19', '10:47:28', 'AMAZING', '192.168.43.248', 'Realizo una consulta a modulos', 'tbl_modulos'),
(6, 'rchocm', '2019-09-19', '10:47:55', 'AMAZING', '192.168.43.248', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(7, 'rchocm', '2019-09-19', '10:47:55', 'AMAZING', '192.168.43.248', 'Realizo una consulta a modulos', 'tbl_modulos'),
(8, 'rchocm', '2019-09-19', '10:48:00', 'AMAZING', '192.168.43.248', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(9, 'rchocm', '2019-09-19', '10:48:09', 'AMAZING', '192.168.43.248', 'Asigno permiso: recepcion a perfil: admin', 'tbl_usuario_aplicacion'),
(10, 'rchocm', '2019-09-19', '10:48:14', 'AMAZING', '192.168.43.248', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(11, 'rchocm', '2019-09-19', '10:48:21', 'AMAZING', '192.168.43.248', 'Asigno permiso: recepcion a perfil: usuario', 'tbl_usuario_aplicacion'),
(12, 'rchocm', '2019-09-19', '10:48:24', 'AMAZING', '192.168.43.248', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(13, 'rchocm', '2019-09-19', '10:48:24', 'AMAZING', '192.168.43.248', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(14, 'rchocm', '2019-09-19', '10:48:39', 'AMAZING', '192.168.43.248', 'Asigno perfil: admin a usuario: rchocm', 'tbl_usuario_perfil'),
(15, 'rchocm', '2019-09-19', '10:48:39', 'AMAZING', '192.168.43.248', 'Asigno perfil: usuario a usuario: choc', 'tbl_usuario_perfil'),
(16, 'rchocm', '2019-09-19', '10:49:56', 'AMAZING', '192.168.43.248', 'Se logeo al sistema', 'Login'),
(17, 'rchocm', '2019-09-19', '10:50:12', 'AMAZING', '192.168.43.248', 'Se creó un nuevo registro', 'Funciones'),
(18, 'rchocm', '2019-09-19', '10:55:21', 'AMAZING', '192.168.43.248', 'Se logeo al sistema', 'Login'),
(19, 'rchocm', '2019-09-19', '10:55:26', 'AMAZING', '192.168.43.248', 'Se creó un nuevo registro', 'Funciones'),
(20, 'choc', '2019-09-19', '10:56:32', 'AMAZING', '192.168.43.248', 'Se logeo al sistema', 'Login'),
(21, 'choc', '2019-09-19', '10:56:37', 'AMAZING', '192.168.43.248', 'Se creó un nuevo registro', 'Funciones'),
(22, 'rchocm', '2019-09-19', '10:57:14', 'AMAZING', '192.168.43.248', 'Se logeo al sistema', 'Login'),
(23, 'rchocm', '2019-09-19', '11:06:58', 'AMAZING', '192.168.43.248', 'Se logeo al sistema', 'Login'),
(24, 'rchocm', '2019-09-19', '11:26:32', 'AMAZING', '192.168.1.12', 'Se logeo al sistema', 'Login'),
(25, 'choc', '2019-09-19', '11:30:33', 'AMAZING', '192.168.1.12', 'Se logeo al sistema', 'Login'),
(26, 'choc', '2019-09-19', '11:53:14', 'AMAZING', '192.168.1.12', 'Se logeo al sistema', 'Login'),
(27, 'choc', '2019-09-19', '11:53:20', 'AMAZING', '192.168.1.12', 'Se creó un nuevo registro', 'Funciones'),
(28, 'choc', '2019-09-19', '11:54:18', 'AMAZING', '192.168.1.12', 'Se creó un nuevo registro', 'Funciones'),
(29, 'rchocm', '2019-09-20', '08:46:05', 'AMAZING', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(30, 'choc', '2019-09-20', '08:46:33', 'AMAZING', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(31, 'choc', '2019-09-20', '08:46:58', 'AMAZING', '192.168.56.1', 'Se creó un nuevo registro', 'Funciones'),
(32, 'choc', '2019-09-20', '08:49:02', 'AMAZING', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(33, 'choc', '2019-09-20', '08:49:17', 'AMAZING', '192.168.56.1', 'Se creó un nuevo registro', 'Funciones'),
(34, 'choc', '2019-09-20', '08:50:16', 'AMAZING', '192.168.56.1', 'Se logeo al sistema', 'Login'),
(35, 'choc', '2019-09-20', '08:50:21', 'AMAZING', '192.168.56.1', 'Se creó un nuevo registro', 'Funciones'),
(36, 'rchocm', '2019-09-20', '10:51:31', 'AMAZING', '192.168.95.18', 'Se logeo al sistema', 'Login'),
(37, 'choc', '2019-09-20', '11:02:19', 'AMAZING', '192.168.95.18', 'Se logeo al sistema', 'Login'),
(38, 'rchocm', '2019-09-20', '11:07:20', 'AMAZING', '192.168.95.18', 'Se logeo al sistema', 'Login'),
(39, 'rchocm', '2019-09-20', '11:09:29', 'AMAZING', '192.168.95.18', 'Se logeo al sistema', 'Login'),
(40, 'rchocm', '2019-09-20', '11:12:53', 'AMAZING', '192.168.95.18', 'Se logeo al sistema', 'Login'),
(41, 'choc', '2019-09-20', '11:15:53', 'AMAZING', '192.168.95.18', 'Se logeo al sistema', 'Login'),
(42, 'choc', '2019-09-20', '11:17:50', 'AMAZING', '192.168.95.18', 'Se logeo al sistema', 'Login'),
(43, 'choc', '2019-09-21', '01:00:17', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(44, 'rchocm', '2019-09-21', '01:00:45', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(45, 'choc', '2019-09-21', '01:02:33', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(46, 'rchocm', '2019-09-21', '01:02:42', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(47, 'choc', '2019-09-21', '01:03:31', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(48, 'choc', '2019-09-21', '01:09:11', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(49, 'choc', '2019-09-21', '01:11:41', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(50, 'rchocm', '2019-09-21', '01:11:49', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(51, 'rchocm', '2019-09-21', '01:16:16', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(52, 'choc', '2019-09-21', '01:17:01', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(53, 'MiUsuario', '2019-09-21', '01:17:16', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(54, 'choc', '2019-09-21', '01:19:40', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(55, 'rchocm', '2019-09-21', '01:19:53', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(56, 'MiUsuario', '2019-09-21', '01:20:21', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(57, 'choc', '2019-09-21', '01:23:38', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(58, 'rchocm', '2019-09-21', '01:23:53', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(59, 'MiUsuario', '2019-09-21', '01:24:15', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(60, 'rchocm', '2019-09-21', '01:39:33', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(61, 'choc', '2019-09-21', '01:39:49', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(62, 'MiUsuario', '2019-09-21', '01:40:05', 'AMAZING', '192.168.1.20', 'Se logeo al sistema', 'Login'),
(63, 'choc', '2019-09-21', '10:11:17', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(64, 'choc', '2019-09-21', '10:16:04', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(65, 'choc', '2019-09-21', '10:19:56', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(66, 'choc', '2019-09-21', '10:23:56', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(67, 'choc', '2019-09-21', '10:24:16', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'Funciones'),
(68, 'choc', '2019-09-21', '10:27:13', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(69, 'choc', '2019-09-21', '10:27:29', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'Funciones'),
(70, 'choc', '2019-09-21', '10:28:41', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(71, 'choc', '2019-09-21', '10:28:55', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'Funciones'),
(72, 'choc', '2019-09-21', '10:30:58', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(73, 'choc', '2019-09-21', '10:31:13', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'Funciones'),
(74, 'choc', '2019-09-21', '10:43:20', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(75, 'choc', '2019-09-21', '10:46:15', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(76, 'choc', '2019-09-21', '10:50:53', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(77, 'rchocm', '2019-09-21', '10:51:18', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(78, 'choc', '2019-09-21', '11:08:13', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(79, 'choc', '2019-09-21', '11:09:06', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(80, 'choc', '2019-09-21', '11:17:30', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(81, 'choc', '2019-09-21', '11:19:42', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(82, 'choc', '2019-09-21', '11:21:15', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(83, 'choc', '2019-09-21', '11:22:16', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(84, 'choc', '2019-09-21', '11:22:42', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'Funciones'),
(85, 'choc', '2019-09-21', '11:23:38', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(86, 'choc', '2019-09-21', '11:29:22', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(87, 'choc', '2019-09-21', '11:34:35', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(88, 'choc', '2019-09-21', '11:35:28', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'Funciones'),
(89, 'rchocm', '2019-09-21', '11:36:55', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(90, 'rchocm', '2019-09-21', '11:37:18', 'AMAZING', '192.168.1.14', 'Se actualizó un registro', 'Funciones'),
(91, 'rchocm', '2019-09-21', '11:47:42', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(92, 'rchocm', '2019-09-21', '11:48:33', 'AMAZING', '192.168.1.14', 'Se actualizó un registro', 'Funciones'),
(93, 'rchocm', '2019-09-21', '11:52:54', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(94, 'rchocm', '2019-09-21', '11:54:35', 'AMAZING', '192.168.1.14', 'Se actualizó un registro', 'Funciones'),
(95, 'choc', '2019-09-21', '11:56:58', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(96, 'choc', '2019-09-21', '11:57:15', 'AMAZING', '192.168.1.14', 'Se creó un nuevo registro', 'Funciones'),
(97, 'rchocm', '2019-09-21', '11:57:38', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(98, 'rchocm', '2019-09-21', '11:58:08', 'AMAZING', '192.168.1.14', 'Se actualizó un registro', 'Funciones'),
(99, 'choc', '2019-09-21', '11:58:24', 'AMAZING', '192.168.1.14', 'Se logeo al sistema', 'Login'),
(100, 'rchocm', '2019-09-22', '12:18:28', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(101, 'choc', '2019-09-22', '12:18:56', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(102, 'choc', '2019-09-22', '12:19:37', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'Funciones'),
(103, 'choc', '2019-09-22', '12:19:59', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(104, 'choc', '2019-09-22', '12:20:30', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'Funciones'),
(105, 'Miusuario', '2019-09-22', '12:22:03', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(106, 'rchocm', '2019-09-22', '12:22:19', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(107, 'rchocm', '2019-09-22', '12:22:28', '657PC', '192.168.1.5', 'Se actualizó un registro', 'Funciones'),
(108, 'rchocm', '2019-09-22', '12:22:48', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'Funciones'),
(109, 'rchocm', '2019-09-22', '12:24:48', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(110, 'rchocm', '2019-09-22', '12:24:57', '657PC', '192.168.1.5', 'Se eliminó un registro', 'Funciones'),
(111, 'rchocm', '2019-09-22', '12:25:14', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(112, 'rchocm', '2019-09-22', '12:25:58', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(113, 'rchocm', '2019-09-22', '12:26:09', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'Funciones'),
(114, 'choc', '2019-09-22', '12:26:52', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(115, 'choc', '2019-09-22', '12:27:08', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'Funciones'),
(116, 'choc', '2019-09-22', '12:36:10', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(117, 'choc', '2019-09-22', '12:36:24', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'tbl_bodega'),
(118, 'choc', '2019-09-22', '12:39:09', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(119, 'choc', '2019-09-22', '12:39:21', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'tbl_bodega'),
(120, 'rchocm', '2019-09-22', '12:39:54', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(121, 'rchocm', '2019-09-22', '12:40:11', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'tbl_bodega'),
(122, 'choc', '2019-09-22', '12:43:02', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(123, 'choc', '2019-09-22', '12:47:05', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(124, 'choc', '2019-09-22', '12:53:16', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(125, 'choc', '2019-09-22', '01:02:38', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(126, 'choc', '2019-09-22', '01:03:08', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(127, 'choc', '2019-09-22', '01:04:04', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(128, 'choc', '2019-09-22', '01:09:20', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(129, 'choc', '2019-09-22', '01:40:35', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(130, 'choc', '2019-09-22', '01:47:07', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(131, 'choc', '2019-09-22', '01:49:56', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(132, 'choc', '2019-09-22', '02:17:58', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(133, 'choc', '2019-09-22', '02:24:52', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(134, 'choc', '2019-09-22', '02:25:18', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'tbl_bodega'),
(135, 'choc', '2019-09-22', '02:57:57', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(136, 'rchocm', '2019-09-22', '02:58:42', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(137, 'choc', '2019-09-22', '03:00:33', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(138, 'choc', '2019-09-22', '03:04:07', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(139, 'choc', '2019-09-22', '03:04:31', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(140, 'choc', '2019-09-22', '03:37:55', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(141, 'choc', '2019-09-22', '03:38:51', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(142, 'choc', '2019-09-22', '03:39:16', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'tbl_bodega'),
(143, 'rchocm', '2019-09-22', '03:39:33', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(144, 'rchocm', '2019-09-22', '03:39:52', '657PC', '192.168.1.5', 'Se actualizó un registro', 'tbl_bodega'),
(145, 'rchocm', '2019-09-22', '03:39:57', '657PC', '192.168.1.5', 'Se eliminó un registro', 'tbl_bodega'),
(146, 'choc', '2019-09-22', '01:04:41', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(147, 'choc', '2019-09-22', '01:08:18', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(148, 'choc', '2019-09-22', '01:08:45', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(149, 'choc', '2019-09-22', '01:10:00', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(150, 'choc', '2019-09-22', '01:14:59', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(151, 'choc', '2019-09-22', '01:16:11', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(152, 'choc', '2019-09-22', '01:16:17', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'tbl_bodega'),
(153, 'choc', '2019-09-22', '01:21:57', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(154, 'choc', '2019-09-22', '01:28:43', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(155, 'choc', '2019-09-22', '02:03:10', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(156, 'choc', '2019-09-22', '02:07:03', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(157, 'choc', '2019-09-22', '02:07:14', '657PC', '192.168.1.5', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(158, 'choc', '2019-09-22', '02:07:14', '657PC', '192.168.1.5', 'Realizo una consulta a modulos', 'tbl_modulos'),
(159, 'choc', '2019-09-22', '02:07:18', '657PC', '192.168.1.5', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(160, 'choc', '2019-09-22', '02:07:29', '657PC', '192.168.1.5', 'Asigno aplicacion: recepcion a usuario: admin', 'tbl_usuario_aplicacion'),
(161, 'choc', '2019-09-22', '02:07:43', '657PC', '192.168.1.5', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(162, 'choc', '2019-09-22', '02:08:05', '657PC', '192.168.1.5', 'Asigno aplicacion: recepcion a usuario: digitador', 'tbl_usuario_aplicacion'),
(163, 'choc', '2019-09-22', '02:08:10', '657PC', '192.168.1.5', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(164, 'choc', '2019-09-22', '02:08:28', '657PC', '192.168.1.5', 'Asigno aplicacion: recepcion a usuario: gus', 'tbl_usuario_aplicacion'),
(165, 'choc', '2019-09-22', '02:08:34', '657PC', '192.168.1.5', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(166, 'choc', '2019-09-22', '02:08:43', '657PC', '192.168.1.5', 'Asigno aplicacion: recepcion a usuario: gusAdmin', 'tbl_usuario_aplicacion'),
(167, 'choc', '2019-09-22', '02:08:55', '657PC', '192.168.1.5', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(168, 'choc', '2019-09-22', '02:08:55', '657PC', '192.168.1.5', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(169, 'choc', '2019-09-22', '02:09:09', '657PC', '192.168.1.5', 'Asigno perfil: admin a usuario: admin', 'tbl_usuario_perfil'),
(170, 'gus', '2019-09-22', '02:09:44', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(171, 'gus', '2019-09-22', '02:09:59', '657PC', '192.168.1.5', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(172, 'gus', '2019-09-22', '02:09:59', '657PC', '192.168.1.5', 'Realizo una consulta a modulos', 'tbl_modulos'),
(173, 'gus', '2019-09-22', '02:10:11', '657PC', '192.168.1.5', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(174, 'gus', '2019-09-22', '02:10:11', '657PC', '192.168.1.5', 'Realizo una consulta a modulos', 'tbl_modulos'),
(175, 'admin', '2019-09-22', '02:10:36', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(176, 'digitador', '2019-09-22', '02:10:52', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(177, 'digitador', '2019-09-22', '02:11:08', '657PC', '192.168.1.5', 'Realizo una consulta a usuarios', 'tbl_usuario'),
(178, 'digitador', '2019-09-22', '02:11:08', '657PC', '192.168.1.5', 'Realizo una consulta a modulos', 'tbl_modulos'),
(179, 'digitador', '2019-09-22', '02:11:13', '657PC', '192.168.1.5', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(180, 'digitador', '2019-09-22', '02:11:21', '657PC', '192.168.1.5', 'Asigno aplicacion: recepcion a usuario: digitador', 'tbl_usuario_aplicacion'),
(181, 'digitador', '2019-09-22', '02:11:25', '657PC', '192.168.1.5', 'Consulto bitacora', 'tbl_bitacora'),
(182, 'digitador', '2019-09-22', '02:11:41', '657PC', '192.168.1.5', 'Realizo una consulta a perfiles', 'tbl_perfil'),
(183, 'digitador', '2019-09-22', '02:11:41', '657PC', '192.168.1.5', 'Realizo una consulta a modulos', 'tbl_modulos'),
(184, 'digitador', '2019-09-22', '02:11:45', '657PC', '192.168.1.5', 'Realizo una consulta a aplicaciones', 'tbl_aplicacion'),
(185, 'digitador', '2019-09-22', '02:11:51', '657PC', '192.168.1.5', 'Asigno permiso: recepcion a perfil: usuario', 'tbl_usuario_aplicacion'),
(186, 'digitador', '2019-09-22', '02:13:52', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(187, 'admin', '2019-09-22', '02:14:20', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(188, 'admin', '2019-09-22', '02:18:47', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(189, 'admin', '2019-09-22', '02:19:28', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'tbl_bodega'),
(190, 'admin', '2019-09-22', '02:19:41', '657PC', '192.168.1.5', 'Se actualizó un registro', 'tbl_bodega'),
(191, 'admin', '2019-09-22', '02:19:54', '657PC', '192.168.1.5', 'Se eliminó un registro', 'tbl_bodega'),
(192, 'admin', '2019-09-22', '02:20:52', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(193, 'digitador', '2019-09-22', '02:21:25', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(194, 'digitador', '2019-09-22', '02:22:03', '657PC', '192.168.1.5', 'Se creó un nuevo registro', 'tbl_producto'),
(195, 'admin', '2019-09-22', '02:23:30', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(196, 'admin', '2019-09-22', '02:23:58', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(197, 'admin', '2019-09-22', '02:24:39', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(198, 'admin', '2019-09-22', '02:25:20', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(199, 'admin', '2019-09-22', '02:26:11', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(200, 'admin', '2019-09-22', '02:27:06', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(201, 'admin', '2019-09-22', '02:27:26', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(202, 'admin', '2019-09-22', '02:28:18', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(203, 'admin', '2019-09-22', '02:28:55', '657PC', '192.168.1.5', 'Se logeo al sistema', 'Login'),
(204, 'admin', '2019-09-24', '07:46:58', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se logeo al sistema', 'Login'),
(205, 'admin', '2019-09-24', '07:50:35', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se creó un nuevo registro', 'tbl_bodega'),
(206, 'admin', '2019-09-24', '07:51:15', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se eliminó un registro', 'tbl_bodega'),
(207, 'admin', '2019-09-24', '07:52:44', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se creó un nuevo registro', 'tbl_bodega'),
(208, 'admin', '2019-09-24', '07:55:48', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Consulto bitacora', 'tbl_bitacora'),
(209, 'admin', '2019-09-24', '08:01:00', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se logeo al sistema', 'Login'),
(210, 'digitador', '2019-09-24', '08:03:14', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se logeo al sistema', 'Login'),
(211, 'digitador', '2019-09-24', '08:04:56', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se creó un nuevo registro', 'tbl_producto'),
(212, 'digitador', '2019-09-24', '08:05:47', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Consulto bitacora', 'tbl_bitacora'),
(213, 'admin', '2019-09-24', '08:18:27', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se logeo al sistema', 'Login'),
(214, 'admin', '2019-09-24', '08:19:10', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se logeo al sistema', 'Login'),
(215, 'admin', '2019-09-24', '08:24:50', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se logeo al sistema', 'Login'),
(216, 'admin', '2019-09-25', '07:48:58', 'DESKTOP-F6RKCJ8', '192.168.1.27', 'Se logeo al sistema', 'Login'),
(217, 'choc', '2019-09-25', '11:51:57', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(218, 'choc', '2019-09-25', '11:52:05', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(219, 'choc', '2019-09-25', '11:52:19', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(220, 'choc', '2019-09-26', '12:02:27', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(221, 'choc', '2019-09-26', '12:02:43', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(222, 'choc', '2019-09-26', '12:02:56', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(223, 'admin', '2019-09-26', '12:45:52', 'DESKTOP-F6RKCJ8', '192.168.57.162', 'Se logeo al sistema', 'Login'),
(224, 'admin', '2019-09-26', '12:46:02', 'DESKTOP-F6RKCJ8', '192.168.57.162', 'Carga de Consultas', 'Consultas'),
(225, 'admin', '2019-09-26', '12:46:20', 'DESKTOP-F6RKCJ8', '192.168.57.162', 'Creacion de Consulta', 'Consultas'),
(226, 'admin', '2019-09-26', '04:53:12', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(227, 'admin', '2019-09-26', '04:56:07', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(228, 'admin', '2019-09-26', '05:02:09', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(229, 'admin', '2019-09-26', '05:02:15', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(230, 'admin', '2019-09-26', '05:03:06', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(231, 'admin', '2019-09-26', '05:03:09', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(232, 'admin', '2019-09-26', '05:25:59', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(233, 'admin', '2019-09-26', '05:26:09', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(234, 'admin', '2019-09-26', '05:26:13', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(235, 'admin', '2019-09-26', '05:26:14', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(236, 'admin', '2019-09-26', '05:26:20', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(237, 'admin', '2019-09-26', '05:26:50', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(238, 'admin', '2019-09-26', '05:26:54', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(239, 'admin', '2019-09-26', '05:42:48', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(240, 'admin', '2019-09-26', '05:42:53', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(241, 'admin', '2019-09-26', '05:43:06', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(242, 'admin', '2019-09-26', '06:05:37', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(243, 'admin', '2019-09-26', '06:06:52', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(244, 'admin', '2019-09-26', '06:08:32', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(245, 'admin', '2019-09-26', '06:08:47', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(246, 'admin', '2019-09-26', '06:08:57', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(247, 'admin', '2019-09-26', '06:11:05', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(248, 'admin', '2019-09-26', '06:11:13', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(249, 'admin', '2019-09-26', '06:11:15', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(250, 'admin', '2019-09-26', '06:11:43', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(251, 'admin', '2019-09-26', '06:12:00', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(252, 'admin', '2019-09-26', '06:12:50', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(253, 'admin', '2019-09-26', '06:13:50', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(254, 'admin', '2019-09-26', '06:13:59', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(255, 'admin', '2019-09-26', '06:15:21', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(256, 'admin', '2019-09-26', '06:16:30', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(257, 'admin', '2019-09-26', '06:16:44', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(258, 'admin', '2019-09-26', '06:16:46', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(259, 'admin', '2019-09-26', '06:18:50', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(260, 'admin', '2019-09-26', '06:22:00', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(261, 'admin', '2019-09-26', '06:23:32', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(262, 'admin', '2019-09-26', '06:24:10', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(263, 'admin', '2019-09-26', '06:24:55', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(264, 'admin', '2019-09-26', '06:27:28', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(265, 'admin', '2019-09-26', '06:28:04', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(266, 'admin', '2019-09-26', '06:28:49', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(267, 'admin', '2019-09-26', '06:34:58', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(268, 'admin', '2019-09-26', '06:35:07', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(269, 'admin', '2019-09-26', '06:37:10', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(270, 'admin', '2019-09-26', '06:40:12', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(271, 'admin', '2019-09-26', '06:41:47', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(272, 'admin', '2019-09-26', '06:42:23', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(273, 'admin', '2019-09-26', '06:42:32', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(274, 'admin', '2019-09-26', '06:43:40', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(275, 'admin', '2019-09-26', '06:44:09', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(276, 'admin', '2019-09-26', '06:44:38', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(277, 'admin', '2019-09-26', '06:44:44', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(278, 'admin', '2019-09-26', '06:45:36', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(279, 'admin', '2019-09-26', '06:46:28', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(280, 'admin', '2019-09-26', '06:47:12', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(281, 'admin', '2019-09-26', '06:48:06', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(282, 'admin', '2019-09-26', '06:48:45', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(283, 'admin', '2019-09-26', '07:02:16', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(284, 'admin', '2019-09-26', '07:05:20', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Modificacion de Consulta', 'Consultas'),
(285, 'admin', '2019-09-26', '07:09:06', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(286, 'admin', '2019-09-26', '07:10:31', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(287, 'admin', '2019-09-26', '07:11:42', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(288, 'admin', '2019-09-26', '07:13:45', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(289, 'admin', '2019-09-26', '07:14:32', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(290, 'admin', '2019-09-26', '07:15:15', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(291, 'admin', '2019-09-26', '07:19:34', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(292, 'admin', '2019-09-26', '07:19:40', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(293, 'admin', '2019-09-26', '07:20:25', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(294, 'admin', '2019-09-26', '07:21:31', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(295, 'admin', '2019-09-26', '07:22:24', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(296, 'admin', '2019-09-26', '07:23:23', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(297, 'admin', '2019-09-26', '07:23:27', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(298, 'admin', '2019-09-26', '07:23:53', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(299, 'admin', '2019-09-26', '07:24:11', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(300, 'admin', '2019-09-26', '07:25:06', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(301, 'admin', '2019-09-26', '07:26:04', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(302, 'admin', '2019-09-26', '07:26:09', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(303, 'admin', '2019-09-26', '07:29:27', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Modificacion de Consulta', 'Consultas'),
(304, 'admin', '2019-09-26', '07:29:32', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(305, 'admin', '2019-09-26', '07:31:36', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(306, 'admin', '2019-09-26', '08:03:30', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(307, 'admin', '2019-09-26', '08:03:35', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(308, 'admin', '2019-09-26', '08:03:38', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(309, 'admin', '2019-09-26', '08:17:15', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(310, 'admin', '2019-09-26', '08:17:20', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(311, 'admin', '2019-09-27', '02:16:45', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(312, 'admin', '2019-09-27', '02:16:55', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(313, 'admin', '2019-09-27', '02:17:00', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(314, 'admin', '2019-09-27', '02:17:45', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(315, 'admin', '2019-09-27', '02:17:51', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(316, 'admin', '2019-09-27', '02:18:58', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(317, 'admin', '2019-09-27', '02:19:01', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(318, 'admin', '2019-09-27', '02:19:31', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Modificacion de Consulta', 'Consultas'),
(319, 'admin', '2019-09-27', '02:19:34', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(320, 'admin', '2019-09-27', '02:19:58', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Eliminacion de Consulta', 'Consultas'),
(321, 'admin', '2019-09-27', '02:20:07', 'DESKTOP-F6RKCJ8', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(322, 'admin', '2019-09-27', '07:23:06', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Se logeo al sistema', 'Login'),
(323, 'admin', '2019-09-27', '07:23:43', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Carga de Consultas', 'Consultas'),
(324, 'admin', '2019-09-27', '07:24:58', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Creacion de Consulta', 'Consultas'),
(325, 'admin', '2019-09-27', '07:25:53', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Carga de Consultas', 'Consultas'),
(326, 'admin', '2019-09-27', '07:27:52', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Creacion de Consulta', 'Consultas'),
(327, 'admin', '2019-09-27', '07:28:29', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Creacion de Consulta', 'Consultas'),
(328, 'admin', '2019-09-27', '07:28:33', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Carga de Consultas', 'Consultas'),
(329, 'admin', '2019-09-27', '07:30:02', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Creacion de Consulta', 'Consultas'),
(330, 'admin', '2019-09-27', '07:30:26', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Carga de Consultas', 'Consultas'),
(331, 'admin', '2019-09-27', '07:32:13', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Modificacion de Consulta', 'Consultas'),
(332, 'admin', '2019-09-27', '07:32:28', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Carga de Consultas', 'Consultas'),
(333, 'admin', '2019-09-27', '07:33:10', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Eliminacion de Consulta', 'Consultas'),
(334, 'admin', '2019-09-27', '07:34:44', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Carga de Consultas', 'Consultas'),
(335, 'admin', '2019-09-27', '07:42:34', 'DESKTOP-F6RKCJ8', '169.254.107.2', 'Carga de Consultas', 'Consultas'),
(336, 'admin', '2019-10-22', '05:51:22', 'DIEGOT', '192.168.1.21', 'Se logeo al sistema', 'Login'),
(337, 'admin', '2019-10-22', '07:13:03', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(338, 'admin', '2019-10-22', '07:19:47', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(339, 'admin', '2019-10-22', '07:25:20', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(340, 'admin', '2019-10-22', '07:26:03', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(341, 'admin', '2019-10-22', '07:27:55', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(342, 'Admin', '2019-10-24', '04:56:49', 'DIEGOT', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(343, 'Admin', '2019-10-24', '04:57:40', 'DIEGOT', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(344, 'Admin', '2019-10-24', '04:57:43', 'DIEGOT', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(345, 'Admin', '2019-10-24', '05:03:30', 'DIEGOT', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(346, 'Admin', '2019-10-24', '05:07:04', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(347, 'Admin', '2019-10-24', '05:07:25', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(348, 'admin', '2019-10-24', '07:08:34', 'DIEGOT', '192.168.1.21', 'Se creó un nuevo registro', 'tbl_tipocliente'),
(349, 'admin', '2019-10-24', '07:09:19', 'DIEGOT', '192.168.1.21', 'Se creó un nuevo registro', 'tbl_clientes'),
(350, 'admin', '2019-11-03', '07:04:19', 'DIEGOT', '192.168.1.21', 'Se creó un nuevo registro', 'tbl_tipoproducto'),
(351, 'admin', '2019-11-03', '07:04:33', 'DIEGOT', '192.168.1.21', 'Se actualizó un registro', 'tbl_tipoproducto'),
(352, 'admin', '2019-11-03', '07:04:46', 'DIEGOT', '192.168.1.21', 'Se creó un nuevo registro', 'tbl_tipoproducto'),
(353, 'admin', '2019-11-03', '07:08:10', 'DIEGOT', '192.168.1.21', 'Se eliminó un registro', 'tbl_tipoproducto'),
(354, 'admin', '2019-11-03', '07:14:21', 'DIEGOT', '192.168.1.21', 'Se creó un nuevo registro', 'tbl_producto'),
(355, 'MiUsuario', '2019-11-04', '01:26:27', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(356, 'MiUsuario', '2019-11-04', '01:26:29', 'DIEGOT', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(357, 'MiUsuario', '2019-11-04', '01:27:34', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(358, 'MiUsuario', '2019-11-04', '01:27:36', 'DIEGOT', '192.168.1.21', 'Carga de Consultas', 'Consultas'),
(359, 'MiUsuario', '2019-11-04', '01:28:16', 'DIEGOT', '192.168.1.21', 'Creacion de Consulta', 'Consultas'),
(360, 'MiUsuario', '2019-11-04', '01:28:19', 'DIEGOT', '192.168.1.21', 'Carga de Consultas', 'Consultas');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_carpeta_mdl`
--

CREATE TABLE `tbl_carpeta_mdl` (
  `ID_CONFIGURACION` int(12) NOT NULL,
  `ID_MODULO` int(12) NOT NULL,
  `ESTADO` int(2) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_carpeta_mdl`
--

INSERT INTO `tbl_carpeta_mdl` (`ID_CONFIGURACION`, `ID_MODULO`, `ESTADO`) VALUES
(2, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_configuracion_rpt`
--

CREATE TABLE `tbl_configuracion_rpt` (
  `ID_CONFIGURACION` int(12) NOT NULL,
  `NOMBRE` varchar(50) NOT NULL,
  `USER` varchar(50) DEFAULT NULL,
  `PASSWORD` varchar(100) DEFAULT NULL,
  `PUERTO` varchar(3) DEFAULT NULL,
  `RUTA` varchar(100) NOT NULL,
  `ESTADO` int(2) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_configuracion_rpt`
--

INSERT INTO `tbl_configuracion_rpt` (`ID_CONFIGURACION`, `NOMBRE`, `USER`, `PASSWORD`, `PUERTO`, `RUTA`, `ESTADO`) VALUES
(3, 'mdlSeguridad', 'na', 'na', 'na', 'C:\\\\Reportes\\\\Seguridad\\\\', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulo`
--

CREATE TABLE `tbl_modulo` (
  `PK_id_Modulo` int(11) NOT NULL,
  `nombre_modulo` varchar(45) DEFAULT NULL,
  `descripcion_modulo` varchar(200) DEFAULT NULL,
  `estado_modulo` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_modulo`
--

INSERT INTO `tbl_modulo` (`PK_id_Modulo`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1, 'hoteleria', 'hoteleria', 1),
(3, 'MDI', 'na', 1),
(4, 'Seguridad', 'na', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_detalle`
--

CREATE TABLE `tbl_perfil_detalle` (
  `PK_id_perfil` int(11) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_perfil_detalle`
--

INSERT INTO `tbl_perfil_detalle` (`PK_id_perfil`, `PK_id_aplicacion`, `ingresar`, `consultar`, `modificar`, `eliminar`, `imprimir`) VALUES
(1, 1, 1, 1, 1, 1, 1),
(2, 1, 1, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_encabezado`
--

CREATE TABLE `tbl_perfil_encabezado` (
  `PK_id_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(45) DEFAULT NULL,
  `descripcion_perfil` varchar(200) DEFAULT NULL,
  `estado_perfil` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_perfil_encabezado`
--

INSERT INTO `tbl_perfil_encabezado` (`PK_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'admin', 'admin', 1),
(2, 'usuario', 'usuario', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_reporte`
--

CREATE TABLE `tbl_reporte` (
  `ID_REPORTE` int(12) NOT NULL,
  `ID_CONFIGURACION` int(12) NOT NULL,
  `NOMBRE` varchar(50) NOT NULL,
  `FILENAME` varchar(100) NOT NULL,
  `ESTADO` int(2) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbl_reporte`
--

INSERT INTO `tbl_reporte` (`ID_REPORTE`, `ID_CONFIGURACION`, `NOMBRE`, `FILENAME`, `ESTADO`) VALUES
(1, 3, 'Prueba1', 'AlumnoCurso.rpt', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_rpt_almacen`
--

CREATE TABLE `tbl_rpt_almacen` (
  `ID_RPT_ALMACEN` int(12) NOT NULL,
  `ID_USUARIO` int(12) NOT NULL,
  `ID_MODULO` int(12) NOT NULL,
  `NOMBRE` varchar(50) NOT NULL,
  `FECHA` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `ESTADO` int(12) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_rpt_app`
--

CREATE TABLE `tbl_rpt_app` (
  `ID_REPORTE` int(12) NOT NULL,
  `ID_APLICACION` int(11) NOT NULL,
  `ID_MODULO` int(11) NOT NULL,
  `ESTADO` int(2) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_rpt_mdl`
--

CREATE TABLE `tbl_rpt_mdl` (
  `ID_REPORTE` int(12) NOT NULL,
  `ID_MODULO` int(11) NOT NULL,
  `ESTADO` int(2) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario`
--

CREATE TABLE `tbl_usuario` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `nombre_usuario` varchar(45) DEFAULT NULL,
  `apellido_usuarios` varchar(45) DEFAULT NULL,
  `password_usuario` varchar(45) DEFAULT NULL,
  `cambio_contrasena` tinyint(4) DEFAULT NULL,
  `ultima_conexion` datetime DEFAULT NULL,
  `estado_usuario` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_usuario`
--

INSERT INTO `tbl_usuario` (`PK_id_usuario`, `nombre_usuario`, `apellido_usuarios`, `password_usuario`, `cambio_contrasena`, `ultima_conexion`, `estado_usuario`) VALUES
('admin', 'admin', 'admin', '202cb962ac59075b964b07152d234b70', 0, '2019-09-05 00:00:00', 1),
('choc', 'choc', 'choc', '509424c905af58c81c60603b8acd70b6', NULL, NULL, 1),
('digitador', 'user', 'user', '202cb962ac59075b964b07152d234b70', 0, '2019-09-06 00:00:00', 1),
('gus', 'gus', 'gus', '84a26c4612a7f9958174ee6552625282', 0, '2019-09-12 00:00:00', 1),
('gusAdmin', 'gus', 'gus', '84a26c4612a7f9958174ee6552625282', 0, '2019-09-04 00:00:00', 1),
('MiUsuario', 'Usuario', 'Prueba', 'e19d5cd5af0378da05f63f891c7467af', 0, NULL, 1),
('rchocm', 'randy', 'choc', '17d0234375b389906d21b70ba5db8cae', NULL, NULL, 1);

--
-- Disparadores `tbl_usuario`
--
DELIMITER $$
CREATE TRIGGER `actualizarClave` BEFORE UPDATE ON `tbl_usuario` FOR EACH ROW IF NEW.password_usuario <> OLD.password_usuario THEN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END IF
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `encriptarClave` BEFORE INSERT ON `tbl_usuario` FOR EACH ROW BEGIN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_aplicacion`
--

CREATE TABLE `tbl_usuario_aplicacion` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_perfil`
--

CREATE TABLE `tbl_usuario_perfil` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_perfil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_usuario_perfil`
--

INSERT INTO `tbl_usuario_perfil` (`PK_id_usuario`, `PK_id_perfil`) VALUES
('admin', 1),
('choc', 2),
('digitador', 2),
('rchocm', 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_aplicacion`
--
ALTER TABLE `tbl_aplicacion`
  ADD PRIMARY KEY (`PK_id_aplicacion`,`PK_id_modulo`),
  ADD KEY `fk_Aplicacion_Modulo` (`PK_id_modulo`);

--
-- Indices de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD PRIMARY KEY (`PK_id_bitacora`,`PK_id_usuario`),
  ADD KEY `fk_Bitacora_Usuario1` (`PK_id_usuario`);

--
-- Indices de la tabla `tbl_carpeta_mdl`
--
ALTER TABLE `tbl_carpeta_mdl`
  ADD PRIMARY KEY (`ID_CONFIGURACION`,`ID_MODULO`),
  ADD KEY `FK_CRPT_MDL_USUARIO` (`ID_MODULO`);

--
-- Indices de la tabla `tbl_configuracion_rpt`
--
ALTER TABLE `tbl_configuracion_rpt`
  ADD PRIMARY KEY (`ID_CONFIGURACION`);

--
-- Indices de la tabla `tbl_modulo`
--
ALTER TABLE `tbl_modulo`
  ADD PRIMARY KEY (`PK_id_Modulo`);

--
-- Indices de la tabla `tbl_perfil_detalle`
--
ALTER TABLE `tbl_perfil_detalle`
  ADD PRIMARY KEY (`PK_id_perfil`,`PK_id_aplicacion`),
  ADD KEY `fk_Perfil_detalle_Aplicacion1` (`PK_id_aplicacion`);

--
-- Indices de la tabla `tbl_perfil_encabezado`
--
ALTER TABLE `tbl_perfil_encabezado`
  ADD PRIMARY KEY (`PK_id_perfil`);

--
-- Indices de la tabla `tbl_reporte`
--
ALTER TABLE `tbl_reporte`
  ADD PRIMARY KEY (`ID_REPORTE`),
  ADD KEY `FK_RPT_CONFIGURACION` (`ID_CONFIGURACION`);

--
-- Indices de la tabla `tbl_rpt_almacen`
--
ALTER TABLE `tbl_rpt_almacen`
  ADD PRIMARY KEY (`ID_RPT_ALMACEN`),
  ADD KEY `FK_RPT_ALM_MODULO` (`ID_MODULO`);

--
-- Indices de la tabla `tbl_rpt_app`
--
ALTER TABLE `tbl_rpt_app`
  ADD PRIMARY KEY (`ID_REPORTE`,`ID_APLICACION`,`ID_MODULO`),
  ADD KEY `FK_RPT_APP_APLICACION` (`ID_APLICACION`),
  ADD KEY `FK_RPT_APP_MODULO` (`ID_MODULO`);

--
-- Indices de la tabla `tbl_rpt_mdl`
--
ALTER TABLE `tbl_rpt_mdl`
  ADD PRIMARY KEY (`ID_REPORTE`,`ID_MODULO`),
  ADD KEY `FK_RPT_MDL_MODULO` (`ID_MODULO`);

--
-- Indices de la tabla `tbl_usuario`
--
ALTER TABLE `tbl_usuario`
  ADD PRIMARY KEY (`PK_id_usuario`);

--
-- Indices de la tabla `tbl_usuario_aplicacion`
--
ALTER TABLE `tbl_usuario_aplicacion`
  ADD PRIMARY KEY (`PK_id_usuario`,`PK_id_aplicacion`),
  ADD KEY `fk_tbl_usuario_aplicacion_tbl_aplicacion1` (`PK_id_aplicacion`);

--
-- Indices de la tabla `tbl_usuario_perfil`
--
ALTER TABLE `tbl_usuario_perfil`
  ADD PRIMARY KEY (`PK_id_usuario`,`PK_id_perfil`),
  ADD KEY `fk_Usuario_perfil_Perfil1` (`PK_id_perfil`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  MODIFY `PK_id_bitacora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=362;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_aplicacion`
--
ALTER TABLE `tbl_aplicacion`
  ADD CONSTRAINT `fk_Aplicacion_Modulo` FOREIGN KEY (`PK_id_modulo`) REFERENCES `tbl_modulo` (`PK_id_Modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD CONSTRAINT `fk_Bitacora_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_carpeta_mdl`
--
ALTER TABLE `tbl_carpeta_mdl`
  ADD CONSTRAINT `FK_CRPT_MDL_USUARIO` FOREIGN KEY (`ID_MODULO`) REFERENCES `tbl_modulo` (`PK_id_Modulo`);

--
-- Filtros para la tabla `tbl_perfil_detalle`
--
ALTER TABLE `tbl_perfil_detalle`
  ADD CONSTRAINT `fk_Perfil_detalle_Aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Perfil_detalle_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_reporte`
--
ALTER TABLE `tbl_reporte`
  ADD CONSTRAINT `FK_RPT_CONFIGURACION` FOREIGN KEY (`ID_CONFIGURACION`) REFERENCES `tbl_configuracion_rpt` (`ID_CONFIGURACION`);

--
-- Filtros para la tabla `tbl_rpt_almacen`
--
ALTER TABLE `tbl_rpt_almacen`
  ADD CONSTRAINT `FK_RPT_ALM_MODULO` FOREIGN KEY (`ID_MODULO`) REFERENCES `tbl_modulo` (`PK_id_Modulo`),
  ADD CONSTRAINT `FK_RPT_ALM_USUARIO` FOREIGN KEY (`ID_MODULO`) REFERENCES `tbl_modulo` (`PK_id_Modulo`);

--
-- Filtros para la tabla `tbl_rpt_app`
--
ALTER TABLE `tbl_rpt_app`
  ADD CONSTRAINT `FK_RPT_APP_APLICACION` FOREIGN KEY (`ID_APLICACION`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`),
  ADD CONSTRAINT `FK_RPT_APP_MODULO` FOREIGN KEY (`ID_MODULO`) REFERENCES `tbl_modulo` (`PK_id_Modulo`),
  ADD CONSTRAINT `FK_RPT_APP_REPORTE` FOREIGN KEY (`ID_REPORTE`) REFERENCES `tbl_reporte` (`ID_REPORTE`);

--
-- Filtros para la tabla `tbl_rpt_mdl`
--
ALTER TABLE `tbl_rpt_mdl`
  ADD CONSTRAINT `FK_RPT_MDL_MODULO` FOREIGN KEY (`ID_MODULO`) REFERENCES `tbl_modulo` (`PK_id_Modulo`),
  ADD CONSTRAINT `FK_RPT_MDL_REPORTE` FOREIGN KEY (`ID_REPORTE`) REFERENCES `tbl_reporte` (`ID_REPORTE`);

--
-- Filtros para la tabla `tbl_usuario_aplicacion`
--
ALTER TABLE `tbl_usuario_aplicacion`
  ADD CONSTRAINT `fk_Usuario_aplicacion_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_usuario_aplicacion_tbl_aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_usuario_perfil`
--
ALTER TABLE `tbl_usuario_perfil`
  ADD CONSTRAINT `fk_Usuario_perfil_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Usuario_perfil_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
