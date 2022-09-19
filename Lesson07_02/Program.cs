using System;

namespace Lesson07_02
{
    internal class Program
    {
        public struct BibliotekosKnyga
        {
            public int Id;
            public string Title;
            public string ReaderName;
            public DateTime TakenAt;

            public BibliotekosKnyga(int id, string title, string readerName, DateTime takenAt)
            {
                Id = id;
                Title = title;
                ReaderName = readerName;
                TakenAt = takenAt;
            }

            public int HowLongBookIsTaken()
            {
                DateTime currentDate = DateTime.Today;
                int bookTakenInDays = (currentDate - TakenAt).Days;

                return bookTakenInDays;
            }
        }

        static void Main(string[] args)
        {
            BibliotekosKnyga bibliotekosKnyga = new BibliotekosKnyga(1, "Haris Poteris", "Daumantas", new DateTime(2022, 09, 09));

            int bookTakenInDays = bibliotekosKnyga.HowLongBookIsTaken();

            Console.WriteLine($"Knyga paimta {bookTakenInDays} dienu");
        }
    }
}
