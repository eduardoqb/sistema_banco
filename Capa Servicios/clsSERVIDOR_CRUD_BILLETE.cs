using System;
using STMA_Financiera.Capa_Dominio;

namespace STMA_Financiera.Capa_Servicios
{
    class clsSERVIDOR_CRUD_BILLETE : clsSERVIDOR_CRUD_DINERO
    {
        static private clsSERVIDOR_CRUD_BILLETE atrInstancia= null;
        static public clsSERVIDOR_CRUD_BILLETE ObtenerInstancia()
        {
            if(atrInstancia == null)
            {
                atrInstancia = new clsSERVIDOR_CRUD_BILLETE();
            }
            return atrInstancia;
        }
        public override object Crear(int pOID, params Object[] pParametros)
        {
            object varObjBillete = new clsBILLETE(pOID, (string)pParametros[0], (int)pParametros[1], (int)pParametros[2], (int)pParametros[3], (int)pParametros[4]);
            return varObjBillete;
        }
    }
}
