# Infinite-Overflow

Make sure to use Unreal Engine 4.23.1

### Game link
[https://daelinc.itch.io/infinite-overflow?secret=VPLiYWh7rkAMdgx8STZrSHCcduY](https://daelinc.itch.io/infinite-overflow?secret=VPLiYWh7rkAMdgx8STZrSHCcduY)

### Setup for dev

1. Download [Epic Games Launcher](https://store.epicgames.com/en-US/download)
2. Login to Epic Games with any provider
3. Go to the `Unreal Engine` tab on the left
4. Click `Install Engine` on the top right
5. When the window pops up, click `cancel`
6. In the `Library` tab, click the drowdown next to the version 5.x.x and `delete`
7. Click the `+` button to add a new engine
8. Change the version to `4.23.1` (Required to build for HTML) and `install`
9. Once downloaded and istalled, you can open the `Infinie_Overflow.uproject` file in the engine

### Create a new level

1. Navigate to `Content/Levels` in the `Content Browser` (Bottom of the window)
2. Right click on `Template` and duplicate it (or `Ctrl+W`)
3. Give your new level and name
4. Double click the new level to open it and generate BuildData

## About the template

The template is a very basic level that includes the character (`2DSideScrollerCharacter`), a level end object (`End`) and a play area. New objects can be dragged into the play area to add them. Objects can also be moved around.

## Creating new objects

1. Navigate to the `2DSideScroller/Objects` folder in the `Content Browser`
2. Right click in the open space and under `Create basic Asset`, select `Blueprint Class`
3. In the next window, click `Actor`
4. Give your object a name
5. Double click the blueprint class to open it.
6. Here you can add components to the object by clicking the `Add Component` button in the top left
7. Change to the `Viewport` tab to see what your object looks like and move/scale the components

## Importing objects

1. Navigate to the `2DSideScroller/Objects` folder in the `Content Browser`
2. Right click in the open space and select `Import to ...`

### Play in the editor

1. Open the level you would like to play from the `Content Browser`
2. Click the `Play` icon in the top action bar

### Play HTML locally

1. Open HTML5LaunchHelper.exe
2. Click on index.html
