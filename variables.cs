//Variables
/*
Variables are containers for storing data values.

In C#, there are different types of variables (defined with different keywords), for example:

int - stores integers (whole numbers), without decimals, such as 123 or -123
double - stores floating point numbers, with decimals, such as 19.99 or -19.99
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false

Declaring (Creating) Variables
To create a variable, specify the type and assign it a value:
syntax for declaring a variable:
type variableName = value;
*/

string name = "john";
Console.WriteLine(name);

int myNum = 15;
Console.WriteLine(myNum);

int myNum;
myNum = 15;
Console.WriteLine(myNum);

//Note: if you assign a new value to an existing variable, it will overwrite the previous value.

int myNum = 15
myNum = 20; // the value of myNum is now 20
Console.WriteLine(myNum);

//Other Types
int myNum = 5;
double my DoubleNum = 5.99;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello"
