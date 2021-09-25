using System;

namespace Patterns.Adapter {
    public class AdapterV2<T> : IType<T> where T : IType<T> {
        private T _type;

        public AdapterV2(T type) {
            _type = type;
        }

        public T Work() {
            Console.WriteLine("AD Work");

            return _type.Work();
        }
    }

    public interface IType<T> {
        T Work();
    }

    public class AdapteeV2 : IType<AdapteeV2> {
        public AdapteeV2 Work() {
            Console.WriteLine("AD");
            return this;
        }
    }

    public class Adapter : ITarget {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee) {
            _adaptee = adaptee;
        }

        public void OnRequest() {
            _adaptee.Request();
        }
    }

    public class Adaptee {
        public void Request() {
            Console.WriteLine("I am called from Adaptee!\n");
        }
    }

    interface ITarget {
        void OnRequest();
    }
}