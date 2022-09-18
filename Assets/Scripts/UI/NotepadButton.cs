using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NotepadButton : MonoBehaviour, IPointerClickHandler {

    private Notepad notepad;
    [SerializeField] GameObject button;

    void Awake() {
        notepad = button.GetComponent<Notepad>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void OnPointerClick(PointerEventData eventData) {
        notepad.toggle();
    }
}
