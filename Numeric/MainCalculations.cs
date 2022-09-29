internal class MainCalculations
{
	private int firstSystem;
	private int secondSystem;
	private int accuracy;
	private string expression;
	NumberConvert numberConvert;

	int floatPosition = 0;

	public MainCalculations(int firstSystem, int secondSystem, int accuracy, string expression)
	{
		this.firstSystem = firstSystem;
		this.secondSystem = secondSystem;
		this.accuracy = accuracy;
		this.expression = expression;
		numberConvert = new NumberConvert();
	}

	public NumberConvert NumberConvert { set => numberConvert = value; }

	public string Execute ()
	{
		string answer = IntPart();
		if (floatPosition != expression.Length)
		{
			answer = string.Concat(answer, FloatPart());
		}
		return answer;
	}

	private string IntPart()
	{
		IntConvert intPartResult = new IntConvert(firstSystem, secondSystem, numberConvert);
		return intPartResult.Convert(expression, ref floatPosition);
	}
	private string FloatPart()
	{
			FloatConvert floatPartResult = new FloatConvert(firstSystem, secondSystem, accuracy, numberConvert);
			return string.Concat('.', floatPartResult.Convert(expression, ref floatPosition));

	}
}