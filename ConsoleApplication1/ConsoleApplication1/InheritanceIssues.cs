using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class InheritanceIssues
    {
    }

    abstract class BaseShape
    {
        public virtual void virtBase() { }
    }

    /// <summary>
    /// Inheritance issues
    /// </summary>
    abstract class Shape : BaseShape
    {
        // REMEMBER: Only VIRUTAL, ABSTRACT or OVERRIDE methods can be overridden
        public abstract double area();
        // Methods are implicitly sealed, 
        // but you can use sealed modifier if method was previously virtual
        // if method
        public virtual void virtMethod() { }
        // to stop possibility of further overriding virtBase() use this definition
        // this is equivalent of FINAL IN JAVA
        public override sealed void virtBase() { }

        public string someField = "abc";
        public readonly string someFieldFinal = "abc";
    }

    class Rectangle : Shape
    {
        // this 'hides' field from Shape class
        public new string someField = "efg";

        public Rectangle(double theBase, double height)
        {
            this.theBase = theBase;
            this.height = height;
            someField = "efg"; //ok
            //someFieldFinal = "efg"; //Compilation error
        }

        // You can't override virtBase() because it was sealed in Shape class
        // public override void virtBase() { }

        public override void virtMethod() { }

        protected double theBase { get; set; }
        protected double height { get; set; }
        // OVERRIDE
        public override double area()
        {
            return (theBase * height);
        }
        // OVERRIDE OPERATOR +
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(r1.theBase + r2.theBase, r1.height + r2.height);
        }
    }

    class Square : Rectangle
    {
        public Square(double theBase) : base(theBase, theBase)
        {

        }
    }


}
