string[] CreateNewMass(string[] mass)
{
    int count = 0;
    foreach (string mas in mass)
    {
        char[] massChar = mas.ToCharArray();
        if (massChar.Length <= 3)
            count++;
    }
    string[] newMass = new string[count];
    count = 0;
    foreach (string mas in mass)
    {
        char[] massChar = mas.ToCharArray();
        if (massChar.Length <= 3)
        {
            newMass[count] = mas;
            count++;
        }
    }
    return newMass;
}

string[] massTest_1 = { "Hello", "2", "world", ":-)" };
string[] massTest_2 = { "1234", "1567", "-2", "computer science" };
string[] massTest_3 = { "HRussia", "Denmark", "Kazan" };

Console.WriteLine(String.Join(",", CreateNewMass(massTest_1)));
Console.WriteLine(String.Join(",", CreateNewMass(massTest_2)));
Console.WriteLine(String.Join(",", CreateNewMass(massTest_3)));

