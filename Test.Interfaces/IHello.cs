using Orleans;
using Orleans.CodeGeneration;
using System;
using System.Threading.Tasks;

namespace Test.Interfaces
{
    [Version(2)]
    public interface IHello : IGrainWithIntegerKey
    {
        Task<String> SayHello(String greeting);
    }
}
