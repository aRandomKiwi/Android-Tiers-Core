﻿using Verse;
using Verse.AI;
using Verse.AI.Group;
using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MOARANDROIDS
{
    internal class ThoughtWorker_SharedBed_Patch

    {
        [HarmonyPatch(typeof(ThoughtWorker_SharedBed), "CurrentStateInternal")]
        public class CurrentStateInternal_Patch
        {
            [HarmonyPostfix]
            public static void Listener(Pawn p, ref ThoughtState __result)
            {
                if (p.IsBasicAndroidTier() || p.IsSurrogateAndroid() || Utils.pawnCurrentlyControlRemoteSurrogate(p))
                {
                    __result = ThoughtState.Inactive;
                }
            }
        }
    }
}