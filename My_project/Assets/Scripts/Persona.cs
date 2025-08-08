using UnityEngine;
using System;

namespace packagePersona
{
    [Serializable]
    public class Persona
    {

        public string nameP;
        public string amilP;
        public string dirP;

        public Persona()
        {
        }

        public Persona(string nameP, string amilP, string dirP)
        {
            this.nameP = nameP;
            this.amilP = amilP;
            this.dirP = dirP;
        }

        public string NameP { get => nameP; set => nameP = value; }
        public string AmilP { get => amilP; set => amilP = value; }
        public string DirP { get => dirP; set => dirP = value; }
    }

            
            

 }
