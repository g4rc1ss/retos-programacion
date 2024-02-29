using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reflection.Metadata.Ecma335;
using System.Text;

public class HangmanState
{
    public string MaskedWord { get; }
    public ImmutableHashSet<char> GuessedChars { get; }
    public int RemainingGuesses { get; }

    public HangmanState(string maskedWord, ImmutableHashSet<char> guessedChars, int remainingGuesses)
    {
        MaskedWord = maskedWord;
        GuessedChars = guessedChars;
        RemainingGuesses = remainingGuesses;
    }
}

public class TooManyGuessesException : Exception
{
}

public class Hangman
{
    public IObservable<HangmanState> StateObservable { get; init; }
    public IObserver<char> GuessObserver { get; init; }

    public Hangman(string word)
    {
        StateObservable = new BehaviorSubject<HangmanState>(new HangmanState(new string('_', word.Length), ImmutableHashSet<char>.Empty, 9));

        GuessObserver = Observer.Create<char>(x =>
        {
            var hangman = (BehaviorSubject<HangmanState>)StateObservable;
            var guessedChars = hangman.Value.GuessedChars.Add(x);
            if (hangman.Value.RemainingGuesses <= 0)
            {
                hangman.OnError(new TooManyGuessesException());
                return;
            }
            var maskedWord = MatchMaskedWord(x, hangman.Value.MaskedWord, word);
            if (maskedWord == word)
            {
                hangman.OnCompleted();
                return;
            }
            hangman.OnNext(new HangmanState(maskedWord, guessedChars, maskedWord == hangman.Value.MaskedWord ? hangman.Value.RemainingGuesses - 1 : hangman.Value.RemainingGuesses));
        });
    }

    private string MatchMaskedWord(char letter, string hangmanMasked, string origWord)
    {
        var newWord = new StringBuilder();
        for (int i = 0; i < hangmanMasked.Length; i++)
        {
            if (letter == origWord[i])
            {
                newWord.Append(letter);
            }
            else
            {
                newWord.Append(hangmanMasked[i]);
            }
        }

        return newWord.ToString();
    }
}
