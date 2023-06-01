namespace JewelCollector
{
    class JewelCollector
    {
        
        static void Main(string[] args) {

            // criei um robo de teste
            var testerbot = new Robot(2,2,5);
            subscriptorEvent gameMap = new subscriptorEvent();
            ConsoleKeyInfo keyinfo; // definição da variavel da tecla pressionada
            Map.Print();
            do {
                
                Console.Write("Insira um movimento: ");
                keyinfo = Console.ReadKey(); // lê o evento do teclado
                gameMap.MovementEvent(keyinfo.Key);
                // testerbot.Movement(keyinfo.Key); // printa a tecla pressionada
                Console.WriteLine(gameMap.robotCoordinate()); // printa as novas coordenadas
            }   
            while (keyinfo.Key != ConsoleKey.X);

        }

    }
}