﻿// For more information see https://aka.ms/fsharp-console-apps
int numberOfApples = 12;
decimal pricePerApple = 0.35M;
Console.WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApples * numberOfApples
);
string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);
//WriteToFile (formatted);