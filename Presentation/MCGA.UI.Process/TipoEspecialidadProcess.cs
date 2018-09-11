using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCGA.Business;
using MCGA.Entities;

namespace MCGA.UI.Process
{
   public class TipoEspecialidadProcess
    {
        public TipoEspecialidadComponent component = new TipoEspecialidadComponent();

        public List<TipoEspecialidad> ToList()
        {
            return component.ToList();
        }
    }
}
