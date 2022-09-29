public delegate bool Condition(string input);
class ConsoleInOut
{
	private string[] inputs;
	private string[] outputs;
	private Condition[] checkConditions;

	public ConsoleInOut(string[] inputs, string[] outputs, Condition[] checkConditions)
	{
		if (inputs.Length != checkConditions.Length)
		{
			throw new Exception("Different size of data arrays");
		}
		this.inputs = inputs;
		this.outputs = outputs;
		this.checkConditions = checkConditions;
	}

	public void WriteReadCycle()
	{
		for (int i = 0; i < inputs.Length; i++)
		{
			bool isCorrect = false;
			while (!isCorrect)
			{
				Console.Write(inputs[i]);
				outputs[i] = Console.ReadLine();
				isCorrect = checkConditions[i](outputs[i]);
				if (!checkConditions[i](outputs[i]))
				{
					Console.WriteLine("Incorrect input");
				}
			}
		}

	}
}