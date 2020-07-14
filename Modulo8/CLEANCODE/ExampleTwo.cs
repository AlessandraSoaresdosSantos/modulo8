using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo8.CLEANCODE
{
    public class ExampleTwo
    {
        //Evitar parâmetros que possam ser extraídos dentro do método 
        //Muitos parâmetros atraplham na reutilização do código    

        public bool VerificarNumeroLista(int contagem, List<int> listaNumeros, int numeroProcurado)
        {
            for (int i = contagem; i < listaNumeros.Count; i++)
            {
                if (listaNumeros[i] == numeroProcurado)
                {
                    return true;
                }
            }

            return false;
        }
        public bool VerificarNumeroLista(List<int> listaNumeros, int numeroProcurado)
        {
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                if (listaNumeros[i] == numeroProcurado)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
