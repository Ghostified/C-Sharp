 using System;
using System.Diagnostics.Contracts;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;
// class Multiply {

//   static void Main (String [] Args) {
//     Console.WriteLine("Enter the first number: "); 
//     int num1 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Enter the first number: ");
//     int num2 = Convert.ToInt32(Console.ReadLine());

//     int answer = num1 * num2;

//     Console.WriteLine("What is the value of  " + num1 + " X " + num2 + " : ");
//     int givenAnswer = Convert.ToInt32(Console.ReadLine());

//     if (givenAnswer == answer){
//       Console.WriteLine("The answer is correct ");
//     }else {
//       Console.WriteLine("Failed , try again");
//     }


//     Console.ReadLine();


//   }
// }

class Multiply
{
  static void Main(String[] Args)
  {
    //If else statement
    //Multiplication();

  //Switch case
    //SwitchCase();

    //For Loop
    //ForLoop();

    //Nested Loop;
    //NestedLoop();

    //while Loops
    //WhileLoops();

   //Type casting
   //CelciusConverter();

   Grader();
  

  }

  static void Multiplication (){
    Console.WriteLine("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the first number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int answer = num1 * num2;

        Console.WriteLine("What is the value of  " + num1 + " X " + num2 + " : ");
        int givenAnswer = Convert.ToInt32(Console.ReadLine());

        if (givenAnswer == answer){
          Console.WriteLine("The answer is correct ");
        }else {
          Console.WriteLine("Failed , try again");
        }


        Console.ReadLine();
  }

  //switch statement
   static void SwitchCase (){
    Console.Write("Enter the day of the week: ");
    int day = Convert.ToInt32(Console.ReadLine());

    switch( day){
      case 1: Console.WriteLine("Monday");
      break;
      case 2: Console.WriteLine("Tue");
      break;
      case 3: Console.WriteLine("Wed");
      break;
      case 4 : Console.WriteLine("Thursday");
      break;
      case 5: Console.WriteLine("Friday");
      break;
      case 6: Console.Write("Saturday");
      break;
      case 7 : Console.Write("Sunday");
      break;
      default:
      Console.WriteLine("Invalid Input");
      break;
    }

    Console.ReadLine(); 
   }

   static void ForLoop(){

     int n = 5; 
     int total = 0;

     for (int i = 0; i < n ; i++){
      Console.WriteLine("Enter a number: ");
      int number = Convert.ToInt32(Console.ReadLine());
      total = total + number; 

     }

     Console.WriteLine("The total is:  " + total);


   }

   static void NestedLoop(){

    Console.WriteLine("What do you want to print?:  ");
    String message = Console.ReadLine();

    Console.WriteLine("How many times do you want to print?: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num <= 0 ){
      for (int i = 0; i < num; i++){
        Console.WriteLine(message);
      }
    } else {
      Console.WriteLine("You entered an incorrect value!");
    }
   }

   static void WhileLoops(){

    Console.WriteLine("Please enter your income (Enter 0 to exit)");
    int income = Convert.ToInt32(Console.ReadLine());


    int loopCounter = 0; 
    int total = 0;
    int min = income;
    int max = income;
    int sentinel = 0;
    int average; 
     
    while (income != sentinel) {
      
      total = income + total;
      if (income > min){
        max = income;
      }
      if (income < min ){
        min = income;
      }

      loopCounter++;
      Console.WriteLine("Enter a new Income: ");
      income = Convert.ToInt32(Console.ReadLine());
    }

    if ( loopCounter == 0){
      Console.WriteLine("You entered an incorrect value");
    } else {
      average = total / loopCounter ;
      Console.WriteLine("The average income is: " + average);
      Console.WriteLine("The Maximum income is" + max);
      Console.WriteLine("The minimum income is: "+ min);
      Console.WriteLine("The Total income is " + total);
    }
   }

   static void GuessTotal(){

    int answer; 
    Console.WriteLine("The the first number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the second number: ");
    int  num2 = Convert.ToInt32(Console.ReadLine());

    answer = num1 * num2;

    Console.WriteLine("What is the value of " + num1 + " X "  + num2);
    int guess = Convert.ToInt32(Console.ReadLine());
   }

  static void CelciusConverter(){

    
    Console.WriteLine("Enter the temprature in fahrenheit");
    decimal input = Convert.ToDecimal(Console.ReadLine());
    decimal calculate = (input - 32) * ((decimal)5/(decimal)9);
    Console.WriteLine(calculate); 


  }

  static void Grader(){

    int currentAssignments = 5; 

    int sophia1 = 93;
    int sophia2 = 87;
    int sophis3 = 98;
    int sophia4 = 95;
    int sophia5 = 100;

    int nico1 = 80;
    int nico2 = 83;
    int nico3 = 82;
    int nico4 = 88;
    int nico5 = 85;

    int zahi1 = 84;
    int zahi2 = 96;
    int zahi3 = 73;
    int zahi4 = 85;
    int zahi5 = 79;

    int jeo1 = 90;
    int jeo2 = 92;
    int jeo3 = 98;
    int jeo4 = 100;
    int jeo5 = 97;


    int sofiasum = 0;
    int nicosum = 0;
    int zahisum =0;
    int jeosum = 0;

    sofiasum = sophia1 + sophia2 + sophis3 + sophia4 + sophia5;
    nicosum = nico1 + nico2 + nico3 + nico4 + nico5;
    zahisum = zahi1 + zahi2 + zahi3 + zahi4 + zahi5;
    jeosum = jeo1 + jeo2 + jeo3 + jeo4 + jeo5;

    Console.WriteLine("Sophia: " + sofiasum);
    Console.WriteLine("Nico: " + nicosum);
    Console.WriteLine("Zahi: " + zahisum);
    Console.WriteLine("Jeo: " + jeosum);

    decimal sophiaScore = (decimal)sofiasum / currentAssignments;
    decimal nicoScore = (decimal)nicosum / currentAssignments;
    decimal zahiscore = (decimal)zahisum / currentAssignments;
    decimal jeoScore = (decimal)jeosum / currentAssignments;

    Console.WriteLine("Studet\t\t\t\tGrades \n");

    Console.WriteLine("The score for sofia:\t\t" + sophiaScore + "\tA");
    Console.WriteLine("The score for Nico:\t\t" + nicoScore  + "\tB");
    Console.WriteLine("The score for Zahi:\t\t" + zahiscore + "\tB");
    Console.WriteLine("The score for Jeo:\t\t" + jeoScore + "\tA"); 



  }
}

