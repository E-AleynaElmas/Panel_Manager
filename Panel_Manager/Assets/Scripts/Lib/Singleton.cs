using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance
    {
        get
        {
            if (instance == null || instance.gameObject == null)
            {
                instance = UnityEngine.GameObject.FindObjectOfType<T>();
            }
            if (instance == null || instance.gameObject == null)
            {
                var newObject = new UnityEngine.GameObject(typeof(T).ToString());
                DontDestroyOnLoad(newObject);
                instance = newObject.AddComponent<T>();
            }
            return instance;
        }
    }
    private static T instance;
}