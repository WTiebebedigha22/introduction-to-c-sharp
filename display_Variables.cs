/*
Display Variables
The WriteLine() method is often used to display variable values to the console window.

To combine both text and a variable, use the + character:
Example
*/
string name = "John";
Console.WriteLine("Hello " + name);
//Output: Hello John

//You can also use the + character to add a variable to another varible:
//Example
string firstName = "John ";
string lastName = "Doe";
String fullName = firstName + lastName;
Console.WriteLine(fullName);
// output: John Doe

//For numeric values, the + character works as a mathematical operator (notice that we use int (integer) variables here):
//Example
int x = 5;
int y = 6;
Console.WriteLine(x + y); // prints the value of x + y
//Output: 11
