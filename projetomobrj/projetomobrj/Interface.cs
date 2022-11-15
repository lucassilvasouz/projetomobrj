using System.Collections.Generic;

namespace projetomobrj
{
    public interface CepResponses
    {
        List<CepResponses> GetCepResponses();
        CepResponses GetCep(string cep);
        void InsertCep  (CepResponses cep);  

    }
}
