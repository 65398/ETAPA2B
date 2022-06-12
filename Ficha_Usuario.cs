using System;
using System.Collections.Generic;
using System.Text;

namespace ETAPA2B
{
     class Ficha_Usuario:ClassPadre
    {
        public string Mpago { set; get; }

        public Ficha_Usuario (int ID, int Cedula, string Nombre, string Apellido, string Correo, int Edad, int Telefono, string Direccion, string Mpago) : base(ID, Cedula, Nombre, Apellido, Correo, Edad, Telefono, Direccion)
        {
            this.Mpago = Mpago;
        }

        public void Requisitos()
        {
            Console.WriteLine("Identificacion: " + ID);
            Console.WriteLine("Numero de Cedula " + Cedula);
            Console.WriteLine(" Nombre : " + Nombre);
            Console.WriteLine("Apellidos :" + Apellido);
            Console.WriteLine("Edad  :" + Edad);
            Console.WriteLine("Correo Electrico :" + Correo);
            Console.WriteLine("Numero de telefono :" + Telefono);
            Console.WriteLine("Direccion del domicilio :" + Direccion);
        }

        public void pago()
        {
            
            double operar, credito,final , resultado , debito , resul;
            operar = 1700 * 12 /100 ;
            final = 1700 + operar;
            credito = 1700 * 16 / 100;
            resultado = 1700 + credito;
            debito = 1700 * 5 / 100;
            resul = 1700 + debito;
            Console.WriteLine("El precio inicial de la portatil :" + Mpago);
            Console.WriteLine("Estas son las diferentes fomras de pago con sus debidos interes");
            Console.WriteLine("Precio en efectivo :" + final  );
            Console.WriteLine("Precio en tarjeta de debito  :" + resul );
            Console.WriteLine("Precio en tarjeta de credito  :" + resultado );

            
        }        

        
    }
}