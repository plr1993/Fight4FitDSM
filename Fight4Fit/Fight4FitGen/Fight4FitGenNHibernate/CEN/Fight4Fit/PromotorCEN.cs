

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
 *      Definition of the class PromotorCEN
 *
 */
public partial class PromotorCEN
{
private IPromotorCAD _IPromotorCAD;

public PromotorCEN()
{
        this._IPromotorCAD = new PromotorCAD ();
}

public PromotorCEN(IPromotorCAD _IPromotorCAD)
{
        this._IPromotorCAD = _IPromotorCAD;
}

public IPromotorCAD get_IPromotorCAD ()
{
        return this._IPromotorCAD;
}

public string CrearUsuarioProm (string p_Email, String p_Password, int p_comentario)
{
        PromotorEN promotorEN = null;
        string oid;

        //Initialized PromotorEN
        promotorEN = new PromotorEN ();
        promotorEN.Email = p_Email;

        promotorEN.Password = Utils.Util.GetEncondeMD5 (p_Password);


        if (p_comentario != -1) {
                // El argumento p_comentario -> Property comentario es oid = false
                // Lista de oids Email
                promotorEN.Comentario = new Fight4FitGenNHibernate.EN.Fight4Fit.ComentarioEN ();
                promotorEN.Comentario.Id = p_comentario;
        }

        //Call to PromotorCAD

        oid = _IPromotorCAD.CrearUsuarioProm (promotorEN);
        return oid;
}
}
}
