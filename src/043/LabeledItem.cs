// The <T> is my generic data type
public class LabeledItem<T> : ILabel
{
    // The data type of the item is <T>
    public T Item { get; set; }
    public string Label { get; private set; } // Implements the ILabel.Label property
    public string GetValue()
    {
        string result;
        if(Item == null)
            result = "-";
        else
            result = Item.ToString();
        return result;
    }

    // Constructor
    public LabeledItem(string text, T value)
    {
        Label = text;
        Item = value;
    }

    public override string ToString()
    {
        return $"{Label}: {Item}";
    }
}
