
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;



/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CP.Fight4Fit_Comentario_PublicarComentario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class ComentarioCP : BasicCP
{
public Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN PublicarComentario (string p_Titulo, string p_Texto, int idfoto, int ideven)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CP.Fight4Fit_Comentario_PublicarComentario) ENABLED START*/

        IComentarioCAD comentarioCAD = null;
        ComentarioCEN comentarioCEN = null;

        Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN result = null;


        try
        {
                SessionInitializeTransaction ();
                comentarioCAD = new ComentarioCAD (session);
                comentarioCEN = new  ComentarioCEN (comentarioCAD);




                int oid;
                //Initialized ComentarioEN
                ComentarioEN comentarioEN;
                comentarioEN = new ComentarioEN ();
                comentarioEN.Titulo = p_Titulo;

                comentarioEN.Texto = p_Texto;

                comentarioEN.Likes = 0;

                //Call to ComentarioCAD

                oid = comentarioCAD.PublicarComentario (comentarioEN);


                if (idfoto > 0) {
                        comentarioCEN.VincFoto (comentarioEN.Id, idfoto);
                }

                else if (ideven >= 0) {
                        comentarioCEN.VincEv (comentarioEN.Id, ideven);
                }



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
