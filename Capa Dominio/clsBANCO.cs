using STMA_Financiera.Capa_Servicios;
using System;
using System.Collections;

namespace STMA_Financiera.Capa_Dominio
{
    class clsBANCO : clsOBJETO
    {
        #region 1: Atributos
            #region 1.1: Propios y Derivables
            #endregion

            #region 1.2: Asociativos
                private clsBOVEDA atrObjMiBoveda = null;
                private ArrayList atrColObjMisAHorradores = new ArrayList();
                private ArrayList atrColObjMisAlcancias = new ArrayList();
            #endregion

            #region 1.3 Puente
            #endregion

            #region 1.4 Estado
            #endregion

        #endregion

        #region 2: Métodos
            #region 2.1: Constructor, Clonador, Comparador, Inicializador, Modificador y Destructor
                public clsBANCO(int pOID, string pNombre) : base(pOID, pNombre)
                {
                    this.crudRegistrarObjBoveda();
                }
                public void Destruir(ref ArrayList pColeccionLiquidacion)
                {
                    this.crudEliminarObjBoveda(ref pColeccionLiquidacion);
                    this.crudEliminartTodosObjsAlcancias();

                }
            #endregion

            #region 2.2: Accesores
                #region 2.2.1: Accesores De Atributo Propio y Derivable
                    public clsBOVEDA GetBoveda()
                    {
                        return this.atrObjMiBoveda;
                    }
                    public ArrayList GetAlcancias()
                    {
                        return this.atrColObjMisAlcancias;
                    }
                    //public int GetOID()
                    //{
                    //    return atrOID;
                    //}
                #endregion

                #region 2.2.2: Accesores De Atributo Asociativo
                #endregion
            #endregion

            #region 2.3: Mutadores
                #region 2.3.1: Mutadores De Atributo Propio y Derivable
                    public void setObjMiBoveda(object pObjeto)
                    {
                        this.atrObjMiBoveda = (clsBOVEDA)pObjeto;
                    }
                #endregion

                #region 2.3.2: Mutadores Asociativos y Disociativos
                #endregion
            #endregion

            #region 2.4: Servicios CRUD
                #region 2.4.1: Registradores
                    public void crudRegistrarObjBoveda()
                    {
                        
                    }
                    public void crudRegistrarObjAlcancia(int pOID, string pNombre)
                    {
                        //object varObjAlcancia = clsSERVIDOR_ASOCIACIONES.ExisteObjetoCon(pOID, this.atrColObjMisAlcancias);
                        //if (varObjAlcancia == null)
                        //{
                        //    varObjAlcancia = new clsBANCO(pOID, pNombre);
                        //    clsSERVIDOR_ASOCIACIONES.AsociarUnObjetoCon(varObjAlcancia, this.atrColObjMisAlcancias);
                        //}

                        clsSERVIDOR_CRUD_ALCANCIA varInstanciaServidorCrud = clsSERVIDOR_CRUD_ALCANCIA.ObtenerInstancia();
                        varInstanciaServidorCrud.crudRegistrarObjeto(this, this.atrColObjMisAlcancias, pOID, pNombre);
                    }
                #endregion

                #region 2.4.2: Actualizadores
                    public void crudActualizarObjAlcancia(int pOID, string pNombre)
                    {
                        object varExisteObjeto = clsSERVIDOR_ASOCIACIONES.ExisteObjetoCon(pOID, this.atrColObjMisAlcancias);
                        if (varExisteObjeto != null)
                        {
                            this.Modificar(pNombre);
                        }
                    }
                #endregion

                #region 2.4.3: Eliminadores
                    public void crudEliminarObjAlcancia(int pOID)
                    {
                        clsALCANCIA varObjAlcancia = (clsALCANCIA)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOID, this.atrColObjMisAlcancias);
                        if (varObjAlcancia != null)
                        {
                            clsSERVIDOR_ASOCIACIONES.DisociarUnObjetoCon(varObjAlcancia, this.atrColObjMisAlcancias);
                            varObjAlcancia.Destruir();
                            varObjAlcancia = null;
                            clsGESTOR_RECURSOS.LiberarRecursos();
                        }
                    }
                    public void crudEliminarObjBoveda(ref ArrayList pColeccionLiquidacion)
                    {
                        clsSERVIDOR_CRUD_BOVEDA varInstanciaServidorCrud = clsSERVIDOR_CRUD_BOVEDA.ObtenerInstancia();
                        varInstanciaServidorCrud.crudEliminarObjeto(this.atrObjMiBoveda, ref pColeccionLiquidacion);
                    }
                    public void crudEliminartTodosObjsAlcancias()
                    {
                        clsSERVIDOR_CRUD_ALCANCIA varInstanciaServidorCrud = clsSERVIDOR_CRUD_ALCANCIA.ObtenerInstancia();
                        varInstanciaServidorCrud.crudEliminarTodosObjetos(this.atrColObjMisAlcancias);
                    }
                #region 2.4.4 Transacciones de Dominio
                    public void Tranferencia(clsBANCO varObjBancoDestino, Type pTipo, int pDenominacion)
                    {
                        this.atrObjMiBoveda.Transferencia(this, varObjBancoDestino.GetBoveda(), pTipo, pDenominacion);
                    }
                    public void Transferencia(int pOIDAlcanciaOrigen,clsBANCO varObjBancoDestino,clsALCANCIA pOIDAlcanciaDestino,Type pTipo,int pDenominacion)
                    {
                        clsALCANCIA varObjAlcanciaOrigen = (clsALCANCIA)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDAlcanciaOrigen,);
                        clsALCANCIA varObjAlcanciaDestino = (clsALCANCIA)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDAlcanciaDestino,);
                        varObjAlcanciaOrigen.Transferencia(varObjBancoDestino,pOIDAlcanciaDestino,pTipo pDenominacion);
                    }
                    public void Transferencia(clsBANCO pObjBancoDestino,int pOIDAlcanciaDestino,Type pTipo,int pDenominacion)
                    {
                        clsALCANCIA varObjAlcanciaDestino = (clsALCANCIA)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDAlcanciaDestino,this.GetAlcancias());
                        this.atrObjMiBoveda.Transferencia(varObjAlcanciaDestino, pTipo, pDenominacion);
                    }
                #endregion

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
