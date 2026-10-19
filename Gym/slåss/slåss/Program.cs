using Raylib_cs;
using System.Numerics;

Raylib.InitWindow(1024, 768, "top down game");
Raylib.SetTargetFPS(60);


Color myColor = new Color(100, 150, 14, 255);

Texture2D avatarimge = Raylib.LoadTexture("nedladdning.png");
Rectangle character = new Rectangle(90, 90, avatarimge.width, avatarimge.height);
Rectangle enemyRect = new Rectangle(700, 500, 64, 64);
float speed = 4.5f;

string curentscrean = "start";



while (Raylib.WindowShouldClose() == false)
{
    if (curentscrean == "game")
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            character.x += speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            character.x -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            character.y -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            character.y += speed;
        }

        if (Raylib.CheckCollisionRecs(character, enemyRect))
        {
            curentscrean = "gameover";
        }
        if (character.x < 0)
        {
            character.x += 9f;
        }

    }
    else if (curentscrean == "start")
    {
        Raylib.DrawText("press enter to start", 250, 700, 32, myColor);
        if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
        {
            curentscrean = "game";
        }

    }
    else if(curentscrean == "gameover")
    {

        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText("You lost", 250, 500, 32, myColor);
        Raylib.DrawText("press enter to start", 250, 700, 32, myColor);
        if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
        {
            curentscrean = "game";
        }
    
    }

    Vector2 playerPos = new Vector2(character.x, character.y);
    Vector2 enemyPos = new Vector2(enemyRect.x, enemyRect.y);

    Vector2 diff = playerPos - enemyPos;


    Vector2 enemyDirevtion = Vector2.Normalize(diff);

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);
    Vector2 enemyMovment = Vector2.UnitX;
    float enemyspeed = 2;

    Vector2 enemyDirection = new Vector2(0, 0);
    enemyMovment = enemyDirection * enemyspeed;

    enemyRect.x += enemyMovment.X;
    enemyRect.y -= enemyMovment.Y;


    if (curentscrean == "game")
    {
        Raylib.DrawTexture(avatarimge,
        (int)character.x,
        (int)character.y,
        Color.WHITE);
        Raylib.DrawTexture(avatarimge, 0, 0, Color.WHITE);
        Raylib.DrawRectangleRec(enemyRect, Color.GREEN);

        Raylib.DrawRectangleRec(character, myColor);
    }
    



    Raylib.EndDrawing();
}

