﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class Constants
{
    public const int maxHandSize = 10;
    public const int maxCardAmount = 14;
    public const int maxUltiAreaSize = 3;
    public const int maxSideListSize = 12;
    public const int SpeedOfLight = 300000;
    public const float cardRiseHeight = 100f;
    public const float cardBigSize = 2.75f;
}

public enum HeroEnum
{
    None,
    Timothy,
    Harold,
    Uga,
    Guujaw,
    Muerte,
    Medusa,
    Bhesaj,
    Mordrea,
    Khalid,
    Wukong,
    Thrain,
    Diana,
    Tupa,
    Dante,
    Kyu,
    Praga,
    Matakite,
    Siphamandla,
    Ghonadur,
    Mercer,
    Sangrenta,
    Yuri,
    Eugene,
    Otto,
    Gerador,
    Elizabeth,
    Albert,
    Yeong,
    Philips,
    Jekyll,
    Uranio,
    Zarnada,
    Espectral

}

public enum CardTypes
{
    Profile,
    Attack,
    Defense,
    Charge,
    Nullification,
    Skill,
    Ultimate,
    Item,
    Passive,
    Structure
}

public enum SlotsOnBoard
{
    PlayerCard,
    PlayerCardAbove,
    PlayerSecondary,
    PlayerUltimate,
    PlayerDiscard,
    PlayerPassive,
    EnemyCard,
    EnemyCardAbove,
    EnemySecondary,
    EnemyUltimate,
    EnemyDiscard,
    EnemyPassive

}

public enum GameState
{
    Purchase,
    Choice,
    Interface,
    Reaction,
    Effects,
    Reset
}

public enum SEPhase
{
    Choice,
    Reaction,
    EffectsBefore,
    EffectsAfter
}

public enum CountEnum
{
    CardCount,
    UltiCount,
    PassiveCount
}

public enum WinCondition
{
    Victory,
    Loss,
    Draw
}