
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
public Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN PublicarComentario (string p_Titulo, string p_Texto, int idref, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoComentarioEnum tipo, int usuarioid)
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
                comentarioEN.Tipocom = tipo;
                comentarioEN.Likes = 0;

                //Call to ComentarioCAD

                oid = comentarioCAD.PublicarComentario (comentarioEN);


                if (comentarioEN.Tipocom == TipoComentarioEnum.Foto) {
                        comentarioCEN.VincFoto (comentarioEN.Id, idref);
                }

                else if (comentarioEN.Tipocom == TipoComentarioEnum.Evento) {
                        comentarioCEN.VincEv (comentarioEN.Id, idref);
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
