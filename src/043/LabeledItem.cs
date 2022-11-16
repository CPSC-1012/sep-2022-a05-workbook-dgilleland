public class LabeledItem<T> // The <T> is my generic data type
{
    // The data type of the item is <T>
    public T Item { get; set; }
    public readonly string Label;

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
