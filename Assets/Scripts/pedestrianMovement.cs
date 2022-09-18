using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedestrianMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 pedmovement;
    public string thecaption = "hello there";
    public GameObject captiontext;
    float cooldowncount = 0;
    float cooldown = 12;
    //scooldown is the cooldown on the sound effect
    float scooldowncount = 0;
    float scooldown = 2;
    // Update is called once per frame
    void Update()
    {
        if (cooldowncount> 0f)// counts down for the cool down
            cooldowncount += -Time.deltaTime;
        else
            cooldowncount = 0f;
        if (scooldowncount> 0f)// counts down for the cool down
            scooldowncount += -Time.deltaTime;
        else
            scooldowncount = 0f;
    }
     // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        // gets position + adds a movement * multiplied by the speed * smooth movement modifier
        rb.MovePosition(rb.position + pedmovement * Time.fixedDeltaTime);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        string collidedname= col.gameObject.name;
        if (collidedname.Equals("Player")) // if the object it collided with was the player and if the cooldown has expired 
        {
            if (cooldowncount == 0)
            {
                cooldowncount = cooldown;
                GameObject textobj = Instantiate(captiontext, gameObject.transform );
                textobj.GetComponent<TextMesh>().text = thecaption;
            }
            if (scooldowncount == 0)
            {
                int randsound = Random.Range(1,4);
                Debug.Log(randsound);
                scooldowncount = scooldown;
                if (randsound == 1)
                    Debug.Log("play hitsound1");
                else if (randsound == 2)
                    Debug.Log("play hitsound2");
                else 
                    Debug.Log("play hitsound3");
            }
        }   
    }
}
