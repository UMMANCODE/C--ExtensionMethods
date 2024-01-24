using ConsoleApp24;

int number = 5;
Console.WriteLine($"{number} is odd: {number.IsOdd()}"); // Output: True
Console.WriteLine($"{number} is even: {number.IsEven()}"); // Output: False

// IsContainsDigit
string textWithDigit = "abc123";
string textWithoutDigit = "abcdef";
Console.WriteLine($"{textWithDigit} contains digit: {textWithDigit.IsContainsDigit()}"); // Output: True
Console.WriteLine($"{textWithoutDigit} contains digit: {textWithoutDigit.IsContainsDigit()}"); // Output: False

// ToCapitalize
string lowercaseText = "hello world";
Console.WriteLine($"Original: {lowercaseText}, Capitalized: {lowercaseText.ToCapitalize()}"); // Output: Original: hello world, Capitalized: Hello world

// GetValueIndexes
string textToSearch = "abracadabra";
char charToFind = 'a';
int[] indexes = textToSearch.GetValueIndexes(charToFind);
Console.WriteLine($"Indexes of '{charToFind}' in '{textToSearch}':");
for (int i = 0; i < indexes.Length; i++)
    Console.Write($"{indexes[i]} "); // Output: Indexes of 'a' in 'abracadabra': 0, 3, 5, 7, 10
Console.WriteLine();    

// GetFirstSentence
string multiSentenceText = "This is the first sentence. And this is the second sentence.";
string firstSentence = multiSentenceText.GetFirstSentence();
Console.WriteLine($"First sentence: {firstSentence}"); // Output: First sentence: This is the first sentence

// GetSecondWord
string sentenceWithMultipleWords = "The quick brown fox";
string secondWord = sentenceWithMultipleWords.GetSecondWord();
Console.WriteLine($"Second word: {secondWord}"); // Output: Second word: quick