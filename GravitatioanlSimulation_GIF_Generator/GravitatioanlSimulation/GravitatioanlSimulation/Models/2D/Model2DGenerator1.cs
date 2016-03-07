﻿using System;
using System.Drawing;
using GravitatioanlSimulation.Models._3D;
using OpenTK;

namespace GravitatioanlSimulation.Models._2D
{
    class Model2DGenerator1:IModel2DGenerator
    {
        public Model2D Generate()
        {
            int count = 10000;
            Vector2[] v = new Vector2[count];
            Vector2[] r = new Vector2[count];
            Random random = new Random();
            Color[] color = new Color[count];
            float[] m = new float[count];

            for (int i = 0; i < count; i++)
            {
                v[i] = new Vector2((float)random.NextDouble() * (random.NextDouble() > 0.5 ? 1 : -1),
                    (float)random.NextDouble() * (random.NextDouble() > 0.5 ? 1 : -1)
                   );
                r[i] = new Vector2((float)random.NextDouble() * 100,
                    (float)random.NextDouble() * 100);
                m[i] = random.Next(10000, 100000);
                color[i] = Color.FromArgb(random.Next(100, 200), random.Next(100, 200), random.Next(100, 200));
            }
            Model2D model2D = new Model2D(r, v, m, color);
            model2D.G = 0.00001f;

            return model2D;
        }
    }
}
