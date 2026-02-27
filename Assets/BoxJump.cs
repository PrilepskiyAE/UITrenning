using UnityEngine;

public class BoxJump : MonoBehaviour
{
   public void Jump()
    {
        GetComponent<Rigidbody>().AddForce(0,100,0f);
    }
}
