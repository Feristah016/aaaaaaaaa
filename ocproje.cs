using System;
using System.Threading;
using Microsoft.VisualBasic;

namespace asd
{
    class Program
    {
        static void Main(String[] args)
        {
			string xx = "";
			string yy = "";
			string op = "";
			long x = 2;
			long y = 2;
			bool monke = true;
			double result;
			double anaresult;
			long paydasayisi;
			long payda;
			long tur;
			while (monke)
			{
				
			
			Console.Clear();
			System.Console.Write("X [2, 50]\t: ");
			xx = Console.ReadLine();
			System.Console.Write("Y [25, 30]\t: ");
			yy = Console.ReadLine();
			System.Console.Write("Operator {*, +}\t: ");
			op = Console.ReadLine();

			if ((Information.IsNumeric(xx)) && (Information.IsNumeric(yy)) && ((op == "*") || (op == "+")))
			{
				x = Convert.ToInt64(xx);
				y = Convert.ToInt64(yy);
				if ((x>=2)&&(x<=50)&&(y>=25)&&(y<=30))
				{
					monke = false;
				}
				else
				{
					System.Console.WriteLine("\n\n");
					System.Console.WriteLine("X must be between 2 and 50\nY must be between 25 and 30");
					Thread.Sleep(400);
					System.Console.WriteLine("3\n");
					Thread.Sleep(1000);
					System.Console.WriteLine("2\n");
					Thread.Sleep(1000);
					System.Console.WriteLine("1\n");
					Thread.Sleep(1000);
				}
			}
			else
			{
				System.Console.WriteLine("\n\n");
				System.Console.WriteLine("Give valiable input.\n");
				Thread.Sleep(400);
				System.Console.WriteLine("3\n");
				Thread.Sleep(1000);
				System.Console.WriteLine("2\n");
				Thread.Sleep(1000);
				System.Console.WriteLine("1\n");
				Thread.Sleep(1000);
			}
			}

			//result = Convert.ToDouble(minn(Eval($"2*{xx}{op}5*{yy}"), faktoriyel(y)))      / 4;
			result = Convert.ToDouble(fonk(2, x, op, y, 0)) / Convert.ToDouble(4);
			anaresult = result;
			System.Console.WriteLine(result);
			
			payda = 0;
			paydasayisi = 2;
			tur = 1;
			//71
			for (long i = 5; i <= 71; i+=3)
			{

				for (long j = i-paydasayisi; j <= i+paydasayisi; j+=2)
				{
					payda += us(j, paydasayisi);
				}
				paydasayisi++;
				System.Console.Write($"\t{i}*{xx}{op}{i+3}*{yy}\t= ");
				System.Console.WriteLine(Eval($"{i}*{xx}{op}{i+3}*{yy}"));
				System.Console.WriteLine($"\ty-tur\t= {y-tur}");
				System.Console.WriteLine($"\tfaktoriyel(y-tur)\t= {faktoriyel(y-tur)}");
				System.Console.Write("\t\t\t\t\t\t\t\t\t\tmin\t= ");
				System.Console.WriteLine(minn(Eval($"{i}*{xx}{op}{i+3}*{yy}"), faktoriyel(y-tur)));
				System.Console.WriteLine($"\ttur:\t{tur}");
				System.Console.WriteLine($"\tpayda:\t{payda}");
				//result = Convert.ToDouble(minn(Eval($"{i}*{xx}{op}{i+3}*{yy}"), faktoriyel(y-tur))) / Convert.ToDouble(payda);
				result = Convert.ToDouble(fonk(i, x, op, y, tur)) / Convert.ToDouble(payda);
				System.Console.WriteLine($"\tresult\t= {result}");
				tur++;

				if (i % 2 == 0)
				{
					anaresult -= result;
				}
				else
				{
					anaresult += result;
				}
				//System.Console.WriteLine(result);
			}
			
			System.Console.WriteLine("asd");
			System.Console.WriteLine(anaresult);
			double dsa = Convert.ToDouble(y)/Convert.ToDouble(x);
			System.Console.WriteLine(dsa);
        }

        static long Eval(String expression)
		{
    		System.Data.DataTable table = new System.Data.DataTable();
    		return Convert.ToInt64(table.Compute(expression, String.Empty));
		}

		static long minn(long input1, long input2)
		{
			if (input1 < 0)
				return input2;

			else if (input2 < 0)
				return input1;

    		if (input1<input2)
				return input1;

			else if (input1>input2)
				return input2;
				
			return input1;
    		
		}

		static long faktoriyel(long sayi)
		{
			long sonuc = 1;
			for(long i = sayi; i > 0; i--) 
    			sonuc *= i; 
			return sonuc;

		}
		static long us(long sayi, long kuvvet)
		{
    		long sonuc = 1;
			for (long i = 0; i < kuvvet; i++)
			{
				sonuc = sonuc * sayi;
			}
			return sonuc;
		}
		static long fonk(long katsayi, long xxx, string islem, long yyy, long tursayisi)
		{
			return minn(Eval($"{katsayi}*{xxx}{islem}{katsayi+3}*{yyy}"), faktoriyel(yyy-tursayisi));
		}

    }
}
