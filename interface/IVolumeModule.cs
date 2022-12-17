namespace DesignPattern
{
    public interface IVolumeModule
    {
        public int Volume { get; set; }
        public int Max { get; }
        public int Min { get; }
        public Boolean Mute { get; set; }
        public HashSet<string> Commands { get; }
        public string mute();
    }
}