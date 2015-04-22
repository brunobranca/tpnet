using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDebbuger
{
   public class Operaciones
    {
       float x { get; set;}
       float y { get; set;}
       public Operaciones()
       {
           try
           {
               x = float.Parse(Console.ReadLine());
               y = float.Parse(Console.ReadLine());
           }
           catch (FormatException fe)
           {
               Console.WriteLine(fe.ToString());
               x = 0;
               y = 0;
           }
           catch (Exception e)
           {
               Console.WriteLine("Ups: " + e.Message);
           }
       }


       public float Suma()
       {
           return x + y;
       }

       public float Resta()
       {
           return x - y;
       }

       public float Producto()
       {
           return x*y;
       }

       public float Division()
       {
           return x/y;
       }
    }
}
