-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 06-11-2019 a las 20:55:18
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `proyectogeneral`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `procedimientoLogin`(IN `usuario` VARCHAR(25), IN `clave` VARCHAR(25))
    NO SQL
Select tbl_usuario.PK_id_Usuario FROM tbl_usuario where tbl_usuario.PK_id_Usuario = usuario and tbl_usuario.password_usuario = MD5(clave) AND tbl_usuario.estado_usuario=1$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ayuda`
--

CREATE TABLE IF NOT EXISTS `ayuda` (
  `Id_ayuda` int(11) NOT NULL,
  `Ruta` text COLLATE utf8_unicode_ci NOT NULL,
  `indice` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `ayuda`
--

INSERT INTO `ayuda` (`Id_ayuda`, `Ruta`, `indice`) VALUES
(1, 'Página web ayuda/ayuda.chm', 'menu.html'),
(2, 'Página web ayuda/ayuda.chm', 'Menúboletos.html'),
(3, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index1.html'),
(4, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index2.html'),
(5, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index3.html'),
(6, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index4.html'),
(7, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index5.html'),
(8, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index6.html'),
(9, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index7.html'),
(10, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index8.html'),
(11, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index9.html'),
(12, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_Ventas\\MDI_Ventas\\bin\\Debug\\Ayudas_Ventas.chm', 'index10.html'),
(13, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_CuentasPorCobrar\\MDI_CuentasPorCobrar\\bin\\Debug\\Ayudas_CuentasPorCobrar.chm', 'index.html'),
(14, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_CuentasPorCobrar\\MDI_CuentasPorCobrar\\bin\\Debug\\Ayudas_CuentasPorCobrar.chm', 'index11a.html'),
(15, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_CuentasPorCobrar\\MDI_CuentasPorCobrar\\bin\\Debug\\Ayudas_CuentasPorCobrar.chm', 'indexab.html'),
(16, 'C:\\Users\\Paula V\\Desktop\\Ventas y Cuentas por Cobrar\\CuentasCobrarVentas\\MDI_CuentasPorCobrar\\MDI_CuentasPorCobrar\\bin\\Debug\\Ayudas_CuentasPorCobrar.chm', 'index61.html');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblproveedorbodega`
--

CREATE TABLE IF NOT EXISTS `tblproveedorbodega` (
  `KidProveedorBodega` int(16) NOT NULL,
  `KidProveedor` int(16) NOT NULL,
  `KidBodega` int(16) NOT NULL,
  `KidProducto` int(16) NOT NULL,
  `stock` int(3) DEFAULT NULL,
  `maxStock` int(3) DEFAULT NULL,
  `minStock` int(3) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidProveedorBodega`),
  KEY `FK_proveedor_bodega` (`KidProveedor`),
  KEY `FK_bodega_proveedor` (`KidBodega`),
  KEY `Fk_proveedor_bodega_producto` (`KidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_acreedor`
--

CREATE TABLE IF NOT EXISTS `tbl_acreedor` (
  `KidAcreedor` int(12) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidAcreedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_aplicacion`
--

CREATE TABLE IF NOT EXISTS `tbl_aplicacion` (
  `PK_id_aplicacion` int(11) NOT NULL,
  `PK_id_modulo` int(11) NOT NULL,
  `nombre_aplicacion` varchar(45) DEFAULT NULL,
  `descripcion_aplicacion` varchar(200) DEFAULT NULL,
  `estado_aplicacion` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_aplicacion`,`PK_id_modulo`),
  KEY `fk_Aplicacion_Modulo` (`PK_id_modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_areas`
--

CREATE TABLE IF NOT EXISTS `tbl_areas` (
  `KidArea` int(11) NOT NULL,
  `nombreArea` varchar(45) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`KidArea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_asignacion_empleado`
--

CREATE TABLE IF NOT EXISTS `tbl_asignacion_empleado` (
  `KidPoliza` int(11) NOT NULL,
  `KidComisiones` int(11) NOT NULL,
  `KidEmpleados` int(11) NOT NULL,
  PRIMARY KEY (`KidPoliza`,`KidComisiones`),
  KEY `fk_Ventas_has_Comisiones_Comisiones1` (`KidComisiones`),
  KEY `fk_Asignacion_Empleado_Empleados1` (`KidEmpleados`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_balancegeneral_detalle`
--

CREATE TABLE IF NOT EXISTS `tbl_balancegeneral_detalle` (
  `KidBalanceGeneral` int(11) NOT NULL,
  `KidCuentaContable` varchar(10) NOT NULL,
  `valor` float DEFAULT NULL,
  PRIMARY KEY (`KidBalanceGeneral`,`KidCuentaContable`),
  KEY `fk_tbl_BalanceGeneral_Detalle_tbl_cuentas_contables1` (`KidCuentaContable`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_balancegeneral_encabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_balancegeneral_encabezado` (
  `KidBalanceGeneral` int(11) NOT NULL AUTO_INCREMENT,
  `capital` float DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidBalanceGeneral`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bancos`
--

CREATE TABLE IF NOT EXISTS `tbl_bancos` (
  `KidBanco` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidBanco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bancotalento`
--

CREATE TABLE IF NOT EXISTS `tbl_bancotalento` (
  `KidBancoTalento` int(11) NOT NULL DEFAULT '0',
  `nombre_candidato` varchar(45) DEFAULT NULL,
  `apellido_candidato` varchar(45) DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `correoelectronico` varchar(45) DEFAULT NULL,
  `KidReporteVacante` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidBancoTalento`),
  KEY `FK_encabezadoReporteVacante_BancoTalento` (`KidReporteVacante`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bitacora`
--

CREATE TABLE IF NOT EXISTS `tbl_bitacora` (
  `PK_id_bitacora` int(11) NOT NULL AUTO_INCREMENT,
  `PK_id_usuario` varchar(25) NOT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `host` varchar(45) DEFAULT NULL,
  `ip` varchar(25) DEFAULT NULL,
  `accion` varchar(50) DEFAULT NULL,
  `tabla` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`PK_id_bitacora`,`PK_id_usuario`),
  KEY `fk_Bitacora_Usuario1` (`PK_id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_bodega`
--

CREATE TABLE IF NOT EXISTS `tbl_bodega` (
  `KidBodega` int(16) NOT NULL,
  `KidSucursal` int(16) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `direccion` varchar(20) DEFAULT NULL,
  `maxStock` int(3) DEFAULT NULL,
  `minStock` int(3) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidBodega`),
  KEY `FK_Sucursal_Bodega` (`KidSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_categorias_habitacion`
--

CREATE TABLE IF NOT EXISTS `tbl_categorias_habitacion` (
  `KidCategoria` varchar(45) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidCategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Disparadores `tbl_categorias_habitacion`
--
DROP TRIGGER IF EXISTS `EstadoHabitaciones2`;
DELIMITER //
CREATE TRIGGER `EstadoHabitaciones2` AFTER UPDATE ON `tbl_categorias_habitacion`
 FOR EACH ROW BEGIN
UPDATE tbl_habitaciones set estado = new.estado WHERE tbl_habitaciones.KidCategoria=new.KidCategoria;
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_check_in`
--

CREATE TABLE IF NOT EXISTS `tbl_check_in` (
  `KidCheckIn` int(11) NOT NULL,
  `KidCliente` int(11) NOT NULL,
  `KidEmpleado` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidCheckIn`),
  KEY `fk_Tbl_Check_In_Tbl_Empleados1` (`KidEmpleado`),
  KEY `fk_Tbl_Check_In_Tbl_Clientes1` (`KidCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_check_out`
--

CREATE TABLE IF NOT EXISTS `tbl_check_out` (
  `KidCheckOut` int(11) NOT NULL,
  `KidCliente` int(11) NOT NULL,
  `KidEmpleado` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidCheckOut`),
  KEY `fk_Tbl_Check_Out_Tbl_Clientes1` (`KidCliente`),
  KEY `fk_Tbl_Check_Out_Tbl_Empleados1` (`KidEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_chequera`
--

CREATE TABLE IF NOT EXISTS `tbl_chequera` (
  `KidChequera` int(4) NOT NULL AUTO_INCREMENT,
  `KidCuentaBancaria` int(11) NOT NULL,
  `No_cheques` int(4) NOT NULL,
  `estado` tinyint(1) NOT NULL,
  PRIMARY KEY (`KidChequera`),
  KEY `FK_CuentaBancaria_Chequera` (`KidCuentaBancaria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_clientes`
--

CREATE TABLE IF NOT EXISTS `tbl_clientes` (
  `KidCliente` int(11) NOT NULL,
  `nombres_cliente` varchar(45) DEFAULT NULL,
  `apellidos_cliente` varchar(45) DEFAULT NULL,
  `telefono_cliente` varchar(10) DEFAULT NULL,
  `direccion_cliente` text,
  `dpi_cliente` int(11) DEFAULT NULL,
  `nit_cliente` varchar(10) DEFAULT NULL,
  `contacto_cliente` varchar(45) DEFAULT NULL,
  `telefono_contacto` varchar(10) DEFAULT NULL,
  `KidTipoCliente` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidCliente`),
  KEY `fk_Cliente_TipoCliente` (`KidTipoCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_clientes`
--

INSERT INTO `tbl_clientes` (`KidCliente`, `nombres_cliente`, `apellidos_cliente`, `telefono_cliente`, `direccion_cliente`, `dpi_cliente`, `nit_cliente`, `contacto_cliente`, `telefono_contacto`, `KidTipoCliente`, `estado`) VALUES
(1, 'Paula', 'Vasquez', '1234567', '14 avenida B 12-10 zona 3 de mixco', 2147483647, '123456-8', 'Paula Vásquez', '12345678', 1, 1),
(2, 'Mayor.S.A', '-', '1234567', '15 calle 2 avenida A', 1, '123456-9', 'Paula Vásquez', '1234567', 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_comandas`
--

CREATE TABLE IF NOT EXISTS `tbl_comandas` (
  `KidNumeroComanda` int(11) NOT NULL,
  `KidServicio` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidNumeroComanda`),
  KEY `service` (`KidServicio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_comisiones`
--

CREATE TABLE IF NOT EXISTS `tbl_comisiones` (
  `KidComisiones` int(11) NOT NULL,
  `KidProducto` int(11) NOT NULL,
  `fecha_comisiones` date DEFAULT NULL,
  `descripcion_comisiones` varchar(45) DEFAULT NULL,
  `monto_comisiones` double DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidComisiones`),
  KEY `fk_Producto_Comisiones` (`KidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_comisiones`
--

INSERT INTO `tbl_comisiones` (`KidComisiones`, `KidProducto`, `fecha_comisiones`, `descripcion_comisiones`, `monto_comisiones`, `estado`) VALUES
(1, 2, '2019-11-05', 'venta', 0.3, 1),
(2, 4, '2019-11-06', 'Compra', 0.6, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_conceptos`
--

CREATE TABLE IF NOT EXISTS `tbl_conceptos` (
  `KidConcepto` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `naturalezaconcepto` varchar(45) DEFAULT NULL,
  `valor` float DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`KidConcepto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_conciliacion_bancaria`
--

CREATE TABLE IF NOT EXISTS `tbl_conciliacion_bancaria` (
  `KidBanco` int(11) NOT NULL,
  `moneda` varchar(45) NOT NULL,
  `mes_conciliacion` varchar(45) NOT NULL,
  `diferencia_total` double DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidBanco`,`moneda`,`mes_conciliacion`),
  KEY `FK_Moneda_ConciliacionBancaria` (`moneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_configuracion_rpt`
--

CREATE TABLE IF NOT EXISTS `tbl_configuracion_rpt` (
  `PK_id_configuracion` int(12) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `ruta` varchar(100) NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`PK_id_configuracion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_consulta`
--

CREATE TABLE IF NOT EXISTS `tbl_consulta` (
  `KidConsulta` int(11) NOT NULL,
  `cadena_consulta` varchar(255) DEFAULT NULL,
  `nombreconsulta_consulta` varchar(45) DEFAULT NULL,
  `descripcion_consulta` varchar(255) DEFAULT NULL,
  `KidUsuario` varchar(45) NOT NULL DEFAULT '',
  `disponible` tinyint(1) NOT NULL,
  PRIMARY KEY (`KidConsulta`,`KidUsuario`),
  KEY `FK_usuario_consulta` (`KidUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_contacto`
--

CREATE TABLE IF NOT EXISTS `tbl_contacto` (
  `KidContacto` int(16) NOT NULL,
  `KidProveedor` int(16) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidContacto`),
  KEY `fk_proveedor_contacto` (`KidProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_control_mesas`
--

CREATE TABLE IF NOT EXISTS `tbl_control_mesas` (
  `KidControl` int(11) NOT NULL,
  `KidNumeroMesa` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidControl`),
  KEY `mesa` (`KidNumeroMesa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cotizaciondetalle`
--

CREATE TABLE IF NOT EXISTS `tbl_cotizaciondetalle` (
  `KidCotizacionDetalle` int(11) NOT NULL DEFAULT '0',
  `KidProducto` int(11) DEFAULT NULL,
  `cantidad_cotizacionDetalle` int(11) DEFAULT NULL,
  `monto_cotizacionDetalle` double DEFAULT NULL,
  PRIMARY KEY (`KidCotizacionDetalle`),
  KEY `FK_Productos_cotizacionDetalle` (`KidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cotizacionencabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_cotizacionencabezado` (
  `KidCotizacionEncabezado` int(11) NOT NULL DEFAULT '0',
  `KidCliente` int(11) DEFAULT NULL,
  `fecha_cotizacionEncabezado` date DEFAULT NULL,
  `vencimiento_cotizacionEncabezado` date DEFAULT NULL,
  PRIMARY KEY (`KidCotizacionEncabezado`),
  KEY `FK_clientes_cotizacionEncabezado` (`KidCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_creditopedido`
--

CREATE TABLE IF NOT EXISTS `tbl_creditopedido` (
  `KidCreditoPedido` int(12) NOT NULL,
  `KidPedido` int(12) NOT NULL,
  `KidBanco` int(12) NOT NULL,
  `total` double(12,2) NOT NULL,
  `cuotas` int(2) NOT NULL,
  `fechaIni` timestamp NULL DEFAULT NULL,
  `fechaFin` timestamp NULL DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidCreditoPedido`),
  KEY `FK_credito_pedido` (`KidPedido`),
  KEY `fk_credito_banco` (`KidBanco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_creditoservicio`
--

CREATE TABLE IF NOT EXISTS `tbl_creditoservicio` (
  `KidCreditoServicio` int(12) NOT NULL,
  `KidPagoServicio` int(12) NOT NULL,
  `KidBanco` int(12) NOT NULL,
  `total` double(12,2) NOT NULL,
  `cuotas` int(2) NOT NULL,
  `fechaIni` timestamp NULL DEFAULT NULL,
  `fechaFin` timestamp NULL DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidCreditoServicio`),
  KEY `FK_credigo_pagoServicio` (`KidPagoServicio`),
  KEY `fk_creditoServicio_banco` (`KidBanco`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_credpeddet`
--

CREATE TABLE IF NOT EXISTS `tbl_credpeddet` (
  `KidCodigoCresDet` int(12) NOT NULL,
  `KidCreditoPedido` int(12) NOT NULL,
  `valor` double(12,2) NOT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidCodigoCresDet`,`KidCreditoPedido`),
  KEY `FK_creditoPedDet_CreditoPedido` (`KidCreditoPedido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_credservdet`
--

CREATE TABLE IF NOT EXISTS `tbl_credservdet` (
  `KidCredServDet` int(12) NOT NULL,
  `KidCreditoServicio` int(12) NOT NULL,
  `valor` double(12,2) NOT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidCredServDet`,`KidCreditoServicio`),
  KEY `fk_credServDet_CreditoServicio` (`KidCreditoServicio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cuentabancaria`
--

CREATE TABLE IF NOT EXISTS `tbl_cuentabancaria` (
  `KidCuentaBancaria` int(11) NOT NULL AUTO_INCREMENT,
  `NumeroCuenta` varchar(20) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `KidBanco` int(11) NOT NULL,
  `KidMoneda` varchar(11) NOT NULL,
  `Firmas_Individuales` varchar(45) DEFAULT NULL,
  `Firmas_Conjuntas` varchar(45) DEFAULT NULL,
  `Saldo` varchar(20) DEFAULT NULL,
  `Cuenta_Primaria` tinyint(4) NOT NULL,
  `estado` tinyint(1) NOT NULL,
  PRIMARY KEY (`KidCuentaBancaria`),
  KEY `FK_Bancos_CuentaBancaria` (`KidBanco`),
  KEY `FK_Moneda_CuentaBancaria` (`KidMoneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_cuentas`
--

CREATE TABLE IF NOT EXISTS `tbl_cuentas` (
  `KidCuenta` varchar(10) NOT NULL,
  `KidTipoCuenta` varchar(10) NOT NULL,
  `nombre` varchar(25) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidCuenta`,`KidTipoCuenta`),
  KEY `fk_tbl_cuentas_contables_tbl_tipoCuentaContable1` (`KidTipoCuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_departamentos`
--

CREATE TABLE IF NOT EXISTS `tbl_departamentos` (
  `KidDepartamento` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `numdepartamento` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `KidArea` int(11) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`KidDepartamento`),
  KEY `fk_Tbl_departamentos_Tbl_areas1_idx` (`KidArea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_descuentos`
--

CREATE TABLE IF NOT EXISTS `tbl_descuentos` (
  `KidDescuentos` int(11) NOT NULL,
  `KidProducto` int(11) DEFAULT NULL,
  `nombre_descuentos` varchar(45) DEFAULT NULL,
  `porcentaje_descuentos` double DEFAULT NULL,
  `fecha_inicio_descuentos` date DEFAULT NULL,
  `fecha_final_descuentos` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidDescuentos`),
  KEY `fk_Producto_Descuentos` (`KidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_descuentos`
--

INSERT INTO `tbl_descuentos` (`KidDescuentos`, `KidProducto`, `nombre_descuentos`, `porcentaje_descuentos`, `fecha_inicio_descuentos`, `fecha_final_descuentos`, `estado`) VALUES
(1, 1, 'Mitad de Precio', 0.5, '2019-11-06', '2019-11-06', 1),
(2, 3, 'Ventas', 0.2, '2019-11-06', '2019-11-06', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_desempeñoempleado`
--

CREATE TABLE IF NOT EXISTS `tbl_desempeñoempleado` (
  `KidDesempeño` int(11) NOT NULL,
  `KidEmpleado` int(11) NOT NULL,
  `KidPruebas` int(11) NOT NULL,
  `Resultado` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidDesempeño`,`KidEmpleado`,`KidPruebas`),
  KEY `FK_Empleado_DesempeñoEmpleado` (`KidEmpleado`),
  KEY `FK_Pruebas_DesempeñoEmpleado` (`KidPruebas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detallecomprobante`
--

CREATE TABLE IF NOT EXISTS `tbl_detallecomprobante` (
  `KidDetalleComprobante` int(11) NOT NULL,
  `articulo_servicio` varchar(45) DEFAULT NULL,
  `Precio` double DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `Descuento` double DEFAULT NULL,
  `Ivaincluido` tinyint(1) DEFAULT NULL,
  `Concepto` varchar(45) DEFAULT NULL,
  `Total` double DEFAULT NULL,
  PRIMARY KEY (`KidDetalleComprobante`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detallepedido`
--

CREATE TABLE IF NOT EXISTS `tbl_detallepedido` (
  `KidDetallePedido` int(11) NOT NULL,
  `KidProducto` int(11) DEFAULT NULL,
  `cantidad_Detallepedido` int(11) DEFAULT NULL,
  `monto_Detallepedido` double DEFAULT NULL,
  PRIMARY KEY (`KidDetallePedido`),
  KEY `FK_Productos_DetallePedido1` (`KidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detallereportevacante`
--

CREATE TABLE IF NOT EXISTS `tbl_detallereportevacante` (
  `KidReporteVacante` int(11) NOT NULL DEFAULT '0',
  `razon` varchar(200) DEFAULT NULL,
  `DescripcionCualidades` varchar(200) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidReporteVacante`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_control`
--

CREATE TABLE IF NOT EXISTS `tbl_detalle_control` (
  `KidNumeroDetalle` int(11) NOT NULL,
  `KidControl` int(11) NOT NULL,
  `KidPlatillo` int(11) NOT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidNumeroDetalle`),
  KEY `fk_Tbl_Detalle_Control_Tbl_Control_Mesas1` (`KidControl`),
  KEY `fk_Tbl_Detalle_Control_Tbl_Platillos1` (`KidPlatillo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_evento`
--

CREATE TABLE IF NOT EXISTS `tbl_detalle_evento` (
  `KidNumeroDetalle` int(11) NOT NULL,
  `KidNumeroSalon` int(11) NOT NULL,
  `KidEvento` int(11) DEFAULT NULL,
  `llegada` date DEFAULT NULL,
  `salida` date DEFAULT NULL,
  `requisitos` varchar(45) DEFAULT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidNumeroDetalle`),
  KEY `reservacion0` (`KidEvento`),
  KEY `fk_Tbl_Detalle_Evento_Tbl_Salones1` (`KidNumeroSalon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_folio`
--

CREATE TABLE IF NOT EXISTS `tbl_detalle_folio` (
  `KidFolio` int(11) NOT NULL,
  `KidNumeroDetalle` int(11) NOT NULL,
  `KidComanda` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `monto` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidFolio`,`KidNumeroDetalle`),
  KEY `servicio` (`KidComanda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_lista_precios`
--

CREATE TABLE IF NOT EXISTS `tbl_detalle_lista_precios` (
  `KidEncabezadoListaPrecios` int(11) NOT NULL DEFAULT '0',
  `KidDetalleListaPrecios` int(11) NOT NULL DEFAULT '0',
  `KidProducto` int(11) DEFAULT NULL,
  `Kidtipo_lista_precios` int(11) DEFAULT NULL,
  `nombre_listaprecios` varchar(50) DEFAULT NULL,
  `precio_listaprecios` double DEFAULT NULL,
  PRIMARY KEY (`KidEncabezadoListaPrecios`,`KidDetalleListaPrecios`),
  KEY `FK_Productos_DetallePedido` (`KidProducto`),
  KEY `FK_TipoListaPrecios_DetalleListaPrecios` (`Kidtipo_lista_precios`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_producto`
--

CREATE TABLE IF NOT EXISTS `tbl_detalle_producto` (
  `Kiddetalleproducto` int(11) NOT NULL,
  `Kidproducto` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `presentacion` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Kiddetalleproducto`),
  KEY `fk_DetalleProducto_Producto` (`Kidproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_reservacion`
--

CREATE TABLE IF NOT EXISTS `tbl_detalle_reservacion` (
  `KidNumeroDetalle` int(11) NOT NULL,
  `KidReservacion` int(11) DEFAULT NULL,
  `KidNumeroHabitacion` int(11) DEFAULT NULL,
  `llegada` date DEFAULT NULL,
  `salida` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidNumeroDetalle`),
  KEY `reservacion` (`KidReservacion`),
  KEY `habitacion` (`KidNumeroHabitacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_detalle_roles`
--

CREATE TABLE IF NOT EXISTS `tbl_detalle_roles` (
  `KidRolpago` int(11) NOT NULL,
  `KidEmpleado` int(11) NOT NULL,
  `remuneracion` float DEFAULT NULL,
  `horasExtras` int(11) DEFAULT NULL,
  `aporteigss` int(11) DEFAULT NULL,
  `gastos` float DEFAULT NULL,
  `vacaciones` int(11) DEFAULT NULL,
  `sueldototal` float DEFAULT NULL,
  `prestamos` float DEFAULT NULL,
  PRIMARY KEY (`KidRolpago`,`KidEmpleado`),
  KEY `fk_Tbl_detalle_roles_Tbl_empleado1_idx` (`KidEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_devoluciones`
--

CREATE TABLE IF NOT EXISTS `tbl_devoluciones` (
  `kidDevoluciones` int(11) NOT NULL,
  `motivo_devoluciones` varchar(45) DEFAULT NULL,
  `fecha_devoluciones` date DEFAULT NULL,
  `KidFacturaEncabezado` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`kidDevoluciones`),
  KEY `fk_Devoluciones_FacturaEncabezado1` (`KidFacturaEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_devoluciones_platillos`
--

CREATE TABLE IF NOT EXISTS `tbl_devoluciones_platillos` (
  `KidDevPlatillo` int(11) NOT NULL,
  `KidPlatillo` int(11) NOT NULL,
  `motivo` varchar(45) DEFAULT NULL,
  `resolucion` varchar(45) DEFAULT NULL,
  `costo` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidDevPlatillo`,`KidPlatillo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_divisa`
--

CREATE TABLE IF NOT EXISTS `tbl_divisa` (
  `KidDivisa` varchar(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidDivisa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_empleado`
--

CREATE TABLE IF NOT EXISTS `tbl_empleado` (
  `KidEmpleado` int(11) NOT NULL,
  `nombres` varchar(45) DEFAULT NULL,
  `apellidos` varchar(45) DEFAULT NULL,
  `dpi` varchar(35) DEFAULT NULL,
  `nit` varchar(25) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `telefonoalternativo` varchar(45) DEFAULT NULL,
  `correo` varchar(45) DEFAULT NULL,
  `correoalternativo` varchar(45) DEFAULT NULL,
  `fechanacimiento` date DEFAULT NULL,
  `estadoCivil` varchar(45) DEFAULT NULL,
  `KidPuesto` int(11) DEFAULT NULL,
  `KidDepartamento` int(11) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`KidEmpleado`),
  KEY `fk_Tbl_empleado_Tbl_puestos1_idx` (`KidPuesto`),
  KEY `fk_Tbl_empleado_Tbl_departamentos1_idx` (`KidDepartamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_encabezadocomprobante`
--

CREATE TABLE IF NOT EXISTS `tbl_encabezadocomprobante` (
  `KidEncabezadoComprobante` int(11) NOT NULL,
  `KidFacturaEncabezado` int(11) DEFAULT NULL,
  `KidCliente` int(11) NOT NULL,
  `KidEmpleado` int(11) NOT NULL,
  `KidtiposComprobantes` int(11) NOT NULL,
  `Serie` varchar(45) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `Moneda` varchar(45) DEFAULT NULL,
  `Cotizacion` double DEFAULT NULL,
  `Centro` varchar(45) DEFAULT NULL,
  `fechaVencimiento` date DEFAULT NULL,
  `Periodo` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidEncabezadoComprobante`),
  KEY `FK_cliente_encabezadoComprobante` (`KidCliente`),
  KEY `FK_empleado_encabezadoComprobante` (`KidEmpleado`),
  KEY `FK_tipoComprobante_encabezadoComprobante` (`KidtiposComprobantes`),
  KEY `FK_FacturaEncabezado_EncabezadoComprobante` (`KidFacturaEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_encabezadopedido`
--

CREATE TABLE IF NOT EXISTS `tbl_encabezadopedido` (
  `KidEncabezadoPedido` int(11) NOT NULL,
  `KidFacturaEncabezado` int(11) DEFAULT NULL,
  `KidCliente` int(11) DEFAULT NULL,
  `fecha_encabezadopedido` date DEFAULT NULL,
  `vencimiento_encabezadopedido` date DEFAULT NULL,
  PRIMARY KEY (`KidEncabezadoPedido`),
  KEY `FK_FacturaEncabezado_EncabezadoPedido` (`KidFacturaEncabezado`),
  KEY `FK_clientes_EncabezadoPedido` (`KidCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_encabezadoreportevacante`
--

CREATE TABLE IF NOT EXISTS `tbl_encabezadoreportevacante` (
  `KidReporteVacante` int(11) NOT NULL DEFAULT '0',
  `KidEmpleado` int(11) DEFAULT NULL,
  `KidPuesto` int(11) DEFAULT NULL,
  `fechaCreacion` date DEFAULT NULL,
  `tipoDeContratacion` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidReporteVacante`),
  KEY `FK_Empleado_ReporteVacante` (`KidEmpleado`),
  KEY `FK_Puesto_ReporteVacante` (`KidPuesto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_encabezado_lista_precios`
--

CREATE TABLE IF NOT EXISTS `tbl_encabezado_lista_precios` (
  `KidEncabezadoListaPrecios` int(11) NOT NULL DEFAULT '0',
  `Fecha_inicio_listaprecios` date DEFAULT NULL,
  `fecha_modificacion_listaprecios` date DEFAULT NULL,
  PRIMARY KEY (`KidEncabezadoListaPrecios`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_estado_perdidas_ganacias_detalle`
--

CREATE TABLE IF NOT EXISTS `tbl_estado_perdidas_ganacias_detalle` (
  `KidPerdidasGanancias` int(11) NOT NULL,
  `KidCuenta` varchar(10) NOT NULL,
  `debe` float DEFAULT NULL,
  `haber` float DEFAULT NULL,
  PRIMARY KEY (`KidPerdidasGanancias`),
  KEY `fk_tbl_estado_perdidas_ganacias_Detalle_tbl_cuentas_contables1` (`KidCuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_estado_perdidas_ganancias_encabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_estado_perdidas_ganancias_encabezado` (
  `KidPerdidasGanancias` int(11) NOT NULL AUTO_INCREMENT,
  `gananciaEnOperacion` float DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidPerdidasGanancias`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_eventos`
--

CREATE TABLE IF NOT EXISTS `tbl_eventos` (
  `KidEvento` int(11) NOT NULL,
  `KidCliente` int(11) NOT NULL,
  `_KidEmpleado` int(11) NOT NULL,
  `fechaEvento` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidEvento`),
  KEY `fk_Tbl_Eventos_Tbl_Clientes1` (`KidCliente`),
  KEY `fk_Tbl_Eventos_Tbl_Empleados1` (`_KidEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_existencia`
--

CREATE TABLE IF NOT EXISTS `tbl_existencia` (
  `Kidexistencia` int(11) NOT NULL,
  `kidproducto` int(11) NOT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Kidexistencia`,`kidproducto`),
  KEY `fk_Producto_Existencia` (`kidproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_existencias`
--

CREATE TABLE IF NOT EXISTS `tbl_existencias` (
  `KidExistencia` int(11) NOT NULL,
  `KidProducto` int(11) DEFAULT NULL,
  `KidBodega` int(11) DEFAULT NULL,
  `existencia` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidExistencia`),
  KEY `prod` (`KidProducto`),
  KEY `bode` (`KidBodega`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_facturadetalle`
--

CREATE TABLE IF NOT EXISTS `tbl_facturadetalle` (
  `KidFacturaDetalle` int(11) NOT NULL,
  `cantidad_facturadetalle` int(11) DEFAULT NULL,
  `monto_facturadetalle` double DEFAULT NULL,
  `KidProducto` int(11) NOT NULL,
  `KidFacturaEncabezado` int(11) NOT NULL,
  PRIMARY KEY (`KidFacturaDetalle`),
  KEY `fk_FacturaDetalle_Producto1` (`KidProducto`),
  KEY `fk_FacturaDetalle_FacturaEncabezado1` (`KidFacturaEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_facturaencabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_facturaencabezado` (
  `KidFacturaEncabezado` int(11) NOT NULL,
  `KidEncabezadoListaPrecios` int(11) NOT NULL,
  `KidCotizacionEncabezado` int(11) DEFAULT NULL,
  `fecha_facturaencabezado` date DEFAULT NULL,
  `descripcion_facturaencabezado` varchar(45) DEFAULT NULL,
  `KidSerie` int(11) NOT NULL,
  `KidCliente` int(11) NOT NULL,
  `KidImpuesto` int(11) NOT NULL,
  `KidMoneda` int(11) NOT NULL,
  `KidDescuentos` int(11) NOT NULL,
  `impuesto_facturaencabezado` double DEFAULT NULL,
  `monto_facturaencabezado` double DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidFacturaEncabezado`,`KidSerie`),
  KEY `fk_FacturaEncabezado_Cliente1` (`KidCliente`),
  KEY `fk_FacturaEncabezado_Serie1` (`KidSerie`),
  KEY `fk_Tbl_FacturaEncabezado_Tbl_Impuesto1` (`KidImpuesto`),
  KEY `fk_Tbl_FacturaEncabezado_Tbl_Moneda1` (`KidMoneda`),
  KEY `fk_Descuentos_facturaEncabezado` (`KidDescuentos`),
  KEY `FK_EncabezadoLista_Precios_FacturaEncabezado` (`KidEncabezadoListaPrecios`),
  KEY `FK_cotizacionEncabezado_FacturaEncabezado` (`KidCotizacionEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_flujoefectivo_detalle`
--

CREATE TABLE IF NOT EXISTS `tbl_flujoefectivo_detalle` (
  `KidFlujoEfectivo` int(11) NOT NULL,
  `KidCuenta` varchar(10) NOT NULL,
  `valor` float DEFAULT NULL,
  PRIMARY KEY (`KidFlujoEfectivo`,`KidCuenta`),
  KEY `fk_tbl_flujoEfectivo_Detalle_tbl_cuentas1` (`KidCuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_flujoefectivo_encabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_flujoefectivo_encabezado` (
  `KidFlujoEfectivo` int(11) NOT NULL AUTO_INCREMENT,
  `total_efectivo` float DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidFlujoEfectivo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_folios`
--

CREATE TABLE IF NOT EXISTS `tbl_folios` (
  `KidFolio` int(11) NOT NULL,
  `fechaApertura` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidFolio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_folios`
--

INSERT INTO `tbl_folios` (`KidFolio`, `fechaApertura`, `estado`) VALUES
(1, '2019-11-06', 1),
(2, '2019-11-21', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_gestionmovimientocliente`
--

CREATE TABLE IF NOT EXISTS `tbl_gestionmovimientocliente` (
  `KidGestionMovimientoCliente` int(11) NOT NULL,
  `KidEncabezadoComprobante` int(11) NOT NULL,
  `SaldoCliente` double DEFAULT NULL,
  `Debe` double DEFAULT NULL,
  `Haber` double DEFAULT NULL,
  `SaldoComprobante` double DEFAULT NULL,
  PRIMARY KEY (`KidGestionMovimientoCliente`),
  KEY `FK_encabezadoComprobante_GestionMovimientoCliente` (`KidEncabezadoComprobante`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_habitaciones`
--

CREATE TABLE IF NOT EXISTS `tbl_habitaciones` (
  `KidNumeroHabitacion` int(11) NOT NULL,
  `KidTipoHabitacion` varchar(45) DEFAULT NULL,
  `KidCategoria` varchar(45) DEFAULT NULL,
  `precio` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidNumeroHabitacion`),
  KEY `tipoHabitacion` (`KidTipoHabitacion`),
  KEY `categoria` (`KidCategoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_historia_inventario`
--

CREATE TABLE IF NOT EXISTS `tbl_historia_inventario` (
  `Kidproducto` int(11) NOT NULL,
  `Kidmovimientoinventario` int(11) NOT NULL,
  `Kidbodega` int(11) NOT NULL,
  `Kidsucursal` int(11) NOT NULL,
  `fecha` datetime DEFAULT NULL,
  `cantidad` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Kidproducto`,`Kidmovimientoinventario`),
  KEY `fk_MovimientoInventario_HistoriaInventario` (`Kidmovimientoinventario`),
  KEY `FK_Bodega_HistoriaInventario` (`Kidbodega`),
  KEY `fk_Sucursal_HistoriaInventario` (`Kidsucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_impuesto`
--

CREATE TABLE IF NOT EXISTS `tbl_impuesto` (
  `KidImpuesto` int(11) NOT NULL,
  `nombre_impuesto` varchar(45) DEFAULT NULL,
  `descripcion_impuesto` varchar(150) DEFAULT NULL,
  `porcentaje_impuesto` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidImpuesto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_impuesto`
--

INSERT INTO `tbl_impuesto` (`KidImpuesto`, `nombre_impuesto`, `descripcion_impuesto`, `porcentaje_impuesto`, `estado`) VALUES
(1, 'ISR', 'impuesto sobre la venta', 0.5, 1),
(2, 'IVA', 'impuesto valor agregado', 0.12, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ingredientes`
--

CREATE TABLE IF NOT EXISTS `tbl_ingredientes` (
  `KidIngredientes` int(11) NOT NULL,
  `KidProducto` int(11) NOT NULL,
  `KidRecetas` int(11) NOT NULL,
  PRIMARY KEY (`KidIngredientes`,`KidRecetas`,`KidProducto`),
  KEY `fk_Tbl_Ingredientes_Tbl_Producto1` (`KidProducto`),
  KEY `fk_Tbl_Ingredientes_Tbl_Recetas1` (`KidRecetas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_inventario`
--

CREATE TABLE IF NOT EXISTS `tbl_inventario` (
  `KidInventario` int(11) NOT NULL,
  `KidProducto` int(11) NOT NULL,
  `Kidbodega` int(11) NOT NULL,
  `Kidstock` int(11) NOT NULL,
  `Kidexistencia` int(11) NOT NULL,
  `fecha_inventario` date DEFAULT NULL,
  `cantidad_inventario` int(11) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidInventario`),
  KEY `fk_Inventario_Producto1` (`KidProducto`),
  KEY `fk_Inventario_Bodegas` (`Kidbodega`),
  KEY `Fk_Inventario_Stock` (`Kidstock`),
  KEY `fk_Inventario_Existencia` (`Kidexistencia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_librodiario`
--

CREATE TABLE IF NOT EXISTS `tbl_librodiario` (
  `KidLibroDiario` int(11) NOT NULL AUTO_INCREMENT,
  `KidPoliza` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `total_debe` float DEFAULT NULL,
  `total_haber` float DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidLibroDiario`,`KidPoliza`),
  KEY `fk_polizaEncabezado_libroDiario` (`KidPoliza`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_libromayor_detalle`
--

CREATE TABLE IF NOT EXISTS `tbl_libromayor_detalle` (
  `KidLibroMayor` int(11) NOT NULL,
  `debe` float DEFAULT NULL,
  `haber` float DEFAULT NULL,
  `saldo_parcial` float DEFAULT NULL,
  PRIMARY KEY (`KidLibroMayor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_libromayor_encabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_libromayor_encabezado` (
  `KidLibroMayor` int(11) NOT NULL AUTO_INCREMENT,
  `KidLibroDiarioEncabezado` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `saldo_final` float DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidLibroMayor`,`KidLibroDiarioEncabezado`),
  KEY `fk_tbl_libroMayor_tbl_libroDiario_Encabezado1` (`KidLibroDiarioEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_libro_bancos`
--

CREATE TABLE IF NOT EXISTS `tbl_libro_bancos` (
  `KidMovimientoBancario` int(11) NOT NULL AUTO_INCREMENT,
  `cuenta_debito` int(11) NOT NULL,
  `cuenta_credito` int(11) NOT NULL,
  `monto` double NOT NULL,
  `tipo_movimiento` varchar(45) DEFAULT NULL,
  `fecha_movimiento` date DEFAULT NULL,
  `beneficiario` varchar(45) DEFAULT NULL,
  `descripcion` varchar(400) DEFAULT NULL,
  `movimiento_conciliado` tinyint(4) DEFAULT NULL,
  `movimiento_trasladado_contabilidad` tinyint(4) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidMovimientoBancario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_marca`
--

CREATE TABLE IF NOT EXISTS `tbl_marca` (
  `Kidmarca` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `paisOrigen` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Kidmarca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_menus`
--

CREATE TABLE IF NOT EXISTS `tbl_menus` (
  `KidMenu` int(11) NOT NULL,
  `nombreMenu` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidMenu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_mesas`
--

CREATE TABLE IF NOT EXISTS `tbl_mesas` (
  `KidNumeroMesa` int(11) NOT NULL,
  `KidArea` int(11) NOT NULL,
  `capacidad` int(11) DEFAULT NULL,
  `estadoMesa` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidNumeroMesa`),
  KEY `fk_Tbl_Mesas_Tbl_Areas1` (`KidArea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_modulo`
--

CREATE TABLE IF NOT EXISTS `tbl_modulo` (
  `PK_id_Modulo` int(11) NOT NULL,
  `nombre_modulo` varchar(45) DEFAULT NULL,
  `descripcion_modulo` varchar(200) DEFAULT NULL,
  `estado_modulo` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_Modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_moneda`
--

CREATE TABLE IF NOT EXISTS `tbl_moneda` (
  `KidMoneda` int(11) NOT NULL,
  `nombre_moneda` varchar(45) DEFAULT NULL,
  `tasa_moneda` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidMoneda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_moviemiento_inventario`
--

CREATE TABLE IF NOT EXISTS `tbl_moviemiento_inventario` (
  `Kidmoviemientoinventario` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `naturaleza` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Kidmoviemientoinventario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_nominasdetalle`
--

CREATE TABLE IF NOT EXISTS `tbl_nominasdetalle` (
  `KidLinea` int(11) NOT NULL,
  `KidNomina` int(11) NOT NULL,
  `KidConcepto` int(11) DEFAULT NULL,
  PRIMARY KEY (`KidLinea`,`KidNomina`),
  KEY `fk_Tbl_nominasDetalle_Tbl_nominasEncabezado1_idx` (`KidNomina`),
  KEY `fk_Tbl_nominasDetalle_Tbl_conceptos1_idx` (`KidConcepto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_nominasencabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_nominasencabezado` (
  `KidNomina` int(11) NOT NULL,
  `KidEmpleado` int(11) NOT NULL,
  `dias` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `sueldoliquido` float DEFAULT NULL,
  `perdidaoganancia` tinyint(1) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`KidNomina`,`KidEmpleado`),
  KEY `fk_Tbl_nominasEncabezado_Tbl_empleado1_idx` (`KidEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_objetos_perdidos`
--

CREATE TABLE IF NOT EXISTS `tbl_objetos_perdidos` (
  `KidObjeto` int(11) NOT NULL,
  `KidNumeroHabitacion` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidObjeto`),
  KEY `fk_Tbl_Objetos_Perdidos_Tbl_Habitaciones1` (`KidNumeroHabitacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_orden_compra_encabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_orden_compra_encabezado` (
  `KidOrdenCompraEncabezado` int(16) NOT NULL,
  `KidProveedor` int(16) NOT NULL,
  `KidImpuesto` int(12) DEFAULT NULL,
  `fechaEmisionOrdenCompraEncabezado` date NOT NULL,
  `fechaRevisionOrdenCompraEncabezado` date NOT NULL,
  `nombreOrdenCompraEncabezado` varchar(30) DEFAULT NULL,
  `descripcionOrdenCompraEncabezado` varchar(100) DEFAULT NULL,
  `fechaEstimadaEntregaOrdenCompraEncabezado` datetime DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidOrdenCompraEncabezado`),
  KEY `fk_OrdenEncabezado_proveedor` (`KidProveedor`),
  KEY `Fk_ordenencabezado_impuesto` (`KidImpuesto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_orden_dompra_detalle`
--

CREATE TABLE IF NOT EXISTS `tbl_orden_dompra_detalle` (
  `KidOrdenCompraDetalle` int(16) NOT NULL,
  `KidOrdenCompraEncabezado` int(16) NOT NULL,
  `KidProducto` int(16) NOT NULL,
  `precioUnitario` float(4,2) DEFAULT NULL,
  `cantidadProducto` int(3) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidOrdenCompraDetalle`,`KidOrdenCompraEncabezado`,`KidProducto`),
  KEY `fk_OrdenEncabezado_detalle` (`KidOrdenCompraEncabezado`),
  KEY `fk_ordendetalle_producto` (`KidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pagos`
--

CREATE TABLE IF NOT EXISTS `tbl_pagos` (
  `KidPagos` int(11) NOT NULL,
  `fecha_pagos` date DEFAULT NULL,
  `descripcion_pagos` varchar(45) DEFAULT NULL,
  `monto_pagos` double DEFAULT NULL,
  `KidTipoPago` int(11) NOT NULL,
  `KidFacturaEncabezado` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidPagos`,`KidTipoPago`),
  KEY `fk_Pagos_TipoPago1` (`KidTipoPago`),
  KEY `fk_Pagos_FacturaEncabezado1` (`KidFacturaEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pagoservicio`
--

CREATE TABLE IF NOT EXISTS `tbl_pagoservicio` (
  `KidPagoServicio` int(12) NOT NULL,
  `KidAcreedor` int(12) NOT NULL,
  `KidServicio` int(12) NOT NULL,
  `fecha` datetime NOT NULL,
  `monto` decimal(10,2) NOT NULL,
  `impuesto` int(12) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidPagoServicio`),
  KEY `FK_pago_acreedor` (`KidAcreedor`),
  KEY `FK_pago_servicio` (`KidServicio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pedido`
--

CREATE TABLE IF NOT EXISTS `tbl_pedido` (
  `KidPedido` int(12) NOT NULL,
  `KidProveedor` int(12) NOT NULL,
  `KidOrdenCompra` int(12) NOT NULL,
  `total` double(12,2) NOT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidPedido`),
  KEY `FK_proveedor_pedido` (`KidProveedor`),
  KEY `fk_OrdenEncabezado_pedido` (`KidOrdenCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pedidodet`
--

CREATE TABLE IF NOT EXISTS `tbl_pedidodet` (
  `KidPedido` int(12) NOT NULL,
  `KidProducto` int(12) NOT NULL,
  `cantidad` int(3) NOT NULL,
  `valor` double(12,2) NOT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidPedido`,`KidProducto`),
  KEY `fk_PedidoDet_producto` (`KidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_detalle`
--

CREATE TABLE IF NOT EXISTS `tbl_perfil_detalle` (
  `PK_id_perfil` int(11) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_perfil`,`PK_id_aplicacion`),
  KEY `fk_Perfil_detalle_Aplicacion1` (`PK_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_perfil_encabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_perfil_encabezado` (
  `PK_id_perfil` int(11) NOT NULL,
  `nombre_perfil` varchar(45) DEFAULT NULL,
  `descripcion_perfil` varchar(200) DEFAULT NULL,
  `estado_perfil` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_plandecarrera`
--

CREATE TABLE IF NOT EXISTS `tbl_plandecarrera` (
  `KidPlanCarrera` int(11) NOT NULL,
  `KidDesempeño` int(11) NOT NULL,
  `Fecha` date DEFAULT NULL,
  `Descripcion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`KidPlanCarrera`,`KidDesempeño`),
  KEY `FK_DesempeñoEmpleado_PlanDeCarrera` (`KidDesempeño`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_planillasdetalle`
--

CREATE TABLE IF NOT EXISTS `tbl_planillasdetalle` (
  `KidPlanilla` int(11) NOT NULL,
  `Ktipo` int(11) NOT NULL,
  `documento` varchar(45) DEFAULT NULL,
  `KidEmpleado` int(11) DEFAULT NULL,
  `ingresos` float DEFAULT NULL,
  `descuentos` float DEFAULT NULL,
  `importeneto` float DEFAULT NULL,
  `estadoenvio` float DEFAULT NULL,
  `estadoregistro` float DEFAULT NULL,
  PRIMARY KEY (`KidPlanilla`,`Ktipo`),
  KEY `fk_Tbl_PlanillasDetalle_Tbl_empleado1_idx` (`KidEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_planillasencabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_planillasencabezado` (
  `KidPlanilla` int(11) NOT NULL,
  `tipo` varchar(25) DEFAULT NULL,
  `clase` varchar(25) DEFAULT NULL,
  `fechaemision` date DEFAULT NULL,
  `correlativo` int(11) DEFAULT NULL,
  `total` float DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`KidPlanilla`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_platillos`
--

CREATE TABLE IF NOT EXISTS `tbl_platillos` (
  `KidPlatillo` int(11) NOT NULL,
  `KidMenu` int(11) NOT NULL,
  `nombrePlatillo` varchar(45) DEFAULT NULL,
  `precio` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidPlatillo`,`KidMenu`),
  KEY `menu` (`KidMenu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_poliza`
--

CREATE TABLE IF NOT EXISTS `tbl_poliza` (
  `KidPoliza` int(11) NOT NULL,
  `KidFacturaDetalle` int(11) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `monto` double DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidPoliza`),
  KEY `FK_FacturaDetalle_Poliza` (`KidFacturaDetalle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_poliza_detalle`
--

CREATE TABLE IF NOT EXISTS `tbl_poliza_detalle` (
  `KidPoliza` int(11) NOT NULL,
  `KidCuenta` varchar(10) NOT NULL,
  `debe` double DEFAULT NULL,
  `haber` double DEFAULT NULL,
  PRIMARY KEY (`KidPoliza`,`KidCuenta`),
  KEY `fk_Cuentas_PolizaDetalle` (`KidCuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_poliza_encabezado`
--

CREATE TABLE IF NOT EXISTS `tbl_poliza_encabezado` (
  `KidPoliza` int(11) NOT NULL AUTO_INCREMENT,
  `KidTipoDePoliza` varchar(5) NOT NULL,
  `KidDocumentoAsociado` int(11) NOT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `fecha_poliza` date DEFAULT NULL,
  `total_poliza` double DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidPoliza`,`KidTipoDePoliza`,`KidDocumentoAsociado`),
  KEY `fk_tipoDePoliza_PolizaEncabezado` (`KidTipoDePoliza`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_precios`
--

CREATE TABLE IF NOT EXISTS `tbl_precios` (
  `KidPrecios` int(11) NOT NULL,
  `precio_precios` double DEFAULT NULL,
  `descripcion_precios` varchar(45) DEFAULT NULL,
  `KidProducto` int(11) NOT NULL,
  PRIMARY KEY (`KidPrecios`),
  KEY `fk_Precios_Producto1` (`KidProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_presupuesto`
--

CREATE TABLE IF NOT EXISTS `tbl_presupuesto` (
  `Kidpresupuesto` int(11) NOT NULL AUTO_INCREMENT,
  `KidMoneda` int(11) DEFAULT NULL,
  `KidArea` int(11) NOT NULL,
  `KidCuenta` varchar(10) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `descripcion` varchar(300) DEFAULT NULL,
  `monto` double DEFAULT NULL,
  `anotacion` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`Kidpresupuesto`),
  KEY `FK_Moneda_Presupuesto` (`KidMoneda`),
  KEY `FK_area_presupuesto` (`KidArea`),
  KEY `FK_cuentas_presupuesto` (`KidCuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_producto`
--

CREATE TABLE IF NOT EXISTS `tbl_producto` (
  `KidProducto` int(11) NOT NULL,
  `KidTipoProducto` int(11) NOT NULL,
  `nombre_producto` varchar(45) DEFAULT NULL,
  `descripcion_producto` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidProducto`),
  KEY `fk_Producto_TipoProducto1` (`KidTipoProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_producto`
--

INSERT INTO `tbl_producto` (`KidProducto`, `KidTipoProducto`, `nombre_producto`, `descripcion_producto`, `estado`) VALUES
(1, 1, 'Aspirina', '125 mg', 1),
(2, 1, 'Pintura', 'Color Rojo', 1),
(3, 2, 'Café', 'Producto del Hotel', 1),
(4, 2, 'Pasta', 'Producto del Hotel', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_producto_marca`
--

CREATE TABLE IF NOT EXISTS `tbl_producto_marca` (
  `Kidproducto` int(11) NOT NULL,
  `Kidmarca` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`Kidproducto`,`Kidmarca`),
  KEY `fk_Marca_Producto` (`Kidmarca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_propiedad_rpt`
--

CREATE TABLE IF NOT EXISTS `tbl_propiedad_rpt` (
  `PK_id_reporte` int(12) NOT NULL,
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `PK_id_Modulo` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_Modulo`,`PK_id_usuario`,`PK_id_aplicacion`),
  KEY `FK_Tbl_reporte_Tbl_propiedad_Rpt` (`PK_id_reporte`),
  KEY `FK_Tbl_usuario_Tbl_propiedad_Rpt` (`PK_id_usuario`),
  KEY `FK_Tbl_Aplicacio_Tbl_propiedad_Rpt` (`PK_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_proveedor`
--

CREATE TABLE IF NOT EXISTS `tbl_proveedor` (
  `KidProveedor` int(16) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `direccion` varchar(20) DEFAULT NULL,
  `pagina` varchar(20) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pruebas`
--

CREATE TABLE IF NOT EXISTS `tbl_pruebas` (
  `KidPruebas` int(11) NOT NULL DEFAULT '0',
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `TiempoDuracion` varchar(45) DEFAULT NULL,
  `PreRequisitos` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidPruebas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_puestos`
--

CREATE TABLE IF NOT EXISTS `tbl_puestos` (
  `KidPuesto` int(11) NOT NULL,
  `KidArea` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `sueldofijo` varchar(45) DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`KidPuesto`),
  KEY `fk_Area_Puestos` (`KidArea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_quejas`
--

CREATE TABLE IF NOT EXISTS `tbl_quejas` (
  `KidQueja` int(11) NOT NULL,
  `KidCliente` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `queja` text,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidQueja`),
  KEY `fk_Tbl_Quejas_Tbl_Clientes1` (`KidCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_recetas`
--

CREATE TABLE IF NOT EXISTS `tbl_recetas` (
  `KidRecetas` int(11) NOT NULL,
  `receta` varchar(500) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidRecetas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_reporte`
--

CREATE TABLE IF NOT EXISTS `tbl_reporte` (
  `PK_id_reporte` int(12) NOT NULL,
  `PK_id_configuracion` int(12) NOT NULL,
  `nombre` varchar(95) NOT NULL,
  `nombre_archivo` varchar(100) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_reporte`),
  KEY `FK_Tbl_reporte_Tbl_Configuacion` (`PK_id_configuracion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_reservaciones`
--

CREATE TABLE IF NOT EXISTS `tbl_reservaciones` (
  `KidReservacion` int(11) NOT NULL,
  `KidCliente` int(11) NOT NULL,
  `KidEmpleado` int(11) NOT NULL,
  `fechaReservacion` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidReservacion`),
  KEY `fk_Tbl_Reservaciones_Tbl_Clientes1` (`KidCliente`),
  KEY `fk_Tbl_Reservaciones_Tbl_Empleados1` (`KidEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_resultados`
--

CREATE TABLE IF NOT EXISTS `tbl_resultados` (
  `KidResultados` int(11) NOT NULL DEFAULT '0',
  `KidBancoTalento` int(11) DEFAULT NULL,
  `KidPruebas` int(11) DEFAULT NULL,
  `Resultado` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidResultados`),
  KEY `FK_BancoTalento_Resultados` (`KidBancoTalento`),
  KEY `FK_Pruebas_Resultados` (`KidPruebas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_roles_de_pago`
--

CREATE TABLE IF NOT EXISTS `tbl_roles_de_pago` (
  `KidRolpago` int(11) NOT NULL,
  `anio` date DEFAULT NULL,
  `mes` date DEFAULT NULL,
  `quincena` date DEFAULT NULL,
  `fechaelaboracion` date DEFAULT NULL,
  `estado` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`KidRolpago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_rpt_app`
--

CREATE TABLE IF NOT EXISTS `tbl_rpt_app` (
  `PK_id_reporte` int(12) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `PK_id_Modulo` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_reporte`,`PK_id_aplicacion`,`PK_id_Modulo`),
  KEY `FK_Tbl_Aplicacion_Tbl_rpt_app` (`PK_id_aplicacion`),
  KEY `FK_Tbl_Modulo_Tbl_rpt_app` (`PK_id_Modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_rpt_mdl`
--

CREATE TABLE IF NOT EXISTS `tbl_rpt_mdl` (
  `PK_id_reporte` int(12) NOT NULL,
  `PK_id_Modulo` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_reporte`,`PK_id_Modulo`),
  KEY `FK_Tbl_modulo_Tbl_rpt_mdl` (`PK_id_Modulo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_salones`
--

CREATE TABLE IF NOT EXISTS `tbl_salones` (
  `KidNumeroSalon` int(11) NOT NULL,
  `capacidad` int(11) DEFAULT NULL,
  `precio` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidNumeroSalon`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_serie`
--

CREATE TABLE IF NOT EXISTS `tbl_serie` (
  `KidSerie` int(11) NOT NULL,
  `KidFolio` int(11) NOT NULL,
  `serie_serie` varchar(45) DEFAULT NULL,
  `certificado_serie` varchar(45) DEFAULT NULL,
  `regimen_fiscal_serie` varchar(45) DEFAULT NULL,
  `formato_serie` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidSerie`),
  KEY `FK_Folio_Serie` (`KidFolio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_serie`
--

INSERT INTO `tbl_serie` (`KidSerie`, `KidFolio`, `serie_serie`, `certificado_serie`, `regimen_fiscal_serie`, `formato_serie`, `estado`) VALUES
(1, 2, 'A', 'CA', '12', 'A-Z', 1),
(2, 1, 'AZ', '123', 'AD2', 'AZ-ZZ', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_servicio`
--

CREATE TABLE IF NOT EXISTS `tbl_servicio` (
  `KidServicio` int(12) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidServicio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_servicios`
--

CREATE TABLE IF NOT EXISTS `tbl_servicios` (
  `KidServicio` int(11) NOT NULL,
  `KidArea` int(11) NOT NULL,
  `nombreServicio` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidServicio`),
  KEY `fk_Tbl_Servicios_Tbl_Areas1` (`KidArea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_solicitudrembolso`
--

CREATE TABLE IF NOT EXISTS `tbl_solicitudrembolso` (
  `KidSolicitudRembolso` int(11) NOT NULL,
  `fecha_solicitudrembolso` date DEFAULT NULL,
  `motivo_solicitudrembolso` varchar(45) DEFAULT NULL,
  `KidFacturaEncabezado` int(11) NOT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidSolicitudRembolso`),
  KEY `fk_SolicitudRembolso_FacturaEncabezado1` (`KidFacturaEncabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_stock`
--

CREATE TABLE IF NOT EXISTS `tbl_stock` (
  `Kidstock` int(11) NOT NULL,
  `cantidadMaxima` int(11) DEFAULT NULL,
  `cantidadMinima` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Kidstock`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_sucursal`
--

CREATE TABLE IF NOT EXISTS `tbl_sucursal` (
  `KidSucursal` int(16) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`KidSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tiendas`
--

CREATE TABLE IF NOT EXISTS `tbl_tiendas` (
  `KidTienda` int(11) NOT NULL,
  `KidArea` int(11) NOT NULL,
  `descripcion` text,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidTienda`),
  KEY `fk_Tbl_Tiendas_Tbl_Areas1` (`KidArea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tiendas_producto`
--

CREATE TABLE IF NOT EXISTS `tbl_tiendas_producto` (
  `KidProducto` int(11) NOT NULL,
  `KidTienda` int(11) NOT NULL,
  PRIMARY KEY (`KidProducto`,`KidTienda`),
  KEY `fk_Tbl_Producto_has_Tbl_Tiendas_Tbl_Tiendas1` (`KidTienda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipocambio`
--

CREATE TABLE IF NOT EXISTS `tbl_tipocambio` (
  `KidMonedaBase` varchar(11) NOT NULL,
  `KidMonedaConversion` varchar(11) NOT NULL,
  `tipo_cambio` float DEFAULT NULL,
  `fecha_tipo_cambio` date DEFAULT NULL,
  PRIMARY KEY (`KidMonedaBase`,`KidMonedaConversion`),
  KEY `fk_tbl_tipoCambio_tbl_Divisa_idx` (`KidMonedaConversion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipocliente`
--

CREATE TABLE IF NOT EXISTS `tbl_tipocliente` (
  `KidTipoCliente` int(11) NOT NULL,
  `tipo_tipocliente` varchar(45) DEFAULT NULL,
  `descripcion_tipocliente` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidTipoCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_tipocliente`
--

INSERT INTO `tbl_tipocliente` (`KidTipoCliente`, `tipo_tipocliente`, `descripcion_tipocliente`, `estado`) VALUES
(1, 'Persona', '-', 1),
(2, 'Empresa', 'S.A.', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipocuenta`
--

CREATE TABLE IF NOT EXISTS `tbl_tipocuenta` (
  `KidTipoCuenta` varchar(10) NOT NULL,
  `nombre_tipoCuenta` varchar(25) DEFAULT NULL,
  `descripcion_tipoCuenta` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidTipoCuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipofactura`
--

CREATE TABLE IF NOT EXISTS `tbl_tipofactura` (
  `KidTipoFactura` int(11) NOT NULL,
  `tipo_tipofactura` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidTipoFactura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_tipofactura`
--

INSERT INTO `tbl_tipofactura` (`KidTipoFactura`, `tipo_tipofactura`, `estado`) VALUES
(1, 'Comprobante', 1),
(2, 'Recibo', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipopago`
--

CREATE TABLE IF NOT EXISTS `tbl_tipopago` (
  `KidTipoPago` int(11) NOT NULL,
  `tipo_tipopago` varchar(45) DEFAULT NULL,
  `descripcion_tipopago` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidTipoPago`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_tipopago`
--

INSERT INTO `tbl_tipopago` (`KidTipoPago`, `tipo_tipopago`, `descripcion_tipopago`, `estado`) VALUES
(1, 'Efectivo', '-', 1),
(2, 'Cheque', 'cualquier banco', 1),
(3, 'Tarjeta Debito', 'Cualquier banco', 1),
(4, 'Tarjeta Credito', 'cualquier banco', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipoproducto`
--

CREATE TABLE IF NOT EXISTS `tbl_tipoproducto` (
  `KidTipoProducto` int(11) NOT NULL,
  `tipo_tipoproducto` varchar(45) DEFAULT NULL,
  `descripcion_tipoproducto` varchar(45) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidTipoProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_tipoproducto`
--

INSERT INTO `tbl_tipoproducto` (`KidTipoProducto`, `tipo_tipoproducto`, `descripcion_tipoproducto`, `estado`) VALUES
(1, 'Consumo', 'Propio para el Hotel', 1),
(2, 'Negocio', 'Para ventas del Hotel', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tiposcomprobantes`
--

CREATE TABLE IF NOT EXISTS `tbl_tiposcomprobantes` (
  `KidtiposComprobantes` int(11) NOT NULL,
  `NombreComprobante` varchar(45) DEFAULT NULL,
  `detalle` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidtiposComprobantes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_tiposcomprobantes`
--

INSERT INTO `tbl_tiposcomprobantes` (`KidtiposComprobantes`, `NombreComprobante`, `detalle`, `estado`) VALUES
(1, 'Cuentas por Cobrar', '-', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipo_habitacion`
--

CREATE TABLE IF NOT EXISTS `tbl_tipo_habitacion` (
  `KidTipoHabitacion` varchar(45) NOT NULL,
  `numeroCamas` int(11) DEFAULT NULL,
  `numeroAmbientes` int(11) DEFAULT NULL,
  `numeroPersonas` varchar(45) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`KidTipoHabitacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Disparadores `tbl_tipo_habitacion`
--
DROP TRIGGER IF EXISTS `EstadoHabitaciones`;
DELIMITER //
CREATE TRIGGER `EstadoHabitaciones` AFTER UPDATE ON `tbl_tipo_habitacion`
 FOR EACH ROW BEGIN
UPDATE tbl_habitaciones set estado = new.estado WHERE tbl_habitaciones.KidTipoHabitacion=new.KidTipoHabitacion;
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipo_lista_precios`
--

CREATE TABLE IF NOT EXISTS `tbl_tipo_lista_precios` (
  `Kidtipo_lista_precios` int(11) NOT NULL,
  `nombre_lista_precios_detalle` varchar(45) DEFAULT NULL,
  `descuento_lista_precios` double DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Kidtipo_lista_precios`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_tipo_lista_precios`
--

INSERT INTO `tbl_tipo_lista_precios` (`Kidtipo_lista_precios`, `nombre_lista_precios_detalle`, `descuento_lista_precios`, `estado`) VALUES
(1, 'Cliente VIP', 0.2, 1),
(2, 'Mayorista', 0.5, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_tipo_poliza`
--

CREATE TABLE IF NOT EXISTS `tbl_tipo_poliza` (
  `KidTipoDePoliza` varchar(5) NOT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `estado` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`KidTipoDePoliza`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ubicacion`
--

CREATE TABLE IF NOT EXISTS `tbl_ubicacion` (
  `Kidubicacion` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `capacidad` int(10) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Kidubicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_ubicacionprodcuto`
--

CREATE TABLE IF NOT EXISTS `tbl_ubicacionprodcuto` (
  `Kidubicacion` int(11) NOT NULL,
  `Kidproducto` int(11) NOT NULL,
  PRIMARY KEY (`Kidubicacion`,`Kidproducto`),
  KEY `fk_Producto_Ubicacion` (`Kidproducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario`
--

CREATE TABLE IF NOT EXISTS `tbl_usuario` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `nombre_usuario` varchar(45) DEFAULT NULL,
  `apellido_usuarios` varchar(45) DEFAULT NULL,
  `password_usuario` varchar(45) DEFAULT NULL,
  `cambio_contrasena` tinyint(4) DEFAULT NULL,
  `estado_usuario` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tbl_usuario`
--

INSERT INTO `tbl_usuario` (`PK_id_usuario`, `nombre_usuario`, `apellido_usuarios`, `password_usuario`, `cambio_contrasena`, `estado_usuario`) VALUES
('MiUsuario', 'Usuario', 'Prueba', 'e19d5cd5af0378da05f63f891c7467af', 0, 1);

--
-- Disparadores `tbl_usuario`
--
DROP TRIGGER IF EXISTS `actualizarClave`;
DELIMITER //
CREATE TRIGGER `actualizarClave` BEFORE UPDATE ON `tbl_usuario`
 FOR EACH ROW IF NEW.password_usuario <> OLD.password_usuario THEN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END IF
//
DELIMITER ;
DROP TRIGGER IF EXISTS `encriptarClave`;
DELIMITER //
CREATE TRIGGER `encriptarClave` BEFORE INSERT ON `tbl_usuario`
 FOR EACH ROW BEGIN
SET NEW.password_usuario = MD5(NEW.password_usuario);
END
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_aplicacion`
--

CREATE TABLE IF NOT EXISTS `tbl_usuario_aplicacion` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_aplicacion` int(11) NOT NULL,
  `ingresar` tinyint(4) DEFAULT NULL,
  `consultar` tinyint(4) DEFAULT NULL,
  `modificar` tinyint(4) DEFAULT NULL,
  `eliminar` tinyint(4) DEFAULT NULL,
  `imprimir` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`PK_id_usuario`,`PK_id_aplicacion`),
  KEY `fk_tbl_usuario_aplicacion_tbl_aplicacion1` (`PK_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_usuario_perfil`
--

CREATE TABLE IF NOT EXISTS `tbl_usuario_perfil` (
  `PK_id_usuario` varchar(25) NOT NULL,
  `PK_id_perfil` int(11) NOT NULL,
  PRIMARY KEY (`PK_id_usuario`,`PK_id_perfil`),
  KEY `fk_Usuario_perfil_Perfil1` (`PK_id_perfil`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tblproveedorbodega`
--
ALTER TABLE `tblproveedorbodega`
  ADD CONSTRAINT `FK_proveedor_bodega` FOREIGN KEY (`KidProveedor`) REFERENCES `tbl_proveedor` (`KidProveedor`),
  ADD CONSTRAINT `FK_bodega_proveedor` FOREIGN KEY (`KidBodega`) REFERENCES `tbl_bodega` (`KidBodega`),
  ADD CONSTRAINT `Fk_proveedor_bodega_producto` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_aplicacion`
--
ALTER TABLE `tbl_aplicacion`
  ADD CONSTRAINT `fk_Aplicacion_Modulo` FOREIGN KEY (`PK_id_modulo`) REFERENCES `tbl_modulo` (`PK_id_Modulo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_asignacion_empleado`
--
ALTER TABLE `tbl_asignacion_empleado`
  ADD CONSTRAINT `fk_Ventas_has_Comisiones_Ventas1` FOREIGN KEY (`KidPoliza`) REFERENCES `tbl_poliza` (`KidPoliza`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Ventas_has_Comisiones_Comisiones1` FOREIGN KEY (`KidComisiones`) REFERENCES `tbl_comisiones` (`KidComisiones`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Asignacion_Empleado_Empleados1` FOREIGN KEY (`KidEmpleados`) REFERENCES `tbl_empleado` (`KidEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_balancegeneral_detalle`
--
ALTER TABLE `tbl_balancegeneral_detalle`
  ADD CONSTRAINT `fk_tbl_BalanceGeneral_Detalle_tbl_BalanceGeneral_Encabezado1` FOREIGN KEY (`KidBalanceGeneral`) REFERENCES `tbl_balancegeneral_encabezado` (`KidBalanceGeneral`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_BalanceGeneral_Detalle_tbl_cuentas_contables1` FOREIGN KEY (`KidCuentaContable`) REFERENCES `tbl_cuentas` (`KidCuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_bancotalento`
--
ALTER TABLE `tbl_bancotalento`
  ADD CONSTRAINT `FK_encabezadoReporteVacante_BancoTalento` FOREIGN KEY (`KidReporteVacante`) REFERENCES `tbl_encabezadoreportevacante` (`KidReporteVacante`);

--
-- Filtros para la tabla `tbl_bitacora`
--
ALTER TABLE `tbl_bitacora`
  ADD CONSTRAINT `fk_Bitacora_Usuario1` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_bodega`
--
ALTER TABLE `tbl_bodega`
  ADD CONSTRAINT `FK_Sucursal_Bodega` FOREIGN KEY (`KidSucursal`) REFERENCES `tbl_sucursal` (`KidSucursal`);

--
-- Filtros para la tabla `tbl_check_in`
--
ALTER TABLE `tbl_check_in`
  ADD CONSTRAINT `fk_Tbl_Check_In_Tbl_Empleados1` FOREIGN KEY (`KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Check_In_Tbl_Clientes1` FOREIGN KEY (`KidCliente`) REFERENCES `tbl_clientes` (`KidCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_check_out`
--
ALTER TABLE `tbl_check_out`
  ADD CONSTRAINT `fk_Tbl_Check_Out_Tbl_Clientes1` FOREIGN KEY (`KidCliente`) REFERENCES `tbl_clientes` (`KidCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Check_Out_Tbl_Empleados1` FOREIGN KEY (`KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_chequera`
--
ALTER TABLE `tbl_chequera`
  ADD CONSTRAINT `FK_CuentaBancaria_Chequera` FOREIGN KEY (`KidCuentaBancaria`) REFERENCES `tbl_cuentabancaria` (`KidCuentaBancaria`);

--
-- Filtros para la tabla `tbl_clientes`
--
ALTER TABLE `tbl_clientes`
  ADD CONSTRAINT `fk_Cliente_TipoCliente` FOREIGN KEY (`KidTipoCliente`) REFERENCES `tbl_tipocliente` (`KidTipoCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_comandas`
--
ALTER TABLE `tbl_comandas`
  ADD CONSTRAINT `service` FOREIGN KEY (`KidServicio`) REFERENCES `tbl_servicios` (`KidServicio`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_comisiones`
--
ALTER TABLE `tbl_comisiones`
  ADD CONSTRAINT `fk_Producto_Comisiones` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_conciliacion_bancaria`
--
ALTER TABLE `tbl_conciliacion_bancaria`
  ADD CONSTRAINT `FK_Bancos_ConciliacionBancaria` FOREIGN KEY (`KidBanco`) REFERENCES `tbl_bancos` (`KidBanco`),
  ADD CONSTRAINT `FK_Moneda_ConciliacionBancaria` FOREIGN KEY (`moneda`) REFERENCES `tbl_divisa` (`KidDivisa`);

--
-- Filtros para la tabla `tbl_consulta`
--
ALTER TABLE `tbl_consulta`
  ADD CONSTRAINT `FK_usuario_consulta` FOREIGN KEY (`KidUsuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`);

--
-- Filtros para la tabla `tbl_contacto`
--
ALTER TABLE `tbl_contacto`
  ADD CONSTRAINT `fk_proveedor_contacto` FOREIGN KEY (`KidProveedor`) REFERENCES `tbl_proveedor` (`KidProveedor`);

--
-- Filtros para la tabla `tbl_control_mesas`
--
ALTER TABLE `tbl_control_mesas`
  ADD CONSTRAINT `mesa` FOREIGN KEY (`KidNumeroMesa`) REFERENCES `tbl_mesas` (`KidNumeroMesa`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_cotizaciondetalle`
--
ALTER TABLE `tbl_cotizaciondetalle`
  ADD CONSTRAINT `FK_cotizacionEncabezado_CotizacionDetalle` FOREIGN KEY (`KidCotizacionDetalle`) REFERENCES `tbl_cotizacionencabezado` (`KidCotizacionEncabezado`),
  ADD CONSTRAINT `FK_Productos_cotizacionDetalle` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_cotizacionencabezado`
--
ALTER TABLE `tbl_cotizacionencabezado`
  ADD CONSTRAINT `FK_clientes_cotizacionEncabezado` FOREIGN KEY (`KidCliente`) REFERENCES `tbl_clientes` (`KidCliente`);

--
-- Filtros para la tabla `tbl_creditopedido`
--
ALTER TABLE `tbl_creditopedido`
  ADD CONSTRAINT `FK_credito_pedido` FOREIGN KEY (`KidPedido`) REFERENCES `tbl_pedido` (`KidPedido`),
  ADD CONSTRAINT `fk_credito_banco` FOREIGN KEY (`KidBanco`) REFERENCES `tbl_bancos` (`KidBanco`);

--
-- Filtros para la tabla `tbl_creditoservicio`
--
ALTER TABLE `tbl_creditoservicio`
  ADD CONSTRAINT `FK_credigo_pagoServicio` FOREIGN KEY (`KidPagoServicio`) REFERENCES `tbl_pagoservicio` (`KidPagoServicio`),
  ADD CONSTRAINT `fk_creditoServicio_banco` FOREIGN KEY (`KidBanco`) REFERENCES `tbl_bancos` (`KidBanco`);

--
-- Filtros para la tabla `tbl_credpeddet`
--
ALTER TABLE `tbl_credpeddet`
  ADD CONSTRAINT `FK_creditoPedDet_CreditoPedido` FOREIGN KEY (`KidCreditoPedido`) REFERENCES `tbl_creditopedido` (`KidCreditoPedido`);

--
-- Filtros para la tabla `tbl_credservdet`
--
ALTER TABLE `tbl_credservdet`
  ADD CONSTRAINT `fk_credServDet_CreditoServicio` FOREIGN KEY (`KidCreditoServicio`) REFERENCES `tbl_creditoservicio` (`KidCreditoServicio`);

--
-- Filtros para la tabla `tbl_cuentabancaria`
--
ALTER TABLE `tbl_cuentabancaria`
  ADD CONSTRAINT `FK_Bancos_CuentaBancaria` FOREIGN KEY (`KidBanco`) REFERENCES `tbl_bancos` (`KidBanco`),
  ADD CONSTRAINT `FK_Moneda_CuentaBancaria` FOREIGN KEY (`KidMoneda`) REFERENCES `tbl_divisa` (`KidDivisa`);

--
-- Filtros para la tabla `tbl_cuentas`
--
ALTER TABLE `tbl_cuentas`
  ADD CONSTRAINT `fk_tbl_cuentas_contables_tbl_tipoCuentaContable1` FOREIGN KEY (`KidTipoCuenta`) REFERENCES `tbl_tipocuenta` (`KidTipoCuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_departamentos`
--
ALTER TABLE `tbl_departamentos`
  ADD CONSTRAINT `fk_Tbl_departamentos_Tbl_areas1` FOREIGN KEY (`KidArea`) REFERENCES `tbl_areas` (`KidArea`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_descuentos`
--
ALTER TABLE `tbl_descuentos`
  ADD CONSTRAINT `fk_Producto_Descuentos` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_desempeñoempleado`
--
ALTER TABLE `tbl_desempeñoempleado`
  ADD CONSTRAINT `FK_Empleado_DesempeñoEmpleado` FOREIGN KEY (`KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_Pruebas_DesempeñoEmpleado` FOREIGN KEY (`KidPruebas`) REFERENCES `tbl_pruebas` (`KidPruebas`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_detallecomprobante`
--
ALTER TABLE `tbl_detallecomprobante`
  ADD CONSTRAINT `FK_encabezado_detalleComprobante` FOREIGN KEY (`KidDetalleComprobante`) REFERENCES `tbl_encabezadocomprobante` (`KidEncabezadoComprobante`);

--
-- Filtros para la tabla `tbl_detallepedido`
--
ALTER TABLE `tbl_detallepedido`
  ADD CONSTRAINT `FK_EncabezadoPedido_DetallePedido1` FOREIGN KEY (`KidDetallePedido`) REFERENCES `tbl_encabezadopedido` (`KidEncabezadoPedido`),
  ADD CONSTRAINT `FK_Productos_DetallePedido1` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_detallereportevacante`
--
ALTER TABLE `tbl_detallereportevacante`
  ADD CONSTRAINT `FK_Encabezado_DetalleReporteVacante` FOREIGN KEY (`KidReporteVacante`) REFERENCES `tbl_encabezadoreportevacante` (`KidReporteVacante`);

--
-- Filtros para la tabla `tbl_detalle_control`
--
ALTER TABLE `tbl_detalle_control`
  ADD CONSTRAINT `fk_Tbl_Detalle_Control_Tbl_Control_Mesas1` FOREIGN KEY (`KidControl`) REFERENCES `tbl_control_mesas` (`KidControl`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Detalle_Control_Tbl_Platillos1` FOREIGN KEY (`KidPlatillo`) REFERENCES `tbl_platillos` (`KidPlatillo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_detalle_evento`
--
ALTER TABLE `tbl_detalle_evento`
  ADD CONSTRAINT `reservacion0` FOREIGN KEY (`KidEvento`) REFERENCES `tbl_eventos` (`KidEvento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Detalle_Evento_Tbl_Salones1` FOREIGN KEY (`KidNumeroSalon`) REFERENCES `tbl_salones` (`KidNumeroSalon`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_detalle_folio`
--
ALTER TABLE `tbl_detalle_folio`
  ADD CONSTRAINT `servicio` FOREIGN KEY (`KidComanda`) REFERENCES `tbl_comandas` (`KidNumeroComanda`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Detalle_Folio_Tbl_Folios1` FOREIGN KEY (`KidFolio`) REFERENCES `tbl_folios` (`KidFolio`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_detalle_lista_precios`
--
ALTER TABLE `tbl_detalle_lista_precios`
  ADD CONSTRAINT `FK_EncabezadoLista_Precios_Detalle_Lista_Precios` FOREIGN KEY (`KidEncabezadoListaPrecios`) REFERENCES `tbl_encabezado_lista_precios` (`KidEncabezadoListaPrecios`),
  ADD CONSTRAINT `FK_Productos_DetallePedido` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`),
  ADD CONSTRAINT `FK_TipoListaPrecios_DetalleListaPrecios` FOREIGN KEY (`Kidtipo_lista_precios`) REFERENCES `tbl_tipo_lista_precios` (`Kidtipo_lista_precios`);

--
-- Filtros para la tabla `tbl_detalle_producto`
--
ALTER TABLE `tbl_detalle_producto`
  ADD CONSTRAINT `fk_DetalleProducto_Producto` FOREIGN KEY (`Kidproducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_detalle_reservacion`
--
ALTER TABLE `tbl_detalle_reservacion`
  ADD CONSTRAINT `reservacion` FOREIGN KEY (`KidReservacion`) REFERENCES `tbl_reservaciones` (`KidReservacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `habitacion` FOREIGN KEY (`KidNumeroHabitacion`) REFERENCES `tbl_habitaciones` (`KidNumeroHabitacion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_detalle_roles`
--
ALTER TABLE `tbl_detalle_roles`
  ADD CONSTRAINT `fk_Tbl_detalle_roles_Tbl_empleado1` FOREIGN KEY (`KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_detalle_roles_Tbl_roles_de_pago` FOREIGN KEY (`KidRolpago`) REFERENCES `tbl_roles_de_pago` (`KidRolpago`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_devoluciones`
--
ALTER TABLE `tbl_devoluciones`
  ADD CONSTRAINT `fk_Devoluciones_FacturaEncabezado1` FOREIGN KEY (`KidFacturaEncabezado`) REFERENCES `tbl_facturaencabezado` (`KidFacturaEncabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_devoluciones_platillos`
--
ALTER TABLE `tbl_devoluciones_platillos`
  ADD CONSTRAINT `fk_Devoluciones_platillos1` FOREIGN KEY (`KidDevPlatillo`) REFERENCES `tbl_platillos` (`KidPlatillo`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_empleado`
--
ALTER TABLE `tbl_empleado`
  ADD CONSTRAINT `fk_Tbl_empleado_Tbl_departamentos1` FOREIGN KEY (`KidDepartamento`) REFERENCES `tbl_departamentos` (`KidDepartamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_empleado_Tbl_puestos1` FOREIGN KEY (`KidPuesto`) REFERENCES `tbl_puestos` (`KidPuesto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_encabezadocomprobante`
--
ALTER TABLE `tbl_encabezadocomprobante`
  ADD CONSTRAINT `FK_cliente_encabezadoComprobante` FOREIGN KEY (`KidCliente`) REFERENCES `tbl_clientes` (`KidCliente`),
  ADD CONSTRAINT `FK_empleado_encabezadoComprobante` FOREIGN KEY (`KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`),
  ADD CONSTRAINT `FK_tipoComprobante_encabezadoComprobante` FOREIGN KEY (`KidtiposComprobantes`) REFERENCES `tbl_tiposcomprobantes` (`KidtiposComprobantes`),
  ADD CONSTRAINT `FK_FacturaEncabezado_EncabezadoComprobante` FOREIGN KEY (`KidFacturaEncabezado`) REFERENCES `tbl_facturaencabezado` (`KidFacturaEncabezado`);

--
-- Filtros para la tabla `tbl_encabezadopedido`
--
ALTER TABLE `tbl_encabezadopedido`
  ADD CONSTRAINT `FK_FacturaEncabezado_EncabezadoPedido` FOREIGN KEY (`KidFacturaEncabezado`) REFERENCES `tbl_facturaencabezado` (`KidFacturaEncabezado`),
  ADD CONSTRAINT `FK_clientes_EncabezadoPedido` FOREIGN KEY (`KidCliente`) REFERENCES `tbl_clientes` (`KidCliente`);

--
-- Filtros para la tabla `tbl_encabezadoreportevacante`
--
ALTER TABLE `tbl_encabezadoreportevacante`
  ADD CONSTRAINT `FK_Empleado_ReporteVacante` FOREIGN KEY (`KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`),
  ADD CONSTRAINT `FK_Puesto_ReporteVacante` FOREIGN KEY (`KidPuesto`) REFERENCES `tbl_puestos` (`KidPuesto`);

--
-- Filtros para la tabla `tbl_estado_perdidas_ganacias_detalle`
--
ALTER TABLE `tbl_estado_perdidas_ganacias_detalle`
  ADD CONSTRAINT `fk_tbl_estado_perdidas_ganacias_Detalle_tbl_estado_perdidas_g1` FOREIGN KEY (`KidPerdidasGanancias`) REFERENCES `tbl_estado_perdidas_ganancias_encabezado` (`KidPerdidasGanancias`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_estado_perdidas_ganacias_Detalle_tbl_cuentas_contables1` FOREIGN KEY (`KidCuenta`) REFERENCES `tbl_cuentas` (`KidCuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_eventos`
--
ALTER TABLE `tbl_eventos`
  ADD CONSTRAINT `fk_Tbl_Eventos_Tbl_Clientes1` FOREIGN KEY (`KidCliente`) REFERENCES `tbl_clientes` (`KidCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Eventos_Tbl_Empleados1` FOREIGN KEY (`_KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_existencia`
--
ALTER TABLE `tbl_existencia`
  ADD CONSTRAINT `fk_Producto_Existencia` FOREIGN KEY (`kidproducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_existencias`
--
ALTER TABLE `tbl_existencias`
  ADD CONSTRAINT `prod` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `bode` FOREIGN KEY (`KidBodega`) REFERENCES `tbl_bodega` (`KidBodega`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_facturadetalle`
--
ALTER TABLE `tbl_facturadetalle`
  ADD CONSTRAINT `fk_FacturaDetalle_Producto1` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_FacturaDetalle_FacturaEncabezado1` FOREIGN KEY (`KidFacturaEncabezado`) REFERENCES `tbl_facturaencabezado` (`KidFacturaEncabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_facturaencabezado`
--
ALTER TABLE `tbl_facturaencabezado`
  ADD CONSTRAINT `fk_FacturaEncabezado_Cliente1` FOREIGN KEY (`KidCliente`) REFERENCES `tbl_clientes` (`KidCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_FacturaEncabezado_Serie1` FOREIGN KEY (`KidSerie`) REFERENCES `tbl_serie` (`KidSerie`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_FacturaEncabezado_Tbl_Impuesto1` FOREIGN KEY (`KidImpuesto`) REFERENCES `tbl_impuesto` (`KidImpuesto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_FacturaEncabezado_Tbl_Moneda1` FOREIGN KEY (`KidMoneda`) REFERENCES `tbl_moneda` (`KidMoneda`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Descuentos_facturaEncabezado` FOREIGN KEY (`KidDescuentos`) REFERENCES `tbl_descuentos` (`KidDescuentos`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_EncabezadoLista_Precios_FacturaEncabezado` FOREIGN KEY (`KidEncabezadoListaPrecios`) REFERENCES `tbl_encabezado_lista_precios` (`KidEncabezadoListaPrecios`),
  ADD CONSTRAINT `FK_cotizacionEncabezado_FacturaEncabezado` FOREIGN KEY (`KidCotizacionEncabezado`) REFERENCES `tbl_cotizacionencabezado` (`KidCotizacionEncabezado`);

--
-- Filtros para la tabla `tbl_flujoefectivo_detalle`
--
ALTER TABLE `tbl_flujoefectivo_detalle`
  ADD CONSTRAINT `fk_tbl_flujoEfectivo_Detalle_tbl_flujoEfectivo_Encabezado1` FOREIGN KEY (`KidFlujoEfectivo`) REFERENCES `tbl_flujoefectivo_encabezado` (`KidFlujoEfectivo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_flujoEfectivo_Detalle_tbl_cuentas1` FOREIGN KEY (`KidCuenta`) REFERENCES `tbl_cuentas` (`KidCuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_gestionmovimientocliente`
--
ALTER TABLE `tbl_gestionmovimientocliente`
  ADD CONSTRAINT `FK_encabezadoComprobante_GestionMovimientoCliente` FOREIGN KEY (`KidEncabezadoComprobante`) REFERENCES `tbl_encabezadocomprobante` (`KidEncabezadoComprobante`);

--
-- Filtros para la tabla `tbl_habitaciones`
--
ALTER TABLE `tbl_habitaciones`
  ADD CONSTRAINT `tipoHabitacion` FOREIGN KEY (`KidTipoHabitacion`) REFERENCES `tbl_tipo_habitacion` (`KidTipoHabitacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `categoria` FOREIGN KEY (`KidCategoria`) REFERENCES `tbl_categorias_habitacion` (`KidCategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_historia_inventario`
--
ALTER TABLE `tbl_historia_inventario`
  ADD CONSTRAINT `fk_Producto_HistoriaInventario` FOREIGN KEY (`Kidproducto`) REFERENCES `tbl_producto` (`KidProducto`),
  ADD CONSTRAINT `fk_MovimientoInventario_HistoriaInventario` FOREIGN KEY (`Kidmovimientoinventario`) REFERENCES `tbl_moviemiento_inventario` (`Kidmoviemientoinventario`),
  ADD CONSTRAINT `FK_Bodega_HistoriaInventario` FOREIGN KEY (`Kidbodega`) REFERENCES `tbl_bodega` (`KidBodega`),
  ADD CONSTRAINT `fk_Sucursal_HistoriaInventario` FOREIGN KEY (`Kidsucursal`) REFERENCES `tbl_sucursal` (`KidSucursal`);

--
-- Filtros para la tabla `tbl_ingredientes`
--
ALTER TABLE `tbl_ingredientes`
  ADD CONSTRAINT `fk_Tbl_Ingredientes_Tbl_Producto1` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Ingredientes_Tbl_Recetas1` FOREIGN KEY (`KidRecetas`) REFERENCES `tbl_recetas` (`KidRecetas`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_inventario`
--
ALTER TABLE `tbl_inventario`
  ADD CONSTRAINT `fk_Inventario_Producto1` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`),
  ADD CONSTRAINT `fk_Inventario_Bodegas` FOREIGN KEY (`Kidbodega`) REFERENCES `tbl_bodega` (`KidBodega`),
  ADD CONSTRAINT `Fk_Inventario_Stock` FOREIGN KEY (`Kidstock`) REFERENCES `tbl_stock` (`Kidstock`),
  ADD CONSTRAINT `fk_Inventario_Existencia` FOREIGN KEY (`Kidexistencia`) REFERENCES `tbl_existencia` (`Kidexistencia`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_librodiario`
--
ALTER TABLE `tbl_librodiario`
  ADD CONSTRAINT `fk_polizaEncabezado_libroDiario` FOREIGN KEY (`KidPoliza`) REFERENCES `tbl_poliza_encabezado` (`KidPoliza`);

--
-- Filtros para la tabla `tbl_libromayor_detalle`
--
ALTER TABLE `tbl_libromayor_detalle`
  ADD CONSTRAINT `fk_tbl_libroMayor_Detalle_tbl_libroMayor1` FOREIGN KEY (`KidLibroMayor`) REFERENCES `tbl_libromayor_encabezado` (`KidLibroMayor`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_libromayor_encabezado`
--
ALTER TABLE `tbl_libromayor_encabezado`
  ADD CONSTRAINT `fk_tbl_libroMayor_tbl_libroDiario_Encabezado1` FOREIGN KEY (`KidLibroDiarioEncabezado`) REFERENCES `tbl_librodiario_encabezado` (`KidLibroDiarioEncabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_mesas`
--
ALTER TABLE `tbl_mesas`
  ADD CONSTRAINT `fk_Tbl_Mesas_Tbl_Areas1` FOREIGN KEY (`KidArea`) REFERENCES `tbl_areas` (`KidArea`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_nominasdetalle`
--
ALTER TABLE `tbl_nominasdetalle`
  ADD CONSTRAINT `fk_Tbl_nominasDetalle_Tbl_conceptos1` FOREIGN KEY (`KidConcepto`) REFERENCES `tbl_conceptos` (`KidConcepto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_nominasDetalle_Tbl_nominasEncabezado1` FOREIGN KEY (`KidNomina`) REFERENCES `tbl_nominasencabezado` (`KidNomina`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_nominasencabezado`
--
ALTER TABLE `tbl_nominasencabezado`
  ADD CONSTRAINT `fk_Tbl_nominasEncabezado_Tbl_empleado1` FOREIGN KEY (`KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_objetos_perdidos`
--
ALTER TABLE `tbl_objetos_perdidos`
  ADD CONSTRAINT `fk_Tbl_Objetos_Perdidos_Tbl_Habitaciones1` FOREIGN KEY (`KidNumeroHabitacion`) REFERENCES `tbl_habitaciones` (`KidNumeroHabitacion`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_orden_compra_encabezado`
--
ALTER TABLE `tbl_orden_compra_encabezado`
  ADD CONSTRAINT `fk_OrdenEncabezado_proveedor` FOREIGN KEY (`KidProveedor`) REFERENCES `tbl_proveedor` (`KidProveedor`),
  ADD CONSTRAINT `Fk_ordenencabezado_impuesto` FOREIGN KEY (`KidImpuesto`) REFERENCES `tbl_impuesto` (`KidImpuesto`);

--
-- Filtros para la tabla `tbl_orden_dompra_detalle`
--
ALTER TABLE `tbl_orden_dompra_detalle`
  ADD CONSTRAINT `fk_OrdenEncabezado_detalle` FOREIGN KEY (`KidOrdenCompraEncabezado`) REFERENCES `tbl_orden_compra_encabezado` (`KidOrdenCompraEncabezado`),
  ADD CONSTRAINT `fk_ordendetalle_producto` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_pagos`
--
ALTER TABLE `tbl_pagos`
  ADD CONSTRAINT `fk_Pagos_TipoPago1` FOREIGN KEY (`KidTipoPago`) REFERENCES `tbl_tipopago` (`KidTipoPago`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Pagos_FacturaEncabezado1` FOREIGN KEY (`KidFacturaEncabezado`) REFERENCES `tbl_facturaencabezado` (`KidFacturaEncabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_pagoservicio`
--
ALTER TABLE `tbl_pagoservicio`
  ADD CONSTRAINT `FK_pago_acreedor` FOREIGN KEY (`KidAcreedor`) REFERENCES `tbl_acreedor` (`KidAcreedor`),
  ADD CONSTRAINT `FK_pago_servicio` FOREIGN KEY (`KidServicio`) REFERENCES `tbl_servicio` (`KidServicio`);

--
-- Filtros para la tabla `tbl_pedido`
--
ALTER TABLE `tbl_pedido`
  ADD CONSTRAINT `FK_proveedor_pedido` FOREIGN KEY (`KidProveedor`) REFERENCES `tbl_proveedor` (`KidProveedor`),
  ADD CONSTRAINT `fk_OrdenEncabezado_pedido` FOREIGN KEY (`KidOrdenCompra`) REFERENCES `tbl_orden_compra_encabezado` (`KidOrdenCompraEncabezado`);

--
-- Filtros para la tabla `tbl_pedidodet`
--
ALTER TABLE `tbl_pedidodet`
  ADD CONSTRAINT `fk_PedidoDet_producto` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_perfil_detalle`
--
ALTER TABLE `tbl_perfil_detalle`
  ADD CONSTRAINT `fk_Perfil_detalle_Aplicacion1` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Perfil_detalle_Perfil1` FOREIGN KEY (`PK_id_perfil`) REFERENCES `tbl_perfil_encabezado` (`PK_id_perfil`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_plandecarrera`
--
ALTER TABLE `tbl_plandecarrera`
  ADD CONSTRAINT `FK_DesempeñoEmpleado_PlanDeCarrera` FOREIGN KEY (`KidDesempeño`) REFERENCES `tbl_desempeñoempleado` (`KidDesempeño`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_planillasdetalle`
--
ALTER TABLE `tbl_planillasdetalle`
  ADD CONSTRAINT `fk_Tbl_PlanillasDetalle_Tbl_empleado1` FOREIGN KEY (`KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_PlanillasDetalle_Tbl_planillasEncabezado1` FOREIGN KEY (`KidPlanilla`) REFERENCES `tbl_planillasencabezado` (`KidPlanilla`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_platillos`
--
ALTER TABLE `tbl_platillos`
  ADD CONSTRAINT `menu` FOREIGN KEY (`KidMenu`) REFERENCES `tbl_menus` (`KidMenu`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_poliza`
--
ALTER TABLE `tbl_poliza`
  ADD CONSTRAINT `FK_FacturaDetalle_Poliza` FOREIGN KEY (`KidFacturaDetalle`) REFERENCES `tbl_facturadetalle` (`KidFacturaDetalle`);

--
-- Filtros para la tabla `tbl_poliza_detalle`
--
ALTER TABLE `tbl_poliza_detalle`
  ADD CONSTRAINT `fk_PolizaEncabezado_PolizaDetalle` FOREIGN KEY (`KidPoliza`) REFERENCES `tbl_poliza_encabezado` (`KidPoliza`),
  ADD CONSTRAINT `fk_Cuentas_PolizaDetalle` FOREIGN KEY (`KidCuenta`) REFERENCES `tbl_cuentas` (`KidCuenta`);

--
-- Filtros para la tabla `tbl_poliza_encabezado`
--
ALTER TABLE `tbl_poliza_encabezado`
  ADD CONSTRAINT `fk_tipoDePoliza_PolizaEncabezado` FOREIGN KEY (`KidTipoDePoliza`) REFERENCES `tbl_tipo_poliza` (`KidTipoDePoliza`);

--
-- Filtros para la tabla `tbl_precios`
--
ALTER TABLE `tbl_precios`
  ADD CONSTRAINT `fk_Precios_Producto1` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_presupuesto`
--
ALTER TABLE `tbl_presupuesto`
  ADD CONSTRAINT `FK_Moneda_Presupuesto` FOREIGN KEY (`KidMoneda`) REFERENCES `tbl_moneda` (`KidMoneda`),
  ADD CONSTRAINT `FK_area_presupuesto` FOREIGN KEY (`KidArea`) REFERENCES `tbl_areas` (`KidArea`),
  ADD CONSTRAINT `FK_cuentas_presupuesto` FOREIGN KEY (`KidCuenta`) REFERENCES `tbl_cuentas` (`KidCuenta`);

--
-- Filtros para la tabla `tbl_producto`
--
ALTER TABLE `tbl_producto`
  ADD CONSTRAINT `fk_Producto_TipoProducto1` FOREIGN KEY (`KidTipoProducto`) REFERENCES `tbl_tipoproducto` (`KidTipoProducto`);

--
-- Filtros para la tabla `tbl_producto_marca`
--
ALTER TABLE `tbl_producto_marca`
  ADD CONSTRAINT `fk_Marca_Producto` FOREIGN KEY (`Kidmarca`) REFERENCES `tbl_marca` (`Kidmarca`),
  ADD CONSTRAINT `fk_Producto_Marca` FOREIGN KEY (`Kidproducto`) REFERENCES `tbl_producto` (`KidProducto`);

--
-- Filtros para la tabla `tbl_propiedad_rpt`
--
ALTER TABLE `tbl_propiedad_rpt`
  ADD CONSTRAINT `FK_Tbl_Modulo_Tbl_propiedad_Rpt` FOREIGN KEY (`PK_id_Modulo`) REFERENCES `tbl_modulo` (`PK_id_Modulo`),
  ADD CONSTRAINT `FK_Tbl_Aplicacio_Tbl_propiedad_Rpt` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`),
  ADD CONSTRAINT `FK_Tbl_reporte_Tbl_propiedad_Rpt` FOREIGN KEY (`PK_id_reporte`) REFERENCES `tbl_reporte` (`PK_id_reporte`),
  ADD CONSTRAINT `FK_Tbl_usuario_Tbl_propiedad_Rpt` FOREIGN KEY (`PK_id_usuario`) REFERENCES `tbl_usuario` (`PK_id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_puestos`
--
ALTER TABLE `tbl_puestos`
  ADD CONSTRAINT `fk_Area_Puestos` FOREIGN KEY (`KidArea`) REFERENCES `tbl_areas` (`KidArea`);

--
-- Filtros para la tabla `tbl_quejas`
--
ALTER TABLE `tbl_quejas`
  ADD CONSTRAINT `fk_Tbl_Quejas_Tbl_Clientes1` FOREIGN KEY (`KidCliente`) REFERENCES `tbl_clientes` (`KidCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_reporte`
--
ALTER TABLE `tbl_reporte`
  ADD CONSTRAINT `FK_Tbl_reporte_Tbl_Configuacion` FOREIGN KEY (`PK_id_configuracion`) REFERENCES `tbl_configuracion_rpt` (`PK_id_configuracion`);

--
-- Filtros para la tabla `tbl_reservaciones`
--
ALTER TABLE `tbl_reservaciones`
  ADD CONSTRAINT `fk_Tbl_Reservaciones_Tbl_Clientes1` FOREIGN KEY (`KidCliente`) REFERENCES `tbl_clientes` (`KidCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Reservaciones_Tbl_Empleados1` FOREIGN KEY (`KidEmpleado`) REFERENCES `tbl_empleado` (`KidEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_resultados`
--
ALTER TABLE `tbl_resultados`
  ADD CONSTRAINT `FK_BancoTalento_Resultados` FOREIGN KEY (`KidBancoTalento`) REFERENCES `tbl_bancotalento` (`KidBancoTalento`),
  ADD CONSTRAINT `FK_Pruebas_Resultados` FOREIGN KEY (`KidPruebas`) REFERENCES `tbl_pruebas` (`KidPruebas`);

--
-- Filtros para la tabla `tbl_rpt_app`
--
ALTER TABLE `tbl_rpt_app`
  ADD CONSTRAINT `FK_Tbl_Modulo_Tbl_rpt_app` FOREIGN KEY (`PK_id_Modulo`) REFERENCES `tbl_modulo` (`PK_id_Modulo`),
  ADD CONSTRAINT `FK_Tbl_Aplicacion_Tbl_rpt_app` FOREIGN KEY (`PK_id_aplicacion`) REFERENCES `tbl_aplicacion` (`PK_id_aplicacion`),
  ADD CONSTRAINT `FK_Tbl_Reporte_Tbl_rpt_app` FOREIGN KEY (`PK_id_reporte`) REFERENCES `tbl_reporte` (`PK_id_reporte`);

--
-- Filtros para la tabla `tbl_rpt_mdl`
--
ALTER TABLE `tbl_rpt_mdl`
  ADD CONSTRAINT `FK_Tbl_modulo_Tbl_rpt_mdl` FOREIGN KEY (`PK_id_Modulo`) REFERENCES `tbl_modulo` (`PK_id_Modulo`),
  ADD CONSTRAINT `FK_Tbl_reporte_Tbl_rpt_mdl` FOREIGN KEY (`PK_id_reporte`) REFERENCES `tbl_reporte` (`PK_id_reporte`);

--
-- Filtros para la tabla `tbl_serie`
--
ALTER TABLE `tbl_serie`
  ADD CONSTRAINT `FK_Folio_Serie` FOREIGN KEY (`KidFolio`) REFERENCES `tbl_folios` (`KidFolio`);

--
-- Filtros para la tabla `tbl_servicios`
--
ALTER TABLE `tbl_servicios`
  ADD CONSTRAINT `fk_Tbl_Servicios_Tbl_Areas1` FOREIGN KEY (`KidArea`) REFERENCES `tbl_areas` (`KidArea`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_solicitudrembolso`
--
ALTER TABLE `tbl_solicitudrembolso`
  ADD CONSTRAINT `fk_SolicitudRembolso_FacturaEncabezado1` FOREIGN KEY (`KidFacturaEncabezado`) REFERENCES `tbl_facturaencabezado` (`KidFacturaEncabezado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_tiendas`
--
ALTER TABLE `tbl_tiendas`
  ADD CONSTRAINT `fk_Tbl_Tiendas_Tbl_Areas1` FOREIGN KEY (`KidArea`) REFERENCES `tbl_areas` (`KidArea`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_tiendas_producto`
--
ALTER TABLE `tbl_tiendas_producto`
  ADD CONSTRAINT `fk_Tbl_Producto_has_Tbl_Tiendas_Tbl_Producto1` FOREIGN KEY (`KidProducto`) REFERENCES `tbl_producto` (`KidProducto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Tbl_Producto_has_Tbl_Tiendas_Tbl_Tiendas1` FOREIGN KEY (`KidTienda`) REFERENCES `tbl_tiendas` (`KidTienda`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_tipocambio`
--
ALTER TABLE `tbl_tipocambio`
  ADD CONSTRAINT `fk_tbl_tipoCambio_tbl_Divisa` FOREIGN KEY (`KidMonedaConversion`) REFERENCES `tbl_divisa` (`KidDivisa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_tipoCambio_tbl_Divisa1` FOREIGN KEY (`KidMonedaBase`) REFERENCES `tbl_divisa` (`KidDivisa`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `tbl_ubicacionprodcuto`
--
ALTER TABLE `tbl_ubicacionprodcuto`
  ADD CONSTRAINT `fk_Producto_Ubicacion` FOREIGN KEY (`Kidproducto`) REFERENCES `tbl_producto` (`KidProducto`),
  ADD CONSTRAINT `fk_Ubicacion_Producto` FOREIGN KEY (`Kidubicacion`) REFERENCES `tbl_ubicacion` (`Kidubicacion`);

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

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
