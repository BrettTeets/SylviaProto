namespace SylviaLib;

public partial class Garden{

    public Garden(Garden_Data data){
        Name = data.Name;
        Plants = PlantList.Build(data.Plants);
        Plots = PlotList.Build(data.Plots);
    }

    readonly string Name;
    readonly PlantList Plants;
    readonly PlotList Plots;

    public Garden_Data Save(){
        return new(){
            Name = Name,
            Plants = Plants.Save(),
            Plots = Plots.Save(),
        };
    }
}
