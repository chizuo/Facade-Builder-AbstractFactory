namespace DesignPattern
{
    public class ChannelModuleV3 : IChannelModule
    {
        private int channel = 3;
        private int min = 0;
        private int max = 999;
        private int index = 0;
        private int last = 3;
        private readonly HashSet<string> _commands = new HashSet<string>() { "ch+", "ch-", "last", "source" };
        private readonly List<string> _source = new List<string> { "antenna", "HDMI1", "HDMI2" };
        public int Channel { get { return channel; } set { channel = value; } }
        public int Last { get { return last; } set { last = value; } }
        public int Index { get { return index; } set { index = value; } }
        public string Source { get { return _source[index]; } set { index = int.Parse(value); } }
        public List<string> Sources { get { return _source; } }
        public HashSet<string> Commands { get { return _commands; } }
        public int Min { get { return min; } }
        public int Max { get { return max; } }
    }
}