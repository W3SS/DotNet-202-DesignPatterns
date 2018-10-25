using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Command_Concept_Demo
{
    class Modification : IModification
    {
        private readonly Character _character;
        private readonly StatisticType _statisticType;

        public Guid Id { get; set; } = Guid.NewGuid();
        public Status Status { get; set; } = Status.Queued;
        public readonly decimal Value;

        IStatistic CharacterStatistic => (IStatistic)
            _character
            .GetType()
            .GetProperty(_statisticType.ToString())
            .GetValue(_character);

        PropertyInfo CharacterStatisticValueProperty =>
            CharacterStatistic?.GetType().GetProperty("Value");

        public Modification(Character character, StatisticType statisticType, decimal value)
        {
            _character = character;
            _statisticType = statisticType;
            Value = value;
        }

        public void Execute()
        {
            Status = UpdateValue() ? Status.ExecuteSucceeded : Status.ExecuteFailed;
        }
        public void Revert()
        {
            Status = UpdateValue(true) ? Status.RevertSucceeded : Status.RevertFailed;
        }
        
        bool UpdateValue(bool isReversion = false)
        {
            try
            {
                if (CharacterStatisticValueProperty == null) return false;

                var originalValue = CharacterStatistic.Value;
                var newValue = 0m;

                newValue = isReversion ? CharacterStatistic.Value - Value : CharacterStatistic.Value + Value;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

    }
}
