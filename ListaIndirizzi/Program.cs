List<Indirizzo> addressesList = new List<Indirizzo>();

//Aperutra file con indirizzi
StreamReader file = File.OpenText("C:\\Users\\Giuseppe Mirizzi\\source\\repos\\csharp-lista-indirizzi\\ListaIndirizzi\\addresses.csv");

string intestazione = file.ReadLine();

while (!file.EndOfStream)
{   
    try
    {
        string riga=file.ReadLine();
        string[] arrData = riga.Split(",");
        Indirizzo address = new Indirizzo(arrData[2], arrData[3]);
        address.SetProvince(arrData[4]);
        address.SetZip(arrData[5]);
        addressesList.Add(address);
        Console.WriteLine(riga);
    } catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

file.Close();
public class Indirizzo
{
    private string street;
    private string city;
    private string province;
    private int zipCode;

    public void SetProvince (string province)
    {
        this.province = province;
    }
    public void SetZip(string zip)
    {
        this.zipCode = int.Parse(zip);
    }

    public Indirizzo(string street, string city)
    {   
        if (street!="")
            this.street = street;
        this.city = city;
    }
}
