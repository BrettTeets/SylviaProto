using System.Diagnostics;

namespace SylviaLib;

public partial class Plot{
    public Plot(Plot_Data data){
        Name = data.Name;
        ID = Guid.Parse(data.ID);
    }

    internal string Name;
    internal Guid ID;


    public Plot_Data Save(){
        return new(){
            Name = Name,
            ID = ID.ToString(),
        };
    } 
}
