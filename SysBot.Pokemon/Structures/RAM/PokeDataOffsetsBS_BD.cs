﻿using System;
using System.Collections.Generic;

namespace SysBot.Pokemon
{
    /// <summary>
    /// Brilliant Diamond Pointers
    /// </summary>
    public class PokeDataOffsetsBS_BD : BasePokeDataOffsetsBS
    {
        public override IReadOnlyList<long> BoxStartPokemonPointer { get; } = new long[] { 0x4E36C58, 0xB8, 0x10, 0xA0, 0x20, 0x20, 0x20 };

        public override IReadOnlyList<long> LinkTradePartnerPokemonPointer { get; } = new long[] { 0x4E32250, 0xB8, 0x8, 0x20 };
        public override IReadOnlyList<long> LinkTradePartnerNamePointer { get; } = new long[] { 0x4E37770, 0xB8, 0x30, 0x110, 0x28, 0x90, 0x20, 0x0 };
        public override IReadOnlyList<long> LinkTradePartnerIDPointer { get; } = new long[] { 0x4E37770, 0xB8, 0x30, 0x110, 0x28, 0x90, 0x10 };
        public override IReadOnlyList<long> LinkTradePartnerParamPointer { get; } = new long[] { 0x4E37770, 0xB8, 0x30, 0x110, 0x28, 0x90 };
        public override IReadOnlyList<long> LinkTradePartnerNIDPointer { get; } = new long[] { 0x4FFE810, 0x70, 0x168, 0x40 }; // todo for multi-user Union Room; limited penalties available.

        public override IReadOnlyList<long> SceneIDPointer { get; } = new long[] { 0x4E2BC08, 0xB8, 0x18 }; // GameManager.AreaInfo.SheetAreaData

        public override IReadOnlyList<long> PlayerPositionPointer { get; } = new long[] { 0x4C11578, 0x90, 0x118, 0x120 }; // Will be zero until game boots up
        public override IReadOnlyList<long> PlayerRotationPointer { get; } = new long[] { 0x4C11578, 0x90, 0x118, 0x130 };
        public override IReadOnlyList<long> PlayerMovementPointer { get; } = new long[] { 0x4E2BC10, 0xB8, 0x10 };

        public override IReadOnlyList<long> UnitySceneStreamPointer { get; } = new long[] { 0x4E43B00, 0xA0 }; // 0x01 for large scenes, 0x09 for local union room >0x20 for pokecenter. View base class for more info

        // Union Work - Detects states in the Union Room
        public override IReadOnlyList<long> UnionWorkIsGamingPointer { get; } = new long[] { 0x4E2BD50, 0xB8, 0x3C }; // 1 when loaded into Union Room, 0 otherwise
        public override IReadOnlyList<long> UnionWorkIsTalkingPointer { get; } = new long[] { 0x4E2BD50, 0xB8, 0x85 };  // 1 when talking to another player or in box, 0 otherwise
        public override IReadOnlyList<long> UnionWorkPenaltyPointer { get; } = new long[] { 0x4E2BD50, 0xB8, 0x90 }; // 0 when no penalty, float value otherwise.

        public override IReadOnlyList<long> MyStatusTrainerPointer { get; } = new long[] { 0x4E36C58, 0xB8, 0x10, 0xE0, 0x0 };
        public override IReadOnlyList<long> MyStatusTIDPointer { get; } = new long[] { 0x4E36C58, 0xB8, 0x10, 0xE8 };
        public override IReadOnlyList<long> ConfigTextSpeedPointer { get; } = new long[] { 0x4E36C58, 0xB8, 0x10, 0xA8 };
        public override IReadOnlyList<long> ConfigLanguagePointer { get; } = new long[] { 0x4E36C58, 0xB8, 0x10, 0xAC };
    }
}
