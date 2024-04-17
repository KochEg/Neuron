﻿using System;
using System.Collections.Generic;

namespace Neuron
{
    public class NeuronOne
    {
        public List<double> Weights { get; }
        public NeuronType NeuronType { get; }
        public double Outpute { get; private set; }

        public NeuronOne(int inputCount, NeuronType type = NeuronType.Normal)
        {
            NeuronType = type;
            Weights = new List<double>();

            for (int i = 0; i < inputCount; i++)
            {
                Weights.Add(1);
            }
        }

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weights[i];
            }
            Outpute = Sigmoid(sum);
            return Outpute;
        }

        //Сигмоида Σ, σ, ς     σ(x) = 1 / 1 + e^-x           E, е - экспонента Math.E
        private double Sigmoid(double x)
        {
            var result = 1.0 / (1.0 + Math.Exp(-x));
            return result;
        }

        public override string ToString()
        {
            return Outpute.ToString();
        }
    }
}
