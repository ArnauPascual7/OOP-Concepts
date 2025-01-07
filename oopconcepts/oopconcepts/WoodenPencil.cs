using System;
namespace oopconcepts
{
    public class WoodenPencil : Pencil
    {
        private string color;

        public string GetColor() { return this.color; }

        public void SetColor(string color) { this.color = color; }

        public WoodenPencil(string hardness, string brand, string color) : base(hardness, brand)
        {
            this.SetColor(color);
        }
    }
}