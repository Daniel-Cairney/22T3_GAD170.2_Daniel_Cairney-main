using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CairneyDaniel
{
    public class Fishes : MonoBehaviour
    {
        string fishSpecies;



        static void main(string[] args)
        {
            List<string> fishSpecies = new List<string>();

            fishSpecies.Add("Damselfish");
            fishSpecies.Add("Ebonkoi");
            fishSpecies.Add("Golden Karp");
            fishSpecies.Add("Prismite");
            fishSpecies.Add("Flarekin Koi");
            fishSpecies.Add("Bass");
            fishSpecies.Add("Flounder");

            string randomFish = fishSpecies[Random.Range(0, fishSpecies.Count)];

            // Start is called before the first frame update
            void Start()
            {

            }

            // Update is called once per frame
            void Update()
            {

            }
        }
    }
}