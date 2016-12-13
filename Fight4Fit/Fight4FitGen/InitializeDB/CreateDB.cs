
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
                IAdminCAD _IAdminCAD = new AdminCAD ();

                //EN
                UsuarioEN usuarioEN = new UsuarioEN ();
                AdminEN adminEN = new AdminEN ();

                //CEN
                UsuarioCEN usuarioCEN = new UsuarioCEN (_IusuarioCAD1);
                AdminCEN adminCEN = new AdminCEN (_IAdminCAD1);

                //CP
                AdminCP adminCP = new AdminCP ();


                //USUARIOS
                usuario1EN= new UsuraioEN ();
                usuario1EN.Email = "Pepe";
                usuario1EN.Password = "123";
                usuario1CEN.CrearUsuario (usuarioEN1.Email, usuarioEN1.Password, false);
                usuario2EN= new UsuraioEN ();
                usuario2EN.Email = "Juan";
                usuario2EN.Password = "123";
                usuario2CEN.CrearUsuario (usuarioEN2.Email, usuarioEN2.Password, false);
                usuario3EN= new UsuraioEN ();
                usuario3EN.Email = "Luis";
                usuario3EN.Password = "123";
                usuario3CEN.CrearUsuario (usuarioEN3.Email, usuarioEN3.Password, false);
                usuario4EN= new UsuraioEN ();
                usuario4EN.Email = "Viki";
                usuario4EN.Password = "123";
                usuario4CEN.CrearUsuario (usuarioEN4.Email, usuarioEN4.Password, false);
                usuario5EN= new UsuraioEN ();
                usuario5EN.Email = "Juan";
                usuario5EN.Password = "123";
                usuario5CEN.CrearUsuario (usuarioEN5.Email, usuarioEN5.Password, false);

                //ADMIN
                adminEN = new adminEN();
                adminEN.Email = "josss";
                adminEN.Password = "183";
                adminCEN.CrearUsuarioAdmin (adminEN1.Email, adminEN1.Password, false);



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
