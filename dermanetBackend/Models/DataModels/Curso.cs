using System.ComponentModel.DataAnnotations;

namespace dermanetBackend.Models.DataModels
{
    public class Curso
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        public string DescripcionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        public enum TipoNivel { 
            Basico,
            Intermedio,
            Avanzado
        }
        public TipoNivel Nivel { get; set; }

    }
}
