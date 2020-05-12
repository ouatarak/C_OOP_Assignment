// Base on TA maretials
// https://www.quora.com/What-are-the-different-types-of-art

using System;

namespace Art
{
    // Abstraction on class Type
    abstract class Type
    {
        public string typeName = "Painting";
        public void displayType()
        {
            Console.WriteLine("This Art is Painting type");
        }

        public virtual void type()
        {
            Console.WriteLine("This painting is Drawings");
        }

        
        public virtual void Tools()
        {
            Console.WriteLine("Painting Tools");
        }

    }

    // Inheritance and Enscapulation
    class Painting : Type
    {
        private string name;
        private string artist;
        private string medium;
        private string year;

        public string name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }

        public string artist
        {
            get
            {
                return artist;
            }

            set
            {
                artist = value;
            }

        }

        public string medium
        {
            get
            {
                return medium;
            }

            set
            {
                medium = value;
            }

        }

        public string year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }

        }

    }

    // Polymorphism
    class Painting
    {
        public virtual void type()
        {
            Console.WriteLine("[Insert Printing Type]");
        }
    }

    class Sculpture : Painting
    {
        public override void type()
        {
            Console.WriteLine("This is Sculpture Painting type");
        }
    }

    class Drawings : Painting
    {
        public override void type()
        {
            Console.WriteLine("This is Drawings Painting type");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Painting myPainting = new Painting();
            Painting mySculpture = new Sculpture();
            Painting Drawings = new Drawings();

            myPainting.type();
            mymySculpture.type();
            myDrawings.type();
        }
    }
}