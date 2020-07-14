using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.CLEANCODE
{
    public class ExampleFour
    {
        //Evitar condicionais longas
        public bool VerificarNumeroImpar(int numero)
        {
            if (numero == 1)
            {
                return true;
            }
            else
            {
                if (numero == 2)
                {
                    return false;
                }
                else
                {
                    if (numero == 3)
                    {
                        return true;
                    }
                    else
                    {
                        if (numero == 4)
                        {
                            return false;
                        }
                    }
                }
            }


            return false;
        }

        public bool VerificarNumeroImparCorreto(int numero)
        {
            if (numero % 2 == 1)
            {
                return true;
            }

            return false;
        }
    }
}
