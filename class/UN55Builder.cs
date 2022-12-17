namespace DesignPattern
{
    public class UN55Builder : ISamsungTvBuilder
    {
        private ISamsungTelevision _television;

        public void NewTV()
        {
            _television = new Facade();
        }

        public void installScreenModule()
        {
            _television.Screen = new DisplayUN55();
        }

        public void installChannelModule()
        {
            _television.ChannelSystem = new ChannelModuleV2();
        }

        public void installVolumeModule()
        {
            _television.VolumeSystem = new VolumeModule();
        }

        public void installSmartOSModule()
        {
            _television.SmartSystem = new SmartModuleV2();
        }

        public void installSpeakerModule()
        {
            _television.AudioSystem = new SpeakerModuleV2();
        }

        public void installPowerModule()
        {
            _television.PowerSystem = new PowerModule();
        }

        public ISamsungTelevision FinalizeProduct()
        {
            return _television;
        }
    }
}