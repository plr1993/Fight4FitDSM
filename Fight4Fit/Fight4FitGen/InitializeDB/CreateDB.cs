
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CP.Fight4Fit;
using Fight4FitGenNHibernate.Enumerated.Fight4Fit;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                //CAD
                IUsuarioCAD _IusuarioCAD = new UsuarioCAD ();
                IEventoCAD _IEventoCAD = new EventoCAD ();
                ICategoriaCAD _ICategoriaCAD = new CategoriaCAD ();
                IReporteCAD _IReporteCAD = new ReporteCAD ();
                IGaleriaCAD _IGaleriaCAD = new GaleriaCAD ();
                IComentarioCAD _IComentarioCAD = new ComentarioCAD ();
                ISoporteCAD _ISoporteCAD = new SoporteCAD ();

                //EN
                UsuarioEN usuarioEN = new UsuarioEN ();
                EventoEN eventoEN = new EventoEN ();
                CategoriaEN categoriaEN = new CategoriaEN ();
                ReporteEN reporteEN = new ReporteEN ();
                GaleriaEN galeriaEN = new GaleriaEN ();
                ComentarioEN comentarioEN = new ComentarioEN ();
                SoporteEN soporteEN = new SoporteEN ();

                //CEN
                UsuarioCEN usuarioCEN = new UsuarioCEN (_IusuarioCAD);
                EventoCEN eventoCEN = new EventoCEN (_IEventoCAD);
                CategoriaCEN categoriaCEN = new CategoriaCEN (_ICategoriaCAD);
                ReporteCEN reporteCEN = new ReporteCEN (_IReporteCAD);
                GaleriaCEN galeriaCEN = new GaleriaCEN (_IGaleriaCAD);
                ComentarioCEN comentarioCEN = new ComentarioCEN (_IComentarioCAD);
                SoporteCEN soporteCEN = new SoporteCEN (_ISoporteCAD);

                //CP
                ReporteCP reporteCP = new ReporteCP ();
                ComentarioCP comentarioCP = new ComentarioCP ();

                //USUARIOS
                UsuarioEN usuario1EN = new UsuarioEN ();
                usuario1EN.Email = "luisberenguer96@gmail.com";
                usuario1EN.Password = "123456qwe";
                usuario1EN.Nombre = "Luis";
                usuario1EN.Apellidos = "Berenguer";
                usuario1EN.Telefono = "665644433";
                usuario1EN.Localidad = "Novelda";
                usuario1EN.Provincia = "Alicante";
                usuario1EN.Direccion = "Calle to guapag 5 C";
                usuarioCEN.CrearUsuario (usuario1EN.Email, usuario1EN.Password, false, TipoUsuarioEnum.Administrador, usuario1EN.Nombre, usuario1EN.Apellidos, usuario1EN.Telefono, usuario1EN.Localidad, usuario1EN.Provincia, usuario1EN.Direccion);

                UsuarioEN usuario2EN = new UsuarioEN ();
                usuario2EN.Email = "victoriahodelin@gmail.com";
                usuario2EN.Password = "123456qwe";
                usuario2EN.Nombre = "Victoria";
                usuario2EN.Apellidos = "Hodelin";
                usuario2EN.Telefono = "665644433";
                usuario2EN.Localidad = "Orihuela";
                usuario2EN.Provincia = "Alicante";
                usuario2EN.Direccion = "Calle to guapag 5 C";
                usuarioCEN.CrearUsuario (usuario2EN.Email, usuario2EN.Password, false, TipoUsuarioEnum.Administrador, usuario2EN.Nombre, usuario2EN.Apellidos, usuario2EN.Telefono, usuario2EN.Localidad, usuario2EN.Provincia, usuario2EN.Direccion);

                UsuarioEN usuario3EN = new UsuarioEN ();
                usuario3EN.Email = "pablolope93@gmail.com";
                usuario3EN.Password = "123456qwe";
                usuario3EN.Nombre = "Pablo";
                usuario3EN.Apellidos = "Lopez";
                usuario3EN.Telefono = "665644433";
                usuario3EN.Localidad = "Aspe";
                usuario3EN.Provincia = "Alicante";
                usuario3EN.Direccion = "Calle to guapag 5 C";
                usuarioCEN.CrearUsuario (usuario3EN.Email, usuario3EN.Password, false, TipoUsuarioEnum.Administrador, usuario3EN.Nombre, usuario3EN.Apellidos, usuario3EN.Telefono, usuario3EN.Localidad, usuario3EN.Provincia, usuario3EN.Direccion);
                usuarioCEN.CrearUsuario ("raul@gmail.com", usuario3EN.Password, false, TipoUsuarioEnum.Normal, usuario3EN.Nombre, usuario3EN.Apellidos, usuario3EN.Telefono, usuario3EN.Localidad, usuario3EN.Provincia, usuario3EN.Direccion);
                usuarioCEN.CrearUsuario ("juan@gmail.com", usuario3EN.Password, false, TipoUsuarioEnum.Normal, usuario3EN.Nombre, usuario3EN.Apellidos, usuario3EN.Telefono, usuario3EN.Localidad, usuario3EN.Provincia, usuario3EN.Direccion);
                usuarioCEN.CrearUsuario ("raul1@gmail.com", usuario3EN.Password, true, TipoUsuarioEnum.Normal, usuario3EN.Nombre, usuario3EN.Apellidos, usuario3EN.Telefono, usuario3EN.Localidad, usuario3EN.Provincia, usuario3EN.Direccion);
                usuarioCEN.CrearUsuario ("raul2@gmail.com", usuario3EN.Password, false, TipoUsuarioEnum.Promotor, usuario3EN.Nombre, usuario3EN.Apellidos, usuario3EN.Telefono, usuario3EN.Localidad, usuario3EN.Provincia, usuario3EN.Direccion);
                usuarioCEN.CrearUsuario ("raul3@gmail.com", usuario3EN.Password, true, TipoUsuarioEnum.Promotor, usuario3EN.Nombre, usuario3EN.Apellidos, usuario3EN.Telefono, usuario3EN.Localidad, usuario3EN.Provincia, usuario3EN.Direccion);


                //CATEGORIA
                categoriaEN = new CategoriaEN ();
                categoriaEN.Nombre = "Futbol";
                categoriaCEN.CrearCategoria (categoriaEN.Nombre);

                CategoriaEN categoria1EN = new CategoriaEN ();
                categoria1EN.Nombre = "Baloncesto";
                categoriaCEN.CrearCategoria (categoria1EN.Nombre);

                CategoriaEN categoria2EN = new CategoriaEN ();
                categoria2EN.Nombre = "Atletismo";
                categoriaCEN.CrearCategoria (categoria2EN.Nombre);

                //EVENTO
                DateTime date1 = DateTime.Now;
                DateTime date12 = new DateTime (2008, 5, 1, 8, 30, 52);
                eventoEN = new EventoEN ();
                eventoEN.Categoria = categoriaEN;
                eventoEN.Descripcion = "Que bien vamos a pasarlo";
                eventoEN.Tipo = TipoEventoEnum.Evento;
                eventoEN.Localizacion = "China";
                eventoEN.Latitud = 1234123;
                eventoEN.Longitud = 123123;
                int ev1 = eventoCEN.CrearEvento ("La copa del meao", "juan@gmail.com", eventoEN.Categoria.Nombre, eventoEN.Descripcion, eventoEN.Tipo, 0, 32, date1, eventoEN.Localizacion, eventoEN.Latitud, eventoEN.Longitud);

                EventoEN evento1EN = new EventoEN ();
                evento1EN = new EventoEN ();
                evento1EN.Categoria = categoriaEN;
                evento1EN.Descripcion = "Que bien vamos a jugahlo";
                evento1EN.Localizacion = "Aspe";
                evento1EN.Latitud = 1234123;
                evento1EN.Longitud = 123123;
                evento1EN.Tipo = TipoEventoEnum.Evento;
                int ev2 = eventoCEN.CrearEvento ("La copa del cagao", "raul@gmail.com", eventoEN.Categoria.Nombre, eventoEN.Descripcion, eventoEN.Tipo, 0, 32, date12, evento1EN.Localizacion, evento1EN.Latitud, evento1EN.Longitud);

                /*/ / COMENTARIO
                comentarioEN = new ComentarioEN ();
                comentarioEN.Titulo = "Futbol";
                comentarioEN.Texto = "El futbol es muy divertido";
                comentarioCP.PublicarComentario (comentarioEN.Titulo, comentarioEN.Texto, ev1, TipoComentarioEnum.Evento);


                ComentarioEN comentario2EN = new ComentarioEN ();
                comentario2EN = new ComentarioEN ();
                comentario2EN.Titulo = "Golf";
                comentario2EN.Texto = "El golf es muy divertido";
                comentarioCP.PublicarComentario (comentario2EN.Titulo, comentario2EN.Texto, ev2, TipoComentarioEnum.Evento);

                ComentarioEN comentario3EN = new ComentarioEN ();
                comentario3EN.Titulo = "Tenis";
                comentario3EN.Texto = "El tenis es muy divertido";
                comentarioCP.PublicarComentario (comentario3EN.Titulo, comentario3EN.Texto, ev1, TipoComentarioEnum.Evento);
                * /



                //REPORTE

                /*
                 *  reporteEN = new ReporteEN ();
                 *  reporteEN.Texto = "Este tio es muy muy feo";
                 *  reporteEN.Motivo = MotivoEnum.ofensivo;
                 *  reporteEN.Usuario = usuario1EN;
                 *  reporteEN.Tipo = TipoReporteEnum.comentario;
                 *  reporteCP.NuevoReporte (reporteEN.Texto, reporteEN.Motivo, reporteEN.Usuario.Email, comentarioEN.Id, reporteEN.Tipo);
                 *
                 *  ReporteEN reporte1EN = new ReporteEN ();
                 *  reporte1EN.Texto = "Este tio es muy muy feo";
                 *  reporte1EN.Motivo = MotivoEnum.terrorismo;
                 *  reporte1EN.Usuario = usuario2EN;
                 *  reporte1EN.Tipo = TipoReporteEnum.comentario;
                 *  reporteCP.NuevoReporte (reporte1EN.Texto, reporte1EN.Motivo, reporte1EN.Usuario.Email, 0, reporte1EN.Tipo);
                 *
                 *  ReporteEN reporte2EN = new ReporteEN ();
                 *  reporte2EN.Texto = "Este tio es muy muy feo";
                 *  reporte2EN.Motivo = MotivoEnum.inapropiado;
                 *  reporte1EN.Usuario = usuario1EN;
                 *  reporte2EN.Tipo = TipoReporteEnum.comentario;
                 *  reporteCP.NuevoReporte (reporte2EN.Texto, reporte2EN.Motivo, reporte2EN.Usuario.Email, 1, reporte2EN.Tipo);*/





                // Insert the initilizations of entities using the CEN classes


                // p.e. CustomerCEN customer = new CustomerCEN();
                // customer.New_ (p_user:"user", p_password:"1234");



                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
