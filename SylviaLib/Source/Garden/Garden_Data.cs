namespace SylviaLib;

public class Garden_Data{
    public Garden_Data(){
        Name = "Default";
        Plants = [];
        Plots = [];
    }

    public          string              Name;
    public          Plant_Data[]        Plants;
    public          Plot_Data[]         Plots;

    public Garden Build(){
        return new(this);
    }
}