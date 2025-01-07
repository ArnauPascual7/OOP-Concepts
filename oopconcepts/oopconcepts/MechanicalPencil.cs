using System;
namespace oopconcepts
{
    public class MechanicalPencil : Pencil
    {
        private string rubberHardness;

        public string GetRubberHardness() { return this.rubberHardness; }

        public void SetRubberHardness(string rubberHardness) { this.rubberHardness = rubberHardness; }

        public MechanicalPencil(string hardness, string brand, string rubberHardness) : base(hardness, brand)
        {
            this.SetRubberHardness(rubberHardness);
        }
    }
}