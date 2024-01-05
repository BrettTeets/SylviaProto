namespace SylviaLib;

public class Garden_Data{
    public Garden_Data(){
        Name = "Default";
        Plants = [];
    }

    public string Name;
    public Plant_Data[] Plants;

    public Garden Build(){
        return new(this);
    }
}