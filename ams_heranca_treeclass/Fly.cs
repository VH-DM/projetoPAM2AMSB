namespace ams_heranca_treeclass{
class Fly : Ave{
        public Fly(string id, string name) : base(id, name){
        }

        public virtual void Voar(){
            Console.WriteLine($"A {Name}, é uma ave que voa.");
            Console.WriteLine($"O ID da águia é: {ID}");
            Console.WriteLine($"O nome da espécie é: {Name}");
        }
    }
}