using System;

namespace _c__{
    class Pages : Book{
        public Pages(string name, string author, float pages, int sno):base(name, pages, author, sno){
            this.name = name;
            this.author = author;
            this.pages = pages;
            this.sno = sno;
        }
    }
}