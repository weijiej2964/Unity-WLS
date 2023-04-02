using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string name;

    public double weight, muscleMass, bodyFat;
        
    public int metabolism , determination;

    public Player(double w, double mass, double b, int d, int m)
    {
        name = "Bob";
        weight = w;
        muscleMass = mass * w;
        bodyFat = b * w;
        determination = d;
        metabolism = m;
       
    }

    public void setValues(double w, double mass, double b, int d, int m)
    {
        weight += w + b*10;
        muscleMass += mass;
        bodyFat += b;
        determination += d;
        metabolism += m;
    }
    
    public double getWeight()
    {
        return weight;
    }

    public string getName()
    {
        return name;
    }

    public int getMetabolism()
    {
        return metabolism;
    }

    public double getMuscleMass(){
        return muscleMass;
    }

    public double getBodyFat(){
        return bodyFat;
    }

    public int getDetermination(){
        return determination;
    }
}
