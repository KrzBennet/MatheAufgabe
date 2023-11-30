namespace StrukturVeranschaulichung;

public class Analyzer
{
    public static AnalyzerResult Analyze(WortMenge menge)
    {
        Dictionary<string, Dictionary<char, int>> analyzedWords = new();
        foreach (string wort in menge.GetWoerter())
        {
            Dictionary<char, int> dict = wort.GroupBy(c => c).Select(c => new { Char = c.Key, Count = c.Count() })
                .ToDictionary(c => c.Char, c => c.Count);
            analyzedWords.Add(wort, dict);
        }
        
        return new AnalyzerResult(analyzedWords);
    }
}