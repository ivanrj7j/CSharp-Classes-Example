using System;

namespace _c__{
    class Book{

        public string name;
        // name of the book 
        public float pages;
        // number of pages in the book 
        public string author;
        // name of the author 
        public int sno;
        // serial number of the book 
        public Book(string name, float pages, string author, int sno){
            this.name = name;
            this.pages = pages;
            this.author = author;
            this.sno = sno;
            // assigining the values to the variable 
        }

        public bool isTheBest(){
            if(this.name.ToLower() == "shingeki no kyojin" 
            || this.name.ToLower() == "attack on titan"){
                return true;
            }
            else{
                return false;
            }
        }

        public string explaination(){
            string isBestText;
            if(this.isTheBest()){
                isBestText = "is";
            }else{
                isBestText = "is not";
            }
            string explaination = "The name of the book is " + this.name + " written by " + this.author + ". This book has a total of " + this.pages + " pages, and labelled by the number " + this.sno + " and this " + isBestText + " the best book in the world";
            return explaination;
        }
    }
}