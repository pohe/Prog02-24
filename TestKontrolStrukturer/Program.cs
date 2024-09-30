// See https://aka.ms/new-console-template for more information
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Hello, World!");


//int age = 17;
//Console.WriteLine("Starting to check age...");

//if (age < 18)
//{
//    Console.WriteLine("You are still a child...");
//    if (age < 1)
//    {
//        Console.WriteLine("New born");
//    }
//}
//else
//{
//    Console.WriteLine("You are an adult!");
//}

//Console.WriteLine("Finished checking age");




//if ((age < 20) && (age > 12))
//{
//    Console.WriteLine("You are a teenager");
//}

int age = 18;
string message = "You are ";

message = message + ((age < 18) ? "a child." : "an adult.");
//if (age < 18)
//{
//    message = message + "a child.";
//}
//else
//{
//    message = message + "an adult.";
//}

int score = 55; 

if (score >= 90 && score <100)
{
    Console.WriteLine("Mark is: A");
}
else if (score >= 70)
{
    Console.WriteLine("Mark is: B");
}
else if (score >= 40)
{
    Console.WriteLine("Mark is: C");
}
else
{
    Console.WriteLine("Mark is: D");
}

int childSupport = 0; 
int noOfChildren = 0; 
switch (noOfChildren)
{
    case 0:
        childSupport = 0;
        break;
    case 1:
        childSupport = 1200;
        break;
    case 2:
        childSupport = 2000;
        break;
    case 3:
        childSupport = 2600;
        break;
    default:
        childSupport = 3000;
        break;
}

//int number = 1;  // Initialisation
//while (number < 5)  // Condition
//{
//    Console.WriteLine(number);
//    // Code block
//    number = number + 1; // Change
//}

for (int number = 1; number < 5; number = number + 1)
{
    Console.WriteLine(number);
}


//int[] myFirstArray; //declare an array
//myFirstArray = new int[7];//creating
////put a value into the array
//myFirstArray[3] = 23;
////retrieve an element
//int singleValue = myFirstArray[5];
////Increase the value - use it as another //variable
//myFirstArray[4]++;

// initialization
int[] myFirstArray = new int[] { 34, -233, 9801, 67, 2, -9582, 770 };

//iterate through the array
for (int index = 0; index < 7; index++)
{
    Console.WriteLine(myFirstArray[index]);
}
for(int index = 0;index < myFirstArray.Length; index++)
{
    myFirstArray[index] = 10;
}

foreach (var value in myFirstArray)
{
    Console.WriteLine(value);
}


string[] studentNames=new string[5];

