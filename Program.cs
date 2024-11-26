
///* Problem: Add both single - line 
//multi-line comments in the following code segment explaining its purpose:*/
//int x = 10;   // this code idintifiy the variable x as an integer and add a value 10 to it
//int y = 20;   // this code idintifiy the variable y as an integer and add a value 20 to it
//int sum = x + y;    // this code idintifiy the variable sum as an integer and make it calculate the sum of x+y = 10+20=30
//            Console.WriteLine(sum);   //this line run the output of the sum which equal 30



//question: what is the shortcut to comment and uncomment a selected block of code in visual studio?  ctrl + k and ctrl + c


//Problem: Identify and fix the errors in this code snippet:
using System.ComponentModel;

///* Problem: Add both single - line 
int x = 10;  //you idintify the variable x as integer and add a string value
int y = 20;  //you was not idintify it
    Console.WriteLine(x + y);  // c# is a csae sensitive language and you write console and it should be capital letter




//A runtime error and a logical error are both types of programming errors, but they differ significantly in their nature and the way they manifest.

/*
1. Runtime Error
Definition: A runtime error occurs while the program is running. It happens due to invalid operations or unexpected conditions that
the program cannot handle, leading to the program's abrupt termination.
Cause: Issues like dividing by zero, accessing invalid memory, or referencing a null object.
Detection: Easy to detect because the program usually crashes and may display an error message */

/* 
2. Logical Error
Definition: A logical error occurs when the program runs successfully but produces incorrect or unintended results due to flaws in the program's logic.
Cause: Mistakes in the algorithm or incorrect implementation of the requirements.
Detection: Harder to detect because the program does not crash; you need to review the results to identify the problem
*/



//Problem: Declare variables using proper naming conventions to store:  Your full name.  Your age.  Your monthly salary.  Whether you are a student.

string FullName = "Ibrahim Saeed Elmahy";
int age = 20;
int salary = 2000;
bool student = true;


//Question: Why is it important to follow naming conventions such as PascalCase in C#? 
//     to make it easy to write and read the code and we cannot make a space between words in variables so we use it 





partial class Program
{
    class Person
    {
        public string Name { get; set; }
    }

    static void Main()
    {
        // Create a new Person object
        Person person1 = new Person { Name = "Alice" };

        // Assign person1 to person2 (both point to the same object)
        Person person2 = person1;

        // Modify the Name property using person2
        person2.Name = "Bob";

        // Display the Name property using both references
        Console.WriteLine("Person1's Name: " + person1.Name); // Output: Bob
        Console.WriteLine("Person2's Name: " + person2.Name); // Output: Bob
    }
}
/*
 Question: Explain the difference between value types and reference types in terms of memory allocation.  
        i answer this question by AI  but i under stand it

### Explanation:
- `person1` and `person2` are references to the same object in memory. 
- Changing the `Name` property using `person2` also affects the value seen by `person1` because they both point to the same memory location.

---

### Question: Difference Between Value Types and Reference Types (Memory Allocation)

| **Aspect**            | **Value Types**                       | **Reference Types**                     |
|------------------------|---------------------------------------|-----------------------------------------|
| **Definition**         | Contain the actual data directly.    | Store a reference (or pointer) to the data stored in heap memory. |
| **Examples**           | `int`, `float`, `char`, `bool`, `struct`, `enum` | `class`, `array`, `string`, `object`, `delegate` |
| **Memory Allocation**  | Allocated on the** stack**.           | Allocated on the** heap**.              |
| **Copy Behavior**      | When assigned or passed, a copy of the value is created. | When assigned or passed, the reference (not the object) is copied. |
| **Independence * *       | Each variable has its own copy of the data, and changes to one do not affect others. | Multiple references can point to the same object, and changes through one reference affect all others. |
| **Performance**        | Faster due to stack allocation.       | Slower due to heap allocation and garbage collection. |
| **Example Code**       |                                       |                                         |

#### Example: Value Types
```csharp
int a = 10;
int b = a; // Copy of 'a' is assigned to 'b'
b = 20;
Console.WriteLine(a); // Output: 10 (unchanged)
```

#### Example: Reference Types
```csharp
string[] arr1 = { "A", "B" };
string[] arr2 = arr1; // 'arr2' references the same array as 'arr1'
arr2[0] = "C";
Console.WriteLine(arr1[0]); // Output: "C" (changed)
```

### Summary:
-**Value types** hold data directly and are independent when copied or passed around.
- **Reference types** hold a reference to the data, so changes affect all references to the same object.*/




//Problem: Create a program that calculates the following using variables x = 15 and y = 4: o Sum o Difference o Product o Division result o Remainder 

int x = 15;
int y = 4;
Console.WriteLine(x+y);
Console.WriteLine(x-y);
Console.WriteLine(x*y);
Console.WriteLine(x/y);
Console.WriteLine(x%y);

int a = 2, b = 7; Console.WriteLine(a % b); // becouse the % output is the remiender of the division so it will be 2 



Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

// Check if the number is greater than 10 and even
if (number > 10 && number % 2 == 0)
{
    Console.WriteLine("The number is greater than 10 and even.");
}
else
{
    Console.WriteLine("The number is either not greater than 10 or not even.");
}



//Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator? 

//&& is for boolean logic, used in control flow, and short - circuits.
//& is for bitwise manipulation, works with integers, and evaluates both operands.




Console.Write("Enter a double value: ");
double userInput = double.Parse(Console.ReadLine());

// Implicit casting (not possible from double to int directly, hence skipped)

// Explicit casting: Convert double to int (this truncates the decimal part)
int explicitCast = (int)userInput;

// Display the results
Console.WriteLine("Original double value: " + userInput);
Console.WriteLine("Explicitly casted to int: " + explicitCast);






//Write a program that: (G01 Bonus, G02 mandatory) o Prompts the user for their age as a string. o Converts the string to an integer using Parse o Checks if the age is valid (e.g., greater than 0).

Console.Write("Please enter your age: ");
string ageInput = Console.ReadLine();



    int age = int.Parse(ageInput);

    // Check if the age is valid (greater than 0)
    if (age > 0)
    {
        Console.WriteLine("Your age is: " + age);
    }
    else
    {
        Console.WriteLine("Invalid age. Age must be greater than 0.");
    }





//Problem: Write a program that demonstrates the difference between prefix and postfix increment operators using a variable x.

// prifix like ++x  we make the operation frist 
// postfix like x++ we make the operation later


//Question: Given the code below, what is the value of x after execution? Explain why int x = 5; int y = ++x + x++;



int x = 5;   
int y = ++x + x++; // ++x=6   and x++=6 but after that meen 7 so y = 6 + 6= 12





