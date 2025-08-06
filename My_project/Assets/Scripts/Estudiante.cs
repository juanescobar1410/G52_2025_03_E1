using packagesPersona;
using UnityEngine;

namespace packagesPersona
{
    public class Estudiante : Persona
    {
        private string codeE;
        private string nameCareraE;
        
        public Estudiante()
        {
        }

        public Estudiante(string codeE, string nameCareraE)
        {
            this.codeE = codeE;
            this.nameCareraE = nameCareraE;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string NameCareraE { get => nameCareraE; set => nameCareraE = value; }
    }
}
