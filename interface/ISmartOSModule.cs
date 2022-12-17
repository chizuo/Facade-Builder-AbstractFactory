namespace DesignPattern
{
    public interface ISmartOSModule
    {
        public string menu();
        public HashSet<string> Commands { get; }
    }
}