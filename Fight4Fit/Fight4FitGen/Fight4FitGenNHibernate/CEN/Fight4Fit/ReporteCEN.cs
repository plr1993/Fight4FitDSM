

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.Exceptions;

using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;


namespace Fight4FitGenNHibernate.CEN.Fight4Fit
{
/*
 *      Definition of the class ReporteCEN
 *
 */
public partial class ReporteCEN
{
private IReporteCAD _IReporteCAD;

public ReporteCEN()
{
        this._IReporteCAD = new ReporteCAD ();
}

public ReporteCEN(IReporteCAD _IReporteCAD)
{
        this._IReporteCAD = _IReporteCAD;
}

public IReporteCAD get_IReporteCAD ()
{
        return this._IReporteCAD;
}

public int NuevoReporte (int p_evento, int p_comentario, int p_foto, string p_Texto, Fight4FitGenNHibernate.Enumerated.Fight4Fit.MotivoEnum p_Motivo, System.Collections.Generic.IList<string> p_usuario)
{
        ReporteEN reporteEN = null;
        int oid;

        //Initialized ReporteEN
        reporteEN = new ReporteEN ();

        if (p_evento != -1) {
                // El argumento p_evento -> Property evento es oid = false
                // Lista de oids id
                reporteEN.Evento = new Fight4FitGenNHibernate.EN.Fight4Fit.EventoEN ();
                reporteEN.Evento.Id = p_evento;
        }


        if (p_comentario != -1) {
                // El argumento p_comentario -> Property comentario es oid = false
                // Lista de oids id
                reporteEN.Comentario = new Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN ();
                reporteEN.Comentario.Id = p_comentario;
        }


        if (p_foto != -1) {
                // El argumento p_foto -> Property foto es oid = false
                // Lista de oids id
                reporteEN.Foto = new Fight4FitGenNHibernate.EN.Fight4Fit.FotoEN ();
                reporteEN.Foto.Id = p_foto;
        }

        reporteEN.Texto = p_Texto;

        reporteEN.Motivo = p_Motivo;


        reporteEN.Usuario = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN>();
        if (p_usuario != null) {
                foreach (string item in p_usuario) {
                        Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN en = new Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN ();
                        en.Email = item;
                        reporteEN.Usuario.Add (en);
                }
        }

        else{
                reporteEN.Usuario = new System.Collections.Generic.List<Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN>();
        }

        //Call to ReporteCAD

        oid = _IReporteCAD.NuevoReporte (reporteEN);
        return oid;
}

public void EliminarReporte (int id
                             )
{
        _IReporteCAD.EliminarReporte (id);
}
}
}
