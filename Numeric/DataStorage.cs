public static class DataStorage
{
	private static readonly Condition[] checkConditions = new Condition[]
	{
	(x) => { return 2 <= Convert.ToInt32(x) && Convert.ToInt32(x) <= 16; },
	(x) => { return 2 <= Convert.ToInt32(x) && Convert.ToInt32(x) <= 16; },
	(x) => { return 0 <= Convert.ToInt32(x) && Convert.ToInt32(x) <= 99; },
	(x) => { return true; }
	};
	private static readonly string[] inputs = new string[4]
	{
	"Система числення вхідного виразу (від 2 до 16): ",
	"Система числення вихідного виразу (від 2 до 16): ",
	"Точність (знаків після коми): ",
	"Вираз: "
	};

	public static string[] Inputs => inputs;

	public static Condition[] CheckConditions => checkConditions;
}
