namespace Patterns.Adapter {
    public class AdapterRunner :AbstractRunner{
        public override void Run() {
            Adaptee Adaptee = new Adaptee();
            ITarget t = new Adapter(Adaptee);
            t.OnRequest();
            
            AdapteeV2 adapteeV2 = new AdapteeV2();
            var ad2 = new AdapterV2<AdapteeV2>(adapteeV2);
            AdapteeV2 result = ad2.Work();
            
        }
    }
}