using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BoxJump : MonoBehaviour
{
    [SerializeField]
    private TMP_Text canvasText;

    [SerializeField]
    Slider h;
    [SerializeField]
    Slider w;

    void Start()
    {
        h.value = transform.localScale.y;
        w.value = transform.localScale.z;
    }
    public void Jump()
    {
        GetComponent<Rigidbody>().AddForce(0, 100, 0f);
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


}
