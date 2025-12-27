string[] text = ["L68", "L30", "R48", "L5", "R60", "L55", "L1", "L99", "R14", "L82"];

text = await File.ReadAllLinesAsync("01-Secret_Entrance/text.txt");
int password = 0;

password = Part1(text);
Console.WriteLine($"Password: {password}");

password = Part2(text);
Console.WriteLine($"Password: {password}");

static int CalculateDial(int lastNumber, int newNumber)
{
    return (lastNumber + newNumber) % 100;
}

static int Part1(string[] text)
{
    int password = 0;
    int number = 150;

    foreach (string line in text)
    {
        switch (line[0])
        {
            case 'L':
                number = CalculateDial(number, -int.Parse(line.Substring(1)));
                break;
            case 'R':
                number = CalculateDial(number, int.Parse(line.Substring(1)));
                break;
            default:
                break;
        }
        if (number == 0)
        {
            password++;
        }
    }

    return password;
}

static int Part2(string[] text)
{
    int password = 0;
    int number = 150;

    foreach (string line in text)
    {
        int value = int.Parse(line[1..]);
        bool crossesZero = false;

        switch (line[0])
        {
            case 'L':
                crossesZero = CrossesZero(number, -value);
                number = CalculateDial(number, -value);
                break;
            case 'R':
                crossesZero = CrossesZero(number, value);
                number = CalculateDial(number, value);
                break;
            default:
                break;
        }
        if (number == 0 || crossesZero)
        {
            password++;
        }
    }

    return password;
}

static bool CrossesZero(int start, int delta, int mod = 100)
{
    int sum = start + delta;

    if (sum == 0)
    {
        return false;
    }

    if (sum >= mod || sum < 0)
    {
        return true;
    }

    return false;
}
