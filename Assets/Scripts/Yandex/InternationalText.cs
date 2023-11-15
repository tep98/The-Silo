using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InternationalText : MonoBehaviour
{
    [SerializeField] string _en;
    [SerializeField] string _ru;

    private void Start()
    {
        if (Language.Instance.currentLanguage == "en")
        {
            GetComponent<TextMeshPro>().text = _en;
        }
        else if (Language.Instance.currentLanguage == "ru")
        {
            GetComponent<TextMeshPro>().text = _ru;
        }
        else
        {
            GetComponent<TextMeshPro>().text = _en;
        }
    }

}
