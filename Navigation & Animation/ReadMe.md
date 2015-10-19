
Part1: Navigation
Description:
>The agents (capsule) can be selected by clicking the mouse and turn black when selected. When several >agents are selected, click a destination by mouse and they will turn white again and move there automatically;
The normal obstacles (cubes) can be moved by arrow keys when selected (turn black) by mouse.
The devils (cylinders) are obstacles which moving automatically.
Questions:
8. When “carve” is turned on, the obstacle will carve hole in the NavMesh, so the agent will recognize it when plotting a path. If it is turned off, the obstacle will only influence avoidance behavior of the agents, NavMesh and pathfinding will not be influenced.
a. Make all obstacles carving: The path will be changed whenever the obstacles move.
b. Make all obstacles not carving: The agent cannot arrive the goal if the obstacle created a narrow gap (less than agent’s width) on the path of agent.
9. We can mark the area where the agent collided with other obstacles by comparing the distance between agent and obstacles and the sum of their radius. Then we avoid the area when searching for a path.
Part2: Animation
Description:
The humanoid character (Teddy) can be moved by WASD/Arrows for default walking forward and backward. Press left shift, it will sprint; press space, it will jump. In both walking and sprinting condition, the agent could turn right or left with the call of directions.
Part3: Coupling Navigation and Animation
Description:
Similar to part1, agents could automatically go to the destination but the difference is that agents are animated according to the navigation.
The selected bear can switch between run and walk by press and release left shift key. It can also jump when meeting off mesh links (between different surfaces).
Links:
Demo part1: https://dl.dropboxusercontent.com/s/kd12ti64aamuhxh/B1_part1.html Demo part2: https://dl.dropboxusercontent.com/s/thg5rlfehnvzclx/B1_part2.html Demo part3: https://dl.dropboxusercontent.com/s/4abdx8lug13vfcs/B1_part3.html Demo combine: https://dl.dropboxusercontent.com/s/jlsshbrf8jopf09/B1_combine.html
Blogger: http://graphicgroup12.blogspot.com
Extra credit:
Part1.10: The devils are cylinders and can move between two points. If carving, the agents will find new path frequently because the NavMesh will be different every time the devils move.
Submission.5: The menu scene contains scene1, scene2, scene3 corresponding to the three assignments. When click one of them, the current scene will be switched to the corresponding scene, and when click menu on the bottom left corner, the scene will come back to menu scene.
