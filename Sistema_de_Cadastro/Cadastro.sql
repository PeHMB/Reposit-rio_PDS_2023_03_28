create database app_contato_bd;
use app_contato_bd;
create table contato(
id_con int not null primary key auto_increment,
nome_con varchar(100),
cpf_con varchar(100),
telefone_con varchar(1000),
sexo_con varchar(1000),
data_nasc_cont date
);
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (1, 'Kendall', '179.930.069-90', '(42) 923446561', 'Masculino', '2023-01-14');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (2, 'Leonora', '524.234.361-60', '(46) 953584479', 'Feminino', '2022-03-03');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (3, 'Fran', '989.484.255-16', '(24) 952947884', 'Feminino', '2022-06-14');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (4, 'Terrie', '475.841.945-66', '(94) 940862067', 'Feminino', '2022-09-10');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (5, 'Yolande', '138.892.472-94', '(05) 982187571', 'Feminino', '2022-05-09');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (6, 'Sven', '337.822.236-28', '(28) 919112048', 'Masculino', '2023-01-06');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (7, 'Fawnia', '619.529.734-53', '(30) 941468960', 'Feminino', '2022-03-29');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (8, 'Reuben', '931.266.911-41', '(68) 992083913', 'Masculino', '2022-03-10');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (9, 'Terrell', '011.076.601-26', '(43) 958273240', 'Masculino', '2022-04-07');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (10, 'Chip', '702.977.610-55', '(75) 931323280', 'Masculino', '2022-12-16');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (11, 'Madel', '957.753.839-44', '(56) 976276351', 'Feminino', '2023-02-02');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (12, 'Blondell', '773.854.669-14', '(64) 965470729', 'Masculino', '2022-11-30');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (13, 'Baudoin', '152.568.904-86', '(12) 959121858', 'Masculino', '2022-05-10');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (14, 'Carmelle', '744.975.190-81', '(06) 978286835', 'Feminino', '2022-12-31');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (15, 'Sax', '454.187.597-45', '(29) 910542530', 'Masculino', '2022-05-21');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (16, 'Vladimir', '115.241.356-96', '(37) 968774938', 'Masculino', '2022-03-14');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (17, 'Dorree', '259.339.068-38', '(33) 994379902', 'Feminino', '2022-08-31');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (18, 'Shelby', '685.442.839-84', '(38) 930115242', 'Masculino', '2022-08-30');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (19, 'Wilfrid', '606.886.019-66', '(57) 984189652', 'Masculino', '2022-04-23');
insert into Contato (id_con, nome_con, cpf_con, telefone_con, sexo_con, data_nasc_cont) values (20, 'Sela', '545.233.643-91', '(63) 981800255', 'Feminino', '2022-12-24');

UPDATE Contato SET cpf_con = replace( replace(cpf_con , "." , ""), "-", "");


DELETE FROM contato WHERE id_con >20;
select * from contato;