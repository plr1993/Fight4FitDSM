using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.Enumerated.Fight4Fit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fight4Fit_FrontEnd.Models
{
    public class ReporteAssembler
    {
        public ReporteModelo ConvertENToModelUI(ReporteEN en)
        {
            ReporteModelo cat = new ReporteModelo();

            cat.texto = en.Texto;
            cat.email = "el puma";
            cat.motivo = en.Motivo;
            cat.tipo = en.Tipo;
       


            return cat;
        }



        public IList<ReporteModelo> ConvertListENToModel(IList<ReporteEN> repens)
        {
            IList<ReporteModelo> repmod = new List<ReporteModelo>();
            foreach (ReporteEN repen in repens)
            {
                repmod.Add(ConvertENToModelUI(repen));
            }

            return repmod;
        }
    }
}