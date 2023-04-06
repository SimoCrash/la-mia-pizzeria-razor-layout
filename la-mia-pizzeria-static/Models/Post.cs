namespace la_mia_pizzeria_static.Models
{
    public class Post
    {
        public Post(int id, string nome, string descrizione, string foto, string prezzo)
        {
            Id = id;
            Nome = nome;
            Descrizione = descrizione;
            Foto = foto;
            Prezzo = prezzo;
        }

        public int Id {  get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string Foto { get; set; }
        public string Prezzo { get; set; }
    }
}
