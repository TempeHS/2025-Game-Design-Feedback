# Shutter

Singleplayer Photograghy game :camera:


![alt text](<Images/Screenshot 2025-10-27 at 8.50.12 PM.png>)

Made with Unity

## Overview

Shutter is a retro-style, singleplayer story game that focuses on the player's lonely journey as a war photographer. With a big focus on narrative and exploration, Shutter has the player navigating a desolate, war-torn environment, documenting the events of the environment by taking photographs. A complete narrative is uncovered by the player the more they discover and explore in the world of Shutter. 


## Getting Started

### Hardware Requirements :computer:

Shutter is available (and will be available on release) for:

* Windows 10/11
* Linux
* MacOS

### Installing

Although the game is not yet in a finished state, and for those reasons does not have an official download package, the most recent version can still be downloaded here from github and can be imported into unity as a project file for a playable experience. When the game is finished development, which should be in 5-10 weeks, it will be available for download on steam for about 3$.


### Controls

| Keybinds  | Actions |
| ------------- | ------------- |
| Right Mouse  | Zoom in camera  |
| Left Mouse | Take photo  |
| E | Enter Van |
| W | Move Forward |
| A | Move Left |
| S | Move Back |
| D | Move Right |


## Gameplay :video_game:

### Objective

![Alt text](Images/gamedemovid1.gif)

The main objective of Shutter is to gather photos of relevant areas on the map. These areas of interest are mainly depictions of war crimes and atrocities, which the player must take clear photographs of to document the conflict. If you do not photograph/discover enough areas of interest within the time frame given in-game, the player has to restart the chapter.

### Progression

![Alt text](Images/gameDemoVid2.gif)

In Shutter, you progress the linear narrative of the story by taking photos of particular locations on the map. The player will have 3 days, each with fifteen minutes of playtime to explore and discover photographable areas. If all areas are not found, the game is reset to the beggining of that chapter, for the player to re-attempt. If all areas are photographed succesfully, a cutscene will play and the game will progress to the next chapter in the narrative.



## Story :book:

![alt text](<Images/Screenshot 2025-10-27 at 8.51.26 PM.png>)

The game's storyline is based off of a certain, current middle eastern conflict. At the beggining of a playthrough, the prevailing narrative will be that a terrorist organisation has attacked a large nation, and this nation has then pushed them far back into their own country, poised for victory. The player is situated alone, far behind the front lines in the aftermath of the advance. The scenes of violence and destruction found by the player are initially thought to be the work of the terrorists, but are soon discovered to be the work of the advancing army, the narrative unraveling to reveal the occupying/advancing army to have started the war.



## Authors

This project was created by Axel Clark and Luka Davies. 


Game engine and programming by me, myself, and I Axel.

Art, story, and world design by Luka.

Special thanks to Mr Jones ([@benpaddlejones](https://github.com/benpaddlejones)), our software engineering teacher.



## Version History & Fixes

Due to the sheer number of disorganized and unreadable commits on this project, a full explanation of each version will not be possible. The following is instead some examples of development milestones:

### Low-Res Filter & Skybox
In the early stages of development, shutter used a low-res "render texture" in unity to achieve the retro, low resolution look. This worked well, but the only issue was the fact that the render texture only picked up 3d objects with the filter, meaning that the skybox just came through as a black void during gameplay. A temporary fix to this was making the skybox an actual 3d model, but this resulted in numerous visual bugs and glitches in the sky. 

![!\[Alt text\](image.png)](Images/image.png)

At the current stage of development, the low resolution look has been achieved with a coded resolution filter for all in game objects, which not only removes the need for a finnicky 3d skybox, but is more performant as well.

### Screen-Size & Resolution Bug
For a long period of time, the game was exclusively being developed on 1080p resolution, and becasue of this we did not realise that the UI elements were set to "scale with screen size, meaning that they could unreliably change size and shape depending on the screen resolution, which was not ideal.

![Alt text](Images/UIexample.png)

This was fixed by setting the screen to a constant 1080p resolution and screen size, meaning that the game can be operated at any screen size in fullscreen mode without any change to the placing of the UI elements.

### Full Commit History
For the full version history and original commits, see [commit change](https://github.com/TempeHS/2025CT_Axel.C_name/commits/main/).



## License

This project is licensed under the [GPL-3.0](LICENSE) License - see the LICENSE.md file for details

## Acknowledgments

Thanks for reading! :kiss:

* [Copilot](https://copilot.microsoft.com/), no modern video game would be complete without abuse of AI and its spaghetti code

* [Github md syntax](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax), this was a basic github provided guide on how to write this ReadMe

* [TempeHS Unity template](https://github.com/TempeHS/TempeHS_Unity_DevContainer), this unity template and related lessons were the framework for Shutter
