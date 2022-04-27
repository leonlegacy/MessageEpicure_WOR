using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//using System.IO.Ports;
using UnityEngine.UI;

public class BT_script : MonoBehaviour
{
    //[SerializeField] SerialPort sp;
    [SerializeField] string port = "COM5";
    [SerializeField] int speed = 115200;
    [SerializeField] InputField inputString;

    /*
    public void openConnection()
    {
        if (sp == null)
        {
            sp = new SerialPort(port, speed, Parity.None, 8, StopBits.One);
        }
        if (sp != null)
        {
            if (!sp.IsOpen)
            {
                try
                {
                    sp.Open();
                    sp.ReadTimeout = 100;
                    Debug.Log("Port opened");
                }catch(System.Exception e)
                {
                    Debug.LogWarning(e.ToString());
                }
            }
        }
    }
    */

    /*
    public void closeConnection()
    {
        if(sp != null && sp.IsOpen)
        {
            try
            {
                sp.Close();
            }catch(System.Exception e)
            {
                Debug.LogWarning(e.ToString());
            }
        }
    }
    */

    /*
    public void sendMessage()
    {
        try
        {
            sp.Write(inputString.text);
        }catch(System.Exception e)
        {
            Debug.LogWarning(e.ToString());
        }
    }
    */
}
