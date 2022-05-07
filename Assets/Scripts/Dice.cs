using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dice : MonoBehaviour

{
    private Sprite[] diceSprites;
    private SpriteRenderer diceRenderer;
    public int diceResult;

    // Start is called before the first frame update
    void Start()
    {
        diceRenderer = GetComponent<SpriteRenderer>();
        diceSprites = Resources.LoadAll<Sprite>("Dice/");
    }

    // Run the "RolltheDice" function when the Event OnMouseDown occur.
    private void OnMouseDown(){
        StartCoroutine(RollTheDice());
    }

    // Roll the dice function random pick a number between 1 and 6.
    private IEnumerator RollTheDice(){
        
        for (int i = 0; i <= 20; i++){

            diceResult = Random.Range(0,6);
            diceRenderer.sprite = diceSprites[diceResult];
            yield return new WaitForSeconds(0.05f);
        }

        diceResult++;
    }
}
