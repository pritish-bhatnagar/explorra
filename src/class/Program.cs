//By Pritish Bhatnagar

namespace FoodieCorner.ConsoleApp
{


    public class calc
    {

        int a, b;

        public void add(int a, int b)
        {
            int add = a + b;
            Console.WriteLine("addition is : " + add);
        }
        public void sub(int a, int b)
        {

            int sub = a - b;
            Console.WriteLine("Subtraction is : " + sub);
        }
        public void mul(int a, int b)
        {

            int mul = a * b;
            Console.WriteLine("multiplication is : " + mul);
        }
        public void div(decimal a, decimal b)
        {

            decimal div = a / b;
            Console.WriteLine("division is : " + div);
        }







    }

    public class student
    {
        public string name;
        public int id, age, clas;
        public student(string name, int age, int clas, int id)
        {
            this.name = name;
            this.age = age;
            this.clas = clas;
            this.id = id;
            Console.WriteLine("New student has been admitted to the school");


        }




    }
    public class teacher
    {
        public string name, desig;
        public int id, age;
        public teacher(string name, int age, string desig, int id)
        {
            this.name = name;
            this.age = age;
            this.desig = desig;
            this.id = id;
            Console.WriteLine("New object of teacher class has been created!!");


        }




    }









    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the class you want to access");
            Console.WriteLine("\n 1 for accessing Calculator \n 2 for Student \n 3 for Teacher");
            try
            {
                int sw = Convert.ToInt32(Console.ReadLine());
                if (sw == 1 || sw == 2 || sw == 3)
                {
                    switch (sw)
                    {
                        case 1:
                            int a, b;
                            int num = 1;

                            Console.WriteLine("1 for Add \n 2 for subtraction \n 3 for multiplication \n 4 for Division");
                            calc calculator = new calc();
                            do
                            {
                                var q = Console.ReadLine();

                                try
                                {
                                    int ch = Convert.ToInt32(q);



                                    if (ch == 1 || ch == 2 || ch == 3 || ch == 4)
                                    {
                                        switch (ch)
                                        {

                                            case 1:
                                                Console.WriteLine("Enter Number 1");
                                                a = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine(" \n Enter Number 2");
                                                b = Convert.ToInt32(Console.ReadLine());
                                                calculator.add(a, b);
                                                num = 0;
                                                break;

                                            case 2:
                                                Console.WriteLine("Enter Number 1");
                                                a = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine(" \n Enter Number 2");
                                                b = Convert.ToInt32(Console.ReadLine());
                                                calculator.sub(a, b);
                                                num = 0;
                                                break;

                                            case 3:
                                                Console.WriteLine("Enter Number 1");
                                                a = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine(" \n Enter Number 2");
                                                b = Convert.ToInt32(Console.ReadLine());
                                                calculator.mul(a, b);
                                                num = 0;
                                                break;


                                            case 4:
                                                Console.WriteLine("Enter Number 1");
                                                a = Convert.ToInt32(Console.ReadLine());
                                                Console.WriteLine(" \n Enter Number 2");
                                                b = Convert.ToInt32(Console.ReadLine());
                                                calculator.div(a, b);
                                                num = 0;
                                                break;

                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter a number between 1-4");
                                        num++;
                                    }
                                }

                                catch (Exception)
                                {
                                    Console.WriteLine(" \n Please Enter A Number not a string ");
                                    num++;

                                }
                            } while (num > 1);

                            Console.WriteLine(num);
                            break;
                        case 2:

                            Console.WriteLine("Enter Student name");
                            string na = Console.ReadLine();
                            Console.WriteLine("Enter his age");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter his class");
                            int clas = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("His I.D has been created");
                            Random rnd = new Random();
                            int id = Convert.ToInt32(rnd.Next());

                            student s1 = new student(na, age, clas, id);
                            Console.WriteLine("His I.D ->" + s1.id);
                            Console.WriteLine(" wanna see details? press y for yes, n for exit. ");
                            string see = Console.ReadLine();
                            if (see == "y")
                            {
                                Console.WriteLine(" I.D ->" + s1.id);
                                Console.WriteLine(" NAME ->" + s1.name);
                                Console.WriteLine(" AGE ->" + s1.age);
                                Console.WriteLine(" CLASS ->" + s1.clas);
                            }
                            else
                            {
                                break;
                            }
                            break;

                        case 3:

                            Console.WriteLine("Enter Teacher's name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the age");
                            int age1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter his/her designation");
                            string desig = Console.ReadLine();
                            Console.WriteLine("Employee's I.D has been created");
                            Random rnd1 = new Random();
                            int id1 = Convert.ToInt32(rnd1.Next());

                            teacher t1 = new teacher(name, age1, desig, id1);
                            Console.WriteLine(" I.D ->" + t1.id);
                            Console.WriteLine(" wanna see details? press y for yes, n for exit. ");
                            string se = Console.ReadLine();
                            if (se == "y")
                            {
                                Console.WriteLine(" I.D ->" + t1.id);
                                Console.WriteLine(" NAME ->" + t1.name);
                                Console.WriteLine(" AGE ->" + t1.age);
                                Console.WriteLine(" DESIGNATION ->" + t1.desig);
                            }
                            else
                            {
                                break;
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(" PLEASE ENTER NUMBER BETWEEN 1-3");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please DO NOT ENTER A STRING");


            }











        }
    }
}
