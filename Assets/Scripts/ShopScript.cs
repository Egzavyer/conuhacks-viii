using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopScript : MonoBehaviour
{

    public GameObject shopItemName1;
    public GameObject shopItemName2;
    public GameObject shopItemName3;
    public GameObject shopItemPrice1;
    public GameObject shopItemPrice2;
    public GameObject shopItemPrice3;
    public GameObject shopItemButton1;
    public GameObject shopItemButton2;
    public GameObject shopItemButton3;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.shopOpen)
        {
            shopItemName1.GetComponent<TMP_Text>().text = "Assault Rifle";
            shopItemName2.GetComponent<TMP_Text>().text = "Shotgun";
            shopItemName3.GetComponent<TMP_Text>().text = "Pistol Upgrade";
            shopItemPrice1.GetComponent<TMP_Text>().text = "$40";
            shopItemPrice2.GetComponent<TMP_Text>().text = "$20";
            shopItemPrice3.GetComponent<TMP_Text>().text = "$10";
            shopItemButton1.GetComponent<UnityEngine.UI.Button>().interactable = true;
            shopItemButton2.GetComponent<UnityEngine.UI.Button>().interactable = true;
            shopItemButton3.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
    }

    public void BuyItem1()
    {
        if (PlayerPrefs.GetInt("coins") >= 40)
        {
            Time.timeScale = 1;
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 40);
            shopItemName1.GetComponent<TMP_Text>().text = "Bought";
            shopItemPrice1.GetComponent<TMP_Text>().text = "";
            shopItemButton1.GetComponent<UnityEngine.UI.Button>().interactable = false;
            Time.timeScale = 0;
        }

    }

    public void BuyItem2()
    {
        if (PlayerPrefs.GetInt("coins") >= 20)
        {
            Time.timeScale = 1;
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 20);
            shopItemName2.GetComponent<TMP_Text>().text = "Bought";
            shopItemPrice2.GetComponent<TMP_Text>().text = "";
            shopItemButton2.GetComponent<UnityEngine.UI.Button>().interactable = false;
            Time.timeScale = 0;
        }

    }

    public void BuyItem3()
    {
        if (PlayerPrefs.GetInt("coins") >= 10)
        {
            Time.timeScale = 1;
            Debug.Log("Bought");
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 10);
            shopItemName3.GetComponent<TMP_Text>().text = "Bought";
            shopItemPrice3.GetComponent<TMP_Text>().text = "";
            shopItemButton3.GetComponent<UnityEngine.UI.Button>().interactable = false;
            //Time.timeScale = 0;
        }
    }
}
