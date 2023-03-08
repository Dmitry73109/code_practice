using System;

namespace Program19
{
    public class Square
    {
        public int x = 0;
        public int y = 0;
        public int length = 1;
        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(int x, int y)//Move the square by the value you specify. For example: start position is x = 5 and y = 10. Use "Move(-2,4)", position of square is x = 3 and y = 14
        {
            this.x = this.x + x;
            this.y = this.y + y;
        }
        public void Scale(int scale)
        {
            this.length = this.length * 2;
        }
        public string ToString()
        {
            return ("Corner(" + this.x + "," + this.y + "), side " + this.length);
        }
        public int GetArea()
        {
            return (this.length * this.length);
        }
        public int GetPerimeter()
        {
            return (this.length * 4);
        }
    }
    public class Square1 : Square
    {
        public Square1()
        {
            SetPosition(5,5);
            Move(-1,2);
            Scale(2);
            Console.WriteLine(ToString());
            Console.WriteLine(GetArea());
            Console.WriteLine(GetPerimeter());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Square1();
        }
    }
}
