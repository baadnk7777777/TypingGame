using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{

    public TextMeshProUGUI output;

    public void HandleInputData(int val)
    {
        if(val == 0)
        {
            output.text = "Bussiness";
        }

        if (val == 1)
        {
            output.text = "office";
        }
        

    }


}
