namespace ConsoleApp1
{
    public class Staffs : People
    {
        public override string Role
        {
            get { return "Staff"; }
        }

        public override double Coefficients
        {
            get { return 2.2D; }
        }
    }
}