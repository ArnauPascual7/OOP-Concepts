using System;
namespace oopconcepts
{
    public class MechanicalPencil : Pencil
    {
        private string rubberHardness;

        public string GetRubberHardness() { return this.rubberHardness; }

        public void SetRubberHardness(string rubberHardness) { this.rubberHardness = rubberHardness; }

        public MechanicalPencil(string hardness, string brand, string rubberHardness) : base (hardness, brand)
        {
            this.SetRubberHardness(rubberHardness);
        }

        public override void Write()
        {
            Console.WriteLine("The mechanical pencil is writing");
        }

        public override void Write(string surface)
        {
            Console.WriteLine($"The mechanical pencil is writing on {surface}");
        }
    }
}
