using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Overloading
    {
        // 클래스 생성
        public class Overload
        {

            // 오버로딩 메서드
            public void print()
            {
                Console.WriteLine("오버로딩 메서드");
            }
        }

        static void Main(string[] args)
        {
            Overload overload = new Overload();
            overload.print();
        }
    }
}


// 다형성
// 하나의 코드가 여러가지 형태로 실행되는 것

// 오버로딩 & 오버라이딩
// 오버로딩- 같은 이름의 메서드를 여러 개 정의
