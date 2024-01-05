namespace SylviaLib;

public partial class Garden{

    public Garden(Garden_Data data){
        Name = data.Name;
        Plants = PlantList.Build(data.Plants);
    }

    string Name;

    PlantList Plants;

    public Garden_Data Save(){
        return new(){
            Name = Name,
            Plants = Plants.Save()
        };
    }
}
