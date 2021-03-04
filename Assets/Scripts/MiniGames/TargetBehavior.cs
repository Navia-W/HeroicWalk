using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    public void GotHit()
    {
        //Set Score.
        Destroy(this.gameObject);
    }
}
