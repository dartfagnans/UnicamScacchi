using System;
using Scacchi.Modello;

namespace Scacchi
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleXUnitRunner.SimpleXUnit.RunTests();

            IOrologio orologio = new Orologio(TimeSpan.FromSeconds(5));
            //L'evento va sottoscritto subito dopo aver creato l'oggetto
            orologio.TempoScaduto += (sender, colore) => {
                Console.WriteLine($"Il giocatore {colore} ha perso la partita, secondo l'orologio {sender}!");
            };
            orologio.Accendi();
            orologio.Avvia();

            Console.ReadKey();
        }

        /*
        private static void NotificaSconfitta(object sender, Colore colore)
        {
            Console.WriteLine($"Il giocatore {colore} ha perso la partita, secondo l'orologio {sender}!");
        }*/
    }
}
