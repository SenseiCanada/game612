using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTextController : MonoBehaviour
{
    private int TextNumber;
    public TMP_Text DialogueText;

    // Start is called before the first frame update
    void Start()
    {
        FootprintCollision.OnCollideFootprint += IncreaseTextNumber;
        TextNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (TextNumber == 1)
        {
            DialogueText.text = "Think of the stories we'll tell about this moment.";
        }
        if (TextNumber == 2)
        {
            DialogueText.text = "They haven't even added ground assets, but look up.";
        }
        if (TextNumber == 3)
        {
            DialogueText.text = "Imagine the world that we'll walk through under this sky.";
        }
        if (TextNumber == 4)
        {
            DialogueText.text = "They really should have added something else by now. A rock. Or an NPC...";
        }
        if (TextNumber == 5)
        {
            DialogueText.text = "I bet the devs are cooking up something... yes, something just marvelous. That's why it's taking so long.";
        }
        if (TextNumber == 6)
        {
            DialogueText.text = "No, it's ok, we don't have to talk anymore if you're feeling tired.";
        }
        if (TextNumber == 7)
        {
            DialogueText.text = "It's really fine if you want to go. I'll just go find you at your respawn as soon as the new build drops.";
        }

        if (TextNumber == 8)
        {
            DialogueText.text = "I wish I could hold hands with someone right now.";
        }
    }

    private void IncreaseTextNumber()
    {
        TextNumber++;
    }

    void OnDisable()
    {
        FootprintCollision.OnCollideFootprint -= IncreaseTextNumber;
    }
}
