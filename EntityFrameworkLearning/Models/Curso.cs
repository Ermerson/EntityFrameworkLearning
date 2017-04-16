using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkLearning.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string Nome  { get; set; }
        public int UniversidadeID { get; set; }

        [ForeignKey("UniversidadeID")]
        public virtual Universidade Universidade { get; set; }

        // Um Objeto do tipo universidade representa uma instancia da classe universidade para ser chave estrangeira
        // Informando para o entity que UniversidadeID é uma chave estrangeira, graça ao [ForeignKey("Nome da chave")] 
    }
}