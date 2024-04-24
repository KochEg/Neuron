using System;
using System.Collections.Generic;
using System.Linq;

namespace Neuron
{
    public class NeuralNetwork
    {
        public List<Layer> Layers { get; }
        public Topology Topology { get; }

        public NeuralNetwork(Topology topology)
        {
            Topology = topology;
            Layers = new List<Layer>();

            CreateInputLayer();
            CreateHiddenLayers();
            CreateOutputLayer();
        }

        private void CreateOutputLayer()
        {
            var outputNeurons = new List<NeuronOne>();
            var lastLayer = Layers.Last();
            for (int i = 0; i < Topology.OutputCount; i++)
            {
                var neuron = new NeuronOne(lastLayer.Count, NeuronType.Output);
                outputNeurons.Add(neuron);
            }
            var outputLayer = new Layer(outputNeurons, NeuronType.Output);
            Layers.Add(outputLayer);
        }

        private void CreateHiddenLayers()
        {
            throw new NotImplementedException();
        }

        private void CreateInputLayer()
        {
            var inputNeurons = new List<NeuronOne>();
            for(int i = 0; i < Topology.InputCount; i++)
            {
                var neuron = new NeuronOne(1, NeuronType.Input);
                inputNeurons.Add(neuron);
            }
            var inputLayer = new Layer(inputNeurons, NeuronType.Input);
            Layers.Add(inputLayer);
        }
    }
}
