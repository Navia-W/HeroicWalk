using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1 : MonoBehaviour
{
    public float range = 1;

    [SerializeField]
    private GameObject _target;

    void Start()
    {
        Vector2 rPos = Random.insideUnitCircle * range;
        Vector3 sPos = new Vector3(rPos.x, 0, rPos.y);
        Instantiate(_target, sPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
