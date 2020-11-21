using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{
    public Text textBox;
    public string text;
    public float writeTime;

    private float timer;
    private int currChar = 0;
    private bool writing = false;

    private void Start()
    {
        if(GetComponent<Text>() != null)
            textBox = GetComponent<Text>();
    }

    public void Write()
    {
        textBox.text = "";
        currChar = 0;
        writing = true;
    }

    public void StopWriting()
    {
        writing = false;
    }

    public void ToggleWriting()
    {
        writing = !writing;
        if (writing) Write();
    }

    private void Update()
    {
        if (writing)
        {
            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                if (currChar != text.Length)
                {
                    currChar++;
                    textBox.text = text.Substring(0, currChar);
                    textBox.text += "<color=#00000000>" + text.Substring(currChar) + "</color>";
                } else textBox.text = text.Substring(0, currChar);
                timer += writeTime;
            }
        }
    }
}
