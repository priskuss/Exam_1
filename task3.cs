#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car until the next cell is a wall.
}

void TurnRight()
{
    // Turns the car 90 deg clockwise.
}

void TurnLeft()
{
    // Turns the car 90 deg counterclockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // Just a placeholder value.
}

bool RightTurn()
{
    // Represents the direction of the next turn.
    // Returns true if the next turn should be to the right, otherwise false.
    return true; // Just a placeholder value. 
}
#endregion

void Main()
{
    while (!AtGoal())
    {
        for (int i = 0; i < 2; i++)
        {
            if (RightTurn)
                TurnRight();
            else
                TurnLeft();

            Move();
        }
        RightTurn = !RightTurn;
    }
}