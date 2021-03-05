using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    public void GotHit()
    {
        //Set Score.
        MiniGameManager.miniGameManager.OnComplete();
        Destroy(this.gameObject);
    }
}
