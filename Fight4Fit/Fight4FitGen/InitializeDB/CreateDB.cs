
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
        IUsuarioCAD _IusuarioCAD = new UsuarioCAD();
        IAdminCAD _IAdminCAD = new AdminCAD();
        ICategoriaCAD _ICategoriaCAD = new CategoriaCAD();
        IReporteCAD _IReporteCAD = new ReporteCAD();
        IPromotorCAD _IPromotorCAD = new PromotorCAD();
        IGaleriaCAD _IGaleriaCAD = new GaleriaCAD();
        IComentarioCAD _IComentarioCAD = new ComentarioCAD();
        ISoporteCAD _ISoporteCAD = new SoporteCAD();

        //EN
        UsuarioEN usuarioEN = new UsuarioEN();
        AdminEN adminEN = new AdminEN();
        CategoriaEN categoriaEN = new CategoriaEN();
        ReporteEN reporteEN = new ReporteEN();
        PromotorEN promotorEN = new PromotorEN();
        GaleriaEN galeriaEN = new GaleriaEN();
        ComentarioEN comentarioEN = new ComentarioEN();
        SoporteEN soporteEN = new SoporteEN();

        //CEN
        UsuarioCEN usuarioCEN = new UsuarioCEN(_IusuarioCAD);
        AdminCEN adminCEN = new AdminCEN(_IAdminCAD);
        CategoriaCEN categoriaCEN = new CategoriaCEN(_ICategoriaCAD);
        ReporteCEN reporteCEN = new ReporteCEN(_IReporteCAD);
        PromotorCEN promotorCEN = new PromotorCEN(_IPromotorCAD);
        GaleriaCEN galeriaCEN = new GaleriaCEN(_IGaleriaCAD);
        ComentarioCEN comentarioCEN = new ComentarioCEN(_IComentarioCAD);
        SoporteCEN soporteCEN = new SoporteCEN(_ISoporteCAD);

        //CP
        AdminCP adminCP = new AdminCP();
        ReporteCP reporteCP = new ReporteCP();

        //USUARIOS
        UsuarioEN usuario1EN = new UsuarioEN();
        usuario1EN.Email = "Pepe";
        usuario1EN.Password = "123";
        usuarioCEN.CrearUsuario(usuario1EN.Email, usuario1EN.Password, false);
        UsuarioEN usuario2EN = new UsuarioEN();
        usuario2EN.Email = "Pyol";
        usuario2EN.Password = "123";
        usuarioCEN.CrearUsuario(usuario2EN.Email, usuario2EN.Password, false);
        UsuarioEN usuario3EN = new UsuarioEN();
        usuario3EN.Email = "Luis";
        usuario3EN.Password = "123";
        usuarioCEN.CrearUsuario(usuario3EN.Email, usuario3EN.Password, false);
        UsuarioEN usuario4EN = new UsuarioEN();
        usuario4EN.Email = "Viki";
        usuario4EN.Password = "123";
        usuarioCEN.CrearUsuario(usuario4EN.Email, usuario4EN.Password, false);
        UsuarioEN usuario5EN = new UsuarioEN();
        usuario5EN.Email = "Juan";
        usuario5EN.Password = "123";
        usuarioCEN.CrearUsuario(usuario5EN.Email, usuario5EN.Password, false);

        //PROMOTOR
        PromotorEN promotor1EN = new PromotorEN();
        promotor1EN.Email = "Hector";
        promotor1EN.Password = "123";
        promotor1EN.CIF = "12345678";
        promotorCEN.CrearUsuarioProm(promotor1EN.Email, promotor1EN.Password, false, promotor1EN.CIF);

        PromotorEN promotor2EN = new PromotorEN();
        promotor2EN.Email = "Marcos";
        promotor2EN.Password = "223";
        promotor2EN.CIF = "22345678";
        promotorCEN.CrearUsuarioProm(promotor2EN.Email, promotor2EN.Password, false, promotor2EN.CIF);

        PromotorEN promotor3EN = new PromotorEN();
        promotor3EN.Email = "Lola";
        promotor3EN.Password = "323";
        promotor3EN.CIF = "32345678";
        promotorCEN.CrearUsuarioProm(promotor3EN.Email, promotor3EN.Password, false, promotor3EN.CIF);

        //ADMIN
        adminEN = new AdminEN();
        adminEN.Email = "josss";
        adminEN.Password = "183";
        adminCEN.CrearUsuarioAdmin(adminEN.Email, adminEN.Password, false);

        //CATEGORIA
        categoriaEN = new CategoriaEN();
        categoriaEN.Nombre = "Futbol";
        categoriaCEN.CrearCategoria(categoriaEN.Nombre);

        CategoriaEN categoria1EN = new CategoriaEN();
        categoria1EN.Nombre = "Baloncesto";
        categoriaCEN.CrearCategoria(categoria1EN.Nombre);

        CategoriaEN categoria2EN = new CategoriaEN();
        categoria2EN.Nombre = "Atletismo";
        categoriaCEN.CrearCategoria(categoria2EN.Nombre);

        //REPORTE


        reporteEN = new ReporteEN();
        reporteEN.Texto = "Este tio es muy muy feo";
        reporteEN.Motivo = MotivoEnum.motivo1;
        reporteEN.Usuario.Email = "Pepe";
        reporteEN.Tipo = TipoReporteEnum.foto;
        reporteCP.NuevoReporte(reporteEN.Texto, reporteEN.Motivo, reporteEN.Usuario.Email, reporteEN.Tipo, 1);

        ReporteEN reporte1EN = new ReporteEN();
        reporte1EN.Texto = "Este tio es muy muy feo";
        reporte1EN.Motivo = MotivoEnum.motivo2;
        reporte1EN.Usuario.Email = "Pepe";
        reporte1EN.Tipo = TipoReporteEnum.comentario;
        reporteCP.NuevoReporte(reporte1EN.Texto, reporte1EN.Motivo, reporte1EN.Usuario.Email, reporte1EN.Tipo, 1);

        ReporteEN reporte2EN = new ReporteEN();
        reporte2EN.Texto = "Este tio es muy muy feo";
        reporte2EN.Motivo = MotivoEnum.motivo3;
        reporte2EN.Usuario.Email = "Pepe";
        reporte2EN.Tipo = TipoReporteEnum.evento;
        reporteCP.NuevoReporte(reporte2EN.Texto, reporte2EN.Motivo, reporte2EN.Usuario.Email, reporte2EN.Tipo, 1);

        // Insert the initilizations of entities using the CEN classes


        // p.e. CustomerCEN customer = new CustomerCEN();
        // customer.New_ (p_user:"user", p_password:"1234");



        /*PROTECTED REGION END*/
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.InnerException);
        throw ex;
    }
}
}
}
