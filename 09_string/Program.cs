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

string[] words = text.Split(' ', ',', '.', '?', '!');

for (int i = 0; i < words.Length; ++i)
{
    Console.WriteLine(words[i]);
}