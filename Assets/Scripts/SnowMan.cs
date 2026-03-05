using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class SnowMan : MonoBehaviour
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
    private List<GameObject> noses;

    [SerializeField]
    private List<Renderer> renderer;

    [SerializeField]
    private TMP_Text nameText;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        h.value = transform.localScale.y;
        w.value = transform.localScale.z;
    }

 public void SetHeight(float value)
    {
        transform.localScale = new Vector3(transform.localScale.x,value,transform.localScale.z);
    }

     public void SetWiht(float value)
    {
        transform.localScale = new Vector3(value,transform.localScale.y,value);
    }

    public void SetNose(int index)
    {
        for(int i = 0; i < noses.Count; i++) {
         noses[i].SetActive(i==index);   
        }
    }

     public void SetMatrial(Material material)
    {
        for(int i = 0; i < renderer.Count; i++) {
           renderer[i].material = material; 
        }
        
    }

       public void SetCap(int index)
    {
        for(int i = 0; i < caps.Count; i++) {
         caps[i].SetActive(i==index);   
        }
    }


}
