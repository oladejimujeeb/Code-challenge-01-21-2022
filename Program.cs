using System;
using System.Collections.Generic;
using System.Collections;
namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Question 1*/
            int [] array = {1,3,2,2,5,2,3,7};
            int m = array.Max();
            int t = array.Min();
            int temp =0;
            for(int i=0; i <array.Length; i++)
            {
                for(int j =i+1; j<array.Length; j++)
                {
                    if(array[i]>array[j])
                    {
                        temp = array[j];
                        array[j]=array[i];
                        array[i]= temp;
                    }
                }
            }

            string a ="";
            if(m==t)
            {
                Console.WriteLine("0");
            }
            else
            {
                for(int i =array.Length-1; i > 0; i--)
                {
                    if(Math.Abs(array[i]-array[i-1])<=1)
                    {
                        a += array[i-1];
                    }
                }
                Console.WriteLine(a.Length);
            }
            //QUESTION TWO
            int n= 5;
            Console.WriteLine("QUESTION TWO, uncomment line 47 to show result ");
            //Console.WriteLine(CompleteSteps(n));
            
        }
         public static int CompleteSteps(int n)
        {
            int stairs =1;
            while(stairs<=n)
            {
                n -=stairs;
                stairs++;
            }
            return stairs-1;   
        }
        
        
    }
}
