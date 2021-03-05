using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// gets the walked distance and sets the distance challenge
/// </summary>
public class DistanceTracker : MonoBehaviour
{
    public GameObject sceneManager;

    CollectStars collectStars;

    public Text DistanceText;
    public Text TargetText;
    public float TargetDistance;

    float currentDistance;
    bool MiniGameActive;

    private void Start()
    {
        collectStars = sceneManager.GetComponent<CollectStars>();
        TargetDistance = 150f;
        MiniGameActive = false;
    }

    private void Update()
    {
        if (MiniGameActive == false)
        {
            TargetText.text = "Doel: " + TargetDistance.ToString() + "m";
            GetDistance();
        }
    }

    //Sets the walked distance as distance and calls the functions that tracks if the target amount of distance has been obtained
    void GetDistance()
    {
        float distance = float.Parse(DistanceText.text);
        currentDistance = distance * 3.2808f;
        DistanceChallenge(currentDistance, TargetDistance);
    }

    //Checks if the set target distance has been obtained
    void DistanceChallenge(float currentDistance, float targetDistance)
    {
        if (currentDistance >= targetDistance)
        {
            //call challenge
            collectStars.SpawnStar();
            MiniGameActive = true;
            IncreaseDistance();
        }
    }

    //Increases the target distance
    void IncreaseDistance()
    {
        TargetDistance *= 1.1f;
    }
}