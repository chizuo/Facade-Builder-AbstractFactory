namespace DesignPattern
{
    public class VolumeModule : IVolumeModule
    {
        private int volume = 50;
        private int max = 100;
        private int min = 0;
        private Boolean state = false;
        private HashSet<string> _commands = new HashSet<string>() { "vol+", "vol-", "mute" };
        public int Volume { get { return volume; } set { volume = value; } }
        public Boolean Mute { get { return state; } set { state = value; } }
        public int Min { get { return min; } }
        public int Max { get { return max; } }
        public HashSet<string> Commands { get { return _commands; } }
        public string mute()
        {
            this.state = !this.state ? true : false;
            return this.state ? "Volume: MUTE" : "Volume: " + this.volume.ToString();
        }
    }
}