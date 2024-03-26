using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{   
    // 1. 부모 클래스 정의
    internal class Overriding
    {
        public class Parent
        {
            
            // 2. 메서드 정의
            
            public void print()
            {
                Console.WriteLine("부모 클래스 메서드");
            }

        }

        // 3. 상속 받는 자식 클래스 정의
        public class Child : Parent 
        { 
            // 부모클래스 메서드 재정의 :: 오버라이딩
            public void print()
            {
                Console.WriteLine("자식 클래스 메서드");

            }
        }
        static void Main(string[] args)
        {
            // 부모 클래스 객체
            Parent parent = new Parent();
            // 자식 클래스 객체
            Child child = new Child();


            parent.print();
            // 부모클래스 메서드 상속
            child.print();
        }
    }
}


// 오버라이딩: 부모 클래스에서 정의된 메서드를 자식 클래스에서 재정의