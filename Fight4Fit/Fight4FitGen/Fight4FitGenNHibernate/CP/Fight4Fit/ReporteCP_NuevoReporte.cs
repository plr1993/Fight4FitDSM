
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;



/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CP.Fight4Fit_Reporte_NuevoReporte) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class ReporteCP : BasicCP
{
public Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN NuevoReporte (string p_Texto, Fight4FitGenNHibernate.Enumerated.Fight4Fit.MotivoEnum p_Motivo, string p_usuario, Fight4FitGenNHibernate.Enumerated.Fight4Fit.TipoReporteEnum p_tipo, int p_idRef)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CP.Fight4Fit_Reporte_NuevoReporte) ENABLED START*/

        IReporteCAD reporteCAD = null;
        ReporteCEN reporteCEN = null;

        Fight4FitGenNHibernate.EN.Fight4Fit.ReporteEN result = null;


        try
        {
                SessionInitializeTransaction ();
                reporteCAD = new ReporteCAD (session);
                reporteCEN = new  ReporteCEN (reporteCAD);




                int oid;
                //Initialized ReporteEN
                ReporteEN reporteEN;
                reporteEN = new ReporteEN ();
                reporteEN.Texto = p_Texto;

                reporteEN.Motivo = p_Motivo;


                if (p_usuario != null) {
                        reporteEN.Usuario = new Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN ();
                        reporteEN.Usuario.Email = p_usuario;
                }

                reporteEN.Tipo = p_tipo;


                //Call to ReporteCAD

                oid = reporteCAD.NuevoReporte (reporteEN);
                result = reporteCAD.ReadOIDDefault (oid);



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
