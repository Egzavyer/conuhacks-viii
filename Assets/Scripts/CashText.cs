using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CashText : MonoBehaviour
{
    public TMP_Text cashText;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cashText.text = "$" + GameManager.cash.ToString();
    }
}
