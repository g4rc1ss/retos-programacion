var Input = await File.ReadAllLinesAsync("./input.txt");
var gaurdCoord = Input.SelectMany((x, i) => x.Select((y, j) =>
{
    if (y == '^')
    {
        return new Coordinate(i, j);
    }

    return null;
})).Single(x => x is not null);

var rowLen = Input.Length;
var colLen = Input[0].Length;
var result = 0;
var direction = Direction.Up;
var seen = new HashSet<Coordinate>();
var tempGaurdCoord = gaurdCoord!;

Part1();
Part2();


void Part1()
{
    while (IsInGrid(tempGaurdCoord, rowLen, colLen))
    {
        if (Input[tempGaurdCoord.Row][tempGaurdCoord.Col] == '#')
        {
            tempGaurdCoord = GetPrevCoordinate(tempGaurdCoord, direction);
            direction = GetNextDirection(direction);
        }
        else if (seen.Add(tempGaurdCoord))
        {
            result++;
        }

        tempGaurdCoord = GetNextCoordinate(tempGaurdCoord, direction);
    }

    Console.WriteLine(result);
}

void Part2()
{
// Part 2
    result = 0;
    var tempInput = Input.Select(x => x.Select(y => y).ToArray()).ToArray();

    foreach (var coordinates_evaluated in seen)
    {
        var i = coordinates_evaluated.Row;
        var j = coordinates_evaluated.Col;

        var temp = tempInput[i][j];
        if (temp == '#')
        {
            continue;
        }

        tempInput[i][j] = 'O';
        tempGaurdCoord = gaurdCoord!;
        direction = Direction.Up;
        if (IsCycle(tempGaurdCoord, direction, rowLen, colLen, tempInput))
        {
            result++;
        }

        tempInput[i][j] = temp;
    }


    Console.WriteLine(result);
}

static Coordinate GetNextCoordinate(Coordinate coord, Direction direction) => direction switch
{
    Direction.Up => coord with { Row = coord.Row - 1 },
    Direction.Down => coord with { Row = coord.Row + 1 },
    Direction.Left => coord with { Col = coord.Col - 1 },
    Direction.Right => coord with { Col = coord.Col + 1 },
    _ => throw new NotImplementedException(),
};

static Coordinate GetPrevCoordinate(Coordinate coord, Direction direction) => direction switch
{
    Direction.Up => coord with { Row = coord.Row + 1 },
    Direction.Down => coord with { Row = coord.Row - 1 },
    Direction.Left => coord with { Col = coord.Col + 1 },
    Direction.Right => coord with { Col = coord.Col - 1 },
    _ => throw new NotImplementedException(),
};

static Direction GetNextDirection(Direction direction) => direction switch
{
    Direction.Up => Direction.Right,
    Direction.Right => Direction.Down,
    Direction.Down => Direction.Left,
    Direction.Left => Direction.Up,
    _ => throw new NotImplementedException(),
};

static bool IsInGrid(Coordinate coord, int rowLen, int colLen) =>
    0 <= coord.Row && coord.Row < rowLen && 0 <= coord.Col && coord.Col < colLen;

static bool IsCycle(Coordinate gaurdCoord, Direction direction, int rowLen, int colLen, char[][] input)
{
    var seenObstacle = new HashSet<(Coordinate, Direction)>();
    while (IsInGrid(gaurdCoord, rowLen, colLen))
    {
        if (input[gaurdCoord.Row][gaurdCoord.Col] == '#'
            || input[gaurdCoord.Row][gaurdCoord.Col] == 'O')
        {
            if (!seenObstacle.Add((gaurdCoord, direction)))
            {
                return true;
            }

            gaurdCoord = GetPrevCoordinate(gaurdCoord!, direction);
            direction = GetNextDirection(direction);
        }

        gaurdCoord = GetNextCoordinate(gaurdCoord!, direction);
    }

    return false;
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}

public sealed record Coordinate(int Row, int Col);