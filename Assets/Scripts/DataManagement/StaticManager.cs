using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is to manage temporary values while the gameloop is running.
/// every value set here will be cleared after closing the game.
/// </summary>
public static class StaticManager
{
    //Current active item
    public static int currentShirt;
    public static int currentHat;

    //Item store
    public static int hat1;

    //Pickups
    public static int pickUpCount;

    //Distance
    public static float distanceTravelled;

    //MiniGame
    public static int score;
}
