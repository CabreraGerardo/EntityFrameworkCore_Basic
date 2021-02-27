using PersistentDatabase;
using PersistentDatabase.Models;
using System;
using Service;

namespace EntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrimerEjemplo();
        }

        static void PrimerEjemplo()
        {
            var areaService = new AreaService();
            var pisoService = new PisoService();
            var edificioService = new EdificioService();

            var piso = new Piso
            {
                Id = "1",
                Nombre = "Piso 1",
                Edificio = new Edificio
                {
                    Id = "1",
                    Ubicacion = "Plaza Mayor"
                }
            };

            pisoService.Add(piso);

            areaService.Add(new Area
            {
                Id = "4",
                Nombre = "Oficina de Direccion",
                Ubicacion = "Plaza Mayor 01",
                PisoId = piso.Id
            });
        }
    }
}
