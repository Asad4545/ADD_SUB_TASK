using System;


namespace ADD_SUB_OVERLOADING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for ADDITION: ");
            Console.WriteLine("Press 2 for SUBTRACTION: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            

            ADD obj = new ADD();
            SUB obj1 = new SUB();
            switch (choice)
            {
                case 0:
                    Console.WriteLine("You Enter Wrong Choice: ");
                    break;
                case 1:
                    Console.WriteLine("How many value you want to add? ");
                    int a = Convert.ToInt32( Console.ReadLine());
                    
                    if(a ==2)
                    {
                        Console.WriteLine("Enter value: ");
                        float x = Convert.ToSingle( Console.ReadLine());

                        Console.WriteLine("Enter second value: ");
                        float y = Convert.ToSingle(Console.ReadLine());

                        obj.add(x, y);

                    }
                    else if(a == 3)
                    {
                        Console.WriteLine("Enter value: ");
                        float x = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter second value: ");
                        float y = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter third value: ");
                        float f = Convert.ToSingle(Console.ReadLine());

                        obj.add(x, y, f);
                    }
                    else if(a == 4)
                    {
                        Console.WriteLine("Enter value: ");
                        float x = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter second value: ");
                        float y = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter third value: ");
                        float f = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter third value: ");
                        float f1 = Convert.ToSingle(Console.ReadLine());
                        obj.add(x,y,f,f1);
                    }
                    else
                    {
                        Console.WriteLine("Vlaue is greater than 4");
                    }

                    break;

                case 2:
                    Console.WriteLine("How many value you want to subtract? ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (b == 2)
                    {
                        Console.WriteLine("Enter value: ");
                        float x = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter second value: ");
                        float y = Convert.ToSingle(Console.ReadLine());

                        obj1.sub(x, y);

                    }
                    else if (b == 3)
                    {
                        Console.WriteLine("Enter value: ");
                        float x = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter second value: ");
                        float y = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter third value: ");
                        float f = Convert.ToSingle(Console.ReadLine());

                        obj1.sub(x, y, f);
                    }
                    else if (b == 4)
                    {
                        Console.WriteLine("Enter value: ");
                        float x = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter second value: ");
                        float y = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter third value: ");
                        float f = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter third value: ");
                        float f1 = Convert.ToSingle(Console.ReadLine());
                        obj1.sub(x, y, f, f1);
                    }
                    else
                    {
                        Console.WriteLine("Vlaue is greater than 4");
                    }

                    break;
            }
            
        }
    }
}
