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

void Move()
{
    (int, int) = NextPosition();
    walkedCells.Add((int, int));
    // Moves the car 1 cell in the direction it is heading.
    // Track the walked cells.
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

void Backtrack()
{
    if (walkedCells.Count > 1)
    {
        walkedCells.RemoveAt(walkedCells.Count - 1);
        (int, int) = walkedCells.Last();
        Move();
    }
}

#endregion

List<(int, int)> walkedCells = new List<(int, int)>();

void Main()
{
    while (!AtGoal())
    {
        if (Peek())
        {
            Move();
        }
        else
        {
            Backtrack();
            Turn();
        }
    }
}