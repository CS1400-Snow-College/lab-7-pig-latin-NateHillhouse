/*
Nathan Hillhouse
10/21/2025
Lab 7 - Pig Latin Encoder
*/


Console.Clear();
Console.WriteLine("Welcome to the Pig Latin Encoder! This will take your message and encode it.");
Console.WriteLine();
Console.Write("What message would you like to encode? ");
string? message = Console.ReadLine();

char[] vowel = { 'a', 'e', 'i', 'o', 'u' };

string[] splitMessage = message.Split();
foreach (string word in splitMessage) PigLatin(word);

void PigLatin(string word)
{
    bool startsWithVowel = false, endsWithVowel = false;
    foreach (char item in vowel) 
    {
        if (word.StartsWith(item)) startsWithVowel = true;
        if (word.EndsWith(item)) endsWithVowel = true;
    }

    if (startsWithVowel && endsWithVowel) word += "way";
    else if (startsWithVowel) word += "ay";
    else
    {
        string[] splitWord = word.Split();
    }



    Console.Write(word);
}




/*
1) Pig Latin rules: If your word starts with a consonant, or a consonant cluster, move the cluster to the end and add AY, so Frank becomes ankfray.
 If your word begins with a vowel and ends with a vowel just add 'way', so apple becomes appleway

2) Cryptogram rules: find a shift amount (you can just assign say '5' or you can use a random number generator) 
and slide every character by that far on the ascii scale, so if we choose 5, apple would become fuuqj, and zoo would become ett.

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

