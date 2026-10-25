# Quil: The Goblin King's Tithe — ARPG prototype (Unity 6)

A Diablo-style, top-down action RPG prototype. You play **Quil Ashby**, a 19-year-old farmhand, fighting goblins in
the burning village of **Hollowmere** with his dead father's hatchet. Everything is grey-box (capsules and cubes)
for now. The concept art is in `Assets/Art/Concept` and the full design doc is in `Docs/design.md`.

**Milestone 1 includes:** Xbox controller + keyboard/mouse controls, an isometric Cinemachine camera, health and stamina,
a 3-hit hatchet combo, a heavy chop, a dodge roll with invincibility frames, health potions, NavMesh goblin AI (idle → chase → attack → hit-react → death),
an endless goblin spawner that gets harder in waves, variable damage with critical hits, floating damage numbers and a HUD.

---

## 1. Install Unity (one time, about 30–60 minutes)

1. Download **Unity Hub** from https://unity.com/download and install it, then sign in. A free Unity Personal licence is fine.
2. In Unity Hub, go to **Installs → Install Editor**, choose the latest **Unity 6 (6000.0.x) LTS**, and click Install.
   - On the modules screen, tick **Microsoft Visual Studio Community** if you don't already have a code editor.
   - Optionally tick **Universal Windows Platform Build Support** (needed for the Xbox step later).
3. Wait for the install to finish.

## 2. Open the project

1. Download this repository: on GitHub click the green **Code → Download ZIP** button and unzip it,
   or run `git clone https://github.com/dt258t5722-ai/quil-arpg.git`.
2. In Unity Hub, click **Add → Add project from disk** and select the `quil-arpg` folder (the one that contains `Assets`).
3. Click the project to open it. The first open takes several minutes because Unity downloads packages and imports everything.
   - If Unity says the project was made with a slightly different 6000.0 version, click **Continue** or **Open** — any Unity 6 LTS works.
   - If a dialog asks to **enable the new Input System backends** and restart, click **Yes**. The editor restarts.

## 3. Build the test level

1. In the top menu bar click **Quil → Build Test Scene**.
2. This does the following automatically:
   - sets up the Universal Render Pipeline (URP) if it isn't set up yet,
   - builds Hollowmere: ground, roads, burning cottages, the Ashby farmhouse, a mill, a well, fences, barrels, firelight and the dusk lighting,
   - adds Quil (the blue capsule with a hatchet), the camera, the goblin spawner and the HUD,
   - bakes the **NavMesh** (the walkable area goblins use to find their way),
   - saves everything as `Assets/Scenes/Hollowmere.unity` and adds it to the build list.
3. If a dialog says *"Active Input Handling was switched… restart"*, save, close Unity, reopen the project and run
   **Quil → Build Test Scene** again.

> Shortcut: pressing **Play** in *any* scene, even an empty one, builds Hollowmere on the fly. The menu item just saves a proper scene you can edit.

## 4. Play with an Xbox controller

1. Plug in the Xbox controller with a USB cable, or pair it over Bluetooth, **before** pressing Play.
2. Open `Assets/Scenes/Hollowmere.unity` (double-click it in the Project window) and press the ▶ **Play** button at the top.
3. Click once inside the Game view so it has focus.

| Action | Xbox controller | Keyboard + mouse |
|---|---|---|
| Move | Left stick | WASD / arrow keys |
| Aim / turn | Right stick | Mouse cursor |
| Hatchet combo (light) | **A** or **RT** (tap repeatedly for a 3-hit combo) | Left mouse button |
| Heavy chop | **X** | Right mouse button |
| Dodge roll (invulnerable mid-roll) | **B** | Space |
| Health potion | **Y** | Q or 1 |
| Rise again after death | **A** | Enter |

Goblins glow red just before they swing. That's your cue to dodge. Crits show as large gold numbers. Goblins sometimes drop potions.
The controller rumbles when you land a hit or take one.

**Tuning:** select **Quil** in the Hierarchy while the game is playing, or after building the scene, and change values in the Inspector,
such as move speed, stamina costs, damage ranges, crit chance and potion heal amount. Select a goblin to tune the goblins in the same way.
Changes made while the game is running are lost when you stop it.

## 5. Next steps: running it on an Xbox

There are two routes:

- **Xbox Dev Mode (UWP), free:** buy the one-time Microsoft Partner developer account, then switch a retail Xbox Series X|S
  or Xbox One into Dev Mode using the *Xbox Dev Mode* app from the Xbox store (https://learn.microsoft.com/windows/uwp/xbox-apps/devkit-activation).
  In Unity, install the **Universal Windows Platform** module. Then go to **File → Build Profiles → Universal Windows Platform**, build,
  open the generated Visual Studio solution, set the target to *Remote Machine* (your Xbox's IP address), and deploy.
  UWP apps in Dev Mode have limited memory and GPU access, but that's plenty for this prototype.
  Note: Microsoft has deprecated UWP for new Xbox *store* titles. It still works for personal testing in Dev Mode.
- **Microsoft GDK (the real console route):** a commercial release requires the **ID@Xbox** program,
  which gives you GDK access, dev kits and Unity's Xbox platform packages under NDA. Apply at https://www.xbox.com/en-US/developers/id.
  The PC version can ship on the Microsoft Store and Game Pass PC with the public PC GDK.

Code-side, nothing needs to change: controls already use the Input System's generic `Gamepad`, which maps to the Xbox pad on every platform.

## Project layout

```
Assets/
  Scripts/Core        Health, DamageInfo (variable damage + crits), melee hit arcs
  Scripts/Player      PlayerController (combo, heavy, dodge i-frames, stamina, potions), QuilInput (bindings)
  Scripts/Enemies     GoblinAI (NavMesh state machine), EnemySpawner (waves)
  Scripts/UI          QuilHUD, DamageNumbers
  Scripts/Bootstrap   HollowmereBuilder (builds the level), RuntimeBootstrap (auto-build on Play)
  Editor              QuilSceneBuilder (menu: Quil > Build Test Scene / Rebake NavMesh)
  Art/Concept         Concept art from the design (reference only)
Docs/design.md        Full game design document
```

## Known limitations (prototype)

- Characters are capsules, and attacks are shown by swinging the hatchet and tilting the body. There's no animation yet.
- The HUD and damage numbers use Unity's simple IMGUI system. They should move to UI Toolkit or uGUI later.
- There's no audio yet.
