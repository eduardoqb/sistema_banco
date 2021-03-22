using System;
using STMA_Financiera.Capa_Servicios;

namespace STMA_Financiera.Capa_Dominio
{
    class clsTRANSACCION : clsOBJETO
    {
        #region 1: Atributos
            #region 1.1: Propios y Derivables
                private string atrFecha = null;
            #endregion

            #region 1.2: Asociativos
                private clsDINERO atrObjDinero = null;
                private clsCUENTA atrObjCuenta = null;
            #endregion

            #region 1.3 Puente
            #endregion

            #region 1.4 Estado
            #endregion
        #endregion

        #region 2: Métodos
            #region 2.1: Constructor, Clonador, Comparador, Inicializador, Modificador y Destructor
                public clsTRANSACCION(clsCUENTA pObjCuenta, clsDINERO pObjDinero,int pOID, string pNombre, string pFecha) : base(pOID, pNombre)
                {
                    this.atrObjCuenta = pObjCuenta;
                    clsSERVIDOR_ASOCIACIONES.AsociarUnObjetoCon(this, pObjCuenta.GetColObjsTransaccion());
                    this.atrObjDinero = pObjDinero;   
                    clsSERVIDOR_ASOCIACIONES.AsociarUnObjetoCon(this, pObjDinero.GetColObjsTransaccion());
                    this.atrFecha = pFecha;
                }
            #endregion

            #region 2.2: Accesores
                #region 2.2.1: Accesores De Atributo Propio y Derivable
                #endregion

                #region 2.2.2: Accesores De Atributo Asociativo
                #endregion
            #endregion

            #region 2.3: Mutadores
                #region 2.3.1: Mutadores De Atributo Propio y Derivable
                #endregion

                #region 2.3.2: Mutadores Asociativos y Disociativos
                #endregion
            #endregion

            #region 2.4: Servicios CRUD
                #region 2.4.1: Registradores
                #endregion

                #region 2.4.2: Actualizadores
                #endregion

                #region 2.4.3: Eliminadores
                #endregion
            #endregion

            #region 2.5: Servicios de Persistencia
                #region 2.5.1: Materializadores
                #endregion

                #region 2.5.2: Des-Materializadores
                #endregion

                #region 2.5.3: Serializadores
                #endregion
        
                #region 2.5.4 Des-Serializadores
                #endregion
            #endregion

            #region 2.6: Servicios de Consulta
            #endregion

            #region 2.7: Servicios de IGU
                #region 2.7.1: Servicios de Navegación
                #endregion

                #region 2.7.2: Gestión Estado de Campos y Comandos IGU
                #endregion
        
                #region 2.7.3: Gestión de Campos IGU
                #endregion

                #region 2.7.4: Servición de Validación
                #endregion
            #endregion
        #endregion
    }
}
