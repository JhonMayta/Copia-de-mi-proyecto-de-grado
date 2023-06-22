using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_Sistema_de_notas
{
    class Alumno
    {
        string Carnet;
        public string CARNET { get => Carnet; set => Carnet = value; }

        string Nombre;
        public string NOMBRE { get => Nombre; set => Nombre = value; }

        double Actividad1;
        public double PARCIAL1 { get => Actividad1; set => Actividad1 = value; }

        double Actividad2;
        public double PARCIAL2 { get => Actividad2; set => Actividad2 = value; }

        double Actividad3;
        public double PARCIAL3 { get => Actividad3; set => Actividad3 = value; }
  
        double Promedio;
        public double PROMEDIO { get => Promedio; set => Promedio = value; }

        string Estado;
        public string ESTADO { get => Estado; set => Estado = value; }
    }
}
