using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace act01
{
    public class Proveedor : Persona
    {
        private int fono;
        private string email;
        private bool activo;

        public Proveedor()
        {           
        }

        public Proveedor(int ide, string nom, string dir, int fon, string ema, bool act)
        {
            Id = ide;
            Nombre = nom;
            Direccion = dir;
            fono = fon;
            email = ema;
            activo = act;
        }

        public int Fono
        {
            get
            {
                return fono;
            }

            set
            {
                fono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }
    }
}