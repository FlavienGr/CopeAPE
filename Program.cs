using System;

namespace APE
{
    class Program
    {
        static int Choice { get; set; }
        static string Letter { get; set; }
        static string City { get; set; }
        static string Chambres { get; set; }
        static void Main(string[] args)
        {
            Start();
            switch (Choice)
            {
                case 1:
                    CodeRCS myNumber = new CodeRCS(City, Letter);
                    myNumber.Create();
                    break;
                case 2:
                    CodeChambreMetier myCodeChambreMetier = new CodeChambreMetier(Chambres);
                    myCodeChambreMetier.Create();
                    break;
                case 3:
                    CodeLibe codeLibe = new CodeLibe();
                    codeLibe.Create();
                    break;
            }
        }
        static void Display()
        {
            Console.WriteLine("Type d'organisation: ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("                   Entre 1 pour Commerçant et sociétes;");
            Console.WriteLine("                   Entre 2 pour immatriculées à la chambre des métiers et de l'artisanat;");
            Console.WriteLine("                   Entre 3 pour Les professions libérales;");
        }
        static void AskCity()
        {
            Console.WriteLine("---- ");
            Console.WriteLine("Whitch city please");
            Console.WriteLine("---- ");
            
        }
        static void AskLetter()
        {
            Console.WriteLine("---- ");
            Console.WriteLine("Witch letter (A ou B) please");
            Console.WriteLine("---- ");
        }
        static void Start()
        {
            do
            {
                try
                {
                    Display();
                    Choice = Int32.Parse(Console.ReadLine());
                    if (Choice <= 0 || Choice > 3)
                    {
                        throw new ArgumentException("AN Error occured, please choosea number between 1 and 3");
                    }
                } catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (Choice <= 0 || Choice > 3);

            if(Choice == 1)
            {
                AskCity();
          
                City = Console.ReadLine();
                City = City.Substring(0, 5).ToUpper();

                do
                {
                    try
                    {
                        AskLetter();
                        Letter = Console.ReadLine().ToUpper();
                        if (Letter != "A" && Letter != "B")
                        {
                            throw new ArgumentException("AN Error occured, please choose a letter. A or B");
                        }
                    } catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (Letter != "A" && Letter != "B");
            }

            if (Choice == 2)
            {
                
                Console.WriteLine("Groupe de chiffre désignant la Chambre de métiers et de l'artisanat:");
                Chambres = Console.ReadLine();
                Console.WriteLine("------------");
                Console.WriteLine(Chambres);

            }

        }
        
    }
}
