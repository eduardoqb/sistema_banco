using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using STMA_Financiera.Capa_Dominio;

namespace STMA_Financiera.Capa_Servicios
{
    class clsSERVIDOR_CRUD_ALCANCIA : clsSERVIDOR_CRUD
    {
        static private clsSERVIDOR_CRUD_ALCANCIA atrInstancia = null;
        static public clsSERVIDOR_CRUD_ALCANCIA ObtenerInstancia()
        {
            if (atrInstancia == null)
            {
                atrInstancia = new clsSERVIDOR_CRUD_ALCANCIA();
            }
            return atrInstancia;
        }

        public override object Crear(object pObjCreador,int pOID, params object[] pParametros)
        {
            object varObjeto = new clsALCANCIA((clsBANCO)pObjCreador,pOID, (string)pParametros[0]);
            return varObjeto;
        }
        public override void Destruir(object pObjeto)
        {
            ((clsALCANCIA)pObjeto).Destruir();
        }
    }
}
