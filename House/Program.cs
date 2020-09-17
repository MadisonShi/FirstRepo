using System;

namespace House
{
    public class House{
        protected int area;
        protected Door door;

        public House(int area){
            this.area = area;
            door = new Door();
        }

        public int Area{
            get{return area;}
            set{area = value;}
        }

        public Door Door{
            get{return door;}
            set{door = value;}
        }

        public virtual void ShowData(){
            Console.WriteLine("I am a house, my area is {0} m2.", this.area);
        }
    }

    public class SmallApartment : House{

        public SmallApartment() : base(50)
        {

        }

          public override void ShowData()
          {
               Console.WriteLine("I am an apartment. My area is {0} m2.", this.area);
          }
 
    }

    public class Door{
        protected String color;

        public Door(){
            this.color = "Brown";
        }

        public Door(String c){
            this.color = c;
        }

        public String Color{
            get{return color;}
            set{color = value;}
        }

        public void ShowData(){
            Console.WriteLine("I am a door, my color is {0}.", this.color);
        }
    }

    public class Person{
        private String name;
        private House house;
        public Person(){
            this.name = "Madison";
            this.house = new House(50);
        }

        public Person(string n, House h){
            this.name = n;
            this.house = h;
        }

        public String Name{
            get{return name;}
            set{name = value;}
        }

        public House House{
            get{return house;}
            set{house = value;}
        }

        public void ShowData(){
            Console.WriteLine("My name is " + this.name + ".");
            house.ShowData(); 
            house.Door.ShowData();
        }
    }

    class Program{
        static void Main(string[] args)
        {
            SmallApartment sa = new SmallApartment();
            Person p = new Person("Nancy", sa);
            p.ShowData();
        }
    }
}
