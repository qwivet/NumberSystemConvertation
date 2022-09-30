Console.OutputEncoding = System.Text.Encoding.Default;
bool isContinue = true;
while (isContinue)
{
	string[] outputs = new string[DataStorage.Inputs.Length];
	ConsoleInOut consoleInOut = new ConsoleInOut(DataStorage.Inputs, outputs, DataStorage.CheckConditions);
	consoleInOut.WriteReadCycle();

	MainCalculations calc = new MainCalculations
		(Convert.ToInt32(outputs[0]), Convert.ToInt32(outputs[1]),
		Convert.ToInt32(outputs[2]), outputs[3],
		new InputConvert(outputs[3]));

	Console.WriteLine(string.Concat("\nРезультат:\t\t\t\t\t\t", calc.Execute()));

	Console.Write("Чи хочете ви продовжити:\t\t\t\t");
	string contAnswer = Console.ReadLine();
	isContinue = contAnswer == "Yes" || contAnswer == "+" || contAnswer == "1" || contAnswer == "Continue" || contAnswer == "Продовжити" || contAnswer == "Так" || contAnswer == "Ок" || contAnswer == "Ok";
}

Console.WriteLine("Дякую за використання програми конвертації чисел в інші системи числення");