﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity=varlık
    {
        //bu tip classlarda sadece özellik olur
        //Crud create update delete
        //entity = varlık sınıfıdır burası
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
