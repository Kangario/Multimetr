[System.Serializable]
public struct MultimetrValues
{
    public float resistance;
    public float currentStrangth;
    public float voltageDC;
    public float voltageAC;

    public MultimetrValues(float resistance, float currentStrangth, float voltageDC, float voltageAC)
    {
        this.resistance = resistance;
        this.currentStrangth = currentStrangth;
        this.voltageDC = voltageDC;
        this.voltageAC = voltageAC;

    }
    public override string ToString()
    {
        string values;
        values = "Ω: " + resistance +"\n" +
            "A: " + currentStrangth + "\n"+
            "V: " + voltageDC + "\n"+
            "~: " + voltageAC + "\n";

        return values;
    }
}