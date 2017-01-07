
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;



/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CP.Fight4Fit_Foto_SubirFoto) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class FotoCP : BasicCP
{
public Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN SubirFoto (string p_Nombre, string p_Usuario, string p_Descripcion, int p_pertenece_a, int p_likes, string p_Ruta)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CP.Fight4Fit_Foto_SubirFoto) ENABLED START*/

        IFotoCAD fotoCAD = null;
        FotoCEN fotoCEN = null;

        Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN result = null;


        try
        {
                SessionInitializeTransaction ();
                fotoCAD = new FotoCAD (session);
                fotoCEN = new  FotoCEN (fotoCAD);




                int oid;
                //Initialized FotoEN
                FotoEN fotoEN;
                fotoEN = new FotoEN ();
                fotoEN.Nombre = p_Nombre;

                fotoEN.Usuario = p_Usuario;

                fotoEN.Descripcion = p_Descripcion;

                fotoEN.Likes = p_likes;

                fotoEN.Ruta = p_Ruta;

                GaleriaCEN cen=new GaleriaCEN();

                fotoEN.Pertenece_a = cen.ReadOID(p_pertenece_a);

                //Call to FotoCAD

                oid = fotoCAD.SubirFoto (fotoEN);
                result = fotoCAD.ReadOIDDefault (oid);



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
