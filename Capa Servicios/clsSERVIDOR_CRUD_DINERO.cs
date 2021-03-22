using System;
using STMA_Financiera.Capa_Dominio;

namespace STMA_Financiera.Capa_Servicios
{
    class clsSERVIDOR_CRUD_DINERO : clsSERVIDOR_CRUD
    {
        static private clsSERVIDOR_CRUD_DINERO atrInstancia = null;
        static public clsSERVIDOR_CRUD_DINERO ObtenerInstancia()
        {
            if (atrInstancia == null)
            {
                atrInstancia = new clsSERVIDOR_CRUD_DINERO();
            }
            return atrInstancia;
        }
       //crud base si tiene el destruir
        public override void Destruir(object pObjeto)
        {
            ((clsDINERO)pObjeto).Destruir();
        }
    }
}
