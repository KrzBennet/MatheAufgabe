using System.Text;

namespace StrukturVeranschaulichung;

public class AnalyzerResult(Dictionary<string, Dictionary<char, int>> rawResults)
{
    private Dictionary<string, Dictionary<char, int>> _rawResults { get; set; } = rawResults;

    public override string ToString()
    {
        StringBuilder result = new StringBuilder("Menge enthält " + _rawResults.Count + " Elemente:\n{\n");
        foreach (KeyValuePair<string,Dictionary<char,int>> keyValuePair in _rawResults)
        {
            result.Append("   { ");
            foreach (KeyValuePair<char, int> innerKeyValue in keyValuePair.Value)
            {
                result.Append($"{innerKeyValue.Key}, {innerKeyValue.Value}; ");
            }

            result.Append("}").Append($"  {keyValuePair.Key};  \n");
        }

        result.Append("\n}");
        return result.ToString();
    }
}