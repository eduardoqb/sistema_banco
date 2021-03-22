using System;
using System.Collections;
using STMA_Financiera.Capa_Dominio;

namespace STMA_Financiera.Capa_Servicios
{
    public class clsSERVIDOR_CRUD_BANCO : clsSERVIDOR_CRUD
    {
        static private clsSERVIDOR_CRUD_BANCO atrInstancia = null;
        static public clsSERVIDOR_CRUD_BANCO ObtenerInstancia()
        {
            if(atrInstancia == null)
            {
                atrInstancia = new clsSERVIDOR_CRUD_BANCO();
            }
            return atrInstancia;
        }

        public override object Crear(int pOID, params object[] pParametros)  // !!! Pendiente !!!  Realizar Prueba reemplazando params por los parametros individuales correspondientes a la clase (Banco).
        {
            object varObjeto = new clsBANCO(pOID, (string) pParametros[0]);
            return varObjeto;
        }
        public override void Modificar(object pObjeto, params object[] pParametros)
        {
            ((clsBANCO)pObjeto).Modificar((string)pParametros[0]);
        }
        public override void Destruir(object pObjeto,ref ArrayList pColeccionLiquidacion)
        {
            ((clsBANCO)pObjeto).Destruir(ref pColeccionLiquidacion);
        }

        //Patron Diseño: Polimorfismo y Factoria.
    }
}
