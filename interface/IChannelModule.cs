namespace DesignPattern
{
    public interface IChannelModule
    {
        public int Channel { get; set; }
        public int Index { get; set; }
        public int Last { get; set; }
        public string Source { get; set; }
        public List<string> Sources { get; }
        public HashSet<string> Commands { get; }
        public int Min { get; }
        public int Max { get; }
    }
}