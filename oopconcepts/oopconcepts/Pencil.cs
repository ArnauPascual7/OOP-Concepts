﻿using System;
namespace oopconcepts
{
    public class Pencil
    {
        private string hardness;
        private string brand;

        public string GetHardness() { return this.hardness; }
        public string GetBrand() { return this.brand; }

        public void SetHardness(string hardness) { this.hardness = hardness; }
        public void SetBrand(string brand) { this.brand = brand; }

        public Pencil(string hardness, string brand)
        {
            this.SetHardness(hardness);
            this.SetBrand(brand);
        }

        public void Write()
        {
            Console.WriteLine("The pencil is writing");
        }

        public void Write(string surface)
        {
            Console.WriteLine($"The pencil is writing on {surface}");
        }
    }
}