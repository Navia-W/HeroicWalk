using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is to manage temporary values while the gameloop is running.
/// every value set here will be cleared after closing the game.
/// </summary>
public static class StaticManager
{
    //Example value
    public static int exampleInt;
    public static int exampleInt2;
    public static int exampleInt3;

    //Current active item
    public static int currentShirt;
    public static int currentHat;

    //Item store
    public static int hat1;
}
