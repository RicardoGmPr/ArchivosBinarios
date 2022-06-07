using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArchivosBinarios
{
    class Program
    {
        //Declaración de flujos
        BinaryWriter bw = null; //Flujo salida - Escritura de datos
        BinaryReader br = null; //Flujo entrada - Lectura de datos

        //Campos de la clase
        string Nombre, Direccion;
        long Telefono;
        int NumEmp, DiasTrabajados;
        float SalarioDiario;

        public void CrearArchivo (string Archivo)
        {
            //Variable local método
            char resp;

            try
            {
                //Creación del flujo para escribir datos al archivo
                bw = new BinaryWriter(new FileStream(Archivo, FileMode.Create, FileAccess.Write));

                //Captura de datos
                do
                {
                    Console.Clear();
                    Console.Write("Numero del Empleado: ");
                    NumEmp = Int32.Parse(Console.ReadLine());
                    Console.Write("Nombre del Empleado: ");
                    Nombre = Console.ReadLine();
                    Console.Write("Dirección del Empleado: ");
                    Direccion = Console.ReadLine();
                    Console.Write("Teléfono del Empleado: ");
                    Telefono = Int64.Parse(Console.ReadLine());
                    Console.Write("Dias trabajados del Empleado: ");
                    DiasTrabajados = Int32.Parse(Console.ReadLine());

                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
