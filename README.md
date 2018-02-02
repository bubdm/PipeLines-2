 # PipeLines
PipeLines
A small WPF game project: the aim is to create a pipeline from the starting point to the finishing pipes.

The game currently contains 9 levels.

The result is not hard coded by levels, it will be checked after every movement by a recursive algorithm. 
A level is solved, when the water can flow from the start to the two finishing points and every pipeitem is used.

## Controls:
  - Left-click holded: horizontal movement
  - Right-click holded: vertical movement
 
## Animation:
  - it will run, when a level is solved
  - it uses opacitymask animation with blue background for every item types
  - the pipeitems use semi-transparent images for this purpose
  
## Screenshots:
### Main menu

![main](https://user-images.githubusercontent.com/25585771/35730196-70ac3ee2-0811-11e8-80ac-44488024b746.jpg)

### Game level starting state

![first](https://user-images.githubusercontent.com/25585771/35730195-708cb568-0811-11e8-8d40-dfecd5df2e8f.jpg)

### Game level completed state

![second](https://user-images.githubusercontent.com/25585771/35730197-70cd7ea4-0811-11e8-90b0-f0d94366da4d.jpg)
