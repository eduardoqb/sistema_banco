using System;
using System.Collections;
using STMA_Financiera.Capa_Dominio;
using STMA_Financiera.Capa_Servicios;

namespace STMA_Financiera.Capa_Coordinacion
{
    static class clsCONTROLADOR
    {
        #region 1. Atributos
            #region 1.1 Propios y Derivables
                static private ArrayList atrMisTipos = new ArrayList {typeof(clsBANCO),typeof(clsAHORRADOR),typeof(clsMONEDA),typeof(clsBILLETE)};
                //static private ArrayList varMisParametros = new ArrayList {pOID, pNombre, pDenominacion, pAño, pMes, pDia };
            #endregion

            #region 1.2 Asociativos
                static private ArrayList atrColMisDineros = new ArrayList();
                static private ArrayList atrColMisAhorradores = new ArrayList();
                static private ArrayList atrColMisBancos = new ArrayList();
            #endregion

            #region 1.3 Puente
            #endregion

            #region 1.4 Estado
            #endregion
        #endregion

        #region 2. Metodos
            #region 2.1: Constructor, Clonador, Comparador, Inicializador, Modificador y Destructor
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

                #region 2.3.2 Mutadores Asociativos y Disociativos
                    static private void registrarDineroEnCuenta()
                    {

                    }
                #endregion
            #endregion

            #region 2.4: Servicios CRUD
                #region 2.4.1: Registradores
                    /*static public void crudRegistrarObjeto(Type pTipo, int pOID, string pNombre, string pApellidos, int pDenominacion, int pAño, int pMes, int pDia)
                    {
                        //int pOID; string pNombre; string pApellidos; int pDenominacion; int pAño; int pMes; int pDia;
                    

                        if(pTipo==typeof(clsBANCO))
                        {
                            clsBANCO varObjeto = new clsBANCO(int.Parse(pMisParametros[0].ToString()), pNombre);
                            clsSERVIDOR_ASOCIACIONES.AsociarUnObjeto(varObjeto,atrMisBancos);
                        }
                        if (pTipo == typeof(clsAHORRADOR))
                        {
                            clsAHORRADOR varObjeto = new clsAHORRADOR(pOID, pNombre, pApellidos);
                            clsSERVIDOR_ASOCIACIONES.AsociarUnObjeto(varObjeto, atrMisAhorradores);
                        }
                        if (pTipo == typeof(clsMONEDA))
                        {
                            clsMONEDA varObjeto = new clsMONEDA(pOID, pNombre, pDenominacion, pAño);
                            clsSERVIDOR_ASOCIACIONES.AsociarUnObjeto(varObjeto, atrMisDineros);
                        }
                        if (pTipo == typeof(clsBILLETE))
                        {
                            clsBILLETE varObjeto = new clsBILLETE(pOID, pNombre, pDenominacion, pAño, pMes, pDia);
                            clsSERVIDOR_ASOCIACIONES.AsociarUnObjeto(varObjeto, atrMisDineros);
                        }
                    }
                     
                    static private void servicio(ArgIterator pMisParametros)                           //ArgIterator
                    {
   
                    }*/

                    static public void crudResgistrarObjetoBanco(int pOID, string pNombre) // Version anterior: "params object[] pParametros".
                    {
                        
                        clsSERVIDOR_CRUD_BANCO varInstanciaServidorCrud = clsSERVIDOR_CRUD_BANCO.ObtenerInstancia();
                        varInstanciaServidorCrud.crudRegistrarObjeto(atrColMisBancos, pOID, pNombre);
                    }
                    static public void crudResgistrarObjetoAhorrador(int pOID, string pNombre, string pApellido)
                    {
                        clsSERVIDOR_CRUD_AHORRADOR varInstanciaServidorCrud = clsSERVIDOR_CRUD_AHORRADOR.ObtenerInstancia();
                        varInstanciaServidorCrud.crudRegistrarObjeto(atrColMisAhorradores, pOID, pNombre, pApellido);
                    }
                    static public void crudRegistrarObjetoMoneda(int pOID, string pValorEnLetras, int pDenominacion, int pAño)
                    {
                        clsSERVIDOR_CRUD_MONEDA varInstanciaServidorCrud = clsSERVIDOR_CRUD_MONEDA.ObtenerInstancia();
                        varInstanciaServidorCrud.crudRegistrarObjeto(atrColMisDineros, pOID, pValorEnLetras, pDenominacion, pAño);
                    }
                    static public void crudRegistrarObjetoBillete(int pOID, string pValorEnLetras, int pDenominacion, int pAño, int pMes, int pDia)
                    {
                        clsSERVIDOR_CRUD_BILLETE varInstanciaObjetoBillete = clsSERVIDOR_CRUD_BILLETE.ObtenerInstancia();
                        varInstanciaObjetoBillete.crudRegistrarObjeto(atrColMisDineros, pOID, pValorEnLetras, pDenominacion, pAño, pMes, pDia);
                    }
                    static public void crudRegistrarObjetoAlcancia(int pOIDBanco, int pOID, string pNombre)
                    {
                        object varObjBanco =clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDBanco, atrColMisBancos);
                        ((clsBANCO)varObjBanco).crudRegistrarObjAlcancia(pOID, pNombre);
                    }

                    //static public void crudRegistrarObjBanco(int pOID, string pNombre)
                    //{
                    //    object varExisteObjeto = null;
                    //    varExisteObjeto=clsSERVIDOR_ASOCIACIONES.ExisteObjetoCon(pOID,clsCONTROLADOR.atrColMisBancos);
                    //    if(varExisteObjeto!=null)
                    //    {
                    //        clsBANCO varObjBanco = new clsBANCO(pOID, pNombre);
                    //        clsSERVIDOR_ASOCIACIONES.AsociarUnObjetoCon(varObjBanco, atrColMisBancos);
                    //    }
                    //}
                    //static public void crudRegistrarObjAhorrador(int pOID, string pNombre, string pApellidos)
                    //{
                    //    object varExisteObjeto = false;
                    //    varExisteObjeto = clsSERVIDOR_ASOCIACIONES.ExisteObjetoCon(pOID, clsCONTROLADOR.atrColMisAhorradores);
                    //    if (varExisteObjeto != null)
                    //    {
                    //        //Heuristicas:
                    //        //1.Crear e inicializar el nuevo objeto.
                    //        clsAHORRADOR varObjAhorrador = new clsAHORRADOR(pOID, pNombre, pApellidos);

                    //        //2.Asociar el nuevo objeto a su patron creador.
                    //        clsSERVIDOR_ASOCIACIONES.AsociarUnObjetoCon(varObjAhorrador, atrColMisAhorradores);
                    //    }                    
                    //}
                    //static public void crudRegistrarObjBillete(int pOID, string pValorEnLetras, int pDenominacion, int pAño, int pMes, int pDia)
                    //{
                    //    object varExisteObjeto = false;
                    //    varExisteObjeto = clsSERVIDOR_ASOCIACIONES.ExisteObjetoCon(pOID, clsCONTROLADOR.atrColMisDineros);
                    //    if (varExisteObjeto != null)
                    //    {
                    //        //Heuristicas:
                    //        //1.Crear e inicializar el nuevo objeto.
                    //        clsBILLETE varObjBillete = new clsBILLETE(pOID, pValorEnLetras, pDenominacion, pAño, pMes, pDia);

                    //        //2.Asociar el nuevo objeto a su patron creador.
                    //        clsSERVIDOR_ASOCIACIONES.AsociarUnObjetoCon(varObjBillete, atrColMisDineros);
                    //    }
                    //}
                    //static public void crudRegistrarObjMoneda(int pOID, string pValorEnLetras, int pDenominacion, int pAño)
                    //{
                    //    object varExisteObjeto = false;
                    //    varExisteObjeto = clsSERVIDOR_ASOCIACIONES.ExisteObjetoCon(pOID, clsCONTROLADOR.atrColMisDineros);
                    //    if (varExisteObjeto != null)
                    //    {
                    //        //Heuristicas:
                    //        //1.Crear e inicializar el nuevo objeto.
                    //        clsMONEDA varObjMoneda = new clsMONEDA(pOID, pValorEnLetras, pDenominacion, pAño);

                    //        //2.Asociar el nuevo objeto a su patron creador.
                    //        clsSERVIDOR_ASOCIACIONES.AsociarUnObjetoCon(varObjMoneda, atrColMisDineros);
                    //    }
                   
                    //}
                #endregion

                #region 2.4.2: Actualizadores
                    //static public void crudActualizarObjBanco(int pOID, string pNombre)
                    //{
                    //    // Heuristica:
                    //    //1. Buscar, Encontrar y Recuperar el Objeto usando el criterio OID.
                    //    //2. Modificar el Objeto Recuperado.
                    //    clsBANCO varObjBanco = (clsBANCO)clsSERVIDOR_ASOCIACIONES.ExisteObjetoCon(pOID, clsCONTROLADOR.atrColMisBancos);
                    //    if (varObjBanco!= null)
                    //    {
                    //        varObjBanco.Modificar(pNombre);
                    //    }
                    //}

                    static public void crudActualizarObjBanco(int pOID, string pNombre)
                    {
                        clsSERVIDOR_CRUD_BANCO varInstanciaServidorCrud = clsSERVIDOR_CRUD_BANCO.ObtenerInstancia();
                        varInstanciaServidorCrud.crudActualizarObjeto(atrColMisBancos, pOID, pNombre);
                    }
                    static public void crudActualizarObjAhorrador(int pOID, string pNombre, string pApellidos)
                    {
                        // Heuristica:
                        //1. Buscar, Encontrar y Recuperar el Objeto usando el criterio OID.
                        //2. Modificar el Objeto Recuperado.
                        clsSERVIDOR_CRUD_AHORRADOR varInstanciaServidorCrud = clsSERVIDOR_CRUD_AHORRADOR.ObtenerInstancia();
                        varInstanciaServidorCrud.crudActualizarObjeto(atrColMisAhorradores, pOID, pNombre, pApellidos);
                    }
                    static public void crudActualizarObjMoneda(int pOID, string pValorEnLetras, int pDenominacion, int pAño)
                    {
                        // Heuristica:
                        //1. Buscar, Encontrar y Recuperar el Objeto usando el criterio OID.
                        //2. Modificar el Objeto Recuperado.

                        clsSERVIDOR_CRUD_MONEDA varInstanciaServidorCrud = clsSERVIDOR_CRUD_MONEDA.ObtenerInstancia();
                        varInstanciaServidorCrud.crudActualizarObjeto(atrColMisDineros, pOID, pValorEnLetras, pDenominacion, pAño);
                    }
                    static public void crudActualizarObjBillete(int pOID, string pValorEnLetras, int pDenominacion, int pAño, int pMes, int pDia)
                    {
                        // Heuristica:
                        //1. Buscar, Encontrar y Recuperar el Objeto usando el criterio OID.
                        //2. Modificar el Objeto Recuperado.

                        clsSERVIDOR_CRUD_BILLETE varInstanciaServidorCrud = clsSERVIDOR_CRUD_BILLETE.ObtenerInstancia();
                        varInstanciaServidorCrud.crudActualizarObjeto(atrColMisDineros, pOID, pValorEnLetras, pDenominacion, pAño, pMes, pDia);
                    }
                #endregion

                #region 2.4.3: Eliminadores
                    //static public void crudEliminarObjBanco(int pOID)
                    //{
                    //    //1.Buscar-Encontrar-Recuperar el objeto con OID.
                    //    clsBANCO varObjBanco = (clsBANCO)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOID, clsCONTROLADOR.atrColMisBancos);
                    //    if (varObjBanco != null)
                    //    {
                    //        //2.Disociar el objeto de su Patron Creador.
                    //        clsSERVIDOR_ASOCIACIONES.DisociarUnObjetoCon(varObjBanco,clsCONTROLADOR.atrColMisBancos);
                    //        //3.Invocar la logica Pre-Destruccion del objeto.
                    //        varObjBanco.Destruir();
                    //        //4.Apuntar el objeto a nulo para que se invoque de forma implicita el destructor de la clase.
                    //        varObjBanco=null;
                    //        //5.Invocar el recolector de basura.
                    //        clsGESTOR_RECURSOS.LiberarRecursos();
                    //    }
                    //}
                    static public void crudEliminarObjBanco(int pOID)
                    {
                        //invocar y delegar a la instancia de servidor crud Banco.
                        clsSERVIDOR_CRUD_BANCO varInstanciaServidorCrud = clsSERVIDOR_CRUD_BANCO.ObtenerInstancia();
                        varInstanciaServidorCrud.crudEliminarObjeto(atrColMisBancos, pOID, ref atrColMisDineros);
                    }

                    static public void crudEliminarObjAhorrador(int pOID)
                    {
                        clsSERVIDOR_CRUD_AHORRADOR varInstanciaServidorCrud = clsSERVIDOR_CRUD_AHORRADOR.ObtenerInstancia();
                        varInstanciaServidorCrud.crudEliminarObjeto(atrColMisAhorradores, pOID);
                    }
                    static public void crudEliminarObjDinero(int pOID)
                    {
                        clsSERVIDOR_CRUD_DINERO varInstanciaServidorCrud = clsSERVIDOR_CRUD_DINERO.ObtenerInstancia();
                        varInstanciaServidorCrud.crudEliminarObjeto(atrColMisDineros, pOID);
                    }
                #endregion
            #endregion

            #region 2.4.4 Transacciones de Dominio
                    static public void Tranferencia(int pOIDBancoOrigen, int pOIDBancoDestino, Type pTipo, int pDenominacion)
                    {
                        clsBANCO varObjBancoOrigen = (clsBANCO)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDBancoOrigen, atrColMisBancos);
                        clsBANCO varObjBancoDestino = (clsBANCO)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDBancoDestino, atrColMisBancos);
                        varObjBancoOrigen.Transferencia(varObjBancoDestino, pTipo, pDenominacion);

                    }

                    public void TransferenciaEntreBancos(int pOIDBancoOrigen, int pOIDBancoDestino, int pOIDAlcanciaOrigen, int pOIDAlcanciaDestino, Type pTipo, int pDenominacion)
                    {
                        clsBANCO varObjBancoOrigen = (clsBANCO)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDBancoOrigen, atrColMisBancos);
                        clsBANCO varObjBancoDestino = (clsBANCO)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDBancoDestino, atrColMisBancos);
                        varObjBancoOrigen.Transferencia(pOIDBancoOrigen, varObjBancoDestino, pOIDAlcanciaDestino, pTipo, pDenominacion);
                    }
                    public void TransferenciaEntreBancos(int pOIDBancoOrigen, int pOIDBancoDestino,int pOIDAlcanciaDestino, Type pTipo, int pDenominacion)
                    {
                        clsBANCO varObjBancoOrigen = (clsBANCO)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDBancoOrigen, atrColMisBancos);
                        clsBANCO varObjBancoDestino = (clsBANCO)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDBancoDestino, atrColMisBancos);
                        varObjBancoOrigen.Transferencia(varObjBancoDestino, pOIDAlcanciaDestino, pTipo, pDenominacion);
                    }

                   public void TransferenciaEntreAhorradores(int pOIDAhorradorOrigen, int pOIDAhorradorDestino,int pOIDBilleteraDestino, Type pTipo, int pDenominacion)
                   {
                       clsAHORRADOR varObjAhorradorOrigen = (clsAHORRADOR)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDAhorradorOrigen, atrColMisAhorradores);
                       clsAHORRADOR varObjAhorradorDestino = (clsAHORRADOR)clsSERVIDOR_ASOCIACIONES.ObtenerObjetoCon(pOIDAhorradorDestino, atrColMisAhorradores);
                       varObjAhorradorOrigen.Transferencia(varObjAhorradorDestino, pTipo, pDenominacion);
                   }
        //biiletera a billetera entre distintos ahorradores 
        //salon 200 FIC Inge civil ultimo salon 9-11 mañana miercoles
        //de banco a origen entre distintos bancos
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
