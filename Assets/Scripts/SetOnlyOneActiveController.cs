using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SetOnlyOneActiveController : MonoBehaviour
{
    public GameObject[] Objects;
    public GameObject Default;

    public void Start()
    {
        SetActive(Default);
    }
    public void SetActive(GameObject active)
    {
        foreach (var obj in Objects) obj.SetActive(false);
        active.SetActive(true);
    }
    public void SetDefault()
    {
        SetActive(Default);
    }
}
