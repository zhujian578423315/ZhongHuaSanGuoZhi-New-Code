﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind425 : InfluenceKind
    {
        private float rate;

        public override void ApplyInfluenceKind(Troop troop)
        {
            troop.RateOfDefence -= this.rate;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.rate = float.Parse(parameter);
            }
            catch
            {
            }
        }

        public override void PurifyInfluenceKind(Troop troop)
        {
            troop.RateOfDefence += this.rate;
        }
    }
}

