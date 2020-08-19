using System;

namespace MyStringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString mstr = new MyString('z','b',' ');
            mstr.AppendAtStart('3');
            mstr.AppendAtStart('1','2');
            mstr.AppendAtEnd('1', '2');
            mstr.AppendAtEnd('3');
            mstr.AppendAtEnd(' ');
            mstr = new MyString(Console.ReadLine().ToCharArray()); 
            Console.WriteLine(mstr.CharArray);
            //Console.WriteLine(mstr.SubString(3,2));
            Console.WriteLine(mstr.CountSentences());

        }


    }
}
