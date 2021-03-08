using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectStars : MonoBehaviour
{
    public GameObject stepCounter;
    DistanceTracker distanceTracker;
    public Button starObj;
    public Text counter;
    bool spawned = false;
    int starAmount;

    private void Start()
    {
        starObj.gameObject.SetActive(false);
        distanceTracker = stepCounter.GetComponent<DistanceTracker>();
        starAmount = 0;
    }

    private void Update()
    {
        StarCounter();
    }

    public void SpawnStar()
    {
        if (spawned == false)
        {
            Vector3 starPosition = new Vector3(Random.Range(100f, 230f), Random.Range(150f, 500f), 0f);
            starObj.transform.position = starPosition;
            spawned = true;
            starObj.gameObject.SetActive(true);
        }
    }

    public void RemoveStar()
    {
        if (spawned == true)
        {
            distanceTracker.MiniGameActive = false;
            starAmount++;
            starObj.gameObject.SetActive(false);
            spawned = false;
        }
    }

    void StarCounter()
    {
        counter.text = starAmount.ToString();
    }

}