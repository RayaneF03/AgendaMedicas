namespace AgendaMedicas.Models
{
    public class Medico
    {
        public static object Especialidade { get; internal set; }
        public Guid MedicoId { get; set; }
        public string? Nome { get; set; }

        public string? CRM { get; set; }

        public string? Celular { get; set; }

        public Guid EspecialidadeId { get; set; }

        public Especialidade? Especialidades { get; set; }

    }
}
