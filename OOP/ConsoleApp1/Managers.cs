namespace ConsoleApp1
{
    public class Managers : People
    {
        public override string Role
        {
            get { return "Manager"; }
        }

        public override double Coefficients
        {
            get { return 4.6D; }
        }
    }
}