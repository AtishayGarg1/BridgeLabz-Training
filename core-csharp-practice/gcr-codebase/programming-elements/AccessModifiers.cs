using System;

class AccessModifiers 
{
	// public: accessible from anywhere
	public int a = 5;

	// private: accessible only inside this class
	private int n1 = 10;

	// protected: accessible in this class and derived classes
	protected int n2 = 20;

	//internal: accessible anywhere within the same assembly/project
	internal int n3 = 100;
	
	//protected internal: accessible in same project or derived class
	protected internal int n4 = 123;

	//private protected int n5 = 456; is available from C# 7.2


	static void Main()
	{


		PublicModifier bam = new PublicModifier();
		bam.Hello();
		
		AccessModifiers mam = new AccessModifiers();
		mam.showPrivate();

		DerivedAccessModifiers dam = new DerivedAccessModifiers();
		dam.deriveAccess();
		
	}

	//method to show private value
	public void showPrivate()
	{
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Private Value is: " + n1);
	}
	
	

}


// accessing value without inheritance
class PublicModifier
{
	public void Hello()
	{
		Console.WriteLine();
		Console.WriteLine();
		AccessModifiers am = new AccessModifiers();
		Console.WriteLine("Public value is: "+am.a);
		Console.WriteLine("Internal value is: "+am.n3);
		
	}
}


//accessing values using inheritance
class DerivedAccessModifiers : AccessModifiers
{
	public void deriveAccess()
	{
		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine("Public Value In Derived Class is: " + a);
		Console.WriteLine("Internal Value In Derived Class is: " + n3);
		Console.WriteLine("ProtectedValue In Derived Class is: " + n2);
		Console.WriteLine("protected internal Value In Derived Class is: " + n4);
		//Console.WriteLine("private protected Value In Derived Class is: " + n5);

	}
}