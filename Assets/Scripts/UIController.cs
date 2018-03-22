using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

    public static UIController instance;
    public GameObject ScrollUI;
    public GameObject CancelBtn;
    public GameObject Grid;
    public GameObject Shop;

    void Awake()
    {
        instance = this;
    }

    public void Clicked_1 () 
    {
        MainController.instance.SpawnBuilding("3x3 House 1");
        DisableScrollUI();
    }

    public void Clicked_2() 
    {
        MainController.instance.SpawnBuilding("3x3 House 3");
        DisableScrollUI();
    }

    public void Clicked_3()
    {
        MainController.instance.SpawnBuilding("3x3 House 2");
        DisableScrollUI();
    }

    public void Clicked_4()
    {
        MainController.instance.SpawnBuilding("3x3 House 4");
        DisableScrollUI();
    }

    public void Clicked_5()
    {
        MainController.instance.SpawnBuilding("3x3 Tower");
        DisableScrollUI();
    }

    public void Clicked_6()
    {
        MainController.instance.SpawnBuilding("5x5 House 1");
        DisableScrollUI();
    }

    public void Clicked_7()
    {
        MainController.instance.SpawnBuilding("5x5 House 2");
        DisableScrollUI();
    }

    public void Clicked_8()
    {
        MainController.instance.SpawnBuilding("7x7 Tree");
        DisableScrollUI();
    }


    public void EnableScrollUI()
    {
        MainController.instance.DestroyCurrentBuilding();
        ScrollUI.SetActive(true);
        CancelBtn.SetActive(false);
    }

    public void GridBtn()
    {
        if(Grid.activeSelf == true)
        {
            Grid.SetActive(false);
        }
        else if(Grid.activeSelf == false)
        {
            Grid.SetActive(true);
        }
    }

    public void ShopBtn()
    {
        if (Shop.activeSelf == true)
        {
            Shop.SetActive(false);
        }
        else if (Shop.activeSelf == false)
        {
            Shop.SetActive(true);
        }
    }

    public void DisableScrollUI()
    {

        ScrollUI.SetActive(false);
        CancelBtn.SetActive(true);
    }


}
