﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_bobs_bagels.CSharp.Main;
using tdd_oop_bobs_bagels.CSharp.Main.Products;

namespace Users
{
    public class Customer : Userr
    {
        public string name { get; set; }

        public List<Items> items { get; set; }

        public Customer(string Name)
        {
            name = Name;
            items = new List<Items>();
        }
    }
}
