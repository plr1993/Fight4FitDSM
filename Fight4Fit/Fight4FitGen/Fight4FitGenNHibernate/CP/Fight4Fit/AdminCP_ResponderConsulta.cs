
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;



/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CP.Fight4Fit_Admin_ResponderConsulta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class AdminCP : BasicCP
{
public void ResponderConsulta (string p_oid, int arg1, string respuestaSoporte)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CP.Fight4Fit_Admin_ResponderConsulta) ENABLED START*/

        IAdminCAD adminCAD = null;
        ISoporteCAD soporteCAD = null;



        try
        {
                SessionInitializeTransaction ();
                adminCAD = new AdminCAD (session);
                soporteCAD = new SoporteCAD (session);
                SoporteCEN soporteCEN = new SoporteCEN (soporteCAD);
                SoporteEN soporteEN = soporteCEN.ReadOID (arg1);

                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new UsuarioCEN (usuarioCAD);

                reporteCAD = new ReporteCAD (session);
                ReporteCEN reporteCEN = new ReporteCEN (reporteCAD);
                reporteCEN.NuevoReporte (null, //foto
                        arg1, //oid comentario
                        null, // oid evento
                        texto,
                        motivo,
                        usuarioCAD.ReadOID (p_oid)); //usuario




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
