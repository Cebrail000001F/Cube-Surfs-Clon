using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplamaKomutu : MonoBehaviour
{
    bool toplandiMi;
    int index;
    public toplayiciKomutu ToplayiciKomutu;
    private void Start()
    {
        toplandiMi = false;  //kup daha toplanma di
    }
    private void Update() // toplanan kuplere duzfun  bir sek'lde ust uste koymak
    {
        if (toplandiMi==true)  // eger kup doplandiysa
        {
            if (transform.parent!=null) //ve bu birinin parenti ise
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }  
    }
    
    private void OnTriggerEnter(Collider other)  //engele carptiginda yukseklik azalmasi
    {
        if (other.gameObject.tag==("Engel")) //carpilan objenin etiketi engel ise
        {
            ToplayiciKomutu.yukseklikAzalt();
            this.transform.parent=null;  //engele carptigi zaman.. engel boyu kadar kup.. artik parenten cikiyor.. ve konumu orada kaliyor

            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GetToplandiMi ()
    {
        return toplandiMi;      //bool degerini dondur
    }
    public void ToplandiYap()
    {
        toplandiMi=true;  //eger true ise toplandi yap// degilse; topla
    }
    public void indexAyarla(int index)
    {
        this.index = index;
    }
}
