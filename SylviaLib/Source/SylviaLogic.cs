namespace SylviaLib;

public static class SylviaLogic
{
    public static Garden MakeGardenForTesting(string name){
        Garden_Data data = new(){
            Name = name,
        };
        return data.Build();
    }
}
