namespace ExamenFinalProgra3
{
    public class Tablet:Dispositivo
    {
        string tamañoPantalla;
        string soporteStylus;
        public Tablet() {

        TamañoPantalla = string.Empty;
        SoporteStylus = string.Empty;
        }

        public string TamañoPantalla { get => tamañoPantalla; set => tamañoPantalla = value; }
        public string SoporteStylus { get => soporteStylus; set => soporteStylus = value; }
    }
}
