using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CrystalCountUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI crystalCountText;

    private void Update()
    {
        crystalCountText.text = CrystalCollector.crystalCount.ToString();
    }
}
