static string ReverseText(string phase)
{
	//create string builder object to save reverse text 
	StringBuilder reversePhase = new StringBuilder();
	//loop in every element in text that will be reversed
	for(int index = phase.Length-1; index>=0; index--)
	{
		//save character of the text backworded
		reversePhase.Append(phase[index]);
	}
	//return reversed text
	return reversePhase.ToString();
}
