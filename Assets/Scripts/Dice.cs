using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
    The Dice class.
    - Represent the Dice Game Object.
    - How it works ?
        1. The user click on the Dice.
        2. The dice diplay random face many times.
        3. Then stop at one random face
**/
public class Dice : MonoBehaviour

{
    // Unity Type variables declaration.
    private Sprite[] diceSprites;
    private SpriteRenderer diceRenderer;

    // C# variables declaration.
    private int diceTemporaryResult = 0;
    public int diceFinalResult = 0;

    // Start is called before the first frame update
    void Start()
    {
        // bind this game component to Sprite Renderer.
        diceRenderer = GetComponent<SpriteRenderer>();

        // Reading all Sprite in Dice directory to `DiceSprites`variable.
        diceSprites = Resources.LoadAll<Sprite>("Dice/");
    }

    // Run the "RolltheDice" function when the Event OnMouseDown occur.
    private void OnMouseDown(){
        // Call the function `RollTheDice
        StartCoroutine("RollTheDice");
    }

    // Roll the dice function random pick a number between 1 and 6.
    private IEnumerator RollTheDice(){

        for (int i = 0; i <= 10; i++){

            // Generating random number between 1 and 6.
            diceFinalResult = Random.Range(0,6);

            // Rendering a Sprite which correspond to the generated random number.
            diceRenderer.sprite = diceSprites[diceTemporaryResult];

            yield return new WaitForSeconds(0.05f);
        }

        // Returning the dice final result.
        diceFinalResult++;

    }
}
