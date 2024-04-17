using System.Collections.Generic;

namespace Neuron
{
    public class Layer
    {
        public List<NeuronOne> Neurons {  get; }   
        public int Count => Neurons?.Count ?? 0;

        public Layer(List<NeuronOne> neurons, NeuronType type = NeuronType.Normal) 
        { 
            //TODO: Проверить все входные нейроны на соответствие типу
            Neurons = neurons;
        }
    }
}
