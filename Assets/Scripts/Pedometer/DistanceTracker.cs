using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// gets the walked distance and sets the distance challenge
/// </summary>
public class DistanceTracker : MonoBehaviour
{
    public Text DistanceText;
    public Text TargetText;
    public int TargetDistance;

    float currentDistance;
    bool MiniGameActive;

    private void Start()
    {
        //in meters
        TargetDistance = 150;
        MiniGameActive = false;
    }

    private void Update()
    {
        GetDistance();
    }

    void GetDistance()
    {
        float distance = float.Parse(DistanceText.text);
        currentDistance = distance * 3.2808f;
        if (MiniGameActive == false)
        {
            DistanceChallenge(currentDistance, TargetDistance);
        }
    }

    void DistanceChallenge(float currentDistance, int targetDistance)
    {
        if (currentDistance > targetDistance)
        {
            //call challenge
            MiniGameActive = true;
            IncreaseDistance();
        }
    }

    void IncreaseDistance()
    {
        TargetDistance *= 2;
    }
}