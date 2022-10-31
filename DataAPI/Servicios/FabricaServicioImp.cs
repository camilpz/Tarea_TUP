using CarpinteriaSLN.DataAPI.Servicios.Interfaz;
using CarpinteriaSNL.DataAPI.Servicios.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaSNL.DataAPI.Servicios
{
    public class FabricaServicioImp : FabricaServicio
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
