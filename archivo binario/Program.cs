using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archivo_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FileStream ARCHIVOLECTOR;
            FileStream ARCHIVOESCRITOR;
            BinaryReader LECTOR;
            BinaryWriter ESCRITOR;
            ARCHIVOESCRITOR = new FileStream("DATOD.dat", FileMode.OpenOrCreate, FileAccess.Write);
            ESCRITOR=new BinaryWriter(ARCHIVOESCRITOR);


            ESCRITOR.Write("juan");
            ESCRITOR.Write(18 );
            ESCRITOR.Write("8661548525");
            ESCRITOR.Write("DIANA");
            ESCRITOR.Write(28);
            ESCRITOR.Write("86617425");
            ESCRITOR.Close();
            ARCHIVOESCRITOR.Close();

            ARCHIVOLECTOR= new FileStream("DATOD.dat",FileMode.OpenOrCreate, FileAccess.Read);
            LECTOR=new BinaryReader(ARCHIVOLECTOR);
            while(ARCHIVOLECTOR.Position!=ARCHIVOLECTOR.Length)
            {
            Console.WriteLine(LECTOR.ReadString());
                Console.WriteLine(LECTOR.ReadInt32());
                Console.WriteLine(LECTOR.ReadString());
            }
            LECTOR.Close();
            ARCHIVOLECTOR.Close();
            Console.ReadKey();

        }
    }
    }

