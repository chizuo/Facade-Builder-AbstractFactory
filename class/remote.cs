namespace DesignPattern
{
    public class Remote
    {
        private SignalHandler signal;

        public Remote(SignalHandler receiver)
        {
            signal = receiver;
        }

        public void press(string command)
        {
            if (command == "help")
            {
                manual();
                viewRemote();
            }
            else
            {
                this.signal(command);
            }
        }

        public void manual()
        {
            Console.WriteLine("\n--- Instructions for Remote ---");
            Console.WriteLine("Enter...");
            Console.WriteLine("...'power' to execute that button");
            Console.WriteLine("...'source' to execute that button");
            Console.WriteLine("... a number within 1-999 inclusive to switch to that channel");
            Console.WriteLine("...'vol+' to increase volume by 1 & 'vol-' to decrease volume by 1");
            Console.WriteLine("...'ch+' to increase channel by 1 & 'ch-' to decrease channel by 1");
            Console.WriteLine("...'mute' to mute the volume & unmute if the volume is already muted");
            Console.WriteLine("...'last' will change the channel to its last channel state prior to the current channel");
            Console.WriteLine("...'menu' will launch the screen menu that is specific to your model");
            Console.WriteLine("...'help' will show this operational manual");
            Console.WriteLine("...'q' will quit this program\n");
            Console.Write("....Press the enter button to continue");
            Console.ReadLine();
        }

        public void viewRemote()
        {
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|[  power ]          [ source ]|");
            Console.WriteLine("|[   1    ][    2   ][    3   ]|");
            Console.WriteLine("|[   4    ][    5   ][    6   ]|");
            Console.WriteLine("|[   7    ][    8   ][    9   ]|");
            Console.WriteLine("|[  menu  ][    0   ][        ]|");
            Console.WriteLine("|[    +   ][  mute  ][    +   ]|");
            Console.WriteLine("|[   vol  ][  last  ][   ch   ]|");
            Console.WriteLine("|[    -   ][  audio ][    -   ]|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|[  help  ]          [    q   ]|");
        }
    }
}