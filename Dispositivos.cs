namespace ExamenFinalProgra3
{
    public class Dispositivo
    {
        string numeroSerie;
        string marca;
        string modelo;

        public Dispositivo()
        {
            numeroSerie = string.Empty;
            marca = string.Empty;
            modelo = string.Empty;
        }

        public string NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
