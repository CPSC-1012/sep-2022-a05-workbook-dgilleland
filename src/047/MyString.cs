// The purpose of this class is to give a kind of
// "glimpse" into the inner-workings of the
// string data type

// This is a class definition for a data type
// that I am coding as a developer
public class MyString
{
    #region Fields
    // Public members of my class can be accessed from
    // outside of this class definition.
    public readonly int Length; // Field

    // As a private member, this _Characters can
    // only be used by other code within this
    // class definition
    private char[] _Characters; // Field
    #endregion

    #region Constructor(s)
    // The only purpose of a constructor is to
    // make sure the fields and properties have
    // "meaningful" data
    #endregion
} // end of MyString class definition