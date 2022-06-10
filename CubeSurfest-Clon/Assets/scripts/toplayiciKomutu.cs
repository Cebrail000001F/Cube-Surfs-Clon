using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplayiciKomutu : MonoBehaviour
{
    GameObject anaKup;
     int yukseklik;
    void Start()
    {
        anaKup = GameObject.Find("Cube");   //cube objesini ariyor ve onu buluyor// sonra ana k]p olarak ayarliypr
    }
    public void yukseklikAzalt()   //engel icin
    {
        yukseklik--;
    }

    void Update()
    {
        anaKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Toplanan" &&other.gameObject.GetComponent<toplamaKomutu>().GetToplandiMi()==false) //toplanan tagi olan objeye carparsa , asagidaki islemleri yap
        {
            yukseklik += 1;
            other.gameObject.GetComponent<toplamaKomutu>().ToplandiYap();        //toplanan objeyi toplandi yap
            other.gameObject.GetComponent<toplamaKomutu>().indexAyarla(yukseklik);   //toplanan objenin yuksekligi
            other.gameObject.transform.parent = anaKup.transform;  //carpilan obje ana kupun konumuna gelecek
        }
    }
   
}
