namespace CSharp_Training_04
{
    public class Rectangle
    {
        private double length;// { get { return length; } set { length = value; } }
        private double width; //{ get { return width; } set { length = value; } }

        public Rectangle(double l, double w)
        {
            width = w;
            length = l;
        }

        public double Area()
        {
            return length * width;
        }

        public void DisplayRectangleData()
        {
            Console.WriteLine("Length:" + length + ",width=" + width + ",area=" + Area());
        }
    }

    public class Tabletop : Rectangle
    {
        public Tabletop(double l, double w) : base(l, w)
        {
        }

        public double computeCost()
        {
            return base.Area() * 5.0;
        }

        public void getTableData()
        {
            Console.WriteLine("Table: area={0}, cost={1}", base.Area(), computeCost());
        }
    }
}
