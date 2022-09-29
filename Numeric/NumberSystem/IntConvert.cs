class IntConvert : NumberSystemConvert
{
	public IntConvert (int startSystem, int endSystem, InputConvert numberConvert)
	{
		this.startSystem = startSystem;
		this.endSystem = endSystem;
		this.numberConvert = numberConvert;
	}

	public override string Convert(string exp, ref int floatPos)
	{
		floatPosition = floatPos;
		int[] numbers = ReadIntPart(exp);

		floatPosition =
			floatPosition == 0 ? 
			numbers.Length : floatPosition;

		string result = IntToResult(numbers);
		floatPos = floatPosition;

		return result;
	}

	private int[] ReadIntPart(string exp)
	{
		int[] numbers = new int[exp.Length];

		for (int i = 0; i<exp.Length; i++)
		{
			if (exp[i] == '.' || exp[i] == ',')
			{
				floatPosition = i;
				break;
			}
			else
			{
				numbers[i] = numberConvert.ConvertTo(exp[i], i);
			}
		}

		return numbers;
	}
	private string IntToResult(int[] numbers)
	{
		int multiplier = 1;
		int tempValue = 0;
		string tempStr = "";
		string result = "";
		for (int i = floatPosition - 1; i >= 0; i--)
		{
			tempValue += numbers[i] * multiplier;
			multiplier *= startSystem;
		}

		while (tempValue >= endSystem)
		{
			tempStr = numberConvert.ConvertFrom(tempValue % endSystem);
			result = string.Concat(tempStr, result);
			tempValue = tempValue / endSystem;
		}
		tempStr = numberConvert.ConvertFrom(tempValue);
		result = tempStr + result;

		return result;

	}
}
