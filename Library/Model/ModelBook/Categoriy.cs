﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Categoriy
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string GetDataCategory()
        {
            return $"Id:{Id}  Name:{Name}\n";
        }
    }
}
