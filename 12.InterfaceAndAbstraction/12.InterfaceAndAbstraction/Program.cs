using System.Text;

string read = "";
StreamReader reader =new StreamReader("../../../Tet.txt");
using (reader)
{
   read =  reader.ReadToEnd();
}

Console.WriteLine(read);
string content = "";
using (FileStream stream = new FileStream("../../../Tet.txt", FileMode.Open))
{

    byte[] byteArray = new byte[2];

    while (stream.Read(byteArray, 0, byteArray.Length) > 0)
    {

        content = Encoding.UTF8.GetString(byteArray);
        Console.WriteLine(content);
    }
}

