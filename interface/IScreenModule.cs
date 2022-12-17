namespace DesignPattern
{
    public interface IScreenModule
    {
        public int Size { get; }
        public string Model { get; }
        public void display(string content);
    }
}