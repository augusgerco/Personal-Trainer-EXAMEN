using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string tipoEntrenamiento;
    public int cantidadHorasSemanales;

    string entrenamientoCardio = "C";
    string entrenamientoFuerza = "F";
    string entrenamientoRecreativo = "R";

    int precioHoraCardio = 1000;
    int precioHoraFuerza = 1500;
    int precioHoraRecreativo = 2500;

    int maximoHorasSemanales = 6;

    float descuentoTotal = 0.9f;
    float subtotalACobrar = 0;
    float totalACobrar = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(cantidadHorasSemanales < 1 && cantidadHorasSemanales > 6){
            Debug.LogError("Error. La cantidad de horas debe ser mayor que 0 y menor que 6");
            return;
        }
        if(tipoEntrenamiento != entrenamientoCardio && tipoEntrenamiento != entrenamientoFuerza && tipoEntrenamiento != entrenamientoRecreativo){
            Debug.LogError("Error. Debe ingresar un codigo de entrenamiento correcto (C, F u R)."); ;
            return;
        }
        if(tipoEntrenamiento == entrenamientoCardio){
            subtotalACobrar = subtotalACobrar + precioHoraCardio * cantidadHorasSemanales;
        }
        if(tipoEntrenamiento == entrenamientoFuerza){
            subtotalACobrar = subtotalACobrar + precioHoraFuerza * cantidadHorasSemanales;
        }
        if (tipoEntrenamiento == entrenamientoRecreativo){
            subtotalACobrar = subtotalACobrar + precioHoraRecreativo * cantidadHorasSemanales;
        }
        if(cantidadHorasSemanales == maximoHorasSemanales){
            totalACobrar = totalACobrar + subtotalACobrar * descuentoTotal;
            Debug.Log("")
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
