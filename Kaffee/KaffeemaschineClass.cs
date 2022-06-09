using Kaffee.Controllers;
namespace KaffeemaschinenVar
{
    public class KaffeemaschineClass
    {
        public double Wasser { get; private set; }

        public double Bohnen { get; private set; }

        public double gesamtMengeKaffeeProduziert { get; private set; }

        private static double maxWasser => 2.5; 

        private static double maxBohnen => 2.5;

        public KaffeemaschineClass(double Wasser = 0, double Kaffebohnen = 0, double gesamtMengeKaffeeProduziert = 0)
        {
            this.Wasser = Wasser;
            this.Bohnen = Bohnen;
            this.gesamtMengeKaffeeProduziert = gesamtMengeKaffeeProduziert;
        }


        public string WasserAuffuellen(double menge)
        {
            if (Wasser + menge <= maxWasser)
            {
                Wasser += menge;
                return "Wasser dazugetan: " + menge;
            }
            double voll = maxWasser - Wasser;
            return "Es hat noch " + voll + "kg Wasser platz";
        }
        public string BohnenAuffuellen(double menge)
        {
            if (Bohnen + menge <= maxBohnen)
            {
                Bohnen += menge;
                return "Bohnen dazugetan: " + menge;
            }
            double voll = maxBohnen - Bohnen;
            return "Es haben noch " + voll + "kg Bohnen platz";
        }

        public bool machKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            double mengeWasser = menge / (verhaeltnisWasserBohnen + 1) * verhaeltnisWasserBohnen;
            double mengeBohnen = menge - mengeWasser;

            if (mengeBohnen <= Bohnen && mengeWasser <= Wasser)
            {
                Bohnen -= mengeBohnen;
                Wasser -= mengeWasser;
                gesamtMengeKaffeeProduziert += menge;
                return true;
            }
            return false;
        }

    }
}