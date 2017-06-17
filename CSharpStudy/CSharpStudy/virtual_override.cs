using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Parent
    {
        public virtual void A()
        {
            Console.WriteLine("부모 클래스의 A() 메소드 호출!");
        }
    }
    class Child : Parent
    {
        public override void A()
        {
            Console.WriteLine("자식 클래스(Child)의 A() 메소드 호출!");
        }
    }
    class Daughter : Parent
    {
        public override void A()
        {
            Console.WriteLine("자식 클래스(Daughter)의 A() 메소드 호출!");
        }
    }
    class virtual_override
    {
        public static void main(string[] args)
        {
            public static void Main(string[] args)
            {
                Parent parent = new Parent();
                parent.A();

                Child child = new Child();
                child.A();

                Daughter daughter = new Daughter();
                daughter.A();
            }
        }
    }
}