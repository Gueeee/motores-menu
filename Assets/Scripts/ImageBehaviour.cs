using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImageBehaviour : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public Image image;
    public Sprite newSprite;
    public GameObject myShot; // Prefab
    public Transform Canvas; // Assign the Canvas Transform here
    public void ShowImage()
    {
        if(image != null) image.enabled = true;
    }

    public void HideImage()
    {
        if(image != null) image.enabled = false;
    }

    public void ChangeImage()
    {
        if(image != null) image.sprite = newSprite;
    }

    void Start()
    {
        HideImage();
    }

    public void OnSelect(BaseEventData eventData)
    {
        ShowImage();
    }

    public void OnDeselect(BaseEventData eventData)
    {
        HideImage();
    }
    
    void Update() {
        if (image != null)
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {
                ChangeImage();

                if (image.enabled == true)
                {
                    GameObject Shot = Instantiate(myShot, new Vector3(-80f, -122f + image.transform.position.y, 1f), image.transform.rotation);
                    Shot.transform.SetParent(Canvas, false);
                }
            }
        }
    }
}
