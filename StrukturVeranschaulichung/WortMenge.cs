using System.Text;

namespace StrukturVeranschaulichung;
public class WortMenge(string w1 = "a", string w2 = "aca", string connectorWord = "cac")
{
    private string w1 { get; set; } = w1;
    private string w2 { get; set; } = w2;

    private string connectorWord { get; set; } = connectorWord;

    private HashSet<string> wörter = new() { w1, w2 };

    public void GenerateNGeneration(int iterations)
    {
        for (int i = 0; i < iterations; i++)
        {
            GenerateNextGeneration();
        }
    }
    
    private void GenerateNextGeneration()
    {
        HashSet<string> tmp = new();
        for (int i = 0; i < wörter.Count; i++)
        {
            for (int j = 0; j < wörter.Count; j++)
            {
                string wort = wörter.ToArray()[i] + connectorWord + wörter.ToArray()[j];
                tmp.Add(wort);
            }
        }
        wörter.UnionWith(tmp);
    }
    
    public override string ToString()
    {
        StringBuilder result = new("Wörter: { ");
        foreach (string wort in wörter)
        {
            result.Append(wort).Append("; ");
        }

        result.Append("}");
        return result.ToString();
    }

    public HashSet<string> GetWoerter()
    {
        return this.wörter;
    }
}
