using System;
using System.Collections.Generic;

namespace Puppugeneraattori
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] LauseenAloitus = { "On huomattava, että", "Kuitenkin", "Tämän vuoksi", "Senpä vuoksi juurikin", "Huolimatta tästä", "Nouskaamme suosta, sillä", "Teidän on syytä kuunnella, kuinka", "Olemme kaikki oikeassa siinä, että", "Kertokaa lapsille, että", "Lähdemme siitä, että" };
                string[] TekijaOsa = { "opintojen suorittaminen", "tenttitilaisuusien järjestäminen", "ohjelmointi-kielen erityispiirteiden hahmottaminen ja huomiointi", "järjestelmällinen toiminta", "nykynuorten opiskelu", "lautasmallin noudattaminen", "sääntöjen vastoin toimiminen", "kaikenlainen kapinointi", "turhaan aploodaaminen", "musiikin soittaminen" };
                string[] ToimintaOsa = { "auttaa myös", "vaikuttaa suoraan mutta myös kiertoteitse", "on ratkaisevassa osassa", "tulee auttamaan", "kasvattaa arvostusta", "jättää huomiotta", "epäonnistuu näyttämään", "todistaa", "huijaa", "mahdollistaa kaikille" };
                string[] LauseenLopetus = { "loppututkinnon suorittamisessa.", "työelämässä.", "saamaan ystäviä ja vaikutusvaltaa.", "kuten yleensäkin elämässä.", "kiitos.", "ottakaa opiksenne.", "näihin sanoihin.", "olen puhunut,", "ja tämä oli totuus.", "kaikenlaisessa pyörityksessä." };
                int[] Tarkastus = new int[4];
                bool onnistui;
                List<string> Puhe = new List<string>();
                Puhe.Add("Arvoisat kuulijat, tänään on juhlapäivä. ");
                do
                {
                    Console.WriteLine("Tervetuloa puheen genedsadsadadadsdadasdassrointiin! Anna haluamasi puheen pituus, eli lauseiden määrä kokonaislukuna.");
                    int lauseet;
                    onnistui = Int32.TryParse(Console.ReadLine(), out lauseet);

                    if (onnistui != true)
                    {
                        Console.WriteLine("Anna kokonaisluku!");
                    }
                    else
                    {
                        Console.WriteLine("Aletaan muodostafgfgfgfgffgfgfgfmaan lausetta!");
                        for (int i = 0; i < lauseet; i++)
                        {
                            Puhe.Add(MuodostaLause());
                        }
                    }

                } while (onnistui != true);

                foreach (string lause in Puhe)
                {
                    Console.WriteLine(" " + lause);
                }








                //metodit ----------------------------------------- //metodit ----------------------------------------- //metodit ----------------------------------------- //metodit -----------------------------------------
                //metodit -----------------------------------------

                //metodi
                string MuodostaLause()
                {
                    string Lause = "";
                    int indeksi;

                    indeksi = ArvoIndeksi("LauseenAloitus");
                    Lause = LauseenAloitus[indeksi];

                    indeksi = ArvoIndeksi("TekijaOsa");
                    Lause = Lause + " " + TekijaOsa[indeksi];

                    indeksi = ArvoIndeksi("ToimintaOsa");
                    Lause = Lause + " " + ToimintaOsa[indeksi];

                    indeksi = ArvoIndeksi("LauseenLopetus");
                    Lause = Lause + " " + LauseenLopetus[indeksi];

                    return Lause;
                }
                //metodi
                int ArvoIndeksi(string LauseenOsa)
                {
                    int alkio = 0;
                    switch (LauseenOsa)
                    {
                        case "LauseenAloitus":
                            do
                            {
                                Random rnd = new Random();
                                alkio = rnd.Next(0, 9);
                            } while (Tarkastus[0] == alkio);
                            Tarkastus[0] = alkio;
                            break;
                        case "TekijaOsa":
                            do
                            {
                                Random rnd = new Random();
                                alkio = rnd.Next(0, 9);
                            } while (Tarkastus[1] == alkio);
                            Tarkastus[1] = alkio;
                            break;
                        case "ToimintaOsa":
                            do
                            {
                                Random rnd = new Random();
                                alkio = rnd.Next(0, 9);
                            } while (Tarkastus[2] == alkio);
                            Tarkastus[2] = alkio;
                            break;
                        case "LauseenLopetus":
                            do
                            {
                                Random rnd = new Random();
                                alkio = rnd.Next(0, 9);
                            } while (Tarkastus[3] == alkio);
                            Tarkastus[3] = alkio;
                            break;
                    }


                    return alkio;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Virhe: " + e.Message);
            }
        }
    }
}
