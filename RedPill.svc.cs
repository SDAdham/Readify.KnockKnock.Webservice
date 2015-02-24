using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Readify.KnockKnock.Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {
        public Guid WhatIsYourToken()
        {
            //f51694d1-5f70-4f0f-9ec5-568ea0595f22
            //return new Guid("4659f88c-909b-4067-b35e-fd27865d5531");
            return new Guid("f51694d1-5f70-4f0f-9ec5-568ea0595f22");
        }

        public long FibonacciNumber(long n)
        {
            if (n > 92)
                throw new Exception("Fib(>92) will cause a 64-bit integer overflow");
            long a = 0;
            long b = 1;
            for (long i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        private string ReverseWord(string s)
        {
            char[] result = new char[s.Length];
            Parallel.For(0, s.Length, i => { result[s.Length - 1 - i] = s[i]; });
            return new string(result);
        }

        public string ReverseWords(string s)
        {
            string[] result = s.Split(' ');
            Parallel.For(0, result.Length, i => { result[i] = ReverseWord(result[i]); });
            return string.Join(" ", result);
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if ((a + b > c && a + c > b && b + c > a))
            {
                if (a == b && b == c)
                    return TriangleType.Equilateral;
                else if (a == b || b == c || a == c)
                    return TriangleType.Isosceles;
                else if (a != b && a != c && b != c)
                    return TriangleType.Scalene;
            }

            return TriangleType.Error;
        }
    }
}
