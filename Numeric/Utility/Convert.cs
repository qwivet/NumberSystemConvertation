public abstract class Convert <N, M>
{
	public abstract N ConvertTo(M i);
	public abstract M ConvertFrom(N i);
}