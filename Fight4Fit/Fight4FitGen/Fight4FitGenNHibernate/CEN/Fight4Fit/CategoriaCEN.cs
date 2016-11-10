

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
 *      Definition of the class CategoriaCEN
 *
 */
public partial class CategoriaCEN
{
private ICategoriaCAD _ICategoriaCAD;

public CategoriaCEN()
{
        this._ICategoriaCAD = new CategoriaCAD ();
}

public CategoriaCEN(ICategoriaCAD _ICategoriaCAD)
{
        this._ICategoriaCAD = _ICategoriaCAD;
}

public ICategoriaCAD get_ICategoriaCAD ()
{
        return this._ICategoriaCAD;
}

public string CrearCategoria (string p_Nombre)
{
        CategoriaEN categoriaEN = null;
        string oid;

        //Initialized CategoriaEN
        categoriaEN = new CategoriaEN ();
        categoriaEN.Nombre = p_Nombre;

        //Call to CategoriaCAD

        oid = _ICategoriaCAD.CrearCategoria (categoriaEN);
        return oid;
}

public CategoriaEN ReadOID (string Nombre
                            )
{
        CategoriaEN categoriaEN = null;

        categoriaEN = _ICategoriaCAD.ReadOID (Nombre);
        return categoriaEN;
}

public System.Collections.Generic.IList<CategoriaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CategoriaEN> list = null;

        list = _ICategoriaCAD.ReadAll (first, size);
        return list;
}
}
}
