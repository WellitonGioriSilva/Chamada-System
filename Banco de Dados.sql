create database chamada_bd;
use chamada_bd;

create table Aluno(
id_alu int primary key auto_increment,
nome_alu varchar(150)
);

create table Turma(
id_tur int primary key auto_increment,
curso_tur varchar(150),
periodo_tur varchar(150)
);

create table Aula(
id_aul int primary key auto_increment, 
nome_aul varchar(150),
data_aul date,
id_alu int,
FOREIGN KEY (id_alu) REFERENCES Aluno (id_alu)
);

SELECT * FROM Turma;