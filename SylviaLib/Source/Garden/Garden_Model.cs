namespace SylviaLib;

public partial class Garden{

    public Garden(Garden_Data data){
        Name = data.Name;
    }

    string Name;

    public Garden_Data Save(){
        return new(){
            Name = Name,
        };
    }
}
