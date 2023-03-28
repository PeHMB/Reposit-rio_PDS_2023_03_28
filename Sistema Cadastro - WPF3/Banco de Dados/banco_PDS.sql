create database banco_PDS;
use banco_PDS;

create table pessoa(
id_pes int primary key auto_increment not null,
telefone_pes varchar(300),
cpf_pes varchar(300),
sexo_pes varchar(300)
);


select * from pessoa;