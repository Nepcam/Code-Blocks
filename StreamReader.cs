StreamReader reader;
string line = "";
string[] csvArray;
// datatypes
int roomNo = 0; 
RoomTypes roomType;
int capacity = 0;

roomList.Clear();
listBoxData.Items.Clear();

openFileDialog1.Filter = "CSV FIles|*.csv|All Files|*.*";
if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
    reader = File.OpenText(openFileDialog1.FileName);
    while(!reader.EndOfStream)
    {
        try
        {
            line = reader.ReadLine();
            csvArray = line.Split(',');
            if (csvArray.Length == 3)
            {

            }
        }
        catch
        {
            Console.WriteLine("Error: " + line);
        }
    }
}