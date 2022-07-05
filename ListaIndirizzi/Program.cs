List<Indirizzo> addressesList = new List<Indirizzo>();

//Aperutra file con indirizzi
StreamReader file = File.OpenText("C:\\Users\\Giuseppe Mirizzi\\source\\repos\\csharp-lista-indirizzi\\ListaIndirizzi\\addresses.csv");

while (!file.EndOfStream)
{
    string riga=file.ReadLine();
    Console.WriteLine(riga);
}

file.Close();
public class Indirizzo
{
    private string street;
    private string city;
    private string province;
    private string zipCode;

    public Indirizzo(string street, string city)
    {
        this.street = street;
        this.city = city;
    }
}
