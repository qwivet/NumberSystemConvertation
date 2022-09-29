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
//
//
//
// ПЕРЕРОБИТИ БЛЯТЬ, ЩОБ ПІСЛЯ НЕПРАВИЛЬНОГО ВВОДУ ПОВТОРИЛО ПИТАННЯ
//
//
//
	public void WriteReadCycle()
	{
		for (int i = 0; i < inputs.Length; i++)
		{
			Console.Write(inputs[i]);
			outputs[i] = Console.ReadLine();
			if (!checkConditions[i](outputs[i]))
			{
				throw new Exception("Incorrect input");
			}

		}

	}
}