namespace ExamenFinalProgra3
{
    public class Smartphone:Dispositivo
    {
        string sistemaOperativo;
        string numeroCamaras;

        public Smartphone()
        {
            sistemaOperativo = string.Empty;
            numeroCamaras = string.Empty;

        }
        public string SistemaOperativo { get => sistemaOperativo; set => sistemaOperativo = value; }
        public string NumeroCamaras { get => numeroCamaras; set => numeroCamaras = value; }
    }
}
