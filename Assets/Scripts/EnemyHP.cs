using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public Slider hpSlider;
    public int fullHp;
    private int amountHp;

    // Start is called before the first frame update
    void Start()
    {
        hpSlider.maxValue = fullHp;
        hpSlider.value = 0;
        hpSlider.fillRect.gameObject.SetActive(false);
        amountHp = fullHp;
    }

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
