using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlugin : MonoBehaviour
{
    const string packageName = "com.example.mylibrary"; //Ruta del paquete
    const string className = packageName + ".WilliamsLogger"; //Nombre del paquete + la clase a la que se quiere acceder

    //No puedo correr esto en plataformas que no sean android (ni siquiera va a compilar)
//#if UNITY_ANDROID
    AndroidJavaClass pluginClass;
    AndroidJavaObject pluginInstance;

    // Start is called before the first frame update
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android) 
        {
            pluginClass = new AndroidJavaClass(className);

            pluginInstance = pluginClass.CallStatic<AndroidJavaObject>("getInstance");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android) 
        {
            pluginInstance.Call<string>("getLogtag"); //Ojo con los metodos que tienen static y los que no
        }
    }
//#endif
}
