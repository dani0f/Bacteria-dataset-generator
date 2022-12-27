using System;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Randomizers.SampleRandomizers.Tags;
using UnityEngine.Perception.Randomization.Samplers;

namespace UnityEngine.Perception.Randomization.Randomizers.SampleRandomizers
{
    [Serializable]
    [AddRandomizerMenu("Bacterias/Ligh Color Randomizer")]

    public class LighColorRandomizer : Randomizer
    {
        [Tooltip("The light of the scene.")]
        public Light light;
        [Tooltip("The range of intensity value.")]
        public FloatParameter intensity = new FloatParameter { value = new UniformSampler(0, 1) };
        [Tooltip("The range of R value.")]
        public FloatParameter r = new FloatParameter { value = new UniformSampler(0, 1) };
        [Tooltip("The range of G value.")]
        public FloatParameter g = new FloatParameter { value = new UniformSampler(0, 1) };
        [Tooltip("The range of B value.")]
        public FloatParameter b = new FloatParameter { value = new UniformSampler(0, 1) };
        [Tooltip("The range of A value.")]
        public FloatParameter a = new FloatParameter { value = new UniformSampler(0, 1) };


        protected override void OnIterationStart()
        {
            Color newColor = Color.white;
            newColor.r = r.Sample();
            newColor.g = g.Sample();
            newColor.b = b.Sample();
            newColor.a = a.Sample();
            light.color = newColor;
            light.intensity = intensity.Sample();
        }
    }
}


