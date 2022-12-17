namespace DesignPattern
{
    public class SpeakerModuleV3 : ISpeakerModule
    {
        private List<string> _audio = new List<string> { "atmos", "thx", "stereo" };
        private int selection = 0;
        private readonly HashSet<string> _commands = new HashSet<string>() { "audio" };
        private readonly HashSet<int> _valid = new HashSet<int>() { 0, 1, 2 };
        public List<string> Audio { get { return _audio; } }
        public HashSet<int> Validation { get { return _valid; } }
        public HashSet<string> Commands { get { return _commands; } }
        public int Selection { get { return selection; } set { selection = value; } }
    }
}