namespace JewelCollector
{
    class JewelCollector
    {
        static void Main(string[] args)
        {

            // criei um robo de teste
            var testerbot = new Robot(1, 1, false, false, 25);
            ConsoleKeyInfo keyinfo; // definição da variavel da tecla pressionada
            bool gameRunning = true;

            // Prototype declaration of the map array
            // TODO: implement this inside the Map class, outside of the Main function
            var map = new Map(testerbot);
            do
            {
                // map.SetRobotPosition();
                // map.Print();
                map.MapRender(map);    
                Console.WriteLine(testerbot.getCoordinate());
                Console.Write("Energia: ");
                Console.WriteLine(testerbot.totalEnergy);

                Console.Write("Insira um movimento: ");
                keyinfo = Console.ReadKey(); // lê o evento do teclado
                // testerbot.Movement(keyinfo.Key, ref map); // printa a tecla pressionada
                map.MovementEvent(keyinfo.Key, ref map, map.map);

                if (keyinfo.Key == ConsoleKey.X || keyinfo.Key == ConsoleKey.Q)
                    gameRunning = false; //eXit
                else if (testerbot.totalEnergy == 0)
                    gameRunning = false;
            } while (gameRunning == true);
        }
    }
}