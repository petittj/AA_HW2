using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0f;

    public Dropdown MyDropDown;
    public Text MyChoice;

    // Update is called once per frame
    public void speedChoice()
    {
        switch (MyDropDown.value)
        {
            case 1:
                speed = 100f;
                break;
            case 2:
                speed = 200f;
                break;
            case 3:
                speed = 800f;
                break;
            default:
                MyChoice.text = "Please Select";
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
     
    }
}
