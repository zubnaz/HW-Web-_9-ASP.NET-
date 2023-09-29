﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kursova.Data.Entitys
{
    public class Auto
    {
        public int Id { get; set; }
        [Required]
        public string? Mark { get; set; }
        [Required]
        public string Model { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public string Image { get; set; }
        public int ColorId { get; set; }

        public Color? Color { get; set; }
         public Auto()
        {

        }
        public Auto(int _id, string _mark, string _model, double _price, int _year,string _image,int _idColor)
        {
            Id = _id;
            Mark = _mark;
            Model = _model;
            Price = _price;
            Year = _year;
            Image = _image;
            ColorId = _idColor;         
        }
       
    }
}
