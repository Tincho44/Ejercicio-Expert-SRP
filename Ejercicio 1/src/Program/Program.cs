using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            ShelveBook Location1 = new ShelveBook($"{book1.Title}","A","7");
            ShelveBook Location2 = new ShelveBook($"{book2.Title}","B","3");

        }
    }
}

