using System;
namespace Person
{
    public class Human
    {
        string Name;
        string Place;
        string Work;
        string Age;

        public Human()
        {

            Console.WriteLine("enter your name name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Where do you live?: ");
            Place = Console.ReadLine();

            Console.WriteLine("Where do you work?: ");
            Work = Console.ReadLine();

            Console.WriteLine("How old are you?: ");
            Age = Console.ReadLine();

            Console.Clear();
        }

        /*  internal bool Info()
         {
             throw new NotImplementedException();
         }*/

        public override string ToString() => Name + ", " + Age
                + " years old,  lives in "
                + Place + " works at "
                + Work + ".";
    }
}
