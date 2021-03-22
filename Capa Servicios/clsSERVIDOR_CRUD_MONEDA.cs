using System;
using STMA_Financiera.Capa_Dominio;

namespace STMA_Financiera.Capa_Servicios
{
    class clsSERVIDOR_CRUD_MONEDA : clsSERVIDOR_CRUD_DINERO
    {
        static private clsSERVIDOR_CRUD_MONEDA atrInstancia = null;
        static public clsSERVIDOR_CRUD_MONEDA ObtenerInstancia()
        {
            if(atrInstancia == null)
            {
                atrInstancia = new clsSERVIDOR_CRUD_MONEDA();
            }
            return atrInstancia;
        }
        public override object Crear(int pOID, params object[] pParametros)
        {
            object varObjMoneda = new clsMONEDA(pOID,(string) pParametros[0],(int) pParametros[1],(int) pParametros[2]);
            return varObjMoneda;
        }
    }
}
