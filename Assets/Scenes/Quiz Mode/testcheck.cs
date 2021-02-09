using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testcheck : MonoBehaviour
{
    //busines test
    public void OnButtonTCB1Click()
    {
        Application.LoadLevel(23);
    }
    public void OnButtonTCB2Click()
    {
        Application.LoadLevel(29);
    }
    public void OnButtonTCB3Click()
    {
        Application.LoadLevel(35);
    }
    public void OnButtonTCB4Click()
    {
        Application.LoadLevel(41);
    }
    //office test
    public void OnButtonTCO1Click()
    {
        Application.LoadLevel(47);
    }
    public void OnButtonTCO2Click()
    {
        Application.LoadLevel(53);
    }
    public void OnButtonTCO3Click()
    {
        Application.LoadLevel(59);
    }
    public void OnButtonTCO4Click()
    {
        Application.LoadLevel(65);
    }
    //purchasing test
    public void OnButtonTCP1Click()
    {
        Application.LoadLevel(71);
    }
    public void OnButtonTCP2Click()
    {
        Application.LoadLevel(77);
    }
    public void OnButtonTCP3Click()
    {
        Application.LoadLevel(83);
    }
    public void OnButtonTCP4Click()
    {
        Application.LoadLevel(89);
    }
    // //back
    

    public void backtoMenu()
    {
        Application.LoadLevel(0);
    }

    

    public void OnButtonlevelbackClick()
    {
        Application.LoadLevel(19);
    }

    //busines mode
    public void OnButtonTCBClick()
    {
        Application.LoadLevel(20);
    }
    //purchasing mode
    public void OnButtonTCPClick()
    {
        Application.LoadLevel(22);
    }
    //office mode
    public void OnButtonTCOClick()
    {
        Application.LoadLevel(21);
    }
}
