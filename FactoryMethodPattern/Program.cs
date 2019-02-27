using System;
using System.Collections.Generic;


namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine[] machines = new Machine[2];
            machines[0] = new Car();
            machines[1] = new Moto();

            foreach (Machine machine in machines)
            {
                Console.WriteLine("\n" + machine.GetType().Name + "--");
                foreach (Part part in machine.AllParts)
                {
                    Console.WriteLine(" " + part.GetType().Name);
                }
            }
            Console.Read();
        }

        protected abstract class Part
            {
            }

        protected class Wheel : Part
        {

        }

        protected class Seat : Part
        {

        }

        protected abstract class Machine
        {
            protected List<Part> parts = new List<Part>();

            public  Machine()
            {
                Assamble();
            }

            public List<Part> AllParts
            {
                get { return this.parts; }
            }
            //Factory Method
            public abstract void Assamble();
        }

        protected class Car : Machine
        {
            public override void Assamble()
            {
                this.parts.Add(new Wheel());
                this.parts.Add(new Wheel());
                this.parts.Add(new Wheel());
                this.parts.Add(new Wheel());
                this.parts.Add(new Seat());
                this.parts.Add(new Seat());
                this.parts.Add(new Seat());
                this.parts.Add(new Seat());
                this.parts.Add(new Seat());
            }
        }

        protected class Moto : Machine
        {
            public override void Assamble()
            {
                this.parts.Add(new Wheel());
                this.parts.Add(new Wheel());
                this.parts.Add(new Seat());
                this.parts.Add(new Seat());

            }
        }


    }
}
