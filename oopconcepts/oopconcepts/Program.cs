namespace oopconcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            WoodenPencil myPencil = new WoodenPencil("HB", "BIC", "blue");

            Console.WriteLine("My pencil is a " + PencilHelper.GetPencilType(myPencil));
            Console.WriteLine("It's time to change pencil? " + PencilHelper.TimeChangePencil(myPencil, 179));
        }
    }
}
