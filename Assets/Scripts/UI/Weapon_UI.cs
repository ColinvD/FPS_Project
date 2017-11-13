using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon_UI : MonoBehaviour {

    public enum weapon {pistol, assault_rifle, raygun, unknown };
    public Sprite[] weaponPics = new Sprite[8];
    public GameObject placeholder;

    private weapon selected = weapon.unknown;
    private Image placeholderImg;
    private RectTransform rt;

    void Start()
    {
        placeholder = GetComponent<GameObject>();
        rt = placeholder.GetComponent(typeof(RectTransform)) as RectTransform;
        placeholderImg = placeholder.GetComponent<Image>();        
    }

    void Update () {
        replacePlaceholder();
	}

    private void replacePlaceholder()
    {
        switch (selected)
        {
            case weapon.unknown:
                placeholderImg.sprite = weaponPics[8];
                rt.sizeDelta = new Vector2(60,100);
                rt.localScale = new Vector2(0.6f,1);
                break;
            case weapon.pistol:
                placeholderImg.sprite = weaponPics[0];
                rt.sizeDelta = new Vector2(100, 100);
                rt.localScale = new Vector2(1, 1);
                break;
            case weapon.assault_rifle:
                placeholderImg.sprite = weaponPics[1];
                rt.sizeDelta = new Vector2(180, 180);
                rt.localScale = new Vector2(1, 1);
                break;
            case weapon.raygun:
                placeholderImg.sprite = weaponPics[2];
                rt.sizeDelta = new Vector2(100, 100);
                rt.localScale = new Vector2(-1, 1);
                break;
        }
    }

    public void SetWeapon(weapon Suggest)
    {
        selected = Suggest;
    }

    public weapon GetWeapon()
    {
        weapon res = selected;

        return res;
    }
}
