using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_wall_circle : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTagR;
    [SerializeField] string triggeringTagL;
    [SerializeField] string triggeringTagU;
    [SerializeField] string triggeringTagD;

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == triggeringTagR || other.tag == triggeringTagL)
        {
            this.transform.position = new Vector3(this.transform.position.x*-1, this.transform.position.y, this.transform.position.z);
        }

        if (other.tag == triggeringTagU || other.tag == triggeringTagD)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y * -1, this.transform.position.z);
        }
       

    }
    
}
