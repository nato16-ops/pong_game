using System.Runtime.InteropServices;
//variables
int gameWidth = 50;
int gameHeight = 20;
int paddleX = 2;
int paddleY = 8;
int paddleHeight=4;
int paddleX2 = gameWidth-3;
int ballX=25;
int ballY=10;
int ballDirectionX = 1;

//SCENERY
//top
for(int i=0; i < gameWidth; i++)
{
    Console.Write("_");
}

//bottom
Console.SetCursorPosition(0,gameHeight);
for(int i=0; i < gameWidth; i++)
{
    Console.Write("_");
}
//left side
for (int y = 0; y < gameHeight; y++)
{
    Console.SetCursorPosition(0, y);
    Console.Write("|");
}
//right side
for (int y=0; y<gameHeight; y++)
{
    Console.SetCursorPosition(gameWidth-1, y);
    Console.Write("|");
}
//left paddle
for (int y = 0; y< paddleHeight; y++)
{
    Console.SetCursorPosition(paddleX, paddleY+y);
    Console.Write("|");
}
//right paddle
for (int y = 0; y < paddleHeight; y++)
{
    Console.SetCursorPosition(paddleX2, paddleY+y);
    Console.Write("|");
}
//Ball 

while (true)
{ //erase ball
    Console.SetCursorPosition(ballX, ballY);
    Console.Write(' ');

    ballX += ballDirectionX;
    if (ballX >= gameWidth - 2)
    {
        ballDirectionX = -1;
    }

    if (ballX <= 1)
    {
        ballDirectionX = 1;
    }
    
    
    // draw the ball again
    Console.SetCursorPosition(ballX, ballY);
    Console.Write('o');
    //delay
    Thread.Sleep(100);
}
