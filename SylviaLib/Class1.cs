namespace SylviaLib;

public partial class Plant
{
    public Plant(string name){
        Name = name;
    }

    public string Name {get; set;}

    public string Save(){
        return Name;
    }
}

public partial class Plant{
    public void Debug(){
        Console.WriteLine(Name);
    }
}
