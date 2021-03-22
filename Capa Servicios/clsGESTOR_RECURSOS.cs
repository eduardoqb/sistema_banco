using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STMA_Financiera.Capa_Servicios
{
    static class clsGESTOR_RECURSOS
    {
        static public void LiberarRecursos()
        {
            GC.Collect();
        }
    }
}
