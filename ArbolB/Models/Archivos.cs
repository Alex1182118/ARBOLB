using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ArbolB.Models
{
   
    
        static private void Archivos()
        {
            System.IO.StreamReader Leer = new System.IO.StreamReader("C:/Users/alexg/OneDrive/Escritorio/lab-proyectp-master/DATA.csv");

            Farmaco NodoArchivo = new Farmaco();
            char[] variables = { '$', ' ', '*', '/', ',' };

            while (!Leer.EndOfStream)
            {
                string lector = Leer.ReadLine();

                var respuesta = lector.Split(',');

                (NodoArchivo.llenar(Convert.ToInt32(respuesta[0]), respuesta[1], respuesta[2], respuesta[3], Convert.ToDouble((respuesta[4].Trim(variables))), Convert.ToInt32(respuesta[5]);
            }

        }
    
}
