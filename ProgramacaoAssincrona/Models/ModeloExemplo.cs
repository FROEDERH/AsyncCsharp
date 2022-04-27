using System.Collections.Generic;

namespace ProgramacaoAssincrona.Models
{
    public class ModeloExemplo
    {
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Todo> Todos { get; set; }
        public IEnumerable<User> User { get; set; }
        public double TempoDeExecucaoEmSegundos { get; set; }
    }
}
