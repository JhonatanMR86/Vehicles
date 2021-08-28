using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public class SeeDb
    {
        private readonly DataContext _context;
        public SeeDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeeAsync() 
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckVehiclesTypeAsync();
            await CheckProceduresAsync();
        }

        private async Task CheckProceduresAsync()
        {
            if (!_context.Procedures.Any())
            {
                _context.Procedures.Add(new procedure { price = 10000, Description = "Alineación" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Lubricación de suspención delantera" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Lubricación de suspención trasera" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Frenos delanteros" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Frenos traseros" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Líquido frenos delanteros" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Líquido frenos traseros" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Calibración de válvulas" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Alineación carburador" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Aceite motor" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Aceite caja" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Filtro de aire" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Sistema eléctrico" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Guayas" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Cambio llanta delantera" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Cambio llanta trasera" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Reparación de motor" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Kit arrastre" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Banda transmisión" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Cambio batería" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Lavado sistema de inyección" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Lavada de tanque" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Cambio de bujia" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Cambio rodamiento delantero" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Cambio rodamiento trasero" });
                _context.Procedures.Add(new procedure { price = 10000, Description = "Accesorios" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckVehiclesTypeAsync()
        {
            if (!_context.VehiclesTypes.Any())
            {
                _context.VehiclesTypes.Add(new VehicleType { Description = "Carro" });
                _context.VehiclesTypes.Add(new VehicleType { Description = "Moto" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
