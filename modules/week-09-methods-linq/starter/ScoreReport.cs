/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Andrew Anderson
- Assignment: Week 9: Score Stats (Methods + LINQ)
-
- What does this program do?:
- Defines a ScoreReport class students complete using LINQ methods.
- */

using System.Globalization;
using System.Linq;

namespace ScoreStats;

internal class ScoreReport
{
    private readonly int[] _scores;

    public ScoreReport(int[] scores, int threshold)
    {
        _scores = scores;
        Threshold = threshold;
    }

    public int Threshold { get; }

    public int Count => _scores.Length;

    // TODO 1: Implement PrintReport
    // This method orchestrates printing the full report.
    // Requirements:
    // - Call PrintBasicStats()
    // - Call PrintPassingFailingCounts()
    // - Print a blank line
    // - Call PrintScoresSorted()
    // - Call PrintTopScores(3)
    // - Call PrintPassingScores()
    // - Call PrintFailingScores()
    public void PrintReport()
    {
        PrintBasicStats();
        PrintPassingFailingCounts();
        Console.WriteLine();
        PrintScoresSorted();
        PrintTopScores(3);
        PrintPassingScores();
        PrintFailingScores();
    }

    // TODO 2: Implement PrintBasicStats
    // Requirements:
    // - Use _scores.Min() to get the minimum score
    // - Use _scores.Max() to get the maximum score
    // - Use _scores.Average() to get the average score
    // - Print exactly:
    //   Count: X
    //   Min: X
    //   Max: X
    //   Average: X.X  (format to 1 decimal place using CultureInfo.InvariantCulture)
    private void PrintBasicStats()
    {
        Console.WriteLine($"Count: {Count}");
        Console.WriteLine($"Min: {_scores.Min()}");
        Console.WriteLine($"Max: {_scores.Max()}");
        Console.WriteLine($"Average: {_scores.Average().ToString("F1", CultureInfo.InvariantCulture)}");
    }

    // TODO 3: Implement PrintPassingFailingCounts
    // Requirements:
    // - Use _scores.Count(score => score >= Threshold) for passing count
    // - Use _scores.Count(score => score < Threshold) for failing count
    // - Print exactly:
    //   Passing (>=threshold): X
    //   Failing (<threshold): X
    private void PrintPassingFailingCounts()
    {
        int passingCount = _scores.Count(score => score >= Threshold);
        int failingCount = _scores.Count(score => score < Threshold);
        Console.WriteLine($"Passing (>={Threshold}): {passingCount}");
        Console.WriteLine($"Failing (<{Threshold}): {failingCount}");
    }

    // TODO 4: Implement PrintScoresSorted
    // Requirements:
    // - Use _scores.OrderBy(score => score) to sort ascending
    // - Use string.Join(", ", sorted) to format the scores
    // - Print exactly: Sorted (asc): 10, 20, 30
    private void PrintScoresSorted()
    {
        IOrderedEnumerable<int> sorted = _scores.OrderBy(score => score);
        Console.WriteLine($"Sorted (asc): {string.Join(", ", sorted)}");
    }

    // TODO 5: Implement PrintTopScores
    // Requirements:
    // - Chain: _scores.OrderByDescending(score => score).Take(topCount)
    // - Use string.Join(", ", top) to format
    // - Print exactly: Top X: 30, 20, 10
    private void PrintTopScores(int topCount)
    {
        IEnumerable<int> top = _scores.OrderByDescending(score => score).Take(topCount);
        Console.WriteLine($"Top {topCount}: {string.Join(", ", top)}");
    }

    // TODO 6: Implement PrintPassingScores
    // Requirements:
    // - Chain: _scores.Where(score => score >= Threshold).OrderByDescending(score => score)
    // - Use string.Join(", ", passingScores) to format
    // - Print exactly: Passing scores (desc): 30, 20
    private void PrintPassingScores()
    {
        IOrderedEnumerable<int> passingScores = _scores.Where(score => score >= Threshold).OrderByDescending(score => score);
        Console.WriteLine($"Passing scores (desc): {string.Join(", ", passingScores)}");
    }

    // TODO 7: Implement PrintFailingScores
    // Requirements:
    // - Chain: _scores.Where(score => score < Threshold).OrderByDescending(score => score)
    // - Use string.Join(", ", failingScores) to format
    // - Print exactly: Failing scores (desc): 10
    private void PrintFailingScores()
    {
        IOrderedEnumerable<int> failingScores = _scores.Where(score => score < Threshold).OrderByDescending(score => score);
        Console.WriteLine($"Failing scores (desc): {string.Join(", ", failingScores)}");
    }
}
