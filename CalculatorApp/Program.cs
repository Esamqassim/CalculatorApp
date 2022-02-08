using System;

namespace CalculatorApp
{
    class Program
    {
        static void setNumber1(double numb1) { Cnumb1 = numb1; }
        static double getNumber1() { return Cnumb1; }
        static void setNumber2(double numb2) { Cnumb2 = numb2; }
        static double getNumber2() { return Cnumb2; }

        static double Cnumb1, Cnumb2,result;


        static void Main(string[] args)
        {
            int choosing;
            bool loop=true;

            //Console.Clear();
            //PrintMenu();
            
            //choosing = Option();

            while (loop) {

                Console.Clear();
                PrintMenu();
                choosing = Option();


                switch (choosing) {
                    case 1:
                        Askuser();
                        result = Add(getNumber1(), getNumber2());
                        Console.WriteLine("Addition of   "+ getNumber1()+ "and"+getNumber2() +" is ="+ result);                        
                        break;

                    case 2:
                        Askuser();
                        result = Sub(getNumber1(), getNumber2());
                        Console.WriteLine("Subtraction  of   " + getNumber1() + "and" + getNumber2() + " is =" + result);
                        break;

                    case 3:
                        Askuser();
                        result = Multiply(getNumber1(), getNumber2());
                        Console.WriteLine("Multiplication   of   " + getNumber1() + "and" + getNumber2() + " is =" + result);
                        break;

                    case 4:
                        Divid();
                        break;

                    case 5:
                        loop = false;
                        break;
                        
                    default:
                        Console.WriteLine("Not a valid option!");
                        break;
                        

                } //end switch

                if (choosing!=5) {
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();//WAIT UNTILL PRESS E KEY
                }
            }//end while
            
        }//end main

       static void PrintMenu() {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("Choose any of number bellow to corrspondet operation");
            Console.WriteLine("  Choose(1) : Add two numbers");
            Console.WriteLine("Choose(2) : Subtract two numbers");
            Console.WriteLine("Choose(3) : Multiply two numbers");
            Console.WriteLine("Choose(4) : Divid two numbers");
            Console.WriteLine("Choose(5) : Exit program  ");
        }//end PrintMenu

        static int Option() {

            int opt= Int32.Parse(Console.ReadLine());
            return opt;
        }//end Option

        static void Askuser() {
            Console.WriteLine("Enter First Number :");
           Cnumb1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            Cnumb2 = Convert.ToDouble(Console.ReadLine());
        }

        static double Add( double n1, double n2) {
          return  n1+n2;
        }

        static double Sub(double n1, double n2)
        {
            return n1 - n2;
        }

        static double Multiply(double n1, double n2)
        {
            return n1 *n2;
        }

        static void Divid()
        {
            

            Console.WriteLine("Enter Numerator  Number :");
            double numerator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter denominator Number :"+ "Note  that denominator should not be equal to Zero!");
            double  denominator = Convert.ToDouble(Console.ReadLine());

            if (denominator != 0) {
                result = numerator / denominator;
                Console.WriteLine("division of  "+ numerator+" by "+ denominator +" = "+ result);

            }

            else
                Console.WriteLine("You entered denominator equal to Zero,Try later ");

        }//end Divid


    }//end class
}
