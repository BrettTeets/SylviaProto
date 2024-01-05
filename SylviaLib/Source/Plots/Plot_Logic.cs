namespace SylviaLib;

public partial class Plot{
    public void Debug(){
        Console.WriteLine(Name);
    }

    public override string ToString()
    {
        return $"The Plot: {Name}.";
    }
}
