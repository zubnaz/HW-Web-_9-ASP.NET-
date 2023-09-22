using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursova.Data.Entitys
{
    public class Auto
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public int ColorId { get; set; }

        public Color? Color { get; set; }
         public Auto()
        {

        }
        public Auto(int _id, string _mark, string _model, double _price, int _year,int _idColor)
        {
            Id = _id;
            Mark = _mark;
            Model = _model;
            Price = _price;
            Year = _year;
            ColorId = _idColor;         
        }
     
    }
}
