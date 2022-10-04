# Explorations

For this example, we will run the program in an external terminal. Close the internal terminal (toggles with  <kbd>ctrl</kbd> + <kbd>`</kbd>). Next, press <kbd>ctrl</kbd> + <kbd>shift</kbd> + <kbd>c</kbd> to open the external terminal.

Now, let's do a series of experiments in our [Program.cs](./Program.cs) file.

### Window Dimensions

You can get the dimensions of the terminal by using the `WindowWidth` and `WindowHeight` properties of the `Console` class.

### Clearing the Screen

The `Clear()` method of the `Console` class will clear the window and position the cursor in the top-left (at position 0, 0).

### Cursor Position

The `GetCursorPosition()` method will return the current x,y position of the cursor. Additionally, the `SetCursorPosition(x, y)` will place the cursor at that position. Note that the set method will throw an exception if the positon is outside the buffer size of the terminal.

### Colors

The text color is set using the `ForegroundColor` and the background is set with the `BackgroundColor` properties of the `Console` class. You can reset the color to the last known setting with the `ResetColor()` method.
