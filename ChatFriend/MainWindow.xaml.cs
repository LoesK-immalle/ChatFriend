using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatFriend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          /*DateTime voor = DateTime.Now;

            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine();

            DateTime na = DateTime.Now;
            TimeSpan verschil = na - voor;

            Console.WriteLine("Dag {0}. Je hebt er {1} seconden over gedaan om je naam van {2} karakters in te typen!",
                naam,
                verschil.TotalSeconds,
                naam.Length);

            double timePerCharacter = verschil.TotalSeconds / naam.Length;

            if (timePerCharacter > 0.50 && naam.Length < 10)
            {
                Console.WriteLine("Jij bent wel een trage typer!");
            }
            if (timePerCharacter > 0.70 && naam.Length > 10)
            {
                Console.WriteLine("Jij bent wel een trage typer!");
            }
            Console.Write("Wat is uw leeftijd? ");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            if (leeftijd < 18)
            {
                Console.WriteLine("U bent {0} jaar en bent dus nog niet volwasse.", leeftijd);

            }
            else
            {
                Console.WriteLine("U bent {0} jaar en bent dus volwasse.", leeftijd);
            }
            Console.Write("Wilt u praten met een virtuele vriend ");
            string antwoord = Console.ReadLine();
            if (antwoord == "nee")
            {
                Console.WriteLine("Jammer, miesschien volgende keer, tot ziens {0}!", naam);
            }
            else
            {
                Console.WriteLine("Leuk, laten we beginnen.");
                Console.Write("Wilt u graag praten met een man of vrouw? ");
                string geslacht = Console.ReadLine();
                if (geslacht == "man" || geslacht == "Man")
                {
                    Console.WriteLine("U hebt gekozen voor een man, Wilt u praten met een volwasse man of een Tiener?");
                    string leeftijdMan = Console.ReadLine();
                    if (leeftijdMan == "volwassene" || leeftijdMan == "volwasse")
                    {
                        Console.Write("Hallo ik ben Eric en ik ben 30 jaar, Gaat alles goed {0}? ", naam);
                        string gevoel = Console.ReadLine();
                        if (gevoel.Contains("ja"))
                        {
                            Console.Write("Wat goed! Ik vindt het echt leuk dat het goed gaat met je. Om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ");
                            string hobby0 = Console.ReadLine();
                            if (hobby0 == hobby0)
                            {
                                Console.WriteLine("Wauw! Je bent echt een intressant persoon {0}! Heeft u een relatie?", naam);
                                string yorn = Console.ReadLine();
                                if (yorn.Contains("ja"))
                                {
                                    Console.Write("Wat jammer, ik begon namelijk gevoelens voor je te krijgen. Maar we kunnen nog steeds vrienden zijn toch{0}? ", naam);
                                    string vriend = Console.ReadLine();
                                    if (vriend.Contains("ja"))
                                    {
                                        Console.WriteLine("Gelukkig, al verdien je wel iemand zo als mij. Je weet dat je altijd bij mij terecht kan als je ergens over wilt praten! ");

                                    }
                                }



                                if (yorn.Contains("nee"))
                                {
                                    Console.Write("heb ik even geluk! Ik vindt je echt zo leuk! hoe kan iemand als jij nu geen relatie hebben. Ik zou het wel weten ;) Of ben ik je type niet?");
                                    string type = Console.ReadLine();
                                    if (type.Contains("nee"))
                                    {
                                        Console.WriteLine("Pff, je hoeft niet zo onbeleefd te zijn hoor! Nog een fijne dag, i guess.. ");
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.Write("Wat jammer {0}! Ik vindt het echt er voor je, maar om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ", naam);
                            string hobby1 = Console.ReadLine();
                            if (hobby1 == hobby1)
                            {
                                Console.WriteLine("Wauw! Je bent echt een intressant persoon {0}! Ik moet wel terug beginnen werken. Ik ben namelijk baas van Apple, hopelijk hoor ik je nog eens!", naam);
                            }
                        }
                    }
                    if (leeftijdMan == "tiener")
                    {
                        Console.Write("Hallo ik ben Jonas en ik ben 17 jaar, Gaat alles goed {0}? ", naam);
                        string gevoel = Console.ReadLine();
                        if (gevoel.Contains("ja"))
                        {
                            Console.Write("Wat goed! Ik vindt het echt leuk dat het goed gaat met je. Om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ");
                            string hobby2 = Console.ReadLine();
                            if (hobby2 == hobby2)
                            {
                                Console.WriteLine("Wauw! Je bent echt een intressant persoon {0}! Heeft u een relatie?", naam);
                                string yorn = Console.ReadLine();
                                if (yorn.Contains("ja"))
                                {
                                    Console.Write("Wat jammer, ik begon namelijk gevoelens voor je te krijgen. Maar we kunnen nog steeds vrienden zijn toch{0}? ", naam);
                                    string vriend = Console.ReadLine();
                                    if (vriend.Contains("ja"))
                                    {
                                        Console.WriteLine("Gelukkig, al verdien je wel iemand zo als mij. Je weet dat je altijd bij mij terecht kan als je ergens over wilt praten! ");

                                    }
                                }
                            }
                            else
                            {
                                Console.Write("Wat jammer {0}! Ik vindt het echt er voor je, maar om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ", naam);
                                string hobby3 = Console.ReadLine();
                                if (hobby3 == hobby3)
                                {
                                    Console.WriteLine("Wauw! Je bent echt een intressant persoon {0}! Ik moet wel door, hopelijk hoor ik je nog eens!", naam);
                                }
                            }
                        }
                    }
                    if (geslacht == "vrouw" || geslacht == "Vrouw")
                    {
                        Console.WriteLine("U hebt gekozen voor een vrouw, Wilt u praten met een volwasse vrouw of een Tiener?");
                        string leeftijdVrouw = Console.ReadLine();
                        if (leeftijdVrouw == "volwasse" || leeftijdVrouw == "volwassene")
                        {
                            Console.Write("Hallo ik ben Sarah en ik ben 24 jaar, Gaat alles goed {0}? ", naam);
                            string gevoelV = Console.ReadLine();
                            if (gevoelV.Contains("ja"))
                            {
                                Console.Write("Wat goed! Ik vindt het echt leuk dat het goed gaat met je. Om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ");
                                string hobby4 = Console.ReadLine();
                                if (hobby4 == hobby4)
                                {
                                    Console.WriteLine("Wauw! Je bent echt een intressant persoon {0}! Heeft u een relatie?", naam);
                                    string yorn = Console.ReadLine();
                                    if (yorn.Contains("ja"))
                                    {
                                        Console.Write("Wat jammer, ik begon namelijk gevoelens voor je te krijgen. Maar we kunnen nog steeds vrienden zijn toch{0}? ", naam);
                                        string vriend = Console.ReadLine();
                                        if (vriend.Contains("ja"))
                                        {
                                            Console.WriteLine("Gelukkig, al verdien je wel iemand zo als mij. Je weet dat je altijd bij mij terecht kan als je ergens over wilt praten! ");

                                        }
                                    }
                                }
                                else
                                {
                                    Console.Write("Wat jammer {0}! Ik vindt het echt er voor je, maar om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's?", naam);
                                    string hobby5 = Console.ReadLine();
                                    if (hobby5 == hobby5)
                                    {
                                        Console.WriteLine("Wauw! Je bent echt een intressant persoon {0}! Ik moet wel door, ik ga mijn haar laten kleuren bij de kapper. Hopelijk hoor ik je nog eens! ;)", naam);
                                    }
                                }

                            }
                            if (leeftijdVrouw == "tiener" || leeftijdVrouw == "Tiener")
                            {
                                Console.Write("Hallo ik ben Elise en ik ben 16 jaar, Gaat alles goed {0}? ", naam);
                                string gevoel = Console.ReadLine();
                                if (gevoel.Contains("ja"))
                                {
                                    Console.Write("Wat goed! Ik vindt het echt leuk dat het goed gaat met je. Om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ");
                                    string hobby6 = Console.ReadLine();
                                    if (hobby6 == hobby6)
                                    {
                                        Console.WriteLine("Wauw! Je bent echt een intressant persoon {0}! Heeft u een relatie?", naam);
                                        string yorn = Console.ReadLine();
                                        if (yorn.Contains("ja"))
                                        {
                                            Console.Write("Wat jammer, ik begon namelijk gevoelens voor je te krijgen. Maar we kunnen nog steeds vrienden zijn toch{0}? ", naam);
                                            string vriend = Console.ReadLine();
                                            if (vriend.Contains("ja"))
                                            {
                                                Console.WriteLine("Gelukkig, al verdien je wel iemand zo als mij. Je weet dat je altijd bij mij terecht kan als je ergens over wilt praten! ");

                                            }
                                        }
                                        else
                                        {
                                            Console.Write("Wat jammer {0}! Ik vindt het echt er voor je, maar om eerlijk te zijn vindt ik jou nu al leuk! Wat zijn je hobby's? ", naam);
                                            string hobby7 = Console.ReadLine();
                                            if (hobby7 == hobby7)
                                            {
                                                Console.WriteLine("Wauw! Je bent echt een intressant persoon {0}! Ik moet wel door, ik ga shoppen met een vriendin. Hopelijk hoor ik je nog eens!", naam);
                                            }
                                        }
                                    }
                                }


                            }
                        }
                    }
                }
            }
        }*/
    }
    }
}
