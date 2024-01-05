namespace SylviaLib;

public partial class Plant
{
    public Plant(Plant_Data data){
        Name = data.Name;
        ID = data.ID;
    }

    public string Name {get; set;}

    public string ID {get; set;}

    public Plant_Data Save(){
        return new(){
            Name = Name,
            ID = ID,
        };
    }
}
