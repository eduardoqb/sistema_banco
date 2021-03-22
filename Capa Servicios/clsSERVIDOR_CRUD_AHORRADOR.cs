using System;
using System.Collections;
using STMA_Financiera.Capa_Dominio;

namespace STMA_Financiera.Capa_Servicios
{
    class clsSERVIDOR_CRUD_AHORRADOR : clsSERVIDOR_CRUD
    {
        static private clsSERVIDOR_CRUD_AHORRADOR atrInstancia = null;
        static public clsSERVIDOR_CRUD_AHORRADOR ObtenerInstancia()
        {
            if (atrInstancia == null)
            {
                atrInstancia = new clsSERVIDOR_CRUD_AHORRADOR();
            }
            return atrInstancia;
        }

        public override object Crear(int pOID, params object[] pParametros)
        {
            object varObjeto = new clsAHORRADOR(pOID, (string)pParametros[0], (string)pParametros[1]);
            return varObjeto;
        }    
        public override void Destruir(object pObjAhorrador)
        {
            ((clsAHORRADOR)pObjAhorrador).Destruir();
        }
    }
}
