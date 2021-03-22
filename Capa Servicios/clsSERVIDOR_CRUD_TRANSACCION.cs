using System;
using STMA_Financiera.Capa_Dominio;


namespace STMA_Financiera.Capa_Servicios
{
    class clsSERVIDOR_CRUD_TRANSACCION : clsSERVIDOR_CRUD
    {
        static private clsSERVIDOR_CRUD_TRANSACCION atrInstancia = null;
        static public clsSERVIDOR_CRUD_TRANSACCION ObtenerInstancia()
        {
            if (atrInstancia == null)
            {
                atrInstancia = new clsSERVIDOR_CRUD_TRANSACCION();
            }
            return atrInstancia;
           
        }
        public override object Crear(object pObjCreador1, object pObjCreador2, int pOID, params object[] pParametros)
        {
            object varObjTransaccion = new clsTRANSACCION((clsCUENTA)pObjCreador1, (clsDINERO)pObjCreador2, pOID,(string) pParametros[0], (string) pParametros[1]);
            return varObjTransaccion;
        }
    }
}
