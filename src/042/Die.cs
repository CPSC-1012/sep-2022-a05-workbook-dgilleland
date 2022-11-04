public class Die
{
    static Random _rnd = new();
    public int FaceValue { get; private set; }
    public void Roll()
    {
        FaceValue = _rnd.Next(1, 7);
    }
}