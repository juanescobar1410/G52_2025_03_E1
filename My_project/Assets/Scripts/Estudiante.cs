using packagePersona;
using System;
using UnityEngine;

namespace packagePersona
{
    [Serializable]
    public class Estudiante : Persona
    {
        
        public string codeE;
        public string nameCarreraE;
        
        public Estudiante()
        {
        }

        public Estudiante(string codeE, string nameCarreraE, string nameP, string amilP, string dirP)
            : base(nameP, amilP, dirP)
        {
            this.codeE = codeE;
            this.nameCarreraE = nameCarreraE;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string NameCarreraE { get => nameCarreraE; set => nameCarreraE = value; }
    }
}
