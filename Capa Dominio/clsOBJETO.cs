using System;

namespace STMA_Financiera.Capa_Dominio
{
    class clsOBJETO
    {
        #region 1: Atributos
            #region 1.1: Propios y Derivables
                protected int atrOID = -1;
                protected string atrNombre = null;
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
                protected clsOBJETO(int pOID, string pNombre)
                {
                    this.atrOID = pOID;
                    this.atrNombre = pNombre;
                }
                protected internal void Modificar(string pNombre)
                {
                    this.atrNombre = pNombre;
                }
            #endregion

            #region 2.2: Accesores
                #region 2.2.1: Accesores De Atributo Propio y Derivable
                    protected internal int GetOID()
                    {
                        return this.atrOID;
                    }
                #endregion

                #region 2.2.2: Accesores De Atributo Asociativo
                #endregion
            #endregion

            #region 2.3: Mutadores
                #region 2.3.1: Mutadores De Atributo Propio y Derivable
                    //protected internal void SetNombre(string pNombre)
                    //{
                      //  this.atrNombre = pNombre;
                    //}
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
