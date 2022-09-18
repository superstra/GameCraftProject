using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class captiontextscr : MonoBehaviour
{
    public int lifetime = 10;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 loc = new Vector3() ;// simply places the text above the characters head
        loc = transform.position;
        loc.y = loc.y+1;
        loc.z = loc.z+1;
        transform.position = loc;
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {     
        
    }
}
