using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Liczby liczby = new Liczby(100);
        liczby.Wyswietl();
        liczby.Szukaj(1);
        liczby.nieparzyste();
        liczby.srednia();
    }
    class Liczby
    {
        private int rozmiar;
        private int[] tablica;

        public Liczby(int r)
        {
            Random rnd = new Random();
          
            rozmiar = r;
            tablica = new int[rozmiar];
            for(int i = 0; i < rozmiar; i++)
            {
                tablica[i] = rnd.Next(1, 100); 
            }
        }
        public void Wyswietl()
        {
            int index;
            for(int i = 0; i < rozmiar; i++)
            {
                index = i + 1;
                Console.WriteLine(index +":"+tablica[i]);
            }
        }
        /*
        **********************************************
        nazwa metody: Szukaj
        opis metody: Wyszukuje w tablicy pierwsze wystąpienie podanej liczby i wyświetla jego pozycję.
        parametry: szukana – liczba, której metoda szuka w tablicy
        zwracany typ i opis: int – indeks pierwszego znalezionego elementu albo -1, jeśli liczby nie znaleziono
        autor: Jakub Kryszewski
        ***********************************************
        */
        public int Szukaj(int szukana)
        {
            int index;
            for(int i = 0; i < rozmiar; i++)
            {
                if(tablica[i] == szukana)
                {
                    index = i + 1;
                    Console.WriteLine("");
                    Console.WriteLine(index);
                    Console.WriteLine("");
                    return i;
                }
            }
           
            return -1;
        }
        public void nieparzyste()         {
            int licznik = 0;
            for(int i = 0; i < rozmiar; i++)
            {
                if(tablica[i] % 2 != 0)
                {
                    licznik++;
                    Console.WriteLine(tablica[i]);
                }
            }
            Console.WriteLine("Razem nieparzystych: " + licznik);
        }
        public void srednia()
        {
            int suma = 0;
            for(int i = 0; i < rozmiar; i++)
            {
                suma += tablica[i];
            }
            double srednia = (double)suma / rozmiar;
            Console.WriteLine("Srednia: " + srednia);
        }

    }


}