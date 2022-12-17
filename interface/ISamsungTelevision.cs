namespace DesignPattern
{
    public interface ISamsungTelevision
    {
        public IChannelModule ChannelSystem { get; set; }
        public IVolumeModule VolumeSystem { get; set; }
        public IPowerModule PowerSystem { get; set; }
        public ISpeakerModule AudioSystem { get; set; }
        public ISmartOSModule SmartSystem { get; set; }
        public IScreenModule Screen { get; set; }

        public void commandProcessor(string command);
        public void channel(string command);
        public void channel(int number);
        public void volume(string command);
        public void power();
        public void menu();
        public void settings();
        public void screen(string content);
    }
}