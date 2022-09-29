public static class DataStorage
{
	private static readonly Condition[] checkConditions = new Condition[]
	{
	(x) => { try { return 2 <= Convert.ToInt32(x) && Convert.ToInt32(x) <= 16; } catch{ return false; } },
	(x) => { try { return 2 <= Convert.ToInt32(x) && Convert.ToInt32(x) <= 16; } catch{ return false; } },
	(x) => { try { return 0 <= Convert.ToInt32(x) && Convert.ToInt32(x) <= 99; } catch{ return false; } },
	(x) => { return true; }
	};
	private static readonly string[] inputs = new string[4]
	{
	"Система числення вхідного виразу (від 2 до 16):\t\t",
	"Система числення вихідного виразу (від 2 до 16):\t",
	"Точність (знаків після коми):\t\t\t\t",
	"Вираз:\t\t\t\t\t\t\t"
	};

	public static string[] Inputs => inputs;

	public static Condition[] CheckConditions => checkConditions;
}
