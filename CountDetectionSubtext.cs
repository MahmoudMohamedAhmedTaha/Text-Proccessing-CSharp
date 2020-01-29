static int DetectionSubstring(string text, string keyword)
{
  //intialize counter
	int counter = 1;
  // intialize index of keyword 
	int index = text.IndexOf(keyword);
  //itrate to count repetation of keyword in the text
	while(index!= -1)
	{
    //increae counter one when we found keyowrd 
		counter++;
    //intialize index to next position aftr keyword was founded
		index = text.IndexOf(keyword, index+1);
		
	}
  //return counter
	return counter;
}
