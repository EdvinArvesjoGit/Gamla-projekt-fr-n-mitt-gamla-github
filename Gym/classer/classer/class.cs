using System;
public class Enemy 
{
    public string name;
   public int hp = 100;
    
    public int Attack()
    {
        Console.WriteLine("pow!");
        return 5;
    }
    
}   