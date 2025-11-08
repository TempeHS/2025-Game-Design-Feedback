
# Project Title:  <ins> <i> Eco Runner </i> <ins> </ins>
# Video Walkthrough:
## Contents:
*  Simple Overview/Purpose
*  Controls
* Menu
* Features/Elements
* Storyline
* Use Docuementation
* Developer Docuementation

  
https://github.com/user-attachments/assets/c0a72539-b741-4f39-965d-2fd5940b4762



> [!NOTE]
> Transition into Level 2 wasn't added due to difficulty of the game.
# Table of Contents
1. [Controls](https://github.com/2025CT_Zaif.K_Name/EcoRunner##Controls)

## Simple overview of use/purpose:
 <b>Eco Runner is an educational adventure game designed to raise awareness about climate change and sustainability. Players take on the role of an environmental hero tasked with cleaning up pollution, restoring ecosystems, and promoting responsible behavior through interactive storytelling. </b>

<i> Every action counts. Eco Runner teaches players that small steps—like recycling or cleaning up waste—can lead to big environmental change. </i>

<p>The core mission of Eco Runner is to raise awareness about sustainability and climate action through immersive gameplay. Players navigate diverse environments—urban, forest, oceanic—each facing unique ecological challenges. By completing tasks such as cleaning up litter, recycling materials, and rehabilitating wildlife habitats, players learn that every action counts in the fight against climate change.</p>

## Description

<b> In Eco Runner, players explore diverse environments—from forests and oceans to urban landscapes—each facing unique ecological challenges. The game combines platforming, puzzle-solving, and resource management to teach players about climate change, recycling, and responsible living </b>

## Controls
<img width="631" height="190" alt="image" src="https://github.com/user-attachments/assets/f5421f9d-69fd-4221-85ca-b3f1da27d9d4" />

## Main Menu (Interactive Design) <b>Eco Runner</b>
<img width="987" height="555" alt="image" src="https://github.com/user-attachments/assets/49043d69-71cf-4ad2-b4b3-f739804366e2" />
<p>The main menu of <b>ECO RUNNER  </b> sets the tone for an immersive, environmentally conscious gaming experience. With its striking visual design and clear thematic messaging, it invites players into a world where sustainability and action go hand in hand.</p>
The menu offers three straightforward options in vibrant green text:

<b> PLAY</b> – Launches the game, signaling immediate engagement with eco-themed challenges.

<b>OPTIONS</b> – Allows players to customize settings, likely including controls, audio, and possibly eco-related gameplay modifiers. Although this hasn't been coded yet. 

<b> QUIT</b> – Exits the game, maintaining the minimalist and user-friendly interface. Whilst this has been coded this is only possible outside of Unity when the game has been fully developed. , <i>All these button uses SpatialMappingOcclusion</i> to achieve this desired effect.

## Why it Matters 
Eco Runner helps players understand that:

* Climate change is a shared responsibility

* Small actions can lead to meaningful impact

* Games can be a force for good

## Features

🪙 Coin Collection System
The coin mechanic serves as both a reward and a progression driver. Coins are strategically placed to encourage exploration and risk-taking, often positioned near hazards or on elevated platforms. Each coin collected contributes to the player's score and may unlock future upgrades or achievements. The floating animation and subtle glow effect make them visually enticing, while their placement subtly guides the player through optimal paths.

<img width="111" height="22" alt="image" src="https://github.com/user-attachments/assets/82416741-5b97-4e99-b62c-df080a521ef3" />
<img width="32" height="32" alt="Collectable Coin-1 png" src="https://github.com/user-attachments/assets/fac908f8-c615-4760-957c-393f3b36283d" />
<img width="32" height="32" alt="Collectable Coin-2 png" src="https://github.com/user-attachments/assets/323c2772-5273-4b21-909f-d487a49dea57" />
<img width="32" height="32" alt="Collectable Coin-3 png" src="https://github.com/user-attachments/assets/6d6578c6-c3d4-4047-b880-558ac3c896cc" />
<img width="32" height="32" alt="Collectable Coin-4 png" src="https://github.com/user-attachments/assets/d15f50b6-b242-4021-9dba-6e09ae4ee24a" />
<img width="32" height="32" alt="Collectable Coin-5 png" src="https://github.com/user-attachments/assets/bd2416e9-5b61-4f34-bfe3-b6c0a7a83765" />
<img width="32" height="32" alt="Collectable Coin-6 png" src="https://github.com/user-attachments/assets/d7095afc-7088-432d-bbe0-ac04736130b2" />

⏱️ Time Limit & Self-Destruct Mechanism
Each level is coded with a 90-second time window, adding urgency and pacing to the gameplay. If the player fails to reach the goal within this limit, a self-destruction sequence is triggered—whether through environmental collapse, character fade-out, or a thematic "nature rejection" effect. This mechanic reinforces the idea that action must be timely to preserve the ecosystem, aligning with the game’s environmental message.

⏸️ Resume/Pause Menu
The pause menu is clean and functional, allowing players to pause gameplay in real time with adherence to the physics of the game.

🧱 Spike Dodging & Level Progression
Progression to Level 2 requires precise movement and hazard avoidance. Spikes are placed as environmental threats that demand timing and spatial awareness. Their placement isn’t random—they’re designed to test the player’s mastery of jump arcs and platform spacing. Successfully dodging them not only unlocks the next level but reinforces the theme of navigating a damaged world with care and precision.
<img width="730" height="98" alt="image" src="https://github.com/user-attachments/assets/77b96dfa-9ded-466c-8d68-e5d734936055" />


⚠️ Death Boundary
A coded death boundary ensures that falling off-screen or into designated danger zones results in instant failure. This mechanic maintains challenge integrity and prevents unintended exploration beyond the designed map. It’s a classic platformer feature, but here it’s framed as falling into ecological ruin—adding thematic weight to player failure.

🎥 Virtual Camera Follow
* The game uses a virtual camera system that smoothly tracks the player’s movement across the tilemap. This dynamic follow ensures:

* Consistent framing of the character

* Visibility of upcoming terrain and hazards


 
 <img width="1096" height="554" alt="image" src="https://github.com/user-attachments/assets/c9683aa2-0fb3-4fe6-838d-5a8e255acf90" />

 <img width="447" height="402" alt="image" src="https://github.com/user-attachments/assets/0b6b5600-aeee-4856-a672-0900ae5aebd0" />

<img width="447" height="402" alt="image" src="https://github.com/user-attachments/assets/34dd9419-0af7-4b05-b35a-ed0944a1a777" />

A cinematic feel that enhances immersion The camera may also zoom or pan slightly during key moments (e.g., coin pickups, near-death escapes), adding polish and emotional impact.
## Spawn Entry:
 <img width="990" height="554" alt="image" src="https://github.com/user-attachments/assets/bbd19204-4064-48d0-b3da-5c56f84eeadc" />

<b><p>In designing the spawn environment for Eco Runner, I aimed to create a visually immersive and thematically rich entry point that immediately communicates the game’s ecological focus. The tilemap features layered grassy platforms with soft, organic edges, suggesting natural terrain rather than rigid, artificial structures. I used pixel textures that blend earthy tones—deep greens, muted browns, and mossy overlays—to evoke a sense of overgrowth and renewal. The background, with its silhouetted pine trees and twilight sky, adds depth and atmosphere, reinforcing the idea that the player is entering a forest in recovery. Every texture was chosen to feel hand-crafted and alive, from the flower crown on the character to the subtle shimmer of the coin, creating a world where nature is central and every detail supports the theme of restoration. My goal was to make the player feel grounded in a living ecosystem from the very first moment, where exploration and environmental impact are tightly intertwined.</p></b>


## Character Design & Storyline:
🌍 The Year is 2145. Earth is in Crisis.

The ice caps have melted. Sea levels have swallowed coastlines. Forests are fading into memory, and the air is thick with pollution. Humanity stands at a crossroads.

But one hero refuses to give up.

Meet Kai, a fearless climate defender armed with cutting-edge eco-tech and unstoppable courage. From the flooded ruins of old cities to the last surviving green zones, Kai battles the forces destroying our planet.


<img width="484" height="135" alt="image" src="https://github.com/user-attachments/assets/4118e7e2-5d48-42e2-91a0-741fe7cd34ee" />

<img width="126" height="146" alt="image" src="https://github.com/user-attachments/assets/c1f85c89-7b03-47bc-8a67-ece949341a97" />
<img width="503" height="244" alt="image" src="https://github.com/user-attachments/assets/28af92be-209e-4dcc-8083-8dfdb37ef16e" />

##Organisation of Files/Scripts/Assets: 
<img width="1240" height="213" alt="image" src="https://github.com/user-attachments/assets/2cd97d8f-c974-4478-932f-518e25aaa9f6" />
I’ve effectively incorporated free or credited assets (e.g. pixel art tiles, character sprites, UI icons) to build a cohesive visual style. These assets are integrated seamlessly into your game world, and their use is clearly acknowledged in your documentation. With the experimentation of various sprites and assets, I have continued to develop my game with a range of interactive features. Most of the files are organised and have been up to date whilst being commited to GitHub in regular intervals. 

## Animator Layout:
<img width="504" height="141" alt="image" src="https://github.com/user-attachments/assets/f3374919-d22f-4bf3-a438-1d9677a2da29" />
<p> Initially, I planned to implement jump animations to enhance the character's movement, but noticed the animation system defaulted to idle regardless of input. To address this, I first added a walk animation that triggers correctly when movement is detected. Since the dash mechanic was already implemented, integrating the walk cycle helped bridge the gap between idle and dash states, laying the groundwork for future animation transitions like jumping and landing. This will be discussed in my file for the scripts and how I edited it to include the boolean </p>

## Tutorials Used:
| Tutorials  | AI|
| ------------- | ------------- |
| MoreBlakkey | Microsoft Copilot |
| 2D Platformer Videos  | Game Code Library |

| Links         | 
| ------------- | 
| Brakkey's: [Link]( https://www.youtube.com/watch?v=UbPiCgCkHTE) | 
| Pandemonium 2D Platformer Playlist: [Link](https://www.youtube.com/watch?v=TcranVQUQ5U&list=PLgOEwFbvGm5o8hayFB6skAfa8Z-mw4dPV ).  |

I used tutorials—especially ones by Brackeys and others on YouTube—to get the core mechanics of my 2D platformer working, like movement, jumping, and collision detection; Brackeys' breakdowns of Unity physics and scripting were super helpful for understanding 

* Rigidbody2D and how to handle input smoothly, and I also leaned on other creators for things like enemy AI, camera follow scripts, and level transitions, piecing together different techniques until everything clicked and I had a playable prototype.
* Movement & Physics: I followed tutorials on player movement, learning how to implement smooth jumping, gravity, and collision detection. Seeing how others handled things like acceleration and friction helped me fine-tune the feel of the game.
* Level Design: Tutorials on tilemaps and parallax scrolling gave me the tools to build visually interesting levels. I learned how to use layers and triggers to create dynamic environments.
* Animation & Feedback: I used guides to set up sprite animations and add visual feedback—like flashing when the player takes damage or squashing/stretching during jumps.* 
* Game Logic: Tutorials helped me structure my code better, especially when it came to managing states (like idle, running, jumping) and organizing scripts for enemies, collectibles, and checkpoints.
* Polish & UI: I even used tutorials to build menus, HUDs, and transitions. It made the game feel complete and user-friendly.

## Developer Docuementation

## Tilemaps
Whilst this was effective in my game currently I have faced alot of issues that I have resolved with Tilemap slicing, editing and modification.
<img width="448" height="298" alt="image" src="https://github.com/user-attachments/assets/db3dad10-3e09-4d3c-80c0-c87b7cfc6d7e" /> <img width="448" height="298" alt="image" src="https://github.com/user-attachments/assets/6d6d3c1e-0ec4-47f4-80ac-3f82a99a433b" />

<p> Various tile palletes were used for this mostly from the Unity Asset store. The tilemaps in Eco Runner were crafted using a diverse mix of tile palettes, primarily sourced from the Unity Asset Store and supplemented by custom assets provided by my multimedia partner. This hybrid approach allowed for both consistency and creative flexibility—standardized tiles ensured smooth integration with Unity’s grid system, while bespoke textures added thematic depth and uniqueness to the game world. Grass platforms, mossy edges, and layered terrain were carefully selected to evoke a sense of natural regrowth, aligning with the game’s environmental message. Each tile was placed with intention, balancing visual appeal with gameplay clarity, and creating a world that feels both handcrafted and alive. This collaborative asset strategy not only streamlined development but also showcased my ability to integrate external resources into a cohesive, playable environment. The effect was used to mimick the mood and storyline of the game which is directly linked to the background and environment which the player navigates. </p>

<img width="1647" height="345" alt="image" src="https://github.com/user-attachments/assets/aea0a8d2-0039-436b-b6d3-b1ad73c1f02a" />




### Executing program

* How to run the program
* Step-by-step bullets

## UI/ Level Design
🧭 User Interface (UI)
Eco Runner features a clean, intuitive UI designed to support fast-paced platforming while reinforcing the game’s eco-conscious theme.
<img width="989" height="99" alt="image" src="https://github.com/user-attachments/assets/9ae0b431-e5cf-4bba-b226-56eea9c0b7db" />
<img width="911" height="61" alt="image" src="https://github.com/user-attachments/assets/d3f31e5c-f75c-4287-ba39-c6ef7fcd3600" />


HUD Elements:

* Coin Counter (Top Left): Tracks collectible progress in real time.

* Level Indicator (Top Right): Displays current stage for player orientation.

* Time Tracker (Bottom Left): Shows countdown from 90 seconds, adding urgency to each run.

  Visuals:
  
  <img width="206" height="49" alt="image" src="https://github.com/user-attachments/assets/57660840-cfdd-41d9-a30d-3a2ae98599ee" />
<img width="784" height="22" alt="image" src="https://github.com/user-attachments/assets/70b6afd0-3d6d-4ffa-8ede-f2dc9eaac293" />

Kill Screen: UI Time Button Flashes Red when you lose on time:
<img width="990" height="554" alt="image" src="https://github.com/user-attachments/assets/9fda014d-b9b5-4b42-9935-a0bb13d99be8" />


## Pause/Resume Menu:

* Accessible via keyboard or controller input.

* Options include Resume, Restart Level, Settings, and Exit to Main Menu.

* Designed with minimal distraction and fast navigation for younger players.

  ## 🎮 How to Play Eco Runner

Welcome to **Eco Runner** — a fast-paced 2D platformer where you help our hero clean up the planet while dodging obstacles, to a better cleaner world!

### ⚙️ Settings
- **Sound**: Samples in Google Drive,but not implemented yt.
- **Esc*: Pause Menu
- **Language**: English only (for now!)

### 🎯 Objective
- Run through each level collecting **eco-points** by:
  - Picking up collectibles
  - Avoiding spikes/lava
- Reach the **Eco Portal** at the end of each level to progress!

  ## Video
  https://github.com/user-attachments/assets/5d0cbc8c-350d-4228-aa81-f60e1a77b0ec

## Visual Styling:

* UI elements use green tones and organic shapes to reflect the game’s environmental theme.

* Fonts are bold and readable, optimized for players aged 8–15.

## Unity Scripting
<img width="300" height="500" alt="image" src="https://github.com/user-attachments/assets/72d7be63-dbd9-44a4-a270-3692f805cf3e" />
Coin Manager:
<img width="449" height="262" alt="image" src="https://github.com/user-attachments/assets/148e6e7e-fede-4646-aed6-d892be571323" />



The PlayerMovement script is a core component of Eco Runner, responsible for handling dynamic character control in a 2D platformer environment. Written in C# for Unity, it integrates physics-based movement, animation control, and dash mechanics to create a responsive and engaging player experience.

🔧 Key Functionalities
Horizontal Movement & Jumping:

* Controlled via horizontal, speed, and jumpingPower variables.

* Uses Rigidbody2D to apply force-based movement, ensuring smooth physics interactions.

* Ground detection is handled via groundCheck and groundLayer, allowing for accurate jump conditions.

Dash Mechanic:

* Includes variables for dashingPower, dashingTime, and dashingCooldown.

* Boolean flags (canDash, isDashing) manage dash availability and state.

* TrailRenderer adds visual feedback during dashing, enhancing player immersion.

Facing Direction:

* isFacingRight tracks player orientation, enabling sprite flipping for left/right movement.

* This ensures animations and movement remain visually consistent.

Animation Integration:

* The Animator component is initialized and used to trigger movement and dash animations based on player input and state.

 Coin Manager Reference:

* The public CoinManager cm

  ## Animation:
  Here it is: Saved in the Repository
   [Gif of Coin Animation](Assets/CTread.mefile)

  <img width="259" height="200" alt="image" src="https://github.com/user-attachments/assets/eb2407b5-fe26-436a-aea3-58679f7df4b7" />            <img width="225" height="225" alt="image" src="https://github.com/user-attachments/assets/de37bb9a-9b74-479c-b861-bf3ce5dbb83a" />


| Command | Attached Animations |
| --- | --- |
| `Jumping` | ![Recording 2025-11-07 145549](https://github.com/user-attachments/assets/35b4d1bb-4d81-428c-bddd-7d9a90e9cf97)|
| `Idle`    | ![Recording 2025-11-07 145549](https://github.com/user-attachments/assets/bdf45f80-3723-440b-a8de-95e05cad0259)| 
| `Running` | ![Recording 2025-11-07 145549](https://github.com/user-attachments/assets/9e30cc72-16df-41dd-9667-4c56d54b4487)|


  ##  Level 2:
Level 2 of Eco Runner remains partially developed due to time constraints and asset limitations. While a basic boss entity was successfully implemented using foundational physics mechanics (e.g., collision detection, movement patterns), the broader level environment could not be fully realized. Initial sprite contributions from my multimedia partner—particularly for dirt tiles and floating islands—lacked the visual depth and polish required to maintain consistency with the game’s aesthetic. These assets appeared flat and under-detailed, which impacted immersion and gameplay clarity. To address this, I sourced higher-quality tilemaps and environmental textures from the Unity Asset Store, ensuring a more cohesive and professional look. This decision reflects my commitment to visual fidelity and player experience, even when working within collaborative or time-bound constraints
  <img width="993" height="555" alt="image" src="https://github.com/user-attachments/assets/ce1bfe8d-d565-4615-87a8-c9a594595df8" />
Boss:
Level 2 was meant to be a turning point in the game — a shift in tone, difficulty, and narrative tension. The environment was more dynamic, with layered backgrounds and tighter platforming challenges. I had planned for the level to culminate in a final boss encounter that would test everything the player had learned so far.

Unfortunately, I couldn’t implement the final boss sprite in time. The concept was there — I had the design sketched out and the mechanics partially mapped — but the sprite itself never made it into the build. There were a few reasons: some technical hiccups with the animation controller, a mismatch between the sprite dimensions and the hitbox setup, and honestly, a crunch on time that forced me to prioritize core gameplay over polish.

As a result, the level ends without the boss fight I’d envisioned. It’s a bit abrupt, and I know it leaves a gap in the pacing. But I still see Level 2 as a strong foundation — the buildup is there, and the placeholder ending gives me room to expand in future updates. The boss sprite is still on my list, and once it’s properly rigged and animated, I’ll be able to deliver the climax this level deserves.
<img width="341" height="127" alt="image" src="https://github.com/user-attachments/assets/f2715c5c-bc26-468c-a6c3-6ec066a2f036" />
<img width="116" height="114" alt="image" src="https://github.com/user-attachments/assets/17791982-2890-4746-be8e-66ccd0051cc2" />

## Interactions/ Animations:
⚙️ Settings
Sound: Currently unavaialable, but will be added later on.

Level: After passing the first level, you will transition into the unfinished second level.

Pause/Resume Menu: Press Esc to transition into Pause State, then click the Resume button to continue from once you were. You will be able to use the Quit game button after the game has been published like a file or released on a platform like Steam. 

Fullscreen: Press F to toggle

# Visuals
<img width="400" height="266" alt="image" src="https://github.com/user-attachments/assets/fad7218b-b859-404f-86f0-e6eabcf144ad" />
<img width="400" height="556" alt="image" src="https://github.com/user-attachments/assets/035035b1-307d-4ab6-a1f8-189c45c68afe" />

## Folio
[Link](file:///C:/Users/nipun/Downloads/Games%20For%20Change%20Computer%20Technology%20Folio%201.pdf)

```
code blocks for commands
```
## Outstanding Elements
Multimedia Partner did deliver with the a few sprites e.g Protagonist. However some of them lacked detail anddid not satisfy what I wanted to build and achieve. That's why I went to Unity Asset store and utilised their free online assets, resources and tile maps.

## Help

Any advise for common problems or issues.
```
command to run if program contains helper info
```
## Developer Notes 
Eco Runner is a solo-developed 2D platformer built to showcase my skills in game design, animation direction, and technical documentation. It was created using Unity and integrates custom UI, layered parallax backgrounds, and interactive level design.

🔧 Skills Demonstrated
*Game Mechanics: Implemented movement physics, collision detection, and environmental hazards
* Animation Direction: Designed and animated title screen, player sprite, and UI transitions
*Asset Integration: Ethically sourced and credited third-party assets; directed original art creation
*Documentation: Produced README.md and developer notes with markdown formatting and embedded media
Environmental theme: Promotes sustainability through gameplay.

Original art direction: Player sprite, & backgrounds designed in collaboration with <b>Grace Tun </b>. 

### 🔧 Technical Overview
- **Engine**: Unity 2D
- **Language**: C#
- **Mechanics**:
  - Object collision and physics
  - Score tracking and level progression
  - Advanced game mechanic features
- **UI/UX**: Custom menus & interactions, pause system, and animations
Creative Direction: Led visual storytelling and level pacing, including boss design (pending implementation)

## Authors
🎨 Art Credits
Special thanks to <b>Grace Tun</b> for contributing original character and environment sprites. All other assets are in the ICT Google Drive.
Fonts: Unity Default Fonts (license)
2. [Google Drive]((https://drive.google.com/drive/folders/1QtWtYFmIMr_mU8awDUPdXL4bAkqxSrwl)).
### Visuals & Tilemaps
<img width="133" height="131" alt="image" src="https://github.com/user-attachments/assets/facbc2f4-bea4-4ed2-86fe-ba3a34673f9a" /> <img width="132" height="130" alt="image" src="https://github.com/user-attachments/assets/913a5775-4afa-4ba7-b1fa-2f6ffb7eddf4" />
<img width="132" height="124" alt="image" src="https://github.com/user-attachments/assets/6021a0a0-f5d6-4c72-82e1-d42281984b03" /> <img width="152" height="49" alt="image" src="https://github.com/user-attachments/assets/47ffefc0-be65-437a-a526-f63da8bb2d50" />

Here is one variation of the tilemap that I used for Level 1:
<img width="174" height="68" alt="image" src="https://github.com/user-attachments/assets/cd594610-6f54-48a4-bb27-c39227bbcb8c" />


Contributors names and contact info

Name: Zaif Khan & Grace Tun
Work Email: zaif.khan@education.nsw.gov.au

## Version History *(Optional)

This is avaiable in VS Code, where regular commits were made for the production of the game. It can also be viewed on Github

## License

This project is licensed under the [Zaif Khan] License - see the LICENSE.md file for details

## Acknowledgments

Inspiration, code snippets, etc.
* [Github md syntax](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)
* [TempeHS Unity template](https://github.com/TempeHS/TempeHS_Unity_DevContainer)
