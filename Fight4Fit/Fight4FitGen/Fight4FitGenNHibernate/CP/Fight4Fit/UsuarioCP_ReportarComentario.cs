
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;



/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CP.Fight4Fit_Usuario_ReportarComentario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class UsuarioCP : BasicCP
{
public void ReportarComentario (string p_oid, int arg1, string texto, Fight4FitGenNHibernate.Enumerated.Fight4Fit.MotivoEnum motivo)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CP.Fight4Fit_Usuario_ReportarComentario) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;

        IReporteCAD reporteCAD = null;


        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new UsuarioCEN (usuarioCAD);

                reporteCAD = new ReporteCAD (session);
                ReporteCEN reporteCEN = new ReporteCEN (reporteCAD);
                reporteCEN.NuevoReporte (-1, //foto
                        arg1, //oid comentario
                        -1, // oid evento
                        texto,
                        motivo,
                        usuarioCAD.ReadOID (p_oid).Email); //usuario

                //  reporteCAD.NuevoReporte (reporteEN);



                // Write here your custom transaction ...




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


        /*PROTECTED REGION END*/
}
}
}
