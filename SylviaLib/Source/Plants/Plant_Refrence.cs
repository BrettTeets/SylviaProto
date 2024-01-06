namespace SylviaLib;

public class Plant_Reference(){
    public string Name {get; set;} = "Default";

    public TimeSpan MiniumTimeUntilWater {get; set;} = new();
    public TimeSpan TimeUntilWaterCritical {get; set;} = new();


}
