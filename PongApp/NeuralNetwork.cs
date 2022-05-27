using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongApp
{
    internal class NeuralNetwork
    {


        public int network(int ballY,int ballX, int paddleY, int ballSpeed)
        {
            double[] inputs = { ballY,ballX, paddleY, ballSpeed };
            //double[] weights = { 0.2, 0.8, 0.5 }; 
            // double bias = 2.0;

            double[][] weights = new double[2][];
            weights[0] = new double[] { 1, -1,0};
            weights[1] = new double[] { 1, -1, 0 };

            //double[] weights1 = { 1, -1,0};
            //double[] weights2 = { -1, 1, 0 };
            double bias = 0.0;


            double outPut1 = 0; //= inputs[0] * weights1[0] + inputs[1] * weights1[1] + inputs[2] * weights1[2] + bias;

            //double outPut2 = inputs[0] * weights2[0] + inputs[1] * weights2[1] + inputs[2] * weights2[2] + bias;


            //iterate through weights and inputs suming the product of the inputs and the weights plus the bias
            for(int i =0;i<weights.Length;i++)
            {
                for (int j = 0; j < weights[i].Length; j++)
                {
                    outPut1 += weights[i][j] * inputs[j];
                }
                outPut1 += bias;

            }

            if (outPut1 > 1) { return 1; }
            if (outPut1 < 1) { return  -1; }
            return 1;

            Console.WriteLine(outPut1);

        }

    }
}
