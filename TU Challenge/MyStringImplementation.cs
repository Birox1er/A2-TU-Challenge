using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            bool news;
            if (input == null|| input == "")
            {
                news= true;
            }
            else
            {
                news = true;
                for(int i = 0; i < input.Length; i++)
                {
                    if(input[i]!=' ')
                    {
                        news = false;
                        break;
                    }
                }
            }
            return news;
        }

        public static string MixString(string a, string b)
        {
            string c="";
            if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
            {
                throw new ArgumentException();
            }
            int j = 0;
            for(int i = 0; i < a.Length + b.Length; i++)
            {
                if(i / 2 < a.Length && i / 2 < b.Length)
                {
                    if (i % 2 == 0)
                    {
                        c += a[j];
                    }
                    else
                    {
                        c += b[j];
                        j++;
                    }
                }
                else if (i / 2 >= b.Length)
                {
                    c += a[j];
                    j++;
                }
                else
                {
                    c += b[j];
                    j++;
                }
            }
            return c;
        }

        public static string ToLowerCase(string a)
        {
            string b = "";
            if (IsNullEmptyOrWhiteSpace(a) )
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsUpper(a[i]))
                {
                    b += Char.ToLower(a[i]);
                }
                else
                {
                    b += a[i];
                }
            }
            return b;
        }

        public static string Voyelles(string a)
        {
            string b = "";
            string newa = ToLowerCase(a);
            if (IsNullEmptyOrWhiteSpace(a))
            {
                throw new ArgumentException();
            }
            bool same=false;
            for (int i = 0; i < newa.Length; i++)
            {
                if(newa[i]=='a'|| newa[i] == 'e' || newa[i] == 'u' || newa[i] == 'i' || newa[i] == 'o' || newa[i] == 'y')
                {
                    if (b.Length > 0)
                    {
                        for(int j = 0; j < b.Length; j++)
                        {
                            if (newa[i] == b[j])
                            {
                                same= true;
                            }
                        }
                    }
                    if (!same)
                    {
                        b += newa[i];
                    }
                    same = false;
                }
            }
            return b;
        }

        public static string BazardString(string input)
        {
            string input1 = "";
            string input2 = "";
            if (IsNullEmptyOrWhiteSpace(input))
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    input1 += input[i];
                }
                else
                {
                    input2 += input[i];
                }
            }
            input1 += input2;
            return input1;
        }

        public static string UnBazardString(string input)
        {
            string input1 = "";

            if (IsNullEmptyOrWhiteSpace(input))
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < input.Length/2; i++)
            {
                input1 += input[i];
                input1 += input[i+input.Length/2];
            }
            return input1;
        }
        public static string ToCesarCode(string input, int offset)
        {
            string input1 = "";
            Dictionary<int, char> caesar = new Dictionary<int, char>();
            caesar.Add(0, 'a');
            caesar.Add(1, 'b');
            caesar.Add(2, 'c');
            caesar.Add(3, 'd');
            caesar.Add(4, 'e');
            caesar.Add(5, 'f');
            caesar.Add(6, 'g');
            caesar.Add(7, 'h');
            caesar.Add(8, 'i');
            caesar.Add(9, 'j');
            caesar.Add(10, 'k');
            caesar.Add(11, 'l');
            caesar.Add(12, 'm');
            caesar.Add(13, 'n');
            caesar.Add(14, 'o');
            caesar.Add(15, 'p');
            caesar.Add(16, 'q');
            caesar.Add(17, 'r');
            caesar.Add(18, 's');
            caesar.Add(19, 't');
            caesar.Add(20, 'u');
            caesar.Add(21, 'v');
            caesar.Add(22, 'w');
            caesar.Add(23, 'x');
            caesar.Add(24, 'y');
            caesar.Add(25, 'z');
            Dictionary<char, int> raseac = new Dictionary<char, int>();
            raseac.Add('a',0);
            raseac.Add( 'b',1);
            raseac.Add('c',2);
            raseac.Add('d',3);
            raseac.Add('e',4);
            raseac.Add('f',5);
            raseac.Add('g',6);
            raseac.Add('h',7);
            raseac.Add('i',8);
            raseac.Add('j',9);
            raseac.Add( 'k',10);
            raseac.Add('l',11);
            raseac.Add('m',12);
            raseac.Add('n',13);
            raseac.Add('o',14);
            raseac.Add('p',15);
            raseac.Add('q',16);
            raseac.Add('r',17);
            raseac.Add('s',18);
            raseac.Add( 't',19);
            raseac.Add('u',20);
            raseac.Add('v',21);
            raseac.Add('w',22);
            raseac.Add( 'x',23);
            raseac.Add('y',24);
            raseac.Add( 'z',25);
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]!=' ')
                {
                    int j=raseac.GetValueOrDefault(input[i]);
                    input1 += caesar.GetValueOrDefault((j+offset)%26);
                }
                else
                {
                    input1 += input[i];
                }
            }
            return input1;
        }

        public static string Reverse(string a)
        {
            string b = "";
            if (IsNullEmptyOrWhiteSpace(a))
            {
                throw new ArgumentException();
            }
            if (IsNullEmptyOrWhiteSpace(a))
            {
                throw new ArgumentException();
            }
            for (int i = a.Length-1; i >=0; i--)
            {
                b += a[i];
            }
            return b;
        }
    }
}
