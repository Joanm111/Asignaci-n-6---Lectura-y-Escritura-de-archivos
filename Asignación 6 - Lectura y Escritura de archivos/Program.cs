using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Asignación_6___Lectura_y_Escritura_de_archivos

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lineas =   File.ReadAllLines("C://Users//joanj//Desktop//Libro1.csv");

               foreach (var linea in lineas)
               {
                   var valores = linea.Split(',');
                   Console.WriteLine(valores[0]  +"   "+ valores[1]+ "   " + valores[2] + "   " + valores[3]);
                   Console.Read();
               }
            
           
            
            //addRecord("jose12", "perez", 43, "B+","libro2.csv");

        }
        /*public static void addRecord(string Nombre,string Apellido,int Edad,string TipoS,string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(Nombre + "," + Apellido + "," + Edad + "," + TipoS);
                    
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException("this program did an oopsie :", ex);
            }
        */
        
    }
}

