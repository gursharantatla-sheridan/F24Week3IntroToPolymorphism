namespace F24Week3IntroToPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objBase = new BaseClass();
            objBase.Show();

            DerivedClass objDerived = new DerivedClass();
            objDerived.Show();


            objBase = new DerivedClass();
            objBase.Show();
        }
    }
}
