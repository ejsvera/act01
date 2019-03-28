using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act01
{
    class Program
    {
        static void Main(string[] args)
        {
            // version sincronizada con GitHub
            // usando equipos en lab202 y lab203
            //
            Proveedor p1 = new Proveedor();
            Proveedor p2 = new Proveedor();
            Cliente c1 = new Cliente();
            Cliente c2 = new Cliente();

            p1.Id = 11;
            p1.Nombre = "proveedor 1";
            p1.Direccion = "dir pro 1";
            p1.Fono = 11111111;
            p1.Email = "prov01@emp.cl";
            p1.Activo = true;

            p2.Id = 22;
            p2.Nombre = "proveedor 2";
            p2.Direccion = "dir pro 2";
            p2.Fono = 22222222;
            p2.Email = "prov02@emp.cl";
            p2.Activo = false;

            c1.Id = 33;
            c1.Nombre = "cliente 3";
            c1.Direccion = "dir cli 3";
            c1.Nacimiento = new DateTime(2001, 11, 29);
            c1.Whatsapp = 33333333;

            c2.Id = 44;
            c2.Nombre = "cliente 4";
            c2.Direccion = "dir cli 4";
            c2.Nacimiento = new DateTime(2003, 2, 15);
            c2.Whatsapp = 44444444;

            Proveedor p3 = new Proveedor(55, "proveedor 5", "dir pro 5", 55555555, "prov05@emp.cl", true);




            Mostrar(p1);
            Mostrar(p2);
            Mostrar(p3);
            Mostrar(c1);
            Mostrar(c2);

            Console.ReadKey();
        }

        static void Mostrar(Proveedor p)
        {
            Console.WriteLine("Id        : " + p.Id);
            Console.WriteLine("Nombre    : " + p.Nombre);
            Console.WriteLine("Direccion : " + p.Direccion);
            Console.WriteLine("Fono      : " + p.Fono);
            Console.WriteLine("Email     : " + p.Email);
            Console.WriteLine("Activo    : " + p.Activo);
            Console.WriteLine("-------------------------------------------------------------------");
        }

        static void Mostrar(Cliente c)
        {
            Console.WriteLine("Id        : " + c.Id);
            Console.WriteLine("Nombre    : " + c.Nombre);
            Console.WriteLine("Direccion : " + c.Direccion);
            Console.WriteLine("Nacimiento: " + c.Nacimiento.ToShortDateString());
            Console.WriteLine("WhatsApp  : " + c.Whatsapp);
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
