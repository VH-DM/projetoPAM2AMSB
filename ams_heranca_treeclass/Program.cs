namespace ams_heranca_treeclass{
class program{
        public static void Main(string[] args)
        {
            Fly aguia = new Fly("224312", "Águia");
            Walk pinguim = new Walk("224313", "Pinguim");

                System.Console.WriteLine($"-=-=-=-=- AVES -=-=-=-=-");
                
            aguia.Voar();

            System.Console.WriteLine($"-=-=-=-=-=-=-=-=-=-");
                
            pinguim.Voar();
        }
    }
}
