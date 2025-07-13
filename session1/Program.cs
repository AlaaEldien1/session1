using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shared;
namespace session1
{
    internal class Program
    {
        enum weekDays
        {
            Sunday = 1 ,
            Monday = 2 ,
            tuesday = 3 ,
            wednesday = 4 , 
            friday = 5 ,
            saturday = 6 
        }
        struct Person
        {
            public int age;
            public string name;
            public Person(int age, string name)
            {
                this.age = age;
                this.name = name;
            }
        }
        enum Seasson
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        enum Colors
        {
            red,
            green,
            blue
        }
        struct Point
        {
            public double x; 
            public double y;
            public Point (double x , double y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            #region question 1 
            //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //int count = 1;
            //foreach (weekDays day in Enum.GetValues(typeof(weekDays)))
            //{
            //    Console.WriteLine(day);
            //    Console.WriteLine("the day printed with the number");
            //    Console.WriteLine(Enum.GetName(typeof(weekDays), count));
            //    count++;
            //}
            #endregion
            #region question2
            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];
            //people[0] = new Person(20,"ali");
            //people[1]  = new Person(21,"amir");
            //people[2] = new Person(22,"ahmed");
            //foreach (Person p in people  )
            //    Console.WriteLine($"the name : {p.name} the age is : {p.age}");
            #endregion
            #region question3
            //Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("enter the season name ");
            //string seasonName = Console.ReadLine();
            //Enum.TryParse(seasonName, true, out Seasson s);
            //switch (s)
            //{
            //    case Seasson.Spring:
            //        Console.WriteLine("Spring is from March to May.");
            //        break;
            //    case Seasson.Summer:
            //        Console.WriteLine("Summer is from June to August.");
            //        break;
            //    case Seasson.Autumn:
            //        Console.WriteLine("Autumn is from September to November.");
            //        break;
            //    case Seasson.Winter:
            //        Console.WriteLine("Winter is from December to February.");
            //        break;
            //}
            #endregion
            #region question4
            //Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("enter a  color");
            //string color =  Console.ReadLine();
            //if (Enum.IsDefined(typeof(Colors), color))
            //    Console.WriteLine("the color is primary");
            //else
            //    Console.WriteLine("the color is not primary");
            #endregion
            #region question5 
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("enter x1");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter y1");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter x2");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter y2");
            //double y2 = double.Parse(Console.ReadLine()); 
            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);
            //double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            //Console.WriteLine($"the distanse between the two points os {distance}");  
            #endregion
            #region question6
            //Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] peoples = new Person[3];
            //for (int i = 0; i < peoples.Length; i++)
            //{
            //    Console.WriteLine("enter the person age");
            //    peoples[i].age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter the person name");
            //    peoples[i].name = Console.ReadLine();
            //}
         
            //Person oldest = peoples[0];
            //for (int i = 1; i < peoples.Length; i++)
            //{
            //    if (peoples[i].age > oldest.age)
            //    {
            //        oldest = peoples[i];
            //    }
            //}
            //Console.WriteLine($" the oldest is : {oldest.name}");
            #endregion
        }
    }
}
