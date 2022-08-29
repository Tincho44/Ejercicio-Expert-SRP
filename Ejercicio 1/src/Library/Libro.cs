using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        // Al igual que el metodo ShelveBook, el string LibrarySector y el string
        // LibraryShelve deben ir a otra clase para cumplir con SRP, dado que
        // no le corresponde tener esta responsabilidad a la clase Book
        // Lo que haria seria hacer que ShelveBook sea una Clase y moveria estos
        // 2 strings con la clase ShelveBook

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        // La clase libro deberia de tener menos responsabilidad, incumple con SRP
        // SRP tiene que tener 1 responsabilidad o una que se complemente por clase
        // Este metodo deberia de estar en otra clase

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}
