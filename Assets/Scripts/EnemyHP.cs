using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Makes enemy get damage from player arrows
public class EnemyHP : MonoBehaviour
{
    [SerializeField]
    private Slider hpSlider;

    [SerializeField]
    private int fullHp;

    private int amountHp;

    void Start()
    {
        hpSlider.maxValue = fullHp;
        hpSlider.value = 0;
        hpSlider.fillRect.gameObject.SetActive(false);
        amountHp = fullHp;
    }

    // ABSTRACTION
    public void GettingDamage(int dmgAmount)
    {
        amountHp -= dmgAmount;
        hpSlider.fillRect.gameObject.SetActive(true);
        hpSlider.value = fullHp - amountHp;

        if (amountHp <= 0)
        {
            Destroy(gameObject);
        }
    }

}
