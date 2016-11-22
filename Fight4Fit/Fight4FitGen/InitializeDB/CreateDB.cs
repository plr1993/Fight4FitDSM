
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
                //usuario 1
                IUsuarioCAD _IusuarioCAD1 = new UsuarioCAD ();
                UsuarioEN usuarioEN1 = new UsuarioEN ();
                UsuarioCEN usuarioCEN1 = new UsuarioCEN (_IusuarioCAD1);

                usuarioEN1.Email = "pepe";
                usuarioEN1.Password = "123";
                usuarioCEN1.CrearUsuario (usuarioEN1.Email, usuarioEN1.Password, false);

                //usuario 2
                IUsuarioCAD _IusuarioCAD2 = new UsuarioCAD ();
                UsuarioEN usuarioEN2 = new UsuarioEN ();
                UsuarioCEN usuarioCEN2 = new UsuarioCEN (_IusuarioCAD2);

                usuarioEN2.Email = "antonio";
                usuarioEN2.Password = "123";
                usuarioCEN2.CrearUsuario (usuarioEN2.Email, usuarioEN2.Password, false);

                //usuario 3
                IUsuarioCAD _IusuarioCAD3 = new UsuarioCAD ();
                UsuarioEN usuarioEN3 = new UsuarioEN ();
                UsuarioCEN usuarioCEN3 = new UsuarioCEN (_IusuarioCAD3);

                usuarioEN3.Email = "joselito";
                usuarioEN3.Password = "123";
                usuarioCEN3.CrearUsuario (usuarioEN3.Email, usuarioEN3.Password, false);



                //admin
                IAdminCAD _IAdminCAD1 = new AdminCAD ();
                AdminEN adminEN1 = new AdminEN ();
                AdminCP adminCP1 = new AdminCP ();
                AdminCEN adminCEN1 = new AdminCEN (_IAdminCAD1);
                adminEN1.Email = "josss";
                adminEN1.Password = "123";
                adminCEN1.CrearUsuarioAdmin (adminEN1.Email, adminEN1.Password, false);



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
