// Your program should start at this line.
/*
Example:
Move();
Move();
Move();
Turn();
Move();
Move();
Turn();
Turn();
Turn();
Move();
*/


#region Basic functions
// These functions are just here to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placeholder
}

bool Visited()
{
    // Returns true if the current cell is visited, otherwise false.
    // Keeps track of visited cells
    return true; // just a placeholder
}

#endregion

void Main()
{

    while (!AtGoal())
    {
        while (Peek())
        {
            Move();
            Visited();
        }
        Turn();
    }
}