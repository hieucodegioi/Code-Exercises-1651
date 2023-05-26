﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    internal class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price * 1.3m)
        {
        }

       

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
