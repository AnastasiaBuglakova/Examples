
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
Console.Clear();

int xa = 16;
int ya = 1;
int xb = 1;
int yb = 25;
int xc = 32;
int yc = 25;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = ya;
int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // 0, 1, 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (x + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (x + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (x + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
