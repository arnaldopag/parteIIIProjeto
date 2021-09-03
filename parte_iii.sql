-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 03-Set-2021 às 02:28
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 7.4.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `parte_iii`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `candidato`
--

CREATE TABLE `candidato` (
  `idCandidato` int(11) NOT NULL,
  `nome` varchar(60) DEFAULT NULL,
  `email` varchar(60) DEFAULT NULL,
  `fone` varchar(15) DEFAULT NULL,
  `dataNascimento` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `candidato`
--

INSERT INTO `candidato` (`idCandidato`, `nome`, `email`, `fone`, `dataNascimento`) VALUES
(1, 'JESUS', 'MARIA ', 'JOSE', '1996-09-17 00:00:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL,
  `nome` varchar(60) DEFAULT NULL,
  `email` varchar(60) DEFAULT NULL,
  `fone` varchar(60) DEFAULT NULL,
  `login` varchar(30) DEFAULT NULL,
  `senha` varchar(30) DEFAULT NULL,
  `cpf` varchar(11) DEFAULT NULL,
  `rg` varchar(10) DEFAULT NULL,
  `salario` double DEFAULT NULL,
  `dataNascimento` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nome`, `email`, `fone`, `login`, `senha`, `cpf`, `rg`, `salario`, `dataNascimento`) VALUES
(6, '1010', '1010', '1010', '1010', '1010', '1010', '1010', 1010, '2010-10-10 00:00:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `conta`
--

CREATE TABLE `conta` (
  `id_conta` int(11) NOT NULL,
  `agencia` int(11) DEFAULT NULL,
  `numero_conta` int(11) DEFAULT NULL,
  `saldo` double DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `conta`
--

INSERT INTO `conta` (`id_conta`, `agencia`, `numero_conta`, `saldo`, `id_cliente`) VALUES
(1, 123, 123, 123, NULL);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `candidato`
--
ALTER TABLE `candidato`
  ADD PRIMARY KEY (`idCandidato`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Índices para tabela `conta`
--
ALTER TABLE `conta`
  ADD PRIMARY KEY (`id_conta`),
  ADD KEY `id_cliente` (`id_cliente`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `candidato`
--
ALTER TABLE `candidato`
  MODIFY `idCandidato` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `conta`
--
ALTER TABLE `conta`
  MODIFY `id_conta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `conta`
--
ALTER TABLE `conta`
  ADD CONSTRAINT `conta_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
