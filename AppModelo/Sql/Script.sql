CREATE DATABASE DesenvolvimentoWeb;

USE DesenvolvimentoWeb;

CREATE TABLE usuarios
(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nomecompleto VARCHAR(100) NOT NULL,
	usuario VARCHAR(100) NOT NULL UNIQUE,
	senha VARCHAR(100) NOT NULL
);

INSERT INTO dbo.usuarios (nomecompleto, usuario, senha) VALUES ('Administrador do Sistema', 'admin', HASHBYTES('SHA1', 'admin'));