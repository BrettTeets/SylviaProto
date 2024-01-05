namespace SylviaLib;

public class Plant_Data{

    public Plant_Data(){
        Name = "default";
        ID = "default";
        Plot_ID = "Unset";
    }
    public string Name;
    public string ID;
    public string Plot_ID;

    public Plant Build(){
        return new(this);
    }
}
