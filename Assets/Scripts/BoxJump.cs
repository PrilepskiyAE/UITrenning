using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class BoxJump : MonoBehaviour
{
    [SerializeField]
    private TMP_Text canvasText;

    [SerializeField]
    Slider h;
    [SerializeField]
    Slider w;

    [SerializeField]
    private List<GameObject> caps;

    [SerializeField]
    private Renderer renderer;

    [SerializeField]
    private TMP_Text nameText;

    public void SetCap(int index)
    {
        for(int i = 0; i < caps.Count; i++) {
         caps[i].SetActive(i==index);   
        }
    }

    void Start()
    {
        h.value = transform.localScale.y;
        w.value = transform.localScale.z;
    }
    public void Jump()
    {
        GetComponent<Rigidbody>().AddForce(0, 300, 0f);
    }

    public void ChangeMass(float delta)
    {
        float result = GetComponent<Rigidbody>().mass + delta;
        result = Mathf.Clamp(result, 1, 50);
        GetComponent<Rigidbody>().mass = result;
        canvasText.text = result.ToString("0.0");
    }

    public void SetHeight(float value)
    {
        transform.localScale = new Vector3(transform.localScale.x,value,transform.localScale.z);
    }

     public void SetWiht(float value)
    {
        transform.localScale = new Vector3(value,transform.localScale.y,value);
    }

 public void SetMatrial(Material material)
    {
        renderer.material=material;
    }

    public void SetName(String name)
    {
        nameText.text=name;
    }
    
}
