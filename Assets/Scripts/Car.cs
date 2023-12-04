using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject vfxTouch;

    [SerializeField] private int uniqueId;

    private bool isClicked = false;

    public int GetUniqueId()
    {
        return uniqueId;
    }

    private void OnMouseDown()
    {
        if (isClicked) return;
        isClicked = true;
        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].DestroyCarById(GetUniqueId());
    }

    public void DestroySelf()
    {
        GameObject vfx = Instantiate(vfxTouch, transform.position, Quaternion.identity) as GameObject;
        Destroy(vfx, 1f);
        gameObject.SetActive(false);
    }
}
