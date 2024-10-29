using System;
using System.Collections.Generic;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int x = 3;
        float z;
        double d;
        decimal D;
        D = 3.22m;
        
        DateTime dd = DateTime.Now;
        TimeSpan ts = DateTime.Now - dd;
        
        Console.WriteLine(x);
        Console.WriteLine(ts);
        Console.WriteLine(dd.DayOfWeek);
        
        //tablica - referencja
        int []tab;
        int [,]tab2D;
        tab = new int[5];
        tab2D = new int[5,15];
        if(tab != null)
        {
            for(int i=0; i<tab.Length; i++)
            {
                tab[i] = i;  
            }
            foreach(int a in tab)
            {
                Console.WriteLine(a);  
            }
        }
        if(tab2D != null)
        {
            for(int i=0; i<tab2D.GetLength(0); i++)
            {
                for(int j=0; j<tab2D.GetLength(1); j++)
                {
                    Console.Write(tab2D[i,j]);  
                }
                Console.WriteLine();  
            }
        }
        //lista - referancja
        List<string> grupa;
        grupa = new List<string>();
        grupa.Add("Ala");
        grupa.Add("Ola1");
        grupa.Add("Ola2");
        grupa.Add("Ola3");
        grupa.Add("Zenek");
        grupa.Insert(0,"Aaa");
        
        grupa.Remove("Ola1");
        grupa.RemoveAt(1);
        
        //grupa.Remove(grupa.First());
        grupa.Remove(grupa.Last());
        
        if(grupa != null)
        {
            for(int i=0; i<grupa.Count; i++)
            {
                Console.WriteLine(grupa[i]);  
            }
            
            foreach(string s in grupa.OrderByDescending(x=>x))
            {
                Console.WriteLine(s);  
            }
        }
        
        Dictionary<string, int> slownik;
        slownik = new Dictionary<string, int>();
        
        slownik["jeden"] = 1;
        slownik["dwa"] = 0;
        slownik.Add("trzy", 3);
        slownik.Add("cztery", 4);
        slownik.Add("pięć", 5);
        
        slownik["dwa"] = 2;
        slownik.Remove("jeden");
       
        
        foreach(var s in slownik)
        {
            Console.WriteLine(s);
            Console.WriteLine(s.Key);  
            Console.WriteLine(s.Value);  
        }
        foreach(var k in slownik.Keys)
        {
            Console.Write(k);
            Console.Write(" >> ");  
            Console.WriteLine(slownik[k]);  
        }
    }
}
