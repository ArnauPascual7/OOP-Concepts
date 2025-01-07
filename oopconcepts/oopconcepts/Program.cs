namespace oopconcepts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pencil myPencil = new Pencil("HB", "BIC");
            WoodenPencil myWoodPencil = new WoodenPencil("HB", "BIC", "yellow");
            MechanicalPencil myMechPencil = new MechanicalPencil("HB", "BIC", "A");

            myPencil.Write();
            myPencil.Write("table");

            myWoodPencil.Write();
            myWoodPencil.Write("cardboard");

            myMechPencil.Write();
            myMechPencil.Write("paper");
        }
    }
}
