namespace DesignPattern
{
    public interface ISamsungTvFactory
    {
        public ISamsungTelevision order(string model);
        public ISamsungTelevision buildModel1();
        public ISamsungTelevision buildModel2();
        public ISamsungTelevision buildModel3();
        public ISamsungTelevision buildModel4();
        public ISamsungTelevision buildModel5();
        public ISamsungTelevision buildModel6();
        public ISamsungTelevision buildModel7();
    }
}