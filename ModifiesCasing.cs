static string ModifiesCasing(string text, string startTag, string endTag)
{
	int StartIndex = text.IndexOf(startTag);
	int LastIndex = text.IndexOf(endTag);
	StringBuilder upcase = new StringBuilder();
	for(int counter=0; counter < text.Length; counter++ )
	{
		
		for(int count = StartIndex+startTag.Length; count < LastIndex; count++)
		{
			upcase.Append(text[count]); 
			//Console.WriteLine(upcase);
		}
		text = text.Replace(startTag + upcase.ToString() + endTag, (upcase.ToString().ToUpper()));
		StartIndex = text.IndexOf(startTag,StartIndex+startTag.Length);
		LastIndex = text.IndexOf(endTag);
		upcase.Clear();
	}
	return text;
}
