using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Captionscript : MonoBehaviour
{
    public string thecaption = "hello there";
    public GameObject captiontext;
    float cooldowncount = 0;
    float cooldown = 12;
    // Start is called before the first frame update
    void Start()
    {  
    }
    // Update is called once per frame
    void Update()
    {
        if (cooldowncount> 0f)// counts down for the cool down
            cooldowncount += -Time.deltaTime;
        else
            cooldowncount = 0f;
    }
    // when an object collides with
    void OnTriggerEnter2D(Collider2D col)
    {
        string collidedname= col.gameObject.name;
        if ((collidedname.Equals("Player")) & (cooldowncount == 0)) // if the object it collided with was the player and if the cooldown has expired 
        {
            Debug.Log("collison");
            cooldowncount = cooldown;
            GameObject textobj = Instantiate(captiontext, col.gameObject.transform );
            textobj.GetComponent<TextMesh>().text = thecaption;
        }   
    }
}
