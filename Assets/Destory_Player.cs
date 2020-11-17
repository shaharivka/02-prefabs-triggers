using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory_Player : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] int life = 3;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            if (life == 0)
            {
                Destroy(this.gameObject);
            }
            else
            {
                life = life - 1;
            }
            Destroy(other.gameObject);
        }
    }

}


   