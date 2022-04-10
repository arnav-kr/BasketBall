using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ballLogic : MonoBehaviour
{
    private TMP_Text scoreBox;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -0)
        {
            Destroy (gameObject);
            scoreBox =
                (GameObject.FindWithTag("score")).GetComponent<TMP_Text>();
            scoreBox.BroadcastMessage("heart", 1);
        }
    }
}
