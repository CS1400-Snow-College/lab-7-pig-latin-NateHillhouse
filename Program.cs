/*
Nathan Hillhouse
10/21/2025
Lab 7 - Pig Latin Encoder

/*
comment Add a comment to the top of your source code with the names of the authors, the date, and the name of the lab. 
(Remember to commit the change.)

greeting Print a greeting and description of the program to the user. 
(Remember to commit the change.)

Collect a string: Get a string from the user to manipulate, then split it into an array of words.

Convert each word into Pig Latin: When looking at the first character of each word, 
consider the command 'contains' it may save you some trouble

Print the phrase in Pig Latin

Get an offset: You can just assign an offset of '5', but a random number generator is so much more interesting. 
Random rand = new Random(); int randomOffset = rand.Next(1,26); should help you get a random number between 1 and 25 (26 is just a full lap)

Offset each character of each word: 
char letter = (char)97; //will make letter into an 'a'.  
letter = (char)((int)letter + 1); // if letter is an 'a', it will become a 'b'

Print out the offset phrase
*/

