namespace SylviaLib;

public class PlantList : List<Plant_Model>{

    public static PlantList Build(Plant_Data[] data){
        PlantList list = new();
        foreach(Plant_Data d in data){
            list.Add(d.Build());
        }
        return list;
    }

    public Plant_Data[] Save(){
        Plant_Data[] output = new Plant_Data[this.Count];
        int c = 0;
        foreach(var element in this){
            output[c] = element.Save();
            c++;
        }
        return output;
    }
}
