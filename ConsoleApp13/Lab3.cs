using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Point 
    {
        public double x, y;
public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
  public void WritePoint()
        {
            Console.WriteLine("(" + x + ";" + y + ")");
        }
    }

    public class Triangle
    {
        public Point A { set; get; }
        public Point B { set; get; }
        public Point C{set; get;}

        public Triangle(Point Aa, Point Bb, Point Cc)
        {
            A = Aa;
            B = Bb;
            C = Cc;
        }
        public void ShowTriangle()
        {
            A.WritePoint();
            B.WritePoint();
            C.WritePoint();
        }
        public void MoveRight(double v)
        {
            A.x -= v;
            B.x -= v;
            C.x -= v;
        }
        public void MoveLeft(double v)
        {
            A.x -= v;
            B.x -= v;
            C.x -= v;
        }
        public void MoveUp(double v)
        {
            A.y += v;
            B.y += v;
            C.y += v;
        }
        public void MoveDown(double v)
        {
            A.y -= v;
            B.y -= v;
            C.y -= v;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите координату X первой точки");
                double X1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ее координату Y");
                double Y1 = double.Parse(Console.ReadLine());
                Point Pervaya = new Point(X1, Y1);
                Console.WriteLine("Введите координату X второй точки");
                double X2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ее координату Y");
                double Y2 = double.Parse(Console.ReadLine());
                Point Vtoraya = new Point(X2, Y2);
                Console.WriteLine("Введите координату X третьей точки");
                double X3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ее координату Y");
                double Y3 = double.Parse(Console.ReadLine());
                Point Tretya = new Point(X3, Y3);
                Triangle simple = new Triangle(Pervaya, Vtoraya, Tretya);
                try
                {
                    if ((X1 == X2) || (Y1 == Y2)) throw new Exception();
                    else if ((X1 == X3) || (Y1 == Y3)) throw new Exception();
                    else if ((X2 == X3) || (Y2 == Y3)) throw new Exception();
                    else if ((Y1 == Y2 || Y2 == Y3)) throw new Exception();
                    else if ((X1 == X2 || X2 == X3)) throw new Exception();

                    else
                    {
                        simple.ShowTriangle();
                        simple.MoveUp(5);
                        Console.WriteLine("Со сдвигом на 5 вверхз");
                        simple.ShowTriangle();
                    }
                }
                catch
                {
                    throw;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }



        }
    }
}
