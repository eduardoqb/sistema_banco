using System;
using System.Collections;
using STMA_Financiera.Capa_Servicios;

namespace STMA_Financiera.Capa_Dominio
{
    class clsDINERO : clsOBJETO
    {
        #region 1: Atributos
            #region 1.1: Propios y Derivables
                protected int atrDenominacion = -1;
                protected int atrAño = -1;
            #endregion

            #region 1.2: Asociativos
                protected clsCUENTA atrObjCuenta = null;
                protected ArrayList atrColObjsTransaccion = new ArrayList();
            #endregion

            #region 1.3 Puente
            #endregion

            #region 1.4 Estado
            #endregion
        #endregion

        #region 2: Métodos
            #region 2.1: Constructor, Clonador, Comparador, Inicializador, Modificador y Destructor
                public clsDINERO(int pOID, string pValorEnLetras, int pDenominacion, int pAño):base(pOID,pValorEnLetras)
                {
                    this.atrDenominacion = pDenominacion;
                    this.atrAño=pAño;
                }
                protected internal void Modificar(string pValorEnLetras, int pDenominacion, int pAño)
                {
                    base.Modificar(pValorEnLetras);
                    this.atrDenominacion = pDenominacion;
                    this.atrAño = pAño;
                }
                protected internal void Destruir()
                {

                }
            #endregion

            #region 2.2: Accesores
                #region 2.2.1: Accesores De Atributo Propio y Derivable
                    protected internal int GetDenominacion()
                    {
                        return this.atrDenominacion;
                    }
                    protected internal ArrayList GetColObjsTransaccion()
                    {
                        return this.atrColObjsTransaccion;
                    }
                #endregion

                #region 2.2.2: Accesores De Atributo Asociativo
                #endregion
            #endregion

            #region 2.3: Mutadores
                #region 2.3.1: Mutadores De Atributo Propio y Derivable
                    protected internal void SetObjCuenta(clsCUENTA pObjeto)
                    {
                        this.atrObjCuenta = pObjeto;
                    }
                    protected internal void UnSetObjCuenta()
                    {
                        this.atrObjCuenta = null;
                    }
                #endregion

                #region 2.3.2: Mutadores Asociativos y Disociativos
                #endregion
            #endregion

            #region 2.4: Servicios CRUD
                #region 2.4.1: Registradores
                    protected internal void crudRegistrarObjTransaccion(clsCUENTA pObjCuenta, int pOID, string pNombre, string pFecha)
                    {
                        clsSERVIDOR_CRUD_TRANSACCION varInstanciaServidorCrud = clsSERVIDOR_CRUD_TRANSACCION.ObtenerInstancia();
                        varInstanciaServidorCrud.crudRegistrarObjeto(pObjCuenta, this, this.GetColObjsTransaccion(), pOID, pNombre, pFecha);
                    }
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
