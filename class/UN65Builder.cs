namespace DesignPattern
{
    public class UN65Builder : ISamsungTvBuilder
    {
        private ISamsungTelevision _television;

        public void NewTV()
        {
            _television = new Facade();
        }

        public void installScreenModule()
        {
            _television.Screen = new DisplayUN65();
        }

        public void installChannelModule()
        {
            _television.ChannelSystem = new ChannelModuleV1();
        }

        public void installVolumeModule()
        {
            _television.VolumeSystem = new VolumeModule();
        }

        public void installSmartOSModule()
        {
            _television.SmartSystem = new SmartModuleV1();
        }

        public void installSpeakerModule()
        {
            _television.AudioSystem = new SpeakerModuleV1();
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