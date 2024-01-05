namespace SylviaLib;

public class Garden_Data{
    public Garden_Data(){
        Name = "Default";
    }

    public string Name;

    public Garden Build(){
        return new(this);
    }
}