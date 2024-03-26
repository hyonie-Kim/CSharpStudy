using System.Diagnostics;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input 변수 생성 - 문자열 자료형
            string input;

            // 출력하는 방법
            Console.Write("안녕하세요.");
            Console.Write("C# 공부중");
            // 마지막에 엔터가 출력됨
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");

            // 사용자 입력 값을 받음
            // 입력한 값이 그대로 들어옴
            // 입력이 된 문자열로 바뀜
            input = Console.ReadLine();

            // 입력 받은 문자열 출력
            Console.WriteLine("입력 받은 문자열: " + input);



        }
    }
}
