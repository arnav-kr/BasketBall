using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject bucket;

    private bool ispressed = false;

    void start()
    {
        bucket = GetComponent<GameObject>();
    }

    void Update()
    {
        if (!ispressed) return;

        bucket.BroadcastMessage("Move", "right");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
