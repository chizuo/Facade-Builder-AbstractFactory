namespace DesignPattern
{
    public class Facade : ISamsungTelevision
    {
        public IChannelModule ChannelSystem { get; set; }
        public IVolumeModule VolumeSystem { get; set; }
        public IPowerModule PowerSystem { get; set; }
        public ISpeakerModule AudioSystem { get; set; }
        public ISmartOSModule SmartSystem { get; set; }
        public IScreenModule Screen { get; set; }

        public void commandProcessor(string command)
        {
            if (PowerSystem.Power)
            {
                if (int.TryParse(command, out _) || ChannelSystem.Commands.Contains(command))
                {
                    if (int.TryParse(command, out int result))
                    {
                        channel(result);
                    }
                    else if (command == "source")
                    {
                        source();
                    }
                    else
                    {
                        channel(command);
                    }
                }
                else if (VolumeSystem.Commands.Contains(command))
                {
                    volume(command);
                }
                else if (PowerSystem.Commands.Contains(command))
                {
                    power();
                }
                else if (AudioSystem.Commands.Contains(command))
                {
                    settings();
                }
                else if (SmartSystem.Commands.Contains(command))
                {
                    menu();
                }
                else
                {
                    screen("Invalid remote command");
                }
            }
            else
            {
                if (command == "power")
                    power();
                else
                    screen("Power: OFF, turn on first!");
            }
        }

        public void channel(int number)
        {
            if (ChannelSystem.Max >= number && ChannelSystem.Min <= number)
            {
                ChannelSystem.Channel = number;
                screen("Channel: " + ChannelSystem.Channel.ToString());
            }
            else
            {
                screen(Screen.Model + " channel min: " + ChannelSystem.Min + ", max:" + ChannelSystem.Max);
            }
        }

        public void channel(string command)
        {
            int current = ChannelSystem.Channel;
            if (command == "ch+")
            {
                if (current < ChannelSystem.Max)
                {
                    ChannelSystem.Last = current;
                    ChannelSystem.Channel = ++current;
                }

            }
            else if (command == "ch-")
            {
                if (current > ChannelSystem.Min)
                {
                    ChannelSystem.Last = current;
                    ChannelSystem.Channel = --current;
                }
            }
            else
            {
                int last = ChannelSystem.Channel;
                ChannelSystem.Channel = ChannelSystem.Last;
                ChannelSystem.Last = last;
            }
            screen("Channel: " + ChannelSystem.Channel.ToString());
        }

        public void volume(string command)
        {
            int current = VolumeSystem.Volume;
            string info = "";
            if (command == "vol+")
            {
                if (current < VolumeSystem.Max)
                    VolumeSystem.Volume = ++current;
                info = "Volume: " + VolumeSystem.Volume.ToString();

            }
            else if (command == "vol-")
            {
                if (current > VolumeSystem.Min)
                    VolumeSystem.Volume = --current;
                info = "Volume: " + VolumeSystem.Volume.ToString();
            }
            else
            {
                VolumeSystem.Mute = !VolumeSystem.Mute ? true : false;
                info = VolumeSystem.Mute ? "Volume: MUTE" : "Volume: " + VolumeSystem.Volume.ToString();
            }
            screen(info);
        }

        public void power()
        {
            screen(PowerSystem.power());
        }

        public void source()
        {
            ChannelSystem.Index = ChannelSystem.Index == ChannelSystem.Sources.Count - 1 ? 0 : 1 + ChannelSystem.Index;
            screen("Source: " + ChannelSystem.Source);
        }

        public void menu()
        {
            screen(SmartSystem.menu());
        }

        public void screen(string content)
        {
            Screen.display(content);
        }

        public void settings()
        {
            var settings = AudioSystem.Audio;
            string choice = "";
            Console.WriteLine("\n***** Audio System Settings *****");
            for (int i = 0; i < settings.Count; i++)
            {
                string selection = i == AudioSystem.Selection ? "x" : (i + 1).ToString();
                Console.Write("[{0}]{1} ", selection, settings[i]);
            }
            Console.Write("\nSelect audio setting: ");
            do
            {
                choice = Console.ReadLine();
                if (!AudioSystem.Validation.Contains(int.Parse(choice) - 1))
                {
                    Console.WriteLine("invalid selection, try again");
                    Console.Write("\nSelect audio setting: ");
                }
            } while (!AudioSystem.Validation.Contains(int.Parse(choice) - 1));
            AudioSystem.Selection = int.Parse(choice) - 1;
        }
    }
}