
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
public void Darlike (int p_oid)
{
        /*PROTECTED REGION ID(Fight4FitGenNHibernate.CEN.Fight4Fit_Foto_darlike) ENABLED START*/

        // Write here your custom code...
        FotoCAD fotoCAD = new FotoCAD();
        FotoEN fotoEN = new FotoEN();
        fotoEN = fotoCAD.ReadOIDDefault(p_oid);
        fotoEN.Likes = fotoEN.Likes + 1;
        /*PROTECTED REGION END*/
}
}
}
