

using System.Runtime.Intrinsics.X86;

namespace TheBasics
{
    public class Professor : Pessoa
    {
        public FloatComparisonMode Salario;

        public Professor(Endereco endereco) : base(endereco)
        {
            
        }
    }
}