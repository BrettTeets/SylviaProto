namespace SylviaLib;

public class Plot_Data{
    public Plot_Data(){
        Name = "Default";
        ID = "Default";
    }
    public string Name;
    public string ID;

    public Plot Build(){
        return new(this);
    }
}