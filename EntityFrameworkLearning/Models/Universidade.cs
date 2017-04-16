using System.Collections.Generic;

namespace EntityFrameworkLearning.Models
{
    public class Universidade
    {
        
        public int UniversidadeID { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }


        //O EntityFramework consegue indentificar as chaves primarias de uma tabela por causa do ID, por padrão ele indentifica os nome que possui ID como prefixo.
        // Pode utilizar o Annotation [Key]   "System.ComponentModel.DataAnnotationspara" determinar uma chave primaria
    }
}