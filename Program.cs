using System;
using System.Threading;


namespace factory_method
{
    //Logistic Class
    abstract class Logistic
    {
        public abstract ITransport FactoryMethod();
        public string SendRoute(){
            var transport=FactoryMethod();
            return transport.StartRoute();
        }
    }
    class LogisticRoad: Logistic
    {
        public override ITransport FactoryMethod()
        {
            return new TransportRoad();
        }
    }
    class LogisticSea: Logistic
    {
        public override ITransport FactoryMethod()
        {
            return new TransportSea();
        }
    }
    class LogisticAir: Logistic
    {
        public override ITransport FactoryMethod()
        {
            return new TransportAir();
        }
    }

    //Transport Class
    public interface ITransport
    {
        string StartRoute();
    }
    class TransportRoad: ITransport
    {
        public string StartRoute()
        {
            return @"Beginning Road Route                                       ________________________
                                                                    ,---------+/       +----------+     \
                                                                /          ||        |          |      |
                                                                /            ||        +----------+      |
                                            _________------=--<I|---------+----------------------------,
                                            .----=============|=========---=|=======================-->> |
                                            |     ______      |             |              ______        |
                                            [|    / _--_ \     /             |             / _--_ \       ]
                                            \__|| -__- ||___/_____________/_____________|| -__- ||_____/
                                                \____/                                   \____/";

        }
    }
    class TransportSea: ITransport
    {
        public string StartRoute(){
            return @"Beginning Sea Route                                    )___(
                                                                    _______/__/_
                                                            ___     /===========|   ___
                                            ____       __   [\\\]___/____________|__[///]   __
                                            \   \_____[\\]__/___________________________\__[//]___
                                            \40A                                                 |
                                            \                                                  /
                                            ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        }
    }
    class TransportAir: ITransport
    {
        public string StartRoute(){
            return @"Beginning Sea Route    __
                                            \  \     _ _
                                                \**\ ___\/ \
                                            X*#####*+^^\_\
                                                o/\  \
                                                \__\";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Como utilizamos el patron de diseño de Factory Method.
            Console.WriteLine("PRUEBA # 1");
            Thread.Sleep(2000);
            Console.WriteLine("Solicitando transporte terrestre");
            Thread.Sleep(2000);
            StartRoute(new LogisticRoad());
            Thread.Sleep(2000);
            Console.WriteLine("PRUEBA # 2");
            Thread.Sleep(2000);
            Console.WriteLine("Solicitando transporte maritimo");
            Thread.Sleep(2000);
            StartRoute(new LogisticSea());
            Thread.Sleep(2000);
            Console.WriteLine("PRUEBA # 3");
            Thread.Sleep(2000);
            Console.WriteLine("Solicitando transporte Aereo");
            Thread.Sleep(2000);
            StartRoute(new LogisticAir());
            Thread.Sleep(2000);
            Console.WriteLine("Buen viaje!!!!!!");
        }
        public static void StartRoute(Logistic obj)
        {
            Console.WriteLine(obj.SendRoute());
        }
    }
}
