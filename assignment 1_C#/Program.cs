using System;

namespace YourNamespace
{

    //class Person
    //{
    //    public string Name;
    //}
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("enter number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"number: {number}");

            #endregion
            #region Q2
            //string name = "adcdf222";
            //int result =int.Parse(name);
            //Console.WriteLine(result);
            // has error beca the string contain letter and parse is repesentaion number into numeric type

            #endregion
            #region Q3
            //float x = 3.5f;
            //float y = 3.1f;

            //Console.WriteLine($"result:{x+y}");
            #endregion
            #region Q4
            //string name = "halloworld";
            //Console.WriteLine("Substring: " + name.Substring(1,2));
            #endregion
            #region Q5
            //int x = 5;
            //int y = x;
            //Console.WriteLine(y);
            //y = 10;
            //Console.WriteLine(y);
            ////he take value 5 to y and them=n change it to 10
            #endregion
            #region Q6
            //Person p1 = new Person();
            //p1.Name = "youssef";
            //Person p2 = new Person();
            //p2 = p1;
            //p2.Name = "ahmed";
            //Console.WriteLine($"Name: {p1.Name} " ); 
            //both have seve values(object)
            #endregion
            #region Q7
            //string f_name = "Youssef";
            //string l_name = "Ahmed";
            //string result = f_name + l_name;
            //Console.WriteLine( result);
            #endregion
            #region Q8
            //double principal_amount = 100;
            //int rate = 10;
            //int time = 5;
            //double interest = (principal_amount*rate*time) / 100;
            //Console.WriteLine("simple interest : " + interest);
            #endregion
            #region Q9
            //double weight = 100;
            //float height = 1.66f;
            //double BMI =(weight)/(height*height);
            //Console.WriteLine("BMI: " + BMI);
            #endregion
            #region Q10
            //int t = 33;
            //string result = t < 10 ?"Just Cold": 
            //                t > 30 ?"Just Hot":"Just Good";
            //Console.WriteLine("Temperature: " + result);
            #endregion
            #region Q11
            //Console.Write("Enter day: ");
            //int day = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter year: ");
            //int year = int.Parse(Console.ReadLine());
            //Console.Write("Enter month: ");
            //int month = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Today'sdate :{day},{month},{year}");
            //Console.WriteLine($"Today'sdate :{day}/{month}/{year}");
            //Console.WriteLine($"Today'sdate :{day}–{month}–{year}");
            #endregion
            #region Q12
            //Console.Write("number: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n%3==0 && n%4==0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion
            #region Q13
            //Console.Write("Enter number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positive");
            #endregion
            #region Q14
            //Console.Write("Enter number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number: ");
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //int max = Math.Max(n1, Math.Max(n2, n3));
            //int min = Math.Min(n1, Math.Min(n2, n3));

            //Console.WriteLine("Max="+max);
            //Console.WriteLine("Min=" +min);

            #endregion
            #region Q15
            //Console.Write("Enter integer: ");
            //int.TryParse(Console.ReadLine(),out int n);
            //if (n % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");
            #endregion
            #region Q16
            //vowel
            //Console.Write("Enter character: ");
            //string c = (Console.ReadLine());
            //switch (c) { 
            //   case "a":
            //        Console.WriteLine("vowel");
            //        break;
            //   case "e":
            //        Console.WriteLine("vowel");
            //        break;
            //   case "I":
            //        Console.WriteLine("vowel");
            //        break;
            //   case "o":
            //        Console.WriteLine("vowel");
            //        break;
            //   case "u":
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;

            //}
            #endregion
            #region Q17
            //Console.Write("month number : ");
            //int m = int.Parse(Console.ReadLine());
            //if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            //    Console.WriteLine("daye:31");
            //if (m == 4 || m == 6 || m == 9 || m == 11)
            //    Console.WriteLine("daye:30");
            //else if (m == 2)
            //    Console.WriteLine("daye:28");
            //else
            //    Console.WriteLine("Invalid month number.");
            #endregion

        }
    }
}

