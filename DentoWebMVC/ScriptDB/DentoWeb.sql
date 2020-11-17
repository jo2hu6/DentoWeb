create table [Cliente](
    [idCliente] INT IDENTITY PRIMARY KEY ,
    [codigo] VARCHAR(50),
    [nombres] VARCHAR(50),
    [apellidos] VARCHAR(50),
    [dni] NVARCHAR(8),
    [fechaNac] DATE,
    [correo] varchar(100),
    [telefono] varchar(20),
    [usuario] varchar(50),
    [passwd] varchar(200)
)

create table Doctor(
    idDoctor int IDENTITY PRIMARY KEY,
    nombres varchar(50),
    apellidos varchar(50),
    codigoCol varchar(50),
    casaEstudio varchar(100),
    titulo varchar(100),
    dni nvarchar(8),
    correo varchar(100),
    telefono varchar(20),
    usuario VARCHAR(50),
    passwd  VARCHAR(200)
)

insert into Doctor values(
    'Pedro','Navaja','0123456',
    'Universidad Privada del Norte',
    'Rehabilitacion oral',
    '12345678','navaja@mail.com',
    '987456123','navaja','ky0MGWs71WJ/g1qG1VjHXZBKmXsOeQslnbHr2WoMLG0='
)

insert into Doctor values(
    'Karl','Xd','065498',
    'Universidad Privada del Norte',
    'Cirujano dentista',
    '12387456','karl@mail.com',
    '123456788','karl','karl'
)

insert into Doctor values(
    'Jaime','Abc','012322',
    'Universidad Nacional de Cajamarca',
    'Estética dental',
    '22222222','jaime@mail.com',
    '982231223','jaime','jaime'
)

create table Cita(
    idCita int IDENTITY PRIMARY KEY,
    fecha DATE,
    idHorario int,
    estado VARCHAR(10),
    idCliente int,
    idDoctor int,
    monto DECIMAL(8,4)
)

create table Horario(
    idHorario int PRIMARY KEY IDENTITY,
    horaInicio VARCHAR(10),
    horaFin VARCHAR(10),
)

insert into Horario VALUES(
    '08:00 AM','10:00 AM'
)
insert into Horario VALUES(
    '10:00 AM','12:00 AM'
)
insert into Horario VALUES(
    '02:00 PM','04:00 PM'
)

insert into Horario VALUES(
    '04:00 PM','06:00 PM'
)

insert into Horario VALUES(
    '06:00 PM','08:00 PM'
)

SELECT * FROM Horario
SELECT * FROM Doctor

UPDATE Doctor set passwd='ky0MGWs71WJ/g1qG1VjHXZBKmXsOeQslnbHr2WoMLG0='
WHERE idDoctor != 1;