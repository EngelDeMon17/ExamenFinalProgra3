using System.Reflection;
using System.Text.RegularExpressions;

namespace ExamenFinalProgra3
{
    public class Laptop:Dispositivo
    {
        string memoriaRam;
        string almacenamiento;

        public Laptop()
        {
            memoriaRam = string.Empty;
            almacenamiento = string.Empty;
            
        }

        public string MemoriaRam { get => memoriaRam; set => memoriaRam = value; }
        public string Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
    }
}
