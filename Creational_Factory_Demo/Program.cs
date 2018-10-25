using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Factory_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Blog and publish.
            var blog = new Blog();
            blog.Publish();


            // Create a Newspaper and publish.
            var newspaper = new Newspaper();
            newspaper.Publish();
        }
    }

    interface IAuthor
    {
        void Write();
    }

    class FictionAuthor : IAuthor
    {
        public void Write()
        {
            Console.WriteLine($"I'm an {this.ToString()} and I write fiction!");
        }
    }

    class NonfictionAuthor : IAuthor
    {
        public void Write()
        {
            Console.WriteLine($"I'm an {this.ToString()} and I write nonfiction!");
        }
    }

    abstract class Publisher
    {
        abstract public IAuthor HireAuthor();

        public void Publish()
        {
            IAuthor author = HireAuthor();
            author.Write();
        }
    }

    class Blog : Publisher
    {
        public override IAuthor HireAuthor()
        {
            return new FictionAuthor();
        }
    }

    class Newspaper : Publisher
    {
        public override IAuthor HireAuthor()
        {
            return new NonfictionAuthor();
        }
    }
}

