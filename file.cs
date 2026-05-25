class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter somesthing:");
		var name = Console.ReadKey();
		Console.Write("Hello, world");
		Console.WriteLine(name);
	}
}