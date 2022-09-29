Console.OutputEncoding = System.Text.Encoding.Default;

string[] outputs = new string[DataStorage.Inputs.Length];
ConsoleInOut consoleInOut = new ConsoleInOut(DataStorage.Inputs, outputs, DataStorage.CheckConditions);
consoleInOut.WriteReadCycle();

int firstSystem = Convert.ToInt32(outputs[0]);
int secondSystem = Convert.ToInt32(outputs[1]);
int accuracy = Convert.ToInt32(outputs[2]);
string expression = outputs[3];
int floatPosition = 0;


NumberConvert numberConvert = new NumberConvert();
IntConvert intPartResult;
intPartResult = new IntConvert(firstSystem, secondSystem, numberConvert);
string answer = "";
answer = string.Concat(answer, intPartResult.Convert(expression, ref floatPosition));

if (floatPosition != expression.Length)
{
	FloatConvert floatPartResult = new FloatConvert(firstSystem, secondSystem, accuracy, numberConvert);
	answer = string.Concat(answer, '.');
	answer += floatPartResult.Convert(expression, ref floatPosition);

}

Console.WriteLine(answer);