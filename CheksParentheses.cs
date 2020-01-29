static int ChecksPranetheses(string text)
        {
        
            //intialize count to zero
            int count = 0;
            //loop to every character
            for (int index = 0; index<text.Length; index++)
            {
                //if found open parenthes increase count to one 
                if (text[index].ToString().Equals("("))
                {
                    count++;
                }
                //if found closed parenthes decrease count to one
                if (text[index].ToString().Equals(")"))
                {
                    count--;
                }
                

            }
            // return count
            return count;
        }
