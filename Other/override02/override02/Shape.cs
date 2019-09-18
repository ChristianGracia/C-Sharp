namespace override02
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //public Position Position { get; set; }

        public virtual void Draw()
        {

        }

    }
    public class Circle : Shape
    {
        


    }

    public class Rectangle : Shape
    {

    }
}