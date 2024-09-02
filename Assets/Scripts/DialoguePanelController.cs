using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class DialoguePanelController : MonoBehaviour
{
    public GameObject offscreenObj;
    public GameObject dialoguePanel;
    public GameObject parentObj;
    public TMP_Text dialogueText;
    private float countdown = 4f;
    private bool isOnscreen;
    // Start is called before the first frame update
    void Start()
    {
        FootprintCollision.OnCollideFootprint += ShowPanel;
        isOnscreen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnscreen)
        {
            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                isOnscreen = false;
                countdown = 4f;
                HidePanel();
            }
        }
    }

    public void ShowPanel()
    {
        dialoguePanel.transform.position = parentObj.transform.position;
        isOnscreen = true;
    }

    public void HidePanel()
    {
        dialoguePanel.transform.position = offscreenObj.transform.position;
    }

    void OnDisable()
    {
        FootprintCollision.OnCollideFootprint -= ShowPanel;
    }
}
