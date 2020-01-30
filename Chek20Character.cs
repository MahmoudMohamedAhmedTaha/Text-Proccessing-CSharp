static string ChekTewinty(string text)
{
	int lengthText = text.Length;
	StringBuilder Addertext = new StringBuilder();
	Addertext.Append(text);
	if(Addertext.Length < 20)
	{
		for(int counter =0;  counter < ( 20 -text.Length);  counter++)
		{
			Addertext.Append("*");
			Console.WriteLine(20 - Addertext.Length);
			
		}
		return Addertext.ToString();
	}
	else if(lengthText > 20)
	{
		string errorMessage=" Error input string you must Enter 20 character only!";
		return errorMessage;
	}
	return text;
}
