namespace DesignPattern
{
    public interface IPowerModule
    {
        public Boolean Power { get; }
        public string power();
        public HashSet<string> Commands { get; }
    }
}