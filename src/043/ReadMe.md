# Hodge-Podge...

## Collections and `List<T>`

Arrays are not the only way to gather many distinct values under one variable. There are many kinds of **collection** data types that provide distinct features not available in arrays. There are types that act as

- **Linked Lists** where each *node* in a list "links" to the next item
- **Queues** where the first item in the list is the first item taken from the list
- **Stacks** where the last item in the list is the first item taken from the list

## Generics

```csharp
public class LabeledItem<T>
{
    public T Item {get;set;}
    public readonly string Label;
    public LabeledItem(string description, T item)
    {

    }

}
```
