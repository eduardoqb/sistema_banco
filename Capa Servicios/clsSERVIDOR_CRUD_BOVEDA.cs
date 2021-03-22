using System;
using System.Collections;
using System.Linq;
using System.Text;
using STMA_Financiera.Capa_Dominio;

namespace STMA_Financiera.Capa_Servicios
{
    class clsSERVIDOR_CRUD_BOVEDA : clsSERVIDOR_CRUD
    {
        static private clsSERVIDOR_CRUD_BOVEDA atrInstancia = null;
        static public clsSERVIDOR_CRUD_BOVEDA ObtenerInstancia()
        {
            if (atrInstancia == null)
            {
                atrInstancia = new clsSERVIDOR_CRUD_BOVEDA();
            }
            return atrInstancia;
        }
        public override object Crear(clsBANCO pObjCreador,int pOID, params object[] pParametros)
        {
            object varObjBoveda = new clsBOVEDA(pObjCreador);
            return varObjBoveda;
        }
        public override void Destruir(object pObjeto,ref ArrayList pColeccionLiquidacion)
        {
            ((clsBOVEDA)pObjeto).Destruir(ref pColeccionLiquidacion);
        }
    }
}
