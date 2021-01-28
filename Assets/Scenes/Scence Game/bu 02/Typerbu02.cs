using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typerbu02 : MonoBehaviour
{
    public WordBankbu02 WordBankbu02 = null;
    public Text wordOutput = null;



    private string remainingWord = string.Empty;
    private string currentWord = string.Empty;

    public AudioSource someSound;
    public AudioSource someSoundfill;
    // Start is called before the first frame update
    private void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()
    {
        //get bank word
        currentWord = WordBankbu02.GetWord();
        SetRemainingWord(currentWord);
        GameComtrolScript.health += 1;
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord;
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
    }



    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {

            string keysPressed = Input.inputString;


            if (keysPressed.Length == 1)

                Input.GetMouseButtonDown(0);

            EnterLetter(keysPressed);

        }
    }
    /// ////////////////////////////////////////////////////////////////////////////////////////
    private void EnterLetter(string typedLetter)
    {
        if (IsCorrectLetter(typedLetter))
        {

            someSound.Play();
            someSoundfill.Stop();
            Score.scoreValue += 2;
            RemoveLetter();

            if (IsWordComplete())

                SetCurrentWord();


        }
    }

    /// ////////////////////////////////////////////////////////////////////////////////////////

    private bool IsCorrectLetter(string letter)
    {

        Score.scoreValue -= 1;
        someSoundfill.Play();
        GameComtrolScript.health -= 1;

        return remainingWord.IndexOf(letter) == 0;




    }
    /// ////////////////////////////////////////////////////////////////////////////////////////
    private void RemoveLetter() //ลบตัวหนังสือ
    {

        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {
        GameComtrolScript.health += 1;
        return remainingWord.Length == 0;
    }
}
