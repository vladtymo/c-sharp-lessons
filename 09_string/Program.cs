string text = "How are you?end. red";

Console.WriteLine($"[2]: {text[2]}"); // w
Console.WriteLine("Length: " + text.Length);

if (text.Contains("me"))
{
    Console.WriteLine("Word 'you' was found!");
}
else Console.WriteLine("Not found!");

Console.WriteLine($"Lower letters: {text.ToLower()}");
Console.WriteLine("Upper letters: " + text.ToUpper());

Console.Write("Enter your email address: ");
string email = Console.ReadLine();

Console.WriteLine($"Your address is |{email}|");
Console.WriteLine($"Trimmed email: |{email.Trim()}|");

string[] words = text.Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("Words:");
for (int i = 0; i < words.Length; ++i)
{
    Console.WriteLine(words[i]);
}

string joined = string.Join("-", words);
Console.WriteLine("Joined string: " + joined);

// Завдання: обрахувати к-сть пробілів в рядку

Console.Write("Enter a message: ");
string message = Console.ReadLine();

int spaces = 0;

for (int i = 0; i < message.Length; ++i)
{
    if (message[i] == ' ')
    {
        ++spaces;
    }
}

Console.WriteLine("Spaces: " + spaces);

// Відобразити повідомлення справа наліво

Console.WriteLine("Original: " + message);

// [H][o][w][ ][a][r][e][ ][y][o][u]

Console.Write("Reversed: ");
for (int i = message.Length - 1; i >= 0; --i)
{
    Console.Write(message[i]);
}
