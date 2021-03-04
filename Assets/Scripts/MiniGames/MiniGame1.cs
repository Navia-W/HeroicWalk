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

    void Update()
    {
#if UNITY_ANDROID
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                RaycastHit hit;
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                // Send message if hit
                if (Physics.Raycast(ray, out hit))
                {
                    Transform objectHit = hit.transform;

                    objectHit.SendMessage("GotHit", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
#endif

#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;

                Debug.Log(objectHit.gameObject.name);
                objectHit.gameObject.SendMessage("GotHit", SendMessageOptions.DontRequireReceiver);
            }
        }
#endif
    }
}
