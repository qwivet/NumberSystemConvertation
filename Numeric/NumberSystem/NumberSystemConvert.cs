abstract class NumberSystemConvert
{
	protected int startSystem;
	protected int endSystem;
	protected NumberConvert numberConvert;
	protected int floatPosition;
	abstract public string Convert(string i, ref int floatPos);
}