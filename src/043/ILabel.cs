// An interface defines a "contract" of a set of methods/properties
// that any class can choose to implement.
// Interfaces describe the "signatures" of the things that a class
// would have to provide
public interface ILabel
{
    string Label {get;} // A property that has to be implemented
    string GetValue();  // A method that has to be implemented
}
