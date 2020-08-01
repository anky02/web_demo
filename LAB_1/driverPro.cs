using System;
using add;
namespace dp
{
    class driver {         
        static void Main(string[] args)
        {
        	int p,q,ans;
        	Console.WriteLine("Enter 1st number:");
        	p= int.Parse(Console.ReadLine());
        	Console.WriteLine("Enter 2nd number:");
        	q= int.Parse(Console.ReadLine());
        	
        	my_prog mp=new my_prog();
        	ans=mp.addition(p,q);
            Console.WriteLine("Addition is:"+ans);
            Console.ReadKey();
             
        }
    }
}