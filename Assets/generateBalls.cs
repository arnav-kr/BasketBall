using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateBalls : MonoBehaviour
{
    public GameObject ball;

    public int xPos;

    public int count;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ballGenerator(1000));
    }

    IEnumerator ballGenerator(int n)
    {
        while (count < n)
        {
            if (ball == null)
            {
                break;
            }
            xPos = Random.Range(25, 170);
            Instantiate(ball, new Vector3(xPos, 155, 0), Quaternion.identity);
            count++;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
