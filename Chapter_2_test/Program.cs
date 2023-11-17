// See https://aka.ms/new-console-template for more information
Console.WriteLine ($"default(int) = {default(int)}");
Console.WriteLine ($"default(bool) = {default(bool)}");
Console.WriteLine ($"default(DateTime) = {default(DateTime)}");
Console.WriteLine ($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");

/* ============================= */

string[] names = new string[4];
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";
for (int i=0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);    
}

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
Console.WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);
string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);
//WriteToFile (formatted);

Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

const string firstname = "Omar";
const string lastname = "Rudberg";
string fullname = $"{firstname} {lastname}";

Console.WriteLine($"{fullname}");

/*============*/
string applesText = "Apples";
int applesCount = 1234;
string bananaText = "Bananas";
int bananasCount = 56789;

Console.WriteLine (
    format: "{0, -10} {1,6}",
    arg0: "Name",
    arg1: "Count"
);
Console.WriteLine (
    format: "{0, -10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount
);
Console.WriteLine (
    format: "{0, -10} {1,6:N0}",
    arg0: bananaText,
    arg1: bananasCount
);


/*=============*/
Console.Write("Type your first namd and press ENTER: ");
string? firstName = Console.ReadLine();
Console.Write("Type your age and press ENTER: ");
string? age = Console.ReadLine();
Console.WriteLine ($"Hello {firstName}, you look good for {age}.");