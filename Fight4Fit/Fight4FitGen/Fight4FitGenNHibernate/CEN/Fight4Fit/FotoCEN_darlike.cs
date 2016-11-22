
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


/*PROTECTED REGION ID(usingFight4FitGenNHibernate.CEN.Fight4Fit_Foto_darlike) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Fight4FitGenNHibernate.CEN.Fight4Fit
{
    public partial class FotoCEN
    {
        public void Darlike(int p_oid)
        {
            FotoEN fotoEN = null;

            if (p_oid != null)
            {
                fotoEN = _IFotoCAD.ReadOIDDefault(p_oid);

                fotoEN.Likes++;
            }
        }
    }
}


