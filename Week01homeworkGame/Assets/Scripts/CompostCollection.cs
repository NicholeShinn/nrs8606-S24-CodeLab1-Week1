using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CompostCollection : MonoBehaviour
{
    public static int scoreValue = 0; //static means the variable belongs to the class rather than the object
    
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>(); // has to be text mesh pro, because I'm using that over normal text. This replaces the text in the text box.
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "A WORMS HUNGER FULFILLED: " + scoreValue; // displaying the score value on the screen
    }
}
