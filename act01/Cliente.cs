using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace act01
{
    public class Cliente : Persona
    {
        private DateTime nacimiento;
        private int whatsapp;

        public DateTime Nacimiento
        {
            get
            {
                return nacimiento;
            }

            set
            {
                nacimiento = value;
            }
        }

        public int Whatsapp
        {
            get
            {
                return whatsapp;
            }

            set
            {
                whatsapp = value;
            }
        }

    }
}