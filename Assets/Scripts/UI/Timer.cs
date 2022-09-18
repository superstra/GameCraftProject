using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour {

    private float time;
    private TMP_Text text;
    private bool ended = false;

    void Start() {
        time = 0;
        text = gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update() {
        if (!ended) {
            time += Time.deltaTime;
            int seconds = (int)time % 60;
            int minutes = (int)time / 60;

            if (seconds < 10) {
                text.text = minutes + ":0" + seconds;
            } else {
                text.text = minutes + ":" + seconds;
            }

            if (minutes >= 5) {
                ended = true;
                endTimer();
            }
        }
    }

    private void endTimer() {
        Debug.Log("Try again");
    }
}
