using System;
namespace ArbolB.Models
{
    public class Farmaco
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Merch { get; set; }
        public double Price { get; set; }
        public int Existence { get; set; }
        public Farmaco()
        {
        }
    
    }
}
