internal class NumberSystemFloatConvert:NumberSystemConvert
{
	int startSystem = 0;
	int endSystem = 0;
	int accuracy = 0;
	NumberConvert numConv;
	FloatPointPositionController floatPosition;

	public NumberSystemFloatConvert(int startSystem, int endSystem, int accuracy, NumberConvert numberConvert, FloatPointPositionController floatPositionController)
	{
		this.startSystem = startSystem;
		this.endSystem = endSystem;
		this.accuracy = accuracy;
		this.numConv = numberConvert;
		this.floatPosition = floatPositionController;
	}

	public override string Convert(string exp)
	{
		double floatExp = 0;
		double floatMult = 1;
		string result = "";

		for (int i = floatPosition.FloatPosition + 1; i < exp.Length; i++)
		{
			floatMult /= (double)startSystem;
			floatExp += numConv.ConvertTo(exp[i]) * floatMult;
		}

		for (int i = 0; i < accuracy; i++)
		{
			floatExp *= endSystem;
			result += numConv.ConvertFrom((int)Math.Floor(floatExp));
			floatExp -= Math.Floor(floatExp);
		}
		return result;
	}
}
