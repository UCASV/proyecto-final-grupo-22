create database proyecto_final;
use proyecto_final;
set lc_time_names='en_US';

create table datevaccinesdatevaccines(
id int primary key auto_increment,
Pacientid double,
foreign key (Pacientid) references pacient (DUI),
date date,
Cabin1id int,
foreign key	(Cabin1idtipoemployees) references cabin (id)
);

create table tipomployees(
id int primary key auto_increment,
typetypevaccines varchar (50)

);

create table typevaccinescabins(
id int primary key auto_increment,
type_vaccine varchar (50)
);

create table cabins(
id int primary key auto_increment,
index_cabin_1id int,
foreign key (index_cabin_1id) references index_cabins(id),
adress varchar (50),
phone varchar (50),
email varchar (50),
dateTime date,
employeeid int,
foreign key (employeeid) references employees(id)
);

create table dayvaccinesdayvaccines(
id int primary key auto_increment,
Pacientid int,
foreign key (Pacientid) references pacients(id),
cabinid int,
foreign key (cabinid) references index_cabins(id),
sideid int,
foreign key (sideid) references sideeffects (id),
TypeVaccineid int,
foreign key (TypeVaccineid) references typevaccines (id),
Dosisid int,
foreign key (Dosisid) references dosidiseasess(id)
);

create table disease (
id int primary key auto_increment,
dosissideeffectsdisease varchar (50)
);
create table dosis(
id int primary key auto_increment,
dosis varchar (50)
);

create table side_effects (
id int primary key auto_increment,
sideemployees varchar (50)
);

create table employees (
id int primary key auto_increment,
name varchar (50),
email varchar (50),
adress varchar (50),
TipoId int,
foreign key (TipoId) references tipoemployees(id),
user varchar (50),
password varchar (50)
);




create table pacients (
id int primary key auto_increment,
DUI varchar (50),
name varchar (50),
adress varchar (50),
phone varchar (50),
email varchar (50),
Diseaseid int, 
foreign key (Diseaseid) references disease(id),
Institutionid double,
foreign key (Institutionid) references institutionobjectives(id)
);

create table insitutionobjectives (
id int primary key,
Institution varchar (50)


);

create table index_cabins (
id int primary key auto_increment,
index varchar (50)
);
