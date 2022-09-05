using System;

namespace SRP
{

    public class ShelveBook
    {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public string Book { get ; set; }
        public ShelveBook(string book, String sector, String shelve)
        {   
            this.Book = book;
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;

                // A mi criterio ShelveBook puede y debe contener la informacion de donde se situa el libro, tanto el secto como estante
                // como el sector. Si fuera una situacion mas particular, se podria perfectamente evaluar el hecho de tener 
                // otras clases para guardar el libro de otra forma

        }
    }    
}