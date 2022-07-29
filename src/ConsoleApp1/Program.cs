namespace FoodiesCorner.ConsoleApp
{
    public class program
    {
        public class Human
        {
            internal string Name;
            internal int Id;
        }
        public static void main(String[] args)
        {
            Human h1 = new Human();
            h1.Name = "n1";
            Human h2 = new Human();
            h2.Name = "n2";
            Console.WriteLine(h1.Name);


            h1.Id = 25;
            h2.Id = 30;
            h2 = h1;
            Console.WriteLine(h1.Name);
            int i2 = 20;
            PassHuman(h1, i2);
            Console.WriteLine(h1.Name);

        }


        static void PassHuman(Human h1, int i2)
        {


            h1.Name = "ChangedInFuncrtion";
            i2 = 20;
        }
    }
   

}



