namespace DesignPattern
{
    public class Factory : ISamsungTvFactory
    {
        private readonly ISamsungTvBuilder worker1;
        private readonly ISamsungTvBuilder worker2;
        private readonly ISamsungTvBuilder worker3;
        private readonly ISamsungTvBuilder worker4;
        private readonly ISamsungTvBuilder worker5;
        private readonly ISamsungTvBuilder worker6;
        private readonly ISamsungTvBuilder worker7;

        public Factory()
        {
            worker1 = new UN75Builder();
            worker2 = new UN70Builder();
            worker3 = new UN65Builder();
            worker4 = new UN58Builder();
            worker5 = new UN55Builder();
            worker6 = new UN50Builder();
            worker7 = new UN43Builder();
        }

        public ISamsungTelevision order(string model)
        {
            ISamsungTelevision product;
            switch (model)
            {
                case "UN75":
                    product = buildModel1();
                    break;
                case "UN70":
                    product = buildModel2();
                    break;
                case "UN65":
                    product = buildModel3();
                    break;
                case "UN58":
                    product = buildModel4();
                    break;
                case "UN55":
                    product = buildModel5();
                    break;
                case "UN50":
                    product = buildModel6();
                    break;
                default:
                    product = buildModel7();
                    break;
            }
            return product;
        }
        public ISamsungTelevision buildModel1()
        {
            worker1.NewTV();
            worker1.installChannelModule();
            worker1.installPowerModule();
            worker1.installScreenModule();
            worker1.installSmartOSModule();
            worker1.installSpeakerModule();
            worker1.installVolumeModule();
            return worker1.FinalizeProduct();
        }

        public ISamsungTelevision buildModel2()
        {
            worker2.NewTV();
            worker2.installChannelModule();
            worker2.installPowerModule();
            worker2.installScreenModule();
            worker2.installSmartOSModule();
            worker2.installSpeakerModule();
            worker2.installVolumeModule();
            return worker2.FinalizeProduct();
        }

        public ISamsungTelevision buildModel3()
        {
            worker3.NewTV();
            worker3.installChannelModule();
            worker3.installPowerModule();
            worker3.installScreenModule();
            worker3.installSmartOSModule();
            worker3.installSpeakerModule();
            worker3.installVolumeModule();
            return worker3.FinalizeProduct();
        }

        public ISamsungTelevision buildModel4()
        {
            worker4.NewTV();
            worker4.installChannelModule();
            worker4.installScreenModule();
            worker4.installSmartOSModule();
            worker4.installSpeakerModule();
            worker4.installVolumeModule();
            return worker4.FinalizeProduct();
        }

        public ISamsungTelevision buildModel5()
        {
            worker5.NewTV();
            worker5.installChannelModule();
            worker5.installScreenModule();
            worker5.installSmartOSModule();
            worker5.installSpeakerModule();
            worker5.installVolumeModule();
            return worker5.FinalizeProduct();
        }

        public ISamsungTelevision buildModel6()
        {
            worker6.NewTV();
            worker6.installChannelModule();
            worker6.installScreenModule();
            worker6.installSmartOSModule();
            worker6.installSpeakerModule();
            worker6.installVolumeModule();
            return worker6.FinalizeProduct();
        }

        public ISamsungTelevision buildModel7()
        {
            worker7.NewTV();
            worker7.installChannelModule();
            worker7.installScreenModule();
            worker7.installSmartOSModule();
            worker7.installSpeakerModule();
            worker7.installVolumeModule();
            return worker7.FinalizeProduct();
        }
    }
}