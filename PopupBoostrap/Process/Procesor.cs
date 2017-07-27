using System;
using PopupBoostrap.Models;
using System.Collections.Generic;

namespace PopupBoostrap.Process
{
    public class Procesor
    {
        public List<Equipo> FillEquipos()
        {
            var equipos = new List<Equipo>();
            equipos.Add(new Equipo(){ Ciudad="Guadalajara", Nombre="Chivas",Titulos=12 });
            equipos.Add(new Equipo() { Ciudad = "CDMX", Nombre = "América", Titulos = 12 });
            equipos.Add(new Equipo() { Ciudad = "Toluca", Nombre = "Toluca", Titulos = 10 });
            equipos.Add(new Equipo() { Ciudad = "CDMX", Nombre = "Cruz Azul", Titulos = 10 });
            equipos.Add(new Equipo() { Ciudad = "Pachuca", Nombre = "Pachuca", Titulos = 6 });

            return equipos;
        }
    }
}