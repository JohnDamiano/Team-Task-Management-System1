using System;

public class TeamTaskManagementSystem
{
    static public void Main ()
    {
     Console.WriteLine("Team Task Manager");
     string Member1name = "John A. nhel Damiano";
string Project = "Team Task Management System";
     string Assignment = "Debugger";
string password = "Damianojohn";
string possition = "Team leader";
    
    
    
    Console.Write("Enter Your Password:");
    String Passwordinput = Console.ReadLine();
    if (Passwordinput  ==  password)
    {
    	Console.WriteLine("Name:"+Member1name);

        Console.WriteLine("Project:"+Project);

        Console.WriteLine("Possition:"+possition);
    	Console.WriteLine("Assignment:"+Assignment);
    		
    	}
    else
    {
    	
       Console.WriteLine("Wrong password try again! ");
    }
   {
   	 string assignment1 = "-Coder";
   	 string assignment2 = "-Editor";
   	 string assignment3 = "-Finance";
   	 
     string name1 = "member1";	
     string name2 =	"member2";
     string name3 ="member3";
     
     
     Console.WriteLine("");
     Console.WriteLine("");
     Console.WriteLine("Add member:");
     
     string member1 = Console.ReadLine();
     string member2 = Console.ReadLine();
     string member3 = Console.ReadLine();
     
     Console.WriteLine("");
     Console.WriteLine("member1: "+member1+assignment1);
     Console.WriteLine("member2: "+member2+assignment2);
     Console.WriteLine("member3: "+member3+assignment3);
    }
     
   
     
     
     
     
     
        }     }

}        
