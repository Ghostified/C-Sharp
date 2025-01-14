 using System;
using System.Runtime.ConstrainedExecution;
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
    WhileLoops();
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
}

