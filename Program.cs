using System;
using System.Linq;
using System.IO;
namespace WhiteBoard
{
    class Program
    {
        public string FizzBuzzNumber(int number)
        {
            //if (number % 3 == 0 && number % 5 == 0)
            //{
            //    return "fizzbuzz";
            //}
            //if (number % 3 == 0)
            //{
            //    return "fizz";
            //}
            //if (number % 5 == 0)
            //{
            //    return "buzz";
            //}
            var answer = "";
            if(number % 3 == 0)
            {
                answer = "fizz";
            }
            if(number % 5 == 0)
            {
                answer += "buzz";
            }
            return answer;
        }
    }
    
}




