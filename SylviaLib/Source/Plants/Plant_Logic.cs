namespace SylviaLib;

public partial class Plant{
    public void Debug(){
        Console.WriteLine(Name);
    }

    public override string ToString()
    {
        return $"Plant: {Name}. ";
    }
}
