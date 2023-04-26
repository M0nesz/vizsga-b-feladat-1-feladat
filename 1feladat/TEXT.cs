using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1feladat
{
    class TEXT
    {
        public int id;
        public string name;
        public int price;
        public string times;
        public string nyertese;

        public TEXT(int id, string name, int price, string times, string nyertese)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.times = times;
            this.nyertese = nyertese;
        }
    }
}
