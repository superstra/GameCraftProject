using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Timer : MonoBehaviour {

    public static event Action OnTimerStart;
    public static event Action OnTimerEnd;

    [SerializeField] float initialTime = 300;

    public static Timer instance;

    public float Time { get; private set; }
    private TMP_Text text;
    private bool ended = false;

    void Start() {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }

        Time = initialTime;
        text = gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update() {
        if (!ended) {
            Time -= UnityEngine.Time.deltaTime;
            int seconds = (int)Time % 60;
            int minutes = (int)Time / 60;

            if (seconds < 10) {
                text.text = minutes + ":0" + seconds;
            } else {
                text.text = minutes + ":" + seconds;
            }

            if (Time <= 0) {
                ended = true;
                endTimer();
            }
        }
    }

    private void endTimer() {
        GameManager.instance.StartGame();
    }
}
