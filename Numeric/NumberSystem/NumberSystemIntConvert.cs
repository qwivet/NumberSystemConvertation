using System.IO;

class NumberSystemIntConvert : NumberSystemConvert
{
	int startSystem = 0;
	int endSystem = 0;
	NumberConvert numConv;
	FloatPointPositionController floatPosition;

	public NumberSystemIntConvert (int startSystem, int endSystem, NumberConvert numberConvert, FloatPointPositionController floatPositionController)
	{
		this.startSystem = startSystem;
		this.endSystem = endSystem;
		this.numConv = numberConvert;
		this.floatPosition = floatPositionController;
	}

	public override string Convert(string exp)
	{

		int[] numbers = ReadIntPart(exp);

		floatPosition.FloatPosition = 
			floatPosition.FloatPosition == -1 ? 
			numbers.Length : floatPosition.FloatPosition;

		return IntToResult(numbers);
	}

	private int[] ReadIntPart(string exp)
	{
		int[] numbers = new int[exp.Length];

		for (int i = 0; i<exp.Length; i++)
		{
			if (exp[i] == '.' || exp[i] == ',')
			{
				floatPosition.FloatPosition = i;
				break;
			}
			else
			{
				numbers[i] = numConv.ConvertTo(exp[i]);
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
		for (int i = floatPosition.FloatPosition - 1; i >= 0; i--)
		{
			tempValue += numbers[i] * multiplier;
			multiplier *= startSystem;
		}

		while (tempValue >= endSystem)
		{
			tempStr = numConv.ConvertFrom(tempValue % endSystem);
			result = tempStr + result;
			tempValue = tempValue / endSystem;
		}
		tempStr = numConv.ConvertFrom(tempValue);
		result = tempStr + result;

		return result;

	}
}
