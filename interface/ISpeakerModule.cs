namespace DesignPattern
{
    public interface ISpeakerModule
    {
        public List<string> Audio { get; }
        public int Selection { get; set; }
        public HashSet<int> Validation { get; }
        public HashSet<string> Commands { get; }
    }
}