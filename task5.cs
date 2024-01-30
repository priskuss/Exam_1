#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}
void Turns()
{
    Turn();
    Turn();
    Turn();
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

void MoveUntilWall()
{
    while (Peek())
    {
        Move();
    }
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placeholder.
}

#endregion
void Main()
{
    int peekCount = 0;

    while (!AtGoal())
    {
        MoveUntilWall();

        peekCount++;

        if (peekCount == 1 || peekCount == 3 || peekCount == 5 || peekCount == 6 || peekCount == 7 || peekCount == 8)
        {
            Turn();
        }
        else if (peekCount == 2 || peekCount == 4)
        {
            Turns();
        }
    }
}

/*
void Main()
{
    while (!AtGoal())
    {
        MoveUntilWall();
        Turn();
        MoveUntilWall();
        Turns();
        MoveUntilWall();
        Turn();
        MoveUntilWall();
        Turns();
        MoveUntilWall();
        Turn();
        MoveUntilWall();
        Turn();
        MoveUntilWall();
        Turn();
        MoveUntilWall();
        Turn();
        MoveUntilWall();
    }
}
*/