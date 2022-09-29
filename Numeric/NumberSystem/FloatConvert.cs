internal class FloatConvert:NumberSystemConvert
{
	int accuracy = 0;

	public FloatConvert(int startSystem, int endSystem, int accuracy, InputConvert numberConvert)
	{
		this.startSystem = startSystem;
		this.endSystem = endSystem;
		this.accuracy = accuracy;
		this.numberConvert = numberConvert;
	}

	public override string Convert(string exp, ref int floatPos)
	{
		double floatExp = 0;
		double floatMult = 1;
		string result = "";

		for (int i = floatPos + 1; i < exp.Length; i++)
		{
			floatMult /= (double)startSystem;
			floatExp += numberConvert.ConvertTo(exp[i], i) * floatMult;
		}

		for (int i = 0; i < accuracy; i++)
		{
			floatExp *= endSystem;
			result += numberConvert.ConvertFrom((int)Math.Floor(floatExp));
			floatExp -= Math.Floor(floatExp);
		}
		return result;
	}
}
