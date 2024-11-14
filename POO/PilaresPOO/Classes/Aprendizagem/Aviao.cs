using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Aviao:Veiculo
    {
    
        
    public void ExibirDados ()
    {
        Console.WriteLine(@$"
        Marca: {marca}
        Modelo: {modelo}
        Cor: {cor}
        Potencia: {potencia}
        qtdPortas: {qtdPortas}");
        
    }
    }
}