# QUIL: THE GOBLIN KING'S TITHE
### Game Design Document · v1.1 · iPhone home-screen web app (PWA)

> **Genre:** single-player dark fantasy RPG · **Platform:** iOS Safari, installed to the home screen, portrait, offline-capable
> **Tone:** mature dark fantasy. Combat is brutal and bloody. Romance can be steamy and suggestive, and **every sex scene fades to black**. The captivity of Quil's mother and sisters is **implied, never shown**: there are no captivity scenes, no captivity images and no detailed description. Every romanceable character is an adult (18+).

---

## Contents

1. Story & Cast · 2. Main Missions (20) · 3. Legendary Side Missions (5) · 4. Towns & Road Traders · 5. Dice Rules · 6. Combat · 7. Stats, Levelling, Inventory & Economy · 8. Romance · 9. Camp, Rest & Autosave · 10. World Map · 11. UI & Screens · 12. Art Plan

---

## 1. Story Overview & Main Cast

### Premise
Quilliam "Quil" Ashby, a 19-year-old farmhand, comes home from the far pastures of **Hollowmere** at dusk to find the town burning. Orcs, goblins, ogres and trolls have taken it apart in a single night. His father **Tomas** dies in the doorway of the family farmhouse, still gripping his hatchet. His mother **Maren** and his sisters **Wren** and **Elsie** have been dragged away in chains as part of the Goblin King's *Tithe*. Quil takes the hatchet, the hunting bow and the road east.

**The secret:** Tomas was once *Sir Tomas Ash*, a royal huntsman who put out the Goblin King's eye twenty years ago and then vanished into farm life. The raid was revenge, and Maren is the bait. Mawrot wants the son to come to him.

### Story Arc (4 Acts)
| Act | Missions | Region | Beat |
|---|---|---|---|
| I. Ash | 1–5 | Hollowmere Vale, Thornwood, Briarwatch | Quil tracks the raiders, survives his first real fights and **rescues Elsie** from Grukk the Flayer (M5). |
| II. Brine | 6–10 | Fenmire, Saltmarrow | The captives are being sold down the coast. Quil **rescues Wren** from Skarra's slave hulk (M10) and learns his father's past. |
| III. Stone & Cinder | 11–15 | Grimspire Mountains, Ashen Wastes | Quil fights through the mountain tunnels to the troll jarl Vorgath and learns that Maren is held in the Throne of Teeth. |
| IV. The Deep | 16–20 | Gloamfang Underkingdom | Quil descends, faces his own corruption, kills **Mawrot the Goblin King** and **rescues Maren** (M20). Then comes the epilogue: rebuilding Hollowmere and the wedding. |

### Main Cast
| Character | Role | Notes |
|---|---|---|
| **Quil (Quilliam) Ashby** | Hero, 19 | A fighter only, with **no spells ever**. Stubborn, wry and grief-driven. The player shapes whether he stays good or slides into corruption. |
| **Tomas Ashby** | Father (dies in the prologue) | A former knight. His hatchet is Quil's starting weapon, and his story is revealed through intel. |
| **Maren Ashby** | Mother, 42 | Calm, clever and unbreakable. She leaves coded marks (carved acorns) along the captive route as findable clues. **Rescued in M20.** |
| **Wren Ashby** | Elder sister, 21 | Fierce, sharp-tongued and a skilled skinner. After her rescue she runs the Hollowmere rebuild and gives Quil a **Hunter's Eye** bonus (+1 Wits at camp Scout). **Rescued in M10.** |
| **Elsie Ashby** | Younger sister, 16 | Bright, hopeful and a carver. After her rescue she stays at Hollowmere and carves charms (camp item: Elsie's Charm, reroll one die per mission). **Rescued in M5.** Never a romance option. |
| **Mawrot, the Goblin King** | Final boss | Ancient, huge and one-eyed (Tomas's work). He uses shadow magic, and his crown is made of teeth. He is cruel, witty and patient. |
| **Grukk the Flayer** | Boss, M5 | Orc warchief who led the Hollowmere raid. |
| **Skarra Brine-Tusk** | Boss, M10 | Ogre slaver-captain of the coast. |
| **Vorgath the Unburnt** | Boss, M15 | Ash-troll jarl and the King's forge-lord. |
| **Yrsa Gorrakh** | Damsel, M12 | Half-orc daughter of Warlord Gorrakh Ironjaw. She secretly hates Mawrot and has a short arc (M12–M14) that ends with her choosing Quil over her father. |
| **Warlord Gorrakh Ironjaw** | Antagonist, Act III | Commander of the King's orc host in the Grimspire, and Yrsa's father. He appears at the end of M14. |
| **Allies (5)** | Rescued and recruitable | Aldric, Rook, Nim, Gideon, Dame Hallam (§2, §8). |
| **Damsels (15)** | Rescued and romanceable | See the roster in §8. |

---

## 2. Main Missions (20)

**Legend:** ⚔ = mini-boss · ☠ = boss (drops a **cursed** weapon) · ✦ = family rescue · 🛡 = ally rescue (5 of 20, 25%) · ♥ = damsel rescue (15 of 20, 75%).
**Intel types:** **[Route]** (an alternate path or skipped fight), **[Weakness]** (+2 attack or a revealed vulnerability), **[Loot]** (a hidden cache), **[Captive]** (the rescue location or a family clue, giving +1 to the rescue check).

### ACT I — ASH

**M1 · Ashes of Hollowmere**

- **Location:** Hollowmere farms and town square (burning)
- **Objective:** Bury your father, then clear the stragglers looting the town.
- **Enemies:** 4 Goblin Cutters, 1 Goblin Archer (on the gallows beam), 1 Goblin Brute (war-horn)
- **Loot:** 15g · 1 garnet · **Tomas's Hatchet**, Hunting Bow + 12 broadhead arrows
- **Rescue ♥:** **Tamsin Reed**, the miller's daughter, found hiding in the mill loft.
- **Intel:** [Route] the raiders went into Thornwood by the old charcoal track · [Captive] "The red-haired one bit Grukk." (Wren is alive.)

**M2 · The Charcoal Track**

- **Location:** Thornwood, a goblin waystation
- **Objective:** Ambush the rear guard before it rejoins the warband.
- **Enemies:** 5 Goblin Cutters, 2 Goblin Archers, 1 Wolf-Rider
- **Loot:** 30g · 2 garnets · Woodsman's Axe, 20 arrows
- **Rescue ♥:** **Ysolde Fane**, a hedge-witch's apprentice, left caged as wolf-bait.
- **Intel:** [Captive] the captives were split into three wagons: east, coast and mountain · [Loot] a goblin stash under the hollow stump · [Route] rumour of the **Elder Oak** (unlocks side mission S1).

**M3 · Old Toll's Bridge ⚔**

- **Location:** Rillwater Bridge
- **Objective:** Cross the only bridge east, which an ogre "taxes" in flesh.
- **Enemies:** 6 Goblin Cutters, 1 Goblin Shaman; **Mini-boss: Old Toll** (Ogre Brute+, 55 HP)
- **Loot:** 45g · 1 amethyst · Rillwater Militia Spear, Leather Jerkin
- **Rescue 🛡:** **Brother Aldric**, a warrior-monk hung under the bridge. **Perk: Iron Litany** (+1 to all Defence rolls).
- **Intel:** [Weakness] Old Toll is blind on his left side, so the first attack from the left gets +2 · [Route] the ford below lets you skip the goblin pickets.

**M4 · The Siege of Briarwatch**

- **Location:** Briarwatch walls and market
- **Objective:** Hold the east gate for 5 rounds, then break the orc ram crew.
- **Enemies:** 6 Orc Grunts, 4 Goblin Archers, 1 Orc Berserker
- **Loot:** 60g · 2 amethysts, 1 sapphire · Arming Sword, Buckler
- **Rescue ♥:** **Corisande Vell**, a merchant heiress snatched from her carriage during the chaos.
- **Intel:** [Captive] Grukk's camp is at Redstone Quarry with "the little one" (Elsie) · [Weakness] Grukk's flaying hook leaves him open after a missed swing · [Route] Saint Halvard's crypt is unguarded (unlocks S2).

**M5 · Redstone Quarry ☠ ✦**

- **Location:** Redstone Quarry, the orc warcamp
- **Objective:** Infiltrate the camp, free the captives and kill Grukk.
- **Enemies:** 6 Orc Grunts, 2 Orc Berserkers, 1 Orc Warlock; **BOSS: Grukk the Flayer**
- **Loot:** 120g · 1 ruby, 2 sapphires · Quarryman's Maul, Longbow · **Cursed: Flayer's Hook**
- **Family ✦:** **Elsie Ashby** is freed from the pens. She is shaken, and the details stay unspoken.
- **Rescue ♥:** **Brenna Holt**, the quarry-master's daughter, still swinging a chisel.
- **Intel:** [Captive] Wren went to the coast on the slaver wagon · [Captive] the King "wants the widow kept whole," his first hint that Maren is bait.

### ACT II — BRINE

**M6 · Fenmire Crossing**

- **Location:** Fenmire stilt-paths
- **Objective:** Cross the bog at night and kill the trolls guarding the causeway.
- **Enemies:** 6 Goblin Cutters, 2 Bog Trolls (regenerating)
- **Loot:** 80g · 2 sapphires · Reedcutter Short Sword, 10 fire arrows
- **Rescue ♥:** **Marisol Keel**, an eel-fisher tied to a stake at the tideline.
- **Intel:** [Weakness] fire stops troll regeneration · [Route] the eel-runs avoid half the patrols.

**M7 · The Drowned Chapel**

- **Location:** A sunken chapel in Fenmire
- **Objective:** Stop a goblin shaman ritual that is defiling the shrine.
- **Enemies:** 6 Goblin Cutters, 3 Goblin Shamans (hexes), 1 Bog Troll
- **Loot:** 95g · 1 emerald, 2 sapphires · Chapel Mace, Studded Leather
- **Rescue ♥:** **Odile**, a novice nun who keeps praying aloud to drown out the chanting.
- **Intel:** [Loot] the reliquary is under the flooded altar · [Captive] a witch-troll keeps a prisoner in a stilt-hut (sets up M8).

**M8 · Hagmaw's Stilt-Hut ⚔**

- **Location:** Deep Fenmire
- **Objective:** Kill the witch-troll and cut her prisoner down.
- **Enemies:** 4 Goblin Archers, 2 Bog Trolls; **Mini-boss: Hagmaw the Witch-Troll** (70 HP, hexes, regeneration 4)
- **Loot:** 110g · 2 emeralds · Recurve Bow, 20 bodkin arrows
- **Rescue 🛡:** **Rook Varga**, a mercenary archer. **Perk: Eagle Eye** (+1 archery attack, recover half of your arrows after each fight).
- **Intel:** [Weakness] Hagmaw's hex-bag. Shooting it (Guard 8) cancels her hexes · [Route] a smuggler's channel leads to Saltmarrow's docks.

**M9 · Saltmarrow Docks**

- **Location:** Saltmarrow harbour at night
- **Objective:** Sabotage the slaver pier and find the hulk that holds the captives.
- **Enemies:** 6 Orc Grunts, 2 Orc Warlocks, 1 Ogre Slaver
- **Loot:** 130g · 1 ruby, 2 emeralds · Cutlass, Crossbow
- **Rescue ♥:** **Kestrel "Kes" Morrow**, a smuggler captain chained in her own hold.
- **Intel:** [Captive] the hulk *Brinewidow* sails at dawn with Wren aboard · [Route] Kes knows the hulk's bilge hatch · [Weakness] Skarra fears fire on deck. Opens S3 (the sea caves).

**M10 · The Brinewidow ☠ ✦**

- **Location:** The slave hulk *Brinewidow*, at sea
- **Objective:** Board, free the hold and kill Skarra before the ship burns or sinks.
- **Enemies:** 6 Orc Grunts, 2 Ogre Slavers, 2 Goblin Shamans; **BOSS: Skarra Brine-Tusk**
- **Loot:** 250g · 2 rubies, 1 diamond · Saltmarrow Longsword, Chainmail · **Cursed: Drowner's Chain**
- **Family ✦:** **Wren Ashby** has already half-freed herself and fights at your side for the last round. She never talks about the voyage.
- **Rescue ♥:** **Delphine Aubrac**, the singer of the Gilded Gull, taken to entertain the crew.
- **Intel:** [Captive] the mother went "to the mountain, then down" · [Lore] Skarra names Tomas the "One-Eye Maker".

### ACT III — STONE & CINDER

**M11 · Kettlewick Under**

- **Location:** Mines beneath Kettlewick
- **Objective:** Clear the goblin tunnels that are swallowing miners.
- **Enemies:** 10 Goblin Cutters (in swarms), 3 Goblin Archers, 1 Stone Troll
- **Loot:** 150g · 3 emeralds, 1 ruby · War Pick, Miner's Lamp (sneak +1 in the dark)
- **Rescue 🛡:** **Nim Two-Ears**, a goblin turncoat chained up by his own kin. **Perk: Tunnel Tongue** (+2 when interrogating goblins, and he reveals one free [Route] each mission).
- **Intel:** [Route] the old ironroot shaft (unlocks S4) · [Captive] an armoured caravan is crossing Frostback Pass.

**M12 · Frostback Pass**

- **Location:** A snowbound mountain pass
- **Objective:** Ambush the troll caravan in a blizzard.
- **Enemies:** 6 Orc Grunts, 2 Wolf-Riders, 2 Stone Trolls
- **Loot:** 170g · 2 rubies, 1 diamond · Northern Bearded Axe, Fur Cloak (cold resistance)
- **Rescue ♥:** **Yrsa Gorrakh**, a half-orc woman of about twenty-five and the daughter of **Warlord Gorrakh Ironjaw**, who commands the Goblin King's orc host in the Grimspire. She rides with the caravan under guard as her father's punishment for speaking against Mawrot, and she is cursing her escort in two languages. She secretly hates the King, who took her human mother as Tithe years ago.
- **Intel:** [Captive] noble captives are held at Hollowhorn Keep · [Weakness] stone trolls crack under hammer blows (blunt weapons ignore 2 of their armour).
- **If won over (Spark success):** Yrsa gives **[Ranks] intel on the orc host**: which berserker bands answer to her father, the warlocks' signal horns, and the Ashen Road ambush plan (M14 starts with the orcs Exposed). Her perk is **Orc-Breaker**: +1 to hit and +1 damage against orcs, and orc grunts must pass a Morale check before attacking Quil while she is at the Hearth.
- **Her arc (3 beats):**
  1. *M12 camp:* she tests Quil, saying humans see only her tusks. Choices honour or distrust her.
  2. *M13 Hollowhorn Keep:* the Orc Warlocks carry her father's war-banner. She can call two Berserkers off the fight (they leave the battle) if Affection is Fond or higher.
  3. *M14 The Ashen Road, the choice:* Warlord Gorrakh Ironjaw rides in at the end of the raid and orders her home. If Affection is Smitten or higher, **Yrsa chooses Quil**. She breaks her father's spear across her knee, and Gorrakh withdraws, swearing she is no longer his. She gains +15 Affection and her personal side scene. Otherwise she goes with him, and the M14 loot adds her farewell gift: her mother's bone-handled knife.

**M13 · Hollowhorn Keep ⚔**

- **Location:** A ruined keep that ogres now occupy
- **Objective:** Retake the keep from the Ogre Twins.
- **Enemies:** 4 Orc Berserkers, 2 Orc Warlocks; **Mini-boss: Brak & Brakka, the Ogre Twins** (2×45 HP; if one dies, the other enrages for +2 damage)
- **Loot:** 200g · 2 diamonds · **Marr Family Longsword**, Chain Coif
- **Rescue ♥:** **Lady Elowen Marr**, the exiled heir of the keep, locked in her own library.
- **Intel:** [Weakness] kill Brakka first, because Brak enrages more slowly · [Captive] captives are being sent to Vorgath's forge in the Ashen Wastes.

**M14 · The Ashen Road**

- **Location:** Ashen Wastes, the caravan road
- **Objective:** Rescue a spice caravan from an orc raid.
- **Enemies:** 8 Orc Grunts, 2 Wolf-Riders, 1 Ash Troll
- **Loot:** 220g · 3 rubies, 1 diamond · Scimitar, Composite Bow, 10 fire arrows
- **Rescue ♥:** **Zahra al-Sidra**, a caravan dancer and spice trader with a knife in her sash.
- **Intel:** [Loot] Zahra's star-map to Skyfall Crater (unlocks S5) · [Route] the cinder vents into the Forge.

**M15 · The Cinder Forge ☠**

- **Location:** Vorgath's volcanic forge-hall
- **Objective:** Break the forge, free the slave-smiths and kill Vorgath.
- **Enemies:** 6 Orc Berserkers, 2 Ash Trolls, 2 Orc Warlocks; **BOSS: Vorgath the Unburnt**
- **Loot:** 400g · 3 diamonds · Masterwork Greatsword, Half-Plate · **Cursed: Emberbrand**
- **Rescue 🛡:** **Gideon Ash**, a master smith and Tomas's old squire. **Perk: Whetstone** (all weapons +1 base damage, and picked-up weapons get +2 durability).
- **Intel:** [Captive] Maren is in the Throne of Teeth, kept "unharmed, as bait" · [Route] the Gloamfang Gate's sewer grate · [Lore] Gideon tells the full story of Sir Tomas.

### ACT IV — THE DEEP

**M16 · Gloamfang Gate**

- **Location:** The fortified entrance to the Underkingdom
- **Objective:** Breach the gate, or sneak in through the grate.
- **Enemies:** 8 Orc Grunts, 4 Goblin Archers, 2 Ogre Brutes
- **Loot:** 250g · 2 diamonds, 2 rubies · Halberd, Tower Shield
- **Rescue ♥:** **Nerys Fallow**, a scout from Last Lantern captured on recon.
- **Intel:** [Route] the Fungal Warrens bypass the barracks · [Weakness] King's Guard armour has a weak seam under the arm.

**M17 · The Fungal Warrens**

- **Location:** Glowing fungus caverns
- **Objective:** Cross the warrens without breathing the spore-clouds (Grit checks).
- **Enemies:** 8 Goblin Cutters, 4 Goblin Shamans, 1 Bog Troll
- **Loot:** 280g · 3 emeralds, 1 diamond · Ashgrove Longbow (a dead ranger's), 20 blunt arrows
- **Rescue ♥:** **Lirien Vale**, a half-elven cartographer mapping the Deep for the crown.
- **Intel:** [Route] Lirien's map of the Weeping Galleries · [Captive] a knight fights for the King's sport in the Pit.

**M18 · The Pit of Ul'grash ⚔**

- **Location:** The goblin arena
- **Objective:** Win three arena bouts, then kill the champion.
- **Enemies:** 2 Orc Berserkers, 2 Wolf-Riders, 1 Ogre Slaver; **Mini-boss: Ul'grash, Pit Champion** (Stone Troll+, 90 HP)
- **Loot:** 320g · 3 diamonds · Knight's Warhammer, Full Plate
- **Rescue 🛡:** **Dame Hallam Gray**, a captive knight and pit-slave. **Perk: Shieldwall** (the first enemy hit in each combat is negated).
- **Intel:** [Weakness] Mawrot's shadow fails in true flame and sunlight · [Route] the arena's royal tunnel.

**M19 · The Weeping Galleries**

- **Location:** Crystal galleries below the throne
- **Objective:** Get through the royal guard and the hostage cells.
- **Enemies:** 6 King's Guard (Orc Berserker+), 3 Goblin Shamans, 2 Stone Trolls
- **Loot:** 360g · 4 diamonds · Ducal Rapier, Royal Arming Sword
- **Rescue ♥:** **Aurelie Vance**, the Duke of Saltmarrow's daughter and a hostage for ransom.
- **Intel:** [Captive] Maren's cell is behind the throne · [Weakness] the King's crown anchors his shadow. Strike it (a called shot at −2) to end Phase 2.

**M20 · The Throne of Teeth ☠ ✦**

- **Location:** The Goblin King's throne cavern
- **Objective:** Kill Mawrot the Goblin King.
- **Enemies:** 4 King's Guard, 2 Goblin Shamans; **FINAL BOSS: Mawrot** (3 phases: Throne → Shadow → Desperate)
- **Loot:** 800g · the King's Hoard (6 diamonds, crown jewels) · **Cursed: The Tithe** (post-game / NG+)
- **Family ✦:** **Maren Ashby** is freed. She is unbowed, and she ties off Quil's wounds with her own shawl.
- **Rescue ♥:** **Isra**, the King's chained oracle, who already knew you would come.
- **Intel:** none. This is the end of the road. Isra's prophecy unlocks the epilogue variants.

---

### Wits Checks in Every Mission
Non-combat skill checks use **Wits**, plus Grit or Charm where noted. The roll is 2d6\* + stat vs 5–9. Each mission has 2–3 checks, and they always pay out in **intel, loot, an ambush avoided or a better start**.
| Mission | Checks (stat · Target) and consequences |
|---|---|
| M1 Ashes of Hollowmere *(built)* | **Read tracks** (Wits 6, +1 farm-raised): the hidden archer is marked, Quil starts in cover, +1 intel; on a fail the archer stays hidden (?) · **Spot the bell-wire** (Wits 7): on a fail two cutters start suspicious · **Maren's acorn** (Wits 6, lore): a hearth cache with +6g, a potion and Lore intel · **Is it lying?** (Wits 6, at interrogation): expose the false lead and get the truth. |
| M2 The Charcoal Track | Spot a deadfall trap (Wits 7) · read cart ruts for the wagon count (Wits 6, [Captive]) · keep pace at a forced march (Grit 6, or start at −2 HP). |
| M3 Old Toll's Bridge | See weakened planks (Wits 7: avoid a fall, flank the troll) · the toll riddle carved on the arch (Wits 8, lore: a toll-chest cache). |
| M4 Siege of Briarwatch | Read the ram crew's rhythm (Wits 7: +1 Defence for the gate hold) · rally the militia (Charm 7) · spot the sapper tunnel (Wits 8: avoid the ambush). |
| M5 Redstone Quarry | Spot loose scree (Wits 7: rockfall on the orcs) · decode Grukk's tally marks (Wits 8: [Weakness]) · Elsie's carved bird trail (Wits 6: a shortcut). |
| M6 Fenmire Crossing | Find safe tussocks (Wits 6, or +1 Bleed from leeches) · notice a bog-light lure (Wits 7: ambush avoided). |
| M7 The Drowned Chapel | Read the flood line (Wits 7: a dry route) · translate a chapel inscription (Wits 8, lore: relic cache). |
| M8 Hagmaw's Stilt-Hut | See through the hag's glamour (Wits 8, or −2 on the first round) · identify her herbs (Wits 7: 2 free potions). |
| M9 Saltmarrow Docks | Spot the harbour spy (Wits 7: [Route]) · tell real crates from decoys (Wits 6: loot) · bluff the dockmaster (Charm 7). |
| M10 The Brinewidow | Read the tide (Wits 7: board at slack water, +1 Sneak) · find Wren's knife-scratches (Wits 6: her cell). |
| M11 Kettlewick Under | Map the tunnels (Wits 7: skip a fight) · spot gas pockets (Wits 8: a fire arrow becomes a weapon, not a hazard). |
| M12 Frostback Pass | Read the blizzard (Wits 7: an ambush window) · endure the cold (Grit 7) · read Yrsa's war-tattoos (Wits 6: +1 Spark). |
| M13 Hollowhorn Keep | Find the postern (Wits 7: [Route]) · the Marr library cipher (Wits 8, lore: a hidden armoury). |
| M14 The Ashen Road | Spot the orc outriders (Wits 7: ambush avoided) · read the caravan's distress code (Wits 6: Zahra +5). |
| M15 The Cinder Forge | Read the forge rhythm (Wits 8: a vent-burst trap on Vorgath) · Gideon's maker's marks (Wits 6: lore). |
| M16 Gloamfang Gate | Spot the sentry rotation (Wits 7: a 2-round stealth window) · the gate-rune puzzle (Wits 8). |
| M17 The Fungal Warrens | Recognise spore caps (Wits 7: avoid confusion, harvest 2 bombs) · follow Maren's acorns (Wits 6: [Captive]). |
| M18 The Pit of Ul'grash | Read the crowd's betting (Wits 7: the champion's tell, +2 on the first attack). |
| M19 The Weeping Galleries | See through the shadow echoes (Wits 8: −1 corruption) · the mirror maze (Wits 7). |
| M20 The Throne of Teeth | Spot Mawrot's blind side (Wits 8: +2 attacks from the left in P1) · read Maren's final acorn (Wits 6: her cell key). |

## 3. Legendary Side Missions (5)

Legendary weapons carry **no corruption**. They are the clean counterpart to cursed weapons.

| # | Mission | Unlocks | Location | Guardian | Weapon | Stats (Base / Scale / Acc) | Special Power |
|---|---|---|---|---|---|---|---|
| S1 | **The Elder Oak** | after M2 | Thornwood's heart | Goblin shaman coven + the Briarhag (bound oak spirit) | **Whisperwind**, longbow | 5 / 1.0 / +2 | **Silent:** shots taken from stealth never break stealth. **Gale Arrow** (1/combat): the target loses its next turn. |
| S2 | **Crypt of Saint Halvard** | after M4 | Beneath Briarwatch | Hrask the Grave-Caller (Orc Warlock) | **Sunsorrow**, longsword | 5 / 1.0 / +1 | **Radiant:** trolls cannot regenerate, +3 damage vs trolls and shamans. **Cleanse:** −2 corruption per mission while equipped. It burns the hand at Corruption ≥75 and cannot be wielded. |
| S3 | **The Singing Caves** | after M9 | Saltmarrow sea caves | Old Barnacle (sea troll) | **Tidebreaker**, trident-spear | 5 / 1.0 / +1 | **Reach:** a free first strike in every combat. On a critical, the enemy is knocked prone and loses its turn. |
| S4 | **The Ironroot Hall** | after M11 | An abandoned miners' guildhall below Kettlewick | The Grindmother (stone troll) | **Ironroot Cleaver**, greataxe | 7 / 1.5 / 0 | **Cleave:** overkill damage carries over to the next enemy. **Shieldbreaker:** ignores 2 armour. |
| S5 | **Skyfall Crater** | after M14 | Ashen Wastes | An ash-troll cult + Cinder-Eye (Ogre Slaver+) | **Starfall**, warhammer (Might 4) | 8 / 1.5 / 0 | **Thunderclap:** on a natural roll of 8+, the target is stunned. **Starstrike** (1/combat): 10 damage to every enemy. |

---

## 4. Towns & Road Traders

### Towns
Every town has a **Smith** (melee weapons, armour, repairs), a **Fletcher** (bows, arrows), an **Apothecary** (potions, bandages), a **Tavern** (rumours, rooms, flirting), a **Jeweller** (best price for jewels) and a **Temple** (cleanses corruption for gold). Flirtable townsfolk are light romance (see §8). They can't be married.

| Town | Region | Flavour | Unique shop | Flirtable townsfolk |
|---|---|---|---|---|
| **Hollowmere** (hub) | Hollowmere Vale | Starts in ruins. It **rebuilds in stages** after M5, M10 and M15 (each stage costs 200g/400g/600g) and unlocks the Hearth Hall, a smithy and Tamsin's mill. | **Hearth Hall:** damsels and family live here. Elsie's charms, Wren's trophy board. | — (it's home; your damsels are here) |
| **Briarwatch** | Thornwood edge | A walled market town, scarred by the siege. | **Halvard's Forge** (good steel) | **Mirelle Dunn**, the widowed keeper of the Crooked Antler, with honeyed teasing and a strong pour. **Pip Ashgrove**, the fletcher, a playful rival who bets on target shots. |
| **Saltmarrow** | Coast | A port of smugglers, salt and sin. | **Brineworks Armory** (crossbows, cutlasses), **Jewel Exchange** | **Captain Ines Corva**, harbourmaster, all business until she isn't. **Lark**, a Gilded Gull barmaid who trades kisses for gossip. |
| **Kettlewick** | Grimspire | A soot-black mining town with hot springs. | **Assay Office** (jewels +10%), **Bathhouse** (full heal + bonus) | **Hilde Ironbrow**, a smith with forearms like hams who loves a good blade. **Sabine**, a bathhouse attendant, sly and perfumed. |
| **Last Lantern** | Edge of Gloamfang | The last human outpost. Everything costs +25%. | **Quartermaster** (Full Plate, King's-bane oil) | **Rhosyn Bell**, quartermaster, battle-weary and gallows-funny. |

### Road Traders
On every map trip there is a 30% chance (rolled 7+) of meeting a random trader.

| Trader | Sells / Buys | Flirt |
|---|---|---|
| **Old Pell's Wagon** | Basics, rations, gossip (a free rumour) | — |
| **Madame Saffi's Caravan** | Exotic arrows, perfumes and silks (romance gifts), dyes | **Saffi**, silver-tongued and older, and she flirts back better than you do. |
| **Brother Ostrum's Relic Cart** | Charms, holy water (−5 corruption, 60g) | — |
| **The Tinker Twins (Jeb & Jessa)** | Repairs. They **buy enemy weapons** at fair prices. | **Jessa**, oil-smudged, who flirts with Quil just to annoy her brother. |
| **Black Marrow** | Only appears at Corruption ≥25. Poisons, and he fences cursed relics. | — |

---

## 5. Dice Rules — "Ashdice"

### The Roll
Roll **2d6**. **A 6 counts as 0**, so each die reads 0–5 and the **total runs 0–10**.

- **Natural 10** (5 + 5) = **Critical**: automatic success plus a bonus effect (double damage, an extra intel card, or bonus affection).
- **Natural 0** (6 + 6, "Gravedice") = **Fumble**: automatic failure plus a complication.
- Otherwise: **Total = natural roll + modifiers**, compared against a **Target**. Meet or beat it to succeed.
- **Margin** = Total − Target. A margin of +3 or more is a **Strong Success**.

### Probability Table
| Natural total | Ways (of 36) | Exactly | This or higher |
|---|---|---|---|
| 0 (fumble) | 1 | 2.8% | 100% |
| 1 | 2 | 5.6% | 97.2% |
| 2 | 3 | 8.3% | 91.7% |
| 3 | 4 | 11.1% | 83.3% |
| 4 | 5 | 13.9% | 72.2% |
| 5 | 6 | 16.7% | 58.3% |
| 6 | 5 | 13.9% | 41.7% |
| 7 | 4 | 11.1% | 27.8% |
| 8 | 3 | 8.3% | 16.7% |
| 9 | 2 | 5.6% | 8.3% |
| 10 (critical) | 1 | 2.8% | 2.8% |

The average is 5. The natural roll you need is the **Target minus your modifiers**.

### Difficulty Targets
| Target | Difficulty | Example |
|---|---|---|
| 3 | Trivial | Hitting a dazed goblin |
| 5 | Easy | Sneaking past a drunk sentry |
| 6 | Standard | Hitting an orc grunt, persuading a goblin |
| 7 | Tricky | Intimidating an orc, romance spark for most damsels |
| 8 | Hard | Hitting an ogre, recruiting a proud ally |
| 9–10 | Very Hard | Hitting a troll, defending against a boss |
| 11–13 | Heroic | Hitting or defending against the Goblin King |

### How Stats Modify Rolls
| Roll | Formula |
|---|---|
| **Melee attack** | 2d6* + Might + weapon Acc + buffs vs enemy **Guard** |
| **Ranged attack** | 2d6* + Edge + bow Acc + arrow modifier vs enemy **Guard** |
| **Defence** | 2d6* + Grit + armour + shield + buffs vs enemy **Attack** |
| **Damage** | Weapon Base + ⌊natural roll × weapon Scale⌋ + ⌊Might ÷ 2⌋ (melee only). **Critical = ×2.** |
| **Sneak** | 2d6* + Edge (+ gear) vs area **Alertness** |
| **Intimidate** | 2d6* + Might (+ corruption bonus) vs captive **Resolve** |
| **Persuade** | 2d6* + Charm (+1 if you already hold related intel) vs captive **Resolve** |
| **Recruit / Romance spark** | 2d6* + Charm + rescue modifiers vs the character's **Heart target** |
| **Search / traps / lies** | 2d6* + Wits vs Target |

The **modifier cap is +8** from all sources combined. *2d6\* means 2d6 with each 6 read as 0.*

**Damage example:** Saltmarrow Longsword (Base 5, Scale 1.0), Might 3, natural damage roll 7 → 5 + 7 + 1 = **13**. A critical makes it **26**.

### Auto-Roll (optional)

- **Settings → Dice:** *Physical* (enter your real dice on the pad), *Auto* (the app rolls with `crypto.getRandomValues`, with an animated pair of bone dice), or *Hybrid* (auto for damage and minions, physical for attacks, defence and checks).
- **Quick Resolve:** fights against minions only can be auto-resolved in one tap. It costs 10% more HP than fighting them out.
- Every roll is logged to the **Roll Log** (tap the dice icon) for transparency.

---

## 6. Combat

### Turn Structure

1. **Opener:** choose **Wait and watch** (patrols move), **Open Assault** (a free volley, then every enemy is alerted), **Melee Stealth** (a takedown on a chosen target) or **Ranged Stealth** (a hidden shot at a chosen target). See *Tactical Map & Perception* below. Archers get 1 free volley in an open assault (2 with long range or high ground).
2. **Rounds:** Quil acts, then each enemy acts. When an enemy attacks, Quil makes a **Defence roll** (enemies use fixed ratings, so **only the player ever rolls**).
3. **Defence results:** Success = no damage · Strong Success = **Riposte** (a free attack) · Fail by 1–2 = **graze** (half damage) · Fail by 3+ = full damage · Gravedice = enemy critical (×1.5).
4. **Actions** (one per round): Strike · Shoot · Subdue (knockout) · Grab Weapon · **Improvised Throw** · Swap Weapon · Use Item · Called Shot (−2, targets a weak point from intel) · Flee (Edge vs 7, impossible in boss fights).

### Enemy Table
| Enemy | HP | Guard | Attack | Dmg | Traits / Magic |
|---|---|---|---|---|---|
| Goblin Cutter | 10 | 5 | 5 | 3 | Swarm: +1 Attack when 3 or more are alive |
| Goblin Archer | 12 | 6 | 6 | 3 | Ranged, stays at the back (often on high ground) |
| Goblin Brute | 16 | 5 | 6 | 4 | **War-horn:** when alerted, every goblin within 6 squares wakes up (unaware → suspicious, suspicious → alerted). Slow-witted: −2 perception. |
| Goblin Shaman | 10 | 6 | 6 | 4 | **Hex:** −1 to all Quil rolls (stacks to −2) |
| Wolf-Rider | 14 | 6 | 7 | 5 | Fast: acts first |
| Orc Grunt | 16 | 6 | 7 | 6 | — |
| Orc Berserker | 22 | 7 | 8 | 8 | Rage below 50% HP: +2 damage |
| Orc Warlock | 18 | 7 | 7 | 7 | **Firebolt:** armour doesn't apply |
| Ogre Brute | 40 | 8 | 9 | 10 | Stagger: a full hit costs Quil his next action |
| Ogre Slaver | 35 | 9 | 9 | 9 | Net: Quil is −2 Defence for 1 round |
| Bog Troll | 35 | 8 | 8 | 8 | **Regen 3/round** unless burned |
| Stone Troll | 45 | 10 | 10 | 12 | Armour 2. Blunt weapons ignore it. |
| Ash Troll | 40 | 9 | 10 | 10 | Burning aura: 2 damage to Quil each melee round |
| King's Guard | 28 | 9 | 9 | 9 | Shield: −1 to ranged attacks against it |
| **Grukk** (M5) | 70 | 9 | 10 | 12 | Flaying Hook: bleed 2/round |
| **Skarra** (M10) | 110 | 10 | 11 | 15 | Chain-drag, summons slavers, deck fire |
| **Vorgath** (M15) | 150 | 11 | 12 | 18 | Fire breath, regenerates 5 unless burned by Sunsorrow or Emberbrand |
| **Mawrot** (M20) | 200 | 12 (P3: 13) | 13 | 20 | **P1 Throne:** summons guards. **P2 Shadow:** untargetable until his crown is struck. **P3 Desperate:** two attacks per round, hexes. |

### Melee Weapons (human)
| Weapon | Damage | Acc | Price | Notes |
|---|---|---|---|---|
| Skinning Knife | 2–6 | +1 | — | **+4 damage on takedowns** |
| Tomas's Hatchet | 4–8 | +1 | — | Sentimental: +1 Charm with family. Takedowns get +4 (8–12). |
| Short Sword | 4–9 | +1 | 40g | |
| Arming Sword | 5–9 | +1 | 60g | Works with a shield |
| Spear | 5–10 | +1 | 50g | Reach: +1 Defence vs the first attack |
| Mace / Warhammer | 5–11 | 0 | 70–180g | Blunt: ignores troll armour, +1 Subdue |
| Longsword | 6–11 | +1 | 150g | |
| Greatsword / Greataxe | 7–14 | −1 | 250g+ | Two-handed |

### Damage & Hit Tiers
The to-hit roll is 2d6\* + stat vs Guard. **Damage is a separate roll inside the weapon's band**, uniform from low to high, with these additions: +Might/2 in melee · **+1 against an unaware target** · arrow shift (Broadhead +1, Fire +1). Goblin weapons: shiv 2–6, shortbow 2–6.

| Tier | Rule | Effect |
|---|---|---|
| **Graze** | damage < 30% of max HP | A shallow cut |
| **Embedded** | 30–59% | Lodged in muscle |
| **Deep wound** | 60%+ but below the target's remaining HP | The target is staggering |
| **Vital** | a natural-10 **critical**, or damage ≥ the target's **remaining** HP | Artery, throat, eye or skull: **the target dies** |

- Each tier × weapon family (arrow, blade or axe) has its own narration pool.
- **Hunting bow 3–9 (+1 Broadhead +1 unaware = 5–11) against a 10-HP cutter:** a normal hit does 50–80% of its HP, and a high roll (10–11) or a crit kills.
- An **unaware target dies silently** to a Vital arrow (a quiet event). Any non-lethal hit makes it **scream**: a loud event, and the target is alerted.

### Tactical Map & Perception

Every fight has a painted top-down **battle map**: a 9×6 grid over the art (for M1, Hollowmere square), collapsible above the combat log, with a fullscreen zoom.
- **Terrain:**
  - **Buildings** block movement and sight.
  - **Fire** can't be entered.
  - **Cover** (the well, low walls, barrels) hides Quil from anyone more than 2 squares away and gives +1 Defence vs arrows.
  - The **gallows beam** is high ground for the archer.
- **Enemy tokens:** each miniature has a state ring (grey 💤 unaware, amber ❓ suspicious, red ❗ alerted), HP pips and a vision cone. Tap one to target it, or tap the ground to identify terrain.

**Openers:** Open Assault (a free volley, then everyone is alerted) · **Melee Stealth** (a takedown) · **Ranged Stealth** (a hidden shot) · **Wait and watch** (up to 3 rounds of letting the patrols move before committing).

**Stealth actions:**
| Action | Roll | Success | Failure |
|---|---|---|---|
| **Takedown** | **Edge vs 7**: +2 if the target is suspicious · **+2 if another goblin is adjacent to the target** · −2 from behind (it can't see Quil) · −2 after a Whistler | Damage = the weapon band +4 (hatchet 8–12) +1 unaware. It kills if that covers the target's HP, or **always** on a Strong success or a critical (a vital strike). Quiet. | A **loud grapple**: the target is alerted. If the takedown lands but doesn't kill (e.g. the 16-HP Brute), that's also a loud grapple. |
| **Choke out** (Subdue on an unaware target) | Edge vs 7, same modifiers | KO, whatever the target's HP. Quiet. The goblin can be interrogated. | A loud grapple |
| **Hidden shot** | Edge + bow vs Guard, +1 if the target is unaware | A Vital hit is a silent kill. | A miss, or any wound, alerts the target. A wound also makes it scream (loud). |
| **Slip into cover** | none | Move up to 3 squares to the most hidden cell, cover first. | Only possible while no one is alerted. |
| **Wait** | none | Let a round pass in hiding. | Only possible while no one is alerted. |

**Perception check.** After any attack, kill or noise, each living, unalerted goblin who can **see** the spot, **see Quil**, or **hear** it rolls **2d6\* + bonus**:
- **Sight:** +2 if it sees the event or Quil, +3 if it sees both. Vision is a 120° cone up to **4 squares** in the smoke; the archer on the beam gets 180° and 5 squares. Buildings block it.
- **Hearing:** quiet = 1.5 squares, +0 · loud = 4 squares, +2 · fire = 6 squares, +3.
- **Other modifiers:** +2 if already suspicious · the goblin's perception (Brute −2) · **tension** · −1 per 2 squares of distance.
- **Tension:** after the first goblin falls, every unalerted goblin gets +1 to notice for the rest of the fight, +1 per fallen goblin, to a maximum of +3. The body that has just dropped doesn't count toward its own witnesses' roll.
- **Result:** **10+** = alerted, 7–9 = suspicious.

**Each enemy round:**
1. **Patrols:** unaware goblins walk 1 square along a short route and turn at each end, so their cones sweep. In M1: Cutter 1 circles the well-side, Cutter 2 walks the north lane, Cutter 3 paces by the mill, Cutter 4 walks the burning-house corner, and the Brute walks the cart road. The archer stays on the beam.
2. **Bodies are discovered:** any unalerted goblin with line of sight to an undiscovered dead or KO'd goblin **within 1.5 squares** (smoke and dark hide anything further) rolls 2d6\* **+3** + tension (+2 if suspicious) vs 10.
   - On a success it is **alerted** and sounds a **horn or whistle**: every goblin within 6 squares becomes suspicious (an already-suspicious one becomes alerted).
   - The Brute's war-horn does the same the moment the Brute itself is alerted.
3. **Searchers:** suspicious goblins turn toward Quil. If they can see him they roll 2d6\* + 4 + tension vs 10.
4. **Alerted goblins** advance 2 squares and attack when adjacent; archers shoot whenever they have a line on Quil. A melee clash is a loud event at Quil's position.

**Balance targets** (checked by `sim/sim.js`, which runs the real combat code 200 times per strategy): an always-stealth player clears M1 **without anyone being alerted in about 10–20% of runs**. An open assault at level 1 with potions is lost in **about 15–25%** of runs.

### Archery & Arrow Types
| Arrow | Cost | Effect |
|---|---|---|
| Broadhead | 1g | Damage band +1 vs unarmoured targets (hunting bow 4–10) |
| Bodkin | 2g | Ignores 2 armour |
| Fire | 4g | Damage band +1, plus 2 burn/round for 3 rounds; **stops troll regeneration**. A fire event when used from hiding. |
| Barbed | 3g | Bleed 2/round; the target's Guard drops by 1 |
| Blunt | 1g | Nonlethal: deals Stun (for knockouts) |
| Whistler | 2g | No damage. Distracts: +2 to the next Sneak, or pulls one enemy away. |
| Silvered | 8g | +3 vs shamans and warlocks; breaks a hex |

The quiver holds 30 (40 with Rook). Arrows are lost on use unless you have Eagle Eye.

### Picking Up Enemy Weapons

- **Grab Weapon** (an action) takes a weapon from a fallen enemy. A disarm happens on a melee critical: the enemy is −2 Attack and you can grab its weapon.
- Enemy weapons are crude and have **Durability** (fights before they break). The Tinker Twins buy them.

| Weapon | Base | Scale | Acc | Durability | Requirement |
|---|---|---|---|---|---|
| Goblin Shiv | 2 | 0.5 | +2 | 3 | — (fast: +1 on Sneak takedowns) |
| Orc Cleaver | 5 | 1.0 | −1 | 4 | Might 2 |
| Ogre Club | 7 | 1.5 | −2 | 3 | Might 3 |
| Troll Bone-Maul | 8 | 1.5 | −2 | 2 | Might 4 (blunt) |
| Shaman Staff | 3 | 0.5 | 0 | 2 | Cancels 1 hex while held |

### Improvised Throw

During a fight with **several enemies**, Quil can snatch a weapon from a **fallen** foe and hurl it at a living one as a **one-off** attack. He **cannot keep** the thrown weapon — it is spent on the throw (lost in the scramble, stuck in a shield, or shattered on impact).

**Prerequisite — open tempo:** the throw is allowed only when **no living enemy is currently engaging Quil in melee** (every living foe is at range, stunned, knocked prone, or otherwise not in his face). Creating or holding that gap **costs him the turn's tempo**: after an Improvised Throw, enemies act first on the following round (Quil loses initiative / cannot Riposte until he has acted again under normal order).

**Roll:** `2d6* + Might` vs the target's **Guard** (Target is usually the Guard rating; treat crude thrown weapons as Acc **0**, or **−1** if the weapon is an Ogre Club / Troll Bone-Maul). Meet or beat Guard to hit.

**Damage:** weapon **Base + ⌊natural roll × Scale⌋ + ⌊Might ÷ 2⌋ + 2** (thrown momentum). **Critical = ×2** and the target is knocked back / loses its next turn. A miss leaves the weapon on the ground (still not kept — it is out of Quil's hands for the rest of the fight unless he later spends **Grab Weapon** on a different fallen blade).

**Limits:** needs at least one fallen enemy with a grabable weapon and at least one living enemy. Bosses' personal arms cannot be thrown this way. Counts as Quil's action for the round.

### Nonlethal Knockouts

- **Subdue:** attack at −1 Acc with the pommel, a blunt weapon or a blunt arrow. The damage counts as **Stun**. When Stun is greater than or equal to the enemy's current HP, the enemy is **knocked out**. A takedown from stealth can choose KO instead of a kill.
- Bosses cannot be knocked out. Mini-bosses can, if they are below 25% HP and Quil wins a Might check vs 9.

### Interrogation
After the fight, pick a knocked-out captive:
| Approach | Roll | Notes |
|---|---|---|
| **Intimidate** | Might + Corruption tier (0 to +2) | **Brutal** option: +2 to the roll, but +3 corruption |
| **Persuade** | Charm (+1 with related intel, +2 with Nim vs goblins) | No corruption. Offering a bribe costs 20g for +1. |

**Resolve targets:** Goblin 5 · Orc 7 · Ogre 6 · Troll 8 · Officer/Mini-boss +2.

| Result | Outcome |
|---|---|
| Critical | **Every** intel card for the mission + a hidden loot cache |
| Strong Success | 2 intel cards |
| Success | 1 intel card (you choose the type: Route, Weakness, Loot or Captive) |
| Fail | Nothing. The captive stays silent. |
| Fail by 3+ / Gravedice | **A lie.** You get a false card marked "?". Spot it with Wits 6, or walk into an ambush. |

**The captive's fate afterwards:** *Release* (may raise the next mission's Alertness by +1) · *Bind & leave* (neutral) · *Execute* (+1 corruption; Low-tolerance damsels at camp lose 3 affection).

### Cursed Weapons — dropped ONLY by bosses (M5, M10, M15, M20)
They are very strong, and they are always optional to pick up and equip. **Corruption** (0–100) changes how the world treats Quil.

| Weapon | Boss | Base / Scale / Acc | Power | Curse |
|---|---|---|---|---|
| **Flayer's Hook** | Grukk | 6 / 1.0 / +1 | Bleed 3; heal 3 HP on each kill | +1 corruption per kill; −1 Charm in towns while equipped |
| **Drowner's Chain** | Skarra | 7 / 1.5 / 0 | Reach; drags archers into melee; on a critical the target loses 2 turns | +4 corruption per mission equipped; camp rest heals only 75% |
| **Emberbrand** | Vorgath | 8 / 1.5 / +1 | Fire: burn 3, stops regeneration | Quil takes 1 burn per round; +2 corruption per combat |
| **The Tithe** | Mawrot | 6 / 2.0 / +3 | Shadowstep: Sneak always succeeds | +5 corruption per kill. At 100 corruption, see the "Crowned" ending. (NG+ only.) |

| Corruption | Tier | How the world reacts |
|---|---|---|
| 0–24 | **Clean** | Normal |
| 25–49 | **Shadowed** | Prices +10%. Black Marrow appears. Low/Very-Low-tolerance damsels −1 on checks. Townsfolk whisper. |
| 50–74 | **Tainted** | Prices +25%. Temples charge double. Low-tolerance damsels earn half affection. High-tolerance damsels +1. Intimidate +1. |
| 75–99 | **Damned** | Some shops refuse you, guards draw steel, Sunsorrow burns. Very-Low damsels leave the Hearth. Intimidate +2. Family epilogue darkens. |
| 100 | **Fallen** | The **Crowned ending**: Quil takes the Throne of Teeth. Romance ends unless the damsel is Very-High tolerance (Isra, Kes). |

**Cleansing:** temple (50g per −5 corruption), Brother Ostrum's holy water, Sunsorrow, Odile or Aldric camp rites (−5 each, once per camp).

---

## 7. Player Stats, Levelling, Inventory & Economy

### Stats (0–5, each value adds directly to rolls)
| Stat | Governs |
|---|---|
| **Might** | Melee attack, half to melee damage, Intimidate, weapon requirements |
| **Edge** | Archery, Sneak, Flee |
| **Grit** | Defence, HP, resisting spores, cold and poison |
| **Wits** | Traps, searching, spotting lies, Scout at camp |
| **Charm** | Persuade, recruit and romance checks, flirting, haggling (−5% price per point) |

- **Start:** Might 1, Edge 1, Grit 1, Wits 0, Charm 1, plus **2 free points** (a maximum of 2 in any stat at level 1).
- **HP** = 20 + 5×Grit + 4×(Level − 1).

### Levelling

- **XP:** each main mission gives 100 + 20×mission number. Side missions give 250, rescues 25, and interrogation intel 10 per card.
- **Next level** costs 100 × current level XP. The level cap is **15**, and a typical run reaches level 13–15.
- **Every level:** +4 HP. **Every even level:** +1 stat point (max 5).
- **Feats at levels 3, 6, 9, 12 and 15** (pick 1):

| Feat | Effect |
|---|---|
| Cleave | A kill gives you a free attack on another enemy |
| Quickdraw | Shoot and Strike in the same round, once per combat |
| Silent Step | +2 Sneak; failing a takedown doesn't alert the whole area |
| Iron Jaw | Grazes deal 0 damage |
| Silver Tongue | Reroll one failed Persuade or Romance check per mission |
| Butcher's Eye | Called Shots at −1 instead of −2 |
| Hard Bargain | Shops −15%, jewels sell for +15% |
| Last Stand | Once per combat, survive a lethal hit with 1 HP |

### Inventory (slot-based)

- **Equipped:** Main hand, off hand/shield, bow, quiver (30), armour, 2 trinkets.
- **Pack:** 12 slots (16 with the Saddlebags at 120g, 20 with the Pack Mule at 300g). Enemy weapons and armour take 1 slot each. Potions stack ×5. **Jewels and gold are weightless.**
- **Armour:** Leather +1 · Studded +2 · Chainmail +3 · Half-Plate +4 · Full Plate +5 (−1 Edge, −2 Sneak).

### Gold & Economy
| Item | Price |
|---|---|
| Healing Draught (heals 15) / Greater (heals 40) | 15g / 40g |
| Bandage (stops bleeding) | 5g |
| Room at an inn (full heal and save outside camp) | 10g |
| Gifts (flowers 5g, perfume 25g, silk 60g, jewel pendant 120g) | varies |
| Arming Sword / Longsword / Greatsword | 60g / 150g / 250g |
| Chainmail / Half-Plate / Full Plate | 200g / 450g / 800g |

| Jewel | Jeweller pays | Trader pays (60%) |
|---|---|---|
| Garnet | 10g | 6g |
| Amethyst | 20g | 12g |
| Sapphire | 30g | 18g |
| Emerald | 40g | 24g |
| Ruby | 60g | 36g |
| Diamond | 100g | 60g |

**Gold sinks:** rebuilding Hollowmere (1,200g total), gear, cleansing, gifts, and the wedding (§8).

---

## 8. Romance System

### Damsel Roster
**Tolerance** is how much corruption she accepts. **Heart** is the spark Target after her rescue.

| # | Name | Brief description | Likes | Dislikes | Tolerance | Heart |
|---|---|---|---|---|---|---|
| 1 | **Tamsin Reed** | Freckled miller's daughter, sharp-tongued, and Quil's childhood friend | Honesty, home | Cruelty | Low | 5 |
| 2 | **Ysolde Fane** | Raven-haired hedge-witch's apprentice who smells of yarrow, wry | Cleverness, herbs | Boasting | Medium | 6 |
| 3 | **Corisande Vell** | Poised Briarwatch heiress in gold rings, bored of soft suitors | Daring, jewels | Poverty talk | Medium | 7 |
| 4 | **Brenna Holt** | Broad-shouldered stonecutter with a loud laugh and steady hands | Strength, mercy | Sneaking | Low | 5 |
| 5 | **Marisol Keel** | Sun-browned eel-fisher who sings to the reeds | Patience, water | Hurry | Medium | 6 |
| 6 | **Odile** | Pale novice nun, devout, quietly doubting | Kindness, faith | Cursed weapons | Very Low | 7 |
| 7 | **Kestrel "Kes" Morrow** | Smuggler captain with a scarred lip and a knife at her thigh | Boldness, plunder | Rules | Very High | 7 |
| 8 | **Delphine Aubrac** | Velvet-voiced singer with a merchant's mind | Music, grand gestures | Crudeness | Medium | 6 |
| 9 | **Yrsa Gorrakh** | Half-orc warlord's daughter: tall and powerful with green-grey skin and small tusks, proud, guarded and secretly tender | Strength, loyalty, being seen as herself | Pity, slurs, cowardice | Medium | 9* |
| 10 | **Lady Elowen Marr** | Melancholy exiled noble, bookish, quietly fierce | Poetry, her keep | Brutality | Low | 7 |
| 11 | **Zahra al-Sidra** | Kohl-eyed caravan dancer and shrewd spice trader | Wit, coin | Dullness | High | 6 |
| 12 | **Nerys Fallow** | Lean, hooded Last Lantern scout, sardonic | Stealth, competence | Recklessness | Medium | 7 |
| 13 | **Lirien Vale** | Ink-stained half-elven cartographer, endlessly curious | Discovery, maps | Lies | Low | 6 |
| 14 | **Aurelie Vance** | The Duke's proud daughter, fierce and used to command | Respect, courage | Flattery | Low | 8 |
| 15 | **Isra** | The King's white-eyed oracle, eerily calm with a dark sense of humour | Truth, fate | Pity | Very High | 8 |

**\*Yrsa and town distrust:** towns fear and distrust a half-orc, so every Yrsa romance roll made in or about a town (town retries, town scenes, the proposal) is **+1 difficulty**, and gossip about her never lowers. In return her rewards are bigger: **+50% Affection** from camp scenes and gifts, and at Devoted her bonus is the Orc-Breaker perk plus **+1 Might** at camp Train. If she is the bride, the Lantern Night epilogue shows Hollowmere learning to welcome her.

### Spark (the check after a rescue)
Roll **2d6\* + Charm** vs Heart. **Modifiers:** +1 if freed without raising the alarm · +1 if freed before the fight ended · +1 with a [Captive] intel card · +1 for a fitting gift · −1 per corruption tier above her tolerance.

- **Critical:** Affection 35 (Fond) + her personal side scene.
- **Success:** Affection 20. She joins the Hearth and can be romanced.
- **Fail:** Affection 5. She goes to the nearest town, and you get **one retry** there (with a gift, Heart +1).
- **Gravedice:** she leaves with a polite thank-you. No romance.

**Allies use the same roll** (their Heart is 6–8). A success gives you the named perk. A fail means they leave with a one-time parting gift (Aldric: 3 holy water · Rook: 20 bodkins · Nim: a goblin map · Gideon: a free masterwork upgrade · Hallam: a tower shield).

### Affection (0–100)
| Tier | Range | Unlocks |
|---|---|---|
| Acquainted | 0–19 | Talk |
| Fond | 20–39 | Camp scene 1, gifts |
| Smitten | 40–59 | Camp scene 2: flirting, a kiss |
| Devoted | 60–79 | Camp scene 3: **steamy, suggestive, fade to black** · her +1 combat or camp bonus |
| Beloved | 80–100 | Camp scene 4: her personal quest resolves · proposal possible |

**Gains:** camp scene +5 to +10 · a liked gift +5 (a disliked one −5) · dialogue choices ±3 to ±8 · rescuing others the way she likes (stealth, mercy, boldness) +2 · her personal quest +15.
**Losses:** her dislikes · cruelty in front of a Low-tolerance damsel −3 to −10 · corruption over her tolerance (gains are halved).

### Jealousy & Rivalry

- Each damsel has **Jealousy 0–10**. It rises +1 for every Smitten-or-higher damsel when Quil spends a camp scene with someone else, +1 when he gives a gift to another, and +2 when town gossip reaches her about a townsfolk flirt. It falls −2 for each camp scene with her.
- **At 5, "Cold Shoulder":** she is −1 on her checks until she is reconciled (a Charm check vs 6 at camp).
- **At 8, a Rivalry Event:** two damsels confront Quil. Examples: *Kes vs Aurelie* over "pirate trash", *Yrsa vs Brenna* in an arm-wrestling bout, *Delphine vs Zahra* in a song-vs-dance-off at the Gilded Gull. You resolve it one of three ways:
  - **Choose one:** she gets +10. The other gets −20 and a reset.
  - **Mediate:** Charm vs 8. On a success, both reset to 0 Jealousy. On a failure, both lose 10.
  - **Let them settle it:** a mini-game (archery, drinking, a dice game with Ashdice). The winner gets +10 and the loser cools off.
- **At 10:** she leaves the Hearth, unless she is Beloved.

### Townsfolk Flirts (light romance)
A Charm check vs 5–7 gives a 10% discount, a free rumour (intel) or a small gift. Three successes unlock one **"night in town"** scene, which **fades to black**. It's no-strings and doesn't count toward the wedding, but gossip can trigger Jealousy.

### Final Selection & Wedding

1. **Lantern Night**, after M20 in rebuilt Hollowmere: every damsel at Devoted or higher attends.
2. **The proposal:** a Beloved damsel accepts automatically. A Devoted one needs Charm vs 7 (+1 per 100g spent on the ring).
3. **The wedding**, in the rebuilt Hollowmere chapel or under the Elder Oak if you have Whisperwind. Maren blesses the couple with Tomas's ring, Wren gives the toast, Elsie carves the wedding birds, and the allies attend (Aldric officiates if recruited). Gold spent on the feast (0/200/500g) changes how grand the scene is.
4. **Epilogues** depend on the bride × corruption tier × the family's reaction. Damsels who weren't chosen get short epilogue cards. You can also choose to stay **unwed** ("The Wanderer" ending).

---

## 9. Camp, Rest & Autosave

### Camp (between every mission and on the road)
You get **2 activities** (3 if Hollowmere is rebuilt to stage 2 or higher):
| Activity | Effect |
|---|---|
| **Rest** | Full HP, clears bleeding and burns (75% with the Drowner's Chain) |
| **Train** | +40 XP |
| **Craft** | Make 10 arrows of one type from loot scraps (50% cost) |
| **Sharpen/Repair** | +1 damage next mission, or +1 durability on picked-up weapons |
| **Talk** | A camp scene with **one** damsel or ally (affection, story, jealousy effects) |
| **Rite** | −5 corruption (needs Odile or Aldric) |
| **Scout** | A Wits check vs 6 reveals one intel card for the next mission (Wren gives +1) |
| **Interrogate** | Question a captive who is still bound |

**Night Event** (roll 2d6\*): 0 ambush (a short fight) · 1–3 bad dream or a minor theft · 4–7 a quiet night · 8–9 a road trader or traveller visits · 10 an omen (a free [Captive] or [Weakness] card).
**Camp scenes** are firelit dialogue with a choice of 3 responses. Intimate scenes end on a fire-crackle **fade to black** and a dawn cutaway.

### Autosave

- **Triggers:** mission start, after each combat, entering camp, entering a town, after each rescue, and on `visibilitychange` (when the app goes to the background).
- **Storage:** IndexedDB. **3 rotating autosaves + 3 manual slots.** Call `navigator.storage.persist()` on install.
- **Export/Import:** the save as a JSON file or a copyable code (a backup against iOS storage eviction).
- **Ironman mode** (optional): a single autosave slot only.

---

## 10. World Map — the Vale of Embers

The map is a hand-painted parchment map that scrolls vertically, travelling west to east and then down into the deep. Paths unlock as missions are completed. **Fast travel** to visited towns costs 1 trader-encounter roll.

| Region | Locations |
|---|---|
| **Hollowmere Vale** (west, farmland) | **Hollowmere** (hub town) · Ashby Farm · Hollowmere Mill · M1 |
| **Thornwood** (old forest) | Charcoal Track (M2) · Rillwater Bridge (M3) · Elder Oak (S1) |
| **Briarwatch March** | **Briarwatch** (town) · East Gate (M4) · Crypt of Saint Halvard (S2) · Redstone Quarry (M5) |
| **Fenmire** (marsh) | Fenmire Crossing (M6) · Drowned Chapel (M7) · Hagmaw's Stilt-Hut (M8) |
| **Saltmarrow Coast** | **Saltmarrow** (port town) · Saltmarrow Docks (M9) · *Brinewidow* at sea (M10) · Singing Caves (S3) |
| **Grimspire Mountains** | **Kettlewick** (mining town) · Kettlewick Under (M11) · Ironroot Hall (S4) · Frostback Pass (M12) · Hollowhorn Keep (M13) |
| **Ashen Wastes** (volcanic desert) | Ashen Road (M14) · Skyfall Crater (S5) · Cinder Forge (M15) |
| **Gloamfang Underkingdom** (beneath the eastern peaks) | **Last Lantern** (outpost town) · Gloamfang Gate (M16) · Fungal Warrens (M17) · Pit of Ul'grash (M18) · Weeping Galleries (M19) · **Throne of Teeth** (M20) |
| **Trade roads** | The King's Road (Hollowmere–Briarwatch–Saltmarrow) · Salt Road (coast–mountains) · Cinder Track (Kettlewick–Wastes–Last Lantern): road trader encounters happen here |

---

## 11. UI & Screen List (iPhone)

### Visual Style: "Candle & Iron"

- **Palette:** Obsidian `#0E0B0A` (background) · Bone parchment `#E8DCC4` (text) · Old gold `#C8A24A` (frames, highlights) · Ember `#C2410C` (actions, criticals) · Dried blood `#7A1C1C` (damage, corruption) · Moss `#4A5D3A` (success).
- **Type:** *Cinzel* for headings, *EB Garamond* for body text (self-hosted, so it works offline). Minimum size 17pt.
- **Materials:** a dark leather texture, gilt filigree corners, wax seals for confirmations, faint parchment grain, and an ember particle glow on critical hits. Corruption slowly creeps black veins into the UI borders.
- **Layout:** portrait 390×844 base. Respect `env(safe-area-inset-*)`. Primary actions sit in the bottom-third thumb zone, and hit targets are at least 44pt.
- **Bottom bar:** Map · Pack · Hero · Hearth · Journal. Combat, dialogue and camp are full-screen takeovers.
- **PWA:** `display: standalone`, `apple-mobile-web-app-status-bar-style: black-translucent`, an apple-touch-icon (a gilt "Q" on a black shield), a service worker for offline play, and an "Add to Home Screen" coach sheet on first run in Safari. iOS Safari has no vibration API, so the game uses visual and audio "thuds" instead of haptics.

### Screens
| # | Screen | Key elements |
|---|---|---|
| 1 | **Title** | Painted Quil silhouette against burning Hollowmere, Continue / New / Load, dice-mode toggle |
| 2 | **New Game** | Distribute 2 stat points, difficulty, dice mode, Ironman |
| 3 | **World Map** | Pannable parchment map, glowing mission seals (gold = main, silver = side, red skull = boss), towns, a travel line, corruption vignette |
| 4 | **Mission Brief** | Location art, objective, known intel cards, Sneak/Assault choice, loadout check |
| 5 | **Scene / Exploration** | Full-bleed scene art, narrative text panel, 2–4 choice buttons |
| 6 | **Combat** | Top: enemy cards (art, HP bar, Guard/Attack, status icons). Middle: the action log. Bottom: action wheel (Strike, Shoot, Subdue, Grab, Item, Called Shot, Flee) and Quil's HP/arrows. |
| 7 | **Dice Entry Pad** | A bottom sheet showing the roll type, Target and modifier breakdown. **Two rows of bone-die buttons, 1–5 and 6 (labelled "6 = 0")**, or a quick-total pad (0–10). A live "Total vs Target" readout with a pass/fail seal, a "🎲 Auto-roll" button and an Undo. Criticals flare ember. Gravedice cracks the screen. |
| 8 | **Dialogue** | Character portrait (with expression variants), name plate, text, choice list with stat tags (e.g. `[Charm 7]`), affection heart pip |
| 9 | **Interrogation** | The captive's portrait, Resolve meter, Intimidate / Brutal / Persuade / Bribe buttons, intel cards dealt out on success |
| 10 | **Inventory (Pack)** | Paper-doll equipment slots, a 12–20 grid, weapon cards (Base/Scale/Acc/Durability), a cursed item glow and warning seal, sell/drop |
| 11 | **Hero (Stats)** | Portrait, level and XP, the 5 stats with modifiers, HP, feats, perks from allies, corruption gauge (a candle burning black) |
| 12 | **Hearth (Romance)** | Damsel cards with affection hearts, jealousy flames, likes/dislikes learned so far, location, gift button. Family panel. |
| 13 | **Camp** | Animated campfire at night, companion portraits around the fire, 2–3 activity slots, a Night Event result, a save indicator |
| 14 | **Town** | Painted street with shop signs, NPC portraits to talk to or flirt with, rumour board |
| 15 | **Shop / Trader** | Split buy/sell list, gold and jewel purse, haggle (Charm) button |
| 16 | **Journal** | Mission log, intel board (cards, false-flagged "?"), lore (Tomas's past), roll log |
| 17 | **Settings / Saves** | Dice mode, text size, music/SFX, content toggles (gore intensity: Full/Reduced; romance: Full/Tame), save slots, export/import |

---

## 12. Art Plan

### Pipeline

1. **Generate on demand:** each image is created the first time the game needs it (a portrait, scene, enemy or item) through an image-generation API call.
2. **Cache:** store images as WebP in **Cache Storage / IndexedDB**, keyed by a hash of `assetId + variant + styleVersion`. Cached images never regenerate. Show a parchment placeholder with an ink-bleed loading effect while an image is generating. Allow ~150 MB of art, with LRU eviction for scenes only and never for characters.
3. **Key characters first:** on first launch (behind the prologue text), generate **Quil, Maren, Wren, Elsie and Mawrot**, in that order. Each gets a **reference sheet** (neutral portrait + full body), with a locked seed and reference image. Every later image of that character is built from that reference plus a fixed **identity block** of text, which keeps them consistent.
4. **Next:** each damsel and ally is generated the moment they are rescued, and enemy types the first time they are met. Bosses are pre-generated one mission early.
5. **Prompt assembly:** `[STYLE ANCHOR] + [IDENTITY BLOCK] + [scene/expression/outfit] + [NEGATIVE]`.
6. **Content guardrails (hard-coded):** there are **no prompts for captivity scenes** involving Maren, Wren or Elsie. The family is only ever shown free, at home, or at the moment of rescue, fully clothed and dignified. Romance art goes no further than suggestive (a closeness or a kiss, clothed or draped). There is no nudity and no explicit content. Gore is allowed in combat and enemy art.

### Style Anchor (prepended to every prompt)
> dark fantasy oil painting, painterly realism, chiaroscuro lighting from candle, torch and ember, muted earthy palette with ember-orange and old-gold accents, weathered textures, cinematic composition, grim medieval world, mature fantasy book-cover quality, highly detailed, no text, no watermark, no frame

**Negative:** cartoon, anime, chibi, plastic skin, modern clothing, text, watermark, extra fingers, deformed hands, nudity

### Key Character Prompts

**Quil (Quilliam Ashby): reference sheet**
> Quilliam "Quil" Ashby, 19-year-old farmhand turned warrior, lean wiry build hardened by field labour, sun-browned skin, shaggy dark-chestnut hair falling over his brow, light stubble, storm-grey eyes, thin fresh cut through his left eyebrow, wearing a patched undyed linen shirt, scuffed brown leather jerkin, rope belt, worn knee boots, his father's iron hatchet at his hip, a simple ash-wood hunting bow and quiver over one shoulder, grief-hardened determined expression, three-quarter portrait plus full-body view, burning farmland and smoke at dusk behind him
- *Act variants:* Act II adds a salt-stained chainmail shirt and a sea-grey cloak. Act III adds a fur mantle, half-plate and new scars. Act IV adds dark plate. At high corruption: black veins at the temples and eyes glinting faintly gold.

**Maren Ashby (mother)**
> Maren Ashby, a strong dignified woman in her early forties, warm olive skin, long dark-auburn hair in a thick braid threaded with early grey, steady green eyes, faint laugh lines, wearing a modest deep-green wool kirtle with a woven shawl, a small silver acorn pendant, calm unbroken gaze, warm hearth light in a farmhouse kitchen, three-quarter portrait
- *Rescue variant (M20):* "weary but unbowed, fully clothed, wrapped in a heavy travelling cloak, standing tall in green witchlight, reaching for her son's face"

**Wren Ashby (elder sister)**
> Wren Ashby, 21, tall athletic young woman, sharp features, copper-red hair cropped at the jaw, heavy freckles, hazel eyes, defiant half-smirk, practical clothing: high-collared leather vest over a linen shirt, wool trousers, sturdy boots, a skinning knife on her belt, protective fighting stance, autumn woods, three-quarter portrait
- *Rescue variant (M10):* "fully clothed in a torn sailcloth coat, gripping a broken chain like a weapon, ship deck at night, fire behind her, fierce"

**Elsie Ashby (younger sister)**
> Elsie Ashby, 16, small bright-eyed girl, round freckled face, long light-brown hair in two braids tied with blue ribbon, gap-toothed hopeful smile, modest homespun dress with a wool cardigan, holding a little hand-carved wooden bird, wholesome and innocent, soft morning light at a farm gate, three-quarter portrait
- *Rescue variant (M5):* "wrapped in her brother's cloak, fully clothed, tear-streaked but smiling with relief, dawn light over a quarry"

**Mawrot, the Goblin King**
> Mawrot the Goblin King, an ancient and monstrously large goblin far bigger than his kin, hunched yet towering, mottled grey-green skin like wet slate, long hooked nose, enormous torn ears heavy with gold rings, left eye milky white across an old sword scar, right eye burning yellow, a grin of needle teeth, a crown of fused human teeth bound in black iron, a cloak stitched together from the banners of conquered towns, a gold ring on every claw, lounging on a throne of bones and stolen treasure in a vast cavern lit by green witchfire, tendrils of shadow magic curling from his fingertips, menacing, intelligent, amused
- *Phase variants:* P2 Shadow ("body dissolving into black smoke, only eye and crown visible"), P3 Desperate ("crown cracked, bleeding black ichor, cloak burning").

**Yrsa Gorrakh (half-orc damsel, M12)**
> Yrsa Gorrakh, a half-orc woman in her mid-twenties, tall and powerfully built with broad shoulders and strong arms, striking and beautiful, smooth green-grey skin, two small ivory tusks rising from her lower lip, fierce amber eyes under dark brows, long black hair in warrior braids bound with bronze rings, a thin ritual scar on one cheek, fully clothed in a fur-trimmed leather and bronze-scale hauberk over a dark red wool tunic, leather bracers, heavy boots, a broken orc spear in one hand, proud defiant expression with a hint of warmth, standing free on a snowbound mountain pass in a blizzard at dusk, torchlight on the snow, three-quarter portrait
- *Choice variant (M14):* "standing beside Quil, the two halves of her father's spear at her feet, a huge armoured orc warlord in the smoke behind her, the ashen road, ember light, resolute"
- *Guardrails:* clearly adult, fully clothed, dignified, never shown bound or under guard.

### Battle Moment Art (shipped, v9)
These three cards are shown once per trigger, with a Continue button and no auto-dismiss. All three are also in the Gallery's Battle tab.
- **Silent Takedown** (`stealth_takedown.webp`): the kill card for a successful Edge takedown kill, in place of the generic hatchet card.
- **Alarm** (`alarm_horn.webp`): shown the first time in a fight that a goblin finds a body or a horn or whistle sounds.
- **Badly Wounded** (`quil_wounded.webp`): shown the first time in a fight that Quil drops below 30% of max HP without being downed.

### Other Asset Queues (generated on demand)
Damsels and allies (on rescue, with 4 expressions each: neutral, smile, angry, tender) · enemies (12 types + 7 bosses) · 28 location scenes · item icons (weapons, arrows, jewels; the legendary and cursed weapons each get a hero image) · camp backgrounds (forest, marsh, mountain, waste, deep) · the wedding scene (bride-specific, generated at Lantern Night).

---
*End of document.*
