-- MySQL dump 10.13  Distrib 5.1.36, for Win32 (ia32)
--
-- Host: localhost    Database: poo
-- ------------------------------------------------------
-- Server version	5.1.36-community-log

--
-- Current Database: `poo`
--

USE `poo`;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) DEFAULT NULL,
  `endereco` varchar(255) DEFAULT NULL,
  `telefone` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=MyISAM AUTO_INCREMENT=55 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
--
-- Table structure for table `fornecedores`
--

DROP TABLE IF EXISTS `fornecedores`;
CREATE TABLE `fornecedores` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) DEFAULT NULL,
  `endereco` varchar(100) DEFAULT NULL,
  `telefone` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fornecedores`
--

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `idCodigo` int(11) NOT NULL DEFAULT '0',
  `Nome` varchar(50) DEFAULT NULL,
  `Preco` float DEFAULT NULL,
  `Quantidade` varchar(50) DEFAULT NULL,
  `DataCompra` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idCodigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

