Console.OutputEncoding = System.Text.Encoding.Default;

string[] outputs = new string[4];
ConsoleInOut consoleInOut = new ConsoleInOut(DataStorage.Inputs, outputs, DataStorage.CheckConditions);
consoleInOut.WriteReadCycle();

int firstSystem = Convert.ToInt32(outputs[0]);
int secondSystem = Convert.ToInt32(outputs[1]);
int accuracy = Convert.ToInt32(outputs[2]);
string expression = outputs[3];

NumberConvert numberConvert = new NumberConvert();
FloatPointPositionController floatPosition = new FloatPointPositionController();
string answer = "";

NumberSystemIntConvert intPartResult;
intPartResult = new NumberSystemIntConvert(firstSystem, secondSystem, numberConvert, floatPosition);
answer += intPartResult.Convert(expression);

if (floatPosition.IsFloat(expression.Length))
{
	NumberSystemFloatConvert floatPartResult = new NumberSystemFloatConvert(firstSystem, secondSystem, accuracy, numberConvert, floatPosition);
	answer += '.';
	answer += floatPartResult.Convert(expression);

}

Console.WriteLine(answer);