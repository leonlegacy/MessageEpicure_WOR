using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Bluetooth))]
public class ControlScript : MonoBehaviour
{
    [Header("Find Device name and address.")]
    public string FindDevName = "BluetoothV3";
    public string FindDevAddr = "98:D3:32:30:24:49";

    [Space]
    public Text text_addr;
    public Text text_name;

    private void Awake()
    {
        Bluetooth.SetDevName(FindDevName);
        Bluetooth.SetDevAddr(FindDevAddr);
    }

    private void Start()
    {
        Bluetooth.openBT();
        Init();
    }

    private void Init()
    {
        Bluetooth.findBT();
        StartCoroutine(ShowDevName());
    }

    private IEnumerator ShowDevName()
    {
        yield return new WaitForEndOfFrame();
        string address = Bluetooth.GetPairAddress();
        string name = Bluetooth.GetPairName();

        if (address != null)
            text_addr.text = address;

        if (name != null)
            text_name.text = name;

        Bluetooth.Connect(address);
    }

    private void Send(byte[] data, string info)
    {
        Bluetooth.Write(data);
        Bluetooth.ShowSend(info);
    }

    public void Btn01Click()
    {
        byte[] senddata = new byte[] { (int)'A', 2 };
        Send(senddata, "Send: (byte) A");
    }

    public void Btn02Click()
    {
        byte[] senddata = new byte[] { (int)'B', 2 };
        Send(senddata, "Send: (byte) B");
    }
}