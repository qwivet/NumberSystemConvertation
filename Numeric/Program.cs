Console.OutputEncoding = System.Text.Encoding.Default;

//Ініціалізація інпутів
Console.Write("Система числення вхідного виразу (від 2 до 16): ");
int firstSystem = Convert.ToInt32(Console.ReadLine());
Console.Write("Система числення вихідного виразу (від 2 до 16): ");
int secondSystem = Convert.ToInt32(Console.ReadLine());
Console.Write("Точність (знаків після коми): ");
int accuracy = Convert.ToInt32(Console.ReadLine());
Console.Write("Вираз: ");
string? expression = Console.ReadLine();

//Ініціалізація
NumberConvert numberConvert = new NumberConvert();
FloatPointPositionController floatPosition = new FloatPointPositionController();
NumberSystemIntConvert intPartResult;
string answer = "";


//Ціла частина
intPartResult = new NumberSystemIntConvert(firstSystem, secondSystem, numberConvert, floatPosition);
answer += intPartResult.Convert(expression);


//Якщо дробове
if (!floatPosition.IsFloat(answer.Length))
{
	NumberSystemFloatConvert floatPartResult = new NumberSystemFloatConvert(firstSystem, secondSystem, accuracy, numberConvert, floatPosition);
	answer += '.';
	answer += floatPartResult.Convert(expression);

}

//Вивід
Console.WriteLine(answer);