using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedRotator : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 peddirection;
    public GameObject ped;
    pedestrianMovement referenceScript = null;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {   
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        if (Equals(col.tag, "pedestrian"))
        {
            Debug.Log("is pedestrian");
            referenceScript = col.GetComponent<pedestrianMovement>();
            referenceScript.pedmovement = peddirection;
            
        }
    }

}