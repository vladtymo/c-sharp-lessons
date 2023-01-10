string text = "How are you?end. red";

Console.WriteLine($"[2]: {text[2]}"); // w
Console.WriteLine("Length: " + text.Length);

if (text.Contains("you"))
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

// How
// are
// you
// end
// red

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

int spaces = 0, uppers = 0;

for (int i = 0; i < message.Length; ++i)
{
    if (message[i] == ' ')
    {
        ++spaces;
    }
    if (char.IsUpper(message[i]))
    {
        ++uppers;
    }
}

Console.WriteLine("Spaces: " + spaces);
Console.WriteLine("Upper letters: " + uppers);

// Відобразити повідомлення справа наліво

Console.WriteLine("Original: " + message);

// [H][o][w][ ][a][r][e][ ][y][o][u]

Console.Write("Reversed: ");
for (int i = message.Length - 1; i >= 0; --i)
{
    Console.Write(message[i]);
}
Console.WriteLine();

// Завдання: Користувач вводить повідомлення, якщо воно закінчується на '!',
// тоді відобразити у верхньому регістрі.

Console.Write("Enter a message: ");
message = Console.ReadLine(); // Hello

if (message[message.Length - 1] == '!')
{
    Console.WriteLine(message.ToUpper());
}
else
{
    Console.WriteLine(message);
}