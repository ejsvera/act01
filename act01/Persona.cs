using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace act01
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string direccion;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }
    }
}