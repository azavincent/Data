﻿// LINQ Any 확장 메서드: 컬렉션(시퀀스)에 요소가 하나라도 있는지 확인
using System.Linq;

class LINQ_Any
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3 };
        bool bln = arr.Any(num => num == 2); // bool 값 반환
        if (bln)
        {
            System.Console.WriteLine("시퀀스에 조건에 맞는 요소가 있다.");
        }
    }
}