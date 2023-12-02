using System.Text;

class SaveLoadCSV
{
    //asdas
    public static void SaveToCSV(List<String> _dataToSave, string _filePath)
    {
        File.WriteAllLines(_filePath, _dataToSave);
    }

    public static List<String> LoadFromCSV(string _filePath)
    {
        List<string> fromCSV = new List<string>();
        StreamReader ReaderMenu= new StreamReader(_filePath);
        
        while (!ReaderMenu.EndOfStream)
        {
            string line = ReaderMenu.ReadLine();
            fromCSV.Add(line.ToString());
        }   
        ReaderMenu.Close();

        return fromCSV;
    }   
}