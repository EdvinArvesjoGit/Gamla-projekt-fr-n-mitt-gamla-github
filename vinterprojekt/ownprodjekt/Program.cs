// this game is a child game
// dont for get to use coments 
using Raylib_cs;
using System.Numerics;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

//test kommer att användas för att rätta se om man har rätt
string test = "nej";
//extra användes för att testa några saker men också för frågorna om färger 
string extra = "nej";
string test3 = "you were right \npress Enter to go back \npress Tab to go to menu";




// " what color is the back\n ground, z blue, x maroon\n c magenta, v purple";


Raylib.InitWindow(1600, 800, "fun games");
Raylib.SetTargetFPS(60);

Font lobsterFont = Raylib.LoadFontEx(@"Lobster-Regular.ttf", 125, null, -1);

string curentsceen = "start";

//de skulle vara en static void och en typkonvertering men kunde inte hita en plats där de behövdes 
//// int kommer att användas bara för att göra en typkonvertering
//// string kommer att användas bara för att göra en typkonvertering
//// string jobig2 = "1";
//// static void Test1(){
////     int jobig = int.Parse(jobig2);
//// }


//Den här klupen med kod används för att göra så att jag för en ändrade i färger på en av texterna.
Color[] textcolors = { Color.SKYBLUE, Color.GREEN, Color.DARKPURPLE, Color.GOLD};
Random generator = new Random();
Color textColor = textcolors[0];
int whichColor;

    List<string> mathq = new List<string>();
mathq.Add("what number is 9 - 9");
mathq.Add("what number is 9 - 8");
mathq.Add("what number is 4 - 2");
mathq.Add("what number is 3 + 0");
mathq.Add("what number is 8 / 2");
mathq.Add("what number is 8 - 3");
mathq.Add("what number is 3 + 3");
mathq.Add("what number is 20 - 13");
mathq.Add("what number is 4 * 2");
mathq.Add("what number is 12 - 3");
string mathqf = mathq[0];
KeyboardKey[] mathc = {KeyboardKey.KEY_ZERO ,KeyboardKey.KEY_ONE, KeyboardKey.KEY_TWO, KeyboardKey.KEY_THREE, KeyboardKey.KEY_FOUR, KeyboardKey.KEY_FIVE, KeyboardKey.KEY_SIX, KeyboardKey.KEY_SEVEN, KeyboardKey.KEY_EIGHT, KeyboardKey.KEY_NINE};
KeyboardKey mathcr = mathc[0];

List<string> test4f = new List<string>();
test4f.Add(" what color is the back\n ground, z blue, x magenta\n c maroon, v purple");
test4f.Add("what color is the back\n z green, x red\n c blue, v gray");
test4f.Add("what color is the back\n z yellow, x lightblue\n c  black, v gray\n ");
string test4 = test4f[0];
int randomQ;
Color[] test4c = {Color.MAROON, Color.BLUE, Color.BLACK};
Color test4cr = test4c[0];



while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    if (curentsceen == "start")
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
            curentsceen = "menu";
        }
        Raylib.ClearBackground(Color.GRAY);
        Raylib.DrawTextEx(lobsterFont, "Press enter to start!!!", new Vector2(20, 190), 125, 10, Color.BLACK);
    }

    if (curentsceen == "menu")
    {
        // det gär för så att det inte ändras varje frame
        whichColor = generator.Next(31);
        if (whichColor >= 27)
        {
            whichColor = generator.Next(textcolors.Length);
            textColor = textcolors[whichColor];
        }


        Raylib.ClearBackground(Color.BLUE); 
        Raylib.DrawTextEx(lobsterFont, "welcome to the best ", new Vector2(20, 15), 80, 40, textColor);
        Raylib.DrawTextEx(lobsterFont, "game", new Vector2(20, 75), 80, 40, textColor);
        Raylib.DrawTextEx(lobsterFont, "press A to play math", new Vector2(20, 190), 125, 10, Color.BLACK);
        Raylib.DrawTextEx(lobsterFont, "Press B to play color", new Vector2(20, 290), 125, 10, Color.BLACK);
        Raylib.DrawTextEx(lobsterFont, "Press C to play spelling", new Vector2(20, 390), 125, 10, Color.BLACK);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
        {
            curentsceen = "math";
            randomQ = generator.Next(10);
            mathqf = mathq[randomQ];
            mathcr = mathc[randomQ];
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_B))
        {
            curentsceen = "Color";
            randomQ = generator.Next(3);
            test4 = test4f[randomQ];
            test4cr = test4c[randomQ];
            
        }
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_C))
        {
            curentsceen = "spelling";
            extra = "asda";
        }

        
    }
    if(curentsceen == "math"){
        //gjorde så att den kollar om test = "ja" för att inan så hade jag problem 
        //med att ha ta bort frågan och ta fram texten när man hade rätt kommer att användas flera gånger
        if (test != "ja"){
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, mathqf, new Vector2(20, 190), 125, 10, Color.YELLOW);
        Raylib.DrawTextEx(lobsterFont, "Pleas enter a number", new Vector2(20, 290), 125, 10, Color.YELLOW);
        }
        if (Raylib.IsKeyDown(mathcr)){
            test = "ja";
        }
        if (test == "ja"){
            Raylib.ClearBackground(Color.BLUE);
            Raylib.DrawTextEx(lobsterFont, test3, new Vector2(20, 190), 125, 10, Color.YELLOW);
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB)){
                curentsceen = "menu";
                // test blir nej för att om man inte gör det och går till en annan fråga 
               
                // så kommer att det leda till man har rätt atomatisk 
                test = "nej";
            }
            else if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
                test = "nej";
                randomQ = generator.Next(10);
                mathqf = mathq[randomQ];
                mathcr = mathc[randomQ];
            }
        }
    }
    if(curentsceen == "Color"){
        if (test == "nej"){
        Raylib.ClearBackground(test4cr);
        Raylib.DrawTextEx(lobsterFont, test4, new Vector2(20, 90), 90, 10, Color.YELLOW);
        }
        if (extra == "ja"){
            Raylib.DrawTextEx(lobsterFont, " wrong color try again", new Vector2(20, 490), 125, 10, Color.WHITE);

        }
        //kunde inte hita ett kod för att checka om vad knappen man trykte var inte rätt
        if (Raylib.IsKeyDown(KeyboardKey.KEY_Z)){
            extra = "ja";

        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_V)){
            extra = "ja";
       
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_X)){
            extra = "ja";
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_C)){
            test = "ja";
            extra = "nej";

        }
        if (test == "ja"){
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, test3, new Vector2(20, 190), 125, 10, Color.YELLOW);
       
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB)){
            curentsceen = "menu";
            test = "nej";
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
            test = "nej";
            extra = "asd";
            randomQ = generator.Next(3);
            test4 = test4f[randomQ];
            test4cr = test4c[randomQ];
        }


        }   
    }
    if(curentsceen == "spelling"){
        if(test == "nej"){
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawTextEx(lobsterFont, "how do you spell, Never", new Vector2(20, 290), 125, 10, Color.YELLOW);
        }
    //orkade inte checka alla boxtäver så jag märkte att om man kollar bokstaven R så hade de troligen rätt 
        // if (Raylib.IsKeyPressed(KeyboardKey.KEY_N)){
            
        //     if (Raylib.IsKeyPressed(KeyboardKey.KEY_E)){

        //         if (Raylib.IsKeyPressed(KeyboardKey.KEY_V)){

        //             if (Raylib.IsKeyPressed(KeyboardKey.KEY_E)){

         if (Raylib.IsKeyPressed(KeyboardKey.KEY_R)){
            test = "ja";
                            
        }
        //             }
        //         }          
        //     }
        // }    
        if (test == "ja"){
        Raylib.ClearBackground(Color.BLUE);
        Raylib.DrawTextEx(lobsterFont, test3, new Vector2(20, 190), 125, 10, Color.YELLOW);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB)){
            curentsceen = "menu";
            test = "nej";
        }
        else if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
            test = "nej";

        }
        }   
    }
    
        
        Raylib.EndDrawing();
    }
