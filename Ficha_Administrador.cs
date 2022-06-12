using System;
using System.Collections.Generic;
using System.Text;

namespace ETAPA2B
{
    class Ficha_Administrador:ClassPadre
    {
        string Exlaboral { set; get; }
        string Profesion { set; get; }

        public  Ficha_Administrador(int ID, int Cedula, string Nombre, string Apellido, string Correo, int Edad, int Telefono, string Direccion, string Exlaboral , string Profesion):base (ID,Cedula,Nombre, Apellido, Correo, Edad, Telefono, Direccion)
        {
            this.Exlaboral = Exlaboral;
            this.Profesion = Profesion;

        }
        public void Requisitos()
        {
            Console.WriteLine("Identificacion: " + ID );
            Console.WriteLine("Numero de Cedula " + Cedula);
            Console.WriteLine(" Nombre : " +Nombre);
            Console.WriteLine("Apellidos :" + Apellido);
            Console.WriteLine("Edad  :" + Edad);
            Console.WriteLine("Correo Electrico :" + Correo);
            Console.WriteLine("Numero de telefono :" + Telefono);
            Console.WriteLine("Direccion del domicilio :" + Direccion);
            
        }
        public void Servicio()
        {
            Console.WriteLine("Experiencia Laboral   :" + Exlaboral);
            Console.WriteLine("Profesion   :" + Profesion);
            
        }
     }
           
}