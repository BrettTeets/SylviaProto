namespace SylviaLib;

public partial class Plant_Model
{
    public Plant_Model(Plant_Data data){
        Name =      data.Name;
        ID =        Guid.Parse(data.ID);
        Plot_ID =   Guid.Parse(data.Plot_ID);
        LastWatered = data.TimeUntilLastWatered;
        Reference = Plant_Index.Plants[data.PlantReference];
    }

    public string Name {get; set;}
    public Guid ID {get; set;}
    public Guid Plot_ID {get; set;}
    public Plant_Reference Reference {get; set;}

    public DateTime LastWatered;

    public Plant_Data Save(){
        return new(){
            Name = Name,
            ID = ID.ToString(),
            Plot_ID = Plot_ID.ToString(),
        };
    }
}
