using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Notepad : MonoBehaviour, IPointerClickHandler {

    private bool isMoving;
    [SerializeField] float max;
    private float offSet;
    [SerializeField] float speed;
    private int direction;
    private bool isOpen;
    [SerializeField] GameObject tasksObject;
    private TMP_Text tasks;
    private List<ListItem> items;
    private string text;

    void Awake() {
        tasks = tasksObject.GetComponent<TMP_Text>();
    }

    void Start() {
        isMoving = false;
        direction = -1;
        isOpen = false;
        offSet = 0;
        CheckList.add(new ListItem("hello", "hello there"));
        CheckList.add(new ListItem("pizza", "I like pizza"));
    }

    // Update is called once per frame
    void Update() {
        if (isMoving) {
            transform.Translate(0.0f, speed * direction, 0.0f);
            offSet += speed;
        }

        if (offSet >= max) {
            isMoving = false;
            offSet = 0.0f;
            if (isOpen) {
                isOpen = false;
            } else {
                isOpen = true;
            }
        }

        if (Input.GetKeyDown("space")) {
            if (isOpen) {
                direction = 1;
            } else {
                direction = -1;
            }
            isMoving = true;
        }

        text = "";
        items = CheckList.GetAllItems();

        items.ForEach(delegate (ListItem item) {
            text += "• " + item.task + "\n";
        });

        tasks.text = text;
    }

    public void OnPointerClick(PointerEventData eventData) {
        if (isOpen) {
            direction = 1;
        } else {
            direction = -1;
        }
        isMoving = true;
    }

    public void toggle() {
        if (isOpen) {
            direction = 1;
        } else {
            direction = -1;
        }
        isMoving = true;
    }
}
