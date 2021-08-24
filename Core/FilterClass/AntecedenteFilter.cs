namespace xmedicalehr.api.Core.FilterClass
{
    public class AntecedenteFilter
    {
        public AntecedenteFilter()
        {
            Busqueda = string.Empty;
            PacienteId = string.Empty;
        }

        public string PacienteId { get; set; }
        public string Busqueda { get; set; }

    }
}