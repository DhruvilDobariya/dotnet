namespace InheritanceDemo
{
    public class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }

        public int width;
        public int height;
    }

    // Derived class
    public class Rectangle : Shape
    {
        public int GetArea()
        {
            return (width * height);
        }
    }
    public class InheritanceDemo
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.SetWidth(5);
            rectangle.SetHeight(7);

            Console.WriteLine($"The area is : {rectangle.GetArea}");
        }
    }
}
