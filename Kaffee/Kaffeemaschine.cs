using Kaffee;
namespace KaffeemaschinenVar
{
    public class Kaffeemaschine
    {
        public double Wasser { get; private set; }

        public double Bohnen { get; private set; }

        public double gesamtMengeKaffeeProduziert { get; private set; }

        private static double maxWasser => 2.5; 

        private static double maxBohnen => 2.5;


        public string WasserAuffuellen(double menge)
        {
            if (Wasser + menge <= maxWasser)
            {
                Wasser += menge;
                return "Wasser dazugetan: " + menge;
            }
            double voll = maxWasser - Wasser;
            return "Es hat noch " + voll + " Wasser platz";
        }
        public string BohnenAuffuellen(double menge)
        {
            if (Bohnen + menge <= maxBohnen)
            {
                Bohnen += menge;
                return "Bohnen dazugetan: " + menge;
            }
            double voll = maxBohnen - Bohnen;
            return "Es haben noch " + voll + " Bohnen platz";
        }

    }
}