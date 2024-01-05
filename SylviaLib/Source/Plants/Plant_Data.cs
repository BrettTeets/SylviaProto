namespace SylviaLib;

public class Plant_Data{

    public Plant_Data(){
        Name = "default";
        ID = "default";
    }
    public string Name;
    public string ID;

    public Plant Build(){
        return new(this);
    }
}
