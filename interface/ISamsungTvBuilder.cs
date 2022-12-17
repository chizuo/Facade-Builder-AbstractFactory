namespace DesignPattern
{
    public interface ISamsungTvBuilder
    {
        public void NewTV();
        public void installScreenModule();
        public void installChannelModule();
        public void installVolumeModule();
        public void installPowerModule();
        public void installSmartOSModule();
        public void installSpeakerModule();
        public ISamsungTelevision FinalizeProduct();
    }
}