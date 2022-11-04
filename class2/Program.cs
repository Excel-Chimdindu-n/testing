// See https://aka.ms/new-console-template for more information
   // Console.WriteLine("Hello, World!");
  using System;

  namespace Classwork{
      class MainClass{ 
         static void Main (string[] args){
         

         //    if (num == 0)
         //    {
         //       Console.WriteLine("wirte a number");

         //    }else
         //    {
         //       int numSquared = num * num;
         //       Console.WriteLine(numSquared);

         //       int numMod2 = num % 2;
         //       Console.WriteLine(numMod2);

         //       int numMod4 = num % 4;
         //       Console.WriteLine(numMod2);

               
         //    }
         // int num =Convert.ToInt32( Console.ReadLine());
         //    Console.ReadKey();
         

        
         var counter = 0;
         for(counter = 0; counter <= 3; counter++){
            if ( counter   == 0){
               Console.WriteLine("the mod of 4 {counter}"); 
            }else{
                Console.WriteLine("the mod of nothing");
            }

            counter = Convert.ToInt32(Console.ReadLine()) + counter;
         }
         int mod4 = counter % 4;
         Console.WriteLine("this is the mod of 4{mod4}");

         }

         // class Operators{
         //    static void Operator(string[] args){
            
         //       int num1;
         //       int num2;

         //       Console.WriteLine("write the 1st number");
         //       num1 = Convert.ToInt32(Console.ReadLine());

         //       Console.WriteLine("write the 2nd number");
         //       num2 = Convert.ToInt32(Console.ReadLine());

         //       Console.WriteLine($"the sum of the numbers are{num1 + num2}");
         //       Console.WriteLine($"the diff of the numbers are{num1 - num2}");
         //       Console.WriteLine($"the quad of the numbers are{num1 / num2}");
         //       Console.WriteLine($"the product of the numbers are{num1 * num2}");
         //       Console.WriteLine($"the mod of the numbers are{num1 % num2}");
         //    }

         // }
      } 
  }
    


  
      

          
         
      