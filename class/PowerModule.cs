namespace DesignPattern
{
    public class PowerModule : IPowerModule
    {
        private Boolean state = false;
        private readonly HashSet<string> _commands = new HashSet<string>() { "power" };
        public HashSet<string> Commands { get { return _commands; } }
        public Boolean Power { get { return state; } }
        public string power()
        {
            this.state = !this.state ? true : false;
            return this.state ? "Power: On" : "Power: Off";
        }
    }
}