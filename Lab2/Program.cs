using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here

        double r = 2.0;
        if (x * x + y * y == r * r && Math.Abs(x*x+y*y-r*r) <= 0.001)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (Math.Abs(x)+y <= 1 && Math.Abs(y) >= 0)
        {
            answer= true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        else
        {
            if (a > b)
            {
                answer = b;
            }
            else
            {
                answer = a;
            }

        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a > b)
        {
            answer = b;
        }
        else
        {
            answer = a;
        }
        if (answer < c)
        {
            answer = c;
        }
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double a;
        double d;
        double d2;
        a = Math.Sqrt(s);
        d = a * Math.Sqrt(2);
        d2 = 2 * Math.Sqrt(r / Math.PI);
        if (d <= d2)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        double a;
        double d2;
        a = Math.Sqrt(s);
        d2 = 2 * Math.Sqrt(r / Math.PI);
        if (d2 <= a)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        
        // code here
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        if ((Math.Abs(x)<= 1))
        {
            answer = Math.Abs(x);
        }

   
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        if ((Math.Abs(x) < 1))
        {
            answer = x*x-1;
        }
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) 
        {
            answer = 0;
        }
        if (x>-1 && x<=0)
        {
            answer = 1+ x;
        }
        if (x > 0)
        {
            answer = 1;
        }
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double r = 0;  //рост одного ученика
        double s = 0; //общий рост учениеков 
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите рост ученика {i + 1} ");
            r = Convert.ToDouble(Console.ReadLine());
            s += r;
        }
        answer = s / n;
        Console.WriteLine(answer);
       
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите координату х {i + 1} точки");
            x = double.Parse(Console.ReadLine());
            Console.Write($"Введите координату y {i + 1} точки");
            y = double.Parse(Console.ReadLine());

            if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r) 
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double wes = 0; //вес 1 ученика
        double milk = 0; 

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите вес ученика {i + 1} ");
            wes = double.Parse(Console.ReadLine());

            if (wes < 30)
            {
                milk += 200;
            } 
        }
        answer = milk / 1000;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;
       
        // code here
        double x, y, x0, y0;
        Console.WriteLine("Введите значение х0");
        x0 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение у0");
        y0 = Double.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите значение х");
            x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение у");
            y = Double.Parse(Console.ReadLine());
            if ((x - x0) + (y - y0) > r1 * r1 && (x - x0) + (y - y0) < r2 * r2)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double rezultat = 0;
        // code here
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите результат участника {i + 1} ");
            rezultat = double.Parse(Console.ReadLine());
            if (rezultat <= norm)
            {
                answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Введите координату х {i + 1} точки");
            x = Double.Parse(Console.ReadLine());
            Console.Write($"Введите координату y {i + 1} точки");
            y = Double.Parse(Console.ReadLine());
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
            {
                answer++;
            }
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Введите координату х {i + 1} точки");
            x = Double.Parse(Console.ReadLine());
            Console.Write($"Введите координату y {i + 1} точки");
            y = Double.Parse(Console.ReadLine());
            if (x > 0 & y > 0)
            {
                answer1++;
                Console.WriteLine(1);
            }
            if (x < 0 && y < 0)
            {
                answer3++;
                Console.WriteLine(3);
            }
            if (x < 0 && y > 0)
            {
                
                Console.WriteLine(2);
            }
            if (x > 0 && y < 0)
            {
               
                Console.WriteLine(4);
            }
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        double x, y;
        int r = 0;
        for (int i = 0; i <= n; i++)
        {
            Console.Write($"Введите координату х {i + 1} точки");
            x = Double.Parse(Console.ReadLine());
            Console.Write($"Введите координату y {i + 1} точки");
            y = Double.Parse(Console.ReadLine());
            r += 1;
            if (Math.Sqrt(x * x + y * y) < answerLength)
            {
                answerLength += (Math.Sqrt(x * x + y * y));
                answer = r;    
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double rez = 0; //рез 1 человека
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите результат спортсмена {i + 1}");
            rez = double.Parse(Console.ReadLine());

            if (rez < answer)
            {
                answer = rez;
                
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double exz1 = 0;
        double exz2 = 0;
        double exz3 = 0;
        double exz4 = 0;
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введиете оценку ученика {i+1} за 1 экзамен");
            exz1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введиете оценку ученика {i + 1} за 2 экзамен");
            exz2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введиете оценку ученика {i + 1} за 3 экзамен");
            exz3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введиете оценку ученика {i + 1} за 4 экзамен");
            exz4 = double.Parse(Console.ReadLine());
            if ((exz1 != 2 && exz1 != 3) && (exz2 != 2 && exz2 != 3) && (exz3 != 2 && exz3 != 3) && (exz4 != 2 && exz4 != 3))
            {
                answer += 1;
            
            }
        }
   
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        
        double s = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введиете оценку ученика {i + 1} за 1 экзамен");
            double exz1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введиете оценку ученика {i + 1} за 2 экзамен");
            double exz2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введиете оценку ученика {i + 1} за 3 экзамен");
            double exz3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введиете оценку ученика {i + 1} за 4 экзамен");
            double exz4 = double.Parse(Console.ReadLine());
            s = s + exz1 + exz2 + exz3 + exz4;
            if ((exz1 == 2) || (exz2 == 2) || (exz3 == 2) || (exz4 == 2))
            {
                answer += 1;
            }
        }
        avg = s / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r > 0)
        {
            switch (type)
            {
                case 0: answer = r*r ; 
                    break;
                 case 1: answer = r*r* Math.PI ;
                    break;
                case 2: answer = r * r * Math.Sqrt(3) / 4;
                    break;

            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        double p = (A + B + B) / 2;
        if (A > 0 && B > 0)
        {

            switch (type)
            {
                case 0:
                    answer = A * B;
                    break;
                case 1:
                    answer = Math.PI * (B * B - A * A);
                    break;
                case 2:
                    answer = Math.Sqrt(p * (p - A) * (p - B) * (p - B));
                    break;

            }
        }
        answer = Math.Round(answer, 2);
        answer = Math.Abs(answer);
        
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here
        double x, y;
        string x1 = "1";
        while (x1 != "break")
        {
            x1 = Console.ReadLine();
            if (x1 != "break")
            {
                y = double.Parse(Console.ReadLine());
                x = double.Parse(x1);
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                {
                    answer++;
                }
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;
        string rezultat1 = "0";
        double rezultat;
        // code here
        while (rezultat1!="break")
        {
            rezultat1 = (Console.ReadLine());
            if (rezultat1 != "break")
            {
                rezultat = Double.Parse(rezultat1);
                if (rezultat <= norm)
                {
                    answer++;
                }
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here
        double x;
        double y;
        int r = 0;
        string x1 = "1";
        while (x1 != "break")
        {
            x1 = Console.ReadLine();
            if (x1 != "break")
            {
                y = double.Parse(Console.ReadLine());
                x = double.Parse(x1);
                r += 1;
                if (Math.Sqrt(x * x + y * y) < answerLength)
                {
                    answerLength += (Math.Sqrt(x * x + y * y));
                    answer = r;

                }
            }
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;
        double exz1, exz2, exz3 ,exz4;
        double s = 0;
        string exz1_1 = "0";
        while (exz1_1 != "break")
        {
            exz1_1 = Console.ReadLine();
            if (exz1_1 != "break")
            {
                Console.WriteLine($"Введиете оценку ученика за 1 экзамен");
                exz1 = double.Parse(exz1_1);
                Console.WriteLine($"Введиете оценку ученика за 2 экзамен");
                exz2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Введиете оценку ученика за 3 экзамен");
                exz3 = double.Parse(Console.ReadLine());
                Console.WriteLine($"Введиете оценку ученика за 4 экзамен");
                exz4 = double.Parse(Console.ReadLine());
                s = s + exz1 + exz2 + exz3 + exz4;
                if ((exz1 == 2) || (exz2 == 2) || (exz3 == 2) || (exz4 == 2))
                {
                    answer += 1;
                }
            }
        }
        avg = s / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);

        // end
        return (answer, avg);
    }
        

    
    #endregion
}
