using System;
using System.Collections;
using System.Linq;
using System.Text;
using STMA_Financiera.Capa_Dominio;

namespace STMA_Financiera.Capa_Servicios
{
    static class clsSERVIDOR_ASOCIACIONES
    {

        public void Creador(clsOBJETO pObjeto, params object[] pParametros)
        {

        }



        #region 1: Atributos
            #region 1.1: Propios y Derivables
            #endregion

            #region 1.2: Asociativos
            #endregion

            #region 1.3 Puente
            #endregion

            #region 1.4 Estado
            #endregion

        #endregion

        #region 2: Métodos
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

                #region 2.3.2: Mutadores Asociativos y Disociativos
                    static public void AsociarUnObjetoCon(object pObjeto, ArrayList pColeccion)
                    {
                        pColeccion.Add(pObjeto);
                    }
                    static public void DisociarUnObjetoCon(object pObjeto, ArrayList pColeccion)
                    {
                        pColeccion.Remove(pObjeto);
                    }
                    static public bool ExisteObjetoCon(int pOID,ArrayList pColeccion)
                    {
                        bool Existe = false;
                        for (int varPosicion=0;varPosicion< pColeccion.Count; varPosicion++)
                        {
                            clsOBJETO varObjeto = (clsOBJETO)pColeccion[varPosicion];
                            if (pOID == varObjeto.GetOID())
                            {
                                Existe = true;
                            }
                        }
                        return Existe;
                    }
                    static public object ObtenerObjetoCon(int pOID, ArrayList pColeccion)
                    {
                        object varObjetoResultado = null;
                        foreach(object varObjeto in pColeccion)
                        {
                            if (pOID == ((clsOBJETO)varObjeto).GetOID())
                            {
                                varObjetoResultado = varObjeto;
                                break;
                            }
                        }
                        return varObjetoResultado;
                    }
                    static public int ObtenerNuevoOID(ArrayList pColeccion)
                    {
                        return pColeccion.Count+1;
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
