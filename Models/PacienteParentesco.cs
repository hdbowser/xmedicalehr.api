namespace xmedical_ehr.Models
{
    public class PacienteParentesco
    {
        public string PacienteId { get; set; }
        public int TipoParentescoId { get; set; }
        public string ParentescoId { get; set; }
        public string Comentario { get; set; }

        // Navigations
        public virtual Paciente Paciente { get; set; }
        public virtual TipoParentesco TipoParentesco { get; set; }
        // public virtual Paciente Parentesco { get; set; }
        //TODO porque tiene dos propiedad de de navegacion del tipo Paciente
    }
}