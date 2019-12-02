using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField inputA;
    public InputField inputB;
    public Button btnReset;
    public Button btnAddNumbers;

    public void SetResult()
    {
        result.text = AddNumbers().ToString();
        //set gui-elements active/inactive 
        inputA.interactable = false;
        inputB.interactable = false;
        btnAddNumbers.interactable = false;
        btnReset.interactable = true;
    }

    public void Reset()
    {
        inputA.text = "0";
        inputB.text = "0";
        result.text = "Result";
        inputA.interactable = true;
        inputB.interactable = true;
        btnAddNumbers.interactable = true;
        btnReset.interactable = false;
    }

    private int AddNumbers()
    {
        int tempResult = int.Parse(inputA.text) + int.Parse(inputB.text);
        return tempResult;
    }

}