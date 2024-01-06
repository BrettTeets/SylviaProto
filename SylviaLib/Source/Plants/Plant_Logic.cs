namespace SylviaLib;

public partial class Plant_Model{
    public void Debug(){
        Console.WriteLine(Name);
    }

    public void WaterPlant(DateTime time){
        LastWatered = time;
    }

    public NeedsWater DoesPlantNeedWater(){
        TimeSpan span = DateTime.Now - LastWatered;
        if(span > Reference.TimeUntilWaterCritical){
            return NeedsWater.Critical;
        }
        else if(span > Reference.MiniumTimeUntilWater){
            return NeedsWater.Yes;
        }
        else{
            return NeedsWater.No;
        }
    }

    public override string ToString()
    {
        return $"Plant: {Name}. ";
    }
}

public enum NeedsWater{
    No,
    Yes,
    Critical,
}
