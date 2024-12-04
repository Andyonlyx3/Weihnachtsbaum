namespace Weihnachtsbaum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stufe1:
            //
            //Programmiere die Ausgabe eines Weinachtsbaum im ASCII Format.
            //Du kannst dir das Aussehen des Baums selber aussuchen
            //Nutze für die Ausgabe Schleifen.
            //
            //Beispiel:
            //       x
            //      xxx
            //     xxxxx
            //    xxxxxxx
            //	 xxxxxxxxx
            //	xxxxxxxxxxx
            //      xxx
            //      xxx

            //Stufe 2:
            //
            //Unter dem Baum soll ein zuffäliger weinachtsgruß ausgegeben werden. nutze dafür ein Array
            //Nutze ggf. Farben.

            //Stufe 3: 
            //
            //Alle paar Sekunden soll sich die Gruß nachricht verändern also aktualisiert werden

            //Stufe 4:
            //
            //Lass den Baum Blinken und Funkeln
            //Mach eine Recherche wie man spezifische stellen in der Konsole aktualisiert.

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int hoehe = 12;
            int stammHoehe = 4;
            int stammBreite = 3;
            string[] spruch = { "Merry Christmas", "Merry Crisis", "Happy Hanukkah", "Feliz Navidad", "  Sack Noel" };
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < hoehe; i++)
                {
                    for (int j = 0; j < hoehe - i - 1; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (2 * i) + 1; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        if (i == 11)
                        {
                            Console.Write("*", 2 * i + 1);
                        }
                        else if (i % 2 == 0)                                    // % für den Restoperator nutzen das abgeglichen wird od i/2 keinen restwert hat
                        {
                            string test = (j % 2 == 0 ? "*" : "•");
                            if (test == "•") Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(test);              // ? als bool abgleich von * und o 
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            string test2 = (j % 2 == 0 ? "†" : "*");
                            if (test2 == "†") Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(test2);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < stammHoehe; i++)
                {
                    for (int j = 0; j < hoehe - stammBreite / 2 - 1; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    for (int j = 0; j < stammBreite; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Write("|");
                    }
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                Random rnd = new Random();

                string zufallsGruss = spruch[rnd.Next(spruch.Length)];

                Random color = new Random();
                ConsoleColor randomColor = (ConsoleColor)color.Next(1, 16);
                Console.ForegroundColor = randomColor;
                Console.WriteLine($"\n      {zufallsGruss}\n");
                Thread.Sleep(3000);

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.BackgroundColor = (ConsoleColor)color.Next(1, 16);
                Console.SetCursorPosition(10, 2); Console.Write("•");
                Console.SetCursorPosition(12, 2); Console.Write("•");
                Console.SetCursorPosition(8, 4); Console.Write("•");
                Console.SetCursorPosition(10, 4); Console.Write("•");
                Console.SetCursorPosition(12, 4); Console.Write("•");
                Console.SetCursorPosition(14, 4); Console.Write("•");
                Console.SetCursorPosition(6, 6); Console.Write( "•");
                Console.SetCursorPosition(8, 6); Console.Write("•");
                Console.SetCursorPosition(10, 6); Console.Write("•");
                Console.SetCursorPosition(12, 6); Console.Write("•");
                Console.SetCursorPosition(14, 6); Console.Write("•");
                Console.SetCursorPosition(16, 6); Console.Write("•");
                Console.SetCursorPosition(4, 8); Console.Write("•");
                Console.SetCursorPosition(6, 8); Console.Write("•");
                Console.SetCursorPosition(8, 8); Console.Write("•");
                Console.SetCursorPosition(10, 8); Console.Write("•");
                Console.SetCursorPosition(12, 8); Console.Write("•");
                Console.SetCursorPosition(14, 8); Console.Write("•");
                Console.SetCursorPosition(16, 8); Console.Write("•");
                Console.SetCursorPosition(18, 8); Console.Write("•");
                Console.SetCursorPosition(2, 10); Console.Write("•");
                Console.SetCursorPosition(4, 10); Console.Write("•");
                Console.SetCursorPosition(6, 10); Console.Write("•");
                Console.SetCursorPosition(8, 10); Console.Write("•");
                Console.SetCursorPosition(10, 10); Console.Write("•");
                Console.SetCursorPosition(12, 10); Console.Write("•");
                Console.SetCursorPosition(14, 10); Console.Write("•");
                Console.SetCursorPosition(16, 10); Console.Write("•");
                Console.SetCursorPosition(18, 10); Console.Write("•");
                Console.SetCursorPosition(20, 10); Console.Write("•");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(10, 1); Console.Write("†");
                Console.SetCursorPosition(12, 1); Console.Write("†");
                Console.SetCursorPosition(8, 3); Console.Write("†");
                Console.SetCursorPosition(10, 3); Console.Write("†");
                Console.SetCursorPosition(12, 3); Console.Write("†");
                Console.SetCursorPosition(14, 3); Console.Write("†");
                Console.SetCursorPosition(6, 5); Console.Write("†");
                Console.SetCursorPosition(8, 5); Console.Write("†");
                Console.SetCursorPosition(10, 5); Console.Write("†");
                Console.SetCursorPosition(12, 5); Console.Write("†");
                Console.SetCursorPosition(14, 5); Console.Write("†");
                Console.SetCursorPosition(16, 5); Console.Write("†");
                Console.SetCursorPosition(4, 7); Console.Write("†");
                Console.SetCursorPosition(6, 7); Console.Write("†");
                Console.SetCursorPosition(8, 7); Console.Write("†");
                Console.SetCursorPosition(10, 7); Console.Write("†");
                Console.SetCursorPosition(12, 7); Console.Write("†");
                Console.SetCursorPosition(14, 7); Console.Write("†");
                Console.SetCursorPosition(16, 7); Console.Write("†");
                Console.SetCursorPosition(18, 7); Console.Write("†");
                Console.SetCursorPosition(2, 9); Console.Write("†");
                Console.SetCursorPosition(4, 9); Console.Write("†");
                Console.SetCursorPosition(6, 9); Console.Write("†");
                Console.SetCursorPosition(8, 9); Console.Write("†");
                Console.SetCursorPosition(10, 9); Console.Write("†");
                Console.SetCursorPosition(12, 9); Console.Write("†");
                Console.SetCursorPosition(14, 9); Console.Write("†");
                Console.SetCursorPosition(16, 9); Console.Write("†");
                Console.SetCursorPosition(18, 9); Console.Write("†");
                Console.SetCursorPosition(20, 9); Console.Write("†");
                Console.BackgroundColor = ConsoleColor.Black;
                string zufallsGruss2 = spruch[rnd.Next(spruch.Length)];
                Random color2 = new Random();
                ConsoleColor randomColor2 = (ConsoleColor)color2.Next(1, 16);
                Console.ForegroundColor = randomColor2;
                Console.SetCursorPosition(21, 16); Console.WriteLine($"\n      {zufallsGruss2}       \n");
                Console.SetCursorPosition(0, 19);
                Thread.Sleep(3000);               
            }
        }
    }
}
