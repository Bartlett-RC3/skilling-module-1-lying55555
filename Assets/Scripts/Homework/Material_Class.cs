using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Analytics;


namespace Materials
{


    public class Material_Class
    {
        //iii. Class extension
        string constructionMaterial;
        string structure;
        float quantity;


        public Material_Class(string _constructionMaterial, string _structure, float _quantity)
        {

            constructionMaterial = _constructionMaterial;
            structure = _structure;
            quantity = _quantity;

        }


        public string Getonstructionmaterial()
        {
            return constructionMaterial;
        }

        public string GetStructure()
        {
            return structure;
        }


        public float GetQuantity()
        {
            return quantity;
        }

        public void prepare()
        {

        }

        public void install()
        {

        }

        public void compelete()
        {

        }

    }





}

