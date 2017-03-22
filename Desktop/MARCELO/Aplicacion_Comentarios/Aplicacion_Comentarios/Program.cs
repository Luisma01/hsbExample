using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicacion_Comentarios
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string m_sArchive = @"C:\Users\hsbUser\Desktop\MARCELO/hola.txt";

            using(FileStream Fs = File.OpenRead(m_sArchive))
            {

                byte[] b = new byte[2000];
                UTF8Encoding Un = new UTF8Encoding(true);
                
                while (Fs.Read(b,0,b.Length) > 0) 
                {


                Console.WriteLine(Un.GetString(b));
                
                }

                Console.ReadKey();

            }




        }
    }
}
