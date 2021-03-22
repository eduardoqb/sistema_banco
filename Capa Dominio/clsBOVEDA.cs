using System;
using System.Collections;

namespace STMA_Financiera.Capa_Dominio
{
    class clsBOVEDA : clsCUENTA
    {
        #region 1: Atributos
            #region 1.1: Propios y Derivables
            #endregion

            #region 1.2: Asociativos
                private clsBANCO atrObjMiBanco = null;
            #endregion

            #region 1.3 Puente
            #endregion

            #region 1.4 Estado
            #endregion
        #endregion

        #region 2: Métodos
            #region 2.1: Constructor, Clonador, Comparador, Inicializador, Modificador y Destructor
            public clsBOVEDA(clsBANCO pObjBanco) : base(1,"Boveda")
            {
                this.atrObjMiBanco=pObjBanco;
            }
            public void Destruir(ref ArrayList pColeccionLiquidacion)
            {
                base.Destruir();
                this.Liquidar(ref pColeccionLiquidacion);
                this.atrObjMiBanco.setObjMiBoveda(null);
                this.atrObjMiBanco=null;
            } 
            #endregion

            public int Transferencia(clsBANCO varObjBancoOrigen,clsALCANCIA varObjBancoDestino.GetAlcancia(),int pTipo,int pDenominacion)
            {

            }

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
                    public void SetObjBanco(object pObjBanco)
                    {
                        this.atrObjMiBanco = pObjBanco;
                    }
                #endregion
            #endregion

            #region 2.4: Servicios CRUD
                #region 2.4.1: Registradores
                #endregion

                #region 2.4.2: Actualizadores
                #endregion

                #region 2.4.3: Eliminadores
                #endregion
                #region 2.4.4: Transacciones de Dominio
                    public void Liquidar(ref ArrayList pColeccionLiquidacion)
                    {
                        //trasladar todos los objetos atrColMiDinero hacia la coleccion dinero que tiene el controlador
                        foreach(object varObjDinero in this.atrColObjsDineros)
                        {
                            pColeccionLiquidacion.Add(varObjDinero);
                        }
                        this.atrColObjsDineros.RemoveRange(0,this.atrColObjsDineros.Count -1);
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
