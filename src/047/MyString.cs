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
    public MyString(string text)
    {
        // Here, I want to make sure my fields have good values.
        if(text == null || text == "") // if empty
        {
            Length = 0;
            _Characters = new char[0];
        }
        else
        {
            _Characters = text.ToArray();
            Length = _Characters.Length;
        }
    }
    #endregion

    #region Methods
    public bool EndsWith(string text)
    {                   // "abscdef"
        // Assume it's true
        bool result = true;

        // Check to see if it is false
        // Assuming my char array is ['B', 'o', 'b'],
        // my own length would be 3
        //     v--7--v   v--3--v
        if(text.Length > Length)
            result = false;
        else
        {
            // Loop from the back end and compare the characters
            int index = text.Length - 1;
            int position = Length - 1;
            while(index >= 0)
            {

                if(text[index] != _Characters[position])
                    result = false;

                position--; // position = position - 1
                index--; // decrement the position
            }
        }

        return result;
    }
    #endregion
} // end of MyString class definition