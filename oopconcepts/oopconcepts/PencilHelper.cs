using System;
namespace oopconcepts
{
    public class PencilHelper
    {
        public static string GetPencilType(Pencil pencil)
        {
            if (pencil is WoodenPencil)
            {
                return "Wooden Pencil";
            }
            else if (pencil is MechanicalPencil)
            {
                return "Mechanical Pencil";
            }
            else
            {
                return "Regular Pencil";
            }
        }
        public static bool TimeChangePencil(Pencil pencil, int uses)
        {
            if (pencil is WoodenPencil && uses > 200)
            {
                return true;
            }
            else if (pencil is MechanicalPencil && uses > 250)
            {
                return true;
            }
            return false;
        }
    }
}
