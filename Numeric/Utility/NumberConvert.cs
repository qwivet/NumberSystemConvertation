public class NumberConvert : Convert<int, string>
{
	private string[] intToStrDict = new string[16] 
		{"0", "1", "2", "3", "4", "5", "6", "7", 
		"8", "9", "A", "B", "C", "D", "E", "F"};
	private Dictionary <string, int> strToIntDict = new Dictionary <string, int>()
		{{"0", 0}, {"1", 1}, {"2", 2}, {"3", 3}, 
		{"4", 4}, {"5", 5}, {"6", 6}, {"7", 7}, 
		{"8", 8}, {"9", 9}, {"A", 10}, {"B", 11}, 
		{"C", 12}, {"D", 13}, {"E", 14}, {"F", 15}};
	public override string ConvertFrom (int i)
	{
		if (i >= 0 && i < 16)
		{
			return intToStrDict[i];
		}
		throw new Exception("Incorrect input");
	}
	public override int ConvertTo(string i)
	{
		string upperChar = i.ToUpper();
		if (strToIntDict.ContainsKey(upperChar))
		{
			return strToIntDict[upperChar];
		}
		throw new Exception("Incorrect app convertation");
	}
	public int ConvertTo(char i)
	{
		return ConvertTo(i.ToString());
	}
}