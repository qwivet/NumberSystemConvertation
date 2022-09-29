public class InputConvert:NumberConvert
{
	private string expression = "";

	public InputConvert (string expression)
	{
		this.expression = expression;
	}
	public int ConvertTo(string i, int charPosition)
	{
		int result = 0;
		bool isCorrect = false;
		while (!isCorrect)
		{
			try
			{
				result = base.ConvertTo(i);
				isCorrect = true;

			}
			catch 
			{
				i = IncorrectInputMessage(charPosition);
			}
		}
		return result;
	}
	public int ConvertTo(char i, int charPosition)
	{
		int result = 0;
		bool isCorrect = false;
		while (!isCorrect)
		{
			try
			{
				result = base.ConvertTo(i);
				isCorrect = true;
			}
			catch
			{
				i = IncorrectInputMessage(charPosition)[0];
			}
		}
		return result;
	}
	private string IncorrectInputMessage (int charPosition)
	{
		Console.WriteLine("There is error in input, please fix incorrect character");
		Console.WriteLine(string.Concat(expression, '\n', new string (' ', charPosition), '^'));
		Console.Write("Fixed character:\t\t\t\t\t");
		char newChar = Console.ReadLine()[0];
		return newChar.ToString();
	}
}