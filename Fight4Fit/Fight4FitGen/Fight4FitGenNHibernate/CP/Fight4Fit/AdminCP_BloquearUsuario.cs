
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;



/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CP.Fight4Fit_Admin_BloquearUsuario) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class AdminCP : BasicCP
{
public void BloquearUsuario (string p_Admin_OID, string p_usuario_OIDs)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CP.Fight4Fit_Admin_BloquearUsuario) ENABLED START*/

        IAdminCAD adminCAD = null;

        IUsuarioCAD usuarioCAD = null;

        try
        {
                SessionInitializeTransaction ();
                adminCAD = new AdminCAD (session);
                AdminCEN adminCEN = new AdminCEN (adminCAD);

                usuarioCAD = new UsuarioCAD (session);

                UsuarioEN usuarioEN = usuarioCAD.ReadOIDDefault (p_oid);

                bool bloq = true;

                UsuarioCEN usuarioCEN = new UsuarioCEN (usuarioCAD);
                usuarioCEN.ModificarPerfil (usuarioEN.Email, usuarioEN.Password, bloq);

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
