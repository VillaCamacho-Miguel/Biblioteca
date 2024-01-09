go
create database biblioteca
go
use BIBLIOTECA

go
create table Libro
(
ISBN char(13) not null,
NombreLibro varchar(30),
Existencia int,
consulta char(1),
TipoUsuario char(1),
idAutor int,
IdEditorial int
)
go
create table Prestamo 
(
ClavePrestamo char(5) not null,
ISBN char(13),
idUsuario int,
fechaDevolucion datetime,
Consulta char(1),

)
--go
--create table Devolucion(
--idDevolucion char(10) not null,
--ClavePrestamo char(5),
--fechaDevolucion datetime
--)
go
create table Usuario
(
idUsuario int identity not null,
nombreUsuario varchar(40),
tipoUsuario char(1)
)
go
create table Autor
(
idAutor int identity not null,
NombreAutor varchar(25),
Nacionalidad varchar(30)
)
go
create table Editorial
(
IdEditorial int identity not null,
nombreEditorial varchar(25),
telefono char(10),
direccion varchar(60),
ciudad varchar(40)
)

go
-- LAVES PRIMARIAS
alter table Editorial add constraint pk_editorial primary key (idEditorial);
--alter table Devolucion add constraint pk_devolucion primary key (idDevolucion);
alter table Usuario add constraint pk_Usuario primary key (idUsuario);
alter table Autor add constraint pk_autores primary key (idAutor);
alter table Libro add constraint pk_libro primary key (ISBN);
alter table Prestamo add constraint pk_prestamo primary key(ClavePrestamo);
go

-- LLAVES FORANEAS
alter table Prestamo Add constraint fk_usuario_prestamo foreign key (idUsuario) references Usuario(idUsuario);



--alter table Devolucion add constraint fk_prestamo_devolucion foreign key (ClavePrestamo) references prestamo(clavePrestamo);
alter table Prestamo add constraint fk_libro_prestamo foreign key (ISBN) references Libro(ISBN);
alter table Libro add constraint fk_Editorial_libro foreign key (idEditorial) references Editorial (idEditorial);
alter table Libro add constraint fk_Autores_libro foreign key (idAutor) references Autor(idAutor);
go
-- INSERCIÓN DE VALROES
insert into Usuario values
('MIGUEL ANTONIO VILLA CAMACHO', 0),
('CESAR ALFREDO SANCHEZ BELTRAN', 1),
('NOE MEDINA NUÑEZ', 0),
('GLORIA EKATERINE PERALTA PEÑUÑURI', 1)

insert into Editorial values
( 'ALIANZA', '6677233943', ' S.A. C/ Juan Ignacio Luca de Tena, 15 28027', 'Madrid'),
( 'ARIEL','3493496703',' Av. Diagonal, 662-664 08034', 'Barcelona')
insert into Autor values
('PETER HANDKE', 'Austríaca'),
('KEN LIU', 'China'),
('ALBERTO MANGUEL', 'Argentino'),
('PETER SINGER', 'Australiano')

insert into Libro values
('1','LA SEGUNDA ESPADA',	20,1,0,'1','1'),
('2','LA CHICA OCULTA',		20,1,0,'2','1'),
('3','LEER IMAGENES',		20,0,1,'3','2'),
('4','EL ASNO DE ORO',		20,1,0,'4','2');

insert into prestamo values
('1','1','1','2023-10-11',0),
('2','2','1','2023-10-1',1),
('3','1','2','2023-10-11',0)
;

go


-- ============================================== PROCEDIMIENTOS ALMACENADOS PARA LIBROS ==============================================
-- procedimiento para verificar un conflicto con las llaves heredadas
create procedure SP_ValidaEliminacionLibro
@isbn char(13),
@existeConflicto int output
as
if exists (select ISBN from Prestamo where @isbn = ISBN)
begin
set @existeConflicto = 1
end
else
begin
set @existeConflicto = 0
end
go
--consulta individual
create procedure SP_ObtenDatoIndividual
@isbn char(13)
as
select ISBN as 'CLAVE', NombreLibro as 'NOMBRE DEL LIBRO', Existencia 'EXISTENCIA',
 case when consulta = 1 then 'Interno' else 'Externo' end as 'CONSULTA', 
 case 
 when TipoUsuario = 0 then 'Alumno'
 when tipoUsuario = 1 then 'Maestro'
 else 'Alumnos y Maestros' end AS 'TIPO DE USUARIO',
  a.NombreAutor 'AUTOR',  e.nombreEditorial 'EDITORIAL'
from Libro l inner join Autor a on l.idAutor = a.idAutor 
inner join Editorial e on e.IdEditorial = l.IdEditorial
where l.isbn = @isbn

go
-- procedimiento para eliminar un libro
create procedure SP_EliminaLibro
@isbn char(13)
as
delete from Libro where ISBN = @isbn 
-- procedimiento para modificar libro
go
create procedure SP_ModificarLibro
@isbn char(13),
@nombrelibro varchar(30),
@existencia int,
@consulta char(1),
@tipousuario char(1),
@idAutor varchar(25),
@idEditorial varchar(25)
as
begin
declare @idautorAux int, @idEditorialAux int
select @idautorAux = idAutor from Autor where NombreAutor = @idAutor;
select @idEditorialAux = IdEditorial from Editorial where nombreEditorial = @idEditorial
update libro set NombreLibro = @nombrelibro, Existencia = @existencia, consulta = @consulta,
 TipoUsuario = @tipousuario, idAutor = @idautorAux, IdEditorial = @idEditorialAux where ISBN = @isbn;
 end

 go
 -- procedimiento para obtener los libros mas populares
 create procedure SP_LibrosMasPopulares
 as
 select l.ISBN 'CLAVE', l.NombreLibro 'NOMBRE LIBRO', count(*) 'PRESTADOS' from prestamo p
 inner join Libro l on l.ISBN = p.ISBN
 group by l.ISBN, l.NombreLibro
 order by count(*) desc

 go
 create procedure SP_VerificaLibroForanea
 @isbn char(13),
 @existe int output
 as
 if exists (select isbn from Prestamo where isbn = @isbn)
 begin
 set @existe = 1;
 end
 else
 begin
 set @existe = 0;
 end

 go
 declare @existe int
 exec SP_VerificaLibroForanea '2', @existe output
 print @existe
 go
 
 CREATE PROC SP_ObtenerLibrosMasExistencia
 as
 select TOP 10 ISBN as 'CLAVE', NombreLibro as 'NOMBRE DEL LIBRO', Existencia 'EXISTENCIA',
 case when consulta = 1 then 'Interno' else 'Externo' end as 'CONSULTA', 
 case 
 when TipoUsuario = 0 then 'Alumno'
 when tipoUsuario = 1 then 'Maestro'
 else 'Alumnos y Maestros' end AS 'TIPO DE USUARIO',
  a.NombreAutor 'AUTOR',  e.nombreEditorial 'EDITORIAL'
from Libro l inner join Autor a on l.idAutor = a.idAutor 
inner join Editorial e on e.IdEditorial = l.IdEditorial
 order by Existencia desc
 go
create proc SP_ObtenerLibros as 
select ISBN as 'CLAVE', NombreLibro as 'NOMBRE DEL LIBRO', Existencia 'EXISTENCIA',
 case when consulta = 1 then 'Interno' else 'Externo' end as 'CONSULTA', 
 case 
 when TipoUsuario = 0 then 'Alumno'
 when tipoUsuario = 1 then 'Maestro'
 else 'Alumnos y Maestros' end AS 'TIPO DE USUARIO',
  a.NombreAutor 'AUTOR',  e.nombreEditorial 'EDITORIAL'
from Libro l inner join Autor a on l.idAutor = a.idAutor 
inner join Editorial e on e.IdEditorial = l.IdEditorial
order by NombreLibro asc 
go
-- obtener libros con un filtro like
create proc SP_ObtenerLibrosFiltro @valor varchar(30) as 
select ISBN as 'CLAVE', NombreLibro as 'NOMBRE DEL LIBRO', Existencia 'EXISTENCIA',
 case when consulta = 1 then 'Interno' else 'Externo' end as 'CONSULTA', 
 case 
 when TipoUsuario = 0 then 'Alumno'
 when tipoUsuario = 1 then 'Maestro'
 else 'Alumnos y Maestros' end AS 'TIPO DE USUARIO',
  a.NombreAutor 'AUTOR',  e.nombreEditorial 'EDITORIAL'
from Libro l inner join Autor a on l.idAutor = a.idAutor 
inner join Editorial e on e.IdEditorial = l.IdEditorial
where nombreLibro like '%'+ @valor+'%'
order by NombreLibro asc 

go

-- LIBRO EXISTE
set Ansi_nulls on
go
set quoted_identifier on
go
create proc SP_ExisteISBN
@valor varchar(13),
@existe char(1) output
as
if exists (select ISBN from Libro where replace(ISBN, ' ','') = replace(@valor,' ',''))
begin
set @existe = 1;
end
else 
begin 
set @existe = 0;
end

go
create proc SP_LibroExiste
@valor varchar(30),
@existe char(1) output
as
if exists (select NombreLibro from Libro where replace(NombreLibro,' ','') = replace(@valor, ' ',''))
begin
set @existe = 1;
end
else 
begin 
set @existe = 0;
end


--declare @existe char(1)
--exec SP_LibroExiste 'La segunda Espada', @existe output
--print @existe


go
-- PROCEDIMIENTO PARA AGREGAR UN LIBRO
create procedure SP_InsertarLibro 
@ISBN char(13),
@NombreLibro varchar(30),
@Existencia int,
@consulta char(1),
@TipoUsuario char(1),
@idAutor int,
@idEditorial int
as
begin
insert into Libro values
(@ISBN, @NombreLibro, @Existencia, @Consulta, @TipoUsuario,@idAutor, @idEditorial)
select @idAutor, @idEditorial
end
go

-- ============================================== PROCEDIMIENTOS ALMACENADOS PARA PRESTAMOS ==============================================
-- procedimiento almacenado para obtener prestamos
create procedure SP_ObtenPrestamos 
as
select
clavePrestamo 'CLAVE', nombreLibro 'LIBRO', nombreUsuario 'USUARIO', fechaDevolucion 'DEVOLUCIÓN', case when p.consulta = 0 then 'INTERNO' else 'EXTERNO' end as 'CONSULTA'
from prestamo p
inner join libro l on l.ISBN = p.ISBN
inner join Usuario u on u.idUsuario = p.idUsuario
-- procedimiento para obtener prestamo filtro
go
create procedure SP_ObtenPrestamosFiltro
@valor varchar(40)
as
select 
clavePrestamo 'CLAVE', nombreLibro 'LIBRO', nombreUsuario 'USUARIO', fechaDevolucion 'DEVOLUCIÓN', p.consulta 'CONSULTA'
from prestamo p
inner join libro l on l.ISBN = p.ISBN
inner join Usuario u on u.idUsuario = p.idUsuario
where u.nombreUsuario like '%'+ @valor +'%' or nombreUsuario like '%'+ @valor +'%';
go
-- procedimiento para verificar que sean los usuarios adecuados
create procedure SP_VerificarUsuarios
@UsuarioLibro char(1),
@UsuarioTipo char(1),
@procede int output
as
if @UsuarioLibro = @UsuarioTipo or @UsuarioLibro = 2
begin
set @procede = 1
end
else
begin
set @procede = 0
end

-- procedimiento almacenado para insertar datos en la tabla prestamos
go
create procedure SP_AgregarPrestamo 
@clavePrestamo char(5),
@nombreLibro varchar(30),
@Usuario varchar(40),
@fechaDevolucion datetime,
@consulta char(1)
as
begin
declare @idUsuario int, @isbn char(13)
select @idUsuario = idUsuario from usuario where nombreUsuario = @usuario
select @isbn = ISBN from libro where nombreLibro = @nombreLibro
insert into prestamo values (@clavePrestamo, @isbn, @idUsuario, @fechaDevolucion,@consulta)
update Libro set Existencia -= 1  where ISBN = @isbn 
end

go
-- restar existencia libro
go
create procedure SP_VerificaExistenciaPrestamo
@nombreLibro varchar(25),
@mensaje int output
as
if((select existencia from libro where replace(nombreLibro,' ','') =replace(@nombreLibro,' ',''))-1)>0
begin 
set @mensaje = 1
end
else
begin
set @mensaje = 0
end
go
declare @mensaje int
exec SP_VerificaExistenciaPrestamo 'El asno de oro' , @mensaje output
print @mensaje
go
-- procedimiento para verificar que la clave no se repita
create proc SP_ClavePrestamoExiste
@valor char(5),
@existe char(1) output
as
if exists (select clavePrestamo from prestamo where replace(clavePrestamo,' ','') = replace(@valor,' ',''))
begin
set @existe = 1;
end
else 
begin 
set @existe = 0;
end
go
-- procedimiento para verificar fecha de devolucion en prestamo
create procedure SP_VerificaFechaDevolucion
@fecha datetime,
@procede int output
as
if @fecha >= GETDATE()
begin
set @procede = 1;
end
else
begin
set @procede = 0;
end
go
-- ============================================== PROCEDIMIENTOS ALMACENADOS PARA EDITORIAL ==============================================
-- obtener editoriales
create procedure SP_ObtenEditoriales
as
select
IdEditorial 'ID', nombreEditorial 'EDITORIAL', telefono 'TELEFONO', direccion 'DIRECCION', ciudad 'CIUDAD' 
from Editorial
go
-- obtener editoriales con filtro
create procedure SP_ObtenEditorialesFiltro
@valor varchar(25)
as
select
IdEditorial 'ID', nombreEditorial 'EDITORIAL', telefono 'TELEFONO', direccion 'DIRECCION', ciudad 'CIUDAD' 
from Editorial
where nombreEditorial like '%'+ @valor +'%'

-- editorial nombre existe
go
create procedure SP_nombreEditorialExiste
@valor varchar(25),
@existe char(1) output
as
if exists (select nombreEditorial from Editorial where replace(nombreEditorial,' ','') = replace(@valor,' ',''))
begin
set @existe = 1
end
else
begin
set @existe = 0
end

go
-- agregar editorial
create procedure SP_AgregarEditorial 
@nombre varchar(25),
@telefono char(10),
@direccion varchar(60),
@ciudad varchar(40)
as
insert into Editorial values (@nombre, @telefono, @direccion, @ciudad)
go

-- procedimiento apra modificar editorial
create procedure SP_modificarEditorial
@clave int,
@nombre varchar(25),
@telefono char(10),
@direccion varchar(60),
@ciudad varchar(40)
as
update Editorial set nombreEditorial = @nombre, telefono = @telefono,
direccion = @direccion, ciudad = @ciudad where IdEditorial = @clave;



-- ============================================== PROCEDIMIENTOS PARA LA TABLA AUTORES ==============================================
go
create procedure SP_ObtenAutores
as
select 
idAutor 'ID',
NombreAutor 'AUTOR',
Nacionalidad 'NACIONALIDAD'
from Autor

go
-- obtener autores filtro
create procedure SP_ObtenAutoresFiltro
@valor varchar(25)
as
select 
idAutor 'ID',
NombreAutor 'AUTOR',
Nacionalidad 'NACIONALIDAD'
from Autor
where NombreAutor like '%'+ @valor +'%';

exec SP_ObtenAutoresFiltro 'a';
go
-- verificar que el nombre del autor no se repita
create procedure SP_NombreAutorRepetido
@valor varchar(25),
@existe int output
as
if exists (select NombreAutor from Autor where REPLACE(NombreAutor, ' ','') = REPLACE(@valor, ' ',''))
begin
set @existe = 1
end
else
begin
set @existe = 0
end

go
-- procedimiento para modificar datos
CREATE procedure SP_modificaAutor
@idAutor int,
@nombreAutor varchar(25),
@nacionalidad varchar(30)
as
update Autor set NombreAutor = @nombreAutor, Nacionalidad = @nacionalidad
where idAutor = @idAutor;



go
-- procedimiento para agregar autores
create procedure SP_AgregaAutor
@nombreAutor varchar(25),
@nacionalidad varchar(30)
as
insert into Autor values (@nombreAutor, @nacionalidad);
go



-- ============================================== PROCEDIMIENTOS ALMACENADOS PARA USUARIOS ==============================================

-- procedimiento almacenado para obtener usuarios
create procedure SP_ObtenUsuarios
as 
select
idUsuario 'CLAVE', nombreUsuario 'NOMBRE USUARIO', case when tipoUsuario = 0 then 'Alumno' when tipoUsuario = 1 then 'Maestro'  else 'Alumnos y Maestros' END AS 'USUARIO'
from usuario

go
-- procedimiento para obtener los usuarios mas activos
CREATE procedure SP_UsuariosMasActivos
as
select u.nombreUsuario 'NOMBRE USUARIO', case when u.tipoUsuario = 0 then 'Alumno' else 'Maestro' end as 'USUARIO', count(*) 'PRESTAMOS REALIZADOS'
from Usuario u 
inner join Prestamo p on u.idUsuario = p.idUsuario
group by  u.nombreUsuario, u.tipoUsuario
ORDER BY COUNT(*) DESC
go
-- procedimiento para filtar datos en una tabla

create procedure sp_FiltraUsuario 
@valor varchar(40)
as
select
idUsuario 'CLAVE', nombreUsuario 'NOMBRE USUARIO',
case when tipoUsuario = 0 then 'Alumno' when tipoUsuario = 1 then 'Maestro'  else 'Alumnos y Maestros' END AS 'USUARIO'
from usuario where nombreUsuario like '%'+@valor+'%'
go
-- procedimiento para insertar usuarios
create procedure SP_AgregarUsuario
@nombreUsuario varchar(40),
@tipoUsuario char(1)
as
insert into Usuario values (@nombreUsuario, @tipoUsuario);

go
-- procedimiento para modificar usuarios
create procedure SP_ModificarUsuario
@idUsuario int,
@nombreUsuario varchar(40),
@tipoUsuario char(1)
as 
update Usuario set nombreUsuario = @nombreUsuario, tipoUsuario = @tipoUsuario where idUsuario = @idUsuario;

