using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStackManager : MonoBehaviour
{
    public Stack<GameObject> uiStack = new Stack<GameObject>();
    public Button[] buttons;
    public GameObject[] popupUIs;


    void Start()
    {
        for (int i = 0; i < 3; i++)
{
    int index = i;
    buttons[i].onClick.AddListener(() =>
    {
        popupUIs[index].SetActive(true);
        uiStack.Push(popupUIs[index]);
    });
}

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject currUI = uiStack.Pop();
            currUI.SetActive(false);
        }
    }



}
