using MCGA.Data;
using MCGA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCGA.Business
{
    public class TipoEspecialidadComponent
    {
        private MedicureContext db = new MedicureContext();
       

        public List<TipoEspecialidad> ToList()
        {
            return db.TipoEspecialidad.ToList();
        }
    }
}
