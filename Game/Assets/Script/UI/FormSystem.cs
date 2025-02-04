using UnityEngine;
using UnityEngine.UI;

public class FormSystem : MonoBehaviour
{
    public GameObject formPanel;

    public void OpenForm()
    {
        formPanel.SetActive(true);
    }

    public void CloseForm()
    {
        formPanel.SetActive(false);
    }
}
