namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> validation = new HashSet<string>() { "UN75", "UN70", "UN65", "UN58", "UN55", "UN50", "UN43" };
            HashSet<string> commands = new HashSet<string>() {
                "power","source","ch+","ch-","vol+","vol-",
                "mute","menu","info","last","audio",
                "help","q"
            };

            Console.WriteLine("Select Model of Samsung Television: 'UN75','UN70','UN65','UN58','UN55','UN50','UN43'");
            Console.Write("Your selection: ");
            string selection = "";

            do
            {
                selection = Console.ReadLine();
                if (!validation.Contains(selection))
                {
                    Console.WriteLine("invalid model, available choices: 'UN75','UN70','UN65','UN58','UN55','UN50','UN43'");
                    Console.Write("Your selection: ");
                }
            } while (!validation.Contains(selection));

            buildGraphic();
            Thread.Sleep(3000);
            factoryGraphic();
            ISamsungTvFactory factory = new Factory();
            Thread.Sleep(3000);
            ISamsungTelevision television = factory.order(selection);
            buildingTelevision(television.Screen.Size, television.Screen.Model);
            SignalHandler signal = television.commandProcessor;
            Remote remote = new Remote(signal);
            remote.manual();

            do
            {
                remote.viewRemote();
                Console.Write("\nYou press: ");
                selection = Console.ReadLine();
                if (int.TryParse(selection, out _) || commands.Contains(selection))
                    remote.press(selection);
                else
                    Console.WriteLine("invalid remote command, type 'help' to view the manual");
            } while (selection != "q");

            Console.Clear();
            Console.WriteLine("This program has been a demonstration of the following design patterns:");
            Console.WriteLine("- Abstract Factory Pattern");
            Console.WriteLine("- Builder Pattern");
            Console.WriteLine("- Facade Pattern");
        }

        static void buildGraphic()
        {
            Console.Clear();
            Console.WriteLine("Building the (abstract) factory (pattern) that produces ISamsungTelevisions\n");
            Console.WriteLine("                    O");
            Console.WriteLine("    /~~~|#|]|=\\|---\\__");
            Console.WriteLine("  |-=_____________  |\\ ,                O       O");
            Console.WriteLine(" I|_/,-.-.-.-.-,-.\\_|='(               T/\\     /\\=,---.");
            Console.WriteLine("    ( o )( o )( o )     \\              U /\\   /\\   `O'  ");
        }

        static void factoryGraphic()
        {
            Console.Clear();
            Console.WriteLine("The (concrete) factory has been built!\n");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⢸⣿");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⢸⣿");
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⢸⣿⡇⠀⢸⣿");
            Console.WriteLine("⠀⠀⢠⣷⡀⠀⠀⠀⠀⣼⣦⠀⠀⠀⠀⢠⣷⣄⠀⠀⠀⠀⢸⣿⡇⠀⢸⣿");
            Console.WriteLine("⠀⠀⢸⣿⣿⣆⠀⠀⠀⣿⣿⣷⡀⠀⠀⢸⣿⣿⣧⠀⠀⠀⢸⣿⡇⠀⢸⣿");
            Console.WriteLine("⠀⠀⣾⣿⣿⣿⣷⡀⢠⣿⣿⣿⣿⣆⠀⣼⣿⣿⣿⣷⣄⠀⢸⣿⡇⠀⢸⣿");
            Console.WriteLine("⠀⠀⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣷⣿⣿⣿⣿⣿⣿⣶⣼⣿⣧⣤⣾⣿");
            Console.WriteLine("⠀⠀⣿⡟⠉⠉⢹⣿⡏⠉⠉⢻⣿⠉⠉⠉⣿⣿⠉⠉⢹⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine("⠀⠀⣿⣷⣶⣶⣾⣿⣷⣶⣶⣾⣿⣶⣶⣶⣿⣿⣶⣶⣾⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine("⠀⠀⣿⡏⠉⠉⢹⣿⡏⠉⠉⢹⣿⠉⠉⠉⣿⣿⠉⠉⢹⣿⣿⣿⣿⣿⣿⣿");
            Console.WriteLine("⠀⠀⣿⣿⣶⣶⣾⣿⣷⣶⣶⣿⣿⣷⣶⣾⣿⣿⣶⣶⣾⣿⣿⣿⣿⣿⣿⣿");
        }

        static void buildingTelevision(int size, string model)
        {
            Console.Clear();
            Console.WriteLine("The builder (pattern) is assembling your {0} inch Samsung {1} television....\n", size.ToString(), model);
            Thread.Sleep(500);
            Console.WriteLine(".---..-----------------------------------------------..---.");
            Thread.Sleep(500);
            Console.WriteLine("|   ||.---------------------------------------------.||   |");
            Thread.Sleep(500);
            Console.WriteLine("| o |||                                             ||| o |");
            Thread.Sleep(500);
            Console.WriteLine("| _ |||                                             ||| _ |");
            Thread.Sleep(500);
            Console.WriteLine("|(_)|||                                             |||(_)|");
            Thread.Sleep(500);
            Console.WriteLine("|   |||                                             |||   |");
            Thread.Sleep(500);
            Console.WriteLine("|.-.|||                                             |||.-.|");
            Thread.Sleep(500);
            Console.WriteLine("| o |||                                             ||| o |");
            Thread.Sleep(500);
            Console.WriteLine("|`-'|||                                             |||`-'|");
            Thread.Sleep(500);
            Console.WriteLine("|   |||                                             |||   |");
            Thread.Sleep(500);
            Console.WriteLine("|.-.|||                                             |||.-.|");
            Thread.Sleep(500);
            Console.WriteLine("| O |||                                             ||| O |");
            Thread.Sleep(500);
            Console.WriteLine("|`-'||`---------------------------------------------'||`-'|");
            Thread.Sleep(500);
            Console.WriteLine("`---'`-----------------------------------------------'`---'");
            Thread.Sleep(500);
            Console.WriteLine("        _||_                                   _||_\n");
        }
    }
}