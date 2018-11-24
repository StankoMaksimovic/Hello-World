using System;


public class Add
{
    bool Punoletan;
    
    public int Age(int age)
    {
        if (age < 18){
            Punoletan = false; 
        }
     
        else Punoletan = true;
        return age;

    }

    public void Print()
    {

            if (Punoletan == true){
                Console.WriteLine("The person can buy alchohol");
            }
            else{
                System.Console.WriteLine("Call the parents or the police");
            }
    }
}