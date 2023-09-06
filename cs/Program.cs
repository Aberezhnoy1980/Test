namespace cs;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter array size: ");
		string[] srcArray = new string[Convert.ToInt32(Console.ReadLine())];

		for (int i = 0; i < srcArray.Length; i++)
		{
			Console.WriteLine($"Enter {i + 1} string: ");
			srcArray[i] = Console.ReadLine();
		}

		int size = 0;
		for (int i = 0; i < srcArray.Length; i++)
		{
			if (srcArray[i].Length <= 3)
			{
				size++;
			}
		}

		string[] dstArray = new string[size];

		for (int i = 0, j = 0; i < srcArray.Length; i++)
		{
			if (srcArray[i].Length <= 3)
			{
				dstArray[j++] = srcArray[i];
			}
		}

		Console.Write($"In source array [ {string.Join(", ", srcArray)} ] elements with symbol length less than three [ {string.Join(", ", dstArray)} ]");
	}
}
