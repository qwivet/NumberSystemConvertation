﻿Console.OutputEncoding = System.Text.Encoding.Default;

string[] outputs = new string[DataStorage.Inputs.Length];
ConsoleInOut consoleInOut = new ConsoleInOut(DataStorage.Inputs, outputs, DataStorage.CheckConditions);
consoleInOut.WriteReadCycle();

MainCalculations calc = new MainCalculations
	(Convert.ToInt32(outputs[0]),Convert.ToInt32(outputs[1]),
	Convert.ToInt32(outputs[2]),outputs[3]);

Console.WriteLine(calc.Execute());