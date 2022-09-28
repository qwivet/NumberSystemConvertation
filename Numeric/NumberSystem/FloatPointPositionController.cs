//Якщо не важко, підкажи пж, як зберігати посилання на об'єкт в окремій змінній в C#,
//бо якби я знав, тут був би не класс, а структура

class FloatPointPositionController
{
	int floatPosition = -1;

	public int FloatPosition { get => floatPosition; set => floatPosition = value; }
	public bool IsFloat (int length) { return floatPosition != length; }
}