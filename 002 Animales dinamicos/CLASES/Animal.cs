using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Animales_dinamicos
{
    class Animal
    {
        private string Nombre;
        private string Clase;
        private string Subclase;
        private string Color;
        private string Sexo;
        private string Peso;
        private string Fecha;
        private string Imagen;


        public string GetImagen()
        {
            return Imagen;
        }

        public string GetFecha()
        {
            return Fecha;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public string GetClase()
        {
            return Clase;
        }
        public string GetSubclase()
        {
            return Subclase;
        }
        public string GetColor()
        {
            return Color;
        }
        public string GetSexo()
        {
            return Sexo;
        }
        public string GetPeso()
        {
            return Peso;
        }


        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public void SetClase(string clase)
        {
            Clase = clase;
        }
        public void SetSubclase(string subclase)
        {
            Subclase = subclase;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
        public void SetSexo(string sexo)
        {
            Sexo = sexo;
        }
        public void SetPeso(string peso)
        {
            Peso = peso;
        }
        public void SetFecha(string fecha)
        {

            Fecha = fecha;
        }
        public void SetImagen(string imagen)
        {
            Imagen = imagen;
        }
    }
}
