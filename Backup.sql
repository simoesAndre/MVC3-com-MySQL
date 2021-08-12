-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29-Out-2020 às 21:09
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `agencia`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `pacote`
--

CREATE TABLE `pacote` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `origem` varchar(100) DEFAULT NULL,
  `destino` varchar(100) DEFAULT NULL,
  `atrativos` text DEFAULT NULL,
  `saida` varchar(100) DEFAULT NULL,
  `retorno` varchar(100) DEFAULT NULL,
  `usuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pacote`
--

INSERT INTO `pacote` (`id`, `nome`, `origem`, `destino`, `atrativos`, `saida`, `retorno`, `usuario`) VALUES
(1, 'Serra Gaucha', 'Santos', 'Gramado', 'Passeios e café colonial', '04/01/2021', '11/01/2021', 2),
(2, 'Passeio no litoral', 'Porto Alegre', 'Tramandaí', 'Show ao vivo na praia', '02/02/2021', '06/02/2021', 2),
(4, 'Ida ao Beto Carrero World', 'São Leopoldo', 'Penha', 'Venha se divertir no maior parque da América Latina. São diversas atrações e brinquedos para curtir com a família e amigos.', '15/12/2020', '19/12/2020', 1),
(5, 'Cicloturismo', 'Novo Hamburgo', 'Rolante', 'Passeio ciclístico por diversas regiões do Vale dos Sinos e Vale do Paranhana.', '20/11/2020', '27/11/2020', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `dataNascimento` varchar(10) NOT NULL,
  `login` varchar(100) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `tipo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id`, `nome`, `dataNascimento`, `login`, `senha`, `tipo`) VALUES
(1, 'Administrador', '01/12/2000', 'admin', '12345', 1),
(2, 'Fulano de tal', '23/09/1998', 'Fulano', '1234', 2),
(5, 'Filomena', '02/02/2010', 'Filo', '345', 2);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `pacote`
--
ALTER TABLE `pacote`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuario` (`usuario`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `pacote`
--
ALTER TABLE `pacote`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `pacote`
--
ALTER TABLE `pacote`
  ADD CONSTRAINT `pacote_ibfk_1` FOREIGN KEY (`usuario`) REFERENCES `usuario` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
