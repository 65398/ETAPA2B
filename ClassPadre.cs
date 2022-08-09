using System;
using System.Collections.Generic;
using System.Text;

namespace ETAPA2B
{
    public class ClassPadre
    {
      
        public int llamada {get;set;}
        public int ID { set; get; }
        public int Cedula {get ; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int  Edad { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }


        public ClassPadre (int ID, int Cedula, string Nombre, string Apellido, string Correo , int Edad , int Telefono , string Direccion )
        {
            this.ID = ID;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Correo = Correo;
            this.Edad = Edad;
            this.Telefono = Telefono;
            this.Direccion =Direccion ;

        }
        public void Imprimir()
        {
            throw new System.NotImplementedException();
        }

        
    }
}
