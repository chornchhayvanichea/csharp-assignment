namespace Assignment.MiniCalculator.CSVToJsonConverter
{
    public class CSVToJsonConverter
    {
        private static (string[] headers, string[] lines) ReadCSV(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string[] headers = lines[0].Split(',');
            return (headers, lines);
        }

        private static string BuildJson(string[] lines, string[] headers)
        {
            string json = "[\n";
            for (int i = 1; i < lines.GetLength(0); i++)
            {
                string[] values = lines[i].Split(',');
                json += " {";
                for (int j = 0; j < headers.Length; j++)
                {
                    string value = j < values.Length ? values[j] : "";
                    json += $"\"{headers[j]}\": \"{value}\"";
                    if (j < headers.Length - 1)
                    {
                        json += ", ";
                    }
                }
                json += "}";
                if (i < lines.GetLength(0) - 1)
                {
                    json += ",";
                }
                json += "\n";
            }
            json += "]";
            return json;
        }

        private static void WriteJson(string path, string json)
        {
            string jsonPath = Path.ChangeExtension(path, ".json");
            File.WriteAllText(jsonPath, json);
            Console.WriteLine($"done! check {jsonPath}");
        }

        public static void Start()
        {
            string filePath = "MiniCalculator/CSVToJsonConverter/people-100.csv";
            (string[] headers, string[] lines) = ReadCSV(filePath);
            string json = BuildJson(lines, headers);
            WriteJson(filePath, json);
        }
    }
}
