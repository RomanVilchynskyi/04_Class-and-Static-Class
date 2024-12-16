using _04_Class_and_Static_Class;

internal class Program
{
    private static void Main(string[] args)
    {
        Character ch = new Character("Elf", 100, 10);
        ch.Print();
        Console.WriteLine(ch);
        Character ch_2 = new Character(damage: 15, name: "Mag", hp: 150);
        ch_2.Name = "   \n";
        ch_2.Name = "Kind Elf";
        Console.WriteLine(ch_2);

        Character ch_3 = new Character() {Name = "Ranger", Damage = 10, Hp = 100 };
        Console.WriteLine(ch_3);
    }
}