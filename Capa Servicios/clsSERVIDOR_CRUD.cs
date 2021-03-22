using System;
using System.Collections;
using System.Linq;
using System.Text;
using STMA_Financiera.Capa_Dominio;

namespace STMA_Financiera.Capa_Servicios
{
    class clsSERVIDOR_CRUD
    {
        #region 1: Metodos Virtuales
            #region 1.1: Creadores de Objetos
                public virtual object Crear(object pObjCreador)
                {
                    return null;
                }
                public virtual object Crear(int pOID, params object[] pParametros)
                {
                    return null;
                }
                public virtual object Crear(object pObjCreador, int pOID, params object[] pParametros)
                {
                    return null;
                }
                public virtual object Crear(object pObjCreador1,object pObjCreador2, int pOID, params object[] pParametros)
                {
                    return null;
                }
            #endregion

            #region 1.2: Modificadores de Objetos
                public virtual void Modificar(object pObjeto, params object[] pParametros)
                {
                }
            #endregion

            #region 1.3: Destructores de Objetos
                public virtual void Destruir(object pObjeto)
                {   
                }
                public virtual void Destruir(object pObjeto, ref ArrayList pColeccionLiquidacion)
        {
        }
            #endregion
        #endregion
        public void crudRegistrarObjeto(object pObjCreador, object pObjAtributo)
        {
            if (pObjAtributo == null)
            {
                pObjAtributo = this.Crear(pObjCreador);
            }
        }
        public void crudRegistrarObjeto(ArrayList pColeccion, int pOID, params object[] pParametros)
        {
            object varObjeto = clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOID, pColeccion);
            if (varObjeto == null)
            {
                varObjeto = this.Crear(pOID, pParametros);
                clsSERVIDOR_ASOCIACIONES.AsociarUnObjetoCon(varObjeto, pColeccion);
            }
        }
        public void crudRegistrarObjeto(object pObjCreador,ArrayList pColeccion, int pOID, params object[] pParametros)
        {
            object varObjeto = clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOID, pColeccion);
            if (varObjeto == null)
            {
                varObjeto = this.Crear(pObjCreador, pOID, pParametros);
            }
        }
        public void crudRegistrarObjeto(object pObjCreador1, object pObjCreador2, ArrayList pColeccion, int pOID, params object[] pParametros)
        {
            object varObjeto = clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOID, pColeccion);
            if (varObjeto == null)
            {
                varObjeto = this.Crear(pObjCreador1, pObjCreador2, pOID, pParametros);
            }
        }
        public void crudActualizarObjeto(ArrayList pColeccion, int pOID, params object[] pParametros)
        {
            object varObjeto = clsSERVIDOR_ASOCIACIONES.ExisteObjetoCon(pOID,pColeccion);
            if (varObjeto != null)
            {
                this.Modificar(varObjeto,pParametros);
            }
        }
        public void crudEliminarObjeto(ArrayList pColeccion, int pOID)
        {
            object varObjeto = clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOID, pColeccion);
            if (varObjeto != null)
            {
                clsSERVIDOR_ASOCIACIONES.DisociarUnObjetoCon(varObjeto, pColeccion);
                this.Destruir(varObjeto);
                varObjeto = null;
                clsGESTOR_RECURSOS.LiberarRecursos();
            }
        }
        public void crudEliminarObjeto(object pObjAtributo)
        {
            if(pObjAtributo!=null)
            {
                this.Destruir(pObjAtributo);
                clsGESTOR_RECURSOS.LiberarRecursos();
            }
        }
        public void crudEliminarObjeto(ArrayList pColeccion, int pOID, ref ArrayList pColeccionLiquidacion)
        {
            object varObjeto = clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOID, pColeccion);
            if (varObjeto != null)
            {
                clsSERVIDOR_ASOCIACIONES.DisociarUnObjetoCon(varObjeto, pColeccion);
                this.Destruir(varObjeto,ref pColeccionLiquidacion);
                varObjeto = null;
                clsGESTOR_RECURSOS.LiberarRecursos();
            }
        }
        public void crudEliminarObjeto(object pObjAtributo, ref ArrayList pColeccionLiquidacion)
        {
            if (pObjAtributo != null)
            {
                this.Destruir(pObjAtributo, ref pColeccionLiquidacion);
                clsGESTOR_RECURSOS.LiberarRecursos();
            }
        }
        public void crudEliminarTodosObjetos(ArrayList pColeccion)
        {
            object varObjeto;
            foreach (object varObjetoPuente in pColeccion)
            {
                varObjeto = varObjetoPuente;
                this.Destruir(varObjeto);
                varObjeto = null;
                clsGESTOR_RECURSOS.LiberarRecursos();
            }
        }
    }
}
