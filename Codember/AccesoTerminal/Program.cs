const string Combination = "URDURUDRUDLLLLUUDDUDUDUDLLRRRR";
const string numbers = "528934712834";

List<int> finalNumbers = [.. numbers.Select(x => int.Parse(x.ToString()))];

int index = 0;
foreach (char c in Combination)
{
    switch (c)
    {
        case 'R':
            index += 1 % finalNumbers.Count;
            break;
        case 'L':
            index = ((index - 1) + finalNumbers.Count) % finalNumbers.Count;
            break;
        case 'U':
            finalNumbers[index] = (finalNumbers[index] + 1) % 10;
            break;
        case 'D':
            finalNumbers[index] = (finalNumbers[index] - 1 + 10) % 10;
            break;
        default:
            break;
    }
}

foreach (int finalNumber in finalNumbers)
{
    Console.Write(finalNumber);
}
