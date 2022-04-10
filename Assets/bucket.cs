using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bucket : MonoBehaviour
{
    private Vector2 screenBounds;

    private TMP_Text scoreBox;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds =
            Camera
                .main
                .ScreenToWorldPoint(new Vector3(Screen.width,
                    Screen.height,
                    Camera.main.transform.position.z));
    }

    public void Move(string direction)
    {
        if (direction == "left")
        {
            Vector3 position = transform.position;
            position.x = Mathf.Max(position.x - 2.0f, 23);
            transform.position = position;
        }
        else if (direction == "right")
        {
            Vector3 position = transform.position;
            position.x = Mathf.Min(position.x + 2.0f, 173);
            transform.position = position;
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move("left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Move("right");
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ball")
        {
            Destroy(coll.gameObject);
            scoreBox =
                (GameObject.FindWithTag("score")).GetComponent<TMP_Text>();
            scoreBox.BroadcastMessage("update_score", +1);
        }
    }
}
