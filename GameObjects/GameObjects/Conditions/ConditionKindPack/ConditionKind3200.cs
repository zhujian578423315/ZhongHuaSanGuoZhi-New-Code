﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind3200 : ConditionKind
    {
        private int val;

        public override bool CheckConditionKind(Faction faction)
        {
            return faction.ID == val;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.val = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

