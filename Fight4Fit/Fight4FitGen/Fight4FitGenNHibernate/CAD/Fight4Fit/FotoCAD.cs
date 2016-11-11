
using System;
using System.Text;
using Fight4FitGenNHibernate.CEN.Fight4Fit;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Fight4FitGenNHibernate.EN.Fight4Fit;
using Fight4FitGenNHibernate.Exceptions;


/*
 * Clase Foto:
 *
 */

namespace Fight4FitGenNHibernate.CAD.Fight4Fit
{
public partial class FotoCAD : BasicCAD, IFotoCAD
{
public FotoCAD() : base ()
{
}

public FotoCAD(ISession sessionAux) : base (sessionAux)
{
}



public FotoEN ReadOIDDefault (int id
                              )
{
        FotoEN fotoEN = null;

        try
        {
                SessionInitializeTransaction ();
                fotoEN = (FotoEN)session.Get (typeof(FotoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in FotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return fotoEN;
}

public System.Collections.Generic.IList<FotoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<FotoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(FotoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<FotoEN>();
                        else
                                result = session.CreateCriteria (typeof(FotoEN)).List<FotoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in FotoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (FotoEN foto)
{
        try
        {
                SessionInitializeTransaction ();
                FotoEN fotoEN = (FotoEN)session.Load (typeof(FotoEN), foto.Id);



                fotoEN.Nombre = foto.Nombre;


                fotoEN.Usuario = foto.Usuario;


                fotoEN.Fecha = foto.Fecha;


                fotoEN.Descripcion = foto.Descripcion;


                fotoEN.Imagen = foto.Imagen;



                fotoEN.Likes = foto.Likes;

                session.Update (fotoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in FotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int SubirFoto (FotoEN foto)
{
        try
        {
                SessionInitializeTransaction ();
                if (foto.Pertenece_a != null) {
                        // Argumento OID y no colección.
                        foto.Pertenece_a = (Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN)session.Load (typeof(Fight4FitGenNHibernate.EN.Fight4Fit.GaleriaEN), foto.Pertenece_a.Id);

                        foto.Pertenece_a.Compuesta_por
                        .Add (foto);
                }

                session.Save (foto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in FotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return foto.Id;
}

public void EditarFoto (FotoEN foto)
{
        try
        {
                SessionInitializeTransaction ();
                FotoEN fotoEN = (FotoEN)session.Load (typeof(FotoEN), foto.Id);

                fotoEN.Nombre = foto.Nombre;


                fotoEN.Usuario = foto.Usuario;


                fotoEN.Fecha = foto.Fecha;


                fotoEN.Descripcion = foto.Descripcion;


                fotoEN.Imagen = foto.Imagen;


                fotoEN.Likes = foto.Likes;

                session.Update (fotoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in FotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void BorrarFoto (int id
                        )
{
        try
        {
                SessionInitializeTransaction ();
                FotoEN fotoEN = (FotoEN)session.Load (typeof(FotoEN), id);
                session.Delete (fotoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in FotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: FotoEN
public FotoEN ReadOID (int id
                       )
{
        FotoEN fotoEN = null;

        try
        {
                SessionInitializeTransaction ();
                fotoEN = (FotoEN)session.Get (typeof(FotoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in FotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return fotoEN;
}

public System.Collections.Generic.IList<FotoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<FotoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(FotoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<FotoEN>();
                else
                        result = session.CreateCriteria (typeof(FotoEN)).List<FotoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Fight4FitGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new Fight4FitGenNHibernate.Exceptions.DataLayerException ("Error in FotoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
