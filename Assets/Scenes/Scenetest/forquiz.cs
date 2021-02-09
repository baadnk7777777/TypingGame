using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forquiz : MonoBehaviour
{
    public Text scoreansText;
    public Text questionText;
    public Text buttonText1;
    public Text buttonText2;
    public Text buttonText3;
    public Text buttonText4;

    public string question = "";
    public string answer1 = "";
    public string answer2 = "";
    public string answer3 = "";
    public string answer4 = "";

    public int correctAnswer = -1;
    static public int scoreans = 0;

    void Start()
    {
        questionText.text = question;
        buttonText1.text = answer1;
        buttonText2.text = answer2;
        buttonText3.text = answer3;
        buttonText4.text = answer4;
    }

    // Update is called once per frame
    void Update()
    {
        scoreansText.text = "score : "+scoreans;
        
    }
    private void setscore()
    {
        if((question == "Abide by")||(question == "Considerably")||(question == "Allocate")||(question == "Durable")||(question == "Appliance")||(question == "Convenient")||(question == "Specific")||(question == "Productive")||(question == "Task")||(question == "Collaborate")||(question == "Discount")||(question == "Inquary"))
                scoreans=0;
    }


    public void OnButton1Click()
    {
        if(correctAnswer == 1)
        {
            setscore();
            scoreans++;
        }   
        Application.LoadLevel(Application.loadedLevel+1);
    }

    public void OnButton2Click()
    {
        if(correctAnswer == 2)
        {
            setscore();
            scoreans++;
        }
        Application.LoadLevel(Application.loadedLevel+1);
    }

    public void OnButton3Click()
    {
        if(correctAnswer == 3)
        {
            setscore();
            scoreans++;
        }
        Application.LoadLevel(Application.loadedLevel+1);
    }

    public void OnButton4Click()
    {
        if(correctAnswer == 4)
        {
            setscore();
            scoreans++;
        }
        Application.LoadLevel(Application.loadedLevel+1);
    }

}
