// See https://aka.ms/new-console-template for more information
using TestKontrolStrukturer;
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Hello, World!");


////int age = 17;
////Console.WriteLine("Starting to check age...");

////if (age < 18)
////{
////    Console.WriteLine("You are still a child...");
////    if (age < 1)
////    {
////        Console.WriteLine("New born");
////    }
////}
////else
////{
////    Console.WriteLine("You are an adult!");
////}

////Console.WriteLine("Finished checking age");




////if ((age < 20) && (age > 12))
////{
////    Console.WriteLine("You are a teenager");
////}

//int age = 18;
//string message = "You are ";

//message = message + ((age < 18) ? "a child." : "an adult.");
////if (age < 18)
////{
////    message = message + "a child.";
////}
////else
////{
////    message = message + "an adult.";
////}

//int score = 55; 

//if (score >= 90 && score <100)
//{
//    Console.WriteLine("Mark is: A");
//}
//else if (score >= 70)
//{
//    Console.WriteLine("Mark is: B");
//}
//else if (score >= 40)
//{
//    Console.WriteLine("Mark is: C");
//}
//else
//{
//    Console.WriteLine("Mark is: D");
//}

//int childSupport = 0; 
//int noOfChildren = 0; 
//switch (noOfChildren)
//{
//    case 0:
//        childSupport = 0;
//        break;
//    case 1:
//        childSupport = 1200;
//        break;
//    case 2:
//        childSupport = 2000;
//        break;
//    case 3:
//        childSupport = 2600;
//        break;
//    default:
//        childSupport = 3000;
//        break;
//}

////int number = 1;  // Initialisation
////while (number < 5)  // Condition
////{
////    Console.WriteLine(number);
////    // Code block
////    number = number + 1; // Change
////}

//for (int number = 1; number < 5; number = number + 1)
//{
//    Console.WriteLine(number);
//}


//int[] myFirstArray; //declare an array
//myFirstArray = new int[7];//creating
////put a value into the array
//myFirstArray[3] = 23;
////retrieve an element
//int singleValue = myFirstArray[5];
////Increase the value - use it as another //variable
//myFirstArray[4]++;

//// initialization
//int[] myFirstArray = new int[] { 34, -233, 9801, 67, 2, -9582, 770 };
////iterate bagfra skriv array ud bagfra

//for(int index=myFirstArray.Length-1;index>=0;index=index-1)
//{
//    Console.WriteLine(myFirstArray[index]);
//}

////while loop
//int i = myFirstArray.Length - 1;
//while (i >=0)
//{
//    Console.WriteLine(myFirstArray[i]);
//    i--;
//}

////iterate through the array for loop
//for (int index = 0; index < 7; index++)
//{
//    Console.WriteLine(myFirstArray[index]);
//}




//for(int index = 0; index < myFirstArray.Length; index++)
//{
//    myFirstArray[index] = 10;
//}

//foreach (var value in myFirstArray)
//{
//    Console.WriteLine(value);
//}


//string[] studentNames=new string[5];

//Student[] students = new Student[7];

List<int> list = new List<int>() { 23, 55, 66 };
list.Add(10);
list.Add(17);
list.Add(81);
Console.WriteLine(list[2]);
//for(int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}
foreach (int j in list)
{
    Console.WriteLine(j);
}
list.Insert(3, 5);

list.RemoveAt(5);


//int searchFor = 15;
//for (int i = 0; i < list.Count; i++)
//{
//    if (list[i] == searchFor)
//    {
//        Console.WriteLine("Elementet er fundet på index " + i);
//        break;
//    }
//    if (i == list.Count-1)
//    {
//        Console.WriteLine("Ikke fundet");
//    }
//}

List<Student> students = new List<Student>();
Student s1 = new Student(3,"2323", "Poul");
students.Add(s1);



Dictionary<string, Student> allStudents = new Dictionary<string, Student>();
Student student = new Student(1, "1212-12", "Peter");
Student student2 = new Student(2, "1212-13", "Ole");
Student student3 = new Student(3, "1212-13", "Charlotte");
allStudents.Add(student.SSN, student);
allStudents.Add("1212-13", student2);


if (!allStudents.ContainsKey("1212-13"))
    allStudents.Add("1212-13", student3);

//if (allStudents.ContainsKey("1212-12"))
//{
//    Student foundStudent = allStudents["1212-12"];
//}
//allStudents.Remove("1212-13");
//allStudents["1212-13"] = new Student(4, "1212-13", "Kurt");

//foreach(Student s in allStudents.Values)
//{
//    Console.WriteLine(s.Name);
//}

//Console.WriteLine("HashSet");


//HashSet<string> ssnColl = new HashSet<string>();

//bool added = ssnColl.Add("12121212");
////Console.WriteLine($"Status { added}");
//added = ssnColl.Add("13131313");
//added = ssnColl.Add("14141414");
//added = ssnColl.Add("15151515");
//added = ssnColl.Add("16161616");
//added = ssnColl.Add("12121212");
//Console.WriteLine("HashSettet ssnColl indeholder");
//foreach (string s in ssnColl)
//{
//    Console.WriteLine(s);
//}

//bool isPresent = ssnColl.Contains("12121212");
//if (isPresent)
//{
//    Console.WriteLine(" 12121212 findes ellerede ssnColl");
//}

//HashSet<string> clubColl = new HashSet<string>();
//added = clubColl.Add("12121212");
////Console.WriteLine($"Status {added}");
//added = clubColl.Add("13131313");
//added = clubColl.Add("45454545");
//added = clubColl.Add("67676767");
//added = clubColl.Add("16161616");
//added = clubColl.Add("89898989");
//Console.WriteLine("HashSettet clubColl indeholder");
//foreach (string s in clubColl)
//{
//    Console.WriteLine(s);
//}

//IEnumerable<string> unionOfColl = ssnColl.Union(clubColl);
//Console.WriteLine("Union af clubColl & ssnColl indeholder");
//foreach (string s in unionOfColl)
//{
//    Console.WriteLine(s);
//}
//IEnumerable<string> unionOfColl2 = ssnColl.Union(new List<String>() { "2323", "4545" });
//Console.WriteLine("Union af en ny liste af strings & ssnColl indeholder");
//foreach (string s in unionOfColl2)
//{
//    Console.WriteLine(s);
//}


//IEnumerable<string> intersection = ssnColl.Intersect(clubColl);
//Console.WriteLine("intersection af unionOFColl & ssnColl indeholder");
//foreach (string s in intersection)
//{
//    Console.WriteLine(s);
//}


Console.WriteLine("Enumeration");

//int fruittype = 2;
FruitType aFruit = FruitType.Banana;
Console.WriteLine(aFruit + " nummer " + (int)aFruit);

//Console.WriteLine("Angiv frugttype 0 Æble 1 pærer 2 cherry 3 banana 4 kiwi");
Console.WriteLine("Angiv frugttype Apple, Pear, Cherry, Banana, Kiwi");
string fruitString = Console.ReadLine();
Enum.TryParse(fruitString, out FruitType myFruitType);

Console.WriteLine(myFruitType);

//// Step 2: Use the Enum

DaysOfWeek today = DaysOfWeek.Wednesday;

// Reading the enum value
Console.WriteLine($"Today is: {today}");

// Converting enum to its underlying integer value
int dayNumber = (int)today;
Console.WriteLine($"Day number is: {dayNumber}");

// Parsing a string to an enum value
string dayString = "Friday";
if (Enum.TryParse(dayString, out DaysOfWeek parsedDay))
{
    Console.WriteLine($"Parsed day is: {parsedDay}");
}
else
{
    Console.WriteLine("Invalid day string");
}

// Iterating over enum values
foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
{
    Console.WriteLine(day);
}



