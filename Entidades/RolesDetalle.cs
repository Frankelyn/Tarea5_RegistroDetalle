using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.Entidades
{
    public class RolesDetalle
    {
        [Key]
        public int RolDetalleId { get; set; }

        public int RolId { get; set; }

        public int PermisoId { get; set; }

        public bool esAsignado { get; set; }

    }
}
