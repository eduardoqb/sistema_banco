using System;
using System.Collections;
using STMA_Financiera.Capa_Servicios;

namespace STMA_Financiera.Capa_Dominio
{
    class clsCUENTA : clsOBJETO
    {
        #region 1: Atributos
            #region 1.1: Propios y Derivables
                protected int atrSaldo = -1;
                protected ArrayList atrColMiDinero = new ArrayList();
                protected ArrayList atrColDenominacionesMonedas = new ArrayList() { 20, 50, 100, 200, 500, 1000 };
                protected ArrayList atrColDenominacionesBilletes = new ArrayList() { 1000, 2000, 5000, 10000, 20000, 50000 };
                protected ArrayList atrColMonedasDisponiblesPorDenominacion = new ArrayList() { 0, 0, 0, 0, 0, 0};
                protected ArrayList atrColBilletesDisponiblesPorDenominacion = new ArrayList() { 0, 0, 0, 0, 0, 0 };
            #endregion

            #region 1.2: Asociativos
                protected ArrayList atrColObjsDineros = new ArrayList();
                protected ArrayList atrColObjsTransaccion = new ArrayList();
            #endregion

            #region 1.3 Puente
            #endregion

            #region 1.4 Estado
            #endregion
        #endregion

        #region 2: Métodos
            #region 2.1: Constructor, Clonador, Comparador, Inicializador, Modificador y Destructor
                public clsCUENTA(int pOID,string pNombre) :base(pOID,pNombre)
                {

                }
                protected internal void Destruir()
                {
                    //Eliminar todas las transacciones y disponer de los dinero "Liquidar".
                }
            #endregion

            #region 2.2: Accesores
                #region 2.2.1: Accesores De Atributo Propio y Derivable
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
                #endregion

                #region 2.3.2: Mutadores Asociativos y Disociativos
                #endregion
            #endregion

            #region 2.4: Servicios CRUD
                #region 2.4.1: Registradores
                    protected internal void crudRegistrarObjTransaccion(clsDINERO pObjDinero, int pOID, string pNombre, string pFecha)
                    {
                        clsSERVIDOR_CRUD_TRANSACCION varInstanciaServidorCrud = clsSERVIDOR_CRUD_TRANSACCION.ObtenerInstancia();
                        varInstanciaServidorCrud.crudRegistrarObjeto(this, pObjDinero, this.GetColObjsTransaccion(), pOID, pNombre, pFecha);
                    }
                #endregion

                #region 2.4.2: Actualizadores
                #endregion

                #region 2.4.3: Eliminadores
                #endregion

                #region 2.4.4: Transacciones de Dominio
                protected internal bool Consignacion(clsDINERO pObjDinero)
                {
                    bool varResultado = false;
                    bool VarEsDinero = this.EsDineroAceptable(pObjDinero);
                    if (VarEsDinero)
                    {
                        try
                        {
                            int varNuevoOID=clsSERVIDOR_ASOCIACIONES.ObtenerNuevoOID(this.atrColObjsTransaccion);
                            this.crudRegistrarObjTransaccion(varNuevoOID,"Consignacion","Hoy", pObjDinero);
                            this.atrSaldo = this.atrSaldo + ((clsDINERO)pObjDinero).GetDenominacion();
                            clsSERVIDOR_ASOCIACIONES.AsociarUnObjetoCon(pObjDinero, this.atrColObjsDineros);
                            ((clsDINERO)pObjDinero).SetObjCuenta(this);
                            varResultado = true;
                        }
                        catch (Exception e)
                        {

                        }
                    }
                    return varResultado;
                }

                protected internal bool Retiro(Type pTipo, int pDenominacion)
                {
                    clsDINERO varObjDinero = null;
                    bool varMovimientoAprobado = (pDenominacion <= this.atrSaldo);
                    if (varMovimientoAprobado)
                    {
                        varObjDinero = this.ObtenerObjDineroCon(pTipo,pDenominacion);
                            if (varObjDinero != null)
                            {
                                int varNuevoOID = clsSERVIDOR_ASOCIACIONES.ObtenerNuevoOID(this.atrColObjsTransaccion);
                                this.crudRegistrarObjTransaccion(varNuevoOID,"Retiro","Hoy",varObjDinero);
                                clsSERVIDOR_ASOCIACIONES.DisociarUnObjetoCon(varObjDinero, this.atrColObjsDineros);
                                varObjDinero.SetObjCuenta(null);
                                this.atrSaldo -= pDenominacion;
                            }

                    }

                }

                
        //todas las transacciones que pueden haber entre controlador y banco - servicios de transferencias colocados en controlador con relacion a banco
                //protected internal bool Retiro(clsDINERO pObjDinero)
                //{
                //    bool varMovimientoAprobado = (pObjDinero.GetDenominacion() <= this.atrSaldo);
                //    clsDINERO varObjDinero = null;
                //    if (varMovimientoAprobado)
                //    {
                //        varObjDinero = (clsDINERO)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pObjDinero.GetOID(), this.atrColMiDinero);
                //        for (int varPosicion = 0; varPosicion < this.atrColMiDinero.Count; varPosicion++)
                //        {
                //            varObjDinero = (clsDINERO)this.atrColMiDinero[varPosicion];
                            
                //            if (varObjDinero.GetOID() == pObjDinero.GetOID())
                //            {
                //                clsSERVIDOR_ASOCIACIONES.DisociarUnObjetoCon(pObjDinero, this.atrColMiDinero);
                //                this.crudRegistrarObjTransaccion(pObjDinero.GetOID(), "Retiro", "Hoy", pObjDinero);
                //                pObjDinero.UnSetObjCuenta();
                //                this.atrSaldo = this.atrSaldo - varObjDinero.GetDenominacion();
                //                break;
                //            }
                //        }

                //    }

                //}
                public clsDINERO ObtenerObjDineroCon(Type pTipo, int pDenominacion)
                {
                    clsDINERO varObjetoResultado = null;
                    foreach (clsDINERO varObjDinero in atrColObjsDineros)
                    {
                        if (pTipo == varObjDinero.GetType())
                        {
                            if( pDenominacion ==varObjDinero.GetDenominacion())
                            {
                                varObjetoResultado = varObjDinero;
                                break;
                            }
                        }
                    }
                    return varObjetoResultado;
                }
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
                protected internal bool ComprobarDenominacion(object pObjeto, ArrayList pDenominaciones)
                {
                    bool varResultado = false;
                    for (int varPosicion = 0; varPosicion < pDenominaciones.Count; varPosicion++)
                    {
                        varResultado = varResultado || (((clsDINERO)pObjeto).GetDenominacion() == (int)pDenominaciones[varPosicion]);
                    }
                    return varResultado;
                }
                protected internal bool EsDineroAceptable(object pObjeto)
                {
                    bool varResultado = false;
                    bool varObjetoNoNulo = (pObjeto != null);
                    if (varObjetoNoNulo)
                    {
                        Type varTipoDelObjeto = pObjeto.GetType();
                        bool varEsMoneda = (varTipoDelObjeto == typeof(clsMONEDA));
                        bool varEsBillete = (varTipoDelObjeto == typeof(clsBILLETE));
                        if (varEsBillete)
                        {
                            varResultado = ComprobarDenominacion(pObjeto, this.atrColDenominacionesBilletes);
                        }
                        if (varEsMoneda)
                        {
                            varResultado = ComprobarDenominacion(pObjeto, this.atrColDenominacionesMonedas);
                        }
                    }
                    return varResultado;
                }
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
