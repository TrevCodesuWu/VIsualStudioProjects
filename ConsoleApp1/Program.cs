using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            String ownerName = "Trevlin";
            String secetaryName = "Kylan Govender";
            Console.WriteLine("Regional Office ");
            Console.WriteLine("Enter your name : ");


            String name = Console.ReadLine();

            String displayMessage = ((name == ownerName ) ||(name == secetaryName )) ? "Yes " : "No ";
            Console.WriteLine("Do you have the same name as the owners / secatary ? " + displayMessage);
            Boolean sameName = false;
            while  (!sameName){
                if ( ( name == "Trevlin" ) || ( name == "Kylan Govender") )
                   
                { 
                    Console.WriteLine("Change your name ? \n\t Yes or No");
                    String answer = Console.ReadLine();
                    if (answer == "Yes")
                    {
                        Console.WriteLine("Enter a new name or Nickname : ");
                        name = Console.ReadLine();
                         if (( name == "Trevlin") || ( name == "Kylan Govender") )
                        {
                            Console.WriteLine("I said change your name !!");
                          
                        }
                         else
                        {
                            sameName = true;
                            Console.WriteLine("Nice new name , keep it that way !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have to change your name to move on from this point forward !!");
                        
                    }

                }
                else
                {
                    Console.WriteLine("Name acceptable ");
              
                    sameName = true;
                }
                Console.ReadLine();
            }
        
           

            */
            //   HOW TO USE AN INPUT METHOD WITH A METHOD // VERY IMPORTANT TO LEARN IT *

            Console.Write("Enter your name for a surprise : ");
            //Entering your name here 
            String firstName = Console.ReadLine();
           
            Console.WriteLine("");
            Console.Write("What is your family's name ? ");
            String familyName = Console.ReadLine();
            // The name is getting stored in this process
            Console.Write("Results are : "); 
            reverseString(firstName);
            reverseString(familyName);
            
            // The input of the method is a variable which is fine aswell 
            Console.ReadLine();

        }
     

        private static void reverseString( String message)
            // void means that you don't get back to me , you go do the mission What is the purpose on the most way to get aroudn in the ways and this is an good example for that to not be able to  not phone or not public void private void  and then don't report back 
            // The method reverseString has an input which is message and needs to be filled when calling it 
        {  
            char[] messageArray = message.ToCharArray();
            //The array called messageArray is converting the string varible message into a char using a helper 
            // method
            Array.Reverse(messageArray);
            // The array function is allowing it to be reversed  with the array inside 
            foreach(char item in messageArray)
                // all the items in the messageArray array is going to be displayed 
            {
                Console.Write(item);
                
                // This will display the things onto the screen 
                
            }
            Console.Write(" ");

            
        }
    }
}
