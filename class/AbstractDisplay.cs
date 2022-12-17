namespace DesignPattern
{
    public abstract class Display : IScreenModule
    {
        protected int _size;
        protected string _model;
        public int Size { get { return _size; } }
        public string Model { get { return _model; } }

        public void display(string content)
        {
            Console.Clear();
            Console.WriteLine("\n.---..-----------------------------------------------..---.");
            Console.WriteLine("|   ||.---------------------------------------------.||   |");
            Console.WriteLine("| o |||                                             ||| o |");
            Console.WriteLine("| _ |||                                             ||| _ |");
            Console.WriteLine("|(_)|||                                             |||(_)|");
            Console.WriteLine("|   |||                                             |||   |");
            Console.Write("|   ||| ");
            Console.Write(content.PadRight(44));
            Console.WriteLine("|||   |");
            Console.WriteLine("|.-.|||                                             |||.-.|");
            Console.WriteLine("| o |||                                             ||| o |");
            Console.WriteLine("|`-'|||                                             |||`-'|");
            Console.WriteLine("|   |||                                             |||   |");
            Console.WriteLine("|.-.|||                                             |||.-.|");
            Console.WriteLine("| O |||                                             ||| O |");
            Console.WriteLine("|`-'||`---------------------------------------------'||`-'|");
            Console.WriteLine("`---'`-----------------------------------------------'`---'");
            Console.WriteLine("        _||_                                   _||_\n");
        }
    }
}