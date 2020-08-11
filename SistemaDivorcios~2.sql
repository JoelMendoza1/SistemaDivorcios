create table Usuario
(CIUsuario varchar(10) primary key null,
NombreUsu varchar(30)not null,
ApellidoUsu varchar(30) not null,
Usuario varchar(50) not null,
EmailUsu varchar(50) not null,
PasswordUsu varchar(50) not null)

create table Administrador
(CIAdmin varchar(10) primary key null,
NombreAdmin varchar(30)not null,
ApellidoAdmin varchar(30) not null,
UsuarioAdmin varchar(50) not null,
EmailAdmin varchar(50) not null,
PasswordAdmin varchar(50) not null)

insert into Administrador values ('1','nomAdmin','ApeAdmin','admin','admin@hotmail.com','123')

select*from Administrador
SELECT * FROM Usuario
 select Usuario, PasswordUsu from Usuario where Usuario = :usuario AND PasswordUsu= :password
insert into Usuario values ('1','nomUsu','apeUsu','usu1','usu1@hotmail.com','123')
insert into Usuario values ('2','nomUsu2','apeUsu2','usu2','usu2@hotmail.com','123')
insert into Usuario values ('1720804432','Joel','Mendoza','joel','joel@hotmail.com','123')

use SistemaDivorcios
select Usuario, PasswordUsu from Usuario

/*
create procedure VerUsuario
as 
begin select Usuario, PasswordUsu from Usuario

create or replace procedure insertarRegistroCivil (nom
exec VerUsuario
*/
create or remplace procedure logingUsuario (
v_usuario in varchar, 
v_password in varchar
)
is
begin select Usuario, PasswordUsu from Usuario where Usuario = v_usuario AND PasswordUsu= v_password;
end;
/*create or replace procedure insertarregistrocivil (nom in VARCHAR, cont in Varchar)
as
begin insert RegistroCivil (oficinaregistros ,usoinec ,oficina ,fechauso ,provinciauso ,cantonuso ,parroquiauso ,fechamatrimonio ,actainscripcion ,numerohijos ,concapitulacion) values (oficinaregistros ,usoinec ,oficina ,fechauso ,provinciauso ,cantonuso ,parroquiauso ,fechamatrimonio ,actainscripcion ,numerohijos ,concapitulacion);
*/

create table PROVINCIAS(
id_prov int not null,
nom_prov varchar(20) not null,
constraint PK_PROVINCIAS primary key (id_prov)
)
/*INSERTAR DATOS EN LA TABLA PROVINCIA*/
insert into PROVINCIAS values(1,'Esmeraldas')
insert into PROVINCIAS values(2,'Manabi')
insert into PROVINCIAS values(3,'Guayas')
insert into PROVINCIAS values(4,'Los Rios')
insert into PROVINCIAS values(5,'El Oro')
insert into PROVINCIAS values(6,'Santa Elena')
insert into PROVINCIAS values(7,'Carchi')
insert into PROVINCIAS values(8,'Imbabura')
insert into PROVINCIAS values(9,'Pichincha')
insert into PROVINCIAS values(10,'Cotopaxi')
insert into PROVINCIAS values(11,'Tungurahua')
insert into PROVINCIAS values(12,'Bolivar')
insert into PROVINCIAS values(13,'Chimborazo')
insert into PROVINCIAS values(14,'Cañar')
insert into PROVINCIAS values(15,'Azuay')
insert into PROVINCIAS values(16,'Carchi')
insert into PROVINCIAS values(17,'Loja')
insert into PROVINCIAS values(18,'Sto Domingo')
insert into PROVINCIAS values(19,'Sucumbios')
insert into PROVINCIAS values(20,'Napo')
insert into PROVINCIAS values(21,'Pastaza')
insert into PROVINCIAS values(22,'Orellana')
insert into PROVINCIAS values(23,'Morona Santiago')
insert into PROVINCIAS values(24,'Zamora Chimchipe')
insert into PROVINCIAS values(25,'Galapagos')
create table CANTONES(
id_cantones int not null,
id_prov int,
nom_canton varchar(20) not null,
primary key (id_cantones),
FOREIGN KEY (id_prov) REFERENCES provincias(id_prov)
)
/*AZUAY*/
insert into CANTONES values(1,15,'CUENCA')
insert into CANTONES values(2,15,'GIRÓN')
insert into CANTONES values(3,15,'GUALACEO')
insert into CANTONES values(4,15,'NABÓN')
insert into CANTONES values(5,15,'PAUTE')
insert into CANTONES values(6,15,'PUCARÁ')
insert into CANTONES values(7,15,'SAN FERNANDO')
insert into CANTONES values(8,15,'SANTA ISABEL')
insert into CANTONES values(9,15,'SIGSIG')	
insert into CANTONES values(10,15,'OÑA')
insert into CANTONES values(11,15,'CHORDELEG')	
insert into CANTONES values(12,15,'EL PAN')
insert into CANTONES values(13,15,'SEVILLA DE ORO')	
insert into CANTONES values(14,15,'GUACHAPALA')
insert into CANTONES values(15,15,'CAMILOPONCEENRÍQUEZ')


/*BOLIBAR*/
insert into CANTONES values(16,12,'GUARANDA')
insert into CANTONES values(17,12,'CHILLANES')
insert into CANTONES values(18,12,'CHIMBO')
insert into CANTONES values(19,12,'ECHEANDÍA')
insert into CANTONES values(20,12,'SAN MIGUEL')
insert into CANTONES values(21,12,'CALUMA')
insert into CANTONES values(22,12,'LAS NAVES')

/*CAÑAR*/
insert into CANTONES values(23,14,'AZOGUES')
insert into CANTONES values(24,14,'BIBLIÁN')
insert into CANTONES values(25,14,'CAÑAR')
insert into CANTONES values(26,14,'LA TRONCAL')
insert into CANTONES values(27,14,'EL TAMBO')
insert into CANTONES values(28,14,'DÉLEG')
insert into CANTONES values(29,14,'SUSCAL')

/*CARCHI7*/
insert into CANTONES values(30,7,'TULCÁN')
insert into CANTONES values(31,7,'BOLÍVAR')
insert into CANTONES values(32,7,'ESPEJO')
insert into CANTONES values(33,7,'MIRA')
insert into CANTONES values(34,7,'MONTÚFAR')
insert into CANTONES values(35,7,'SAN PEDRO DE HUACA')

/*COTOPAXI*/
insert into CANTONES values(36,10,'LATACUNGA')
insert into CANTONES values(37,10,'LA MANÁ')
insert into CANTONES values(38,10,'PANGUA')
insert into CANTONES values(39,10,'PUJILÍ')
insert into CANTONES values(40,10,'SALCEDO')
insert into CANTONES values(41,10,'SAQUISILÍ')
insert into CANTONES values(42,10,'SIGCHOS')

/*CHIMBORAZO*/
insert into CANTONES values(43,13,'RIOBAMBA')
insert into CANTONES values(44,13,'ALAUSÍ')
insert into CANTONES values(45,13,'COLTA')
insert into CANTONES values(46,13,'CHAMBO')
insert into CANTONES values(47,13,'CHUNCHI')
insert into CANTONES values(48,13,'GUAMOTE')
insert into CANTONES values(49,13,'GUANO')
insert into CANTONES values(50,13,'PALLATANGA')
insert into CANTONES values(51,13,'PENIPE')
insert into CANTONES values(53,13,'CUMANDÁ')

/*EL ORO*/
insert into CANTONES values(54,5,'MACHALA')
insert into CANTONES values(55,5,'ARENILLAS')
insert into CANTONES values(56,5,'ATAHUALPA')
insert into CANTONES values(57,5,'BALSAS')
insert into CANTONES values(58,5,'CHILLA')
insert into CANTONES values(59,5,'EL GUABO')
insert into CANTONES values(60,5,'HUAQUILLAS')
insert into CANTONES values(61,5,'MARCABELÍ')
insert into CANTONES values(62,5,'PASAJE')
insert into CANTONES values(63,5,'PIÑAS')
insert into CANTONES values(64,5,'PORTOVELO')
insert into CANTONES values(65,5,'SANTA ROSA')
insert into CANTONES values(66,5,'ZARUMA')
insert into CANTONES values(67,5,'LAS LAJAS')
/*ESMERALDAS*/
insert into CANTONES values(68,1,'ESMERALDAS')
insert into CANTONES values(69,1,'ELOY ALFARO')
insert into CANTONES values(70,1,'MUISNE')
insert into CANTONES values(71,1,'QUININDÉ')
insert into CANTONES values(72,1,'SAN LORENZO')
insert into CANTONES values(73,1,'ATACAMES')
insert into CANTONES values(74,1,'RÍOVERDE')
/*GUAYAS*/
insert into CANTONES values(75,3,'GUAYAQUIL')
insert into CANTONES values(76,3,'ALFREDOBAQUERIZOM.')
insert into CANTONES values(77,3,'BALAO')
insert into CANTONES values(78,3,'BALZAR')
insert into CANTONES values(79,3,'COLIMES')
INSERT INTO CANTONES VALUES(80,3,'DAULE')
insert into CANTONES values(81,3,'DURÁN')
insert into CANTONES values(82,3,'EL EMPALME')
insert into CANTONES values(83,3,'EL TRIUNFO')
insert into CANTONES values(84,3,'MILAGRO')
insert into CANTONES values(85,3,'NARANJAL')
insert into CANTONES values(86,3,'NARANJITO')
insert into CANTONES values(87,3,'PALESTINA')
insert into CANTONES values(88,3,'PEDRO CARBO')
insert into CANTONES values(89,3,'*SALINAS')
insert into CANTONES values(90,3,'SAMBORONDÓN')
insert into CANTONES values(91,3,'*SANTA ELENA')
insert into CANTONES values(92,3,'SANTA LUCÍA')
insert into CANTONES values(93,3,'SALITRE')
insert into CANTONES values(94,3,'S.JACINTO YAGUACHI')
insert into CANTONES values(95,3,'PLAYAS')
insert into CANTONES values(96,3,'SIMÓN BOLÍVAR')
insert into CANTONES values(97,3,'COR.MARCELINOMARIDUE')
insert into CANTONES values(98,3,'LOMAS SARGENTILLO')
insert into CANTONES values(99,3,'NOBOL')
insert into CANTONES values(100,3,'*LA LIBERTAD')
insert into CANTONES values(101,3,'GEN. ANTONIO ELIZALD')
insert into CANTONES values(102,3,'ISIDRO AYORA')
insert into CANTONES values(103,3,'ISIDRO AYORA')
/*IMBABURA*/
insert into CANTONES values(104,8,'IBARRA')
insert into CANTONES values(105,8,'ANTONIO ANTE')
insert into CANTONES values(106,8,'COTACACHI')
insert into CANTONES values(107,8,'OTAVALO')
insert into CANTONES values(108,8,'PIMAMPIRO')
insert into CANTONES values(109,8,'S.MIGUEL URCUQUÍ')
/*LOJA*/
insert into CANTONES values(110,17,'LOJA ')
insert into CANTONES values(111,17,'CALVAS ')
insert into CANTONES values(112,17,'CATAMAYO ')
insert into CANTONES values(113,17,'CELICA ')
insert into CANTONES values(114,17,'CHAGUARPAMBA') 
insert into CANTONES values(115,17,'ESPÍNDOLA ')
insert into CANTONES values(116,17,'GONZANAMÁ') 
insert into CANTONES values(117,17,'MACARÁ')
insert into CANTONES values(118,17,'PALTAS')
insert into CANTONES values(119,17,'PUYANGO')
insert into CANTONES values(120,17,'SARAGURO')
insert into CANTONES values(121,17,'SOZORANGA')
insert into CANTONES values(122,17,'ZAPOTILLO')
insert into CANTONES values(123,17,'PINDAL')
insert into CANTONES values(124,17,'QUILANGA')
insert into CANTONES values(125,17,'OLMEDO')
/*LOS RIOS*/
insert into CANTONES values(126,4,'BABAHOYO') 
insert into CANTONES values(127,4,'BABA ')
insert into CANTONES values(128,4,'MONTALVO ')
insert into CANTONES values(129,4,'PUEBLOVIEJO')
insert into CANTONES values(130,4,'QUEVEDO ')
insert into CANTONES values(131,4,'URDANETA')
insert into CANTONES values(132,4,'VENTANAS')
insert into CANTONES values(133,4,'VINCES')
insert into CANTONES values(134,4,'PALENQUE')
insert into CANTONES values(135,4,'BUENA FÉ')
insert into CANTONES values(136,4,'VALENCIA')
insert into CANTONES values(137,4,'MOCACHE')
insert into CANTONES values(138,4,'QUINSALOMA')

/*MANABI*/
insert into CANTONES values(139,2,'PORTOVIEJO') 
insert into CANTONES values(140,2,'BOLÍVAR') 
insert into CANTONES values(141,2,'CHONE') 
insert into CANTONES values(142,2,'EL CARMEN') 
insert into CANTONES values(143,2,'FLAVIO ALFARO') 
insert into CANTONES values(144,2,'JIPIJAPA') 
insert into CANTONES values(145,2,'JUNÍN') 
insert into CANTONES values(146,2,'MANTA') 
insert into CANTONES values(147,2,'MONTECRISTI') 
insert into CANTONES values(148,2,'PAJÁN') 
insert into CANTONES values(149,2,'PICHINCHA') 
insert into CANTONES values(150,2,'ROCAFUERTE')
insert into CANTONES values(151,2,'SANTA ANA')
insert into CANTONES values(152,2,'SUCRE')
insert into CANTONES values(153,2,'TOSAGUA')
insert into CANTONES values(154,2,'24 DE MAYO')
insert into CANTONES values(155,2,'PEDERNALES')
insert into CANTONES values(156,2,'OLMEDO')
insert into CANTONES values(157,2,'PUERTO LÓPEZ')
insert into CANTONES values(158,2,'JAMA')
insert into CANTONES values(159,2,'JARAMIJÓ')
insert into CANTONES values(160,2,'SAN VICENTE')
/*MORONA SANTIAGO*/
insert into CANTONES values(161,23,'MORONA')
insert into CANTONES values(162,23,'GUALAQUIZA')
insert into CANTONES values(163,23,'LIMÓN INDANZA') 
insert into CANTONES values(164,23,'PALORA')
insert into CANTONES values(165,23,'SANTIAGO')
insert into CANTONES values(166,23,'SUCÚA')
insert into CANTONES values(167,23,'HUAMBOYA')
insert into CANTONES values(168,23,'SAN JUAN BOSCO')
insert into CANTONES values(169,23,'TAISHA')
insert into CANTONES values(170,23,'LOGROÑO')
insert into CANTONES values(171,23,'PABLO SEXTO')
insert into CANTONES values(172,23,'TIWINTZA')
/*NAPO*/
insert into CANTONES values(173,20,'TENA')
insert into CANTONES values(174,20,'*AGUARICO')
insert into CANTONES values(175,20,'ARCHIDONA')
insert into CANTONES values(176,20,'EL CHACO')
insert into CANTONES values(177,20,'*JOYA DE SACHAS')
insert into CANTONES values(178,20,'*ORELLANA')
insert into CANTONES values(179,20,'QUIJOS')
insert into CANTONES values(180,20,'*LORETO')
insert into CANTONES values(181,20,'CARLOS AROSEMENA T.')

/*PASTAZA*/
insert into CANTONES values(182,21,'PASTAZA')
insert into CANTONES values(183,21,'MERA')
insert into CANTONES values(184,21,'SANTA CLARA')
insert into CANTONES values(185,21,'ARAJUNO')

/*PICHINCHA*/
insert into CANTONES values(186,9,'QUITO')
insert into CANTONES values(187,9,'CAYAMBE')
insert into CANTONES values(188,9,'MEJÍA')
insert into CANTONES values(189,9,'PEDRO MONCAYO')
insert into CANTONES values(190,9,'RUMIÑAHUI')
insert into CANTONES values(191,9,'*SANTO DOMINGO')
insert into CANTONES values(192,9,'SAN MIGUEL DE LOS BANCOS')
insert into CANTONES values(193,9,'PEDRO VICENTE MALDONADO')
insert into CANTONES values(194,9,'PUERTO QUITO')

/*TUGURAHUA*/
insert into CANTONES values(195,11,'AMBATO')
insert into CANTONES values(196,11,'BAÑOS')
insert into CANTONES values(197,11,'CEVALLOS')
insert into CANTONES values(198,11,'MOCHA')
insert into CANTONES values(199,11,'PATATE')
insert into CANTONES values(200,11,'QUERO')
insert into CANTONES values(201,11,'S. PEDRO PELILEO')
insert into CANTONES values(202,11,'SANTIAGO DE PÍLLARO')
insert into CANTONES values(203,11,'TISALEO')
/*ZAMORA CHINCHIPE*/
insert into CANTONES values(204,24,'ZAMORA')
insert into CANTONES values(205,24,'CHINCHIPE')
insert into CANTONES values(206,24,'NANGARITZA')
insert into CANTONES values(207,24,'YACUAMBÍ')
insert into CANTONES values(208,24,'YANTZAZA')
insert into CANTONES values(209,24,'EL PANGUI')
insert into CANTONES values(210,24,'CENTINELA CÓNDOR')
insert into CANTONES values(211,24,'PALANDA')
insert into CANTONES values(212,24,'PAQUISHA')
/*GALAPAGOS*/
insert into CANTONES values(213,25,'SAN CRISTÓBAL')
insert into CANTONES values(214,25,'ISABELA')
insert into CANTONES values(215,25,'SANTA CRUZ')
/*sucumbios*/
insert into CANTONES values(216,19,'LAGO AGRIO')
insert into CANTONES values(217,19,'GONZALO PIZARRO')
insert into CANTONES values(218,19,'PUTUMAYO')
insert into CANTONES values(219,19,'SHUSHUFINDI')
insert into CANTONES values(220,19,'SUCUMBÍOS')
insert into CANTONES values(221,19,'CASCALES')
insert into CANTONES values(223,19,'CUYABENO')

/*ORELLANA*/
insert into CANTONES values(224,22,'ORELLANA')
insert into CANTONES values(225,22,'AGUARICO')
insert into CANTONES values(226,22,'JOYA SACHAS')
insert into CANTONES values(227,22,'LORETO')
/*SANTO DOMINGO*/
insert into CANTONES values(228,18,'SANTO DOMINGO')
insert into CANTONES values(229,18,'LA CONCORDIA')
/*SANTA ELENA*/
insert into CANTONES values(230,6,'SANTA ELENA')
insert into CANTONES values(231,6,'LA LIBERTAD')
insert into CANTONES values(232,6,'SALINAS')

select nom_prov from provincias
select nom_prov,nom_canton from Cantones,provincias where cantones.id_prov=provincias.id_prov 

select Cantones.nom_canton from Cantones where id_prov=1
/*
create table PARROQUIAS(
id_parroquias int not null,
id_cantones int,
nom_parroquia varchar(50) not null,
 primary key (id_parroquias),
 foreign key (id_cantones) references CANTONES(id_cantones))
 */
 
 create table CABECERA(
 acta_incripcion int not null,
 id_prov varchar (50)not null,
 id_canton varchar(50) null,
 fecha_incrip varchar(50) not null,
 fecha_sentencia varchar(50)not null,
 fecha_matrim varchar(50) not null,
 capitulacion varchar(2)null,
 causa_divorcio varchar(50)null,
 duracion_años numeric(3)null,
 primary key (acta_incripcion))
 
 insert into CABECERA values (:actaIncripcion,:provincia,:canton,:fechaIncripcion,:fechaSentencia,:fechaMatrimonio,:capitulacion,:causaDiv,:duracion)
 
create table DIVORCIADO(
cedula varchar(10) not null,
nacionalidad varchar(50) not null,
fechaNaci varchar(50) not null,
edad numeric(3) not null,
numHijos numeric(3) not null,
idEtnia varchar(50) not null,
instruccion varchar(50) not null,
id_prov varchar(50) not null,
id_canton varchar(50) not null,
acta_incripcion int not null,
primary key (cedula))
insert into DIVORCIADO values(:cedula,:nacionalidad,:fechaNaci,:edad,:numHijos,:idEtnia,:instruccion,:prov,:canton)
 
create table DIVORCIADA(
cedula varchar(10) not null,
nacionalidad varchar(50) not null,
fechaNaci varchar(50) not null,
edad numeric(3) not null,
numHijos numeric(3) not null,
idEtnia varchar(50) not null,
instruccion varchar(50) not null,
id_prov int not null,
id_canton int not null,
id_parroquia int not null,
acta_incripcion int not null,
primary key (cedula))
select*from cabecera
delete from divorciado
 select*from divorciada
 
 CREATE TABLE auditoria(
 id_auditoria int,
  sentencia varchar(10),
  tabla varchar(20),
  clave varchar(50),
  primary key (id_auditoria))
GO
create table Auditoria1
(Sentencia varchar(10),
Usuario varchar(30),
NombreTabla varchar(20),
ClaveRegistro int,
FechaCambio date)

--Creación del trigger para almacenar los cambios
create trigger InsertarAuditorias on Cabecera
for insert, update, delete
as
declare Sentencia varchar(10), 
Usuario varchar(30),
NombreTabla varchar(20),
id int,
FechaCambio date
select NombreTabla='CABECERA'
select Usuario= CURRENT_USER,
FechaCambio= getdate()
if (select count(*) from inserted) !=0
begin
	select id=ProductID from inserted
	if(select count(*) from deleted) !=0
		select Sentencia='update'
	else
		select Sentencia='insert'
end
else
begin
	select Sentencia='delete'
	select id=	ProductID from deleted
end
insert into auditoria1 values (Sentencia,Usuario,NombreTabla,id, FechaCambio)


