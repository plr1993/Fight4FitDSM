

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

public int NuevoReporte (int p_evento, int p_comentario, int p_foto, string p_Texto, Fight4FitGenNHibernate.Enumerated.Fight4Fit.MotivoEnum p_Motivo, string p_usuario)
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


        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                reporteEN.Usuario = new Fight4FitGenNHibernate.EN.Fight4Fit.UsuarioEN ();
                reporteEN.Usuario.Email = p_usuario;
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

public ReporteEN ReadOID (int id
                          )
{
        ReporteEN reporteEN = null;

        reporteEN = _IReporteCAD.ReadOID (id);
        return reporteEN;
}

public System.Collections.Generic.IList<ReporteEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ReporteEN> list = null;

        list = _IReporteCAD.ReadAll (first, size);
        return list;
}
}
}
