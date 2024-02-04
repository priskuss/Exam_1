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

bool CountTurn(int count)
{
    return count == 1 || count == 3 || count == 5 || count == 6 || count == 7 || count == 8;
}

bool CountTurns(int count)
{
    return count == 2 || count == 4;
}

#endregion

void Main()
{
    int peekCount = 0;

    while (!AtGoal())
    {
        MoveUntilWall();

        peekCount++;

        if (CountTurn(peekCount))
        {
            Turn();
        }
        else if (CountTurns(peekCount))
        {
            Turns();
        }
    }
}