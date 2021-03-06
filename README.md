# TrekSharp
TrekSharp is a Blazor WebAssembly project designed to create tools for assisting players of Modiphius's <a href="https://www.modiphius.net/collections/star-trek-adventures" target="_blank"> Star Trek Adventures </a> Tabletop RPG. This repository is grouped into three directories, `TrekSharp` contains the core classes and data-structures, `TrekSharp.AdventureTools` contains the actual Blazor application and `TrekSharp.Godot` contains Godot game engine apps which are integrated into the Blazor application for some of the more "interactive" components. 

## License
This site is intended for personal and non-profit use only and is not sponsored, sanctioned, or affiliated with CBS Studios Inc., Paramount Pictures, Modiphius Entertainment, or the STAR TREK franchise. No copyright infringement is intended through the display of content on this site. Any copyrighted material is included under "fair use" principles. The Star Trek® franchise and related logos are owned by and are a registered trademark of Paramount Pictures & CBS Studios Inc. All Rights Reserved by their respective owners.

The code in this project is licensed under the following [LICENSE](LICENSE).

- [TrekSharp](#treksharp)
  - [License](#license)
  - [Usage](#usage)
    - [Saving and Loading](#saving-and-loading)
    - [Tool-shelf](#tool-shelf)
      - [Momentum and Threat](#momentum-and-threat)
      - [Dice Rolling](#dice-rolling)
    - [Asset Creation](#asset-creation)
      - [Plot](#plot)
      - [Character Creator](#character-creator)
      - [Ship Creator](#ship-creator)
      - [Support Creator](#support-creator)
      - [Battle Grid](#battle-grid)
    - [Management](#management)
      - [Characters](#characters)
      - [Ships](#ships)
      - [Extended Tasks](#extended-tasks)
    - [Calculators](#calculators)
      - [Stardate](#stardate)
      - [Warp Speed](#warp-speed)

## Usage
### Saving and Loading
Some app data such as characters, ships, momentum, and extended tasks can be persisted between app sessions. On the bottom left of the left-hand side navigation panel the save and load buttons can be found. The save button will encode the app state as a JSON object and trigger a download of the JSON file. The load button will allow you to copy the contents of a saved JSON file into the app and use that as the current state instead. This is a little clunky, as loading requires copying the contents of the JSON file into a text-box, but it was easy to implement. 

### Tool-shelf
#### Momentum and Threat
Momentum and Threat counts can be managed in the tool-shelf. Open the tool-shelf on the right hand side of the app to access the Momentum and Threat counts. These values persist between pages and can be incremented and reduced to keep track of these tokens during sessions. 

#### Dice Rolling
A dice-rolling panel can be accessed within the tool-shelf which can be opened from the right hand side of the app. Along the bottom of the panel is three different dice buttons. These represent the challenge dice, a regular d6, and a d20. Clicking any of these button will place that die into the centre of the panel and automatically roll it. On the bottom right of the panel the 'clr' button will remove all dice from the dice panel and the 're-roll' button will re-roll all of the dice in the dice panel. The total count of all rolled dice as well as any effects from challenge dice are displayed along the top.

### Asset Creation
#### Plot
The plot generator randomly generates plot ideas for GMs. These random plots are single sentences describing generalized ideas and are not meant to encompass every plot point.

#### Character Creator
The character creator can be accessed by the navigation bar along the left hand side of the app. This tool is used to create player characters. Navigate between the steps of the character creator using the 'Back' and 'Next' button running along the bottom of each page. Please fill out all fields for each step before continuing to the next step. Additionally, while you can use the 'Back' button to return to the first step of the creator, it is better to navigate to a different page and then back to the character creator to completely reset the state of the character creator. 

#### Ship Creator
The ship creator can be accessed by the navigation bar along the left hand side of the app. The ship creator operates similarly to the character creator, but is used for creating player vessels. 

#### Support Creator
The support character creator can be accessed by the navigation bar along the left hand side of the app. The support creator operates similarly to the character creator, but is used for creating support characters rather than for player characters. 

#### Battle Grid
You can create battle grids for both space battles and starship interior combat using this creator. For space battle grids simply select a background image (nebula, asteroid belt...) and choose what kind of grid overlay you would like. For starship interiors, you can use a Godot app which allows for rooms and hallways to be snapped together to construct larger interior spaces. 

### Management
#### Characters
Shows a list of all player, support, and npc characters created within the app. Clicking any character will load up a printable character sheet for that character. 

#### Ships
Shows a list of all player ships created within the app. Clicking any ship will load up a printable ship sheet for that vessel.

#### Extended Tasks
This tool is useful for GMs to be able to keep track of player progress for Extended Tasks. Create a new task using the "New Task +" button. Set the name, difficulty, magnitude, resistance, and work track size for the task. Use the '+' button at the bottom of the task to add work to the task. This follows the rules for extended tasks by first taking off the resistance, then applying breakthroughs if the work track is empty or if more than 5 points are added to the work track.

### Calculators
#### Stardate
The stardate calculator allows for conversion to and from TNG style stardates to gregorian calendar dates.

#### Warp Speed
The warp speed calculator allows for calculations as to the speed of a given warp factor as well as the amount of time taken at that warp factor to cover a given number of light years. 