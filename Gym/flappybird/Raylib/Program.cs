using Raylib_cs;

Raylib.InitWindow(1550, 800, "flappy bird");
Raylib.SetTargetFPS(60);

Rectangle player = new Rectangle(200, 200, 75,50);
Rectangle wall1 = new Rectangle(1550, 0, 100, 550);
Rectangle wall2 = new Rectangle(1550, 0, 100, 800);
Rectangle wall3 = new Rectangle(1950, 0, 100, 550);
Rectangle wall4 = new Rectangle(1950, 0, 100, 800);
Rectangle wall5 = new Rectangle(2350, 0, 100, 550);
Rectangle wall6 = new Rectangle(2350, 0, 100, 800);
Rectangle wall7 = new Rectangle(2750, 0, 100, 550);
Rectangle wall8 = new Rectangle(2750, 0, 100, 800);

string count="";

int playerac =2;

int i =0;

int life =2;

int menu =1;

int point =0;

Random genarator = new Random();

wall1.y = genarator.Next(451);
wall3.y = genarator.Next(451);
wall5.y = genarator.Next(451);
wall7.y = genarator.Next(451);

wall1.y *= -1;
wall3.y *= -1;
wall5.y *= -1;
wall7.y *= -1;

wall2.y = wall1.y + 750;
wall4.y = wall3.y + 750;
wall6.y = wall5.y + 750;
wall8.y = wall7.y + 750;

while(menu>=1)
{
    if(Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
    {
        menu = 0;
        life = 1;
    }
    Raylib.BeginDrawing();
    Raylib.DrawText("Press ENTER to stsrt",150 ,100 ,60 ,Color.BLUE);
    Raylib.ClearBackground(Color.BLACK);
    Raylib.EndDrawing();
}
while (!Raylib.WindowShouldClose()){ 
if(life == 0)
{
    if(Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
    {
        life++;
        wall1.y = genarator.Next(451);
        wall3.y = genarator.Next(451);
        wall5.y = genarator.Next(451);
        wall7.y = genarator.Next(451);
        wall1.y *= -1;
        wall3.y *= -1;
        wall5.y *= -1;
        wall7.y *= -1;
        wall2.y = wall1.y + 750;
        wall4.y = wall3.y + 750;
        wall6.y = wall5.y + 750;
        wall8.y = wall7.y + 750;
        wall1.x = 1550; 
        wall2.x = 1550; 
        wall3.x = 1950; 
        wall4.x = 1950; 
        wall5.x = 2350; 
        wall6.x = 2350; 
        wall7.x = 2750; 
        wall8.x = 2750; 
        point=0;
        player.y = 250;
    }
}
if(Raylib.CheckCollisionRecs(wall1, player))
{life=0;}
if(Raylib.CheckCollisionRecs(wall2, player))
{life=0;}
if(Raylib.CheckCollisionRecs(wall3, player))
{life=0;}
if(Raylib.CheckCollisionRecs(wall4, player))
{life=0;}
if(Raylib.CheckCollisionRecs(wall5, player))
{life=0;}
if(Raylib.CheckCollisionRecs(wall6, player))
{life=0;}
if(Raylib.CheckCollisionRecs(wall7, player))
{life=0;}
if(Raylib.CheckCollisionRecs(wall8, player))
{life=0;}

if(wall1.x <=-100)
{wall1.x = 1550;
wall2.x = 1550;
wall1.y = genarator.Next(451);
wall1.y *= -1;
wall2.y = wall1.y + 750;
point ++;}
if(wall3.x <=-100)
{wall3.x = 1550;
wall4.x = 1550;
wall3.y = genarator.Next(451);
wall3.y *= -1;
wall4.y = wall3.y + 750;
point ++;}
if(wall5.x <=-100)
{wall5.x = 1550;
wall6.x = 1550;
wall5.y = genarator.Next(451);
wall5.y *= -1;
wall6.y = wall5.y + 750;
point ++;}
if(wall7.x <=-100)
{wall7.x = 1550;
wall8.x = 1550;
wall7.y = genarator.Next(451);
wall7.y *= -1;
wall8.y = wall7.y + 750;
point ++;}

if(Raylib.IsKeyPressed(KeyboardKey.KEY_W)|| Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
{
    i=15;
}
if(i>=1)
{
    playerac-=15;
    if(playerac<=-10)
    {
        playerac=-10;
    }
    i-=1;
}
if(playerac<5)
{
    playerac+=3;
}
if(player.y >=750)
{
    life=0;
}
if (life == 1)
{
player.y+=playerac;
wall1.x-=2;
wall2.x-=2;
wall3.x-=2;
wall4.x-=2;
wall5.x-=2;
wall6.x-=2;
wall7.x-=2;
wall8.x-=2;


count="your points are "+point;
}

Raylib.BeginDrawing();


Raylib.DrawRectangleRec(wall1, Color.GREEN);
Raylib.DrawRectangleRec(wall2, Color.GREEN);
Raylib.DrawRectangleRec(wall3, Color.GREEN);
Raylib.DrawRectangleRec(wall4, Color.GREEN);
Raylib.DrawRectangleRec(wall5, Color.GREEN);
Raylib.DrawRectangleRec(wall6, Color.GREEN);
Raylib.DrawRectangleRec(wall7, Color.GREEN);
Raylib.DrawRectangleRec(wall8, Color.GREEN);
Raylib.DrawText(count,1250 ,50 ,30 ,Color.BLUE);


Raylib.DrawRectangleRec(player, Color.WHITE);
Raylib.ClearBackground(Color.BLACK);
if (life == 0)
{
    Raylib.DrawText("you died press ENTER to try again",250 ,200 ,30 ,Color.BLUE);
}


Raylib.EndDrawing();

}