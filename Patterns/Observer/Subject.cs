using System;
using System.Collections.Generic;

namespace Patterns.Observer {
    class Subject<T> {
        private List<Observer<T>> observers = new List<Observer<T>>();

        public void Add(Observer<T> observer) {
            observers.Add(observer);
        }

        public void Remove(Observer<T> observer) {
            observers.Remove(observer);
        }

        public void Notify(T data) {
            foreach (var observer in observers) {
                observer.Update(data);
                Console.WriteLine("Notify called!");
            }
        }
    }
}