using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links : MonoBehaviour
{
    public void Open(string link)
    {
        Application.OpenURL (link);
    }
}
