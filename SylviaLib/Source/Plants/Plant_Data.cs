namespace SylviaLib;

public class Plant_Data{

    public Plant_Data(){
        Name = "default";
        ID = "default";
        Plot_ID = "Unset";
        PlantReference = "NA";
        TimeUntilLastWatered = new();
    }
    public string Name;
    public string ID;
    public string Plot_ID;
    public string PlantReference;
    public DateTime TimeUntilLastWatered;

    public Plant_Model Build(){
        return new(this);
    }
}
