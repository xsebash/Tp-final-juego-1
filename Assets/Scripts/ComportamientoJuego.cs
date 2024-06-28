using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoJuego : MonoBehaviour
{
    public Producto[] primerproducto;
    public Producto[] segundoproducto;

    void Comienzodejuego()

    {
        Producto producto1rndm = primerproducto[UnityEngine.Random.Range(0, primerproducto.Length - 1)];
        Producto producto2rndm = segundoproducto[UnityEngine.Random.Range(0, segundoproducto.Length - 1)];
        DeactivateAll();
    }

    void DeactivateAll()

    {
        foreach (Producto i in primerproducto)
        {
            i.gameObject.SetActive(false);
        }

        foreach (Producto i in segundoproducto)
        {
            i.gameObject.SetActive(false);
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


}
