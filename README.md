# CopseArena-Game

Solo Project Creator: Kyle Russell

--------------------------------------
Description: The Copse arena is an RPG based around combat and story. The idea of the game is to be entirely based in one arena. The player starts being able to pick one of three characters: Korat the Brave, Shalidar the Snake or Menesa the Mystical. The game is designed on the fundamentals of mass replay ability. So, depending on which character you pick the players should feel as if he is playing a different game. Each character will interact with NPC’s differently both in and out of combat. Each fighter is designed to involve different strategies to defeat their opponent. Out of combat there will be different dialogue depending on which NPC is interacted with as everyone in the arena foyer (The Roots) will treat each character differently. The idea behind having dialogue playing a major part in the game is to break the game into two key components. The first being combat and the second being story. Each character has their own motivations for wanting to become the champion of the arena.

--------------------------------------
Current Run Instructions
- Download Unity/Open unity
- Click 'Open' (Top right corner)
- Find CopseArena-Game location highlight then click 'select folder'
- In the middle at the top click the play button

--------------------------------------
Directory layout
(For the sake of explanation I will be ignoring/marking all folders/files that I didn't create just to mark out assembly stuff)

- Root/CopseArena-Game: Core folder of the project

- Root/CopseArena-Game/Assets: This folder contains most of the project.
    Root/CopseArena-Game/Assets/Animations: This folder contrains animations for characters sprites within the game
    Root/CopseArena-Game/Assets/Art: This contains Game art: Such as Spritesheets and general sprite art as well as any other               miscellaneous art
    Root/CopseArena-Game/Assets/Audio: Contains Game Audio
    Root/CopseArena-Game/Assets/Maps: Contains Game Maps (Scenes where the game is played out such as the overworld) However these
    maps are most likely located at Root/CopseArena-Game/Assets/Tiled2Unity since this is the program that exports these maps and           automatically puts them here
    Root/CopseArena-Game/Assets/Materials: Contains materials for image assets (Largely unused since this is a 2D game except one           material which helped solve a clipping issue
    Root/CopseArena-Game/Assets/Scenes: These are the scenes from which the game is played out. EG Overworld scene, main menu etc.
    Root/CopseArena-Game/Assets/Scripts: The code scripts which make the game run! All of the coding is practically found here
    Root/CopseArena-Game/Assets/Tiled2Unity: This folder is third party addon of Unity which helps create tile maps, all the tiled maps     are located at Root/CopseArena-Game/Assets/Tiled2Unity/Prefabs
    
- Root/CopseArena-Game/Copse Arena: An old version which contains original files

- Root/CopseArena-Game/Library: Unity package stuff (Nothing I made here)

- Root/CopseArena-Game/Maps: Some Tiled stuff here (Program that helps make the scenes for the game) Just the maps

- Root/CopseArena-Game/obj: Unity package stuff (Nothing I made here)

- Root/CopseArena-Game/ProjectSettings: Unity package stuff (Nothing I made here)

- Root/CopseArena-Game/tilesets: Tilesets that were used to create the overworld for this game

--------------------------------------

# Henry comments 13/April
- Not enough commits + changelog items to pass at this frequency.
- I couldn't find your text-based data. Create a root folder "data/" and put all your JSON files in there.


--------------------------------------
Github Link: https://github.com/karussel/CopseArena-Game/edit/master/README.md
