using System;

class Operators
{
	static void Main()
	{
		int a = 100;
		int b = 20;
		int c = 5;

		// Arithmetic Operators(+,-,*,/,%)
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Arithmetic Operators");
		Console.WriteLine(a + "+" + b + "=" + (a+b));		//Addition
		Console.WriteLine(a + "-" + b + "=" + (a-b));		//Subtraction
		Console.WriteLine(a + "*" + b + "=" + (a*b));		//Multiplication
		Console.WriteLine(a + "/" + b + "=" + (a/b));		//Division
		Console.WriteLine(a + "%" + b + "=" + (a%b));		//Modulus


		//Relational Operators(==,!=,>,<,>=,<=)
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Relational Operators");
		Console.WriteLine("a==b:"+(a==b));	//Equal
		Console.WriteLine("a!=b:"+(a!=b));	//Not Equal
		Console.WriteLine("a>b:"+(a>b));	//Greater Than
		Console.WriteLine("a<b:"+(a<b));	//Less Than
		Console.WriteLine("a>=b:"+(a>=b));	//Greater Than Equal To
		Console.WriteLine("a<=b:"+(a<=b));	//Less Than Equal To

		bool t = true;
		bool f = false;

		//Logical Operators(&&,||,!)
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Logical Operators");
		Console.WriteLine("t && f:"+(t && f));	//Logical AND
		Console.WriteLine("t || f:"+(t || f));	//Logical OR
		Console.WriteLine("!t:"+(!t));		//Logical NOT

		// Assignment Operators(=,+=,-=,*=,/=,%=)
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Assignment Operators");
		Console.WriteLine("c = "+(c=a));		//Assignment Operator
		Console.WriteLine("c += "+a+" : "+(c+=a));	//Additional Assignment Operator
		Console.WriteLine("c -= "+a+" : "+(c-=a));	//Subtraction Assignment Operator
		Console.WriteLine("c *= "+a+" : "+(c*=a));	//Multiplication Assignment Operator
		Console.WriteLine("c /= "+a+" : "+(c/=a));	//Division Assignment Operator
		Console.WriteLine("c %= "+a+" : "+(c%=a));	//Modulus Assignment Operator 

		//Unary Operators(+,-,++,--,!)
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Unary Operators");
		Console.WriteLine("+" + a + ": " +a);		//Unary Plus
		Console.WriteLine("-" + a + ": " + -a);	//Unary Minus
		Console.WriteLine("a++ :" + a++ );	//Postfix Increment
		Console.WriteLine("++a :" + ++a );	//Prefix Increment
		Console.WriteLine("a-- :" + a-- );	//Postfix Decrement
		Console.WriteLine("--a :" + --a );	//Prefix Decrement
		Console.WriteLine("!"+t+":"+!t );	//Logical Complement

		//Ternary Operator
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Ternary Operator");
		Console.WriteLine("max = " + (a>b? a : b));	//Ternary Operator

		//is Operator
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine(" Operators");
		Console.WriteLine("a is int: " + (a is int));
	
	}
}


