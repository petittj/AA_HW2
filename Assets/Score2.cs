using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    void Update()
    {
        text.text = Score.PinCount.ToString();
    }
}
