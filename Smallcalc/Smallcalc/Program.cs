// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using System;
using System.Numerics;
using System.Drawing;

class smallcalc {

    //Computation Function to calculate the Input
    void compute() {

        
        int c;
        string num1,num2;   
        Console.WriteLine("Enter a First Number for computaion");
        num1 = Console.ReadLine();
        bool checknumber=int.TryParse(num1, out int  a);
        Console.WriteLine("Enter a Seciond Number for computaion");
        num2 = Console.ReadLine();
        bool checknumber1 = int.TryParse(num2, out int b);
        //Checking the Input given is Number 
        if (checknumber && checknumber1)
        {
            Console.WriteLine("OUTPUT \n");
            c = a + b;
            Console.WriteLine("Addition of Two Numbers " + a + " + " + b + " = " + c + "\n");
            c = a - b;
            Console.WriteLine($"Subtraction of Two Numbers {a} - {b} = {c} \n");
            c = a * b;
            Console.WriteLine($"Multiplication of Two Numbers {a} * {b} = {c} \n");
            c = a / b;
            Console.WriteLine($"Division of Two Numbers {a} / {b} = {c} \n");

        }
        else {
            Console.WriteLine("Please Enter Only Number");
        
        }
    }
           





    //To Show Message to User 

    int show() {

        int choice;

        Console.WriteLine("Small Calc");
        Console.WriteLine("Press 1 For Input");
        Console.WriteLine("Press 2 For Clear");
        Console.WriteLine("Press 3 For Exit");
        choice = Convert.ToInt32(Console.ReadLine());
        return choice;
    }


        


    static void Main() {

        int choice= 0;  
        smallcalc s = new smallcalc();


        

        bool checkChoice = true;
        choice = s.show();
        while(checkChoice)
        {
                   

            switch (choice){

            case 1: {
                    s.compute();
                    choice=s.show();
                    break;  
                
                     }
            case 2: {
                        Console.Clear();
                        choice=s.show();
                        break;

                
                
                     }
                    case 3: {

                        // Environment.Exit(0);
                        checkChoice = false;
                        Console.WriteLine("Thank You!");
                                break; 
                          }
                default:
                    { Console.WriteLine("Enter valid input");
                        choice=s.show();   
                        break;
                        
                    }
                    


        }

            }

    }
    



}
