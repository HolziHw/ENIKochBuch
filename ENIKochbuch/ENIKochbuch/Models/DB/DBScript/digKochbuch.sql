create database Eni_Kochbuch collate utf8_general_ci;
use Eni_Kochbuch;


create table rezepte(
	id int not null auto_increment,
    rezeptName varchar(100) not null,
    Beschreibung varchar(10000) not null,
    Klassifikation int not null,
    portionen int not null,
    Schwierigkeit int not null,
    saison int not null,
    Gang int not null,
    constraint id_PK primary key(id)
)engine=InnoDB;

select * from rezepte;
