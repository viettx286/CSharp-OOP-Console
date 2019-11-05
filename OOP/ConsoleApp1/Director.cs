namespace ConsoleApp1
{
    public class Director : People
    {
        public override string Role
        {
            get { return "Diretor"; }
        }

        public override double Coefficients
        {
            get { return 12.5D; }
        }
    }
}