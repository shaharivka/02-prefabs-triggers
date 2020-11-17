using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Trigger_wall_block : MonoBehaviour
{
    [SerializeField] string triggeringTagR;
    [SerializeField] string triggeringTagL;
    [SerializeField] string triggeringTagU;
    [SerializeField] string triggeringTagD;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("On wall");
        if (other.tag == triggeringTagR)
        {

            this.transform.position = new Vector3(this.transform.position.x - 0.5f, this.transform.position.y, this.transform.position.z);
        }
        if (other.tag == triggeringTagL)
        {
            Debug.Log("On wall Left");
            this.transform.position = new Vector3(this.transform.position.x + 0.5f, this.transform.position.y, this.transform.position.z);
        }
        if (other.tag == triggeringTagU)
        {
            Debug.Log("On wall Up");
            this.transform.position = new Vector3(this.transform.position.x , this.transform.position.y - 0.5f, this.transform.position.z);
        }
        if (other.tag == triggeringTagD)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+0.5f, this.transform.position.z);
        }



    }
}
