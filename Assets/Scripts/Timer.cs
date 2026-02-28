using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
     private TMP_Text canvasText;
   
    // Update is called once per frame
    void Update()
    {
        canvasText.text = Time.time.ToString("0.0");
    }
}
