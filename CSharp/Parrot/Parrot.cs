using System;
using System.Collections.Generic;
using Parrot.Implementations;

namespace Parrot
{

    /// <summary>
    /// ⚠️ This class is deprecated. Please use <c><see cref="IParrot"/></c> and <c><see cref="ParrotFactory"/></c> instead.
    /// </summary>
    [Obsolete("Use IParrot instead.")]
    public class Parrot : IParrot
    {
        // Uses composition instead of inheritance to allow for more flexibility 
        private readonly IParrot _implementation;
        public string GetCry() => _implementation.GetCry();
        public double GetSpeed() => _implementation.GetSpeed();

        // Mantains the old constructor for backwards-compatibility reasons.
        // This is not scalable. 
        [Obsolete("Use ParotFactory instead.")]
        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _implementation = type switch
            {
                ParrotTypeEnum.AFRICAN => ParotFactory.African(numberOfCoconuts),
                ParrotTypeEnum.EUROPEAN => ParotFactory.European(),
                ParrotTypeEnum.NORWEGIAN_BLUE => ParotFactory.NorwegianBlue(voltage, isNailed),
                _ => throw new ArgumentException("Este tipo de papagaio não é suportado")
            };
        }
    }
}