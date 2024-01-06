using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace SylviaLib;

public partial class Garden{
    public void Debug(){
        Console.WriteLine(Name);
    }

    public void CreatePlot(string name){
        Plot_Data plot = new(){
            Name = name,
            ID = Guid.NewGuid().ToString(),
        };

        Plots.Add(plot.Build());
    }

    public void CreatePlant(string name, string plot_name){
        Guid? plot_id = Plots.GetGuidFromName(plot_name);
        if(plot_id is not null){
            Plant_Data plant = new(){
                Name = name,
                ID = Guid.NewGuid().ToString(),
                Plot_ID = plot_id.ToString() ?? throw new UnreachableException(),
            };

            Plants.Add(plant.Build());
        }
    }

    public string[] GetAllPlotNames(){
        string[] plots = new string[Plots.Count];

        int c = 0;
        foreach(Plot p in Plots){
            plots[c] = p.ToString();
            c++;
        }

        return plots;
    }

    public string[] GetAllPlantNames(){
        string[] plants = new string[Plants.Count];

        int c = 0;
        foreach(Plant_Model p in Plants){
            plants[c] = p.ToString();
            c++;
        }

        return plants;
    }

    public string[] GetAllPlantsInPlot(string name){
        Guid id = Plots.GetGuidFromName(name) ?? throw new Exception();
        List<string> plants = new();

        foreach(Plant_Model p in Plants){
            if(p.Plot_ID == id){
                plants.Add(p.ToString());
            }
        }

        return plants.ToArray();
    }
}
