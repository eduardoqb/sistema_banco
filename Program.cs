using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using STMA_Financiera.Capa_Coordinacion;
//using STMA_Financiera.Capa_Presentacion;

namespace STMA_Financiera
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            clsCONTROLADOR.crudRegistrarObjBanco(496, "Banco de Bogota - La Herreria" );
            clsCONTROLADOR.crudRegistrarObjAhorrador(300, "Fulano","De Quien");
            clsCONTROLADOR.crudRegistrarObjMoneda(543, "Quinientos Pesos", 500, 2010);
            //clsCONTROLADOR.crudResgistrarObjBillete(498723,);
            clsCONTROLADOR.
        }
    }
}
