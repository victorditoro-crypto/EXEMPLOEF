using Microsoft.VisualBasic;

namespace EXEMPLOEF.Models
{
    public class cliente
    {

        public Guid ID { get; set; }

        public string Nome { get; set; } = string.Empty;

        public DateAndTime Nascimento { get; set; }
    }
}
