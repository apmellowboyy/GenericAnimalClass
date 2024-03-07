using System;
namespace blud
{
    public class Animal < A >
    {
        public A data;
        public Animal( A data )
        {
            this.data = data;
            Console.WriteLine("Animal Info - " + this.data);
        }

        public A getAnimal()
        {
            return data;
        }
    }
    class Program
    {
        static void Main()
        {
            Animal < string > animalName = new Animal < string >("Capybara");
            Animal<string> animalHabitat = new Animal<string>("Dense Forest");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> lifeSpan = new Animal<int>(6);
         

        }
    }
}
