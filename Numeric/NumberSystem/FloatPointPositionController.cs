class FloatPointPositionController
{
	int floatPosition = -1;

	public int FloatPosition { get => floatPosition; set => floatPosition = value; }
	public bool IsFloat (int length) { return floatPosition != length; }
}