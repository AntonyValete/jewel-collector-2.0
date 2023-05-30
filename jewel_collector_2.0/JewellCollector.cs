namespace JewelCollector
{
    class JewelCollector
    {
        static void Main(string[] args) {

            // criei um robo de teste
            var testerbot = new Robot(2,2,5);

            ConsoleKeyInfo keyinfo; // definição da variavel da tecla pressionada
            map.Print();
            do {
                
                Console.Write("Insira um movimento: ");
                keyinfo = Console.ReadKey(); // lê o evento do teclado
                testerbot.Movement(keyinfo.Key); // printa a tecla pressionada
                Console.WriteLine(testerbot.getCoordinate()); // printa as novas coordenadas
            }   
            while (keyinfo.Key != ConsoleKey.X);

        }
    }
}