
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using Fight4FitGenNHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.CAD.Fight4Fit;
using Fight4FitGenNHibernate.CEN.Fight4Fit;


namespace Fight4FitGenNHibernate.CP.Fight4Fit
{
public partial class PromotorCP : BasicCP
{
public PromotorCP() : base ()
{
}

public PromotorCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
