namespace _09_disk_fragmenter;

public class Exercise()
{
    public long Part1(string[] textLines)
    {
        long finalResult = 0;

        foreach (var line in textLines)
        {
            var blocksWithSpaces = GetBlocksWithSpaces(line);
            var compressed = CompressBlocks(blocksWithSpaces);

            finalResult += CalculateChecksum(compressed);

            Console.WriteLine(string.Join("", blocksWithSpaces));
            Console.WriteLine(string.Join("", compressed));
        }

        return finalResult;
    }

    private long CalculateChecksum(List<string> compressed)
    {
        long checksum = 0;
        for (var i = 0; i < compressed.Count; i++)
        {
            long.TryParse(compressed[i], out var compressedValue);
            checksum += compressedValue * i;
        }

        return checksum;
    }

    private static List<string> GetBlocksWithSpaces(string line)
    {
        var id = 0;
        var blocksWithSpaces = new List<string>();
        var isFreeSpace = false;
        foreach (var digit in line)
        {
            int.TryParse(digit.ToString(), out var number);
            for (var i = 0; i < number; i++)
            {
                blocksWithSpaces.Add(isFreeSpace ? "." : id.ToString());
            }

            if (isFreeSpace) id++;
            isFreeSpace = !isFreeSpace;
        }

        return blocksWithSpaces;
    }

    private static List<string> CompressBlocks(List<string> blocks)
    {
        var copiedBlocks = new List<string>(blocks);
        var countFreeSpaces = blocks.Count(x => x == ".");
        var cleanBlocks = blocks.Where(x => x != ".")
            .Reverse().ToList();
        var compressedBlocks = new List<string>();

        for (int i = 0; i < copiedBlocks.Count; i++)
        {
            var block = copiedBlocks[i];
            if (compressedBlocks.Count == blocks.Count - countFreeSpaces)
            {
                break;
            }

            if (block == ".")
            {
                var blockToAdd = cleanBlocks[0];
                cleanBlocks.RemoveAt(0);
                compressedBlocks.Add(blockToAdd);
                copiedBlocks.RemoveAt(copiedBlocks.Count - 1);
                continue;
            }

            compressedBlocks.Add(block);
        }

        return compressedBlocks;
    }

    public long Part2(string[] textLines)
    {
        long finalResult = 0;


        return finalResult;
    }
}