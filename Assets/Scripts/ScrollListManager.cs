using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollListManager : MonoBehaviour
{
    public List<Button> buttons;

    void Start()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            int index = i;
            buttons[i].onClick.AddListener(() => OnButtonClick(index));
        }
    }

    void OnButtonClick(int index)
    {
        Destroy(buttons[index].gameObject);
        buttons.RemoveAt(index);

        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].onClick.RemoveAllListeners();

            int newIndex = i;
            buttons[i].onClick.AddListener(() => OnButtonClick(newIndex));
        }

        if (buttons.Count == 0)
        {
            Debug.Log("No more buttons left!");
        }
    }
}