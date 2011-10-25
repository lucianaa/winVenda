-- MySQL dump 10.13  Distrib 5.1.36, for Win32 (ia32)
--
-- Host: localhost    Database: poo
-- ------------------------------------------------------
-- Server version	5.1.36-community-log



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

create table produtos (codigo int not null auto_increment primary key, nome varchar(255), descricao text,  quantidade float, preco float);


