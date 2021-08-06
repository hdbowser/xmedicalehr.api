namespace xmedical_ehr.Models
{
    public class AlergiaPaciente
    {
        public string PacienteId { get; set; }
        public int SustanciaId { get; set; }
        public string Comentario { get; set; }

        // Navications
        public virtual Paciente Paciente { get; set; }
        public virtual Sustancia Sustancia { get; set; }
    }
}