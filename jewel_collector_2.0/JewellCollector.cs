namespace JewelCollector
{
    class JewelCollector
    {
        static void Main(string[] args)
        {

            // criei um robo de teste
            var testerbot = new Robot(1, 1, 5);
            ConsoleKeyInfo keyinfo; // definição da variavel da tecla pressionada
            bool gameRunning = true;

            // Prototype declaration of the map array
            // TODO: implement this inside the Map class, outside of the Main function
            var map = new Map(new Robot(1, 1, 5));
            do
            {
                map.Print();
                Console.Write("Insira um movimento: ");
                keyinfo = Console.ReadKey(); // lê o evento do teclado
                testerbot.Movement(keyinfo.Key); // printa a tecla pressionada
                Console.WriteLine(testerbot.getCoordinate()); // printa as novas coordenadas

                if (keyinfo.Key == ConsoleKey.X)
                    gameRunning = false; //eXit
                if (keyinfo.Key == ConsoleKey.R)
                {
                    // mapArray[1,1]++;
                    continue; //reloop to the redraw
                }
            } while (gameRunning == true);


        }
    }
}