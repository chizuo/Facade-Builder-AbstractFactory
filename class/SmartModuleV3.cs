namespace DesignPattern
{
    public class SmartModuleV3 : ISmartOSModule
    {
        private readonly string _os = "Tizen v.79.01";
        private readonly HashSet<string> _commands = new HashSet<string>() { "menu" };
        public string menu() { return "Smart Menu powered by " + _os; }
        public HashSet<string> Commands { get { return _commands; } }
    }
}