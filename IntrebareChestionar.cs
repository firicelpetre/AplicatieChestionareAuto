using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieChestionareAuto
{
    public class IntrebareChestionar
    {
        public string enuntIntrebare   { get; set; }
        public string variantaA        { get; set; }
        public string variantaB        { get; set; }
        public string variantaC        { get; set; }
        public string raspunsCorect    { get; set; }

        public bool VerificareRaspuns(string raspuns)
        {
            bool returnValue = false;

            if (raspuns == raspunsCorect)
            {
                returnValue = true;
            }

            return returnValue;
        }
    }
}
