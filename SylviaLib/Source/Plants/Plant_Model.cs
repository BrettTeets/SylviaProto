namespace SylviaLib;

public partial class Plant
{
    public Plant(Plant_Data data){
        Name =      data.Name;
        ID =        Guid.Parse(data.ID);
        Plot_ID =   Guid.Parse(data.Plot_ID);
    }

    public string Name {get; set;}
    public Guid ID {get; set;}
    public Guid Plot_ID {get; set;}

    public Plant_Data Save(){
        return new(){
            Name = Name,
            ID = ID.ToString(),
            Plot_ID = Plot_ID.ToString(),
        };
    }
}
