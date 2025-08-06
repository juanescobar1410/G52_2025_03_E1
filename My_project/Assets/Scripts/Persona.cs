using UnityEngine;
using System;

namespace packagesPersona
{
    [Serializable]
    public class Persona
    {

        private string nameP;
        private string amilP;
        private string dirP;

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
