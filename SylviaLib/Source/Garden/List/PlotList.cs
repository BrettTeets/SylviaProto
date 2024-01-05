namespace SylviaLib;

public class PlotList : List<Plot>{

    public static PlotList Build(Plot_Data[] data){
        PlotList list = new();
        foreach(Plot_Data d in data){
            list.Add(d.Build());
        }
        return list;
    }
    
    public Plot_Data[] Save(){
        Plot_Data[] output = new Plot_Data[this.Count];
        int c = 0;
        foreach(var element in this){
            output[c] = element.Save();
            c++;
        }
        return output;
    }

    public Guid? GetGuidFromName(string name){
        foreach(Plot element in this){
            if(element.Name == name) return element.ID;
        }
        return null;
    }
}
