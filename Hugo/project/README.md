<h1 align=center> Platformer for Computer Technologies 2025 - Godhood

<h3 align=center> Hugo Brown

## Table of Contents
- Demo
- Map
- Description
- Story
- Level Design
- Keyboard and Mouse Controls
- Features
  - Jump, Double Jump, Variable Jump Height and Gravity
  - Player Tracking Camera
  - Obstacles/Hazards
  - Future Development for My Game
- Authors
- License
- Acknowledgments
  - Sprite Sheet by Kenney
  - Youtube Tutorial by Game Code Library
  - Youtube Tutorial by Bluecap

## Demo
![gameshowcaseworking](https://github.com/user-attachments/assets/5c43f733-988e-4d56-b50d-2b76dde4b898)

This is a short demo showing all the features I have created in my game thus far.

## Map
<img width="1567" height="765" alt="image" src="https://github.com/user-attachments/assets/0fd679f6-88c8-48e9-8785-4ecb10a436d4" />

Here is a map of the level I have created, showing a few placeholders for powerups and the unfinished static obstacles.

## Description

This game was intended to become a 2d platformer metroidvania with roguelike inspired by games like and Hollow Knight and Dead Cells. It was intended to have a complex upgradeable movement and ability to progress that were attained from different characters in a similar way to the progression of Hades. The main features I wanted to add out outlines in the "Features" section below. In addition I wanted to add a combat system with various ability paths based on the characters in the game you choose to interact with. I would have liked to add enemies that use abilities similar to the players for its relevance to the story which I'll explain in the next section.

### Story

The story follows a young developing god gaining independence from its creators which are older, more powerful gods. The creator gods are cruel to the developing god prompting the character to denounce the abilities given to them by the creator god, moving the player on a path to independence and founding of their own ability. The player achieves this through developing their own powers channeled through the godly essence they possess and also through the assistance of side characters which give the character more specified abilities. 

### Level Design

The levels in this game were intended to occur based on the abilities the player has picked up, meaning the player has to use the unique abilities given to them to progress. The main form of enemy is summoned by the older gods in occasional encounters throughout the levels, having a spawn function and coming in waves in a type of enemy gauntlet. At the same time there would be static obstacles in the levels that require the unique movement features to get past. There would also be powerups in the level that last for a short duration of time.

## Keyboard and Mouse Controls

| Action        | Output                              |
| ------------- | ----------------------------------- |
| **A**         | Move Left                           |
| **D**         | Move Right                          |
| **W**         | Jump                                |
| **W x2**      | Double Jump                         |

## Features

- [x] :arrow_up:Jump
- [x] :arrow_double_up:Double Jump
- [x] :arrow_heading_up:Variable Jump Height
- [x] :arrow_down:Gravity
- [x] 🧱Ground and Wall Surfaces
- [x] :movie_camera:Player Tracking Camera
- [ ] :sagittarius:Wallslide and Walljump
- [ ] :star:Power-ups
- [ ] :skull:Death/Respawn System
- [ ] :purple_heart:Health
- [ ] :fried_shrimp:Collectables
- [ ] :rage:Enemies
- [ ] :no_entry_sign:Obstacles/Hazards

## Physics Controls
<img width="953" height="663" alt="image" src="https://github.com/user-attachments/assets/9944915f-1dd6-40d7-a04a-90546b1ec4ba" />

This screenshot shows the easy to change physics values to determine the player's movement. It creates a smooth and responsive system, with some medium speed values to keep the movement in an easy to control state and somewhat low gravity to keep the movement feeling bouncy. It is also easy to modify the amount of jumps and other values which can be a good framework for a powerup system in future. 

## Jump, Double Jump, Variable Jump Height and Gravity
<img width="901" height="425" alt="image" src="https://github.com/user-attachments/assets/b9b36b9c-fe3c-4d27-9b11-4f5e7b70875b" />

I have used gravity combined with a MaxFallspeed function to make jumping more responsive, with longer taps of the W key creating a higher jump. It does this by adding force on a Vector2 function to push the player in a direction.

## Player Tracking Camera
<img width="698" height="327" alt="image" src="https://github.com/user-attachments/assets/724d855c-65bf-4272-9dea-894bd729db82" />

I used the packages on unity to take a smooth camera function without using any janky code. It follows the player at all times.

## Obstacles/Hazards
<img width="565" height="329" alt="image" src="https://github.com/user-attachments/assets/6a66171d-5364-41b1-a626-fbf333b29416" />

Using the platformer asset pack by Kenney, I have multiple designs for spikes and other obstacles. I intended for these to create difficult platforming courses partially inspired by Geometry Dash.

## Future Development for My Game
I would like to add all the features not yet ticked off in the features list, and some npc's that give you specific abilities. Adding some enemies that have a spawning system based off the older god characters is also something I wanted to add. 

## Authors
Hugo Brown - Developer
[@ComputerChip16](https://github.com/ComputerChip16)

## License

This project is licensed under the [Hugo Brown] License - see the LICENSE.md file for details

## Acknowledgments
### Sprite Sheet by Kenney
https://www.kenney.nl/assets/1-bit-platformer-pack

### Youtube Tutorial by Game Code Library
https://www.youtube.com/watch?v=Pkc4A1ukbJU

### Youtube Tutorial by Bluecap
https://www.youtube.com/watch?v=7CAc5OyQCFc
