
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;


/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CEN.Fight4Fit_Comentario_darlike) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CEN.Fight4Fit
{
    public partial class ComentarioCEN
    {
        public void Darlike(int p_oid)
        {

            ComentarioEN comentarioEN = null;

            if (p_oid != null)
            {
                comentarioEN = _IComentarioCAD.ReadOIDDefault(p_oid);

                comentarioEN.Likes++;
            }
        }
    }
}