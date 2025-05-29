using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keep : MonoBehaviour
{
    public static Keep Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // giữ lại qua các scene
        }
        else if (Instance != this)
        {
            Destroy(gameObject); // huỷ object trùng khi quay lại scene menu
        }
    }


}
