# Exceptions and Exception Handling

The program shown here illustrates where exception handling should occur ([top-level](./Program.cs)) in a program with a [decent driver](./MyDriver.cs).

## Paint Program (Demo)

I want a program that can read a file of information about rooms in a building. From that information, I want to be able to determine how much paint I might need to get.

The file structure looks like this

```text
Room:Living Room, 10.5, 12.5, 4.2
Opening:Living Room, 1.4, 2.4
```

The file contains information on the dimensions of a room and of the openings to the room (an opening can be a door, window, missing wall because the room is adjacent to another room, etc.).

### Analysis

Key to my program is the ability to calculate areas of rooms so that I can punch that into whatever other software I have to manage the painting jobs I have.
