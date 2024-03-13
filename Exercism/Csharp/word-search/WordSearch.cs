using System;
using System.Collections.Generic;
using System.Linq;

public class WordSearch
{
    private readonly List<List<char>> _grid;
    public WordSearch(string grid)
    {
        _grid = GetGrid(grid);
    }

    private List<List<char>> GetGrid(string grid)
    {
        var gridList = new List<List<char>>();

        foreach (var line in grid.Split('\n'))
        {
            var rows = new List<char>();
            foreach (var letters in line)
            {
                rows.Add(letters);
            }
            gridList.Add(rows);
        }

        return gridList;
    }

    public Dictionary<string, ((int, int), (int, int))?> Search(string[] wordsToSearchFor)
    {
        foreach (var wordToSearch in wordsToSearchFor)
        {
            
        }
    }
}