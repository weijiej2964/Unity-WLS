using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player 
{
    public string name;

    public double weight, muscleMass, bodyFat, metabolism;
        
    public int  determination;

    public Sprite ll, lm, lh, ml, mm, mh, hl, hm, hh;

    public Player(double w, double mass, double b, int d, double m, Sprite ll, Sprite lm, Sprite lh, Sprite ml, Sprite mm, Sprite mh, Sprite hl, Sprite hm, Sprite hh)
    {
        name = "Bob";
        weight = w;
        muscleMass = mass * w;
        bodyFat = b * w;
        determination = d;
        metabolism = m;

        this.ll = ll;
        this.lm = lm;
        this.lh = lh;
        this.ml = ml;
        this.mm = mm;
        this.mh = mh;
        this.hl = hl;
        this.hm = hm;
        this.hh = hh;

    }

    public void setValues(double w, double mass, double b, int d, double m)
    {
        weight += w;
        muscleMass += mass;
        bodyFat += b;
        determination += d;
        metabolism += m;

        Debug.Log(m);
        Debug.Log(metabolism);
    }
    
    public Sprite getCurrentPlayerBody()
    {
        if (bodyFat < weight*.08)
        {
            if (muscleMass < weight * .33)
            {
                return ll;
            }else if(muscleMass < weight * .39)
            {
                return lm;
            } else
            {
                return lh;
            }
        }
        else if (bodyFat <= weight * .19)
        {
            if (muscleMass < weight * .33)
            {
                return ml;
            }
            else if (muscleMass < weight * .39)
            {
                return mm;
            }
            else
            {
                return mh;
            }
        }
        else if (bodyFat > weight * .19)
        {
            if (muscleMass < weight * .33)
            {
                return hl;
            }
            else if (muscleMass < weight * .39)
            {
                return hm;
            }
            else
            {
                return hh;
            }
        }
        return ll;
    }


    public double getWeight()
    {
        return weight;
    }

    public string getName()
    {
        return name;
    }

    public double getMetabolism()
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
