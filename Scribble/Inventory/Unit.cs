﻿using Inventories;
using System.Collections.Generic;

namespace InventoriesSample
{
    /// <summary>
    /// A battle unit.
    /// </summary>
    class Unit : IIdentifiable
    {
        public int Id { get; set; }

        public int MasterId { get; set; }

        public int Life { get; set; }

        public int Energy { get; set; }
    }

    /// <summary>
    /// A leader unit:
    /// - only one unit is the leader.
    /// - the leader has special skills effective on the party.
    /// - the leader is always active.
    /// </summary>
    class LeaderUnit : Unit
    {
        public IEnumerable<int> SpecialSkillIds { get; }
    }

    /// <summary>
    /// A servant unit:
    /// - you can pay costs to summon servants to the party.
    /// - only summoned servants are active.
    /// </summary>
    class ServantUnit : Unit
    {
        public bool IsSummoned { get; }
    }
}
